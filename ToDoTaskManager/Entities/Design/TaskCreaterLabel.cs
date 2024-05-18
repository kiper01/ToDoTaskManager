using System.Drawing;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class TaskCreaterLabel : Label
    {
        public TaskCreaterLabel()
        {
            Font = new Font("Arial", 16f);
            ForeColor = Color.FromArgb(55, 71, 79);
            BackColor = Color.Transparent;
            Anchor = AnchorStyles.Top;
            TextAlign = ContentAlignment.BottomLeft;
        }
    }
}