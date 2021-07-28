using System;
using System.Windows.Forms;

namespace SimpleNotes
{
    public partial class CreateNoteForm : Form
    {
        private string[] container;

        public CreateNoteForm() => InitializeComponent();

        public CreateNoteForm(string[] cont)
        {
            InitializeComponent();
            container = cont;
        }

        private void cancelNoteButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // ...Управление переходит в CreateNoteForm_FormClosing
        }

        private void createNoteButton_Click(object sender, EventArgs e)
        {
            if (NoteNameTextBox.TextLength < 1)
            {
                MessageBox.Show("Название заметки не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (NoteContentTextBox.TextLength < 3)
            {
                MessageBox.Show("Заметка слишком короткая", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            container[0] = NoteNameTextBox.Text;
            container[1] = NoteContentTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CreateNoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Выводим диалог, нужно ли отменять создание заметки
            // Только если одно из полей пустое ИЛИ мы ещё не закончили создание записи
            if ((NoteNameTextBox.TextLength != 0 || NoteContentTextBox.TextLength != 0) && this.DialogResult != DialogResult.OK)
                if (DialogResult.No == MessageBox.Show("Отменить создание заметки?\nВведённые данные не сохранятся", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    e.Cancel = true;
                }
            // Если оба поля пусты / мы получили подверждение / закончили создание записи
            // продолжаем закрытие окна
            if (this.DialogResult != DialogResult.OK)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
