namespace Ambulance.AdminPanel
{
    partial class Paramedic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paramedic));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчесвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramedicBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ambulanceDataSet31 = new Ambulance.ds.AmbulanceDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.paramedicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ambulanceDataSet3 = new Ambulance.ds.AmbulanceDataSet3();
            this.paramedicTableAdapter = new Ambulance.ds.AmbulanceDataSet3TableAdapters.ParamedicTableAdapter();
            this.ambulanceDataSet4 = new Ambulance.ds.AmbulanceDataSet4();
            this.paramedicBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paramedicTableAdapter1 = new Ambulance.ds.AmbulanceDataSet4TableAdapters.ParamedicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramedicBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramedicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramedicBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.отчесвтоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paramedicBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(453, 190);
            this.dataGridView1.TabIndex = 0;
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
            // отчесвтоDataGridViewTextBoxColumn
            // 
            this.отчесвтоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчесвтоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчесвтоDataGridViewTextBoxColumn.Name = "отчесвтоDataGridViewTextBoxColumn";
            this.отчесвтоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paramedicBindingSource2
            // 
            this.paramedicBindingSource2.DataMember = "Paramedic";
            this.paramedicBindingSource2.DataSource = this.ambulanceDataSet31;
            // 
            // ambulanceDataSet31
            // 
            this.ambulanceDataSet31.DataSetName = "AmbulanceDataSet3";
            this.ambulanceDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.Location = new System.Drawing.Point(184, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button3.Location = new System.Drawing.Point(371, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button4.Location = new System.Drawing.Point(371, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "Обновить таблицу";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // paramedicBindingSource
            // 
            this.paramedicBindingSource.DataMember = "Paramedic";
            this.paramedicBindingSource.DataSource = this.ambulanceDataSet3;
            // 
            // ambulanceDataSet3
            // 
            this.ambulanceDataSet3.DataSetName = "AmbulanceDataSet3";
            this.ambulanceDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paramedicTableAdapter
            // 
            this.paramedicTableAdapter.ClearBeforeFill = true;
            // 
            // ambulanceDataSet4
            // 
            this.ambulanceDataSet4.DataSetName = "AmbulanceDataSet4";
            this.ambulanceDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paramedicBindingSource1
            // 
            this.paramedicBindingSource1.DataMember = "Paramedic";
            this.paramedicBindingSource1.DataSource = this.ambulanceDataSet4;
            // 
            // paramedicTableAdapter1
            // 
            this.paramedicTableAdapter1.ClearBeforeFill = true;
            // 
            // Paramedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 330);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paramedic";
            this.Text = "Фельдшеры";
            this.Load += new System.EventHandler(this.Paramedic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramedicBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramedicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramedicBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ds.AmbulanceDataSet3 ambulanceDataSet3;
        private System.Windows.Forms.BindingSource paramedicBindingSource;
        private ds.AmbulanceDataSet3TableAdapters.ParamedicTableAdapter paramedicTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private ds.AmbulanceDataSet4 ambulanceDataSet4;
        private System.Windows.Forms.BindingSource paramedicBindingSource1;
        private ds.AmbulanceDataSet4TableAdapters.ParamedicTableAdapter paramedicTableAdapter1;
        private ds.AmbulanceDataSet3 ambulanceDataSet31;
        private System.Windows.Forms.BindingSource paramedicBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчесвтоDataGridViewTextBoxColumn;
    }
}