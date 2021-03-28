namespace UI
{
    partial class FormaZvtGrid
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaZvtGrid));
            this.generatorDataSet = new UI.GeneratorDataSet();
            this.formaZvtsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formaZvtsTableAdapter = new UI.GeneratorDataSetTableAdapters.FormaZvtsTableAdapter();
            this.tableAdapterManager = new UI.GeneratorDataSetTableAdapters.TableAdapterManager();
            this.formaZvtsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.formaZvtsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.formaZvtsAdvancedDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.generatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaZvtsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaZvtsBindingNavigator)).BeginInit();
            this.formaZvtsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formaZvtsAdvancedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // generatorDataSet
            // 
            this.generatorDataSet.DataSetName = "GeneratorDataSet";
            this.generatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formaZvtsBindingSource
            // 
            this.formaZvtsBindingSource.DataMember = "FormaZvts";
            this.formaZvtsBindingSource.DataSource = this.generatorDataSet;
            // 
            // formaZvtsTableAdapter
            // 
            this.formaZvtsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Dodatoc1TableAdapter = null;
            this.tableAdapterManager.Dodatoc2TableAdapter = null;
            this.tableAdapterManager.Dodatoc4TableAdapter = null;
            this.tableAdapterManager.Dodatoc5TableAdapter = null;
            this.tableAdapterManager.DynamicTablesTableAdapter = null;
            this.tableAdapterManager.Forma7TableAdapter = null;
            this.tableAdapterManager.FormaN1TableAdapter = null;
            this.tableAdapterManager.FormaN5TableAdapter = null;
            this.tableAdapterManager.FormaNpvsTableAdapter = null;
            this.tableAdapterManager.FormaNtsTableAdapter = null;
            this.tableAdapterManager.FormaZvtsTableAdapter = this.formaZvtsTableAdapter;
            this.tableAdapterManager.UpdateOrder = UI.GeneratorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // formaZvtsBindingNavigator
            // 
            this.formaZvtsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.formaZvtsBindingNavigator.BindingSource = this.formaZvtsBindingSource;
            this.formaZvtsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.formaZvtsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.formaZvtsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.formaZvtsBindingNavigatorSaveItem});
            this.formaZvtsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.formaZvtsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.formaZvtsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.formaZvtsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.formaZvtsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.formaZvtsBindingNavigator.Name = "formaZvtsBindingNavigator";
            this.formaZvtsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.formaZvtsBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.formaZvtsBindingNavigator.TabIndex = 0;
            this.formaZvtsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // formaZvtsBindingNavigatorSaveItem
            // 
            this.formaZvtsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.formaZvtsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("formaZvtsBindingNavigatorSaveItem.Image")));
            this.formaZvtsBindingNavigatorSaveItem.Name = "formaZvtsBindingNavigatorSaveItem";
            this.formaZvtsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.formaZvtsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.formaZvtsBindingNavigatorSaveItem.Click += new System.EventHandler(this.formaZvtsBindingNavigatorSaveItem_Click);
            // 
            // formaZvtsAdvancedDataGridView
            // 
            this.formaZvtsAdvancedDataGridView.AutoGenerateColumns = false;
            this.formaZvtsAdvancedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formaZvtsAdvancedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.formaZvtsAdvancedDataGridView.DataSource = this.formaZvtsBindingSource;
            this.formaZvtsAdvancedDataGridView.FilterAndSortEnabled = true;
            this.formaZvtsAdvancedDataGridView.Location = new System.Drawing.Point(12, 28);
            this.formaZvtsAdvancedDataGridView.Name = "formaZvtsAdvancedDataGridView";
            this.formaZvtsAdvancedDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.formaZvtsAdvancedDataGridView.Size = new System.Drawing.Size(960, 521);
            this.formaZvtsAdvancedDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Input_1_назва_організації_профспілки";
            this.dataGridViewTextBoxColumn2.HeaderText = "Input_1_назва_організації_профспілки";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Input_2_рік";
            this.dataGridViewTextBoxColumn3.HeaderText = "Input_2_рік";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Input_3_кількість_інспекторів_гаджетів";
            this.dataGridViewTextBoxColumn4.HeaderText = "Input_3_кількість_інспекторів_гаджетів";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Input_4_т_3_р_4_к_2";
            this.dataGridViewTextBoxColumn5.HeaderText = "Input_4_т_3_р_4_к_2";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Input_5_т_3_р_4_к_3";
            this.dataGridViewTextBoxColumn6.HeaderText = "Input_5_т_3_р_4_к_3";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Input_6_т_3_р_5_к_2";
            this.dataGridViewTextBoxColumn7.HeaderText = "Input_6_т_3_р_5_к_2";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Input_7_т_3_р_5_к_3";
            this.dataGridViewTextBoxColumn8.HeaderText = "Input_7_т_3_р_5_к_3";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Input_8_т_3_р_6_к_2";
            this.dataGridViewTextBoxColumn9.HeaderText = "Input_8_т_3_р_6_к_2";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Input_9_т_3_р_6_к_3";
            this.dataGridViewTextBoxColumn10.HeaderText = "Input_9_т_3_р_6_к_3";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Input_10_т_3_р_7_к_2";
            this.dataGridViewTextBoxColumn11.HeaderText = "Input_10_т_3_р_7_к_2";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Input_11_т_3_р_7_к_3";
            this.dataGridViewTextBoxColumn12.HeaderText = "Input_11_т_3_р_7_к_3";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Input_12_т_3_р_8_к_2";
            this.dataGridViewTextBoxColumn13.HeaderText = "Input_12_т_3_р_8_к_2";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Input_13_т_3_р_8_к_3";
            this.dataGridViewTextBoxColumn14.HeaderText = "Input_13_т_3_р_8_к_3";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Input_14_т_3_р_9_к_2";
            this.dataGridViewTextBoxColumn15.HeaderText = "Input_14_т_3_р_9_к_2";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Input_15_т_3_р_9_к_3";
            this.dataGridViewTextBoxColumn16.HeaderText = "Input_15_т_3_р_9_к_3";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Input_16_т_3_р_10_к_2";
            this.dataGridViewTextBoxColumn17.HeaderText = "Input_16_т_3_р_10_к_2";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Input_17_т_3_р_10_к_3";
            this.dataGridViewTextBoxColumn18.HeaderText = "Input_17_т_3_р_10_к_3";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Input_18_т_3_р_11_к_2";
            this.dataGridViewTextBoxColumn19.HeaderText = "Input_18_т_3_р_11_к_2";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Input_19_т_3_р_11_к_3";
            this.dataGridViewTextBoxColumn20.HeaderText = "Input_19_т_3_р_11_к_3";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Input_20_т_3_р_12_к_2";
            this.dataGridViewTextBoxColumn21.HeaderText = "Input_20_т_3_р_12_к_2";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Input_21_т_3_р_12_к_3";
            this.dataGridViewTextBoxColumn22.HeaderText = "Input_21_т_3_р_12_к_3";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Input_22_тех_інспектор_праці_1";
            this.dataGridViewTextBoxColumn23.HeaderText = "Input_22_тех_інспектор_праці_1";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Input_23_тех_інспектор_праці_2";
            this.dataGridViewTextBoxColumn24.HeaderText = "Input_23_тех_інспектор_праці_2";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FormaZvtGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.formaZvtsAdvancedDataGridView);
            this.Controls.Add(this.formaZvtsBindingNavigator);
            this.Name = "FormaZvtGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaZvtGrid";
            this.Load += new System.EventHandler(this.FormaZvtGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaZvtsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaZvtsBindingNavigator)).EndInit();
            this.formaZvtsBindingNavigator.ResumeLayout(false);
            this.formaZvtsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formaZvtsAdvancedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GeneratorDataSet generatorDataSet;
        private System.Windows.Forms.BindingSource formaZvtsBindingSource;
        private GeneratorDataSetTableAdapters.FormaZvtsTableAdapter formaZvtsTableAdapter;
        private GeneratorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator formaZvtsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton formaZvtsBindingNavigatorSaveItem;
        private Zuby.ADGV.AdvancedDataGridView formaZvtsAdvancedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    }
}