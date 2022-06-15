namespace WindowsFormsApp1
{
    partial class Main
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
            this.zakData = new System.Windows.Forms.DataGridView();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakButton = new System.Windows.Forms.Button();
            this.skladButton = new System.Windows.Forms.Button();
            this.uslugiButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.dellButton = new System.Windows.Forms.Button();
            this.uslugiData = new System.Windows.Forms.DataGridView();
            this.skladData = new System.Windows.Forms.DataGridView();
            this.upDateButton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zakData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladData)).BeginInit();
            this.SuspendLayout();
            // 
            // zakData
            // 
            this.zakData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zakData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.client,
            this.parts,
            this.service,
            this.id});
            this.zakData.Location = new System.Drawing.Point(182, 12);
            this.zakData.Name = "zakData";
            this.zakData.RowHeadersWidth = 51;
            this.zakData.RowTemplate.Height = 24;
            this.zakData.Size = new System.Drawing.Size(910, 485);
            this.zakData.TabIndex = 0;
            // 
            // client
            // 
            this.client.HeaderText = "клиент";
            this.client.MinimumWidth = 6;
            this.client.Name = "client";
            this.client.Width = 230;
            // 
            // parts
            // 
            this.parts.HeaderText = "запчасти";
            this.parts.MinimumWidth = 6;
            this.parts.Name = "parts";
            this.parts.Width = 250;
            // 
            // service
            // 
            this.service.HeaderText = "услуги";
            this.service.MinimumWidth = 6;
            this.service.Name = "service";
            this.service.Width = 250;
            // 
            // zakButton
            // 
            this.zakButton.Location = new System.Drawing.Point(12, 12);
            this.zakButton.Name = "zakButton";
            this.zakButton.Size = new System.Drawing.Size(164, 37);
            this.zakButton.TabIndex = 1;
            this.zakButton.Text = "заказы";
            this.zakButton.UseVisualStyleBackColor = true;
            this.zakButton.Click += new System.EventHandler(this.zakButton_Click);
            // 
            // skladButton
            // 
            this.skladButton.Location = new System.Drawing.Point(12, 55);
            this.skladButton.Name = "skladButton";
            this.skladButton.Size = new System.Drawing.Size(164, 37);
            this.skladButton.TabIndex = 2;
            this.skladButton.Text = "склад";
            this.skladButton.UseVisualStyleBackColor = true;
            this.skladButton.Click += new System.EventHandler(this.skladButton_Click);
            // 
            // uslugiButton
            // 
            this.uslugiButton.Location = new System.Drawing.Point(12, 98);
            this.uslugiButton.Name = "uslugiButton";
            this.uslugiButton.Size = new System.Drawing.Size(164, 37);
            this.uslugiButton.TabIndex = 3;
            this.uslugiButton.Text = "услуги";
            this.uslugiButton.UseVisualStyleBackColor = true;
            this.uslugiButton.Click += new System.EventHandler(this.uslugiButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(182, 504);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(164, 37);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(352, 504);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(164, 37);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "изменить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dellButton
            // 
            this.dellButton.Location = new System.Drawing.Point(522, 504);
            this.dellButton.Name = "dellButton";
            this.dellButton.Size = new System.Drawing.Size(164, 37);
            this.dellButton.TabIndex = 6;
            this.dellButton.Text = "удалить";
            this.dellButton.UseVisualStyleBackColor = true;
            this.dellButton.Click += new System.EventHandler(this.dellButton_Click);
            // 
            // uslugiData
            // 
            this.uslugiData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uslugiData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column2});
            this.uslugiData.Location = new System.Drawing.Point(182, 13);
            this.uslugiData.Name = "uslugiData";
            this.uslugiData.RowHeadersWidth = 51;
            this.uslugiData.RowTemplate.Height = 24;
            this.uslugiData.Size = new System.Drawing.Size(910, 485);
            this.uslugiData.TabIndex = 7;
            // 
            // skladData
            // 
            this.skladData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skladData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.id1});
            this.skladData.Location = new System.Drawing.Point(182, 12);
            this.skladData.Name = "skladData";
            this.skladData.RowHeadersWidth = 51;
            this.skladData.RowTemplate.Height = 24;
            this.skladData.Size = new System.Drawing.Size(910, 485);
            this.skladData.TabIndex = 8;
            // 
            // upDateButton
            // 
            this.upDateButton.Location = new System.Drawing.Point(692, 503);
            this.upDateButton.Name = "upDateButton";
            this.upDateButton.Size = new System.Drawing.Size(164, 37);
            this.upDateButton.TabIndex = 9;
            this.upDateButton.Text = "обновить";
            this.upDateButton.UseVisualStyleBackColor = true;
            this.upDateButton.Click += new System.EventHandler(this.upDateButton_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "колличество";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "стоимость";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "название";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "название";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 230;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "стоимость";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // id1
            // 
            this.id1.HeaderText = "id";
            this.id1.MinimumWidth = 6;
            this.id1.Name = "id1";
            this.id1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 553);
            this.Controls.Add(this.upDateButton);
            this.Controls.Add(this.dellButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.uslugiButton);
            this.Controls.Add(this.skladButton);
            this.Controls.Add(this.zakButton);
            this.Controls.Add(this.uslugiData);
            this.Controls.Add(this.zakData);
            this.Controls.Add(this.skladData);
            this.Name = "Main";
            this.Text = "окно работника";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zakData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView zakData;
        private System.Windows.Forms.Button zakButton;
        private System.Windows.Forms.Button skladButton;
        private System.Windows.Forms.Button uslugiButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button dellButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn parts;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridView uslugiData;
        private System.Windows.Forms.DataGridView skladData;
        private System.Windows.Forms.Button upDateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
    }
}