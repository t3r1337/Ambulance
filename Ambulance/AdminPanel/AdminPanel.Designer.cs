namespace Ambulance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OperatorsBtn = new System.Windows.Forms.Button();
            this.DoctorsBtn = new System.Windows.Forms.Button();
            this.ParamedicBtn = new System.Windows.Forms.Button();
            this.OrderliesBtn = new System.Windows.Forms.Button();
            this.BrigadesBtn = new System.Windows.Forms.Button();
            this.TransportsBtn = new System.Windows.Forms.Button();
            this.ReportesBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperatorsBtn
            // 
            this.OperatorsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OperatorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OperatorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperatorsBtn.Location = new System.Drawing.Point(478, 251);
            this.OperatorsBtn.Name = "OperatorsBtn";
            this.OperatorsBtn.Size = new System.Drawing.Size(150, 70);
            this.OperatorsBtn.TabIndex = 0;
            this.OperatorsBtn.Text = "Учетные записи операторов";
            this.OperatorsBtn.UseVisualStyleBackColor = false;
            this.OperatorsBtn.Click += new System.EventHandler(this.OperatorsBtn_Click);
            // 
            // DoctorsBtn
            // 
            this.DoctorsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DoctorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorsBtn.Location = new System.Drawing.Point(21, 129);
            this.DoctorsBtn.Name = "DoctorsBtn";
            this.DoctorsBtn.Size = new System.Drawing.Size(150, 70);
            this.DoctorsBtn.TabIndex = 3;
            this.DoctorsBtn.Text = "Доктора";
            this.DoctorsBtn.UseVisualStyleBackColor = false;
            this.DoctorsBtn.Click += new System.EventHandler(this.DoctorsBtn_Click);
            // 
            // ParamedicBtn
            // 
            this.ParamedicBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ParamedicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParamedicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParamedicBtn.Location = new System.Drawing.Point(245, 129);
            this.ParamedicBtn.Name = "ParamedicBtn";
            this.ParamedicBtn.Size = new System.Drawing.Size(150, 70);
            this.ParamedicBtn.TabIndex = 4;
            this.ParamedicBtn.Text = "Фельдшеры";
            this.ParamedicBtn.UseVisualStyleBackColor = false;
            this.ParamedicBtn.Click += new System.EventHandler(this.ParamedicBtn_Click);
            // 
            // OrderliesBtn
            // 
            this.OrderliesBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OrderliesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderliesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderliesBtn.Location = new System.Drawing.Point(478, 129);
            this.OrderliesBtn.Name = "OrderliesBtn";
            this.OrderliesBtn.Size = new System.Drawing.Size(150, 70);
            this.OrderliesBtn.TabIndex = 5;
            this.OrderliesBtn.Text = "Санитары";
            this.OrderliesBtn.UseVisualStyleBackColor = false;
            this.OrderliesBtn.Click += new System.EventHandler(this.OrderliesBtn_Click);
            // 
            // BrigadesBtn
            // 
            this.BrigadesBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BrigadesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrigadesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrigadesBtn.Location = new System.Drawing.Point(21, 251);
            this.BrigadesBtn.Name = "BrigadesBtn";
            this.BrigadesBtn.Size = new System.Drawing.Size(150, 70);
            this.BrigadesBtn.TabIndex = 6;
            this.BrigadesBtn.Text = "Бригады";
            this.BrigadesBtn.UseVisualStyleBackColor = false;
            this.BrigadesBtn.Click += new System.EventHandler(this.BrigadesBtn_Click);
            // 
            // TransportsBtn
            // 
            this.TransportsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TransportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportsBtn.Location = new System.Drawing.Point(245, 251);
            this.TransportsBtn.Name = "TransportsBtn";
            this.TransportsBtn.Size = new System.Drawing.Size(150, 70);
            this.TransportsBtn.TabIndex = 7;
            this.TransportsBtn.Text = "Транспорт";
            this.TransportsBtn.UseVisualStyleBackColor = false;
            this.TransportsBtn.Click += new System.EventHandler(this.TransportsBtn_Click);
            // 
            // ReportesBtn
            // 
            this.ReportesBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReportesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportesBtn.Location = new System.Drawing.Point(245, 391);
            this.ReportesBtn.Name = "ReportesBtn";
            this.ReportesBtn.Size = new System.Drawing.Size(150, 70);
            this.ReportesBtn.TabIndex = 9;
            this.ReportesBtn.Text = "Вызовы и отчеты";
            this.ReportesBtn.UseVisualStyleBackColor = false;
            this.ReportesBtn.Click += new System.EventHandler(this.ReportesBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 39);
            this.panel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(209, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Панель администратора";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ReportesBtn);
            this.Controls.Add(this.TransportsBtn);
            this.Controls.Add(this.BrigadesBtn);
            this.Controls.Add(this.OrderliesBtn);
            this.Controls.Add(this.ParamedicBtn);
            this.Controls.Add(this.DoctorsBtn);
            this.Controls.Add(this.OperatorsBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Панель администратора";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OperatorsBtn;
        private System.Windows.Forms.Button DoctorsBtn;
        private System.Windows.Forms.Button ParamedicBtn;
        private System.Windows.Forms.Button OrderliesBtn;
        private System.Windows.Forms.Button BrigadesBtn;
        private System.Windows.Forms.Button TransportsBtn;
        private System.Windows.Forms.Button ReportesBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

