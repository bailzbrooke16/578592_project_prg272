using Core.Interfaces;
using DataLayer.Models;
using DataLayer;
using System.Security.Cryptography;
using System.Text;

namespace Core
{
    public class UserService : IUserService
    {
        private FileManager _fileManager = new FileManager();
        private List<User> users = new List<User>();
        public UserService() 
        {
            string[] lines =  _fileManager.ReadFileLines();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 2)
                {
                    string username = parts[0].Trim();
                    string password = parts[1].Trim();
                    User user = new User(username, password);
                    users.Add(user);
                }
                else
                {
                    Console.WriteLine($"Skipping invalid line: {line}");
                }
            }


        }

        public string createUser(User user)
        {
            try
            {
                string encryptedpassword = GetSha256Hash(user.Password);

                _fileManager.AddNewLine(user.Username + "," + encryptedpassword);
                return "User added successfully";
            } catch 
            {
                return "There was an error adding the new user";
            }

        }

        public string loginUser(User loggingInUser)
        {
            try
            {
                string encryptedpassword = GetSha256Hash(loggingInUser.Password);
                foreach (User user in users)
                {
                    if (user.Username.Equals(loggingInUser.Username))
                    {
                        if (user.Password.Equals(encryptedpassword))
                        {
                            return "Logged in successfully";
                        }
                        else
                        {
                            return "Password is Incorrect";
                        }
                    }
                }
                return "User not found";
            }
            catch
            {
                return "There was an error logging in the user";
            }
        }


        private string GetSha256Hash(string input)
        {
            // Create a SHA256 instance
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash
                byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a StringBuilder to collect the bytes and create a string
                StringBuilder sb = new StringBuilder();

                // Loop through each byte of the hashed data and format each one as a hexadecimal string
                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string
                return sb.ToString();
            }
        }
    }
}
