namespace TESTREALISE.Формы
{
    partial class Парковочные_места
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Удалить_все_записи = new System.Windows.Forms.Button();
            this.Удалить_место = new System.Windows.Forms.Button();
            this.Добавить_место = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Название_места = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Показать_все_записи = new System.Windows.Forms.Button();
            this.Значения = new System.Windows.Forms.TextBox();
            this.Критерии = new System.Windows.Forms.ComboBox();
            this.Поиск = new System.Windows.Forms.Button();
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.Места = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Места)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 117);
            this.panel1.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Удалить_все_записи);
            this.groupBox1.Controls.Add(this.Удалить_место);
            this.groupBox1.Controls.Add(this.Добавить_место);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Название_места);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 94);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление и удаление места";
            // 
            // Удалить_все_записи
            // 
            this.Удалить_все_записи.AutoSize = true;
            this.Удалить_все_записи.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Удалить_все_записи.FlatAppearance.BorderSize = 2;
            this.Удалить_все_записи.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Удалить_все_записи.Location = new System.Drawing.Point(8, 54);
            this.Удалить_все_записи.Name = "Удалить_все_записи";
            this.Удалить_все_записи.Size = new System.Drawing.Size(203, 31);
            this.Удалить_все_записи.TabIndex = 30;
            this.Удалить_все_записи.Text = "Удалить все записи";
            this.Удалить_все_записи.UseVisualStyleBackColor = true;
            this.Удалить_все_записи.Click += new System.EventHandler(this.Удалить_все_записи_Click);
            // 
            // Удалить_место
            // 
            this.Удалить_место.AutoSize = true;
            this.Удалить_место.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Удалить_место.FlatAppearance.BorderSize = 2;
            this.Удалить_место.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Удалить_место.Location = new System.Drawing.Point(217, 54);
            this.Удалить_место.Name = "Удалить_место";
            this.Удалить_место.Size = new System.Drawing.Size(192, 31);
            this.Удалить_место.TabIndex = 29;
            this.Удалить_место.Text = "Удалить выбранное  место";
            this.Удалить_место.UseVisualStyleBackColor = true;
            this.Удалить_место.Click += new System.EventHandler(this.Удалить_место_Click);
            // 
            // Добавить_место
            // 
            this.Добавить_место.AutoSize = true;
            this.Добавить_место.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Добавить_место.FlatAppearance.BorderSize = 2;
            this.Добавить_место.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Добавить_место.Location = new System.Drawing.Point(286, 17);
            this.Добавить_место.Name = "Добавить_место";
            this.Добавить_место.Size = new System.Drawing.Size(123, 31);
            this.Добавить_место.TabIndex = 28;
            this.Добавить_место.Text = "Добавить место";
            this.Добавить_место.UseVisualStyleBackColor = true;
            this.Добавить_место.Click += new System.EventHandler(this.Добавить_место_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Название места";
            // 
            // Название_места
            // 
            this.Название_места.Location = new System.Drawing.Point(8, 24);
            this.Название_места.Name = "Название_места";
            this.Название_места.Size = new System.Drawing.Size(137, 25);
            this.Название_места.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Показать_все_записи);
            this.groupBox2.Controls.Add(this.Значения);
            this.groupBox2.Controls.Add(this.Критерии);
            this.groupBox2.Controls.Add(this.Поиск);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(437, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 77);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // Показать_все_записи
            // 
            this.Показать_все_записи.AutoSize = true;
            this.Показать_все_записи.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Показать_все_записи.FlatAppearance.BorderSize = 2;
            this.Показать_все_записи.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Показать_все_записи.Location = new System.Drawing.Point(266, 19);
            this.Показать_все_записи.Name = "Показать_все_записи";
            this.Показать_все_записи.Size = new System.Drawing.Size(151, 47);
            this.Показать_все_записи.TabIndex = 31;
            this.Показать_все_записи.Text = "Показать все записи";
            this.Показать_все_записи.UseVisualStyleBackColor = true;
            this.Показать_все_записи.Click += new System.EventHandler(this.Показать_все_записи_Click);
            // 
            // Значения
            // 
            this.Значения.Location = new System.Drawing.Point(8, 46);
            this.Значения.Name = "Значения";
            this.Значения.Size = new System.Drawing.Size(160, 25);
            this.Значения.TabIndex = 19;
            // 
            // Критерии
            // 
            this.Критерии.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Критерии.FormattingEnabled = true;
            this.Критерии.Items.AddRange(new object[] {
            "Место",
            "Статус",
            "Дата_въезда",
            "Госномер"});
            this.Критерии.Location = new System.Drawing.Point(8, 19);
            this.Критерии.Name = "Критерии";
            this.Критерии.Size = new System.Drawing.Size(160, 25);
            this.Критерии.TabIndex = 18;
            // 
            // Поиск
            // 
            this.Поиск.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Поиск.FlatAppearance.BorderSize = 2;
            this.Поиск.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Поиск.Location = new System.Drawing.Point(174, 19);
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(86, 47);
            this.Поиск.TabIndex = 17;
            this.Поиск.Text = "Поиск";
            this.Поиск.UseVisualStyleBackColor = true;
            this.Поиск.Click += new System.EventHandler(this.Поиск_Click);
            // 
            // Места
            // 
            this.Места.AllowUserToAddRows = false;
            this.Места.AllowUserToDeleteRows = false;
            this.Места.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Места.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.Места.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Места.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Места.Location = new System.Drawing.Point(0, 0);
            this.Места.Name = "Места";
            this.Места.ReadOnly = true;
            this.Места.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Места.Size = new System.Drawing.Size(985, 504);
            this.Места.TabIndex = 26;
            // 
            // Парковочные_места
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Места);
            this.Name = "Парковочные_места";
            this.Text = "Парковочные_места";
            this.Load += new System.EventHandler(this.Парковочные_места_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Парковочные_места_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Места)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Удалить_все_записи;
        private System.Windows.Forms.Button Удалить_место;
        private System.Windows.Forms.Button Добавить_место;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Название_места;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox Значения;
        public System.Windows.Forms.ComboBox Критерии;
        private System.Windows.Forms.Button Поиск;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip8;
        public System.Windows.Forms.DataGridView Места;
        private System.Windows.Forms.Button Показать_все_записи;
    }
}