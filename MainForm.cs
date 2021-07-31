using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimpleNotes
{
    public partial class MainForm : Form
    {
        // Папка, в которой хранятся файлы заметок
        public static DirectoryInfo NotesFolder;
        // Выбранная в текущий момент заметка
        public static Button SelectedNote;

        public MainForm()
        {
            InitializeComponent();
            // Если папка уже существует, она не будет перезаписана, так что
            // проверка существования не нужна
            NotesFolder = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SimpleNotes");
            // Смотрим на наличие заметок в папке %APPDATA%/Roaming
            // Заметка = Файл с расширением .snf (Simple Note File)
            foreach (string i in Directory.GetFiles(NotesFolder.FullName, "??*.snf"))
            {
                // Каждая заметка имеет свою кнопку в панели слева
                // Имя файла (без расширения) = имя кнопки - заголовок
                // Содержимое файла = тэг внутри кнопки - сама заметка
                Button NoteButton = new Button
                {
                    Text = i.Substring(i.LastIndexOf('\\') + 1, i.LastIndexOf('.') - i.LastIndexOf('\\') - 1),
                    Tag = File.ReadAllText(i),
                    Size = new Size(165, 23),
                };
                NoteButton.Click += NoteButton_Click;
                notesLayoutPanel.Controls.Add(NoteButton);
            }
        }

        private void CreateNoteButton_Click(object sender, EventArgs e)
        {
            // Массив из двух строк
            // Первая - Заголовок
            // Вторая - Содержимое заметки
            string[] container = new string[2] { "", "" };
            // Создаём форму для создания новой заметки
            // Код останавливает выполнение до закрытия окна
            DialogResult res = new CreateNoteForm(container).ShowDialog();
            if (res == DialogResult.OK)
            {
                // Создаём заметку в виде кнопки
                Button NoteButton = new Button
                {
                    Text = container[0],
                    Tag = container[1],
                    Size = new Size(165, 23),
                };
                NoteButton.Click += NoteButton_Click;
                notesLayoutPanel.Controls.Add(NoteButton);
                // Заметка в виде файла создаётся в CreateNoteForm
                // Имитируем клик по кнопке, чтобы вызвать отображение заметки
                NoteButton.PerformClick();
            }
        }

        private void NoteButton_Click(object sender, EventArgs e)
        {
            // Показываем что заметка выбрана и применяем её свойства
            Button noteButton = (Button)sender;
            SelectedNote = noteButton;
            Text = $"SimpleNotes | {noteButton.Text}";
            NoteGroupBox.Text = $"Заметка \"{noteButton.Text}\"";
            NoteTextBox.Text = noteButton.Tag.ToString();
            EditNoteButton.Enabled = true;
            DeleteNoteButton.Enabled = true;
            NoteTextBox.Enabled = true;
            NoteTextBox.ReadOnly = true;
        }

        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            // Запрашиваем подтверждение на удаление
            if (DialogResult.Yes == MessageBox.Show($"Действительно удалить запись \"{SelectedNote.Text}\"?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                // Удаляем файл с заметкой и саму кнопку
                File.Delete($"{NotesFolder.FullName}\\{SelectedNote.Text}.snf");
                SelectedNote.Dispose();
                // После чего снова ставим состояние на "Заметка не выбрана"
                SelectedNote = null;
                Text = $"SimpleNotes";
                NoteGroupBox.Text = "Заметка не выбрана";
                NoteTextBox.Text = "";
                EditNoteButton.Enabled = false;
                DeleteNoteButton.Enabled = false;
                NoteTextBox.Enabled = false;
                NoteTextBox.ReadOnly = false;
            }
        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            string[] container = new string[2]
            {
                SelectedNote.Text,
                SelectedNote.Tag.ToString()
            };
            // Создаём форму для редактирования заметки
            // Код останавливает выполнение до закрытия окна
            DialogResult res = new CreateNoteForm(container, true).ShowDialog();
            if (res == DialogResult.OK)
            {
                // Редактируем текущую заметку-кнопку
                SelectedNote.Tag = container[1];
                // Заметка в виде файла редактируется в CreateNoteForm
                // Имитируем клик по кнопке, чтобы вызвать отображение заметки
                SelectedNote.PerformClick();
            }
        }
    }
}
