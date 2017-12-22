namespace test
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FILE_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OPEN_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SAVE_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QUIT_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VIEW_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ADMINview_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EXPERTview_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HELP_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABOUT_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TreeBuild = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BuiltTreeView = new System.Windows.Forms.TreeView();
            this.Description1 = new System.Windows.Forms.TextBox();
            this.Close_button1 = new System.Windows.Forms.Button();
            this.EditTreeButton = new System.Windows.Forms.Button();
            this.CalcEventualWeightsButton = new System.Windows.Forms.Button();
            this.TreeImport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Description2 = new System.Windows.Forms.TextBox();
            this.TreeText = new System.Windows.Forms.TextBox();
            this.BuildTreeButton = new System.Windows.Forms.Button();
            this.Weights = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.EventualWeightsGrid = new System.Windows.Forms.DataGridView();
            this.GridForCalculation = new System.Windows.Forms.DataGridView();
            this.CloseButton3 = new System.Windows.Forms.Button();
            this.BackButton3 = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TreeBuild.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TreeImport.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Weights.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventualWeightsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridForCalculation)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FILE_MenuItem,
            this.VIEW_MenuItem,
            this.HELP_MenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1043, 33);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FILE_MenuItem
            // 
            this.FILE_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OPEN_MenuItem,
            this.SAVE_MenuItem,
            this.QUIT_MenuItem});
            this.FILE_MenuItem.Name = "FILE_MenuItem";
            this.FILE_MenuItem.Size = new System.Drawing.Size(65, 29);
            this.FILE_MenuItem.Text = "Файл";
            // 
            // OPEN_MenuItem
            // 
            this.OPEN_MenuItem.Name = "OPEN_MenuItem";
            this.OPEN_MenuItem.Size = new System.Drawing.Size(183, 30);
            this.OPEN_MenuItem.Text = "Открыть";
            this.OPEN_MenuItem.Click += new System.EventHandler(this.OPEN_MenuItem_Click);
            // 
            // SAVE_MenuItem
            // 
            this.SAVE_MenuItem.Name = "SAVE_MenuItem";
            this.SAVE_MenuItem.Size = new System.Drawing.Size(183, 30);
            this.SAVE_MenuItem.Text = "Сохранить";
            this.SAVE_MenuItem.Click += new System.EventHandler(this.SAVE_MenuItem_Click);
            // 
            // QUIT_MenuItem
            // 
            this.QUIT_MenuItem.Name = "QUIT_MenuItem";
            this.QUIT_MenuItem.Size = new System.Drawing.Size(183, 30);
            this.QUIT_MenuItem.Text = "Выход";
            this.QUIT_MenuItem.Click += new System.EventHandler(this.QUIT_MenuItem_Click);
            // 
            // VIEW_MenuItem
            // 
            this.VIEW_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADMINview_MenuItem,
            this.EXPERTview_MenuItem});
            this.VIEW_MenuItem.Name = "VIEW_MenuItem";
            this.VIEW_MenuItem.Size = new System.Drawing.Size(54, 29);
            this.VIEW_MenuItem.Text = "Вид";
            // 
            // ADMINview_MenuItem
            // 
            this.ADMINview_MenuItem.Name = "ADMINview_MenuItem";
            this.ADMINview_MenuItem.Size = new System.Drawing.Size(226, 30);
            this.ADMINview_MenuItem.Text = "Администратор";
            // 
            // EXPERTview_MenuItem
            // 
            this.EXPERTview_MenuItem.Name = "EXPERTview_MenuItem";
            this.EXPERTview_MenuItem.Size = new System.Drawing.Size(226, 30);
            this.EXPERTview_MenuItem.Text = "Эксперт";
            // 
            // HELP_MenuItem
            // 
            this.HELP_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ABOUT_MenuItem});
            this.HELP_MenuItem.Name = "HELP_MenuItem";
            this.HELP_MenuItem.Size = new System.Drawing.Size(93, 29);
            this.HELP_MenuItem.Text = "Справка";
            // 
            // ABOUT_MenuItem
            // 
            this.ABOUT_MenuItem.Name = "ABOUT_MenuItem";
            this.ABOUT_MenuItem.Size = new System.Drawing.Size(210, 30);
            this.ABOUT_MenuItem.Text = "О программе";
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.TreeBuild);
            this.TabControl.Controls.Add(this.TreeImport);
            this.TabControl.Controls.Add(this.Weights);
            this.TabControl.Location = new System.Drawing.Point(0, 47);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1043, 611);
            this.TabControl.TabIndex = 2;
            this.TabControl.TabStop = false;
            // 
            // TreeBuild
            // 
            this.TreeBuild.Controls.Add(this.tableLayoutPanel1);
            this.TreeBuild.Location = new System.Drawing.Point(4, 29);
            this.TreeBuild.Name = "TreeBuild";
            this.TreeBuild.Padding = new System.Windows.Forms.Padding(3);
            this.TreeBuild.Size = new System.Drawing.Size(1035, 578);
            this.TreeBuild.TabIndex = 10;
            this.TreeBuild.Text = "TreeBuild";
            this.TreeBuild.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel1.Controls.Add(this.BuiltTreeView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Description1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Close_button1, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.EditTreeButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalcEventualWeightsButton, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 572);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // BuiltTreeView
            // 
            this.BuiltTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.BuiltTreeView, 4);
            this.BuiltTreeView.Location = new System.Drawing.Point(3, 46);
            this.BuiltTreeView.Name = "BuiltTreeView";
            this.tableLayoutPanel1.SetRowSpan(this.BuiltTreeView, 2);
            this.BuiltTreeView.Size = new System.Drawing.Size(1026, 462);
            this.BuiltTreeView.TabIndex = 0;
            // 
            // Description1
            // 
            this.Description1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.Description1, 4);
            this.Description1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description1.Location = new System.Drawing.Point(3, 3);
            this.Description1.Multiline = true;
            this.Description1.Name = "Description1";
            this.Description1.ReadOnly = true;
            this.Description1.Size = new System.Drawing.Size(1026, 37);
            this.Description1.TabIndex = 12;
            this.Description1.Text = "Для перехода к проставлению оценок дважды щелкните ПРАВОЙ кнопкой мыши.          " +
    " Красный означает, что веса рассчитаны";
            // 
            // Close_button1
            // 
            this.Close_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button1.Location = new System.Drawing.Point(812, 514);
            this.Close_button1.Name = "Close_button1";
            this.Close_button1.Size = new System.Drawing.Size(217, 55);
            this.Close_button1.TabIndex = 16;
            this.Close_button1.Text = "???";
            this.Close_button1.UseVisualStyleBackColor = true;
            this.Close_button1.Click += new System.EventHandler(this.CloseButton1_Click);
            // 
            // EditTreeButton
            // 
            this.EditTreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditTreeButton.Location = new System.Drawing.Point(3, 514);
            this.EditTreeButton.Name = "EditTreeButton";
            this.EditTreeButton.Size = new System.Drawing.Size(155, 55);
            this.EditTreeButton.TabIndex = 1;
            this.EditTreeButton.Text = "Редактировать дерево";
            this.EditTreeButton.UseVisualStyleBackColor = true;
            this.EditTreeButton.Click += new System.EventHandler(this.EditTreeButton_Click);
            // 
            // CalcEventualWeightsButton
            // 
            this.CalcEventualWeightsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.CalcEventualWeightsButton, 2);
            this.CalcEventualWeightsButton.Location = new System.Drawing.Point(164, 514);
            this.CalcEventualWeightsButton.Name = "CalcEventualWeightsButton";
            this.CalcEventualWeightsButton.Size = new System.Drawing.Size(642, 55);
            this.CalcEventualWeightsButton.TabIndex = 13;
            this.CalcEventualWeightsButton.Text = " Расчет весов альтернатив";
            this.CalcEventualWeightsButton.UseVisualStyleBackColor = true;
            this.CalcEventualWeightsButton.Click += new System.EventHandler(this.CalcEventualWeightsButton_Click);
            // 
            // TreeImport
            // 
            this.TreeImport.Controls.Add(this.tableLayoutPanel2);
            this.TreeImport.Location = new System.Drawing.Point(4, 29);
            this.TreeImport.Name = "TreeImport";
            this.TreeImport.Padding = new System.Windows.Forms.Padding(3);
            this.TreeImport.Size = new System.Drawing.Size(1176, 578);
            this.TreeImport.TabIndex = 11;
            this.TreeImport.Text = "TreeImport";
            this.TreeImport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel2.Controls.Add(this.Description2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TreeText, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BuildTreeButton, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1173, 572);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Description2
            // 
            this.Description2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.Description2, 4);
            this.Description2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description2.Location = new System.Drawing.Point(3, 3);
            this.Description2.Multiline = true;
            this.Description2.Name = "Description2";
            this.Description2.ReadOnly = true;
            this.Description2.Size = new System.Drawing.Size(1167, 37);
            this.Description2.TabIndex = 12;
            this.Description2.Text = "Вставьте список критериев иерархии в следующем формате \"x.x.x.x Название критерия" +
    "\"";
            // 
            // TreeText
            // 
            this.TreeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.TreeText, 4);
            this.TreeText.Location = new System.Drawing.Point(3, 46);
            this.TreeText.Multiline = true;
            this.TreeText.Name = "TreeText";
            this.tableLayoutPanel2.SetRowSpan(this.TreeText, 2);
            this.TreeText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TreeText.Size = new System.Drawing.Size(1167, 466);
            this.TreeText.TabIndex = 0;
            this.TreeText.Text = resources.GetString("TreeText.Text");
            // 
            // BuildTreeButton
            // 
            this.BuildTreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.BuildTreeButton, 4);
            this.BuildTreeButton.Location = new System.Drawing.Point(3, 518);
            this.BuildTreeButton.Name = "BuildTreeButton";
            this.BuildTreeButton.Size = new System.Drawing.Size(1167, 51);
            this.BuildTreeButton.TabIndex = 13;
            this.BuildTreeButton.Text = "Построить дерево";
            this.BuildTreeButton.UseVisualStyleBackColor = true;
            this.BuildTreeButton.Click += new System.EventHandler(this.BuildTreeButton_Click);
            // 
            // Weights
            // 
            this.Weights.Controls.Add(this.tableLayoutPanel3);
            this.Weights.Location = new System.Drawing.Point(4, 29);
            this.Weights.Name = "Weights";
            this.Weights.Padding = new System.Windows.Forms.Padding(3);
            this.Weights.Size = new System.Drawing.Size(1176, 578);
            this.Weights.TabIndex = 12;
            this.Weights.Text = "Weights";
            this.Weights.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.03564F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.63103F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel3.Controls.Add(this.EventualWeightsGrid, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.GridForCalculation, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CloseButton3, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.BackButton3, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1177, 578);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // EventualWeightsGrid
            // 
            this.EventualWeightsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventualWeightsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EventualWeightsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.EventualWeightsGrid, 4);
            this.EventualWeightsGrid.Location = new System.Drawing.Point(3, 46);
            this.EventualWeightsGrid.Name = "EventualWeightsGrid";
            this.tableLayoutPanel3.SetRowSpan(this.EventualWeightsGrid, 2);
            this.EventualWeightsGrid.Size = new System.Drawing.Size(1171, 468);
            this.EventualWeightsGrid.TabIndex = 0;
            // 
            // GridForCalculation
            // 
            this.GridForCalculation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridForCalculation.Location = new System.Drawing.Point(3, 3);
            this.GridForCalculation.Name = "GridForCalculation";
            this.GridForCalculation.RowTemplate.Height = 28;
            this.GridForCalculation.Size = new System.Drawing.Size(10, 10);
            this.GridForCalculation.TabIndex = 2;
            // 
            // CloseButton3
            // 
            this.CloseButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton3.Location = new System.Drawing.Point(909, 520);
            this.CloseButton3.Name = "CloseButton3";
            this.CloseButton3.Size = new System.Drawing.Size(265, 55);
            this.CloseButton3.TabIndex = 15;
            this.CloseButton3.Text = "????";
            this.CloseButton3.UseVisualStyleBackColor = true;
            this.CloseButton3.Click += new System.EventHandler(this.CloseButton3_Click);
            // 
            // BackButton3
            // 
            this.BackButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton3.Location = new System.Drawing.Point(3, 520);
            this.BackButton3.Name = "BackButton3";
            this.BackButton3.Size = new System.Drawing.Size(257, 55);
            this.BackButton3.TabIndex = 1;
            this.BackButton3.Text = "Назад";
            this.BackButton3.UseVisualStyleBackColor = true;
            this.BackButton3.Click += new System.EventHandler(this.BackButton3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1043, 660);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Оценка Эффективности";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.TreeBuild.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TreeImport.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Weights.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventualWeightsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridForCalculation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FILE_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem QUIT_MenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TreeImport;
        private System.Windows.Forms.TextBox TreeText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Description2;
        private System.Windows.Forms.Button BuildTreeButton;
        private System.Windows.Forms.ToolStripMenuItem VIEW_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ADMINview_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem EXPERTview_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem HELP_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ABOUT_MenuItem;
        private System.Windows.Forms.TabPage TreeBuild;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button EditTreeButton;
        private System.Windows.Forms.TextBox Description1;
        private System.Windows.Forms.TreeView BuiltTreeView;
        private System.Windows.Forms.TabPage Weights;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView EventualWeightsGrid;
        private System.Windows.Forms.Button CalcEventualWeightsButton;
        private System.Windows.Forms.Button BackButton3;
        private System.Windows.Forms.ToolStripMenuItem OPEN_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem SAVE_MenuItem;
        private System.Windows.Forms.DataGridView GridForCalculation;
        private System.Windows.Forms.Button CloseButton3;
        private System.Windows.Forms.Button Close_button1;
    }

}

