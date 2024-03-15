namespace identify
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Tecnologico Campus Monclova");
            button1 = new Button();
            checkBox1 = new CheckBox();
            notifyIcon1 = new NotifyIcon(components);
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            listView1 = new ListView();
            maskedTextBox1 = new MaskedTextBox();
            monthCalendar1 = new MonthCalendar();
            numericUpDown1 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            radioButton1 = new RadioButton();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            treeView1 = new TreeView();
            radioButton2 = new RadioButton();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.BackgroundImage = Properties.Resources._20220917_021400000_iOS;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Snap ITC", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.InactiveCaption;
            button1.Image = Properties.Resources._20220917_021400000_iOS;
            button1.Location = new Point(2, 2);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ActiveCaption;
            checkBox1.Location = new Point(83, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Bueno";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Hola", "Que onda" });
            checkedListBox1.Location = new Point(183, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 40);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Queso", "Totillas", "Coca" });
            comboBox1.Location = new Point(321, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(448, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(657, 10);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 5;
            label1.Text = "Texto";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(701, 10);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Tecnologico", "Nacional ", "Campus", "Monclova" });
            listBox1.Location = new Point(2, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 34);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(128, 71);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 34);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(255, 71);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 9;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(367, 55);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(619, 34);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.af905e1e28f3c9484e00127e5738e062__pop_art_illustration_art_illustrations;
            pictureBox1.Location = new Point(2, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(420, 262);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 13;
            progressBar1.Click += progressBar1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(567, 262);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(56, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mujer";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(420, 326);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(676, 267);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(571, 326);
            treeView1.Name = "treeView1";
            treeNode1.BackColor = Color.FromArgb(255, 192, 192);
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "Tecnologico Campus Monclova";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1 });
            treeView1.Size = new Size(217, 97);
            treeView1.TabIndex = 17;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(567, 287);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 19);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hombre";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = SystemColors.ActiveCaption;
            checkBox2.Location = new Point(83, 30);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(70, 19);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Exelente";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(radioButton2);
            Controls.Add(treeView1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(monthCalendar1);
            Controls.Add(maskedTextBox1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "   ";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private NotifyIcon notifyIcon1;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
        private ListView listView1;
        private MaskedTextBox maskedTextBox1;
        private MonthCalendar monthCalendar1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private ToolTip toolTip1;
        private TreeView treeView1;
        private RadioButton radioButton2;
        private CheckBox checkBox2;
    }
}
