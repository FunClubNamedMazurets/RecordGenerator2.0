namespace UI
{
    partial class Dodatoc2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodatoc2Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.Label();
            this.DynamicTable1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Input_13_рік = new System.Windows.Forms.TextBox();
            this.Input_12_місяць = new System.Windows.Forms.TextBox();
            this.Input_11_число = new System.Windows.Forms.TextBox();
            this.Input_10_ініціали_прізвище = new System.Windows.Forms.TextBox();
            this.Input_9_керівник_закладу = new System.Windows.Forms.TextBox();
            this.Input_8_рік = new System.Windows.Forms.TextBox();
            this.Input_7_місяць = new System.Windows.Forms.TextBox();
            this.Input_6_число = new System.Windows.Forms.TextBox();
            this.Input_5_номер_акту_форми = new System.Windows.Forms.TextBox();
            this.Input_4_клас_група = new System.Windows.Forms.TextBox();
            this.Input_3_навчальний_заклад = new System.Windows.Forms.TextBox();
            this.Input_2_п_і_б = new System.Windows.Forms.TextBox();
            this.Input_1_орган_управління_освітою = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DynamicTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Id);
            this.panel1.Controls.Add(this.DynamicTable1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Input_13_рік);
            this.panel1.Controls.Add(this.Input_12_місяць);
            this.panel1.Controls.Add(this.Input_11_число);
            this.panel1.Controls.Add(this.Input_10_ініціали_прізвище);
            this.panel1.Controls.Add(this.Input_9_керівник_закладу);
            this.panel1.Controls.Add(this.Input_8_рік);
            this.panel1.Controls.Add(this.Input_7_місяць);
            this.panel1.Controls.Add(this.Input_6_число);
            this.panel1.Controls.Add(this.Input_5_номер_акту_форми);
            this.panel1.Controls.Add(this.Input_4_клас_група);
            this.panel1.Controls.Add(this.Input_3_навчальний_заклад);
            this.panel1.Controls.Add(this.Input_2_п_і_б);
            this.panel1.Controls.Add(this.Input_1_орган_управління_освітою);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 817);
            this.panel1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(835, 33);
            this.Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(0, 17);
            this.Id.TabIndex = 18;
            // 
            // DynamicTable1
            // 
            this.DynamicTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DynamicTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DynamicTable1.Location = new System.Drawing.Point(17, 508);
            this.DynamicTable1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DynamicTable1.Name = "DynamicTable1";
            this.DynamicTable1.RowHeadersWidth = 51;
            this.DynamicTable1.Size = new System.Drawing.Size(817, 151);
            this.DynamicTable1.TabIndex = 17;
            this.DynamicTable1.Tag = "3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Діагноз за довідкою лікувально- профілактичного закладу";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 280;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Звільнений від  навчання (відвідування) у         навчальному  закладі";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Число  днів невідвідування навчального закладу";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 764);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Зберегти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 764);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Згенерувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Input_13_рік
            // 
            this.Input_13_рік.Location = new System.Drawing.Point(729, 706);
            this.Input_13_рік.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_13_рік.Name = "Input_13_рік";
            this.Input_13_рік.Size = new System.Drawing.Size(40, 22);
            this.Input_13_рік.TabIndex = 14;
            // 
            // Input_12_місяць
            // 
            this.Input_12_місяць.Location = new System.Drawing.Point(557, 706);
            this.Input_12_місяць.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_12_місяць.Name = "Input_12_місяць";
            this.Input_12_місяць.Size = new System.Drawing.Size(151, 22);
            this.Input_12_місяць.TabIndex = 13;
            // 
            // Input_11_число
            // 
            this.Input_11_число.Location = new System.Drawing.Point(488, 706);
            this.Input_11_число.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_11_число.Name = "Input_11_число";
            this.Input_11_число.Size = new System.Drawing.Size(51, 22);
            this.Input_11_число.TabIndex = 12;
            // 
            // Input_10_ініціали_прізвище
            // 
            this.Input_10_ініціали_прізвище.Location = new System.Drawing.Point(573, 667);
            this.Input_10_ініціали_прізвище.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_10_ініціали_прізвище.Name = "Input_10_ініціали_прізвище";
            this.Input_10_ініціали_прізвище.Size = new System.Drawing.Size(232, 22);
            this.Input_10_ініціали_прізвище.TabIndex = 11;
            // 
            // Input_9_керівник_закладу
            // 
            this.Input_9_керівник_закладу.Location = new System.Drawing.Point(295, 667);
            this.Input_9_керівник_закладу.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_9_керівник_закладу.Name = "Input_9_керівник_закладу";
            this.Input_9_керівник_закладу.Size = new System.Drawing.Size(272, 22);
            this.Input_9_керівник_закладу.TabIndex = 10;
            // 
            // Input_8_рік
            // 
            this.Input_8_рік.Location = new System.Drawing.Point(501, 404);
            this.Input_8_рік.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_8_рік.Name = "Input_8_рік";
            this.Input_8_рік.Size = new System.Drawing.Size(29, 22);
            this.Input_8_рік.TabIndex = 9;
            // 
            // Input_7_місяць
            // 
            this.Input_7_місяць.Location = new System.Drawing.Point(389, 404);
            this.Input_7_місяць.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_7_місяць.Name = "Input_7_місяць";
            this.Input_7_місяць.Size = new System.Drawing.Size(91, 22);
            this.Input_7_місяць.TabIndex = 8;
            // 
            // Input_6_число
            // 
            this.Input_6_число.Location = new System.Drawing.Point(336, 404);
            this.Input_6_число.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_6_число.Name = "Input_6_число";
            this.Input_6_число.Size = new System.Drawing.Size(40, 22);
            this.Input_6_число.TabIndex = 7;
            // 
            // Input_5_номер_акту_форми
            // 
            this.Input_5_номер_акту_форми.Location = new System.Drawing.Point(241, 404);
            this.Input_5_номер_акту_форми.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_5_номер_акту_форми.Name = "Input_5_номер_акту_форми";
            this.Input_5_номер_акту_форми.Size = new System.Drawing.Size(51, 22);
            this.Input_5_номер_акту_форми.TabIndex = 6;
            // 
            // Input_4_клас_група
            // 
            this.Input_4_клас_група.Location = new System.Drawing.Point(29, 342);
            this.Input_4_клас_група.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_4_клас_група.Name = "Input_4_клас_група";
            this.Input_4_клас_група.Size = new System.Drawing.Size(780, 22);
            this.Input_4_клас_група.TabIndex = 5;
            // 
            // Input_3_навчальний_заклад
            // 
            this.Input_3_навчальний_заклад.Location = new System.Drawing.Point(309, 282);
            this.Input_3_навчальний_заклад.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_3_навчальний_заклад.Name = "Input_3_навчальний_заклад";
            this.Input_3_навчальний_заклад.Size = new System.Drawing.Size(507, 22);
            this.Input_3_навчальний_заклад.TabIndex = 4;
            // 
            // Input_2_п_і_б
            // 
            this.Input_2_п_і_б.Location = new System.Drawing.Point(29, 224);
            this.Input_2_п_і_б.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_2_п_і_б.Name = "Input_2_п_і_б";
            this.Input_2_п_і_б.Size = new System.Drawing.Size(741, 22);
            this.Input_2_п_і_б.TabIndex = 3;
            // 
            // Input_1_орган_управління_освітою
            // 
            this.Input_1_орган_управління_освітою.Location = new System.Drawing.Point(353, 73);
            this.Input_1_орган_управління_освітою.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Input_1_орган_управління_освітою.Name = "Input_1_орган_управління_освітою";
            this.Input_1_орган_управління_освітою.Size = new System.Drawing.Size(467, 22);
            this.Input_1_орган_управління_освітою.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 702);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(843, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // Dodatoc2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 847);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dodatoc2Form";
            this.Text = "Dodatoc2";
            this.Load += new System.EventHandler(this.Dodatoc2Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DynamicTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Input_13_рік;
        private System.Windows.Forms.TextBox Input_12_місяць;
        private System.Windows.Forms.TextBox Input_11_число;
        private System.Windows.Forms.TextBox Input_10_ініціали_прізвище;
        private System.Windows.Forms.TextBox Input_9_керівник_закладу;
        private System.Windows.Forms.TextBox Input_8_рік;
        private System.Windows.Forms.TextBox Input_7_місяць;
        private System.Windows.Forms.TextBox Input_6_число;
        private System.Windows.Forms.TextBox Input_5_номер_акту_форми;
        private System.Windows.Forms.TextBox Input_4_клас_група;
        private System.Windows.Forms.TextBox Input_3_навчальний_заклад;
        private System.Windows.Forms.TextBox Input_2_п_і_б;
        private System.Windows.Forms.TextBox Input_1_орган_управління_освітою;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DynamicTable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label Id;
    }
}