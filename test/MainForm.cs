using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class MainForm : Form
    {
        public static Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
        public static Dictionary<string, int> node_level = new Dictionary<string, int>();
        public static Dictionary<string, int> node_position = new Dictionary<string, int>();
        public static Dictionary<string, int> nodes = new Dictionary<string, int>();
        public static Dictionary<int, string>[] node_position_in_level = new Dictionary<int, string>[10];

        public static int[] level_nodes_count = new int[10];
        public static double[, ,] w = new double[10, 100, 100];
        int max_level = 0, min_level, wRows = 1, wCols = 0;
        string enditem = "------------------------------";


        public MainForm()
        {
            InitializeComponent();
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;

            this.KeyPreview = true;
            this.BuiltTreeView.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(treeView1_NodeMouseDoubleClick);
            this.FormClosing += new FormClosingEventHandler(MainForm_BeforeClosing);

            this.BuiltTreeView.ShowPlusMinus = false;
            this.BuiltTreeView.Visible = true;
            for (int i = 0; i < 10; i++)
                node_position_in_level[i] = new Dictionary<int, string>();
            TabControl.SelectTab(TreeImport);
            var window = MessageBox.Show("Загрузить сохраненный сеанс?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (window == DialogResult.Yes)
                OPEN_MenuItem.PerformClick();
           
        }

        public TreeView treeview
        {
            get { return BuiltTreeView; }
            set {}
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (BuiltTreeView.SelectedNode == null || e.Button == MouseButtons.Left)
                return;
                       
            BuiltTreeView.SelectedNode = e.Node;


            if (e.Node.Nodes.Count < 2)
            {
                if (e.Node.Nodes.Count == 1)
                    MainForm.w[MainForm.node_level[e.Node.Text], MainForm.node_position[e.Node.Text], MainForm.node_position[e.Node.Nodes[0].Text]] = 1;
                MessageBox.Show("Данный элемент содержит недостаточное количество дочерних критериев");
                treeview.SelectedNode.ForeColor = Color.Red;
                return;
            }

            /*//ПАРОЛЬ для НИЖНИХ уровней
            if (node_level[e.Node.Text] > 1)
            {
                Form3 f3 = new Form3(e.Node, this);
                f3.Show();
                f3.TopMost = true;
                return;
            }*/

            PairwiseComparisons f2 = new PairwiseComparisons(e.Node, this);
            f2.Show();
        }
                
        private void fill_tree()
        {
            Array.Clear(level_nodes_count, 0, 10);
            Array.Clear(w, 0, w.Length);
            BuiltTreeView.Nodes.Clear();
            node_level.Clear();
            node_position.Clear();

            for (int i = 0; i < 10; i++)
                node_position_in_level[i].Clear();
            nodes.Clear();

            string file_content = TreeText.Text, curr_line;
            string[] lines = file_content.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int, TreeNode> parents = new Dictionary<int, TreeNode>();
            bool started = false;
            foreach (string text_line in lines)
            {
                int level = 0, spc = 0;
                string node_text = "";
                curr_line = text_line.Trim();
                for (int i = 0; i < curr_line.Count(); i++)
                {
                    if (curr_line[i] == ' ' && spc != 0)
                    {
                        while (++i < curr_line.Count())
                            node_text += curr_line[i];
                        break;
                    }
                    else
                        spc = 1;
                    if (curr_line[i] == '.')
                        level++;
                }
                node_text = node_text.Trim();
                max_level = Math.Max(max_level, level);
                if (!started)
                {
                    started = true;
                    parents[level - 1] = BuiltTreeView.Nodes.Add("Цель");
                    node_position.Add("Цель", 1);
                    node_level.Add("Цель", level - 1);
                    nodes.Add("Цель", 1);
                    min_level = level - 1;
                    ++level_nodes_count[level - 1];
                }

                if (!nodes.ContainsKey(node_text))
                {
                    node_position.Add(text_line, ++level_nodes_count[level]);
                    nodes.Add(node_text, level_nodes_count[level]);
                    node_position_in_level[level].Add(level_nodes_count[level], text_line);
                }
                else
                    node_position.Add(text_line, nodes[node_text]);

                node_level.Add(text_line, level);
                parents[level] = parents[level - 1].Nodes.Add(text_line);
                parents[level].EnsureVisible();
                wRows++;
                wCols = Math.Max(wCols, level_nodes_count[level]);
            }
            if (BuiltTreeView.Nodes.Count > 0)
                BuiltTreeView.Nodes[0].EnsureVisible();
            hideNodes(BuiltTreeView.Nodes[0]);
        }

        private void CalcEventualWeightsButton_Click(object sender, EventArgs e)
        {            
            EventualWeightsGrid.Rows.Clear();
            EventualWeightsGrid.DefaultCellStyle.Format = "0.0#";
            GridForCalculation.RowCount = max_level;
            GridForCalculation.ColumnCount = wCols + 1;
            int q = min_level, m = -1, n = 0;
            while (q < max_level)
            {
                m++;
                GridForCalculation.Rows[m].Cells[0].Value = "Веса " + Convert.ToString(q) + " уровня";
                if (q == min_level)
                    for (int j = 1; j <= level_nodes_count[q + 1]; j++)
                        GridForCalculation.Rows[m].Cells[j].Value = w[q, 1, j];
                else
                    for (int j = 1; j <= level_nodes_count[q + 1]; j++)
                    {
                        GridForCalculation.Rows[m].Cells[j].Value = 0;
                        for (int i = 1; i <= level_nodes_count[q]; i++)
                            GridForCalculation.Rows[m].Cells[j].Value = Convert.ToDouble(GridForCalculation.Rows[m].Cells[j].Value) +
                                Convert.ToDouble(GridForCalculation.Rows[m - 1].Cells[i].Value) * w[q, i, j];
                    }
                q++;
            }

            EventualWeightsGrid.RowCount = nodes.Count() + 10;
            EventualWeightsGrid.ColumnCount = 2;
            q = min_level;
            m = -1;
            n = 0;
            while (q < max_level)
            {
                m++;
                EventualWeightsGrid.Rows[m].Cells[0].Value = "Веса " + Convert.ToString(++n) + " уровня";
                EventualWeightsGrid.Rows[m].Cells[0].Style.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                EventualWeightsGrid.Rows[m].DefaultCellStyle.BackColor = Color.LightGray;
                for (int j = 1; j <= level_nodes_count[q + 1]; j++)
                {
                    EventualWeightsGrid.Rows[++m].Cells[0].Value = node_position_in_level[q + 1][j];
                    EventualWeightsGrid.Rows[m].Cells[1].Value = GridForCalculation.Rows[q].Cells[j].Value;
                }
                
                q++;
            }

            TabControl.SelectTab(Weights);   
        }

        void hideNodes(TreeNode curr)
        {
            if (curr.Nodes.Count == 0 || list.ContainsKey(curr.Text))
                curr.ForeColor = Color.Red;
            foreach (TreeNode tn in curr.Nodes)
            {
                if (node_level[tn.Text] > 1)
                {
                    if (tn.Nodes.Count == 0 || list.ContainsKey(tn.Text))
                        tn.ForeColor = Color.Red;
                }
                hideNodes(tn);
            }
        }

        private void EditTreeButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(TreeImport);
        }
        

        private void QUIT_MenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void BuildTreeButton_Click(object sender, EventArgs e) {
            if (BuiltTreeView.Nodes.Count == 0)
            {
                list.Clear();
                fill_tree();
                TabControl.SelectTab(TreeBuild);
                return;
            }
            var window = MessageBox.Show("Применить изменения?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (window == DialogResult.No)
                TabControl.SelectTab(TreeBuild);
            else
            {
                list.Clear();
                fill_tree();
                TabControl.SelectTab(TreeBuild);
            }
            
        }


        private void SAVE_MenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(enditem);
                    sw.Write(TreeText.Text);
                    sw.WriteLine();
                    sw.WriteLine(enditem);
                    foreach (KeyValuePair<string, List<string>> item in list)
                    {
                        sw.WriteLine(item.Key);
                        foreach (string list_item in item.Value)
                            sw.WriteLine(list_item);
                        sw.WriteLine(enditem);
                    }

                    sw.WriteLine(enditem + enditem);

                    for (int i = 0; i < 10; i++)
                        for (int j = 0; j < 100; j++)
                            for (int k = 0; k < 100; k++)
                                sw.WriteLine(w[i, j, k]);//sw.WriteLine(i.ToString()+' ' +j.ToString() + ' ' + k.ToString() + ' '+ w[i, j, k].ToString());


                    //sw.WriteLine("Hello World!");
                }
            }
        }

        private void OPEN_MenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string file_content = File.ReadAllText(openFileDialog1.FileName);
                            string[] lines = file_content.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                            TreeText.Clear();

                            list.Clear();
                            if (lines[0] != enditem)
                            {
                                MessageBox.Show("Неверный файл. Попытайтесь еще раз.");
                                return;
                            }

                            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                            {
                                if (Application.OpenForms[i].Name != "MainForm")
                                    Application.OpenForms[i].Close();
                            }

                            int iter = 0;
                            while (lines[++iter] != enditem)
                                TreeText.AppendText(lines[iter] + "\r\n");

                            while (lines[++iter] != enditem + enditem)
                            {
                                string temp_key = lines[iter];
                                List<string> temp_list = new List<string>();
                                while (lines[++iter] != enditem)
                                    temp_list.Add(lines[iter]);
                                list.Add(temp_key, temp_list);
                            }
                            fill_tree();
                            for (int i = 0; i < 10; i++)
                                for (int j = 0; j < 100; j++)
                                    for (int k = 0; k < 100; k++)
                                        w[i, j, k] = Convert.ToDouble(lines[++iter]);

                            TabControl.SelectTab(TreeBuild);

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void MainForm_BeforeClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Сохранить изменения перед выходом?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (window == DialogResult.Yes)
                SAVE_MenuItem.PerformClick();
                
            e.Cancel = (window == DialogResult.Cancel);
        }

        private void CloseButton2_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    Application.OpenForms[i].Close();
        }

        private void CloseButton3_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                Application.OpenForms[i].Close();
        }
        
        private void CloseButton1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void BackButton3_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(TreeBuild);
        }

        

        
                
    }
}

