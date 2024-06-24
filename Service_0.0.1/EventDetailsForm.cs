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
            event_time_label.Text = ev.EventData.ToString(); 
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EventDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
