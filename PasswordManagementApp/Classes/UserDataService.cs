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

    // Constructor that initializes the Firestore database with the given credentials
    public UserDataService(string credentialsPath, string projectId)
    {
        // Set the environment variable for Firebase credentials
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credentialsPath);
        // Initialize Firestore with the specified project ID
        firestoreDb = FirestoreDb.Create(projectId);
    }

    // Method to set user credentials (UserId and UserEmail)
    public void SetUserCredentials(string userId, string userEmail)
    {
        UserId = userId;
        UserEmail = userEmail;
    }

    // Asynchronous method to store user password in Firestore
    public async Task StoreUserPasswordAsync(string saveId, string platformName, string userName, string email, string website, string password)
    {
        try
        {
            // Throw an error if the user's email address is not available
            if (string.IsNullOrEmpty(UserEmail))
                throw new Exception("User email address is not available.");

            // Get the collection belonging to the user in Firestore
            CollectionReference userCollection = firestoreDb.Collection(UserEmail);
            // Get a reference to the document where the password will be stored
            DocumentReference passwordDocRef = userCollection.Document(saveId);
            // Create an encryption helper
            EncryptionHelper encryptionHelper = new EncryptionHelper();

            // Create a dictionary of data to be saved, encrypting the values
            var passwordData = new Dictionary<string, object>
            {
                { "PasswordID", encryptionHelper.Encrypt(saveId) },
                //{ "PlatformName",encryptionHelper.Encrypt( platformName) },
                { "PlatformName",platformName },
                { "UserName", encryptionHelper.Encrypt(userName) },
                { "Email", encryptionHelper.Encrypt(email) },
                { "Website", encryptionHelper.Encrypt(website) },
                { "Password", encryptionHelper.Encrypt(password) }
            };

            // Save the data to Firestore
            await passwordDocRef.SetAsync(passwordData);
        }
        catch (Exception ex)
        {
            // Show an error message in case of failure and rethrow the exception
            MessageBox.Show($"Data saving error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }

    // Asynchronous method to retrieve the user's passwords from Firestore
    public async Task<List<Dictionary<string, object>>> GetUserPasswordsAsync()
    {
        try
        {
            // Throw an error if the user's email address is not available
            if (string.IsNullOrEmpty(UserEmail))
                throw new Exception("User email address is not available.");

            // Get the collection belonging to the user in Firestore
            CollectionReference userCollection = firestoreDb.Collection(UserEmail);
            // Get a snapshot of the documents in the collection
            QuerySnapshot snapshot = await userCollection.GetSnapshotAsync();

            var passwordList = new List<Dictionary<string, object>>();
            EncryptionHelper encryptionHelper = new EncryptionHelper();

            // Decrypt the encrypted data for each document and add it to the list
            foreach (var document in snapshot.Documents)
            {
                var decryptedData = new Dictionary<string, object>
                {
                    { "PasswordID", encryptionHelper.Decrypt(document.GetValue<string>("PasswordID")) },
                    { "PlatformName", document.GetValue<string>("PlatformName") },
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
            // Show an error message in case of failure and rethrow the exception
            MessageBox.Show($"Data retrieval error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }

    // Asynchronous method to update the user's passwords in Firestore
    public async Task<bool> UpdateUserPasswordsAsync(string passwordID, string platformName, string username, string email, string website, string password)
    {
        try
        {
            // Throw an error if the user's email address is not available
            if (string.IsNullOrEmpty(UserEmail))
                throw new Exception("User email address is not available.");

            // Get the collection belonging to the user in Firestore
            CollectionReference userCollection = firestoreDb.Collection(UserEmail);
            // Get a snapshot of the documents in the collection
            QuerySnapshot snapshot = await userCollection.GetSnapshotAsync();
            EncryptionHelper encryptionHelper = new EncryptionHelper();

            // Create a dictionary of updated data, encrypting the values
            var updatedData = new Dictionary<string, object>
            {
                { "PasswordID", encryptionHelper.Encrypt(passwordID) },
                { "PlatformName", platformName },
                { "UserName", encryptionHelper.Encrypt(username) },
                { "Email", encryptionHelper.Encrypt(email) },
                { "Website", encryptionHelper.Encrypt(website) },
                { "Password", encryptionHelper.Encrypt(password) }
            };

            bool isUpdated = false;

            // Check each document, find the matching password ID, and update
            foreach (var document in snapshot.Documents)
            {
                // Decrypt the data from the database
                string decryptedPasswordID = encryptionHelper.Decrypt(document.GetValue<string>("PasswordID"));

                // Compare with the decrypted data
                if (decryptedPasswordID == passwordID)
                {
                    DocumentReference docRef = userCollection.Document(document.Id);
                    // Save the updated data to Firestore
                    await docRef.UpdateAsync(updatedData);
                    MessageBox.Show("Update successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    isUpdated = true;
                    break; // Exit the loop if the update is successful
                }
            }

            if (!isUpdated)
            {
                MessageBox.Show("No content found to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isUpdated;
        }
        catch (Exception ex)
        {
            // Show an error message in case of failure and rethrow the exception
            MessageBox.Show($"Update error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }

    // Asynchronous method to delete a user's password from Firestore
    public async Task<bool> DeleteUserPasswordAsync(string passwordID)
    {
        try
        {
            // Throw an error if the user's email address is not available
            if (string.IsNullOrEmpty(UserEmail))
                throw new Exception("User email address is not available.");

            // Get the collection belonging to the user in Firestore
            CollectionReference userCollection = firestoreDb.Collection(UserEmail);
            // Get a snapshot of the documents in the collection
            QuerySnapshot snapshot = await userCollection.GetSnapshotAsync();
            EncryptionHelper encryptionHelper = new EncryptionHelper();

            bool isDeleted = false;

            // Check each document, find the matching password ID, and delete
            foreach (var document in snapshot.Documents)
            {
                // Decrypt the data from the database
                string decryptedPasswordID = encryptionHelper.Decrypt(document.GetValue<string>("PasswordID"));

                // Compare with the decrypted data
                if (decryptedPasswordID == passwordID)
                {
                    DocumentReference docRef = userCollection.Document(document.Id);
                    // Delete the document from Firestore
                    await docRef.DeleteAsync();
                    MessageBox.Show("Deletion successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    isDeleted = true;
                    break; // Exit the loop if the deletion is successful
                }
            }

            if (!isDeleted)
            {
                MessageBox.Show("No content found to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isDeleted;
        }
        catch (Exception ex)
        {
            // Show an error message in case of failure and rethrow the exception
            MessageBox.Show($"Deletion error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }
}