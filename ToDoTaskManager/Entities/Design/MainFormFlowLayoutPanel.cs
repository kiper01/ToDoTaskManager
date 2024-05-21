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
