using System.Drawing;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class TaskCreaterDateTimePicker : DateTimePicker
    {
        public TaskCreaterDateTimePicker()
        {
            this.Font = new Font("Arial", 16f);
            this.Anchor = AnchorStyles.Top;
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = "dd.MM.yyyy HH:mm";
            this.ShowUpDown = true;
        }
    }
}
