
namespace WpfLibrary1
{
    public class Class1
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

        }
    }

}
