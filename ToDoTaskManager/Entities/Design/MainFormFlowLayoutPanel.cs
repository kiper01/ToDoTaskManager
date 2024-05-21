using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class MainFormFlowLayoutPanel : FlowLayoutPanel
    {
        public MainFormFlowLayoutPanel()
        {
            this.FlowDirection = FlowDirection.TopDown;
            this.AutoScroll = true;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
    }
}
