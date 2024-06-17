using System;
using System.Windows.Forms;

namespace Service
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            User loginuser = new User(username_textbox_login.Text, password_textbox_login.Text, "", Guid.NewGuid());
            if (new UsersDateBase().SucessLogin(loginuser))
            {
                loginuser = new UsersDateBase().GetUser(loginuser);
                if (loginuser.Role == "organizator")
                {
                    OraganizatorForm f = new OraganizatorForm(loginuser);
                    f.Show();
                }
                else
                {
                    MemberForm m = new MemberForm(loginuser);
                    m.Show();
                }
                this.Visible = false;
            }
            else
                MessageBox.Show("Данные для входа введены неверно!", "Ошибка аунтефикации.");
        }
        private void regestration_button_Click(object sender, EventArgs e)
        {
            string role = null;
            if (role_rbutton_member.Checked)
                role = "member";
            if (role_rbutton_organizator.Checked)
                role = "organizator";

            if (new ValidData().RegestrationDataisValid(username_textbox_reg.Text, password_textbox_reg.Text, repeatpass_textbox_reg.Text, role))
            {
                User regestrationuser = new User(username_textbox_reg.Text, password_textbox_reg.Text, role, Guid.NewGuid());
                UsersDateBase adduser = new UsersDateBase(regestrationuser);
                adduser.AddUser();
            }
        }
    }
}
