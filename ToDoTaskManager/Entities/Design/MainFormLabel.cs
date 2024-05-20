using System.Drawing;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class MainFormLabel : Label
    {
        public MainFormLabel()
        {
            this.Font = new Font("Arial", 24f);
            this.ForeColor = Color.WhiteSmoke;
            this.BackColor = Color.FromArgb(55, 71, 79);
            this.Anchor = AnchorStyles.Top;
        }
    }
}