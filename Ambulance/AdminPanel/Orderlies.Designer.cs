namespace Ambulance.AdminPanel
{
    partial class Orderlies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orderlies));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderliesDS = new Ambulance.OrderliesDS();
            this.button4 = new System.Windows.Forms.Button();
            this.ambulanceDataSet = new Ambulance.ds.AmbulanceDataSet();
            this.doctorcallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctor_callTableAdapter = new Ambulance.ds.AmbulanceDataSetTableAdapters.Doctor_callTableAdapter();
            this.ambulanceDataSet1 = new Ambulance.ds.AmbulanceDataSet1();
            this.brigadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brigadesTableAdapter = new Ambulance.ds.AmbulanceDataSet1TableAdapters.BrigadesTableAdapter();
            this.ambulanceDataSet2 = new Ambulance.ds.AmbulanceDataSet2();
            this.transportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportsTableAdapter = new Ambulance.ds.AmbulanceDataSet2TableAdapters.TransportsTableAdapter();
            this.orderliesTableAdapter = new Ambulance.OrderliesDSTableAdapters.OrderliesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderliesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorcallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Location = new System.Drawing.Point(12, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.Location = new System.Drawing.Point(189, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button3.Location = new System.Drawing.Point(371, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderliesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(453, 190);
            this.dataGridView1.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderliesBindingSource
            // 
            this.orderliesBindingSource.DataMember = "Orderlies";
            this.orderliesBindingSource.DataSource = this.orderliesDS;
            // 
            // orderliesDS
            // 
            this.orderliesDS.DataSetName = "OrderliesDS";
            this.orderliesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button4.Location = new System.Drawing.Point(371, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "Обновить таблицу";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ambulanceDataSet
            // 
            this.ambulanceDataSet.DataSetName = "AmbulanceDataSet";
            this.ambulanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorcallBindingSource
            // 
            this.doctorcallBindingSource.DataMember = "Doctor_call";
            this.doctorcallBindingSource.DataSource = this.ambulanceDataSet;
            // 
            // doctor_callTableAdapter
            // 
            this.doctor_callTableAdapter.ClearBeforeFill = true;
            // 
            // ambulanceDataSet1
            // 
            this.ambulanceDataSet1.DataSetName = "AmbulanceDataSet1";
            this.ambulanceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brigadesBindingSource
            // 
            this.brigadesBindingSource.DataMember = "Brigades";
            this.brigadesBindingSource.DataSource = this.ambulanceDataSet1;
            // 
            // brigadesTableAdapter
            // 
            this.brigadesTableAdapter.ClearBeforeFill = true;
            // 
            // ambulanceDataSet2
            // 
            this.ambulanceDataSet2.DataSetName = "AmbulanceDataSet2";
            this.ambulanceDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportsBindingSource
            // 
            this.transportsBindingSource.DataMember = "Transports";
            this.transportsBindingSource.DataSource = this.ambulanceDataSet2;
            // 
            // transportsTableAdapter
            // 
            this.transportsTableAdapter.ClearBeforeFill = true;
            // 
            // orderliesTableAdapter
            // 
            this.orderliesTableAdapter.ClearBeforeFill = true;
            // 
            // Orderlies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 336);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orderlies";
            this.Text = "Санитары";
            this.Load += new System.EventHandler(this.Orderlies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderliesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorcallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private ds.AmbulanceDataSet ambulanceDataSet;
        private System.Windows.Forms.BindingSource doctorcallBindingSource;
        private ds.AmbulanceDataSetTableAdapters.Doctor_callTableAdapter doctor_callTableAdapter;
        private ds.AmbulanceDataSet1 ambulanceDataSet1;
        private System.Windows.Forms.BindingSource brigadesBindingSource;
        private ds.AmbulanceDataSet1TableAdapters.BrigadesTableAdapter brigadesTableAdapter;
        private ds.AmbulanceDataSet2 ambulanceDataSet2;
        private System.Windows.Forms.BindingSource transportsBindingSource;
        private ds.AmbulanceDataSet2TableAdapters.TransportsTableAdapter transportsTableAdapter;
        private OrderliesDS orderliesDS;
        private System.Windows.Forms.BindingSource orderliesBindingSource;
        private OrderliesDSTableAdapters.OrderliesTableAdapter orderliesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
    }
}