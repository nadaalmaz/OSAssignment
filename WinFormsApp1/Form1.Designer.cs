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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Rows = new Label();
            Columns = new Label();
            Make_Table = new Button();
            label3 = new Label();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            dataGridView3 = new DataGridView();
            label6 = new Label();
            dataGridView4 = new DataGridView();
            label7 = new Label();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(729, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(638, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            // 
            // Rows
            // 
            Rows.AutoSize = true;
            Rows.Location = new Point(58, 45);
            Rows.Name = "Rows";
            Rows.Size = new Size(91, 25);
            Rows.TabIndex = 3;
            Rows.Text = "Resources";
            Rows.Click += label1_Click;
            // 
            // Columns
            // 
            Columns.AutoSize = true;
            Columns.Location = new Point(201, 45);
            Columns.Name = "Columns";
            Columns.Size = new Size(89, 25);
            Columns.TabIndex = 4;
            Columns.Text = "Processes";
            Columns.Click += label2_Click;
            // 
            // Make_Table
            // 
            Make_Table.Location = new Point(109, 110);
            Make_Table.Name = "Make_Table";
            Make_Table.Size = new Size(123, 34);
            Make_Table.TabIndex = 5;
            Make_Table.Text = "Make Tables";
            Make_Table.UseVisualStyleBackColor = true;
            Make_Table.Click += Make_Table_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(237, 25);
            label3.TabIndex = 11;
            label3.Text = "Step 2: Fill in Total Resources";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(421, 25);
            label4.TabIndex = 12;
            label4.Text = "Step 1: Specify Number of Resources and Processes";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 184);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(638, 225);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 423);
            label5.Name = "label5";
            label5.Size = new Size(261, 25);
            label5.TabIndex = 14;
            label5.Text = "Step 3: Fill in Available Resorces";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 451);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 33;
            dataGridView3.Size = new Size(638, 225);
            dataGridView3.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(729, 17);
            label6.Name = "label6";
            label6.Size = new Size(242, 25);
            label6.TabIndex = 16;
            label6.Text = "Step 4: Fill in Maximum Need";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(729, 45);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.RowTemplate.Height = 33;
            dataGridView4.Size = new Size(638, 225);
            dataGridView4.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(729, 282);
            label7.Name = "label7";
            label7.Size = new Size(258, 25);
            label7.TabIndex = 18;
            label7.Text = "Step 5: Fill in Current Allocation";
            // 
            // button2
            // 
            button2.Location = new Point(805, 693);
            button2.Name = "button2";
            button2.Size = new Size(347, 34);
            button2.TabIndex = 19;
            button2.Text = "Check if safe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(729, 574);
            label8.Name = "label8";
            label8.Size = new Size(499, 25);
            label8.TabIndex = 20;
            label8.Text = "Step 6: Choose which Process, which resource, and how many";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(765, 617);
            label9.Name = "label9";
            label9.Size = new Size(72, 25);
            label9.TabIndex = 21;
            label9.Text = "Process";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(942, 617);
            label10.Name = "label10";
            label10.Size = new Size(83, 25);
            label10.TabIndex = 22;
            label10.Text = "Resource";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(777, 656);
            label11.Name = "label11";
            label11.Size = new Size(22, 25);
            label11.TabIndex = 23;
            label11.Text = "P";
            label11.Click += label11_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(805, 653);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(32, 31);
            textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(960, 656);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(42, 31);
            textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1104, 653);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(52, 31);
            textBox7.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1087, 617);
            label12.Name = "label12";
            label12.Size = new Size(98, 25);
            label12.TabIndex = 27;
            label12.Text = "How many";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 750);
            Controls.Add(label12);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(dataGridView4);
            Controls.Add(label6);
            Controls.Add(dataGridView3);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Make_Table);
            Controls.Add(Columns);
            Controls.Add(Rows);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Rows;
        private Label Columns;
        private Button Make_Table;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView2;
        private Label label5;
        private DataGridView dataGridView3;
        private Label label6;
        private DataGridView dataGridView4;
        private Label label7;
        private Button button2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label12;
    }
}