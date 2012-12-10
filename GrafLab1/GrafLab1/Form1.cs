using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrafLab1
{
    public partial class Form1 : Form
    {
        private Graph graf1;
        private Graph graf2;
        private Graph grafResult= new Graph();
        private System.Drawing.Graphics grafic;

        public Form1()
        {
            InitializeComponent();
            this.grafic = this.CreateGraphics();
            this.Size = new Size(686, 647);
            panel4.Size=new Size(0,0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nodes grafDecart1 = new Nodes(3, 3,true);
            graf1 = new Graph(grafDecart1);
            VisualGraph drawGraf = new VisualGraph(10,10,panel1);
            drawGraf.paintGraf(graf1);
            if (graf2!=null && graf2!=null)
            {
                groupBox2.Enabled = true;
                checkBoxList();
            }
            else
            {
                groupBox2.Enabled = false;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Nodes grafDecart = new Nodes(3, 3,true);
            graf2 = new Graph(grafDecart);
            VisualGraph drawGraf = new VisualGraph(10,10,panel2);
            drawGraf.paintGraf(graf2);
            if (graf2 != null && graf2 != null)
            {
                groupBox2.Enabled = true;
                checkBoxList();
            }
            else
            {
                groupBox2.Enabled = false;
            }
            
        }

        private void grafUnionButton_Click(object sender, EventArgs e)
        {
            label1.Text =Convert.ToString( graf1.getCountPoint(graf2.getGrafDecart()));
            grafResult = graf1 + graf2;
            VisualGraph drawGraf = new VisualGraph(10, 10,panel3);
            drawGraf.paintGraf(grafResult);
            label6.Text = "Union graf №1 and graf №2";

        }

        private void grafConnectionButton_Click(object sender, EventArgs e)
        {
            if (label2.Text == "1->2")
            {
                grafResult = graf1 * graf2;
                label6.Text = "Connection graf №1 with graf №2";
            }
            else
            {
                grafResult = graf2 * graf1;
                label6.Text = "Connection graf №2 with graf №1";
            }
            
            VisualGraph drawGraf = new VisualGraph(10, 10, panel3);
            drawGraf.paintGraf(grafResult);

        }

        private void grafAdditionButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Graf №1")
            {
               grafResult =  grafResult .setWith( graf1);
                grafResult++;
                label6.Text = "Addition graf №1 ";
            }
            else
            {
                grafResult = grafResult.setWith(graf2);
                grafResult++;
                label6.Text = "Addition graf №2 ";
            }
            
            VisualGraph drawGraf = new VisualGraph(10, 10, panel3);
            drawGraf.paintGraf(grafResult);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "1->2")
            {
                label2.Text = "1<-2";
            }
            else
            {
                label2.Text = "1->2";
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            checkBoxList();

        }

        private void checkBoxList()
        {
            checkedListBox1.Items.Clear();
            if (comboBox2.Text == "Graf №1")
                for (int y = 0; y < graf1.getGrafDecart().getSizeDecartGrafMatrixY(); y++)
                {
                    for (int x = 0; x < graf1.getGrafDecart().getSizeDecartGrafMatrixX(); x++)
                    {
                        if (graf1.getGrafDecart().getElementDecartGraf(x, y) > 0)
                            checkedListBox1.Items.Add(Convert.ToString(graf1.getGrafDecart().getElementDecartGraf(x, y)));
                    }
                }
            else
            {
                for (int y = 0; y < graf2.getGrafDecart().getSizeDecartGrafMatrixY(); y++)
                {
                    for (int x = 0; x < graf2.getGrafDecart().getSizeDecartGrafMatrixX(); x++)
                    {
                        if (graf2.getGrafDecart().getElementDecartGraf(x, y) > 0)
                            checkedListBox1.Items.Add(Convert.ToString(graf2.getGrafDecart().getElementDecartGraf(x, y)));
                    }
                }

            }
        }
        /// <summary>
        /// Сведение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grafContractionButton_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text == "Graf №1")
            {
               grafResult =  grafResult.setWith( graf1);
                label6.Text = "Addition graf №1 ";
                List<int> buf = new List<int>();
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        buf.Add(Convert.ToInt32(checkedListBox1.Items[i]));
                    }
                }
                grafResult = grafResult.contraction(grafResult, buf);
            }
            else
            {
                grafResult = grafResult.setWith(graf2);
                
                label6.Text = "Addition graf №2 ";
            }

            VisualGraph drawGraf = new VisualGraph(10, 10, panel3);
            drawGraf.paintGraf(grafResult);
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            label1.Text = checkedListBox1.Items[1].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Width!=686)
            {
                this.Size = new System.Drawing.Size(686, 647); 
            }
            else
            {
                this.Size = new System.Drawing.Size(1187, 647);
                
            }

        }

        private void createGrafDecartInfo(Graph graf1)
        {
            if (graf1==null)
                return;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            for (int i = 0; i < graf1.getGrafDecart().getSizeDecartGrafMatrixX(); i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Name = Convert.ToString(i+1);
                col.HeaderText = Convert.ToString(i+1);
                col.ValueType = typeof(string);
                col.Width = 50;
                dataGridView1.Columns.Add(col);
            }

            for (int y = 0; y < graf1.getGrafDecart().getSizeDecartGrafMatrixY(); y++)
            {
                DataGridViewRow row = new DataGridViewRow(); 
                for (int x = 0; x < graf1.getGrafDecart().getSizeDecartGrafMatrixX(); x++)
                {
                        DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                        cell.ValueType = typeof (int);
                        cell.Value = graf1.getGrafDecart().getElementDecartGraf(x,y);
                        row.Cells.Add(cell);
                }
                row.HeaderCell.Value = Convert.ToString(y + 1); 
                dataGridView1.Rows.Add(row);
            }
        }
        
        private void createGrafInfo(Graph graf1)
        {
            if (graf1 == null)
                return;
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            for (int i = 0; i < graf1.getGraf().Count; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Name = Convert.ToString(i+1);
                col.HeaderText = Convert.ToString(i+1);
                col.ValueType = typeof(string);
                col.Width = 50;
                dataGridView2.Columns.Add(col);
            }

            for (int y = 0; y < graf1.getGraf().Count; y++)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int x = 0; x < graf1.getGraf().Count; x++)
                {
                        DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                        cell.ValueType = typeof (int);
                        cell.Value = Convert.ToInt32(graf1.getCoordinates(x,y));
                        row.Cells.Add(cell);
                }
                row.HeaderCell.Value = Convert.ToString(y + 1); 
                dataGridView2.Rows.Add(row);
            }
        }

        private void createGrafSizeWay(Graph graf1)
        {
            if (graf1 == null)
                return;
            dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView4.DataSource = null;
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            for (int i = 0; i < graf1.getGraf().Count; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Name = Convert.ToString(i + 1);
                col.HeaderText = Convert.ToString(i + 1);
                col.ValueType = typeof(string);
                col.Width = 50;
                DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                col1.Name = Convert.ToString(i + 1);
                col1.HeaderText = Convert.ToString(i + 1);
                col1.ValueType = typeof(string);
                col1.Width = 50;
                dataGridView3.Columns.Add(col);
                dataGridView4.Columns.Add(col1);
            }

            for (int y = 0; y < graf1.getGraf().Count; y++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewRow row1 = new DataGridViewRow();
                for (int x = 0; x < graf1.getGraf().Count; x++)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                    cell1.ValueType = typeof (int);
                    cell1.Value = Convert.ToInt32(graf1.resultSizeWay[x][y].SizeWay);
                    cell.ValueType = typeof(int);
                    cell.Value = Convert.ToInt32(graf1.GrafSizeWay[x][y].SizeWay);
                    row.Cells.Add(cell);
                    row1.Cells.Add(cell1);
                }
                row1.HeaderCell.Value = Convert.ToString(y + 1);
                row.HeaderCell.Value = Convert.ToString(y + 1);
                dataGridView3.Rows.Add(row);
                dataGridView4.Rows.Add(row1);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            createGrafDecartInfo(graf1);
            createGrafInfo(graf1);
            createGrafSizeWay(graf1);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            createGrafDecartInfo(graf2);
            createGrafInfo(graf2);
            createGrafSizeWay(graf2);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            createGrafDecartInfo(grafResult);
            createGrafInfo(grafResult);
            createGrafSizeWay(grafResult);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            VisualGraph drawGraf = new VisualGraph(10, 10, panel2);
            drawGraf.paintGraf(graf2);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            VisualGraph drawGraf = new VisualGraph(10, 10, panel1);
            drawGraf.paintGraf(graf1);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            VisualGraph drawGraf = new VisualGraph(10, 10, panel3);
            drawGraf.paintGraf(grafResult);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nodes grafDecart1 = new Nodes(3, 3, true);
            graf1 = new Graph(grafDecart1);
            VisualGraph drawGraf = new VisualGraph(10, 10, panel1);
            drawGraf.paintGraf(graf1);
            if (graf2 != null && graf2 != null)
            {
                groupBox2.Enabled = true;
                checkBoxList();
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void лабораторнаяРабота1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLAboratoryWork(1);
        }


        /// <summary>
        /// показывает выбранную работу
        /// </summary>
        private void showLAboratoryWork(int numberLaboratoryWork)
        {
            switch (numberLaboratoryWork)
            {
                case 1:
                    {
                        panel4.Size = new Size(0, 0);
                        break;
                    }
                case 2:
                    {
                        panel4.Size = new Size(677, 577);
                        break;
                    }
            }
        }

        private void лабораторнаяРабота2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLAboratoryWork(2);
        }

        private void дейкстераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grafResult = grafResult.setWith(graf1);
             grafResult.algoritmDeikster(Convert.ToInt32(textBox2.Text));
            VisualGraph drawGraf = new VisualGraph(10, 10, panel3);
            drawGraf.paintGraf(grafResult);
            label6.Text = "Algorithm Deikstera";
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void флойдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grafResult = graf1.setWith(graf1);
            grafResult.algoritmFloid();
            VisualGraph drawGraf = new VisualGraph(10, 10, panel3);
            drawGraf.paintGraf(grafResult);
            label6.Text = "algorithm Floida";
        }

        private void алгоритмыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
       
    }
}
