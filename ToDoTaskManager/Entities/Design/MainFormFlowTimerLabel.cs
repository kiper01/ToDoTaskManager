using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class MainFormFlowTimerLabel : Label
    {
        public MainFormFlowTimerLabel(string timer) 
        {
            this.Text = timer;
            this.Size = new System.Drawing.Size(230, 30); //x = 220 дефолт, но с 22 шрифтом не влезает
            this.Location = new Point(10, 220);
            this.Font = new Font("Arial", 22f);
            this.ForeColor = Color.FromArgb(55, 71, 79);
            this.BackColor = Color.Transparent;
        }
    }
}
