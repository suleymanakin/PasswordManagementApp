using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using System;
using System.Threading.Tasks;

namespace FirebaseProject.Classes
{
    internal class FirebaseService
    {
        public FirebaseService(string credentialsPath)
        {
            InitializeFirebase(credentialsPath);
        }

        private void InitializeFirebase(string credentialsPath)
        {
            // FirebaseApp'ı başlatmak için önce var olup olmadığını kontrol edin
            if (FirebaseApp.DefaultInstance == null)
            {
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile(credentialsPath),
                });
            }
        }

        public async Task<string> CreateUserAsync(string email, string password)
        {
            try
            {
                UserRecordArgs args = new UserRecordArgs()
                {
                    Email = email,
                    Password = password,

                };
                UserRecord userRecord = await FirebaseAuth.DefaultInstance.CreateUserAsync(args);
                return userRecord.Uid;
            }
            catch (Exception ex)
            {
                throw new Exception($"User creation error: {ex.Message}");
            }
        }
    }
}
