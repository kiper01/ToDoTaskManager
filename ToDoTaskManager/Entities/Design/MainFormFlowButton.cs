using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoTaskManager.Properties;

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
