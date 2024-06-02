using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;

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
