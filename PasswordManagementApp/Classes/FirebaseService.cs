using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using System;
using System.Threading.Tasks;

namespace FirebaseProject.Classes
{
    internal class FirebaseService
    {
        // Constructor - Used to initialize the Firebase service
        public FirebaseService(string credentialsPath)
        {
            InitializeFirebase(credentialsPath);  // Calls the function to initialize Firebase
        }

        // Function to initialize the Firebase app
        private void InitializeFirebase(string credentialsPath)
        {
            // Checks if FirebaseApp already exists before starting it
            if (FirebaseApp.DefaultInstance == null)
            {
                // Initialize the Firebase app
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile(credentialsPath),  // Loads Google credentials from a file
                });
            }
        }

        // Function to create a new user
        public async Task<string> CreateUserAsync(string email, string password)
        {
            try
            {
                // Prepares the arguments needed to create a user
                UserRecordArgs args = new UserRecordArgs()
                {
                    Email = email,
                    Password = password,
                };

                // Creates a new user using Firebase Auth
                UserRecord userRecord = await FirebaseAuth.DefaultInstance.CreateUserAsync(args);

                // Returns the user's Uid
                return userRecord.Uid;
            }
            catch (Exception ex)
            {
                // Throws an error with a custom message in case of failure
                throw new Exception($"User creation error: {ex.Message}");
            }
        }
    }
}
