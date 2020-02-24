namespace Lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrapezesMethodCheckBox = new System.Windows.Forms.CheckBox();
            this.ImplicitEMethodCheckBox = new System.Windows.Forms.CheckBox();
            this.ExplicitEMethodCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CapacityTextBox = new System.Windows.Forms.TextBox();
            this.ResistTextBox = new System.Windows.Forms.TextBox();
            this.VoltageTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CapacityTextBox);
            this.panel1.Controls.Add(this.ResistTextBox);
            this.panel1.Controls.Add(this.VoltageTextBox);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 115);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HTextBox);
            this.groupBox2.Location = new System.Drawing.Point(480, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 92);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметр h в долях от RC:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TrapezesMethodCheckBox);
            this.groupBox1.Controls.Add(this.ImplicitEMethodCheckBox);
            this.groupBox1.Controls.Add(this.ExplicitEMethodCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(274, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Итерационные методы расчета:";
            // 
            // TrapezesMethodCheckBox
            // 
            this.TrapezesMethodCheckBox.AutoSize = true;
            this.TrapezesMethodCheckBox.Checked = true;
            this.TrapezesMethodCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TrapezesMethodCheckBox.Location = new System.Drawing.Point(17, 65);
            this.TrapezesMethodCheckBox.Name = "TrapezesMethodCheckBox";
            this.TrapezesMethodCheckBox.Size = new System.Drawing.Size(79, 19);
            this.TrapezesMethodCheckBox.TabIndex = 2;
            this.TrapezesMethodCheckBox.Text = "Трапеций";
            this.TrapezesMethodCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImplicitEMethodCheckBox
            // 
            this.ImplicitEMethodCheckBox.AutoSize = true;
            this.ImplicitEMethodCheckBox.Checked = true;
            this.ImplicitEMethodCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ImplicitEMethodCheckBox.Location = new System.Drawing.Point(17, 40);
            this.ImplicitEMethodCheckBox.Name = "ImplicitEMethodCheckBox";
            this.ImplicitEMethodCheckBox.Size = new System.Drawing.Size(119, 19);
            this.ImplicitEMethodCheckBox.TabIndex = 1;
            this.ImplicitEMethodCheckBox.Text = "Неявный Эйлера";
            this.ImplicitEMethodCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExplicitEMethodCheckBox
            // 
            this.ExplicitEMethodCheckBox.AutoSize = true;
            this.ExplicitEMethodCheckBox.Checked = true;
            this.ExplicitEMethodCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExplicitEMethodCheckBox.Location = new System.Drawing.Point(17, 15);
            this.ExplicitEMethodCheckBox.Name = "ExplicitEMethodCheckBox";
            this.ExplicitEMethodCheckBox.Size = new System.Drawing.Size(105, 19);
            this.ExplicitEMethodCheckBox.TabIndex = 0;
            this.ExplicitEMethodCheckBox.Text = "Явный Эйлера";
            this.ExplicitEMethodCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "U0, В";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Параметры\r\nмоделирования:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "R, Ом";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "C, нФ";
            // 
            // CapacityTextBox
            // 
            this.CapacityTextBox.Location = new System.Drawing.Point(144, 80);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.Size = new System.Drawing.Size(100, 23);
            this.CapacityTextBox.TabIndex = 3;
            this.CapacityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.CapacityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ResistTextBox
            // 
            this.ResistTextBox.Location = new System.Drawing.Point(144, 45);
            this.ResistTextBox.Name = "ResistTextBox";
            this.ResistTextBox.Size = new System.Drawing.Size(100, 23);
            this.ResistTextBox.TabIndex = 2;
            this.ResistTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.ResistTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // VoltageTextBox
            // 
            this.VoltageTextBox.Location = new System.Drawing.Point(144, 10);
            this.VoltageTextBox.Name = "VoltageTextBox";
            this.VoltageTextBox.Size = new System.Drawing.Size(100, 23);
            this.VoltageTextBox.TabIndex = 1;
            this.VoltageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.VoltageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(661, 44);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(111, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Смоделировать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.Title = "t, c";
            chartArea5.AxisY.Title = "U, В";
            chartArea5.Name = "Area";
            this.Chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.Chart.Legends.Add(legend5);
            this.Chart.Location = new System.Drawing.Point(0, 2);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.Chart.Size = new System.Drawing.Size(784, 440);
            this.Chart.TabIndex = 1;
            this.Chart.Text = "chart1";
            this.Chart.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Chart_MouseWheelZoom);
            // 
            // HTextBox
            // 
            this.HTextBox.Location = new System.Drawing.Point(35, 36);
            this.HTextBox.Name = "HTextBox";
            this.HTextBox.Size = new System.Drawing.Size(100, 23);
            this.HTextBox.TabIndex = 3;
            this.HTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.HTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Лаб. №1 АСП: Моделирование разрядки конденсатора через резистор. МИЭТ, 2020";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CapacityTextBox;
        private System.Windows.Forms.TextBox ResistTextBox;
        private System.Windows.Forms.TextBox VoltageTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox TrapezesMethodCheckBox;
        private System.Windows.Forms.CheckBox ImplicitEMethodCheckBox;
        private System.Windows.Forms.CheckBox ExplicitEMethodCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox HTextBox;
    }
}

