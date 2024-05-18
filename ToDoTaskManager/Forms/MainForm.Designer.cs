namespace ToDoTaskManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainFormButton1 = new ToDoTaskManager.MainFormButton();
            this.mainFormLabel1 = new ToDoTaskManager.Entities.Design.MainFormLabel();
            this.SuspendLayout();
            // 
            // mainFormButton1
            // 
            this.mainFormButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFormButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.mainFormButton1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.mainFormButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainFormButton1.Location = new System.Drawing.Point(633, 433);
            this.mainFormButton1.Name = "mainFormButton1";
            this.mainFormButton1.Radius = 55;
            this.mainFormButton1.Size = new System.Drawing.Size(55, 55);
            this.mainFormButton1.TabIndex = 0;
            this.mainFormButton1.Text = "+";
            // 
            // mainFormLabel1
            // 
            this.mainFormLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainFormLabel1.AutoSize = true;
            this.mainFormLabel1.BackColor = System.Drawing.Color.Transparent;
            this.mainFormLabel1.Font = new System.Drawing.Font("Arial", 20F);
            this.mainFormLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainFormLabel1.Location = new System.Drawing.Point(214, 29);
            this.mainFormLabel1.Name = "mainFormLabel1";
            this.mainFormLabel1.Size = new System.Drawing.Size(265, 32);
            this.mainFormLabel1.TabIndex = 1;
            this.mainFormLabel1.Text = "Планировщик задач";
            this.mainFormLabel1.Click += new System.EventHandler(this.mainFormLabel1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.mainFormLabel1);
            this.Controls.Add(this.mainFormButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MainFormButton mainFormButton1;
        private Entities.Design.MainFormLabel mainFormLabel1;
    }
}

