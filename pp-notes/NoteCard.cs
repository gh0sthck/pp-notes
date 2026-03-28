using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pp_notes
{
    public partial class NoteCard : UserControl
    {
        public Note note;
        public event Action<Note>? onClick;

        public NoteCard()
        {
            InitializeComponent();
        }

        private void NoteCard_Load(object sender, EventArgs e)
        {
            NoteCardText.Text = note.Text;
            NoteCardTitle.Text = note.Title;
        }

        private void NoteCard_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(note);
        }
    }
}
