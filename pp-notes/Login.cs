namespace pp_notes
{
    public partial class Login : UserControl
    {

        public event Action<User>? OnAuthenticated;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Authenticate()
        {
            string login = LoginLoginBox.Text.ToString();
            string password = LoginPasswordBox.Text.ToString();
            // get data from db; test user instead
            User TestUser = new User("admin", "admin");
            if (login == TestUser.Username && password == TestUser.Password)
            {
                OnAuthenticated?.Invoke(TestUser);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Authenticate();
        }
    }
}
