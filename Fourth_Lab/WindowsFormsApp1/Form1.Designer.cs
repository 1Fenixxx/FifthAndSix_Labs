namespace WindowsFormsApp1
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
            this.B_Export = new System.Windows.Forms.Button();
            this.B_ClearList = new System.Windows.Forms.Button();
            this.B_NewObject = new System.Windows.Forms.Button();
            this.DGV_Data = new System.Windows.Forms.DataGridView();
            this.B_DeleteObject = new System.Windows.Forms.Button();
            this.B_Edit = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IndexColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotherboardTypeColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPUColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrivesColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PowerSupplyColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Export
            // 
            this.B_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Export.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Export.ForeColor = System.Drawing.Color.ForestGreen;
            this.B_Export.Location = new System.Drawing.Point(13, 388);
            this.B_Export.Name = "B_Export";
            this.B_Export.Size = new System.Drawing.Size(109, 44);
            this.B_Export.TabIndex = 3;
            this.B_Export.Text = "Export";
            this.B_Export.UseVisualStyleBackColor = true;
            this.B_Export.Click += new System.EventHandler(this.B_Export_Click);
            // 
            // B_ClearList
            // 
            this.B_ClearList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_ClearList.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_ClearList.ForeColor = System.Drawing.Color.Red;
            this.B_ClearList.Location = new System.Drawing.Point(13, 12);
            this.B_ClearList.Name = "B_ClearList";
            this.B_ClearList.Size = new System.Drawing.Size(109, 44);
            this.B_ClearList.TabIndex = 6;
            this.B_ClearList.Text = "Clear List";
            this.B_ClearList.UseVisualStyleBackColor = true;
            this.B_ClearList.Click += new System.EventHandler(this.B_ClearList_Click);
            // 
            // B_NewObject
            // 
            this.B_NewObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_NewObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_NewObject.ForeColor = System.Drawing.Color.Green;
            this.B_NewObject.Location = new System.Drawing.Point(13, 235);
            this.B_NewObject.Name = "B_NewObject";
            this.B_NewObject.Size = new System.Drawing.Size(109, 56);
            this.B_NewObject.TabIndex = 7;
            this.B_NewObject.Text = "New Object";
            this.B_NewObject.UseVisualStyleBackColor = true;
            this.B_NewObject.Click += new System.EventHandler(this.B_NewObject_Click);
            // 
            // DGV_Data
            // 
            this.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexColum,
            this.TotalPriceColum,
            this.MotherboardTypeColum,
            this.CPUColum,
            this.GPUColum,
            this.DrivesColum,
            this.PowerSupplyColum});
            this.DGV_Data.Location = new System.Drawing.Point(128, 12);
            this.DGV_Data.Name = "DGV_Data";
            this.DGV_Data.Size = new System.Drawing.Size(1167, 420);
            this.DGV_Data.TabIndex = 8;
            // 
            // B_DeleteObject
            // 
            this.B_DeleteObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_DeleteObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_DeleteObject.ForeColor = System.Drawing.Color.Red;
            this.B_DeleteObject.Location = new System.Drawing.Point(13, 62);
            this.B_DeleteObject.Name = "B_DeleteObject";
            this.B_DeleteObject.Size = new System.Drawing.Size(109, 54);
            this.B_DeleteObject.TabIndex = 5;
            this.B_DeleteObject.Text = "Delete Object";
            this.B_DeleteObject.UseVisualStyleBackColor = true;
            this.B_DeleteObject.Click += new System.EventHandler(this.B_DeleteObject_Click);
            // 
            // B_Edit
            // 
            this.B_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Edit.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Edit.ForeColor = System.Drawing.Color.DarkOrange;
            this.B_Edit.Location = new System.Drawing.Point(13, 181);
            this.B_Edit.Name = "B_Edit";
            this.B_Edit.Size = new System.Drawing.Size(109, 38);
            this.B_Edit.TabIndex = 4;
            this.B_Edit.Text = "Edit";
            this.B_Edit.UseVisualStyleBackColor = true;
            this.B_Edit.Click += new System.EventHandler(this.B_Edit_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApp1.Form1);
            // 
            // IndexColum
            // 
            this.IndexColum.HeaderText = "Index";
            this.IndexColum.Name = "IndexColum";
            this.IndexColum.Width = 45;
            // 
            // TotalPriceColum
            // 
            this.TotalPriceColum.HeaderText = "Price";
            this.TotalPriceColum.Name = "TotalPriceColum";
            // 
            // MotherboardTypeColum
            // 
            this.MotherboardTypeColum.HeaderText = "Motherboard";
            this.MotherboardTypeColum.Name = "MotherboardTypeColum";
            this.MotherboardTypeColum.Width = 150;
            // 
            // CPUColum
            // 
            this.CPUColum.HeaderText = "CPU";
            this.CPUColum.Name = "CPUColum";
            this.CPUColum.Width = 225;
            // 
            // GPUColum
            // 
            this.GPUColum.HeaderText = "GPU";
            this.GPUColum.Name = "GPUColum";
            this.GPUColum.Width = 150;
            // 
            // DrivesColum
            // 
            this.DrivesColum.HeaderText = "Drives";
            this.DrivesColum.Name = "DrivesColum";
            this.DrivesColum.Width = 250;
            // 
            // PowerSupplyColum
            // 
            this.PowerSupplyColum.HeaderText = "Power Supply";
            this.PowerSupplyColum.Name = "PowerSupplyColum";
            this.PowerSupplyColum.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 450);
            this.Controls.Add(this.DGV_Data);
            this.Controls.Add(this.B_NewObject);
            this.Controls.Add(this.B_ClearList);
            this.Controls.Add(this.B_DeleteObject);
            this.Controls.Add(this.B_Edit);
            this.Controls.Add(this.B_Export);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button B_Export;
        private System.Windows.Forms.Button B_ClearList;
        private System.Windows.Forms.Button B_NewObject;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView DGV_Data;
        private System.Windows.Forms.Button B_DeleteObject;
        private System.Windows.Forms.Button B_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherboardTypeColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPUColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrivesColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowerSupplyColum;
    }
}

