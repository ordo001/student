namespace student
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ИП-22-3", "ИП-22-7к" });
            comboBox1.Location = new Point(91, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 25);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 1;
            label1.Text = "Группа:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(17, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(786, 301);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ФИО";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 59;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(830, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 230);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Предметы";
            // 
            // button1
            // 
            button1.Location = new Point(59, 177);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 3;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(18, 135);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(175, 25);
            comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(18, 99);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 1;
            label3.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(5, 51);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 0;
            label2.Text = "Количество:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(871, 341);
            button2.Name = "button2";
            button2.Size = new Size(169, 28);
            button2.TabIndex = 4;
            button2.Text = "Заполнить ведомость";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(871, 385);
            button3.Name = "button3";
            button3.Size = new Size(169, 27);
            button3.TabIndex = 5;
            button3.Text = "Средний балл";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 467);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private Button button1;
        private ComboBox comboBox2;
        private Label label3;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
    }
}
