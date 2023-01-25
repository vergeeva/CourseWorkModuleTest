
namespace Trade_Desktop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ЦенаTB = new System.Windows.Forms.TextBox();
            this.товарыViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оптоваяТорговляDataSet = new Trade_Desktop.ОптоваяТорговляDataSet();
            this.АртикулTB = new System.Windows.Forms.TextBox();
            this.TableТовары = new System.Windows.Forms.DataGridView();
            this.FilterCancel = new System.Windows.Forms.ToolStripButton();
            this.FilterAccept = new System.Windows.Forms.ToolStripButton();
            this.ValueTB = new System.Windows.Forms.ToolStripTextBox();
            this.FieldCB = new System.Windows.Forms.ToolStripComboBox();
            this.ButtonUpdate1 = new System.Windows.Forms.ToolStripButton();
            this.ButtonDelete1 = new System.Windows.Forms.ToolStripButton();
            this.НаименованиеTB = new System.Windows.Forms.TextBox();
            this.ButtonAdd1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigatorТовары = new System.Windows.Forms.BindingNavigator(this.components);
            this.StatusLine = new System.Windows.Forms.StatusStrip();
            this.Result1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.товары_ViewTableAdapter = new Trade_Desktop.ОптоваяТорговляDataSetTableAdapters.Товары_ViewTableAdapter();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.кодтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикултовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиетовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценатовараштDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.товарыViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оптоваяТорговляDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableТовары)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorТовары)).BeginInit();
            this.NavigatorТовары.SuspendLayout();
            this.StatusLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // ЦенаTB
            // 
            this.ЦенаTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыViewBindingSource, "Цена_товара_шт", true));
            this.ЦенаTB.Location = new System.Drawing.Point(736, 220);
            this.ЦенаTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ЦенаTB.Name = "ЦенаTB";
            this.ЦенаTB.Size = new System.Drawing.Size(104, 22);
            this.ЦенаTB.TabIndex = 9;
            // 
            // товарыViewBindingSource
            // 
            this.товарыViewBindingSource.DataMember = "Товары_View";
            this.товарыViewBindingSource.DataSource = this.оптоваяТорговляDataSet;
            // 
            // оптоваяТорговляDataSet
            // 
            this.оптоваяТорговляDataSet.DataSetName = "ОптоваяТорговляDataSet";
            this.оптоваяТорговляDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // АртикулTB
            // 
            this.АртикулTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыViewBindingSource, "Артикул_товара", true));
            this.АртикулTB.Location = new System.Drawing.Point(734, 99);
            this.АртикулTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.АртикулTB.Name = "АртикулTB";
            this.АртикулTB.Size = new System.Drawing.Size(163, 22);
            this.АртикулTB.TabIndex = 7;
            // 
            // TableТовары
            // 
            this.TableТовары.AllowUserToAddRows = false;
            this.TableТовары.AllowUserToDeleteRows = false;
            this.TableТовары.AutoGenerateColumns = false;
            this.TableТовары.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableТовары.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодтовараDataGridViewTextBoxColumn,
            this.артикултовараDataGridViewTextBoxColumn,
            this.наименованиетовараDataGridViewTextBoxColumn,
            this.ценатовараштDataGridViewTextBoxColumn});
            this.TableТовары.DataSource = this.товарыViewBindingSource;
            this.TableТовары.Location = new System.Drawing.Point(12, 38);
            this.TableТовары.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableТовары.Name = "TableТовары";
            this.TableТовары.ReadOnly = true;
            this.TableТовары.RowHeadersWidth = 51;
            this.TableТовары.RowTemplate.Height = 24;
            this.TableТовары.Size = new System.Drawing.Size(695, 309);
            this.TableТовары.TabIndex = 6;
            this.TableТовары.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TableТовары_DataError);
            // 
            // FilterCancel
            // 
            this.FilterCancel.AutoSize = false;
            this.FilterCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FilterCancel.Image = ((System.Drawing.Image)(resources.GetObject("FilterCancel.Image")));
            this.FilterCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterCancel.Name = "FilterCancel";
            this.FilterCancel.Size = new System.Drawing.Size(32, 32);
            this.FilterCancel.Tag = "Отменить";
            this.FilterCancel.Text = "Отменить";
            this.FilterCancel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.FilterCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // FilterAccept
            // 
            this.FilterAccept.AutoSize = false;
            this.FilterAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FilterAccept.Image = ((System.Drawing.Image)(resources.GetObject("FilterAccept.Image")));
            this.FilterAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterAccept.Name = "FilterAccept";
            this.FilterAccept.Size = new System.Drawing.Size(32, 32);
            this.FilterAccept.Tag = "Применить";
            this.FilterAccept.Text = "Применить";
            this.FilterAccept.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ValueTB
            // 
            this.ValueTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(100, 35);
            // 
            // FieldCB
            // 
            this.FieldCB.AutoSize = false;
            this.FieldCB.Items.AddRange(new object[] {
            "Артикул_товара",
            "Наименование_товара",
            "Цена_товара_шт"});
            this.FieldCB.Name = "FieldCB";
            this.FieldCB.Size = new System.Drawing.Size(200, 28);
            // 
            // ButtonUpdate1
            // 
            this.ButtonUpdate1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonUpdate1.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUpdate1.Image")));
            this.ButtonUpdate1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonUpdate1.Name = "ButtonUpdate1";
            this.ButtonUpdate1.Size = new System.Drawing.Size(29, 32);
            this.ButtonUpdate1.Text = "Сохранить изменения";
            this.ButtonUpdate1.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonDelete1
            // 
            this.ButtonDelete1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonDelete1.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDelete1.Image")));
            this.ButtonDelete1.Name = "ButtonDelete1";
            this.ButtonDelete1.RightToLeftAutoMirrorImage = true;
            this.ButtonDelete1.Size = new System.Drawing.Size(29, 32);
            this.ButtonDelete1.Text = "Удалить";
            this.ButtonDelete1.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // НаименованиеTB
            // 
            this.НаименованиеTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыViewBindingSource, "Наименование_товара", true));
            this.НаименованиеTB.Location = new System.Drawing.Point(734, 156);
            this.НаименованиеTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.НаименованиеTB.Name = "НаименованиеTB";
            this.НаименованиеTB.Size = new System.Drawing.Size(261, 22);
            this.НаименованиеTB.TabIndex = 8;
            // 
            // ButtonAdd1
            // 
            this.ButtonAdd1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonAdd1.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd1.Image")));
            this.ButtonAdd1.Name = "ButtonAdd1";
            this.ButtonAdd1.RightToLeftAutoMirrorImage = true;
            this.ButtonAdd1.Size = new System.Drawing.Size(29, 32);
            this.ButtonAdd1.Text = "Добавить";
            this.ButtonAdd1.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 32);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 32);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 32);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // NavigatorТовары
            // 
            this.NavigatorТовары.AddNewItem = null;
            this.NavigatorТовары.BindingSource = this.товарыViewBindingSource;
            this.NavigatorТовары.CountItem = this.bindingNavigatorCountItem;
            this.NavigatorТовары.DeleteItem = null;
            this.NavigatorТовары.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavigatorТовары.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.ButtonAdd1,
            this.ButtonDelete1,
            this.ButtonUpdate1,
            this.FieldCB,
            this.ValueTB,
            this.FilterAccept,
            this.FilterCancel});
            this.NavigatorТовары.Location = new System.Drawing.Point(0, 0);
            this.NavigatorТовары.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.NavigatorТовары.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.NavigatorТовары.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.NavigatorТовары.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.NavigatorТовары.Name = "NavigatorТовары";
            this.NavigatorТовары.PositionItem = this.bindingNavigatorPositionItem;
            this.NavigatorТовары.Size = new System.Drawing.Size(1013, 35);
            this.NavigatorТовары.TabIndex = 5;
            // 
            // StatusLine
            // 
            this.StatusLine.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Result1});
            this.StatusLine.Location = new System.Drawing.Point(0, 382);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.StatusLine.Size = new System.Drawing.Size(1013, 26);
            this.StatusLine.TabIndex = 10;
            this.StatusLine.Text = "statusStrip1";
            // 
            // Result1
            // 
            this.Result1.Name = "Result1";
            this.Result1.Size = new System.Drawing.Size(52, 20);
            this.Result1.Text = "Статус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(733, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Цена";
            // 
            // товары_ViewTableAdapter
            // 
            this.товары_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(736, 247);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(228, 29);
            this.ButtonAdd.TabIndex = 14;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(736, 282);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(228, 29);
            this.ButtonUpdate.TabIndex = 15;
            this.ButtonUpdate.Text = "Обновить";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(735, 317);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(228, 29);
            this.ButtonDelete.TabIndex = 16;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(12, 349);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(69, 23);
            this.Result.TabIndex = 17;
            this.Result.Text = "Статус";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(734, 38);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(163, 28);
            this.Next.TabIndex = 18;
            this.Next.Text = "Следующая запись";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.button1_Click);
            // 
            // кодтовараDataGridViewTextBoxColumn
            // 
            this.кодтовараDataGridViewTextBoxColumn.DataPropertyName = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.HeaderText = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодтовараDataGridViewTextBoxColumn.Name = "кодтовараDataGridViewTextBoxColumn";
            this.кодтовараDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодтовараDataGridViewTextBoxColumn.Visible = false;
            this.кодтовараDataGridViewTextBoxColumn.Width = 125;
            // 
            // артикултовараDataGridViewTextBoxColumn
            // 
            this.артикултовараDataGridViewTextBoxColumn.DataPropertyName = "Артикул_товара";
            this.артикултовараDataGridViewTextBoxColumn.HeaderText = "Артикул_товара";
            this.артикултовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.артикултовараDataGridViewTextBoxColumn.Name = "артикултовараDataGridViewTextBoxColumn";
            this.артикултовараDataGridViewTextBoxColumn.ReadOnly = true;
            this.артикултовараDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиетовараDataGridViewTextBoxColumn
            // 
            this.наименованиетовараDataGridViewTextBoxColumn.DataPropertyName = "Наименование_товара";
            this.наименованиетовараDataGridViewTextBoxColumn.HeaderText = "Наименование_товара";
            this.наименованиетовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиетовараDataGridViewTextBoxColumn.Name = "наименованиетовараDataGridViewTextBoxColumn";
            this.наименованиетовараDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиетовараDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценатовараштDataGridViewTextBoxColumn
            // 
            this.ценатовараштDataGridViewTextBoxColumn.DataPropertyName = "Цена_товара_шт";
            this.ценатовараштDataGridViewTextBoxColumn.HeaderText = "Цена_товара_шт";
            this.ценатовараштDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценатовараштDataGridViewTextBoxColumn.Name = "ценатовараштDataGridViewTextBoxColumn";
            this.ценатовараштDataGridViewTextBoxColumn.ReadOnly = true;
            this.ценатовараштDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 408);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLine);
            this.Controls.Add(this.ЦенаTB);
            this.Controls.Add(this.АртикулTB);
            this.Controls.Add(this.TableТовары);
            this.Controls.Add(this.НаименованиеTB);
            this.Controls.Add(this.NavigatorТовары);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.товарыViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оптоваяТорговляDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableТовары)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigatorТовары)).EndInit();
            this.NavigatorТовары.ResumeLayout(false);
            this.NavigatorТовары.PerformLayout();
            this.StatusLine.ResumeLayout(false);
            this.StatusLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ЦенаTB;
        public System.Windows.Forms.TextBox АртикулTB;
        private System.Windows.Forms.DataGridView TableТовары;
        private System.Windows.Forms.ToolStripButton FilterCancel;
        private System.Windows.Forms.ToolStripButton FilterAccept;
        private System.Windows.Forms.ToolStripTextBox ValueTB;
        private System.Windows.Forms.ToolStripComboBox FieldCB;
        public System.Windows.Forms.TextBox НаименованиеTB;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator NavigatorТовары;
        private System.Windows.Forms.StatusStrip StatusLine;
        private ОптоваяТорговляDataSet оптоваяТорговляDataSet;
        private System.Windows.Forms.BindingSource товарыViewBindingSource;
        private ОптоваяТорговляDataSetTableAdapters.Товары_ViewTableAdapter товары_ViewTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ToolStripStatusLabel Result1;
        public System.Windows.Forms.ToolStripButton ButtonUpdate1;
        public System.Windows.Forms.ToolStripButton ButtonDelete1;
        public System.Windows.Forms.ToolStripButton ButtonAdd1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Next;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикултовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиетовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценатовараштDataGridViewTextBoxColumn;
    }
}

