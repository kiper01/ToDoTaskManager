using MaterialSkin.Controls;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoTaskManager
{
    public partial class TaskCreater : MaterialForm
    {
        public TaskCreater()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(380, 490);
            this.MinimumSize = new Size(380, 490);
        }

        private void mainFormLabel1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
