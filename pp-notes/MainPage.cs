using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pp_notes
{
    public partial class MainPage : UserControl
    {

        public User LoggedUser;
        private List<Note> notes = new List<Note>();
        public event Action<Note>? OnNoteClick;

        public MainPage()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                notes.Add(new Note(i, $"testtitle-{i}", "so description...", LoggedUser));
            }
        }

        private void InsertData()
        {
            foreach (Note note in notes)
            {
                var nc = new NoteCard();
                nc.note = note;
                nc.onClick += note =>
                {
                    OnNoteClick?.Invoke(note);
                };
                MainFlowLayout.Controls.Add(nc);
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            MainUsername.Text = LoggedUser.Username;
            InsertData();
        }
    }
}
