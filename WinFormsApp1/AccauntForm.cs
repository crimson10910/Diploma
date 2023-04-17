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
    public partial class AccauntForm : Form
    {
        int iid;
        public AccauntForm(int id = 1)
        {
            InitializeComponent();
            Init(id);
            
        }
        private void Init(int id)
        {
            using (TestDBContext db = new TestDBContext())
            {
                var role = db.Roles;
                foreach (var item in role)
                {
                    comboBoxRole.Items.Add(item.RoleName);
                }
                var user = db.Persons.Where(x => x.id_Person == id);
                foreach (var item in user)
                {
                    textBoxName.Text = item.FirstName;
                    textBoxPatronic.Text = item.Patronimic;
                    textBoxSurename.Text = item.SureName;
                    textBoxPhone.Text = item.PhoneNumber;
                    textBoxLogin.Text = item.Login;
                    textBoxEmail.Text = item.EMail;
                    dateTimePickerBD.Value = Convert.ToDateTime(item.BDay);
                    comboBoxRole.SelectedIndex = item.id_Role - 1;

                    //pictureBox1.Image

                }
                iid = id;
            }
        }
        private void AccauntForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Сохранить текущие данные?",
                "Сохранение изменений", MessageBoxButtons.YesNo);
            //e.Cancel = true;
            if (dialog == DialogResult.Yes)
            {
                using (TestDBContext dbo = new TestDBContext())
                {
                   
                    var user = dbo.Persons.Where(x => x.id_Person == iid);
                    foreach (var item in user)
                    {
                        if (textBoxName.Text != item.FirstName ||
                            textBoxPatronic.Text != item.Patronimic ||
                            textBoxSurename.Text != item.SureName ||
                            textBoxPhone.Text != item.PhoneNumber ||
                            textBoxLogin.Text != item.Login ||
                            textBoxEmail.Text != item.EMail ||
                            dateTimePickerBD.Value != Convert.ToDateTime(item.BDay) ||
                            comboBoxRole.SelectedIndex != item.id_Role - 1)
                        {
                            item.FirstName = textBoxName.Text;
                            item.Patronimic = textBoxPatronic.Text;
                            item.SureName = textBoxSurename.Text;
                            item.PhoneNumber = textBoxPhone.Text;
                            item.Login = textBoxLogin.Text;
                            item.EMail = textBoxEmail.Text;
                            item.BDay = dateTimePickerBD.Value;
                            if (item.Photo == "" || item.Photo == null)
                            {
                                item.Photo = "";
                            }
                            
                            //item.
                            //item.
                            //item.
                            //await db.SaveChangesAsync();
                        }
                        dbo.Update(item);
                       
                    }
                    dbo.SaveChanges();
                }
                e.Cancel = false;
                return;
            }
            if(dialog == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                e.Cancel=false;
                return;
            }

        }

        private void AccauntForm_Load(object sender, EventArgs e)
        {

        }
    }
}

