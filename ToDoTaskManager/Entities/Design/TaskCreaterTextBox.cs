using System.Drawing;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class TaskCreaterTextBox : TextBox
    {
        public TaskCreaterTextBox()
        {
            this.Font = new Font("Arial", 14f);
            this.ForeColor = Color.FromArgb(55, 71, 79);
            this.BackColor = SystemColors.Window;
            this.Anchor = AnchorStyles.Top;
            this.TextAlign = HorizontalAlignment.Left;
        }
    }
}