using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class PairwiseComparisons : Form
    {

        public TreeNode form_node;

        private MainForm mainForm = null;

        public PairwiseComparisons(TreeNode curr_node, Form callingForm)
        {
            mainForm = callingForm as MainForm; 
            InitializeComponent();
            form_node = curr_node;
            this.Name = curr_node.Text;

            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;

            this.Text = curr_node.Text;
            fill_grid(curr_node);
            GridForCalculation.Rows.Clear();
            GridForCalculation.Columns.Clear();
            if (MainForm.list.ContainsKey(form_node.Text))
                weightAssessment();

            this.AssesmentsAndWeightsGrid.CellMouseClick += new DataGridViewCellMouseEventHandler(AssesmentsAndWeightsGrid_CellMouseClick);
            this.AssesmentsAndWeightsGrid.KeyDown += new KeyEventHandler(AssesmentsAndWeightsGrid_KeyDown);
            this.GridForCalculation.KeyDown += new KeyEventHandler(dataGridView4_KeyDown);
        }
        
        private void AssesmentsAndWeightsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                AssesmentsAndWeightsGrid.CurrentCell = AssesmentsAndWeightsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (AssesmentsAndWeightsGrid.CurrentCell.ColumnIndex.Equals(2) && Convert.ToDouble(AssesmentsAndWeightsGrid.CurrentCell.Value) > 0)
                    AssesmentsAndWeightsGrid.CurrentCell.Value = 1 / Convert.ToDouble(AssesmentsAndWeightsGrid.CurrentCell.Value);
            }
        }

        void AssesmentsAndWeightsGrid_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject d = AssesmentsAndWeightsGrid.GetClipboardContent();
                Clipboard.SetDataObject(d);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int row = AssesmentsAndWeightsGrid.CurrentCell.RowIndex, t;
                t = row;
                int col = AssesmentsAndWeightsGrid.CurrentCell.ColumnIndex;
                foreach (string line in lines)
                {
                    if (row >= AssesmentsAndWeightsGrid.RowCount)
                        AssesmentsAndWeightsGrid.Rows.Add();
                    if (line.Length > 0)
                    {
                        string[] cells = line.Split('\t');
                        for (int i = 0; i < cells.GetLength(0); ++i)
                            if (col + i >= this.AssesmentsAndWeightsGrid.ColumnCount)
                                AssesmentsAndWeightsGrid.Columns.Add("", "");
                        row++;
                    }
                    else
                        break;
                }
                row = t;
                foreach (string line in lines)
                    if (line.Length > 0)
                    {
                        string[] cells = line.Split('\t');
                        for (int i = 0; i < cells.GetLength(0); ++i)
                            AssesmentsAndWeightsGrid[col + i, row].Value = Convert.ChangeType(cells[i], AssesmentsAndWeightsGrid[col + i, row].ValueType);
                        row++;
                    }
                    else
                        break;

            }
        }
        void dataGridView4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject d = GridForCalculation.GetClipboardContent();
                Clipboard.SetDataObject(d);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int row = GridForCalculation.CurrentCell.RowIndex, t;
                t = row;
                int col = GridForCalculation.CurrentCell.ColumnIndex;
                foreach (string line in lines)
                {
                    if (row >= GridForCalculation.RowCount)
                        GridForCalculation.Rows.Add();
                    if (line.Length > 0)
                    {
                        string[] cells = line.Split('\t');
                        for (int i = 0; i < cells.GetLength(0); ++i)
                            if (col + i >= this.GridForCalculation.ColumnCount)
                                GridForCalculation.Columns.Add("", "");
                        row++;
                    }
                    else
                        break;
                }
                row = t;
                foreach (string line in lines)
                    if (line.Length > 0)
                    {
                        string[] cells = line.Split('\t');
                        for (int i = 0; i < cells.GetLength(0); ++i)
                            GridForCalculation[col + i, row].Value = Convert.ChangeType(cells[i], GridForCalculation[col + i, row].ValueType);
                        row++;
                    }
                    else
                        break;

            }
        }

        private void fill_grid(TreeNode curr_node)
        {
            string txt = "Какой критерий наиболее предпочтителен с точки зрения: ";
            AssesmentsAndWeightsGrid.Rows.Clear();
            AssesmentsAndWeightsGrid.ColumnCount = 4;
            AssesmentsAndWeightsGrid.Columns[0].Name = "#";
            AssesmentsAndWeightsGrid.Columns[1].Name = "Описание критерия";
            AssesmentsAndWeightsGrid.Columns[2].Name = "Оценка";
            AssesmentsAndWeightsGrid.Columns[3].Name = "Веса";
            AssesmentsAndWeightsGrid.Columns[1].ReadOnly = true;
            AssesmentsAndWeightsGrid.Columns[3].ReadOnly = true;
            AssesmentsAndWeightsGrid.DefaultCellStyle.Format = "0.00#";
            txt = txt + curr_node.Text;
            int n = 0;
            foreach (TreeNode tn in curr_node.Nodes)
                if (!MainForm.list.ContainsKey(curr_node.Text))
                   AssesmentsAndWeightsGrid.Rows.Add((++n) > 9 ? (n).ToString() : "0" + (n).ToString(), tn.Text, 1);
                else
                   AssesmentsAndWeightsGrid.Rows.Add((++n) > 9 ? (n).ToString() : "0" + (n).ToString(), tn.Text, MainForm.list[curr_node.Text][n - 1]); 
            MainDescription.Text = txt;
            AssesmentsAndWeightsGrid.Rows[0].Cells[2].ReadOnly = true;
        }

        private void weightAssessment()
        {
            GridForCalculation.Rows.Clear();
            GridForCalculation.Columns.Clear();
            int n;
            n = AssesmentsAndWeightsGrid.RowCount;
            GridForCalculation.ColumnCount = n + 1;
            GridForCalculation.RowCount = n;
            GridForCalculation.DefaultCellStyle.Format = "0.00#";
            for (int i = 1; i < n + 1; i++)
            {
                GridForCalculation.Columns[i].Name = (AssesmentsAndWeightsGrid.Rows[i - 1].Cells[0].Value).ToString();
                GridForCalculation.Rows[i - 1].Cells[0].Value = AssesmentsAndWeightsGrid.Rows[i - 1].Cells[0].Value;
                GridForCalculation.Rows[i - 1].Cells[0].ReadOnly = true;
                GridForCalculation.Rows[0].Cells[i].Value = 0;
                GridForCalculation.Rows[0].Cells[i].Value = AssesmentsAndWeightsGrid.Rows[i - 1].Cells[2].Value;
            }
            GridForCalculation.Columns[0].Name = "K#";
            GridForCalculation.ColumnCount++;
            n = GridForCalculation.ColumnCount;
            GridForCalculation.Columns[n - 1].Name = "W";
            for (int i = 1; i < GridForCalculation.RowCount; i++)
                for (int j = 1; j < GridForCalculation.ColumnCount - 1; j++)
                {
                    if (j == 1)
                    {
                        if (Convert.ToDouble(GridForCalculation.Rows[0].Cells[j].Value) == 0)
                            return;
                        GridForCalculation.Rows[i].Cells[j].Value = 1 / Convert.ToDouble(GridForCalculation.Rows[0].Cells[i + 1].Value);
                    }
                    else
                        GridForCalculation.Rows[i].Cells[j].Value = Convert.ToDouble(GridForCalculation.Rows[i].Cells[1].Value) * Convert.ToDouble(GridForCalculation.Rows[0].Cells[j].Value);
                }
            double sAll = 0;
            for (int i = 0; i < GridForCalculation.RowCount; i++)
            {
                double s = 1.0;
                for (int j = 1; j < GridForCalculation.ColumnCount - 1; j++)
                    s *= Convert.ToDouble(GridForCalculation.Rows[i].Cells[j].Value);
                GridForCalculation.Rows[i].Cells[n - 1].Value = Math.Pow(s, 1 / Convert.ToDouble(n - 2));
                AssesmentsAndWeightsGrid.Rows[i].Cells[3].Value = Math.Pow(s, 1 / Convert.ToDouble(n - 2));
                //Form1.w[Form1.node_level[form_node.Text], Form1.node_position[form_node.Text], Form1.node_position[form_node.Nodes[i].Text]] = Math.Pow(s, 1 / Convert.ToDouble(n - 2));
                sAll += Convert.ToDouble(Math.Pow(s, 1 / Convert.ToDouble(n - 2)));
            }
            for (int i = 0; i < GridForCalculation.RowCount; i++)
            {
                GridForCalculation.Rows[i].Cells[n - 1].Value = Convert.ToDouble(GridForCalculation.Rows[i].Cells[n - 1].Value) / sAll;
                AssesmentsAndWeightsGrid.Rows[i].Cells[3].Value = Convert.ToDouble(GridForCalculation.Rows[i].Cells[n - 1].Value);

                MainForm.w[MainForm.node_level[form_node.Text], MainForm.node_position[form_node.Text], MainForm.node_position[form_node.Nodes[i].Text]] = Convert.ToDouble(GridForCalculation.Rows[i].Cells[n - 1].Value);
                
            }
        }
        

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void CalcWeights_Click(object sender, EventArgs e)
        {
            List<string> filled_list = new List<string>();
            foreach (DataGridViewRow item in AssesmentsAndWeightsGrid.Rows)
            {
                if (item.Cells[2].Value != null) //value is not null
                    filled_list.Add(item.Cells[2].Value.ToString());
            }
            if (!MainForm.list.ContainsKey(form_node.Text))
                MainForm.list.Add(form_node.Text, filled_list);
            else
                MainForm.list[form_node.Text] = filled_list;
            weightAssessment();
            mainForm.treeview.SelectedNode.ForeColor = Color.Red;
        }
    }
}
