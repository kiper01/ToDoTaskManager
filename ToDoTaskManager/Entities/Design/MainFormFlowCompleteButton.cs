using System.Drawing;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class MainFormFlowCompleteButton : Button
    {
        public MainFormFlowCompleteButton()
        {
            this.Size = new System.Drawing.Size(160, 40);
            this.Location = new Point(-1, 260);
            this.Text = "Выполнить";
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(55, 71, 79);
            this.ForeColor = Color.WhiteSmoke;
            this.Font = new Font("Arial", 16f);
        }
    }
}