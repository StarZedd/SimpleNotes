using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimpleNotes
{
    public partial class CreateNoteForm : Form
    {
        // Массив для хранения данных о заметке
        // Используется для передачи данных между формами
        private string[] TextContainer;
        private bool Editing = false;

        public CreateNoteForm() => InitializeComponent();

        public CreateNoteForm(string[] cont, bool editing = false)
        {
            InitializeComponent();
            TextContainer = cont;
            Editing = editing;
            // Если форма открыта для редактирования,
            // в контейнере уже будет текст
            if (editing)
            {
                Text = $"Редактирование - {cont[0]}";
                NoteNameTextBox.ReadOnly = true;
                NoteNameTextBox.Text = cont[0];
                NoteContentTextBox.Text = cont[1];
            }
        }

        private void cancelNoteButton_Click(object sender, EventArgs e) => Close();// ...Управление переходит в CreateNoteForm_FormClosing

        private void createNoteButton_Click(object sender, EventArgs e)
        {
            if (NoteNameTextBox.TextLength < 1)
            {
                MessageBox.Show("Название заметки не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (NoteContentTextBox.TextLength < 3)
            {
                MessageBox.Show("Заметка слишком короткая", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (NoteContentTextBox.TextLength > 2000)
            {
                if(DialogResult.No == MessageBox.Show("Заметка слишком длинная! Рекомендуемый размер - до 2000 символов\n\nВсё равно создать заметку?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    return;
            }
            // Проверка на корректность названия заметки.
            // Необходимость такой заметки заключается в том, что название заметки - это имя файла.
            // Он не может начинаться или заканчиваться на пробел, пустой символ, и не может содержать в себе спецсимволы
            Regex name = new Regex("^\\S[\\w, \\s]+\\S$", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase);
            if (!name.IsMatch(NoteNameTextBox.Text))
            {
                MessageBox.Show("Недопустимое название заметки.\nРазрешено использование только букв, цифр и пробелов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Записываем данные в контейнер, где они будут использованы в главной форме
            TextContainer[0] = NoteNameTextBox.Text;
            TextContainer[1] = NoteContentTextBox.Text;
            // Если мы не редактируем заметку И она уже существует
            if (!Editing && File.Exists($"{MainForm.NotesFolder.FullName}\\{TextContainer[0]}.snf"))
            {
                MessageBox.Show("Заметка с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Создаём заметку в виде файла
            // Или перезаписываем при редактировании
            File.WriteAllText($"{MainForm.NotesFolder.FullName}\\{TextContainer[0]}.snf", TextContainer[1]);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CreateNoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Выводим диалог, нужно ли отменять создание заметки
            // Только если одно из полей пустое ИЛИ мы ещё не закончили создание записи
            if ((NoteNameTextBox.TextLength != 0 || NoteContentTextBox.TextLength != 0) && DialogResult != DialogResult.OK)
                if (DialogResult.No == MessageBox.Show("Отменить создание заметки?\nВведённые данные не сохранятся", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    e.Cancel = true;
                }
            // Если оба поля пусты / мы получили подверждение / закончили создание записи
            // продолжаем закрытие окна
            if (DialogResult != DialogResult.OK)
                DialogResult = DialogResult.Cancel;
        }

        private void NoteNameTextBox_TextChanged(object sender, EventArgs e) => groupBox1.Text = $"Название заметки ({NoteNameTextBox.TextLength}/24)";

        private void NoteContentTextBox_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Text = $"Содержание заметки ({NoteContentTextBox.TextLength}/2000)";
            if (NoteContentTextBox.TextLength >= 2999)
            {
                groupBox2.ForeColor = Color.Red;
            }
            else if (NoteContentTextBox.TextLength >= 2000)
            {
                groupBox2.ForeColor = Color.DarkOrange;
            }
            else
            {
                groupBox2.ForeColor = Color.Black;
            }
        }
    }
}
