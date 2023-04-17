using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EnterWindow : Form
    {
        public EnterWindow()
        {
            InitializeComponent();
            this.Text = SettingsGeneral.Default.ProgrammName + " - Вход";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            TestDBContext dBContext = new TestDBContext();

            var result = dBContext.Persons.Where(x => x.Login == textBoxLogin.Text);
            foreach (var login in result)
            {
                if (login.Password == textBoxPassword.Text)
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();

                }
                else
                {
                    this.Text = "Error";
                }
            }
        }

        private void EnterWindow_Load(object sender, EventArgs e)
        {

        }

        private void EnterWindow_VisibleChanged(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
        }
    }
}
