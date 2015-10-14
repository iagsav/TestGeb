namespace TestGen
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenTemplate = new System.Windows.Forms.Button();
            this.OpenTheoreticalQuestions = new System.Windows.Forms.Button();
            this.OpenPracticalQuestions = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TagOfBlokQuestions = new System.Windows.Forms.TextBox();
            this.TagOfNumberTickets = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BuildTickets = new System.Windows.Forms.Button();
            this.LoadLabels = new System.Windows.Forms.Button();
            this.SaveLabels = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenTemplate
            // 
            this.OpenTemplate.Location = new System.Drawing.Point(5, 8);
            this.OpenTemplate.Name = "OpenTemplate";
            this.OpenTemplate.Size = new System.Drawing.Size(185, 23);
            this.OpenTemplate.TabIndex = 0;
            this.OpenTemplate.Text = "Открыть шаблон экзаменационных билетов билетов";
            this.OpenTemplate.UseVisualStyleBackColor = true;
            this.OpenTemplate.Click += new System.EventHandler(this.OpenTemplate_Click);
            // 
            // OpenTheoreticalQuestions
            // 
            this.OpenTheoreticalQuestions.Location = new System.Drawing.Point(5, 34);
            this.OpenTheoreticalQuestions.Name = "OpenTheoreticalQuestions";
            this.OpenTheoreticalQuestions.Size = new System.Drawing.Size(185, 23);
            this.OpenTheoreticalQuestions.TabIndex = 4;
            this.OpenTheoreticalQuestions.Text = "Открыть теоретические вопросы";
            this.OpenTheoreticalQuestions.UseVisualStyleBackColor = true;
            this.OpenTheoreticalQuestions.Click += new System.EventHandler(this.OpenTheoreticalQuestions_Click);
            // 
            // OpenPracticalQuestions
            // 
            this.OpenPracticalQuestions.Location = new System.Drawing.Point(5, 63);
            this.OpenPracticalQuestions.Name = "OpenPracticalQuestions";
            this.OpenPracticalQuestions.Size = new System.Drawing.Size(185, 23);
            this.OpenPracticalQuestions.TabIndex = 6;
            this.OpenPracticalQuestions.Text = "Открыть практические вопросы вопросы";
            this.OpenPracticalQuestions.UseVisualStyleBackColor = true;
            this.OpenPracticalQuestions.Click += new System.EventHandler(this.OpenPracticalQuestions_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество Билетов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Количество теоретических вопросов в билете";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Количество практических вопросов в билете";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(252, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OpenPracticalQuestions);
            this.panel1.Controls.Add(this.OpenTheoreticalQuestions);
            this.panel1.Controls.Add(this.OpenTemplate);
            this.panel1.Location = new System.Drawing.Point(26, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 127);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TagOfBlokQuestions);
            this.panel2.Controls.Add(this.TagOfNumberTickets);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.BuildTickets);
            this.panel2.Controls.Add(this.LoadLabels);
            this.panel2.Controls.Add(this.SaveLabels);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(25, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 315);
            this.panel2.TabIndex = 29;
            // 
            // TagOfBlokQuestions
            // 
            this.TagOfBlokQuestions.Location = new System.Drawing.Point(162, 42);
            this.TagOfBlokQuestions.Name = "TagOfBlokQuestions";
            this.TagOfBlokQuestions.Size = new System.Drawing.Size(229, 20);
            this.TagOfBlokQuestions.TabIndex = 34;
            // 
            // TagOfNumberTickets
            // 
            this.TagOfNumberTickets.Location = new System.Drawing.Point(162, 12);
            this.TagOfNumberTickets.Name = "TagOfNumberTickets";
            this.TagOfNumberTickets.Size = new System.Drawing.Size(229, 20);
            this.TagOfNumberTickets.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Метка блока вопросов";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Метка номера билета";
            // 
            // BuildTickets
            // 
            this.BuildTickets.Location = new System.Drawing.Point(382, 268);
            this.BuildTickets.Name = "BuildTickets";
            this.BuildTickets.Size = new System.Drawing.Size(188, 23);
            this.BuildTickets.TabIndex = 3;
            this.BuildTickets.Text = "Сформировать билеты\r\n";
            this.BuildTickets.UseVisualStyleBackColor = true;
            this.BuildTickets.Click += new System.EventHandler(this.button3_Click);
            // 
            // LoadLabels
            // 
            this.LoadLabels.Location = new System.Drawing.Point(142, 268);
            this.LoadLabels.Name = "LoadLabels";
            this.LoadLabels.Size = new System.Drawing.Size(120, 23);
            this.LoadLabels.TabIndex = 2;
            this.LoadLabels.Text = "Загрузить метки";
            this.LoadLabels.UseVisualStyleBackColor = true;
            this.LoadLabels.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveLabels
            // 
            this.SaveLabels.Location = new System.Drawing.Point(16, 268);
            this.SaveLabels.Name = "SaveLabels";
            this.SaveLabels.Size = new System.Drawing.Size(120, 23);
            this.SaveLabels.TabIndex = 1;
            this.SaveLabels.Text = "Сохранить метки";
            this.SaveLabels.UseVisualStyleBackColor = true;
            this.SaveLabels.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(16, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Метка";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Текст замены";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Описание";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Location = new System.Drawing.Point(277, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 118);
            this.panel4.TabIndex = 31;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 443);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(697, 482);
            this.MinimumSize = new System.Drawing.Size(697, 482);
            this.Name = "MainForm";
            this.Text = "Генератор билетов (v. 0.1)";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenTemplate;
        private System.Windows.Forms.Button OpenTheoreticalQuestions;
        private System.Windows.Forms.Button OpenPracticalQuestions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button LoadLabels;
        private System.Windows.Forms.Button SaveLabels;
        private System.Windows.Forms.Button BuildTickets;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TagOfBlokQuestions;
        private System.Windows.Forms.TextBox TagOfNumberTickets;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

