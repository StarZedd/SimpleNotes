
namespace SimpleNotes
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox GroupBox1;
            System.Windows.Forms.SplitContainer splitContainer2;
            System.Windows.Forms.SplitContainer splitContainer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CreateNoteButton = new System.Windows.Forms.Button();
            this.NoteGroupBox = new System.Windows.Forms.GroupBox();
            this.NoteTextBox = new System.Windows.Forms.RichTextBox();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.notesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            GroupBox1 = new System.Windows.Forms.GroupBox();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            GroupBox1.SuspendLayout();
            this.NoteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(this.notesLayoutPanel);
            GroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            GroupBox1.Location = new System.Drawing.Point(0, 0);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new System.Drawing.Size(170, 359);
            GroupBox1.TabIndex = 0;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Заметки";
            // 
            // CreateNoteButton
            // 
            this.CreateNoteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateNoteButton.Location = new System.Drawing.Point(170, 330);
            this.CreateNoteButton.Name = "CreateNoteButton";
            this.CreateNoteButton.Size = new System.Drawing.Size(337, 29);
            this.CreateNoteButton.TabIndex = 1;
            this.CreateNoteButton.Text = "Создать новую заметку";
            this.CreateNoteButton.UseVisualStyleBackColor = true;
            this.CreateNoteButton.Click += new System.EventHandler(this.CreateNoteButton_Click);
            // 
            // NoteGroupBox
            // 
            this.NoteGroupBox.Controls.Add(splitContainer2);
            this.NoteGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteGroupBox.Location = new System.Drawing.Point(170, 0);
            this.NoteGroupBox.Name = "NoteGroupBox";
            this.NoteGroupBox.Size = new System.Drawing.Size(337, 330);
            this.NoteGroupBox.TabIndex = 2;
            this.NoteGroupBox.TabStop = false;
            this.NoteGroupBox.Text = "Заметка не выбрана";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer2.Location = new System.Drawing.Point(3, 16);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(this.NoteTextBox);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer1);
            splitContainer2.Size = new System.Drawing.Size(331, 311);
            splitContainer2.SplitterDistance = 275;
            splitContainer2.TabIndex = 2;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteTextBox.Enabled = false;
            this.NoteTextBox.Location = new System.Drawing.Point(0, 0);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(331, 275);
            this.NoteTextBox.TabIndex = 0;
            this.NoteTextBox.Text = "";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(this.EditNoteButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(this.DeleteNoteButton);
            splitContainer1.Size = new System.Drawing.Size(331, 32);
            splitContainer1.SplitterDistance = 162;
            splitContainer1.TabIndex = 1;
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditNoteButton.Enabled = false;
            this.EditNoteButton.Location = new System.Drawing.Point(0, 0);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(162, 32);
            this.EditNoteButton.TabIndex = 0;
            this.EditNoteButton.Text = "Редактировать заметку";
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteNoteButton.Enabled = false;
            this.DeleteNoteButton.ForeColor = System.Drawing.Color.DarkRed;
            this.DeleteNoteButton.Location = new System.Drawing.Point(0, 0);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(165, 32);
            this.DeleteNoteButton.TabIndex = 0;
            this.DeleteNoteButton.Text = "Удалить эту заметку";
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // notesLayoutPanel
            // 
            this.notesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.notesLayoutPanel.Name = "notesLayoutPanel";
            this.notesLayoutPanel.Size = new System.Drawing.Size(164, 340);
            this.notesLayoutPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 359);
            this.Controls.Add(this.NoteGroupBox);
            this.Controls.Add(this.CreateNoteButton);
            this.Controls.Add(GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 230);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleNotes";
            GroupBox1.ResumeLayout(false);
            this.NoteGroupBox.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.RichTextBox NoteTextBox;
        private System.Windows.Forms.FlowLayoutPanel notesLayoutPanel;
        private System.Windows.Forms.GroupBox NoteGroupBox;
    }
}

