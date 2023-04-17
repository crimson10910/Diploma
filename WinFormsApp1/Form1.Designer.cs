namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxGoods = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDelited = new System.Windows.Forms.CheckBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSchName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSchFrom = new System.Windows.Forms.TextBox();
            this.textBoxSchTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.userNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхWipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внешнийВидWipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxGoods
            // 
            this.comboBoxGoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGoods.FormattingEnabled = true;
            this.comboBoxGoods.Items.AddRange(new object[] {
            "1 товар",
            "2 товара",
            "3 товара",
            "Отобразить все"});
            this.comboBoxGoods.Location = new System.Drawing.Point(9, 126);
            this.comboBoxGoods.Name = "comboBoxGoods";
            this.comboBoxGoods.Size = new System.Drawing.Size(241, 28);
            this.comboBoxGoods.TabIndex = 0;
            this.comboBoxGoods.SelectedIndexChanged += new System.EventHandler(this.comboBoxGoods_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(256, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(839, 555);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FlowLayoutPanel1_ControlAdded);
            this.flowLayoutPanel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FlowLayoutPanel1_ControlRemoved);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(9, 548);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 54);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.Visible = false;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(12, 687);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(94, 29);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "<<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(112, 687);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(94, 29);
            this.buttonAll.TabIndex = 4;
            this.buttonAll.Text = "Показать";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(212, 687);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(94, 29);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = ">>";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // checkBoxDelited
            // 
            this.checkBoxDelited.AutoSize = true;
            this.checkBoxDelited.ImageKey = "(нет)";
            this.checkBoxDelited.Location = new System.Drawing.Point(9, 170);
            this.checkBoxDelited.Name = "checkBoxDelited";
            this.checkBoxDelited.Size = new System.Drawing.Size(160, 24);
            this.checkBoxDelited.TabIndex = 7;
            this.checkBoxDelited.Tag = "del";
            this.checkBoxDelited.Text = "Только удаленные";
            this.checkBoxDelited.UseVisualStyleBackColor = true;
            this.checkBoxDelited.CheckedChanged += new System.EventHandler(this.checkBoxdelited_CheckedChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(9, 200);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(238, 29);
            this.buttonNew.TabIndex = 11;
            this.buttonNew.Text = "Создать";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "По названию:";
            // 
            // textBoxSchName
            // 
            this.textBoxSchName.Location = new System.Drawing.Point(9, 298);
            this.textBoxSchName.Name = "textBoxSchName";
            this.textBoxSchName.Size = new System.Drawing.Size(238, 27);
            this.textBoxSchName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Цена с:";
            // 
            // textBoxSchFrom
            // 
            this.textBoxSchFrom.Location = new System.Drawing.Point(9, 351);
            this.textBoxSchFrom.Name = "textBoxSchFrom";
            this.textBoxSchFrom.Size = new System.Drawing.Size(106, 27);
            this.textBoxSchFrom.TabIndex = 17;
            this.textBoxSchFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.defence);
            // 
            // textBoxSchTo
            // 
            this.textBoxSchTo.Location = new System.Drawing.Point(125, 351);
            this.textBoxSchTo.Name = "textBoxSchTo";
            this.textBoxSchTo.Size = new System.Drawing.Size(125, 27);
            this.textBoxSchTo.TabIndex = 18;
            this.textBoxSchTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.defence);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "До:";
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameToolStripMenuItem,
            this.базаДанныхWipToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.внешнийВидWipToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1110, 28);
            this.menuStripMain.TabIndex = 20;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // userNameToolStripMenuItem
            // 
            this.userNameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userNameToolStripMenuItem.Image")));
            this.userNameToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.userNameToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userNameToolStripMenuItem.Name = "userNameToolStripMenuItem";
            this.userNameToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.userNameToolStripMenuItem.Text = "UserName \\n \\n";
            this.userNameToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.userNameToolStripMenuItem.Click += new System.EventHandler(this.учетнаяЗаписьToolStripMenuItem_Click);
            // 
            // базаДанныхWipToolStripMenuItem
            // 
            this.базаДанныхWipToolStripMenuItem.Name = "базаДанныхWipToolStripMenuItem";
            this.базаДанныхWipToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.базаДанныхWipToolStripMenuItem.Text = "База данных (Wip)";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // внешнийВидWipToolStripMenuItem
            // 
            this.внешнийВидWipToolStripMenuItem.Name = "внешнийВидWipToolStripMenuItem";
            this.внешнийВидWipToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.внешнийВидWipToolStripMenuItem.Text = "Внешний вид (Wip)";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1110, 728);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSchTo);
            this.Controls.Add(this.textBoxSchFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSchName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.checkBoxDelited);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.comboBoxGoods);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Form1";
            this.Text = "Отображение товаров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxGoods;
        private FlowLayoutPanel flowLayoutPanel1;
        private VScrollBar vScrollBar1;
        private Button buttonLeft;
        private Button buttonAll;
        private Button buttonRight;
        private Label label1;
        private CheckBox checkBoxDelited;
        private Button buttonNew;
        private Label label2;
        private Label label3;
        private TextBox textBoxSchName;
        private Label label4;
        private TextBox textBoxSchFrom;
        private TextBox textBoxSchTo;
        private Label label5;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem базаДанныхWipToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem внешнийВидWipToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem userNameToolStripMenuItem;
    }
}