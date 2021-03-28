namespace UI
{
    partial class Dodatoc4Grid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodatoc4Grid));
            this.generatorDataSet = new UI.GeneratorDataSet();
            this.dodatoc4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodatoc4TableAdapter = new UI.GeneratorDataSetTableAdapters.Dodatoc4TableAdapter();
            this.tableAdapterManager = new UI.GeneratorDataSetTableAdapters.TableAdapterManager();
            this.dodatoc4BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dodatoc4BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dodatoc4AdvancedDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.generatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatoc4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatoc4BindingNavigator)).BeginInit();
            this.dodatoc4BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodatoc4AdvancedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // generatorDataSet
            // 
            this.generatorDataSet.DataSetName = "GeneratorDataSet";
            this.generatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dodatoc4BindingSource
            // 
            this.dodatoc4BindingSource.DataMember = "Dodatoc4";
            this.dodatoc4BindingSource.DataSource = this.generatorDataSet;
            // 
            // dodatoc4TableAdapter
            // 
            this.dodatoc4TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Dodatoc1TableAdapter = null;
            this.tableAdapterManager.Dodatoc2TableAdapter = null;
            this.tableAdapterManager.Dodatoc4TableAdapter = this.dodatoc4TableAdapter;
            this.tableAdapterManager.Dodatoc5TableAdapter = null;
            this.tableAdapterManager.DynamicTablesTableAdapter = null;
            this.tableAdapterManager.Forma7TableAdapter = null;
            this.tableAdapterManager.FormaN1TableAdapter = null;
            this.tableAdapterManager.FormaN5TableAdapter = null;
            this.tableAdapterManager.FormaNpvsTableAdapter = null;
            this.tableAdapterManager.FormaNtsTableAdapter = null;
            this.tableAdapterManager.FormaZvtsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UI.GeneratorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dodatoc4BindingNavigator
            // 
            this.dodatoc4BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dodatoc4BindingNavigator.BindingSource = this.dodatoc4BindingSource;
            this.dodatoc4BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dodatoc4BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dodatoc4BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dodatoc4BindingNavigatorSaveItem});
            this.dodatoc4BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dodatoc4BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dodatoc4BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dodatoc4BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dodatoc4BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dodatoc4BindingNavigator.Name = "dodatoc4BindingNavigator";
            this.dodatoc4BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dodatoc4BindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.dodatoc4BindingNavigator.TabIndex = 0;
            this.dodatoc4BindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dodatoc4BindingNavigatorSaveItem
            // 
            this.dodatoc4BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dodatoc4BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dodatoc4BindingNavigatorSaveItem.Image")));
            this.dodatoc4BindingNavigatorSaveItem.Name = "dodatoc4BindingNavigatorSaveItem";
            this.dodatoc4BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dodatoc4BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.dodatoc4BindingNavigatorSaveItem.Click += new System.EventHandler(this.dodatoc4BindingNavigatorSaveItem_Click);
            // 
            // dodatoc4AdvancedDataGridView
            // 
            this.dodatoc4AdvancedDataGridView.AutoGenerateColumns = false;
            this.dodatoc4AdvancedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dodatoc4AdvancedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dodatoc4AdvancedDataGridView.DataSource = this.dodatoc4BindingSource;
            this.dodatoc4AdvancedDataGridView.FilterAndSortEnabled = true;
            this.dodatoc4AdvancedDataGridView.Location = new System.Drawing.Point(12, 28);
            this.dodatoc4AdvancedDataGridView.Name = "dodatoc4AdvancedDataGridView";
            this.dodatoc4AdvancedDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dodatoc4AdvancedDataGridView.Size = new System.Drawing.Size(960, 521);
            this.dodatoc4AdvancedDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Input_1_орган_управління_освітою";
            this.dataGridViewTextBoxColumn11.HeaderText = "Input_1_орган_управління_освітою";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Input_2_дата_час_нещасності";
            this.dataGridViewTextBoxColumn12.HeaderText = "Input_2_дата_час_нещасності";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Input_3_назва_навчального_закладу";
            this.dataGridViewTextBoxColumn13.HeaderText = "Input_3_назва_навчального_закладу";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Input_4_місце_нещасності";
            this.dataGridViewTextBoxColumn14.HeaderText = "Input_4_місце_нещасності";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Input_5_дані_потерпілих";
            this.dataGridViewTextBoxColumn15.HeaderText = "Input_5_дані_потерпілих";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Input_6_характер_травм";
            this.dataGridViewTextBoxColumn16.HeaderText = "Input_6_характер_травм";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Input_7_обставини_нещасності";
            this.dataGridViewTextBoxColumn17.HeaderText = "Input_7_обставини_нещасності";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Input_8_дата_передачі_інформації";
            this.dataGridViewTextBoxColumn18.HeaderText = "Input_8_дата_передачі_інформації";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Dodatoc4Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dodatoc4AdvancedDataGridView);
            this.Controls.Add(this.dodatoc4BindingNavigator);
            this.Name = "Dodatoc4Grid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodatoc4Grid";
            this.Load += new System.EventHandler(this.Dodatoc4Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatoc4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodatoc4BindingNavigator)).EndInit();
            this.dodatoc4BindingNavigator.ResumeLayout(false);
            this.dodatoc4BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodatoc4AdvancedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfOrganAndAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfOrganAndOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeInjuriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn causesAccidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private GeneratorDataSet generatorDataSet;
        private System.Windows.Forms.BindingSource dodatoc4BindingSource;
        private GeneratorDataSetTableAdapters.Dodatoc4TableAdapter dodatoc4TableAdapter;
        private GeneratorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dodatoc4BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dodatoc4BindingNavigatorSaveItem;
        private Zuby.ADGV.AdvancedDataGridView dodatoc4AdvancedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}