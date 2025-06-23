using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Net.Mail;
using System.Globalization;
using todoo;



namespace UserRepos
{
    public class UserRepos
    {

        public string _name { get; set; }
        public string _mail { get; set; }
        public string _password { get; set; }

        public UserRepos(string name, string mail, string password)
        {
            _name = name;
            _mail = mail;
            _password = password;
        }

        public override string ToString()
        {
            return $"{_name},{_mail},{_password}";
        }
    }


    public class UserManager
    {
        private const string filePath = @"C:\Users\Public\Documents\Users.txt";


        public void RegisterUser(string name, string mail,string password)
        {
            if (IsUserExists(name) == true)
            {
                throw new Exception("Пользователь с таким именем уже существует.");
            }

            UserRepos newUser = new UserRepos(name, mail, password);

            File.AppendAllText(filePath, newUser.ToString() + Environment.NewLine);

        }

        public bool AuthorizeUser(string mail, string password)
        {
            var users = GetAllUsers();
            foreach (var user in users)
            {
                if (user._mail == mail & user._password == password)
                    return true;
            }
            return false;
        }

        private bool IsUserExists(string username)
        {
            var users = GetAllUsers();
            foreach (var user in users)
            {
                if (user._name == username)
                    return true;
            }
            return false;
        }

        private List<UserRepos> GetAllUsers()
        {
            var users = new List<UserRepos>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        users.Add(new UserRepos(parts[0], parts[1], parts[2]));
                    }
                }
            }
            return users;
        }

       
    }

    public class AppConnect
    {
        public static todoEntities2 todoModel;

    }
    public class AppFrame
    {
        public static MainWindow frameMain;
    }

}