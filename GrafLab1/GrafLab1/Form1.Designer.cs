namespace GrafLab1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.grafContractionButton = new System.Windows.Forms.Button();
            this.grafAdditionButton = new System.Windows.Forms.Button();
            this.grafConnectionButton = new System.Windows.Forms.Button();
            this.grafUnionButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лабораторныеРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лабораторнаяРабота1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лабораторнаяРабота2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лабораторнаяРабота2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.дейкстераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.флойдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(330, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 243);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generation graf menu";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(128, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Create second graf associated";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Create first graf associated";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.grafContractionButton);
            this.groupBox2.Controls.Add(this.grafAdditionButton);
            this.groupBox2.Controls.Add(this.grafConnectionButton);
            this.groupBox2.Controls.Add(this.grafUnionButton);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(6, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 142);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation with grafs";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Graf №1",
            "Graf №2"});
            this.comboBox2.Location = new System.Drawing.Point(169, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Graf №1";
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Graf №1",
            "Graf №2"});
            this.comboBox1.Location = new System.Drawing.Point(91, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Graf №1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(97, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "1->2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(169, 72);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(142, 64);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // grafContractionButton
            // 
            this.grafContractionButton.Location = new System.Drawing.Point(169, 19);
            this.grafContractionButton.Name = "grafContractionButton";
            this.grafContractionButton.Size = new System.Drawing.Size(142, 22);
            this.grafContractionButton.TabIndex = 3;
            this.grafContractionButton.Text = "Contraction";
            this.grafContractionButton.UseVisualStyleBackColor = true;
            this.grafContractionButton.Click += new System.EventHandler(this.grafContractionButton_Click);
            // 
            // grafAdditionButton
            // 
            this.grafAdditionButton.Location = new System.Drawing.Point(15, 77);
            this.grafAdditionButton.Name = "grafAdditionButton";
            this.grafAdditionButton.Size = new System.Drawing.Size(75, 23);
            this.grafAdditionButton.TabIndex = 2;
            this.grafAdditionButton.Text = "Addition";
            this.grafAdditionButton.UseVisualStyleBackColor = true;
            this.grafAdditionButton.Click += new System.EventHandler(this.grafAdditionButton_Click);
            // 
            // grafConnectionButton
            // 
            this.grafConnectionButton.Location = new System.Drawing.Point(15, 48);
            this.grafConnectionButton.Name = "grafConnectionButton";
            this.grafConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.grafConnectionButton.TabIndex = 1;
            this.grafConnectionButton.Text = "Connection";
            this.grafConnectionButton.UseVisualStyleBackColor = true;
            this.grafConnectionButton.Click += new System.EventHandler(this.grafConnectionButton_Click);
            // 
            // grafUnionButton
            // 
            this.grafUnionButton.Location = new System.Drawing.Point(15, 19);
            this.grafUnionButton.Name = "grafUnionButton";
            this.grafUnionButton.Size = new System.Drawing.Size(75, 23);
            this.grafUnionButton.TabIndex = 0;
            this.grafUnionButton.Text = "Union";
            this.grafUnionButton.UseVisualStyleBackColor = true;
            this.grafUnionButton.Click += new System.EventHandler(this.grafUnionButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Create second graf";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create first graf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 233);
            this.panel1.TabIndex = 7;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(336, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 233);
            this.panel2.TabIndex = 8;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(12, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 237);
            this.panel3.TabIndex = 9;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(424, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Graf №2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(84, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Graf №1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Result Graf";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(274, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "tetete";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(636, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = ">>>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(683, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(252, 233);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(683, 318);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(252, 236);
            this.dataGridView2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(729, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Decart Matrix";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(729, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Smeznost` Matrix";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.лабораторныеРаботыToolStripMenuItem,
            this.алгоритмыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // лабораторныеРаботыToolStripMenuItem
            // 
            this.лабораторныеРаботыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лабораторнаяРабота1ToolStripMenuItem,
            this.лабораторнаяРабота2ToolStripMenuItem});
            this.лабораторныеРаботыToolStripMenuItem.Name = "лабораторныеРаботыToolStripMenuItem";
            this.лабораторныеРаботыToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.лабораторныеРаботыToolStripMenuItem.Text = "Лабораторные работы";
            // 
            // лабораторнаяРабота1ToolStripMenuItem
            // 
            this.лабораторнаяРабота1ToolStripMenuItem.Name = "лабораторнаяРабота1ToolStripMenuItem";
            this.лабораторнаяРабота1ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.лабораторнаяРабота1ToolStripMenuItem.Text = "Лабораторная работа 1";
            this.лабораторнаяРабота1ToolStripMenuItem.Click += new System.EventHandler(this.лабораторнаяРабота1ToolStripMenuItem_Click);
            // 
            // лабораторнаяРабота2ToolStripMenuItem
            // 
            this.лабораторнаяРабота2ToolStripMenuItem.Name = "лабораторнаяРабота2ToolStripMenuItem";
            this.лабораторнаяРабота2ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.лабораторнаяРабота2ToolStripMenuItem.Text = "Лабораторная работа 2";
            this.лабораторнаяРабота2ToolStripMenuItem.Click += new System.EventHandler(this.лабораторнаяРабота2ToolStripMenuItem_Click);
            // 
            // алгоритмыToolStripMenuItem
            // 
            this.алгоритмыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лабораторнаяРабота2ToolStripMenuItem1});
            this.алгоритмыToolStripMenuItem.Name = "алгоритмыToolStripMenuItem";
            this.алгоритмыToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.алгоритмыToolStripMenuItem.Text = "Алгоритмы";
            this.алгоритмыToolStripMenuItem.Click += new System.EventHandler(this.алгоритмыToolStripMenuItem_Click);
            // 
            // лабораторнаяРабота2ToolStripMenuItem1
            // 
            this.лабораторнаяРабота2ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дейкстераToolStripMenuItem,
            this.флойдаToolStripMenuItem});
            this.лабораторнаяРабота2ToolStripMenuItem1.Name = "лабораторнаяРабота2ToolStripMenuItem1";
            this.лабораторнаяРабота2ToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.лабораторнаяРабота2ToolStripMenuItem1.Text = "Лабораторная работа 2";
            // 
            // дейкстераToolStripMenuItem
            // 
            this.дейкстераToolStripMenuItem.Name = "дейкстераToolStripMenuItem";
            this.дейкстераToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.дейкстераToolStripMenuItem.Text = "Дейкстера";
            this.дейкстераToolStripMenuItem.Click += new System.EventHandler(this.дейкстераToolStripMenuItem_Click);
            // 
            // флойдаToolStripMenuItem
            // 
            this.флойдаToolStripMenuItem.Name = "флойдаToolStripMenuItem";
            this.флойдаToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.флойдаToolStripMenuItem.Text = "Флойда";
            this.флойдаToolStripMenuItem.Click += new System.EventHandler(this.флойдаToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(0, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 137);
            this.panel4.TabIndex = 22;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(934, 50);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 233);
            this.dataGridView3.TabIndex = 23;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(934, 318);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(240, 236);
            this.dataGridView4.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 620);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button grafContractionButton;
        private System.Windows.Forms.Button grafAdditionButton;
        private System.Windows.Forms.Button grafConnectionButton;
        private System.Windows.Forms.Button grafUnionButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лабораторныеРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лабораторнаяРабота1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лабораторнаяРабота2ToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStripMenuItem алгоритмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лабораторнаяРабота2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem дейкстераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem флойдаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}

