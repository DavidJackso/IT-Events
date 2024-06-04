using Service_0._0._1;
using System;
using System.Windows.Forms;

namespace Service
{
    public partial class OraganizatorForm : Form
    {
        User activeuser;
        UsersBase usersBase = new UsersBase();
        EventsBase eventsBase;
        public OraganizatorForm(User activeuser)
        {
            this.activeuser = activeuser;
            eventsBase = new EventsBase(activeuser);
            InitializeComponent();
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Changeprofiledata_button_Click(object sender, EventArgs e)
        {
            firstname_textbox.ReadOnly = false;
            lastname_textbox.ReadOnly = false;
            email_textbox.ReadOnly = false;
            organization_textbox.ReadOnly = false;
            changeprofiledata_button.Visible = false;
            saveprofiledata_button.Visible = true;
        }

        private void Saveprofiledata_button_Click(object sender, EventArgs e)
        {
            RechangePersonalInfo(activeuser);
            usersBase = new UsersBase(activeuser);
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

        private void OraganizatorForm_Load(object sender, EventArgs e)
        {
            saveprofiledata_button.Visible = false;
            events_datagrid.ClearSelection();
            ReadPersonalInfo(activeuser);
            eventsBase.WriteUserEventsinDataGrid(events_datagrid);
            HideEventPanel();
        }

        private void Add_new_event_button_Click(object sender, EventArgs e)
        {
            if (activeuser.PersonalInfo == null)
                MessageBox.Show("Заполните персональную информацию!", "Заполните профиль");
            else
            {
                ShowEventPanel();
            }
        }

        private void Rechange_event_button_Click(object sender, EventArgs e)
        {
            if (events_datagrid.Rows.Count > 0)
            {
                ShowEventPanel();

                int rowindex = events_datagrid.CurrentCell.RowIndex;
                Event ev = eventsBase.GetEventId(Guid.Parse(events_datagrid[eventid_column.Index, rowindex].Value.ToString()));
                event_name_textbox.Text = ev.Name;
                event_type_textbox.Text = ev.Type;
                event_data_textbox.Text = ev.EventData.ToString("dd.MM.yyyy HH:mm");
                event_regestrationclose_textbox.Text = ev.DataEndRegestration.ToString("dd.MM.yyyy HH:mm");
                event_organizator_textbox.Text = ev.Organizator;
                event_location_textbox.Text = ev.EventLocation;
                event_description_textbox.Text = ev.Description;
            }
            else
                MessageBox.Show("Создайте мероприятие", "Ошибка");
        }

        private void Save_event_button_Click(object sender, EventArgs e)
        {
            DateTime closeregesration, eventdata;
            try
            {
                closeregesration = DateTime.ParseExact(event_regestrationclose_textbox.Text, $"dd.MM.yyyy HH:mm", null);
                eventdata = DateTime.ParseExact(event_data_textbox.Text, $"dd.MM.yyyy HH:mm", null);
                Guid eventid = Guid.NewGuid();
                if (new ValidData().EventDataisValid(event_name_textbox.Text, event_type_textbox.Text, event_organizator_textbox.Text, event_location_textbox.Text, event_description_textbox.Text, eventdata))
                {
                    Event ev = new Event(eventid, event_name_textbox.Text, event_type_textbox.Text, eventdata, closeregesration, true, event_organizator_textbox.Text, event_location_textbox.Text, event_description_textbox.Text, null);
                    eventsBase.AddEvent(ev);
                    eventsBase.WriteUserEventsinDataGrid(events_datagrid);

                    HideEventPanel();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Допущена ошибка в полях заполнения времени!\nЗначения времени обязаны заполняться в формате день.месяц.год час:минуты", "Ошибка в заполнение данных");
            }
        }
        private void ShowEventPanel()
        {
            add_event_mp.Visible = true;
            save_event_button.Visible = true;
            add_new_event_button.Visible = false;
            rechange_event_button.Visible = false;
            members_list_button.Visible = false;
            cancel_button.Visible = true;
        }
        private void HideEventPanel()
        {
            cancel_button.Visible = false;
            add_event_mp.Visible = false;
            save_event_button.Visible = false;
            add_new_event_button.Visible = true;
            rechange_event_button.Visible = true;
            members_list_button.Visible = true;
        }
        private void Members_list_button_Click(object sender, EventArgs e)
        {
            int rowindex = events_datagrid.CurrentCell.RowIndex;
            Event ev = eventsBase.GetEventId(Guid.Parse(events_datagrid[eventid_column.Index, rowindex].Value.ToString()));
            if (ev.Members.Count == 0)
                MessageBox.Show("На ваше мероприятие еще никто не записан");
            else
            {
                Form form = new MembersListForm(eventsBase.GetEventId(Guid.Parse(events_datagrid[eventid_column.Index, rowindex].Value.ToString())));
                form.ShowDialog();
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            event_name_textbox.Clear();
            event_data_textbox.Clear();
            event_regestrationclose_textbox.Clear();
            event_location_textbox.Clear();
            event_description_textbox.Clear();
            event_organizator_textbox.Clear();

            HideEventPanel();
        }
    }
}
