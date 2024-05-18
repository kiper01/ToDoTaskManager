using System.Drawing;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class TaskCreaterDateTimePicker : DateTimePicker
    {
        public TaskCreaterDateTimePicker()
        {
            Font = new Font("Arial", 16f);
            ForeColor = Color.FromArgb(55, 71, 79);
            BackColor = SystemColors.Window; // Transparent is not supported, using default background color
            Anchor = AnchorStyles.Top;
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "dd.MM.yyyy HH:mm"; // Format to include both date and time
            ShowUpDown = true; // Enables time selection using up and down buttons
        }
    }
}
