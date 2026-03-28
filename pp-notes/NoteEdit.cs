using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pp_notes
{
    public partial class NoteEdit : UserControl
    {
        public Note? note;
        public User loggedUser;

        public event Action<Note>? OnConfirm;
        public event Action<Note>? OnSave;
        public event Action? OnBack;
        public event Action? OnCreateBack;

        public NoteEdit()
        {
            InitializeComponent();
        }

        private void NoteEdit_Load(object sender, EventArgs e)
        {
            if (note != null)
            {
                NETitle.Text = note.Title;
                NEText.Text = note.Text;
            } else
            {
                NEDelete.Visible = false;
            }
            
        }

        private void NEConfirm_Click(object sender, EventArgs e)
        {
            if (note != null)
            {
                OnConfirm?.Invoke(note);
            }
            else
            {
                Note CreatedNote = new Note(1, NETitle.Text.ToString(), NEText.Text.ToString(), loggedUser);
                OnSave?.Invoke(CreatedNote);
            }
            
        }

        private void NEBack_Click(object sender, EventArgs e)
        {
            if (note != null)
            {
                OnBack?.Invoke();
            } else
            {
                OnCreateBack?.Invoke();
            }
            
        }
    }
}
