using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    internal class MainFormFlowPanel : Panel
    {
        public MainFormFlowPanel() 
        {
            this.Width = 240;
            this.Height = 300;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Margin = new Padding(10);
        }
    }
}
