namespace ToDoTaskManager
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.taskCreaterLabel2 = new ToDoTaskManager.Entities.Design.TaskCreaterLabel();
            this.taskCreaterTextBox2 = new ToDoTaskManager.Entities.Design.TaskCreaterTextBox();
            this.taskCreaterDateTimePicker1 = new ToDoTaskManager.Entities.Design.TaskCreaterDateTimePicker();
            this.mainFormLabel1 = new ToDoTaskManager.Entities.Design.MainFormLabel();
            this.taskCreaterLabel1 = new ToDoTaskManager.Entities.Design.TaskCreaterLabel();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(150, 460);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(84, 36);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "Создать";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // taskCreaterLabel2
            // 
            this.taskCreaterLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taskCreaterLabel2.AutoSize = true;
            this.taskCreaterLabel2.BackColor = System.Drawing.Color.Transparent;
            this.taskCreaterLabel2.Font = new System.Drawing.Font("Arial", 16F);
            this.taskCreaterLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.taskCreaterLabel2.Location = new System.Drawing.Point(12, 339);
            this.taskCreaterLabel2.Name = "taskCreaterLabel2";
            this.taskCreaterLabel2.Size = new System.Drawing.Size(128, 25);
            this.taskCreaterLabel2.TabIndex = 5;
            this.taskCreaterLabel2.Text = "Срок сдачи";
            this.taskCreaterLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // taskCreaterTextBox2
            // 
            this.taskCreaterTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taskCreaterTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.taskCreaterTextBox2.Font = new System.Drawing.Font("Arial", 14F);
            this.taskCreaterTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.taskCreaterTextBox2.Location = new System.Drawing.Point(12, 135);
            this.taskCreaterTextBox2.Multiline = true;
            this.taskCreaterTextBox2.Name = "taskCreaterTextBox2";
            this.taskCreaterTextBox2.Size = new System.Drawing.Size(356, 187);
            this.taskCreaterTextBox2.TabIndex = 4;
            this.taskCreaterTextBox2.TextChanged += new System.EventHandler(this.taskCreaterTextBox2_TextChanged);
            // 
            // taskCreaterDateTimePicker1
            // 
            this.taskCreaterDateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taskCreaterDateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.taskCreaterDateTimePicker1.Font = new System.Drawing.Font("Arial", 16F);
            this.taskCreaterDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.taskCreaterDateTimePicker1.Location = new System.Drawing.Point(12, 377);
            this.taskCreaterDateTimePicker1.Name = "taskCreaterDateTimePicker1";
            this.taskCreaterDateTimePicker1.ShowUpDown = true;
            this.taskCreaterDateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.taskCreaterDateTimePicker1.TabIndex = 3;
            // 
            // mainFormLabel1
            // 
            this.mainFormLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainFormLabel1.AutoSize = true;
            this.mainFormLabel1.BackColor = System.Drawing.Color.Transparent;
            this.mainFormLabel1.Font = new System.Drawing.Font("Arial", 24F);
            this.mainFormLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainFormLabel1.Location = new System.Drawing.Point(60, 27);
            this.mainFormLabel1.Name = "mainFormLabel1";
            this.mainFormLabel1.Size = new System.Drawing.Size(269, 36);
            this.mainFormLabel1.TabIndex = 1;
            this.mainFormLabel1.Text = "Создание задачи";
            this.mainFormLabel1.Click += new System.EventHandler(this.mainFormLabel1_Click);
            // 
            // taskCreaterLabel1
            // 
            this.taskCreaterLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taskCreaterLabel1.AutoSize = true;
            this.taskCreaterLabel1.BackColor = System.Drawing.Color.Transparent;
            this.taskCreaterLabel1.Font = new System.Drawing.Font("Arial", 16F);
            this.taskCreaterLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.taskCreaterLabel1.Location = new System.Drawing.Point(12, 96);
            this.taskCreaterLabel1.Name = "taskCreaterLabel1";
            this.taskCreaterLabel1.Size = new System.Drawing.Size(111, 25);
            this.taskCreaterLabel1.TabIndex = 0;
            this.taskCreaterLabel1.Text = "Описание";
            this.taskCreaterLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 510);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.taskCreaterLabel2);
            this.Controls.Add(this.taskCreaterTextBox2);
            this.Controls.Add(this.taskCreaterDateTimePicker1);
            this.Controls.Add(this.mainFormLabel1);
            this.Controls.Add(this.taskCreaterLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(380, 510);
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TaskCreater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Entities.Design.TaskCreaterLabel taskCreaterLabel1;
        private Entities.Design.MainFormLabel mainFormLabel1;
        private Entities.Design.TaskCreaterDateTimePicker taskCreaterDateTimePicker1;
        private Entities.Design.TaskCreaterTextBox taskCreaterTextBox2;
        private Entities.Design.TaskCreaterLabel taskCreaterLabel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}