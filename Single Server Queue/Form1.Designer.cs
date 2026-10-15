namespace WinFormsApp1
{
    partial class system_box
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            lblservice2 = new Label();
            arrival_input2 = new TextBox();
            labelservice1 = new Label();
            service_input1 = new TextBox();
            service_rate_label = new Label();
            service_dist_lbl = new Label();
            modelbox = new ComboBox();
            service_input2 = new TextBox();
            arrival_input1 = new TextBox();
            servicedist = new ComboBox();
            label2 = new Label();
            servicewise = new ComboBox();
            lbl_arrival_input1 = new Label();
            Servicetimeunit = new ComboBox();
            arrivaldistlbl = new Label();
            arrivaldist = new ComboBox();
            label3 = new Label();
            timebox = new ComboBox();
            wisebox = new ComboBox();
            label6 = new Label();
            arrivalwise_lbl = new Label();
            lbl_arrival_input2 = new Label();
            label7 = new Label();
            Title = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label10 = new Label();
            label18 = new Label();
            wtime = new Label();
            label17 = new Label();
            wqtime = new Label();
            label15 = new Label();
            displaytimebox = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            labelL = new Label();
            labelrho = new Label();
            labelW = new Label();
            labelLq = new Label();
            labelWq = new Label();
            Calculate = new Button();
            mainLayout = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            mainLayout.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 446);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "System Parameter";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.80851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.19149F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lblservice2, 0, 12);
            tableLayoutPanel1.Controls.Add(arrival_input2, 1, 6);
            tableLayoutPanel1.Controls.Add(labelservice1, 0, 11);
            tableLayoutPanel1.Controls.Add(service_input1, 1, 11);
            tableLayoutPanel1.Controls.Add(service_rate_label, 0, 10);
            tableLayoutPanel1.Controls.Add(service_dist_lbl, 0, 8);
            tableLayoutPanel1.Controls.Add(modelbox, 1, 0);
            tableLayoutPanel1.Controls.Add(service_input2, 1, 12);
            tableLayoutPanel1.Controls.Add(arrival_input1, 1, 5);
            tableLayoutPanel1.Controls.Add(servicedist, 1, 8);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(servicewise, 1, 10);
            tableLayoutPanel1.Controls.Add(lbl_arrival_input1, 0, 5);
            tableLayoutPanel1.Controls.Add(Servicetimeunit, 1, 9);
            tableLayoutPanel1.Controls.Add(arrivaldistlbl, 0, 2);
            tableLayoutPanel1.Controls.Add(arrivaldist, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(timebox, 1, 3);
            tableLayoutPanel1.Controls.Add(wisebox, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 7);
            tableLayoutPanel1.Controls.Add(arrivalwise_lbl, 0, 4);
            tableLayoutPanel1.Controls.Add(lbl_arrival_input2, 0, 6);
            tableLayoutPanel1.Controls.Add(label7, 0, 9);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(612, 416);
            tableLayoutPanel1.TabIndex = 26;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Model:";
            // 
            // lblservice2
            // 
            lblservice2.AutoSize = true;
            lblservice2.Font = new Font("Segoe UI", 9F);
            lblservice2.Location = new Point(3, 383);
            lblservice2.Name = "lblservice2";
            lblservice2.Size = new Size(93, 20);
            lblservice2.TabIndex = 20;
            lblservice2.Text = "Service Rate:";
            lblservice2.Click += lblservice2_Click;
            // 
            // arrival_input2
            // 
            arrival_input2.Dock = DockStyle.Fill;
            arrival_input2.Font = new Font("Segoe UI", 9F);
            arrival_input2.Location = new Point(289, 195);
            arrival_input2.Name = "arrival_input2";
            arrival_input2.Size = new Size(320, 27);
            arrival_input2.TabIndex = 25;
            // 
            // labelservice1
            // 
            labelservice1.AutoSize = true;
            labelservice1.Font = new Font("Segoe UI", 9F);
            labelservice1.Location = new Point(3, 350);
            labelservice1.Name = "labelservice1";
            labelservice1.Size = new Size(93, 20);
            labelservice1.TabIndex = 18;
            labelservice1.Text = "Service Rate:";
            // 
            // service_input1
            // 
            service_input1.Dock = DockStyle.Fill;
            service_input1.Font = new Font("Segoe UI", 9F);
            service_input1.Location = new Point(289, 353);
            service_input1.Name = "service_input1";
            service_input1.Size = new Size(320, 27);
            service_input1.TabIndex = 19;
            // 
            // service_rate_label
            // 
            service_rate_label.AutoSize = true;
            service_rate_label.Font = new Font("Segoe UI", 9F);
            service_rate_label.Location = new Point(3, 316);
            service_rate_label.Name = "service_rate_label";
            service_rate_label.Size = new Size(106, 20);
            service_rate_label.TabIndex = 11;
            service_rate_label.Text = "Value given as:";
            service_rate_label.Click += label8_Click;
            // 
            // service_dist_lbl
            // 
            service_dist_lbl.AutoSize = true;
            service_dist_lbl.Font = new Font("Segoe UI", 9F);
            service_dist_lbl.Location = new Point(3, 248);
            service_dist_lbl.Name = "service_dist_lbl";
            service_dist_lbl.Size = new Size(90, 20);
            service_dist_lbl.TabIndex = 16;
            service_dist_lbl.Text = "Distribution:";
            // 
            // modelbox
            // 
            modelbox.Dock = DockStyle.Fill;
            modelbox.DropDownStyle = ComboBoxStyle.DropDownList;
            modelbox.Font = new Font("Segoe UI", 9F);
            modelbox.FormattingEnabled = true;
            modelbox.Items.AddRange(new object[] { "M/M/1", "M/G/1", "G/G/1" });
            modelbox.Location = new Point(289, 3);
            modelbox.Name = "modelbox";
            modelbox.Size = new Size(320, 28);
            modelbox.TabIndex = 1;
            modelbox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // service_input2
            // 
            service_input2.Dock = DockStyle.Fill;
            service_input2.Font = new Font("Segoe UI", 9F);
            service_input2.Location = new Point(289, 386);
            service_input2.Name = "service_input2";
            service_input2.Size = new Size(320, 27);
            service_input2.TabIndex = 15;
            // 
            // arrival_input1
            // 
            arrival_input1.Dock = DockStyle.Fill;
            arrival_input1.Font = new Font("Segoe UI", 9F);
            arrival_input1.Location = new Point(289, 162);
            arrival_input1.Name = "arrival_input1";
            arrival_input1.Size = new Size(320, 27);
            arrival_input1.TabIndex = 24;
            arrival_input1.TextChanged += textBox1_TextChanged_1;
            // 
            // servicedist
            // 
            servicedist.Dock = DockStyle.Fill;
            servicedist.DropDownStyle = ComboBoxStyle.DropDownList;
            servicedist.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic);
            servicedist.FormattingEnabled = true;
            servicedist.Items.AddRange(new object[] { "Uniform", "Gamma", "Normal", "Exponential" });
            servicedist.Location = new Point(289, 251);
            servicedist.Name = "servicedist";
            servicedist.Size = new Size(320, 28);
            servicedist.TabIndex = 17;
            servicedist.SelectedIndexChanged += servicedist_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 2;
            label2.Text = "Arrivals";
            // 
            // servicewise
            // 
            servicewise.Dock = DockStyle.Fill;
            servicewise.DropDownStyle = ComboBoxStyle.DropDownList;
            servicewise.Font = new Font("Segoe UI", 9F);
            servicewise.FormattingEnabled = true;
            servicewise.Items.AddRange(new object[] { "Mean", "Rate" });
            servicewise.Location = new Point(289, 319);
            servicewise.Name = "servicewise";
            servicewise.Size = new Size(320, 28);
            servicewise.TabIndex = 13;
            servicewise.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // lbl_arrival_input1
            // 
            lbl_arrival_input1.AutoSize = true;
            lbl_arrival_input1.Font = new Font("Segoe UI", 9F);
            lbl_arrival_input1.Location = new Point(3, 159);
            lbl_arrival_input1.Name = "lbl_arrival_input1";
            lbl_arrival_input1.Size = new Size(89, 20);
            lbl_arrival_input1.TabIndex = 23;
            lbl_arrival_input1.Text = "Arrival Rate:";
            // 
            // Servicetimeunit
            // 
            Servicetimeunit.Dock = DockStyle.Fill;
            Servicetimeunit.DropDownStyle = ComboBoxStyle.DropDownList;
            Servicetimeunit.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic);
            Servicetimeunit.FormattingEnabled = true;
            Servicetimeunit.Items.AddRange(new object[] { "Seconds", "Minutes", "Hours" });
            Servicetimeunit.Location = new Point(289, 285);
            Servicetimeunit.Name = "Servicetimeunit";
            Servicetimeunit.Size = new Size(320, 28);
            Servicetimeunit.TabIndex = 12;
            // 
            // arrivaldistlbl
            // 
            arrivaldistlbl.AutoSize = true;
            arrivaldistlbl.Font = new Font("Segoe UI", 9F);
            arrivaldistlbl.Location = new Point(3, 57);
            arrivaldistlbl.Name = "arrivaldistlbl";
            arrivaldistlbl.Size = new Size(90, 20);
            arrivaldistlbl.TabIndex = 21;
            arrivaldistlbl.Text = "Distribution:";
            // 
            // arrivaldist
            // 
            arrivaldist.Dock = DockStyle.Fill;
            arrivaldist.DropDownStyle = ComboBoxStyle.DropDownList;
            arrivaldist.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic);
            arrivaldist.FormattingEnabled = true;
            arrivaldist.Items.AddRange(new object[] { "Uniform", "Gamma", "Normal", "Exponential" });
            arrivaldist.Location = new Point(289, 60);
            arrivaldist.Name = "arrivaldist";
            arrivaldist.Size = new Size(320, 28);
            arrivaldist.TabIndex = 22;
            arrivaldist.SelectedIndexChanged += arrivaldist_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Time Unit:";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // timebox
            // 
            timebox.Dock = DockStyle.Fill;
            timebox.DropDownStyle = ComboBoxStyle.DropDownList;
            timebox.Font = new Font("Segoe UI", 9F);
            timebox.FormattingEnabled = true;
            timebox.Items.AddRange(new object[] { "Seconds", "Minutes", "Hours" });
            timebox.Location = new Point(289, 94);
            timebox.Name = "timebox";
            timebox.Size = new Size(320, 28);
            timebox.TabIndex = 4;
            // 
            // wisebox
            // 
            wisebox.Dock = DockStyle.Fill;
            wisebox.DropDownStyle = ComboBoxStyle.DropDownList;
            wisebox.Font = new Font("Segoe UI", 9F);
            wisebox.FormattingEnabled = true;
            wisebox.Items.AddRange(new object[] { "Mean", "Rate" });
            wisebox.Location = new Point(289, 128);
            wisebox.Name = "wisebox";
            wisebox.Size = new Size(320, 28);
            wisebox.TabIndex = 6;
            wisebox.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(3, 225);
            label6.Name = "label6";
            label6.Size = new Size(68, 23);
            label6.TabIndex = 9;
            label6.Text = "Service";
            // 
            // arrivalwise_lbl
            // 
            arrivalwise_lbl.AutoSize = true;
            arrivalwise_lbl.Font = new Font("Segoe UI", 9F);
            arrivalwise_lbl.Location = new Point(3, 125);
            arrivalwise_lbl.Name = "arrivalwise_lbl";
            arrivalwise_lbl.Size = new Size(106, 20);
            arrivalwise_lbl.TabIndex = 5;
            arrivalwise_lbl.Text = "Value given as:";
            arrivalwise_lbl.Click += label4_Click;
            // 
            // lbl_arrival_input2
            // 
            lbl_arrival_input2.AutoSize = true;
            lbl_arrival_input2.Font = new Font("Segoe UI", 9F);
            lbl_arrival_input2.Location = new Point(3, 192);
            lbl_arrival_input2.Name = "lbl_arrival_input2";
            lbl_arrival_input2.Size = new Size(89, 20);
            lbl_arrival_input2.TabIndex = 7;
            lbl_arrival_input2.Text = "Arrival Rate:";
            lbl_arrival_input2.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(3, 282);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 10;
            label7.Text = "Time Unit:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Title.Location = new Point(3, 0);
            Title.Name = "Title";
            Title.Size = new Size(329, 35);
            Title.TabIndex = 1;
            Title.Text = "Queueing System Analyzer";
            Title.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.Location = new Point(3, 558);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(618, 308);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.33367F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.6663322F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            tableLayoutPanel2.Controls.Add(label10, 0, 0);
            tableLayoutPanel2.Controls.Add(label18, 0, 6);
            tableLayoutPanel2.Controls.Add(wtime, 2, 5);
            tableLayoutPanel2.Controls.Add(label17, 0, 5);
            tableLayoutPanel2.Controls.Add(wqtime, 2, 4);
            tableLayoutPanel2.Controls.Add(label15, 0, 4);
            tableLayoutPanel2.Controls.Add(displaytimebox, 1, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 3);
            tableLayoutPanel2.Controls.Add(label13, 0, 1);
            tableLayoutPanel2.Controls.Add(labelL, 1, 6);
            tableLayoutPanel2.Controls.Add(labelrho, 1, 1);
            tableLayoutPanel2.Controls.Add(labelW, 1, 5);
            tableLayoutPanel2.Controls.Add(labelLq, 1, 3);
            tableLayoutPanel2.Controls.Add(labelWq, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.Size = new Size(612, 238);
            tableLayoutPanel2.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 0;
            label10.Text = "Display Times in:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F);
            label18.Location = new Point(3, 204);
            label18.Name = "label18";
            label18.Size = new Size(180, 20);
            label18.TabIndex = 25;
            label18.Text = "L - avg.numbers in Queue:";
            // 
            // wtime
            // 
            wtime.AutoSize = true;
            wtime.Font = new Font("Segoe UI", 9F);
            wtime.Location = new Point(497, 170);
            wtime.Name = "wtime";
            wtime.Size = new Size(15, 20);
            wtime.TabIndex = 28;
            wtime.Text = "-";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F);
            label17.Location = new Point(3, 170);
            label17.Name = "label17";
            label17.Size = new Size(164, 20);
            label17.TabIndex = 24;
            label17.Text = "W - avg. time in Queue:";
            // 
            // wqtime
            // 
            wqtime.AutoSize = true;
            wqtime.Font = new Font("Segoe UI", 9F);
            wqtime.Location = new Point(497, 136);
            wqtime.Name = "wqtime";
            wqtime.Size = new Size(15, 20);
            wqtime.TabIndex = 29;
            wqtime.Text = "-";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F);
            label15.Location = new Point(3, 136);
            label15.Name = "label15";
            label15.Size = new Size(174, 20);
            label15.TabIndex = 22;
            label15.Text = "Wq - avg. time in system:";
            // 
            // displaytimebox
            // 
            displaytimebox.Dock = DockStyle.Fill;
            displaytimebox.DropDownStyle = ComboBoxStyle.DropDownList;
            displaytimebox.Font = new Font("Segoe UI", 9F);
            displaytimebox.FormattingEnabled = true;
            displaytimebox.Items.AddRange(new object[] { "Seconds", "Minutes", "Hours" });
            displaytimebox.Location = new Point(222, 3);
            displaytimebox.Name = "displaytimebox";
            displaytimebox.Size = new Size(269, 28);
            displaytimebox.TabIndex = 16;
            displaytimebox.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(3, 102);
            label12.Name = "label12";
            label12.Size = new Size(191, 20);
            label12.TabIndex = 18;
            label12.Text = "Lq - avg.numbers in system:";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(3, 34);
            label13.Name = "label13";
            label13.Size = new Size(100, 20);
            label13.TabIndex = 20;
            label13.Text = "Utilization (p)";
            label13.Click += label13_Click;
            // 
            // labelL
            // 
            labelL.AutoSize = true;
            labelL.Font = new Font("Segoe UI", 9F);
            labelL.Location = new Point(222, 204);
            labelL.Name = "labelL";
            labelL.Size = new Size(17, 20);
            labelL.TabIndex = 27;
            labelL.Text = "0";
            // 
            // labelrho
            // 
            labelrho.AutoSize = true;
            labelrho.Font = new Font("Segoe UI", 9F);
            labelrho.Location = new Point(222, 34);
            labelrho.Name = "labelrho";
            labelrho.Size = new Size(17, 20);
            labelrho.TabIndex = 19;
            labelrho.Text = "0";
            // 
            // labelW
            // 
            labelW.AutoSize = true;
            labelW.Font = new Font("Segoe UI", 9F);
            labelW.Location = new Point(222, 170);
            labelW.Name = "labelW";
            labelW.Size = new Size(17, 20);
            labelW.TabIndex = 26;
            labelW.Text = "0";
            // 
            // labelLq
            // 
            labelLq.AutoSize = true;
            labelLq.Font = new Font("Segoe UI", 9F);
            labelLq.Location = new Point(222, 102);
            labelLq.Name = "labelLq";
            labelLq.Size = new Size(17, 20);
            labelLq.TabIndex = 21;
            labelLq.Text = "0";
            labelLq.Click += label14_Click;
            // 
            // labelWq
            // 
            labelWq.AutoSize = true;
            labelWq.Font = new Font("Segoe UI", 9F);
            labelWq.Location = new Point(222, 136);
            labelWq.Name = "labelWq";
            labelWq.Size = new Size(17, 20);
            labelWq.TabIndex = 23;
            labelWq.Text = "0";
            // 
            // Calculate
            // 
            Calculate.BackColor = SystemColors.Highlight;
            Calculate.Dock = DockStyle.Fill;
            Calculate.Font = new Font("Segoe UI", 9F);
            Calculate.ForeColor = Color.AliceBlue;
            Calculate.Location = new Point(3, 490);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(618, 62);
            Calculate.TabIndex = 3;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = false;
            Calculate.Click += calculation;
            // 
            // mainLayout
            // 
            mainLayout.AutoScroll = true;
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(groupBox2, 0, 3);
            mainLayout.Controls.Add(groupBox1, 0, 1);
            mainLayout.Controls.Add(Title, 0, 0);
            mainLayout.Controls.Add(Calculate, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 4;
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.RowStyles.Add(new RowStyle());
            mainLayout.Size = new Size(624, 869);
            mainLayout.TabIndex = 4;
            // 
            // system_box
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 869);
            Controls.Add(mainLayout);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "system_box";
            Text = "Form1";
            Load += system_box_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label Title;
        private GroupBox groupBox2;
        private Button Calculate;
        private ComboBox modelbox;
        private Label label1;
        private ComboBox timebox;
        private Label label3;
        private Label label2;
        private TextBox arrival_input;
        private Label lbl_arrival_input2;
        private ComboBox wisebox;
        private Label arrivalwise_lbl;
        private ComboBox displaytimebox;
        private Label label10;
        private Label label13;
        private Label labelrho;
        private Label label12;
        private Label labelLq;
        private Label labelL;
        private Label labelW;
        private Label label18;
        private Label label17;
        private Label labelWq;
        private Label label15;
        private Label wqtime;
        private Label wtime;
        private Label lblservice2;
        private TextBox service_input1;
        private Label labelservice1;
        private ComboBox servicedist;
        private Label service_dist_lbl;
        private TextBox service_input2;
        private ComboBox servicewise;
        private ComboBox Servicetimeunit;
        private Label service_rate_label;
        private Label label7;
        private Label label6;
        private ComboBox arrivaldist;
        private Label arrivaldistlbl;
        private TextBox arrival_input1;
        private Label lbl_arrival_input1;
        private TextBox arrival_input2;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
