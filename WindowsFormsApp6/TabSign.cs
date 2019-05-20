using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class TabSign : UserControl
    {
        public TabSign()
        {
            InitializeComponent();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("TabSignUp"))
            {
                TabSignUp su = new TabSignUp();
                su.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(su);

            }
            Form1.Instance.PnlContainer.Controls["TabSignUp"].BringToFront();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Classes.Login lgn = new Classes.Login();
            
            string[] user = lgn.userLogin(userNameText.Text, passText.Text);
            if (user == null)
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
            }
            else if (user[0] == "PAROLA_HATASI")
            {
                MessageBox.Show("Parolanızı yanlış girdiniz.");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı");
            }
           

        }

        
        private void PassText_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TabSign_Load(object sender, EventArgs e)
        {
           
        }
    }
}
