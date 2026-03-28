namespace pp_notes
{
    public partial class Login : UserControl
    {

        public event Action<User>? OnAuthenticated;
        private DatabaseController db;

        public Login()
        {
            InitializeComponent();
            db = new DatabaseController();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Authenticate()
        {
            string login = LoginLoginBox.Text.ToString();
            string password = LoginPasswordBox.Text.ToString();
            
            User? user = db.GetUserByName(login);
            if (user != null)
            {
                if (password == user.Password)
                {
                    OnAuthenticated?.Invoke(user);
                }
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
