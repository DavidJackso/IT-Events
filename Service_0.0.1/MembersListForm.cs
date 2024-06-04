using Service;
using System;
using System.Windows.Forms;

namespace Service_0._0._1
{
    public partial class MembersListForm : Form
    {
        Event ev;
        public MembersListForm(Event ev)
        {
            this.ev = ev;
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MembersListForm_Load(object sender, EventArgs e)
        {
            EventsBase evbase = new EventsBase();
            evbase.WriteMembers(ev, members_datagrid);
        }

        private void members_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
