using System.Drawing;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class MainFormLabel : Label
    {
        public MainFormLabel()
        {
            Font = new Font("Arial", 20f);
            ForeColor = Color.WhiteSmoke;
            BackColor = Color.Transparent;
            Anchor = AnchorStyles.Top;
        }
    }
}