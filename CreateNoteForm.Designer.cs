
namespace SimpleNotes
{
    partial class CreateNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateNoteButton = new System.Windows.Forms.Button();
            this.CancelNoteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoteNameTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NoteContentTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateNoteButton
            // 
            this.CreateNoteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateNoteButton.Location = new System.Drawing.Point(0, 0);
            this.CreateNoteButton.Name = "CreateNoteButton";
            this.CreateNoteButton.Size = new System.Drawing.Size(224, 36);
            this.CreateNoteButton.TabIndex = 0;
            this.CreateNoteButton.Text = "Готово";
            this.CreateNoteButton.UseVisualStyleBackColor = true;
            this.CreateNoteButton.Click += new System.EventHandler(this.createNoteButton_Click);
            // 
            // CancelNoteButton
            // 
            this.CancelNoteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelNoteButton.ForeColor = System.Drawing.Color.Red;
            this.CancelNoteButton.Location = new System.Drawing.Point(0, 0);
            this.CancelNoteButton.Name = "CancelNoteButton";
            this.CancelNoteButton.Size = new System.Drawing.Size(119, 36);
            this.CancelNoteButton.TabIndex = 1;
            this.CancelNoteButton.Text = "Отмена";
            this.CancelNoteButton.UseVisualStyleBackColor = true;
            this.CancelNoteButton.Click += new System.EventHandler(this.cancelNoteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoteNameTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Название заметки (0/24)";
            // 
            // NoteNameTextBox
            // 
            this.NoteNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteNameTextBox.Location = new System.Drawing.Point(3, 16);
            this.NoteNameTextBox.MaxLength = 24;
            this.NoteNameTextBox.Name = "NoteNameTextBox";
            this.NoteNameTextBox.Size = new System.Drawing.Size(341, 20);
            this.NoteNameTextBox.TabIndex = 0;
            this.NoteNameTextBox.TextChanged += new System.EventHandler(this.NoteNameTextBox_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 192);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CreateNoteButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CancelNoteButton);
            this.splitContainer1.Size = new System.Drawing.Size(347, 36);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoteContentTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 150);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Содержимое заметки";
            // 
            // NoteContentTextBox
            // 
            this.NoteContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteContentTextBox.Location = new System.Drawing.Point(3, 16);
            this.NoteContentTextBox.Name = "NoteContentTextBox";
            this.NoteContentTextBox.Size = new System.Drawing.Size(341, 131);
            this.NoteContentTextBox.TabIndex = 0;
            this.NoteContentTextBox.Text = "";
            // 
            // CreateNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 228);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создать заметку";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNoteForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNoteButton;
        private System.Windows.Forms.Button CancelNoteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox NoteNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox NoteContentTextBox;
    }
}