namespace TESTREALISE
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.Свернуть = new FontAwesome.Sharp.IconButton();
            this.Развернуть = new FontAwesome.Sharp.IconButton();
            this.Закрыть = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.Главная_страница = new System.Windows.Forms.PictureBox();
            this.Журнал_регистраций = new FontAwesome.Sharp.IconButton();
            this.Журнал_услуг = new FontAwesome.Sharp.IconButton();
            this.Парковочные_места = new FontAwesome.Sharp.IconButton();
            this.Тарифы_и_Услуги = new FontAwesome.Sharp.IconButton();
            this.Автомобили = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Клиенты = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Report = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Главная_страница)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Приложение свёрнуто";
            this.notifyIcon1.BalloonTipTitle = "CarPark";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CarPark";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitleChildForm.Location = new System.Drawing.Point(64, 48);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(154, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Начальная страница";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.GhostWhite;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.GhostWhite;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 39;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(17, 42);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(41, 39);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // Свернуть
            // 
            this.Свернуть.Dock = System.Windows.Forms.DockStyle.Right;
            this.Свернуть.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Свернуть.IconColor = System.Drawing.Color.Black;
            this.Свернуть.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Свернуть.IconSize = 20;
            this.Свернуть.Location = new System.Drawing.Point(1118, 0);
            this.Свернуть.Name = "Свернуть";
            this.Свернуть.Size = new System.Drawing.Size(27, 27);
            this.Свернуть.TabIndex = 2;
            this.Свернуть.UseVisualStyleBackColor = true;
            this.Свернуть.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Развернуть
            // 
            this.Развернуть.Dock = System.Windows.Forms.DockStyle.Right;
            this.Развернуть.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.Развернуть.IconColor = System.Drawing.Color.Black;
            this.Развернуть.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Развернуть.IconSize = 20;
            this.Развернуть.Location = new System.Drawing.Point(1145, 0);
            this.Развернуть.Name = "Развернуть";
            this.Развернуть.Size = new System.Drawing.Size(27, 27);
            this.Развернуть.TabIndex = 1;
            this.Развернуть.UseVisualStyleBackColor = true;
            this.Развернуть.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // Закрыть
            // 
            this.Закрыть.Dock = System.Windows.Forms.DockStyle.Right;
            this.Закрыть.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.Закрыть.IconColor = System.Drawing.Color.Red;
            this.Закрыть.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Закрыть.IconSize = 30;
            this.Закрыть.Location = new System.Drawing.Point(1172, 0);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(27, 27);
            this.Закрыть.TabIndex = 0;
            this.Закрыть.UseVisualStyleBackColor = true;
            this.Закрыть.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Свернуть);
            this.panel1.Controls.Add(this.Развернуть);
            this.panel1.Controls.Add(this.Закрыть);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 27);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 87);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1199, 561);
            this.panelDesktop.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1199, 561);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1199, 87);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // Главная_страница
            // 
            this.Главная_страница.BackColor = System.Drawing.Color.Transparent;
            this.Главная_страница.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Главная_страница.Image = ((System.Drawing.Image)(resources.GetObject("Главная_страница.Image")));
            this.Главная_страница.Location = new System.Drawing.Point(0, 0);
            this.Главная_страница.Name = "Главная_страница";
            this.Главная_страница.Size = new System.Drawing.Size(200, 87);
            this.Главная_страница.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Главная_страница.TabIndex = 0;
            this.Главная_страница.TabStop = false;
            this.Главная_страница.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Журнал_регистраций
            // 
            this.Журнал_регистраций.Dock = System.Windows.Forms.DockStyle.Top;
            this.Журнал_регистраций.FlatAppearance.BorderSize = 0;
            this.Журнал_регистраций.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Журнал_регистраций.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Журнал_регистраций.ForeColor = System.Drawing.Color.Transparent;
            this.Журнал_регистраций.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.Журнал_регистраций.IconColor = System.Drawing.Color.White;
            this.Журнал_регистраций.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Журнал_регистраций.IconSize = 40;
            this.Журнал_регистраций.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Журнал_регистраций.Location = new System.Drawing.Point(0, 331);
            this.Журнал_регистраций.Name = "Журнал_регистраций";
            this.Журнал_регистраций.Size = new System.Drawing.Size(200, 50);
            this.Журнал_регистраций.TabIndex = 7;
            this.Журнал_регистраций.Text = "Журнал регистраций";
            this.Журнал_регистраций.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Журнал_регистраций.UseVisualStyleBackColor = true;
            this.Журнал_регистраций.Click += new System.EventHandler(this.Ж2_Click);
            // 
            // Журнал_услуг
            // 
            this.Журнал_услуг.Dock = System.Windows.Forms.DockStyle.Top;
            this.Журнал_услуг.FlatAppearance.BorderSize = 0;
            this.Журнал_услуг.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Журнал_услуг.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Журнал_услуг.ForeColor = System.Drawing.Color.Transparent;
            this.Журнал_услуг.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.Журнал_услуг.IconColor = System.Drawing.Color.White;
            this.Журнал_услуг.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Журнал_услуг.IconSize = 40;
            this.Журнал_услуг.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Журнал_услуг.Location = new System.Drawing.Point(0, 281);
            this.Журнал_услуг.Name = "Журнал_услуг";
            this.Журнал_услуг.Size = new System.Drawing.Size(200, 50);
            this.Журнал_услуг.TabIndex = 6;
            this.Журнал_услуг.Text = "Журнал услуг";
            this.Журнал_услуг.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Журнал_услуг.UseVisualStyleBackColor = true;
            this.Журнал_услуг.Click += new System.EventHandler(this.Ж1_Click);
            // 
            // Парковочные_места
            // 
            this.Парковочные_места.Dock = System.Windows.Forms.DockStyle.Top;
            this.Парковочные_места.FlatAppearance.BorderSize = 0;
            this.Парковочные_места.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Парковочные_места.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Парковочные_места.ForeColor = System.Drawing.Color.Transparent;
            this.Парковочные_места.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.Парковочные_места.IconColor = System.Drawing.Color.White;
            this.Парковочные_места.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Парковочные_места.IconSize = 40;
            this.Парковочные_места.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Парковочные_места.Location = new System.Drawing.Point(0, 231);
            this.Парковочные_места.Name = "Парковочные_места";
            this.Парковочные_места.Size = new System.Drawing.Size(200, 50);
            this.Парковочные_места.TabIndex = 4;
            this.Парковочные_места.Text = "Парквовочные места";
            this.Парковочные_места.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Парковочные_места.UseVisualStyleBackColor = true;
            this.Парковочные_места.Click += new System.EventHandler(this.Места_Click);
            // 
            // Тарифы_и_Услуги
            // 
            this.Тарифы_и_Услуги.Dock = System.Windows.Forms.DockStyle.Top;
            this.Тарифы_и_Услуги.FlatAppearance.BorderSize = 0;
            this.Тарифы_и_Услуги.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Тарифы_и_Услуги.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Тарифы_и_Услуги.ForeColor = System.Drawing.Color.Transparent;
            this.Тарифы_и_Услуги.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.Тарифы_и_Услуги.IconColor = System.Drawing.Color.White;
            this.Тарифы_и_Услуги.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Тарифы_и_Услуги.IconSize = 40;
            this.Тарифы_и_Услуги.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Тарифы_и_Услуги.Location = new System.Drawing.Point(0, 181);
            this.Тарифы_и_Услуги.Name = "Тарифы_и_Услуги";
            this.Тарифы_и_Услуги.Size = new System.Drawing.Size(200, 50);
            this.Тарифы_и_Услуги.TabIndex = 3;
            this.Тарифы_и_Услуги.Text = "Тарифы и Услуги";
            this.Тарифы_и_Услуги.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Тарифы_и_Услуги.UseVisualStyleBackColor = true;
            this.Тарифы_и_Услуги.Click += new System.EventHandler(this.Тарифы_Click);
            // 
            // Автомобили
            // 
            this.Автомобили.Dock = System.Windows.Forms.DockStyle.Top;
            this.Автомобили.FlatAppearance.BorderSize = 0;
            this.Автомобили.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Автомобили.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Автомобили.ForeColor = System.Drawing.Color.Transparent;
            this.Автомобили.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.Автомобили.IconColor = System.Drawing.Color.White;
            this.Автомобили.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Автомобили.IconSize = 40;
            this.Автомобили.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Автомобили.Location = new System.Drawing.Point(0, 87);
            this.Автомобили.Name = "Автомобили";
            this.Автомобили.Size = new System.Drawing.Size(200, 44);
            this.Автомобили.TabIndex = 1;
            this.Автомобили.Text = "Авто";
            this.Автомобили.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Автомобили.UseVisualStyleBackColor = true;
            this.Автомобили.Click += new System.EventHandler(this.Авто_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.Журнал_регистраций);
            this.panelMenu.Controls.Add(this.Журнал_услуг);
            this.panelMenu.Controls.Add(this.Парковочные_места);
            this.panelMenu.Controls.Add(this.Тарифы_и_Услуги);
            this.panelMenu.Controls.Add(this.Клиенты);
            this.panelMenu.Controls.Add(this.Автомобили);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 648);
            this.panelMenu.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 381);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 50);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Отчёты";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Клиенты
            // 
            this.Клиенты.Dock = System.Windows.Forms.DockStyle.Top;
            this.Клиенты.FlatAppearance.BorderSize = 0;
            this.Клиенты.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Клиенты.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Клиенты.ForeColor = System.Drawing.Color.Transparent;
            this.Клиенты.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.Клиенты.IconColor = System.Drawing.Color.White;
            this.Клиенты.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Клиенты.IconSize = 40;
            this.Клиенты.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Клиенты.Location = new System.Drawing.Point(0, 131);
            this.Клиенты.Name = "Клиенты";
            this.Клиенты.Size = new System.Drawing.Size(200, 50);
            this.Клиенты.TabIndex = 2;
            this.Клиенты.Text = "Клиенты";
            this.Клиенты.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Клиенты.UseVisualStyleBackColor = true;
            this.Клиенты.Click += new System.EventHandler(this.Клиенты_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.Главная_страница);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 87);
            this.panelLogo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 648);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Главная_страница)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton Свернуть;
        private FontAwesome.Sharp.IconButton Развернуть;
        private FontAwesome.Sharp.IconButton Закрыть;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox Главная_страница;
        private FontAwesome.Sharp.IconButton Журнал_регистраций;
        private FontAwesome.Sharp.IconButton Журнал_услуг;
        private FontAwesome.Sharp.IconButton Парковочные_места;
        private FontAwesome.Sharp.IconButton Тарифы_и_Услуги;
        private FontAwesome.Sharp.IconButton Автомобили;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton Клиенты;
        private System.Windows.Forms.Timer Report;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

