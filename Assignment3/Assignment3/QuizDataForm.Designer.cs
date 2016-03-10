namespace Assignment3
{
    partial class QuizDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizDataForm));
            this.quizDataSet1 = new Assignment3.QuizDataSet1();
            this.examineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examineeTableAdapter = new Assignment3.QuizDataSet1TableAdapters.ExamineeTableAdapter();
            this.tableAdapterManager = new Assignment3.QuizDataSet1TableAdapters.TableAdapterManager();
            this.examineeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.examineeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.examineeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizTableAdapter = new Assignment3.QuizDataSet1TableAdapters.QuizTableAdapter();
            this.quizDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTableAdapter = new Assignment3.QuizDataSet1TableAdapters.QuestionTableAdapter();
            this.questionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingNavigator)).BeginInit();
            this.examineeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examineeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // quizDataSet1
            // 
            this.quizDataSet1.DataSetName = "QuizDataSet1";
            this.quizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examineeBindingSource
            // 
            this.examineeBindingSource.DataMember = "Examinee";
            this.examineeBindingSource.DataSource = this.quizDataSet1;
            // 
            // examineeTableAdapter
            // 
            this.examineeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExamineeTableAdapter = this.examineeTableAdapter;
            this.tableAdapterManager.OptionsTableAdapter = null;
            this.tableAdapterManager.QuestionTableAdapter = this.questionTableAdapter;
            this.tableAdapterManager.QuizTableAdapter = this.quizTableAdapter;
            this.tableAdapterManager.UpdateOrder = Assignment3.QuizDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // examineeBindingNavigator
            // 
            this.examineeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.examineeBindingNavigator.BindingSource = this.examineeBindingSource;
            this.examineeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.examineeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.examineeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.examineeBindingNavigatorSaveItem});
            this.examineeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.examineeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.examineeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.examineeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.examineeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.examineeBindingNavigator.Name = "examineeBindingNavigator";
            this.examineeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.examineeBindingNavigator.Size = new System.Drawing.Size(891, 25);
            this.examineeBindingNavigator.TabIndex = 0;
            this.examineeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // examineeBindingNavigatorSaveItem
            // 
            this.examineeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.examineeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("examineeBindingNavigatorSaveItem.Image")));
            this.examineeBindingNavigatorSaveItem.Name = "examineeBindingNavigatorSaveItem";
            this.examineeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.examineeBindingNavigatorSaveItem.Text = "Save Data";
            this.examineeBindingNavigatorSaveItem.Click += new System.EventHandler(this.examineeBindingNavigatorSaveItem_Click);
            // 
            // examineeDataGridView
            // 
            this.examineeDataGridView.AutoGenerateColumns = false;
            this.examineeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examineeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.examineeDataGridView.DataSource = this.examineeBindingSource;
            this.examineeDataGridView.Location = new System.Drawing.Point(12, 46);
            this.examineeDataGridView.Name = "examineeDataGridView";
            this.examineeDataGridView.Size = new System.Drawing.Size(245, 116);
            this.examineeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Examinee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quiz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Question";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Option";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // quizBindingSource
            // 
            this.quizBindingSource.DataMember = "Quiz";
            this.quizBindingSource.DataSource = this.quizDataSet1;
            // 
            // quizTableAdapter
            // 
            this.quizTableAdapter.ClearBeforeFill = true;
            // 
            // quizDataGridView
            // 
            this.quizDataGridView.AutoGenerateColumns = false;
            this.quizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quizDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.quizDataGridView.DataSource = this.quizBindingSource;
            this.quizDataGridView.Location = new System.Drawing.Point(12, 190);
            this.quizDataGridView.Name = "quizDataGridView";
            this.quizDataGridView.Size = new System.Drawing.Size(587, 98);
            this.quizDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn4.HeaderText = "Score";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ExamineeID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ExamineeID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataMember = "Question";
            this.questionBindingSource.DataSource = this.quizDataSet1;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // questionDataGridView
            // 
            this.questionDataGridView.AutoGenerateColumns = false;
            this.questionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.questionDataGridView.DataSource = this.questionBindingSource;
            this.questionDataGridView.Location = new System.Drawing.Point(12, 321);
            this.questionDataGridView.Name = "questionDataGridView";
            this.questionDataGridView.Size = new System.Drawing.Size(587, 106);
            this.questionDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "text";
            this.dataGridViewTextBoxColumn9.HeaderText = "text";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "QuizID";
            this.dataGridViewTextBoxColumn10.HeaderText = "QuizID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // quizDataGridView1
            // 
            this.quizDataGridView1.AutoGenerateColumns = false;
            this.quizDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quizDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.quizDataGridView1.DataSource = this.quizBindingSource;
            this.quizDataGridView1.Location = new System.Drawing.Point(12, 462);
            this.quizDataGridView1.Name = "quizDataGridView1";
            this.quizDataGridView1.Size = new System.Drawing.Size(587, 96);
            this.quizDataGridView1.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn11.HeaderText = "Id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn12.HeaderText = "Score";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn13.HeaderText = "Date";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn14.HeaderText = "Name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ExamineeID";
            this.dataGridViewTextBoxColumn15.HeaderText = "ExamineeID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // QuizDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 703);
            this.Controls.Add(this.quizDataGridView1);
            this.Controls.Add(this.questionDataGridView);
            this.Controls.Add(this.quizDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.examineeDataGridView);
            this.Controls.Add(this.examineeBindingNavigator);
            this.Name = "QuizDataForm";
            this.Text = "QuizDataForm";
            this.Load += new System.EventHandler(this.QuizDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingNavigator)).EndInit();
            this.examineeBindingNavigator.ResumeLayout(false);
            this.examineeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examineeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuizDataSet1 quizDataSet1;
        private System.Windows.Forms.BindingSource examineeBindingSource;
        private QuizDataSet1TableAdapters.ExamineeTableAdapter examineeTableAdapter;
        private QuizDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator examineeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton examineeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView examineeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private QuizDataSet1TableAdapters.QuizTableAdapter quizTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource quizBindingSource;
        private System.Windows.Forms.DataGridView quizDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private QuizDataSet1TableAdapters.QuestionTableAdapter questionTableAdapter;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.DataGridView questionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridView quizDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}