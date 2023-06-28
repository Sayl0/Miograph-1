namespace Miograph
{
    public class User
    {
        // Поля класса
        private long id;
        private string fio;
        private string acc_type;
        private string login;
        private string password;

        // Свойства класса
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Fio
        {
            get { return fio; }
            set { fio = value; }
        }

        public string AccType
        {
            get { return acc_type; }
            set { acc_type = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Конструкторы класса
        public User() // Конструктор по умолчанию
        {
            id = 0;
            fio = "";
            acc_type = "operator";
            login = "";
            password = "";
        }

        public User(long id, string fio, string acc_type, string login, string password) // Конструктор с параметрами
        {
            this.id = id;
            this.fio = fio;
            this.acc_type = acc_type;
            this.login = login;
            this.password = password;
        }

        public bool CheckLogin(string login, string password) // Метод для проверки логина и пароля пользователя
        {
            return this.login == login && this.password == password;
        }
    }
}

