using System.Drawing;
using System.Windows.Forms;

namespace ToDoTaskManager.Entities.Design
{
    public class MainFormLabel : Label
    {
        public MainFormLabel()
        {
            // Установка свойств шрифта, цвета текста и размера текста
            this.Font = new Font("Arial", 12f);
            this.ForeColor = Color.Blue;
            // Установка свойств цвета фона
            this.BackColor = Color.LightGray;
        }
    }
}