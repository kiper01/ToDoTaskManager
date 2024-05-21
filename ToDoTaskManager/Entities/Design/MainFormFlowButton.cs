using System.Drawing;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class MainFormFlowButton : Button
    {
        public MainFormFlowButton() 
        {
            this.Size = new System.Drawing.Size(40, 40);
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(55, 71, 79);
            this.Text = "";
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
