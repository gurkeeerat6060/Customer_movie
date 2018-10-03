namespace Customer_movie
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label rMIDLabel;
            System.Windows.Forms.Label movieIDFKLabel;
            System.Windows.Forms.Label custIDFKLabel;
            System.Windows.Forms.Label dateRentedLabel;
            System.Windows.Forms.Label dateReturnedLabel;
            this.customersDataSet = new Customer_movie.CustomersDataSet();
            this.rented_moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rented_moviesTableAdapter = new Customer_movie.CustomersDataSetTableAdapters.Rented_moviesTableAdapter();
            this.tableAdapterManager = new Customer_movie.CustomersDataSetTableAdapters.TableAdapterManager();
            this.rented_moviesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rented_moviesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rented_moviesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rMIDTextBox = new System.Windows.Forms.TextBox();
            this.movieIDFKTextBox = new System.Windows.Forms.TextBox();
            this.custIDFKTextBox = new System.Windows.Forms.TextBox();
            this.dateRentedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateReturnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_Search2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1_Exit = new System.Windows.Forms.Button();
            rMIDLabel = new System.Windows.Forms.Label();
            movieIDFKLabel = new System.Windows.Forms.Label();
            custIDFKLabel = new System.Windows.Forms.Label();
            dateRentedLabel = new System.Windows.Forms.Label();
            dateReturnedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rented_moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rented_moviesBindingNavigator)).BeginInit();
            this.rented_moviesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rented_moviesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "CustomersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rented_moviesBindingSource
            // 
            this.rented_moviesBindingSource.DataMember = "Rented_movies";
            this.rented_moviesBindingSource.DataSource = this.customersDataSet;
            // 
            // rented_moviesTableAdapter
            // 
            this.rented_moviesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.MoviesTableAdapter = null;
            this.tableAdapterManager.Rented_moviesTableAdapter = this.rented_moviesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Customer_movie.CustomersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rented_moviesBindingNavigator
            // 
            this.rented_moviesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rented_moviesBindingNavigator.BindingSource = this.rented_moviesBindingSource;
            this.rented_moviesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rented_moviesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rented_moviesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rented_moviesBindingNavigatorSaveItem});
            this.rented_moviesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rented_moviesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rented_moviesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rented_moviesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rented_moviesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rented_moviesBindingNavigator.Name = "rented_moviesBindingNavigator";
            this.rented_moviesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rented_moviesBindingNavigator.Size = new System.Drawing.Size(874, 25);
            this.rented_moviesBindingNavigator.TabIndex = 0;
            this.rented_moviesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // rented_moviesBindingNavigatorSaveItem
            // 
            this.rented_moviesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rented_moviesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rented_moviesBindingNavigatorSaveItem.Image")));
            this.rented_moviesBindingNavigatorSaveItem.Name = "rented_moviesBindingNavigatorSaveItem";
            this.rented_moviesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rented_moviesBindingNavigatorSaveItem.Text = "Save Data";
            this.rented_moviesBindingNavigatorSaveItem.Click += new System.EventHandler(this.rented_moviesBindingNavigatorSaveItem_Click);
            // 
            // rented_moviesDataGridView
            // 
            this.rented_moviesDataGridView.AutoGenerateColumns = false;
            this.rented_moviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rented_moviesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rented_moviesDataGridView.DataSource = this.rented_moviesBindingSource;
            this.rented_moviesDataGridView.Location = new System.Drawing.Point(33, 105);
            this.rented_moviesDataGridView.Name = "rented_moviesDataGridView";
            this.rented_moviesDataGridView.Size = new System.Drawing.Size(377, 263);
            this.rented_moviesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RMID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RMID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MovieIDFK";
            this.dataGridViewTextBoxColumn2.HeaderText = "MovieIDFK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustIDFK";
            this.dataGridViewTextBoxColumn3.HeaderText = "CustIDFK";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateRented";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateRented";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateReturned";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateReturned";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // rMIDLabel
            // 
            rMIDLabel.AutoSize = true;
            rMIDLabel.Location = new System.Drawing.Point(436, 179);
            rMIDLabel.Name = "rMIDLabel";
            rMIDLabel.Size = new System.Drawing.Size(38, 13);
            rMIDLabel.TabIndex = 2;
            rMIDLabel.Text = "RMID:";
            // 
            // rMIDTextBox
            // 
            this.rMIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rented_moviesBindingSource, "RMID", true));
            this.rMIDTextBox.Location = new System.Drawing.Point(522, 176);
            this.rMIDTextBox.Name = "rMIDTextBox";
            this.rMIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.rMIDTextBox.TabIndex = 3;
            // 
            // movieIDFKLabel
            // 
            movieIDFKLabel.AutoSize = true;
            movieIDFKLabel.Location = new System.Drawing.Point(436, 205);
            movieIDFKLabel.Name = "movieIDFKLabel";
            movieIDFKLabel.Size = new System.Drawing.Size(66, 13);
            movieIDFKLabel.TabIndex = 4;
            movieIDFKLabel.Text = "Movie IDFK:";
            // 
            // movieIDFKTextBox
            // 
            this.movieIDFKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rented_moviesBindingSource, "MovieIDFK", true));
            this.movieIDFKTextBox.Location = new System.Drawing.Point(522, 202);
            this.movieIDFKTextBox.Name = "movieIDFKTextBox";
            this.movieIDFKTextBox.Size = new System.Drawing.Size(200, 20);
            this.movieIDFKTextBox.TabIndex = 5;
            // 
            // custIDFKLabel
            // 
            custIDFKLabel.AutoSize = true;
            custIDFKLabel.Location = new System.Drawing.Point(436, 231);
            custIDFKLabel.Name = "custIDFKLabel";
            custIDFKLabel.Size = new System.Drawing.Size(58, 13);
            custIDFKLabel.TabIndex = 6;
            custIDFKLabel.Text = "Cust IDFK:";
            // 
            // custIDFKTextBox
            // 
            this.custIDFKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rented_moviesBindingSource, "CustIDFK", true));
            this.custIDFKTextBox.Location = new System.Drawing.Point(522, 228);
            this.custIDFKTextBox.Name = "custIDFKTextBox";
            this.custIDFKTextBox.Size = new System.Drawing.Size(200, 20);
            this.custIDFKTextBox.TabIndex = 7;
            // 
            // dateRentedLabel
            // 
            dateRentedLabel.AutoSize = true;
            dateRentedLabel.Location = new System.Drawing.Point(436, 258);
            dateRentedLabel.Name = "dateRentedLabel";
            dateRentedLabel.Size = new System.Drawing.Size(71, 13);
            dateRentedLabel.TabIndex = 8;
            dateRentedLabel.Text = "Date Rented:";
            // 
            // dateRentedDateTimePicker
            // 
            this.dateRentedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rented_moviesBindingSource, "DateRented", true));
            this.dateRentedDateTimePicker.Location = new System.Drawing.Point(522, 254);
            this.dateRentedDateTimePicker.Name = "dateRentedDateTimePicker";
            this.dateRentedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateRentedDateTimePicker.TabIndex = 9;
            // 
            // dateReturnedLabel
            // 
            dateReturnedLabel.AutoSize = true;
            dateReturnedLabel.Location = new System.Drawing.Point(436, 284);
            dateReturnedLabel.Name = "dateReturnedLabel";
            dateReturnedLabel.Size = new System.Drawing.Size(80, 13);
            dateReturnedLabel.TabIndex = 10;
            dateReturnedLabel.Text = "Date Returned:";
            // 
            // dateReturnedDateTimePicker
            // 
            this.dateReturnedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rented_moviesBindingSource, "DateReturned", true));
            this.dateReturnedDateTimePicker.Location = new System.Drawing.Point(522, 280);
            this.dateReturnedDateTimePicker.Name = "dateReturnedDateTimePicker";
            this.dateReturnedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateReturnedDateTimePicker.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // button1_Search2
            // 
            this.button1_Search2.Location = new System.Drawing.Point(202, 375);
            this.button1_Search2.Name = "button1_Search2";
            this.button1_Search2.Size = new System.Drawing.Size(75, 23);
            this.button1_Search2.TabIndex = 13;
            this.button1_Search2.Text = "Search";
            this.button1_Search2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rented movies detail";
            // 
            // button1_Exit
            // 
            this.button1_Exit.Location = new System.Drawing.Point(461, 356);
            this.button1_Exit.Name = "button1_Exit";
            this.button1_Exit.Size = new System.Drawing.Size(75, 23);
            this.button1_Exit.TabIndex = 16;
            this.button1_Exit.Text = "Home";
            this.button1_Exit.UseVisualStyleBackColor = true;
            this.button1_Exit.Click += new System.EventHandler(this.button1_Exit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 421);
            this.Controls.Add(this.button1_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_Search2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(rMIDLabel);
            this.Controls.Add(this.rMIDTextBox);
            this.Controls.Add(movieIDFKLabel);
            this.Controls.Add(this.movieIDFKTextBox);
            this.Controls.Add(custIDFKLabel);
            this.Controls.Add(this.custIDFKTextBox);
            this.Controls.Add(dateRentedLabel);
            this.Controls.Add(this.dateRentedDateTimePicker);
            this.Controls.Add(dateReturnedLabel);
            this.Controls.Add(this.dateReturnedDateTimePicker);
            this.Controls.Add(this.rented_moviesDataGridView);
            this.Controls.Add(this.rented_moviesBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rented_moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rented_moviesBindingNavigator)).EndInit();
            this.rented_moviesBindingNavigator.ResumeLayout(false);
            this.rented_moviesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rented_moviesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource rented_moviesBindingSource;
        private CustomersDataSetTableAdapters.Rented_moviesTableAdapter rented_moviesTableAdapter;
        private CustomersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rented_moviesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rented_moviesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rented_moviesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox rMIDTextBox;
        private System.Windows.Forms.TextBox movieIDFKTextBox;
        private System.Windows.Forms.TextBox custIDFKTextBox;
        private System.Windows.Forms.DateTimePicker dateRentedDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateReturnedDateTimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_Search2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1_Exit;
    }
}