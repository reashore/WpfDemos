using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ControlsDemo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string sex = MaleRadioButton.IsChecked == true ? "Male" : "Female";
            string computers = "";

            if (DesktopCheckBox.IsChecked == true)
            {
                computers += "Desktop";
            }

            if (LaptopCheckBox.IsChecked == true)
            {
                computers += " Laptop";
            }

            if (TabletCheckBox.IsChecked == true)
            {
                computers += " Tablet";
            }

            stringBuilder.AppendLine($"Full name = {FullNameTextBox.Text}");
            stringBuilder.AppendLine($"Sex = {sex}");
            stringBuilder.AppendLine($"Computers = {computers}");
            stringBuilder.AppendLine($"Job = {JobComboBox.Text}");
            stringBuilder.AppendLine($"Delivery Date = {DeliverDateCalendar.SelectedDate.ToString()}");

            const string caption = "Employee Details";
            string message = stringBuilder.ToString();

            MessageBox.Show(message, caption);
        }

        private void JobComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
