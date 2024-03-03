namespace TESTREALISE.Формы
{
    partial class Журнал_регистраций
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Код_клиента = new System.Windows.Forms.MaskedTextBox();
            this.Место = new System.Windows.Forms.MaskedTextBox();
            this.Дата_выезда = new System.Windows.Forms.MaskedTextBox();
            this.Дата_въезда = new System.Windows.Forms.MaskedTextBox();
            this.Показать_все_записи = new System.Windows.Forms.Button();
            this.Удалить_всё = new System.Windows.Forms.Button();
            this.Удалить = new System.Windows.Forms.Button();
            this.Добавить = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Значения = new System.Windows.Forms.TextBox();
            this.Критерии = new System.Windows.Forms.ComboBox();
            this.Поиск = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Редактирование_регистрации = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Код_клиентар = new System.Windows.Forms.MaskedTextBox();
            this.Местор = new System.Windows.Forms.MaskedTextBox();
            this.Дата_выездар = new System.Windows.Forms.MaskedTextBox();
            this.Дата_въездар = new System.Windows.Forms.MaskedTextBox();
            this.toolTip12 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip11 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip10 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Регистрации = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Регистрации)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Код клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Место";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Дата выезда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Дата въезда";
            // 
            // Код_клиента
            // 
            this.Код_клиента.Location = new System.Drawing.Point(6, 129);
            this.Код_клиента.Name = "Код_клиента";
            this.Код_клиента.Size = new System.Drawing.Size(125, 25);
            this.Код_клиента.TabIndex = 33;
            // 
            // Место
            // 
            this.Место.Location = new System.Drawing.Point(6, 98);
            this.Место.Name = "Место";
            this.Место.Size = new System.Drawing.Size(125, 25);
            this.Место.TabIndex = 32;
            // 
            // Дата_выезда
            // 
            this.Дата_выезда.Location = new System.Drawing.Point(6, 67);
            this.Дата_выезда.Mask = "0000/00/00 90:00";
            this.Дата_выезда.Name = "Дата_выезда";
            this.Дата_выезда.Size = new System.Drawing.Size(125, 25);
            this.Дата_выезда.TabIndex = 31;
            this.Дата_выезда.ValidatingType = typeof(System.DateTime);
            this.Дата_выезда.Click += new System.EventHandler(this.Дата_выезда_Click);
            // 
            // Дата_въезда
            // 
            this.Дата_въезда.Location = new System.Drawing.Point(6, 36);
            this.Дата_въезда.Mask = "0000/00/00 90:00";
            this.Дата_въезда.Name = "Дата_въезда";
            this.Дата_въезда.Size = new System.Drawing.Size(125, 25);
            this.Дата_въезда.TabIndex = 30;
            this.Дата_въезда.ValidatingType = typeof(System.DateTime);
            this.Дата_въезда.Click += new System.EventHandler(this.Дата_въезда_Click);
            // 
            // Показать_все_записи
            // 
            this.Показать_все_записи.AutoSize = true;
            this.Показать_все_записи.FlatAppearance.BorderSize = 2;
            this.Показать_все_записи.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Показать_все_записи.Location = new System.Drawing.Point(251, 62);
            this.Показать_все_записи.Name = "Показать_все_записи";
            this.Показать_все_записи.Size = new System.Drawing.Size(204, 31);
            this.Показать_все_записи.TabIndex = 25;
            this.Показать_все_записи.Text = "Показать все записи";
            this.Показать_все_записи.UseVisualStyleBackColor = true;
            this.Показать_все_записи.Click += new System.EventHandler(this.Показать_все_записи_Click);
            // 
            // Удалить_всё
            // 
            this.Удалить_всё.AutoSize = true;
            this.Удалить_всё.FlatAppearance.BorderSize = 2;
            this.Удалить_всё.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Удалить_всё.Location = new System.Drawing.Point(359, 99);
            this.Удалить_всё.Name = "Удалить_всё";
            this.Удалить_всё.Size = new System.Drawing.Size(96, 31);
            this.Удалить_всё.TabIndex = 4;
            this.Удалить_всё.Text = "Удалить всё";
            this.Удалить_всё.UseVisualStyleBackColor = true;
            this.Удалить_всё.Click += new System.EventHandler(this.Удалить_всё_Click);
            // 
            // Удалить
            // 
            this.Удалить.AutoSize = true;
            this.Удалить.FlatAppearance.BorderSize = 2;
            this.Удалить.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Удалить.Location = new System.Drawing.Point(353, 136);
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(102, 31);
            this.Удалить.TabIndex = 3;
            this.Удалить.Text = "Удалить";
            this.Удалить.UseVisualStyleBackColor = true;
            this.Удалить.Click += new System.EventHandler(this.Удалить_Click);
            // 
            // Добавить
            // 
            this.Добавить.AutoSize = true;
            this.Добавить.FlatAppearance.BorderSize = 2;
            this.Добавить.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Добавить.Location = new System.Drawing.Point(373, 25);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(82, 31);
            this.Добавить.TabIndex = 1;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = true;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Код_клиента);
            this.groupBox1.Controls.Add(this.Место);
            this.groupBox1.Controls.Add(this.Дата_выезда);
            this.groupBox1.Controls.Add(this.Дата_въезда);
            this.groupBox1.Controls.Add(this.Показать_все_записи);
            this.groupBox1.Controls.Add(this.Удалить_всё);
            this.groupBox1.Controls.Add(this.Удалить);
            this.groupBox1.Controls.Add(this.Добавить);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 178);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление и Редактирование";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 193);
            this.panel1.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Значения);
            this.groupBox2.Controls.Add(this.Критерии);
            this.groupBox2.Controls.Add(this.Поиск);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(479, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 76);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // Значения
            // 
            this.Значения.Location = new System.Drawing.Point(6, 43);
            this.Значения.Name = "Значения";
            this.Значения.Size = new System.Drawing.Size(181, 25);
            this.Значения.TabIndex = 2;
            // 
            // Критерии
            // 
            this.Критерии.FormattingEnabled = true;
            this.Критерии.Items.AddRange(new object[] {
            "Дата_въезда",
            "Дата_выезда",
            "Место",
            "Код_клиента"});
            this.Критерии.Location = new System.Drawing.Point(6, 16);
            this.Критерии.Name = "Критерии";
            this.Критерии.Size = new System.Drawing.Size(181, 25);
            this.Критерии.TabIndex = 1;
            // 
            // Поиск
            // 
            this.Поиск.FlatAppearance.BorderSize = 2;
            this.Поиск.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Поиск.Location = new System.Drawing.Point(193, 16);
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(105, 47);
            this.Поиск.TabIndex = 0;
            this.Поиск.Text = "Поиск";
            this.Поиск.UseVisualStyleBackColor = true;
            this.Поиск.Click += new System.EventHandler(this.Поиск_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.Редактирование_регистрации);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Код_клиентар);
            this.groupBox3.Controls.Add(this.Местор);
            this.groupBox3.Controls.Add(this.Дата_выездар);
            this.groupBox3.Controls.Add(this.Дата_въездар);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(479, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(619, 96);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редактирование";
            // 
            // Редактирование_регистрации
            // 
            this.Редактирование_регистрации.AutoSize = true;
            this.Редактирование_регистрации.BackColor = System.Drawing.Color.Transparent;
            this.Редактирование_регистрации.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Редактирование_регистрации.FlatAppearance.BorderSize = 2;
            this.Редактирование_регистрации.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Редактирование_регистрации.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Редактирование_регистрации.Location = new System.Drawing.Point(6, 53);
            this.Редактирование_регистрации.Name = "Редактирование_регистрации";
            this.Редактирование_регистрации.Size = new System.Drawing.Size(593, 34);
            this.Редактирование_регистрации.TabIndex = 49;
            this.Редактирование_регистрации.Text = "Редактирование";
            this.Редактирование_регистрации.UseVisualStyleBackColor = false;
            this.Редактирование_регистрации.Click += new System.EventHandler(this.Редактирование_регистрации_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(524, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Код клиента";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(100, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Дата въезда";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(282, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "Дата выезда";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(419, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 44;
            this.label10.Text = "Место";
            // 
            // Код_клиентар
            // 
            this.Код_клиентар.Location = new System.Drawing.Point(467, 21);
            this.Код_клиентар.Name = "Код_клиентар";
            this.Код_клиентар.Size = new System.Drawing.Size(51, 25);
            this.Код_клиентар.TabIndex = 43;
            // 
            // Местор
            // 
            this.Местор.Location = new System.Drawing.Point(365, 21);
            this.Местор.Name = "Местор";
            this.Местор.Size = new System.Drawing.Size(48, 25);
            this.Местор.TabIndex = 41;
            // 
            // Дата_выездар
            // 
            this.Дата_выездар.Location = new System.Drawing.Point(181, 22);
            this.Дата_выездар.Mask = "00/00/0000 90:00";
            this.Дата_выездар.Name = "Дата_выездар";
            this.Дата_выездар.Size = new System.Drawing.Size(95, 25);
            this.Дата_выездар.TabIndex = 40;
            this.Дата_выездар.ValidatingType = typeof(System.DateTime);
            // 
            // Дата_въездар
            // 
            this.Дата_въездар.Location = new System.Drawing.Point(8, 21);
            this.Дата_въездар.Mask = "00/00/0000 90:00";
            this.Дата_въездар.Name = "Дата_въездар";
            this.Дата_въездар.Size = new System.Drawing.Size(86, 25);
            this.Дата_въездар.TabIndex = 39;
            this.Дата_въездар.ValidatingType = typeof(System.DateTime);
            // 
            // Регистрации
            // 
            this.Регистрации.AllowUserToAddRows = false;
            this.Регистрации.AllowUserToDeleteRows = false;
            this.Регистрации.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Регистрации.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.Регистрации.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Регистрации.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Регистрации.Location = new System.Drawing.Point(0, 0);
            this.Регистрации.Name = "Регистрации";
            this.Регистрации.ReadOnly = true;
            this.Регистрации.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Регистрации.Size = new System.Drawing.Size(1110, 535);
            this.Регистрации.TabIndex = 22;
            this.Регистрации.SelectionChanged += new System.EventHandler(this.Регистрации_SelectionChanged);
            // 
            // Журнал_регистраций
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Регистрации);
            this.Name = "Журнал_регистраций";
            this.Text = "Журнал_регистраций";
            this.Load += new System.EventHandler(this.Журнал_регистраций_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Журнал_регистраций_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Регистрации)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox Код_клиента;
        public System.Windows.Forms.MaskedTextBox Место;
        public System.Windows.Forms.MaskedTextBox Дата_выезда;
        public System.Windows.Forms.MaskedTextBox Дата_въезда;
        private System.Windows.Forms.Button Показать_все_записи;
        private System.Windows.Forms.Button Удалить_всё;
        private System.Windows.Forms.Button Удалить;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip12;
        private System.Windows.Forms.ToolTip toolTip11;
        private System.Windows.Forms.ToolTip toolTip10;
        private System.Windows.Forms.ToolTip toolTip9;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DataGridView Регистрации;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Редактирование_регистрации;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox Код_клиентар;
        public System.Windows.Forms.MaskedTextBox Местор;
        public System.Windows.Forms.MaskedTextBox Дата_выездар;
        public System.Windows.Forms.MaskedTextBox Дата_въездар;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox Значения;
        public System.Windows.Forms.ComboBox Критерии;
        private System.Windows.Forms.Button Поиск;
    }
}