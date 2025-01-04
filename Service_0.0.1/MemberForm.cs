using Service_0._0._1;
using System;
using System.Windows.Forms;

namespace Service
{
    public partial class MemberForm : Form
    {
        private readonly User activeuser;
        private readonly UsersBase usersBase;
        private readonly EventsBase eventsBase;

        public MemberForm(User activeuser)
        {
            InitializeComponent();
            this.activeuser = activeuser;
            usersBase = new UsersBase();
            eventsBase = new EventsBase(activeuser);
            next_event_label.Text = eventsBase.NextEvent(activeuser.Id).ToString();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeprofiledata_button_Click(object sender, EventArgs e)
        {
            SetProfileDataReadOnly(false);
            changeprofiledata_button.Visible = false;
            saveprofiledata_button.Visible = true;
        }

        private void saveprofiledata_button_Click(object sender, EventArgs e)
        {
            RechangePersonalInfo();
            usersBase.AddPersonalData();
            ReadPersonalInfo();
            saveprofiledata_button.Visible = false;
            changeprofiledata_button.Visible = true;
        }

        private void ReadPersonalInfo()
        {
            if (activeuser.PersonalInfo != null)
            {
                firstname_textbox.Text = activeuser.PersonalInfo.FirstName;
                lastname_textbox.Text = activeuser.PersonalInfo.LastName;
                email_textbox.Text = activeuser.PersonalInfo.Email;
                organization_textbox.Text = activeuser.PersonalInfo.Organization;
                SetProfileDataReadOnly(true);
            }
        }

        private void RechangePersonalInfo()
        {
            activeuser.PersonalInfo = new PersonalInformation
            {
                FirstName = firstname_textbox.Text,
                LastName = lastname_textbox.Text,
                Email = email_textbox.Text,
                Organization = organization_textbox.Text
            };
        }

        private void SetProfileDataReadOnly(bool isReadOnly)
        {
            firstname_textbox.ReadOnly = isReadOnly;
            lastname_textbox.ReadOnly = isReadOnly;
            email_textbox.ReadOnly = isReadOnly;
            organization_textbox.ReadOnly = isReadOnly;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            events_datagrid.Rows.Clear();
            user_events_datagrid.Rows.Clear();
            eventsBase.WriteAllEventsinDataGrid(events_datagrid);
            eventsBase.WriteUserEventsinDataGrid(user_events_datagrid);
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            if (activeuser.PersonalInfo == null)
            {
                MessageBox.Show("Заполните персональную информацию!", "Ошибка регистрации на мероприятие");
                return;
            }

            if (events_datagrid[event_regestration_status_column.Index, events_datagrid.CurrentCell.RowIndex].Value.ToString() == "закрыта")
            {
                MessageBox.Show("Регистрация на мероприятие закрыта!", "Ошибка регистрации на мероприятие");
                return;
            }

            eventsBase.SignUpinEvent(Guid.Parse(events_datagrid[event_id_column.Index, events_datagrid.CurrentCell.RowIndex].Value.ToString()));
            eventsBase.WriteUserEventsinDataGrid(user_events_datagrid);
            next_event_label.Text = eventsBase.NextEvent(activeuser.Id).ToString();
        }

        private void details_button_Click(object sender, EventArgs e)
        {
            var eventId = Guid.Parse(events_datagrid[event_id_column.Index, events_datagrid.CurrentCell.RowIndex].Value.ToString());
            using (var form = new EventDetailsForm(eventsBase.GetEventId(eventId)))
            {
                form.ShowDialog();
            }
        }
    }
}
