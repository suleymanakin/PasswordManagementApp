using Google.Cloud.Firestore;
using PasswordManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class UserDataService
{
    private readonly FirestoreDb firestoreDb;
    private string SaveID;
    public static string? UserId { get; private set; }
    public static string? UserEmail { get; private set; }

    public UserDataService(string credentialsPath, string projectId)
    {
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credentialsPath);
        firestoreDb = FirestoreDb.Create(projectId);
    }

    public void SetUserCredentials(string userId, string userEmail)
    {
        UserId = userId;
        UserEmail = userEmail;
    }

    public async Task StoreUserPasswordAsync(string saveId, string platformName, string userName, string email, string website, string password)
    {
        try
        {
            if (string.IsNullOrEmpty(UserEmail))
                throw new Exception("Kullanıcı e-posta adresi mevcut değil.");

            CollectionReference userCollection = firestoreDb.Collection(UserEmail);
            DocumentReference passwordDocRef = userCollection.Document(saveId);
            EncryptionHelper encryptionHelper = new EncryptionHelper();

            MessageBox.Show(saveId);

            var passwordData = new Dictionary<string, object>
            {
                { "PasswordID", encryptionHelper.Encrypt(saveId) },
                { "PlatformName",encryptionHelper.Encrypt( platformName) },
                { "UserName", encryptionHelper.Encrypt(userName) },
                { "Email", encryptionHelper.Encrypt(email) },
                { "Website", encryptionHelper.Encrypt(website) },
                { "Password", encryptionHelper.Encrypt(password) }
            };

            await passwordDocRef.SetAsync(passwordData);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Veri kaydetme hatası: {ex.Message}");
            throw;
        }
    }

    public async Task<List<Dictionary<string, object>>> GetUserPasswordsAsync()
    {
        try
        {
            if (string.IsNullOrEmpty(UserEmail))
                throw new Exception("Kullanıcı e-posta adresi mevcut değil.");

            CollectionReference userCollection = firestoreDb.Collection(UserEmail);
            QuerySnapshot snapshot = await userCollection.GetSnapshotAsync();

            var passwordList = new List<Dictionary<string, object>>();
            EncryptionHelper encryptionHelper = new EncryptionHelper();

            foreach (var document in snapshot.Documents)
            {
                var decryptedData = new Dictionary<string, object>
                {
                    { "PasswordID", encryptionHelper.Decrypt(document.GetValue<string>("PasswordID")) },
                    { "PlatformName", encryptionHelper.Decrypt(document.GetValue<string>("PlatformName")) },
                    { "UserName", encryptionHelper.Decrypt(document.GetValue<string>("UserName")) },
                    { "Email", encryptionHelper.Decrypt(document.GetValue<string>("Email")) },
                    { "Website", encryptionHelper.Decrypt(document.GetValue<string>("Website")) },
                    { "Password", encryptionHelper.Decrypt(document.GetValue<string>("Password")) }
                };

                passwordList.Add(decryptedData);
            }

            return passwordList;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Veri alma hatası: {ex.Message}");
            throw;
        }
    }

    public async Task<bool> UpdateUserPasswordsAsync(string passwordID, string platformName, string username, string email, string website, string password)
    {
        try
        {
            if (string.IsNullOrEmpty(UserEmail))
                throw new Exception("Kullanıcı e-posta adresi mevcut değil.");

            CollectionReference userCollection = firestoreDb.Collection(UserEmail);
            QuerySnapshot snapshot = await userCollection.GetSnapshotAsync();
            EncryptionHelper encryptionHelper = new EncryptionHelper();

            var updatedData = new Dictionary<string, object>
        {
            { "PasswordID", encryptionHelper.Encrypt(passwordID) },
            { "PlatformName", encryptionHelper.Encrypt(platformName) },
            { "UserName", encryptionHelper.Encrypt(username) },
            { "Email", encryptionHelper.Encrypt(email) },
            { "Website", encryptionHelper.Encrypt(website) },
            { "Password", encryptionHelper.Encrypt(password) }
        };

            bool isUpdated = false;

            foreach (var document in snapshot.Documents)
            {
                // Veritabanındaki şifrelenmiş veriyi çöz
                string decryptedPasswordID = encryptionHelper.Decrypt(document.GetValue<string>("PasswordID"));

                // Çözülen veri ile karşılaştırma yap
                if (decryptedPasswordID == passwordID)
                {
                    DocumentReference docRef = userCollection.Document(document.Id);
                    await docRef.UpdateAsync(updatedData);
                    MessageBox.Show("Güncelleme işlemi başarılı!");
                    isUpdated = true;
                    break; // Güncelleme işlemi başarılıysa döngüden çık
                }
            }

            if (!isUpdated)
            {
                MessageBox.Show("Güncellenecek kayıt bulunamadı.");
            }

            return isUpdated;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Güncelleme hatası: {ex.Message}");
            throw;
        }
    }

    public async Task<bool> DeleteUserPasswordAsync(string passwordID)
    {
        try
        {
            if (string.IsNullOrEmpty(UserEmail))
                throw new Exception("Kullanıcı e-posta adresi mevcut değil.");

            CollectionReference userCollection = firestoreDb.Collection(UserEmail);
            QuerySnapshot snapshot = await userCollection.GetSnapshotAsync();
            EncryptionHelper encryptionHelper = new EncryptionHelper();

            bool isDeleted = false;

            foreach (var document in snapshot.Documents)
            {
                // Veritabanındaki şifrelenmiş veriyi çöz
                string decryptedPasswordID = encryptionHelper.Decrypt(document.GetValue<string>("PasswordID"));

                // Çözülen veri ile karşılaştırma yap
                if (decryptedPasswordID == passwordID)
                {
                    DocumentReference docRef = userCollection.Document(document.Id);
                    await docRef.DeleteAsync();
                    MessageBox.Show("Silme işlemi başarılı!");
                    isDeleted = true;
                    break; // Silme işlemi başarılıysa döngüden çık
                }
            }

            if (!isDeleted)
            {
                MessageBox.Show("Silinecek kayıt bulunamadı.");
            }

            return isDeleted;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Silme hatası: {ex.Message}");
            throw;
        }
    }

}
