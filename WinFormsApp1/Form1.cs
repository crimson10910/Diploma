using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        
        Size panelSize = new Size(800, 135);
        string Label = "Редактор БД";
        string labIndex = "Индекс:";
        string labName = "Наименование";
        decimal from = -1;
        decimal to = 99999999;
        string adminName = "";
        string adminSurename = "";
        string adminRole = "";

        int lastIndexInSearch = 0;
        int startindex = 0;
        int maxRowsInSearch = 230;
        int stap = 0;
        int DbCount = 0;
        int userId = 0;
        bool showDelited = false;
        bool showAll = false;
        bool rbPressed = false;
        bool lbPressed = false;
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            //Taxes: Remote Desktop Connection and painting
            //http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                System.Reflection.PropertyInfo aProp =
                      typeof(System.Windows.Forms.Control).GetProperty(
                            "DoubleBuffered",
                            System.Reflection.BindingFlags.NonPublic
                            | System.Reflection.BindingFlags.Instance);
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                aProp.SetValue(c, true, null);
            }
        }
        public void InterfaceInit(int id = 1)
        {
            using (TestDBContext db = new TestDBContext())
            {
                int roleId = 0;
                var user = db.Persons.Where(x => x.id_Person == id);
                foreach (var item in user)
                {
                    roleId = item.id_Role;
                    adminName = item.FirstName;
                    adminSurename = item.SureName;
                }
                var role = db.Roles.Where(x => x.id_Role == roleId);
                foreach (var item in role)
                {
                    adminRole = item.RoleName;
                }

            }
            userNameToolStripMenuItem.Text = adminName;
            //userNameToolStripMenuItem.ForeColor
        }
        public Form1(int id = 0)
        {
            InitializeComponent();
            InterfaceInit();
            comboBoxGoods.SelectedIndex = 0;
            stap = comboBoxGoods.SelectedIndex + 1;
            this.Text = SettingsGeneral.Default.ProgrammName;
            //      Необходимо для плавного скроллинга
            vScrollBar1.Hide();
            vScrollBar1.Value = flowLayoutPanel1.VerticalScroll.Value;
            vScrollBar1.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            vScrollBar1.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;
            UpdateData();
            
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            SetDoubleBuffered(flowLayoutPanel1);
            if (FlowLayoutPanel1_ControlAdded != null)
            {
                flowLayoutPanel1.ControlAdded += FlowLayoutPanel1_ControlAdded;
            }
            if (FlowLayoutPanel1_ControlRemoved != null)
            {
                flowLayoutPanel1.ControlRemoved += FlowLayoutPanel1_ControlRemoved;
            }
            //          ...............................
            //enterWindow.Hide();
        }
        void StartToZero()
        {
            startindex = 0;
        }
        void UpdateData()
        {
            using (TestDBContext db = new TestDBContext())
            {
                DbCount = db.Products.Where(x => x.Status >= Convert.ToInt32(showDelited)
                && x.ProductName.Contains(textBoxSchName.Text)
                && x.ProductPrice>= from
                && x.ProductPrice <= to)
                    .Skip(startindex)
                    .Count();
            }
        }
        int Showing(int index, int stap = 230, int skip = 0, int take = 1)
        {
            //     Инициализция объектов 
            flowLayoutPanel1.Controls.Clear();
            TestDBContext db = new TestDBContext();
            if (textBoxSchFrom.Text != string.Empty)
            {
                from = Convert.ToDecimal(textBoxSchFrom.Text);
            }
            if (textBoxSchTo.Text != string.Empty)
            {
                to = Convert.ToDecimal(textBoxSchTo.Text);
            }

            if (stap < 4)
            {
                take = comboBoxGoods.SelectedIndex + 1;
            }
            else
            {
                take = db.Products.Where(x => x.Status >= Convert.ToInt32(showDelited)
                && x.ProductName.Contains(textBoxSchName.Text)
                && x.ProductPrice >= from
                && x.ProductPrice <= to)
                    .Count();
            }

            // полечение данных, удовлетворяющих определенные условия
            var input = db.Products.Where(x => 
                x.Status >= Convert.ToInt32(showDelited)
                && x.ProductName.Contains(textBoxSchName.Text)
                && x.ProductPrice >= from
                && x.ProductPrice <= to)
                .Skip(startindex)
                .Take(take);


            int cur = 0;

            foreach (Product u in input)
            {
                // Инициализация
                Panel panel = new Panel();
                Label lableIndex = new Label();
                Label lableName = new Label();
                Label labelPrice = new Label();
                Label labelBoxPrice = new Label();
                Label labelStatus = new Label();
                TextBox textBoxIndex = new TextBox();
                TextBox textBoxName = new TextBox();
                TextBox textBoxPrice = new TextBox();
                TextBox textBoxStatus = new TextBox();
                PictureBox picture = new PictureBox();
                Button buttonEdit = new Button();
                Button buttonDelete = new Button();
                // ............................
                

                panel.MaximumSize = panelSize;
                panel.MinimumSize = panelSize;
                panel.Size = panelSize;
                // panel.Size = new Size(flowLayoutPanel1.Width, flowLayoutPanel1.Height);   // wtf
                panel.BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanel1.Controls.Add(panel);

                //          LableIndex
                lableIndex.Text = labIndex;
                //lableIndex.Font() = new Font(); 
                lableIndex.BorderStyle = BorderStyle.None;
                lableIndex.Size = new Size(80, 16);
                panel.Controls.Add(lableIndex);
                Point currentLocationLableIndex = lableIndex.Location;

                //          lableName
                lableName.Text = labName;
                lableName.BorderStyle = BorderStyle.None;
                lableName.Size = new Size(80, 16);
                lableName.Location = new Point(lableIndex.Location.X, lableIndex.Location.Y + 16 + 2);
                panel.Controls.Add(lableName);
                Point currentLocationLableName = lableName.Location;


                //          labelBoxPrice
                labelBoxPrice.Text = "Цена руб.";
                labelBoxPrice.BorderStyle = BorderStyle.None;
                labelBoxPrice.Size = new Size(80, 16);
                labelBoxPrice.Location = new Point(lableIndex.Location.X, lableName.Location.Y + 16 + 2);
                panel.Controls.Add(labelBoxPrice);
                Point currentLocationLabelPrice = labelBoxPrice.Location;


                //          labelBoxStatus
                labelStatus.Text = "Статус:";
                labelStatus.BorderStyle = BorderStyle.None;
                labelStatus.Size = new Size(80, 16);
                labelStatus.Location = new Point(lableIndex.Location.X, currentLocationLabelPrice.Y + 16 + 2);
                panel.Controls.Add(labelStatus);
                Point currentLocationLabelStatus = labelStatus.Location;


                //          TextboxName
                textBoxName.Text = u.ProductName.ToString();
                textBoxName.Size = new Size(150, 16);

                textBoxName.Location = new Point(lableName.Location.X + lableName.Width, lableName.Location.Y);
                textBoxName.BorderStyle = BorderStyle.None;
                panel.Controls.Add(textBoxName);

                //          TextBoxIndex
                textBoxIndex.Text = Convert.ToString(u.id_Product);
                textBoxIndex.Size = new Size(150, 16);
                textBoxIndex.Location = new Point(lableIndex.Size.Width, currentLocationLableIndex.Y);
                textBoxIndex.BorderStyle = BorderStyle.None;
                panel.Controls.Add(textBoxIndex);

                //          TextBoxPrice
                textBoxPrice.Text = Convert.ToString(u.ProductPrice);
                textBoxPrice.Size = new Size(150, 16);
                textBoxPrice.Location = new Point(labelBoxPrice.Size.Width, currentLocationLabelPrice.Y);
                textBoxPrice.BorderStyle = BorderStyle.None;
                textBoxPrice.ReadOnly = true;
                panel.Controls.Add(textBoxPrice);

                //          TextBoxPrice
                //if (u.Status == false)
                //{
                  //  textBoxStatus.Text = "Закончился";
                //}
                //else
                //{
                  //  textBoxStatus.Text = "В наличие";
                //}
                textBoxStatus.Size = new Size(150, 16);
                textBoxStatus.Location = new Point(labelStatus.Size.Width, currentLocationLabelStatus.Y);
                textBoxStatus.BorderStyle = BorderStyle.None;
                textBoxStatus.ReadOnly = true;
                panel.Controls.Add(textBoxStatus);
                //////////////////////////////////////
                //          OTHER OBJECTS           //
                //////////////////////////////////////



                //          Picturebox
                picture.Location = new Point(panelSize.Width - panelSize.Height, 0);
                picture.BorderStyle = BorderStyle.FixedSingle;
                picture.Size = new Size(panelSize.Height, panelSize.Height);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;

                //MemoryStream ms = new MemoryStream(u.Picture);
                if (u.ProductPicture != null)
                {
                    picture.Image = System.Drawing.Image.FromFile(u.ProductPicture);
                }
                picture.ResetText();
                panel.Controls.Add(picture);
                cur++;
                lastIndexInSearch = u.id_Product;
                //label1.Text = Convert.ToString(lastIndexInSearch);

                //          ButtonChange
                buttonEdit.Location = new Point(picture.Location.X - 80, picture.Location.Y + picture.Size.Width - 32);
                buttonEdit.Size = new Size(80, 32);
                buttonEdit.Tag = u.id_Product;
                buttonEdit.Text = "Изменить";
                buttonEdit.Click += new EventHandler(Edit_Click);
                panel.Controls.Add(buttonEdit);


                //              ButtonDelete
                buttonDelete.Location = new Point(buttonEdit.Location.X, buttonEdit.Location.Y - 32);
                buttonDelete.Size = new Size(80, 32);
                buttonDelete.Tag = u.id_Product;
                buttonDelete.Text = "Удалить";
                buttonDelete.Click += new EventHandler(Delete_Click);
                panel.Controls.Add(buttonDelete);

                if (cur > stap)
                {
                    break;
                }

            }
            return lastIndexInSearch;
            //}

        }
        private async void Edit_Click(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            Button b = (Button)sender;
            int tag = (int)b.Tag;
            EditWindow edit = new EditWindow(tag);
            edit.Show();
        }
        private async void Delete_Click(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            Button c = (Button)sender;
            int tag = (int)c.Tag;

            using (TestDBContext db = new TestDBContext())
            {
                var input = db.Products.Skip(tag).Take(1);
                foreach (var item in input)
                {
                    //item.Status = false; ;
                }
                db.SaveChanges();
            }
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewWindow nw = new NewWindow();
            nw.Show();
        }
        void ShowCarrentL(int curr, int stap)
        {
            flowLayoutPanel1.Controls.Clear();
            lastIndexInSearch -= Showing(curr, stap, lastIndexInSearch, stap);
        }
        void ShowCarrentR(int curr, int stap)
        {
            flowLayoutPanel1.Controls.Clear();
            lastIndexInSearch = Showing(curr, stap, lastIndexInSearch, stap);

        }

        void ShowAll()
        {
            Cursor = Cursors.WaitCursor;
            Showing(0, DbCount, 0, DbCount);
            label1.Text = "Найдено " + DbCount + " записей.";
            //label1.Text = Convert.ToString(startindex) + Convert.ToString(stap) + Convert.ToString(DbCount);
            Cursor = Cursors.Default;
        }
        private void FlowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            vScrollBar1.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
        }
        private void FlowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            vScrollBar1.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel1.VerticalScroll.Value = vScrollBar1.Value;
        }
        private void comboBoxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            startindex = 0;
            stap = comboBoxGoods.SelectedIndex + 1;
            if (comboBoxGoods.SelectedIndex == 0)
            {
                buttonLeft.Show();
                buttonRight.Show();
                buttonAll.Hide();
                return;
            }
            if (comboBoxGoods.SelectedIndex == 1)
            {
                buttonLeft.Show();
                buttonRight.Show();
                buttonAll.Hide();
                return;
            }
            if (comboBoxGoods.SelectedIndex == 2)
            {
                buttonLeft.Show();
                buttonRight.Show();
                buttonAll.Hide();
                return;
            }
            else
            {
                buttonRight.Hide();
                buttonLeft.Hide();
                buttonAll.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ShowAll();
            Cursor = Cursors.Default;
        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            if (startindex - comboBoxGoods.SelectedIndex - stap < 0)
            {
                startindex = 0;
               // this.Text += Convert.ToString(startindex) + " )";
            }
            else
            {
                startindex -= (comboBoxGoods.SelectedIndex + 1);
             //   this.Text += Convert.ToString(startindex) + " (";
            }
            ShowCarrentL(startindex, stap);
            Cursor = Cursors.Default;
            lbPressed = true;
            rbPressed = false;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (rbPressed && startindex + comboBoxGoods.SelectedIndex + 1 < DbCount)
            {
                startindex += comboBoxGoods.SelectedIndex + 1;
            }
            if (startindex == DbCount)
            {
                //startindex = startindex;
                rbPressed = true;
                lbPressed = false;
                return;
            }
            Cursor = Cursors.WaitCursor;
            ShowCarrentR(startindex, stap);


            Cursor = Cursors.Default;
            rbPressed = true;
            lbPressed = false;
        }

        private void checkBoxdelited_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;
            UpdateData();
            StartToZero();

            if (ch.Tag.ToString() == "del")
            {
                showDelited = checkBoxDelited.Checked;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void defence(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            //Text = textBox.Text;
            e.Handled = true;
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            if (textBox.Text.Contains(',') == false && (textBox.Text != "" && textBox.Text != "-") && e.KeyChar == ',')
            {
                e.Handled = false;
                return;
            }

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            EnterWindow enterWindow = new EnterWindow();
            enterWindow.Show();
        }

        private void учетнаяЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccauntForm accauntForm = new AccauntForm();
            Form1 form1 = new Form1();
            accauntForm.Show();
            form1.Enabled = false;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //userNameToolStripMenuItem.Image = Image.FromFile(@"\DefaultImages\");
            userNameToolStripMenuItem.Text = adminName + "\n" + adminSurename + "\n" + adminRole;
        }
    }
}