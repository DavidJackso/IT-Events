using Renci.SshNet.Security;
using System;
using System.IO;
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

        private void login_form_Load(object sender, EventArgs e)
        {
            if (!File.Exists("data/server/key.pub"))
            {
                File.Create("data/server/key.pub");
                File.WriteAllText("data/server/key.pub", "-----BEGIN RSA PRIVATE KEY-----\r\nMIIEpAIBAAKCAQEAvD3JHBlmkvS+yRcUK5fPi6FQVfS/UBXs9IwDDz/2yChRT5mc\r\nbO+6adTK6mPROK+NpbaB914b/H0y74lAvktPzDJ0PFBmAvHJ8E23o8ODzysTCMZ5\r\n/YlQGeXGQOE+7pK6czA/RjbiJYns/mlvq7JNBrIQNbHE7XudxpUhlz86ePZryhg3\r\n+NxG2CNRqRy8cGqbL4QwTG5KnIU5M1cTmLTxnQG1MN+PSJQgDySdmR4ZdSmW2V06\r\nBE+x3NEAo7aWy83i7BlrB3tF02g+s2p3DqOfyf2OrAYryFn+HPRrk/U5lMdBtl7Y\r\nD9JrelMa7X/DKVMcRB+DbB1i1iroQg0/l/pneQIDAQABAoIBACKqai/PibFEeyID\r\nKwbAJUt8gJPjx5uS/hkm86VKTUMdEaRMEJ+LIlQ9CMVTboM26Sn8S0DnxtWfpNKx\r\n/wdMTTy4ielVkQO3zU2AsnHpHov3TcEO9AY51FOAmhr2oCVFRirSVsSydMEe/lL3\r\nzcXbxw2VmyCYRUDKxAp/CjmVPkpqHh9s5IrxZ+PXDsr60selQ7Uz7hYov19TV06v\r\nq2l6nDxuMSkQvGwZrdvbc53H7OOgATYac14E2Rhxz1+KhMVJ6L2X89cwNb1WuVZJ\r\nmuo/FJaTb+XiaQ6Nom33dCLTBlQMtTeM90mA2nJBcXRsz+Ih2bWTe2TI0aGJFqq6\r\nfZFwiHUCgYEA3625aHaVRcE/yNy9K8b670xvmeTXG4lfyn5i5z+oE+/SbuXWbRSf\r\nb3XjZaU56SUT1sE50DA0pXhEk9ZN5s9lSqnBciPDIwakbnV+Zw7ICctEtvDVQ92T\r\n+FTLnTd8j1WhvUjiH7Vy1UgcQZl7kFpiN67ab5oONkDyaLydthUSvasCgYEA13Es\r\nTpb1pBfzUssb16AJ5EyiyEq5tGhsCBtc3tae/0DT8nXXqIm7gT5WFJwQl1MkQy2h\r\n80+HsMu+bI/FX9/tsgqgvT18FoycpJaxYzb8d5BhRam00hdjOGv/nIeiEP4yUsQy\r\nBGLFJdZUNixTA2xgndWJRcnzt8Ot9l9WNFlkY2sCgYEAtIZENoBGV2bxcM5eyt8s\r\nFUguZhkgVvQXYJmCfzqMD5Ml1iUfWygiyVVu8tFYHMe07EVEwLa3NrkLN/nlI5xN\r\nFuZM3y7nxfQNb6zaGJkAb48jZTaYGM7TJsBhGQD4QcKN5/PTtF3AUUyCqZsS891O\r\nmbxARYQjZjwiqM9ZxePaHUMCgYAVHVNhVGw4q9w+Fgfhhx7REC24AZLXupAz7zKX\r\n6GLm01yyW5hKPU1yKkDXfkAmBJD+QH+pz/aVfjJog2Kttc2e8Gm2gksiDp/fhaFW\r\n/vGZaj4OTMaa/I3N3s/LcIOStMcL04yvX1rBDZNtR8TPBhUmAuKUQ2mubfAjwE47\r\njTNIhwKBgQDVY7qwtjXogRjA5R6u5xYUt8sOxXrMNoQdSZmH250GYfRlHZ00ZY8G\r\nBUsqVrynakpOyHMwJgaMV0Dj8CbL27UZ6WeKQsFlcSSIaHbjCuFZ5R0Spk7FmTw4\r\nHmwR0a09p0gMifkdDLMpcwYGhi7yTbzsivbDxQ8zGzeiPLG6YSZH1g==\r\n-----END RSA PRIVATE KEY-----\r\n");
            } 
            Server server = new Server();
            server.DownloadBases();
        }
    }
}
