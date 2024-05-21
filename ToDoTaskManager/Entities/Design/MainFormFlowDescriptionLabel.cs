using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class MainFormFlowDescriptionLabel : Label
    {
        public MainFormFlowDescriptionLabel(string description)
        {
            this.Text = description;
            this.Size = new System.Drawing.Size(220, 200);
            this.Location = new Point(10, 10);
            this.Font = new Font("Arial", 14f);
            this.ForeColor = Color.FromArgb(55, 71, 79);
            this.BackColor = Color.Transparent;
        }
    }
}
