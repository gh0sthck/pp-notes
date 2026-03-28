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
        public event Action? OnExit;
        public event Action? OnNoteAdd;

        public MainPage()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                notes.Add(new Note(i, $"testtitle-{i}", "so description...", LoggedUser));
            }
        }

        private void InsertData(List<Note> notes)
        {
            MainFlowLayout.Controls.Clear();
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
            InsertData(notes);
        }

        private void MainSearch_TextChanged(object sender, EventArgs e)
        {
            string temp = MainSearch.Text;
            List<Note> notes2 = new List<Note>();
            foreach (Note note in notes)
            {
                if (note.Title.Contains(temp))
                {
                    notes2.Add(note);
                }
            }
            InsertData(notes2);
        }

        private void MainExit_Click(object sender, EventArgs e)
        {
            OnExit?.Invoke();
        }

        private void MainAdd_Click(object sender, EventArgs e)
        {
            OnNoteAdd?.Invoke();
        }
    }
}
