namespace Mikromax
{
    partial class FaturaEvrak
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
            this.btnCariList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridStok = new System.Windows.Forms.DataGridView();
            this.lblEvrakNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCKod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvakList = new System.Windows.Forms.Button();
            this.listEvrak = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnCKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCUnvan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mikroDataSet = new Mikromax.mikroDataSet();
            this.mikroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStokList = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnStokKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStokIsim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikroDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCariList
            // 
            this.btnCariList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCariList.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCariList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCariList.Location = new System.Drawing.Point(12, 24);
            this.btnCariList.Name = "btnCariList";
            this.btnCariList.Size = new System.Drawing.Size(215, 56);
            this.btnCariList.TabIndex = 0;
            this.btnCariList.Text = "Cari Listesi";
            this.btnCariList.UseVisualStyleBackColor = false;
            this.btnCariList.Click += new System.EventHandler(this.btnCariList_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridStok);
            this.panel1.Controls.Add(this.lblEvrakNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCKod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(581, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 561);
            this.panel1.TabIndex = 2;
            // 
            // GridStok
            // 
            this.GridStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStok.Location = new System.Drawing.Point(45, 114);
            this.GridStok.Name = "GridStok";
            this.GridStok.RowTemplate.Height = 24;
            this.GridStok.Size = new System.Drawing.Size(613, 326);
            this.GridStok.TabIndex = 4;
            // 
            // lblEvrakNo
            // 
            this.lblEvrakNo.AutoSize = true;
            this.lblEvrakNo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEvrakNo.Location = new System.Drawing.Point(536, 7);
            this.lblEvrakNo.Name = "lblEvrakNo";
            this.lblEvrakNo.Size = new System.Drawing.Size(0, 24);
            this.lblEvrakNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(429, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Evrak No:";
            // 
            // lblCKod
            // 
            this.lblCKod.AutoSize = true;
            this.lblCKod.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCKod.Location = new System.Drawing.Point(202, 7);
            this.lblCKod.Name = "lblCKod";
            this.lblCKod.Size = new System.Drawing.Size(0, 24);
            this.lblCKod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(109, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Kod:";
            // 
            // btnEvakList
            // 
            this.btnEvakList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEvakList.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEvakList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEvakList.Location = new System.Drawing.Point(299, 24);
            this.btnEvakList.Name = "btnEvakList";
            this.btnEvakList.Size = new System.Drawing.Size(202, 56);
            this.btnEvakList.TabIndex = 3;
            this.btnEvakList.Text = "Evrak Listesi";
            this.btnEvakList.UseVisualStyleBackColor = false;
            // 
            // listEvrak
            // 
            this.listEvrak.FormattingEnabled = true;
            this.listEvrak.ItemHeight = 16;
            this.listEvrak.Location = new System.Drawing.Point(299, 86);
            this.listEvrak.Name = "listEvrak";
            this.listEvrak.Size = new System.Drawing.Size(202, 100);
            this.listEvrak.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCKod,
            this.columnCUnvan});
            this.listView1.Location = new System.Drawing.Point(12, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(215, 161);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnCKod
            // 
            this.columnCKod.Text = "Cari Kodu";
            this.columnCKod.Width = 73;
            // 
            // columnCUnvan
            // 
            this.columnCUnvan.Text = "Cari Unvan";
            this.columnCUnvan.Width = 270;
            // 
            // mikroDataSet
            // 
            this.mikroDataSet.DataSetName = "mikroDataSet";
            this.mikroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mikroDataSetBindingSource
            // 
            this.mikroDataSetBindingSource.DataSource = this.mikroDataSet;
            this.mikroDataSetBindingSource.Position = 0;
            // 
            // btnStokList
            // 
            this.btnStokList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStokList.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnStokList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStokList.Location = new System.Drawing.Point(12, 253);
            this.btnStokList.Name = "btnStokList";
            this.btnStokList.Size = new System.Drawing.Size(215, 56);
            this.btnStokList.TabIndex = 6;
            this.btnStokList.Text = "Stok Listesi";
            this.btnStokList.UseVisualStyleBackColor = false;
            this.btnStokList.Click += new System.EventHandler(this.btnStokList_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(299, 331);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(92, 44);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(299, 381);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 43);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnStokKod,
            this.columnStokIsim});
            this.listView2.Location = new System.Drawing.Point(12, 331);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(215, 204);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnStokKod
            // 
            this.columnStokKod.Text = "Stok Kod";
            this.columnStokKod.Width = 73;
            // 
            // columnStokIsim
            // 
            this.columnStokIsim.Text = "Stok İsmi";
            this.columnStokIsim.Width = 270;
            // 
            // FaturaEvrak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1284, 727);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnStokList);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listEvrak);
            this.Controls.Add(this.btnEvakList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCariList);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FaturaEvrak";
            this.Text = "FaturaEvrak";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikroDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCariList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEvakList;
        private System.Windows.Forms.ListBox listEvrak;
        private System.Windows.Forms.Label lblEvrakNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnCKod;
        private System.Windows.Forms.ColumnHeader columnCUnvan;
        private mikroDataSet mikroDataSet;
        private System.Windows.Forms.BindingSource mikroDataSetBindingSource;
        private System.Windows.Forms.Button btnStokList;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView GridStok;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnStokKod;
        private System.Windows.Forms.ColumnHeader columnStokIsim;
    }
}