
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
            this.notesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NoteTextBox = new System.Windows.Forms.RichTextBox();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.CreateNoteButton = new System.Windows.Forms.Button();
            this.NoteGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            GroupBox1 = new System.Windows.Forms.GroupBox();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            this.NoteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(this.notesLayoutPanel);
            GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            GroupBox1.Location = new System.Drawing.Point(0, 0);
            GroupBox1.Margin = new System.Windows.Forms.Padding(6);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new System.Drawing.Size(196, 341);
            GroupBox1.TabIndex = 0;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Заметки";
            // 
            // notesLayoutPanel
            // 
            this.notesLayoutPanel.AutoScroll = true;
            this.notesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.notesLayoutPanel.Name = "notesLayoutPanel";
            this.notesLayoutPanel.Size = new System.Drawing.Size(190, 322);
            this.notesLayoutPanel.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new System.Drawing.Point(6, 19);
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
            splitContainer2.Size = new System.Drawing.Size(326, 281);
            splitContainer2.SplitterDistance = 245;
            splitContainer2.TabIndex = 2;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteTextBox.Enabled = false;
            this.NoteTextBox.Location = new System.Drawing.Point(0, 0);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.NoteTextBox.Size = new System.Drawing.Size(326, 245);
            this.NoteTextBox.TabIndex = 0;
            this.NoteTextBox.Text = "";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
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
            splitContainer1.Size = new System.Drawing.Size(326, 32);
            splitContainer1.SplitterDistance = 161;
            splitContainer1.TabIndex = 1;
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditNoteButton.Enabled = false;
            this.EditNoteButton.Location = new System.Drawing.Point(0, 0);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(161, 32);
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
            this.DeleteNoteButton.Size = new System.Drawing.Size(161, 32);
            this.DeleteNoteButton.TabIndex = 0;
            this.DeleteNoteButton.Text = "Удалить эту заметку";
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // CreateNoteButton
            // 
            this.CreateNoteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateNoteButton.Location = new System.Drawing.Point(0, 0);
            this.CreateNoteButton.Margin = new System.Windows.Forms.Padding(6);
            this.CreateNoteButton.Name = "CreateNoteButton";
            this.CreateNoteButton.Size = new System.Drawing.Size(338, 31);
            this.CreateNoteButton.TabIndex = 1;
            this.CreateNoteButton.Text = "Создать новую заметку";
            this.CreateNoteButton.UseVisualStyleBackColor = true;
            this.CreateNoteButton.Click += new System.EventHandler(this.CreateNoteButton_Click);
            // 
            // NoteGroupBox
            // 
            this.NoteGroupBox.Controls.Add(splitContainer2);
            this.NoteGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteGroupBox.Location = new System.Drawing.Point(0, 0);
            this.NoteGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.NoteGroupBox.Name = "NoteGroupBox";
            this.NoteGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.NoteGroupBox.Size = new System.Drawing.Size(338, 306);
            this.NoteGroupBox.TabIndex = 2;
            this.NoteGroupBox.TabStop = false;
            this.NoteGroupBox.Text = "Заметка не выбрана";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.NoteGroupBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.CreateNoteButton);
            this.splitContainer3.Size = new System.Drawing.Size(338, 341);
            this.splitContainer3.SplitterDistance = 306;
            this.splitContainer3.TabIndex = 3;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(6, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(GroupBox1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer4.Size = new System.Drawing.Size(538, 341);
            this.splitContainer4.SplitterDistance = 196;
            this.splitContainer4.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.splitContainer4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 230);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleNotes";
            GroupBox1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            this.NoteGroupBox.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.RichTextBox NoteTextBox;
        private System.Windows.Forms.FlowLayoutPanel notesLayoutPanel;
        private System.Windows.Forms.GroupBox NoteGroupBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
    }
}

