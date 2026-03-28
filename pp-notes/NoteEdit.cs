using System;
using System.Collections.Frozen;
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
        private DatabaseController db;

        public event Action<Note>? OnConfirm;
        public event Action<Note>? OnSave;
        public event Action? OnBack;
        public event Action? OnCreateBack;

        public NoteEdit()
        {
            InitializeComponent();
            db = new DatabaseController();
        }

        private void NoteEdit_Load(object sender, EventArgs e)
        {
            if (note != null)
            {
                NETitle.Text = note.Title;
                NEText.Text = note.Text;
                NEImagePath.Text = note.Image;
            }
            else
            {
                NEDelete.Visible = false;
            }

        }

        private void NEConfirm_Click(object sender, EventArgs e)
        {
            if (note != null)
            {
                Note? CreatedNote = new Note(note.Id, NETitle.Text.ToString(), NEText.Text.ToString(), loggedUser);
                if (NEImagePath.Text.ToString() != "")
                {
                    CreatedNote.Image = NEImagePath.Text;
                }
                
                CreatedNote = db.EditNote(note.Id, CreatedNote);
                if (CreatedNote != null)
                {
                    OnConfirm?.Invoke(CreatedNote);
                }
                else
                {
                    MessageBox.Show("Ошибка обновления данных: возможно, вы не ввели заголовок");
                }

            }
            else
            {
                Note? CreatedNote = new Note(-1, NETitle.Text.ToString(), NEText.Text.ToString(), loggedUser);
                if (NEImagePath.Text.ToString() != "")
                {
                    CreatedNote.Image = NEImagePath.Text;
                }
                CreatedNote = db.AddNote(CreatedNote);
                if (CreatedNote != null)
                {
                    OnSave?.Invoke(CreatedNote);
                }
                else
                {
                    MessageBox.Show("Ошибка добавления данных: возможно, вы не ввели заголовок");
                }
            }

        }

        private void NEBack_Click(object sender, EventArgs e)
        {
            if (note != null)
            {
                OnBack?.Invoke();
            }
            else
            {
                OnCreateBack?.Invoke();
            }

        }

        private void NEDelete_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show($"Вы точно хотите удалить заметку {note.Title}?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                if (db.DeleteNote(note.Id))
                {
                    OnCreateBack?.Invoke();
                    MessageBox.Show("Заметка удалена");
                }
            }
        }
    }
}
