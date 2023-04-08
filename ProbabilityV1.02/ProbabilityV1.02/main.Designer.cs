namespace ProbabilityV1._02
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.from1 = new System.Windows.Forms.ComboBox();
            this.to1 = new System.Windows.Forms.ComboBox();
            this.calculatebut = new System.Windows.Forms.Button();
            this.singleflight = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.from2 = new System.Windows.Forms.ComboBox();
            this.to2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.threeflight = new System.Windows.Forms.RadioButton();
            this.twoflight = new System.Windows.Forms.RadioButton();
            this.to3 = new System.Windows.Forms.ComboBox();
            this.from3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.swap1 = new System.Windows.Forms.Button();
            this.swap2 = new System.Windows.Forms.Button();
            this.swap3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.GroupBox();
            this.time3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ra1 = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.ra2 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.th2 = new System.Windows.Forms.RadioButton();
            this.pg2 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.ra3 = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.th3 = new System.Windows.Forms.RadioButton();
            this.pg3 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pg1 = new System.Windows.Forms.RadioButton();
            this.th1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.time2.SuspendLayout();
            this.time3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // from1
            // 
            this.from1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.from1.FormattingEnabled = true;
            this.from1.Location = new System.Drawing.Point(21, 318);
            this.from1.Name = "from1";
            this.from1.Size = new System.Drawing.Size(509, 45);
            this.from1.TabIndex = 0;
            this.from1.Text = "From";
            // 
            // to1
            // 
            this.to1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.to1.FormattingEnabled = true;
            this.to1.Location = new System.Drawing.Point(850, 318);
            this.to1.Name = "to1";
            this.to1.Size = new System.Drawing.Size(518, 45);
            this.to1.TabIndex = 1;
            this.to1.Text = "To";
            this.to1.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // calculatebut
            // 
            this.calculatebut.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculatebut.Location = new System.Drawing.Point(583, 873);
            this.calculatebut.Name = "calculatebut";
            this.calculatebut.Size = new System.Drawing.Size(196, 83);
            this.calculatebut.TabIndex = 2;
            this.calculatebut.Text = "Calculate";
            this.calculatebut.UseVisualStyleBackColor = true;
            this.calculatebut.Click += new System.EventHandler(this.button1_Click);
            // 
            // singleflight
            // 
            this.singleflight.AutoSize = true;
            this.singleflight.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.singleflight.Location = new System.Drawing.Point(38, 40);
            this.singleflight.Name = "singleflight";
            this.singleflight.Size = new System.Drawing.Size(256, 54);
            this.singleflight.TabIndex = 3;
            this.singleflight.TabStop = true;
            this.singleflight.Text = "Single flight";
            this.singleflight.UseVisualStyleBackColor = true;
            this.singleflight.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "First flight:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second flight:";
            // 
            // from2
            // 
            this.from2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.from2.FormattingEnabled = true;
            this.from2.Location = new System.Drawing.Point(21, 454);
            this.from2.Name = "from2";
            this.from2.Size = new System.Drawing.Size(509, 45);
            this.from2.TabIndex = 6;
            this.from2.Text = "From";
            // 
            // to2
            // 
            this.to2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.to2.FormattingEnabled = true;
            this.to2.Location = new System.Drawing.Point(850, 455);
            this.to2.Name = "to2";
            this.to2.Size = new System.Drawing.Size(518, 45);
            this.to2.TabIndex = 7;
            this.to2.Text = "To";
            this.to2.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.threeflight);
            this.groupBox1.Controls.Add(this.twoflight);
            this.groupBox1.Controls.Add(this.singleflight);
            this.groupBox1.Location = new System.Drawing.Point(302, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // threeflight
            // 
            this.threeflight.AutoSize = true;
            this.threeflight.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.threeflight.Location = new System.Drawing.Point(660, 40);
            this.threeflight.Name = "threeflight";
            this.threeflight.Size = new System.Drawing.Size(247, 54);
            this.threeflight.TabIndex = 5;
            this.threeflight.TabStop = true;
            this.threeflight.Text = "Three flight";
            this.threeflight.UseVisualStyleBackColor = true;
            this.threeflight.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // twoflight
            // 
            this.twoflight.AutoSize = true;
            this.twoflight.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.twoflight.Location = new System.Drawing.Point(382, 40);
            this.twoflight.Name = "twoflight";
            this.twoflight.Size = new System.Drawing.Size(221, 54);
            this.twoflight.TabIndex = 4;
            this.twoflight.TabStop = true;
            this.twoflight.Text = "Two flight";
            this.twoflight.UseVisualStyleBackColor = true;
            this.twoflight.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // to3
            // 
            this.to3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.to3.FormattingEnabled = true;
            this.to3.ItemHeight = 37;
            this.to3.Location = new System.Drawing.Point(850, 588);
            this.to3.Name = "to3";
            this.to3.Size = new System.Drawing.Size(518, 45);
            this.to3.TabIndex = 11;
            this.to3.Text = "To";
            // 
            // from3
            // 
            this.from3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.from3.FormattingEnabled = true;
            this.from3.Location = new System.Drawing.Point(21, 587);
            this.from3.Name = "from3";
            this.from3.Size = new System.Drawing.Size(509, 45);
            this.from3.TabIndex = 10;
            this.from3.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "Third flight:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(1248, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(542, 41);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // swap1
            // 
            this.swap1.BackgroundImage = global::ProbabilityV1._02.Properties.Resources.swap1;
            this.swap1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.swap1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.swap1.Location = new System.Drawing.Point(603, 312);
            this.swap1.Name = "swap1";
            this.swap1.Size = new System.Drawing.Size(176, 43);
            this.swap1.TabIndex = 13;
            this.swap1.UseVisualStyleBackColor = true;
            this.swap1.Click += new System.EventHandler(this.swap1_Click);
            // 
            // swap2
            // 
            this.swap2.BackgroundImage = global::ProbabilityV1._02.Properties.Resources.swap1;
            this.swap2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.swap2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.swap2.Location = new System.Drawing.Point(603, 454);
            this.swap2.Name = "swap2";
            this.swap2.Size = new System.Drawing.Size(176, 47);
            this.swap2.TabIndex = 14;
            this.swap2.UseVisualStyleBackColor = true;
            this.swap2.Click += new System.EventHandler(this.swap2_Click);
            // 
            // swap3
            // 
            this.swap3.BackgroundImage = global::ProbabilityV1._02.Properties.Resources.swap1;
            this.swap3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.swap3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.swap3.Location = new System.Drawing.Point(603, 587);
            this.swap3.Name = "swap3";
            this.swap3.Size = new System.Drawing.Size(176, 46);
            this.swap3.TabIndex = 15;
            this.swap3.UseVisualStyleBackColor = true;
            this.swap3.Click += new System.EventHandler(this.swap3_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Am",
            "Pm"});
            this.comboBox3.Location = new System.Drawing.Point(55, 35);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(53, 28);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox6.Location = new System.Drawing.Point(6, 35);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(43, 28);
            this.comboBox6.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Flight time";
            // 
            // time2
            // 
            this.time2.Controls.Add(this.label6);
            this.time2.Controls.Add(this.comboBox3);
            this.time2.Controls.Add(this.comboBox6);
            this.time2.Location = new System.Drawing.Point(1978, 419);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(112, 70);
            this.time2.TabIndex = 28;
            this.time2.TabStop = false;
            // 
            // time3
            // 
            this.time3.Controls.Add(this.label4);
            this.time3.Controls.Add(this.comboBox1);
            this.time3.Controls.Add(this.comboBox4);
            this.time3.Location = new System.Drawing.Point(1978, 504);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(112, 70);
            this.time3.TabIndex = 29;
            this.time3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Flight time";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Am",
            "Pm"});
            this.comboBox1.Location = new System.Drawing.Point(55, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(53, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox4.Location = new System.Drawing.Point(6, 35);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(43, 28);
            this.comboBox4.TabIndex = 21;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(32, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 120);
            this.button2.TabIndex = 54;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1337, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 31);
            this.label5.TabIndex = 55;
            this.label5.Text = "Expected to rain at flight time ?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.ra1);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 95);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(101, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 32);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ra1
            // 
            this.ra1.AutoSize = true;
            this.ra1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ra1.Location = new System.Drawing.Point(16, 38);
            this.ra1.Name = "ra1";
            this.ra1.Size = new System.Drawing.Size(60, 32);
            this.ra1.TabIndex = 0;
            this.ra1.TabStop = true;
            this.ra1.Text = "Yes";
            this.ra1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboBox2);
            this.groupBox8.Controls.Add(this.groupBox2);
            this.groupBox8.Controls.Add(this.groupBox5);
            this.groupBox8.Location = new System.Drawing.Point(1421, 289);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(475, 125);
            this.groupBox8.TabIndex = 60;
            this.groupBox8.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(1421, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 125);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.ra2);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 95);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(101, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 32);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "No";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // ra2
            // 
            this.ra2.AutoSize = true;
            this.ra2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ra2.Location = new System.Drawing.Point(16, 38);
            this.ra2.Name = "ra2";
            this.ra2.Size = new System.Drawing.Size(60, 32);
            this.ra2.TabIndex = 0;
            this.ra2.TabStop = true;
            this.ra2.Text = "Yes";
            this.ra2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.th2);
            this.groupBox6.Controls.Add(this.pg2);
            this.groupBox6.Location = new System.Drawing.Point(443, 83);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(26, 36);
            this.groupBox6.TabIndex = 57;
            this.groupBox6.TabStop = false;
            // 
            // th2
            // 
            this.th2.AutoSize = true;
            this.th2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.th2.Location = new System.Drawing.Point(6, 63);
            this.th2.Name = "th2";
            this.th2.Size = new System.Drawing.Size(159, 32);
            this.th2.TabIndex = 1;
            this.th2.TabStop = true;
            this.th2.Text = "Turkish Airines";
            this.th2.UseVisualStyleBackColor = true;
            // 
            // pg2
            // 
            this.pg2.AutoSize = true;
            this.pg2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pg2.Location = new System.Drawing.Point(6, 25);
            this.pg2.Name = "pg2";
            this.pg2.Size = new System.Drawing.Size(102, 32);
            this.pg2.TabIndex = 0;
            this.pg2.TabStop = true;
            this.pg2.Text = "Pegasus";
            this.pg2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox7);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.groupBox10);
            this.groupBox7.Location = new System.Drawing.Point(1421, 551);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(475, 125);
            this.groupBox7.TabIndex = 61;
            this.groupBox7.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.radioButton9);
            this.groupBox9.Controls.Add(this.ra3);
            this.groupBox9.Location = new System.Drawing.Point(6, 26);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(183, 95);
            this.groupBox9.TabIndex = 56;
            this.groupBox9.TabStop = false;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton9.Location = new System.Drawing.Point(101, 37);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(60, 32);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "No";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // ra3
            // 
            this.ra3.AutoSize = true;
            this.ra3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ra3.Location = new System.Drawing.Point(16, 38);
            this.ra3.Name = "ra3";
            this.ra3.Size = new System.Drawing.Size(60, 32);
            this.ra3.TabIndex = 0;
            this.ra3.TabStop = true;
            this.ra3.Text = "Yes";
            this.ra3.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.th3);
            this.groupBox10.Controls.Add(this.pg3);
            this.groupBox10.Location = new System.Drawing.Point(449, 86);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(20, 33);
            this.groupBox10.TabIndex = 57;
            this.groupBox10.TabStop = false;
            // 
            // th3
            // 
            this.th3.AutoSize = true;
            this.th3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.th3.Location = new System.Drawing.Point(6, 63);
            this.th3.Name = "th3";
            this.th3.Size = new System.Drawing.Size(159, 32);
            this.th3.TabIndex = 1;
            this.th3.TabStop = true;
            this.th3.Text = "Turkish Airines";
            this.th3.UseVisualStyleBackColor = true;
            // 
            // pg3
            // 
            this.pg3.AutoSize = true;
            this.pg3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pg3.Location = new System.Drawing.Point(6, 25);
            this.pg3.Name = "pg3";
            this.pg3.Size = new System.Drawing.Size(102, 32);
            this.pg3.TabIndex = 0;
            this.pg3.TabStop = true;
            this.pg3.Text = "Pegasus";
            this.pg3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "January",
            "February, ",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November ",
            "December"});
            this.comboBox2.Location = new System.Drawing.Point(246, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 45);
            this.comboBox2.TabIndex = 62;
            this.comboBox2.Text = "Month Selection";
            // 
            // pg1
            // 
            this.pg1.AutoSize = true;
            this.pg1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pg1.Location = new System.Drawing.Point(6, 25);
            this.pg1.Name = "pg1";
            this.pg1.Size = new System.Drawing.Size(102, 32);
            this.pg1.TabIndex = 0;
            this.pg1.TabStop = true;
            this.pg1.Text = "Pegasus";
            this.pg1.UseVisualStyleBackColor = true;
            // 
            // th1
            // 
            this.th1.AutoSize = true;
            this.th1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.th1.Location = new System.Drawing.Point(6, 63);
            this.th1.Name = "th1";
            this.th1.Size = new System.Drawing.Size(159, 32);
            this.th1.TabIndex = 1;
            this.th1.TabStop = true;
            this.th1.Text = "Turkish Airines";
            this.th1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.th1);
            this.groupBox5.Controls.Add(this.pg1);
            this.groupBox5.Location = new System.Drawing.Point(443, 87);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(26, 32);
            this.groupBox5.TabIndex = 57;
            this.groupBox5.TabStop = false;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "January",
            "February, ",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November ",
            "December"});
            this.comboBox5.Location = new System.Drawing.Point(246, 45);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(223, 45);
            this.comboBox5.TabIndex = 63;
            this.comboBox5.Text = "Month Selection";
            // 
            // comboBox7
            // 
            this.comboBox7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "January",
            "February, ",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November ",
            "December"});
            this.comboBox7.Location = new System.Drawing.Point(252, 50);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(223, 45);
            this.comboBox7.TabIndex = 64;
            this.comboBox7.Text = "Month Selection";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.swap3);
            this.Controls.Add(this.swap2);
            this.Controls.Add(this.swap1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.to3);
            this.Controls.Add(this.from3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.to2);
            this.Controls.Add(this.from2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculatebut);
            this.Controls.Add(this.to1);
            this.Controls.Add(this.from1);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.time2.ResumeLayout(false);
            this.time2.PerformLayout();
            this.time3.ResumeLayout(false);
            this.time3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox from1;
        private ComboBox to1;
        private Button calculatebut;
        private RadioButton singleflight;
        private Label label1;
        private Label label2;
        private ComboBox from2;
        private ComboBox to2;
        private GroupBox groupBox1;
        private RadioButton threeflight;
        private RadioButton twoflight;
        private ComboBox to3;
        private ComboBox from3;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button swap1;
        private Button swap2;
        private Button swap3;
        private ComboBox comboBox3;
        private ComboBox comboBox6;
        private Label label6;
        private GroupBox time2;
        private GroupBox time3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Label label5;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton ra1;
        private GroupBox groupBox8;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private RadioButton radioButton3;
        private RadioButton ra2;
        private GroupBox groupBox6;
        private RadioButton th2;
        private RadioButton pg2;
        private GroupBox groupBox7;
        private GroupBox groupBox9;
        private RadioButton radioButton9;
        private RadioButton ra3;
        private GroupBox groupBox10;
        private RadioButton th3;
        private RadioButton pg3;
        private ComboBox comboBox2;
        private GroupBox groupBox5;
        private RadioButton th1;
        private RadioButton pg1;
        private ComboBox comboBox5;
        private ComboBox comboBox7;
    }
}