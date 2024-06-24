using Service_0._0._1;
using System;
using System.Windows.Forms;

namespace Service
{
    public partial class MemberForm : Form
    {
        User activeuser;
        UsersDateBase usersBase = new UsersDateBase();
        EventsDataBase eventsBase;
        public MemberForm(User activeuser)
        {
            InitializeComponent();
            this.activeuser = activeuser;
            eventsBase = new EventsDataBase(activeuser);
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeprofiledata_button_Click(object sender, EventArgs e)
        {
            firstname_textbox.ReadOnly = false;
            lastname_textbox.ReadOnly = false;
            email_textbox.ReadOnly = false;
            organization_textbox.ReadOnly = false;
            changeprofiledata_button.Visible = false;
            saveprofiledata_button.Visible = true;
        }

        private void saveprofiledata_button_Click(object sender, EventArgs e)
        {
            RechangePersonalInfo(activeuser);
            usersBase = new UsersDateBase(activeuser);
            usersBase.AddPersonalData();
            ReadPersonalInfo(activeuser);
            usersBase.AddPersonalData();
            saveprofiledata_button.Visible = false;
            changeprofiledata_button.Visible = true;
        }
        private void ReadPersonalInfo(User activeuser)
        {
            if (activeuser.PersonalInfo != null)
            {
                firstname_textbox.Text = activeuser.PersonalInfo.FirstName;
                lastname_textbox.Text = activeuser.PersonalInfo.LastName;
                email_textbox.Text = activeuser.PersonalInfo.Email;
                organization_textbox.Text = activeuser.PersonalInfo.Organization;
                firstname_textbox.ReadOnly = true;
                lastname_textbox.ReadOnly = true;
                email_textbox.ReadOnly = true;
                organization_textbox.ReadOnly = true;
            }
        }
        private void RechangePersonalInfo(User activeuser)
        {
            firstname_textbox.ReadOnly = false;
            lastname_textbox.ReadOnly = false;
            email_textbox.ReadOnly = false;
            organization_textbox.ReadOnly = false;
            PersonalInformation personalinfo = new PersonalInformation();
            personalinfo.FirstName = firstname_textbox.Text;
            personalinfo.LastName = lastname_textbox.Text;
            personalinfo.Email = email_textbox.Text;
            personalinfo.Organization = organization_textbox.Text;
            activeuser.PersonalInfo = personalinfo;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            events_datagrid.Rows.Clear();
            user_events_datagrid.Rows.Clear();
            eventsBase.WriteAllEventsinDataGrid(events_datagrid);
            eventsBase.WriteUserEventsinDataGrid(user_events_datagrid);
            NextEvent();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            if (activeuser.PersonalInfo == null)
            {
                MessageBox.Show("Заполните персональную информацию!", "Ошибка регистрации на мероприятие");
                return;
            }
            else if (events_datagrid[event_regestration_status_column.Index, events_datagrid.CurrentCell.RowIndex].Value.ToString() == "закрыта")
            {
                MessageBox.Show("Регистрация на мероприятие закрыта!", "Ошибка регистрации на мероприятие");
                return;
            }
            else
            {
                eventsBase.SignUpinEvent(Guid.Parse(events_datagrid[event_id_column.Index, events_datagrid.CurrentCell.RowIndex].Value.ToString()));
                eventsBase.WriteUserEventsinDataGrid(user_events_datagrid);
                next_event_label.Text = eventsBase.NextEvent(activeuser.Id).ToString();
            }
            NextEvent();
        }

        private void details_button_Click(object sender, EventArgs e)
        {
            Form form = new EventDetailsForm(eventsBase.GetEventId(Guid.Parse(events_datagrid[event_id_column.Index, events_datagrid.CurrentCell.RowIndex].Value.ToString())));
            form.ShowDialog();
        }
        private void NextEvent() 
        {
            Event ev = eventsBase.NextEvent(activeuser.Id);
            if (ev == null)
                next_event_label.Text = "Вы пока не зарегестрировались ни на одно мероприятие";
            else
                next_event_label.Text =  ev.ToString();
        }
    }
}
