using System.Drawing;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class TaskCreaterLabel : Label
    {
        public TaskCreaterLabel()
        {
            this.Font = new Font("Arial", 16f);
            this.ForeColor = Color.FromArgb(55, 71, 79);
            this.BackColor = Color.Transparent;
            this.Anchor = AnchorStyles.Top;
            this.TextAlign = ContentAlignment.BottomLeft;
        }
    }
}