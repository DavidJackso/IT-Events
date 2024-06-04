using Service;
using System;
using System.Windows.Forms;

namespace Service_0._0._1
{
    public partial class EventDetailsForm : Form
    {
        public EventDetailsForm(Event ev)
        {
            InitializeComponent();
            event_name.Text += $" {ev.Name}";
            event_location.Text += $" {ev.EventLocation}";
            event_description_label.Text = ev.Description;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
