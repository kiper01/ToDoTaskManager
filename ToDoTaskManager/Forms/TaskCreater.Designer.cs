namespace ToDoTaskManager
{
    partial class TaskCreater
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
            this.taskCreaterLabel1 = new ToDoTaskManager.Entities.Design.TaskCreaterLabel();
            this.mainFormLabel1 = new ToDoTaskManager.Entities.Design.MainFormLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.taskCreaterDateTimePicker1 = new ToDoTaskManager.Entities.Design.TaskCreaterDateTimePicker();
            this.SuspendLayout();
            // 
            // taskCreaterLabel1
            // 
            this.taskCreaterLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taskCreaterLabel1.AutoSize = true;
            this.taskCreaterLabel1.BackColor = System.Drawing.Color.Transparent;
            this.taskCreaterLabel1.Font = new System.Drawing.Font("Arial", 16F);
            this.taskCreaterLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.taskCreaterLabel1.Location = new System.Drawing.Point(38, 91);
            this.taskCreaterLabel1.Name = "taskCreaterLabel1";
            this.taskCreaterLabel1.Size = new System.Drawing.Size(187, 25);
            this.taskCreaterLabel1.TabIndex = 0;
            this.taskCreaterLabel1.Text = "taskCreaterLabel1";
            this.taskCreaterLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // mainFormLabel1
            // 
            this.mainFormLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainFormLabel1.AutoSize = true;
            this.mainFormLabel1.BackColor = System.Drawing.Color.Transparent;
            this.mainFormLabel1.Font = new System.Drawing.Font("Arial", 20F);
            this.mainFormLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainFormLabel1.Location = new System.Drawing.Point(85, 29);
            this.mainFormLabel1.Name = "mainFormLabel1";
            this.mainFormLabel1.Size = new System.Drawing.Size(209, 32);
            this.mainFormLabel1.TabIndex = 1;
            this.mainFormLabel1.Text = "Создать задачу";
            this.mainFormLabel1.Click += new System.EventHandler(this.mainFormLabel1_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(43, 147);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(200, 23);
            this.materialSingleLineTextField1.TabIndex = 2;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // taskCreaterDateTimePicker1
            // 
            this.taskCreaterDateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taskCreaterDateTimePicker1.BackColor = System.Drawing.SystemColors.Window;
            this.taskCreaterDateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.taskCreaterDateTimePicker1.Font = new System.Drawing.Font("Arial", 16F);
            this.taskCreaterDateTimePicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.taskCreaterDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.taskCreaterDateTimePicker1.Location = new System.Drawing.Point(43, 353);
            this.taskCreaterDateTimePicker1.Name = "taskCreaterDateTimePicker1";
            this.taskCreaterDateTimePicker1.ShowUpDown = true;
            this.taskCreaterDateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.taskCreaterDateTimePicker1.TabIndex = 3;
            // 
            // TaskCreater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(380, 490);
            this.Controls.Add(this.taskCreaterDateTimePicker1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.mainFormLabel1);
            this.Controls.Add(this.taskCreaterLabel1);
            this.Name = "TaskCreater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Entities.Design.TaskCreaterLabel taskCreaterLabel1;
        private Entities.Design.MainFormLabel mainFormLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private Entities.Design.TaskCreaterDateTimePicker taskCreaterDateTimePicker1;
    }
}