using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelMain; }
            set { panelMain = null; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton2_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void BunifuImageButton3_MouseEnter(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void BunifuImageButton4_MouseEnter(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void BunifuImageButton5_MouseEnter(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void BunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void BunifuImageButton3_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void BunifuImageButton4_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void BunifuImageButton5_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            MainBase mb = new MainBase();
            mb.Dock = DockStyle.Fill;
            panelMain.Controls.Add(mb);
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(!Form1.Instance.PnlContainer.Controls.ContainsKey("LearnWord"))
            {
                LearnWord ln = new LearnWord();
                ln.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(ln);

            }
            Form1.Instance.PnlContainer.Controls["LearnWord"].BringToFront();
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("AddWord"))
            {
                AddWord aw = new AddWord();
                aw.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(aw);

            }
            Form1.Instance.PnlContainer.Controls["AddWord"].BringToFront();
        }

        private void BunifuImageButton7_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("MainBase"))
            {
                MainBase mb = new MainBase();
                mb.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(mb);

            }
            Form1.Instance.PnlContainer.Controls["MainBase"].BringToFront();
        }

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Search"))
            {
                Search sa = new Search();
                sa.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(sa);

            }
            Form1.Instance.PnlContainer.Controls["Search"].BringToFront();
        }

        private void BunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("TabSignUp"))
            {
                TabSignUp su = new TabSignUp();
                su.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(su);

            }
            Form1.Instance.PnlContainer.Controls["TabSignUp"].BringToFront();
        }
    }
 }

