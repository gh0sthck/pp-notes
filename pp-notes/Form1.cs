namespace pp_notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowLoginScreen();
        }

        private void ShowScreen(UserControl uc)
        {
            BasePanel.Controls.Clear();
            BasePanel.Controls.Add(uc);
        }

        private void ShowMainScreen(User loggedUser)
        {
            MainPage mp = new MainPage();
            mp.LoggedUser = loggedUser;

            mp.OnNoteClick += note =>
            {
                ShowNoteScreen(note, loggedUser);
            };
            mp.OnExit += () =>
            {
                ShowLoginScreen();
            };
            mp.OnNoteAdd += () =>
            {
                ShowEditNoteScreen(null, loggedUser);
            };

            ShowScreen(mp);
        }

        private void ShowNoteScreen(Note note, User loggedUser)
        {
            NoteDetail np = new NoteDetail();
            np.note = note;
            np.OnBack += () =>
            {
                ShowMainScreen(loggedUser);
            };
            np.OnEdit += () =>
            {
                ShowEditNoteScreen(note, loggedUser);
            };
            ShowScreen(np);
        }

        private void ShowEditNoteScreen(Note? note, User loggedUser)
        {
            NoteEdit nd = new NoteEdit();
            nd.note = note;
            nd.OnConfirm += editedNote =>
            {
                ShowNoteScreen(editedNote, loggedUser);
            };
            nd.OnCreateBack += () =>
            {
                ShowMainScreen(loggedUser);
            };
            nd.OnBack += () =>
            {
                ShowNoteScreen(note, loggedUser);
            };
            
            ShowScreen(nd);
        }

        private void ShowLoginScreen()
        {
            var lc = new Login();
            lc.OnAuthenticated += user =>
            {
                ShowMainScreen(user);
            };
            ShowScreen(lc);
        }

        
    }

}
