using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace pp_notes
{
    internal class DatabaseController
    {
        private readonly string CONNSTRING;

        public DatabaseController()
        {
            CONNSTRING = "Data Source = " + Environment.CurrentDirectory + @"\data.db; Version = 3;";
        }

        public User? GetUserByName(string name)
        {
            using (var connection = new SQLiteConnection(CONNSTRING))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.CommandText = "SELECT id, username, password FROM users WHERE username = @un;";
                command.Connection = connection;

                using (command)
                {
                    command.Parameters.AddWithValue("un", name);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User us = new User(
                                Id: int.Parse(reader["id"].ToString()),
                                Username: reader["username"].ToString(),
                                Password: reader["password"].ToString()
                            );
                            return us;
                        }
                        return null;
                    }
                }
            }
        }

        public List<Note> GetNotesByUserId(int userId)
        {
            List<Note> notes = new List<Note>();

            using (var connection = new SQLiteConnection(CONNSTRING))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "SELECT notes.id, title, text, users.id as UID, users.username as UN, users.password as UP FROM notes INNER JOIN users ON notes.author_id = users.id WHERE notes.author_id = @aid";
                using (command)
                {
                    command.Parameters.AddWithValue("aid", userId.ToString());
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new User(Id: int.Parse(reader["UID"].ToString()), Username: reader["UN"].ToString(), Password: reader["UP"].ToString());
                            var note = new Note(
                                id: int.Parse(reader["id"].ToString()),
                                title: reader["title"].ToString(),
                                text: reader["text"].ToString(),
                                author: user
                            );
                            notes.Add(note);
                        }
                        return notes;
                    }
                }
            }
        }

        public Note? AddNote(Note note)
        {
            using (var connection = new SQLiteConnection(CONNSTRING))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO notes (title, text, author_id) VALUES (@title, @text, @aid);";
                
                using (command)
                {
                    command.Parameters.AddWithValue("title", note.Title);
                    command.Parameters.AddWithValue("text", note.Text);
                    command.Parameters.AddWithValue("aid", note.Author.Id);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return note;
                    } else
                    {
                        return null;
                    }
                }
            }
        }

        public Note? EditNote(int NoteId, Note newNote)
        {
            using (var connection = new SQLiteConnection(CONNSTRING))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE notes SET title = @title, text = @text WHERE notes.id = @nid;";

                using (command)
                {
                    command.Parameters.AddWithValue("title", newNote.Title);
                    command.Parameters.AddWithValue("text", newNote.Text);
                    command.Parameters.AddWithValue("nid", NoteId);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return newNote;
                    } else
                    {
                        return null;
                    }
                }
            }
        }

        public bool DeleteNote(int NoteId)
        {
            using (var connection = new SQLiteConnection(CONNSTRING))
            {
                connection.Open();
                var command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM notes WHERE id = @id";

                using (command)
                {
                    command.Parameters.AddWithValue("id", NoteId);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}
