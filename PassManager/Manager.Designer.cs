
namespace PassManager
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.FilterCombobox = new System.Windows.Forms.ComboBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryCombobox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.SiteTextbox = new System.Windows.Forms.TextBox();
            this.SiteLabel = new System.Windows.Forms.Label();
            this.PassTextbox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PassDatagrid = new System.Windows.Forms.DataGridView();
            this.CommentTextbox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassCheckbox = new System.Windows.Forms.CheckBox();
            this.CopyPassButton = new System.Windows.Forms.Button();
            this.SiteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PassDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterCombobox
            // 
            this.FilterCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FilterCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterCombobox.DisplayMember = "0";
            this.FilterCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterCombobox.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterCombobox.FormattingEnabled = true;
            this.FilterCombobox.Items.AddRange(new object[] {
            "Все",
            "Соц. Сеть",
            "Аккаунт",
            "Сервис",
            "Мессенджер",
            "Форум",
            "Другое"});
            this.FilterCombobox.Location = new System.Drawing.Point(362, 92);
            this.FilterCombobox.Name = "FilterCombobox";
            this.FilterCombobox.Size = new System.Drawing.Size(294, 27);
            this.FilterCombobox.TabIndex = 5;
            this.FilterCombobox.ValueMember = "0";
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Font = new System.Drawing.Font("Hero Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.Location = new System.Drawing.Point(462, 508);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(94, 32);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Font = new System.Drawing.Font("Hero Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(562, 470);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 32);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Font = new System.Drawing.Font("Hero Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(462, 470);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(94, 32);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Font = new System.Drawing.Font("Hero Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(362, 470);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 32);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoButton.Font = new System.Drawing.Font("Hero Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoButton.Location = new System.Drawing.Point(562, 508);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(94, 32);
            this.InfoButton.TabIndex = 4;
            this.InfoButton.Text = "Справка";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Комментарий:";
            // 
            // CategoryCombobox
            // 
            this.CategoryCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryCombobox.DisplayMember = "0";
            this.CategoryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombobox.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryCombobox.FormattingEnabled = true;
            this.CategoryCombobox.Items.AddRange(new object[] {
            "Соц. Сеть",
            "Аккаунт",
            "Сервис",
            "Мессенджер",
            "Форум",
            "Другое"});
            this.CategoryCombobox.Location = new System.Drawing.Point(362, 426);
            this.CategoryCombobox.Name = "CategoryCombobox";
            this.CategoryCombobox.Size = new System.Drawing.Size(294, 27);
            this.CategoryCombobox.TabIndex = 10;
            this.CategoryCombobox.ValueMember = "0";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoryLabel.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.ForeColor = System.Drawing.Color.White;
            this.CategoryLabel.Location = new System.Drawing.Point(358, 403);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(96, 19);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Категория:";
            // 
            // SiteTextbox
            // 
            this.SiteTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SiteTextbox.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SiteTextbox.Location = new System.Drawing.Point(362, 322);
            this.SiteTextbox.Name = "SiteTextbox";
            this.SiteTextbox.Size = new System.Drawing.Size(259, 27);
            this.SiteTextbox.TabIndex = 7;
            // 
            // SiteLabel
            // 
            this.SiteLabel.AutoSize = true;
            this.SiteLabel.BackColor = System.Drawing.Color.Transparent;
            this.SiteLabel.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SiteLabel.ForeColor = System.Drawing.Color.White;
            this.SiteLabel.Location = new System.Drawing.Point(358, 299);
            this.SiteLabel.Name = "SiteLabel";
            this.SiteLabel.Size = new System.Drawing.Size(51, 19);
            this.SiteLabel.TabIndex = 6;
            this.SiteLabel.Text = "Сайт:";
            // 
            // PassTextbox
            // 
            this.PassTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PassTextbox.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTextbox.Location = new System.Drawing.Point(362, 270);
            this.PassTextbox.Name = "PassTextbox";
            this.PassTextbox.Size = new System.Drawing.Size(259, 27);
            this.PassTextbox.TabIndex = 5;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassLabel.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.ForeColor = System.Drawing.Color.White;
            this.PassLabel.Location = new System.Drawing.Point(358, 247);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(71, 19);
            this.PassLabel.TabIndex = 4;
            this.PassLabel.Text = "Пароль:";
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginTextbox.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextbox.Location = new System.Drawing.Point(362, 218);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(294, 27);
            this.LoginTextbox.TabIndex = 3;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(358, 195);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(59, 19);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Логин:";
            // 
            // NameTextbox
            // 
            this.NameTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameTextbox.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextbox.Location = new System.Drawing.Point(362, 166);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(294, 27);
            this.NameTextbox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(358, 143);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(91, 19);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название:";
            // 
            // PassDatagrid
            // 
            this.PassDatagrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.PassDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassDatagrid.ColumnHeadersVisible = false;
            this.PassDatagrid.Location = new System.Drawing.Point(12, 12);
            this.PassDatagrid.Name = "PassDatagrid";
            this.PassDatagrid.RowHeadersWidth = 24;
            this.PassDatagrid.RowTemplate.Height = 25;
            this.PassDatagrid.Size = new System.Drawing.Size(341, 528);
            this.PassDatagrid.TabIndex = 12;
            this.PassDatagrid.SelectionChanged += new System.EventHandler(this.PassDatagrid_SelectionChanged);
            // 
            // CommentTextbox
            // 
            this.CommentTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CommentTextbox.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentTextbox.Location = new System.Drawing.Point(362, 374);
            this.CommentTextbox.Name = "CommentTextbox";
            this.CommentTextbox.Size = new System.Drawing.Size(294, 27);
            this.CommentTextbox.TabIndex = 13;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Font = new System.Drawing.Font("Hero Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(362, 508);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 32);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchTextbox.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextbox.Location = new System.Drawing.Point(362, 40);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(294, 27);
            this.SearchTextbox.TabIndex = 15;
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchLabel.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.ForeColor = System.Drawing.Color.White;
            this.SearchLabel.Location = new System.Drawing.Point(358, 17);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(57, 19);
            this.SearchLabel.TabIndex = 16;
            this.SearchLabel.Text = "Поиск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(358, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Фильтрация:";
            // 
            // PassCheckbox
            // 
            this.PassCheckbox.AutoSize = true;
            this.PassCheckbox.Location = new System.Drawing.Point(599, 276);
            this.PassCheckbox.Name = "PassCheckbox";
            this.PassCheckbox.Size = new System.Drawing.Size(15, 14);
            this.PassCheckbox.TabIndex = 18;
            this.PassCheckbox.UseVisualStyleBackColor = true;
            this.PassCheckbox.CheckedChanged += new System.EventHandler(this.PassCheckbox_CheckedChanged);
            // 
            // CopyPassButton
            // 
            this.CopyPassButton.Location = new System.Drawing.Point(627, 270);
            this.CopyPassButton.Name = "CopyPassButton";
            this.CopyPassButton.Size = new System.Drawing.Size(26, 26);
            this.CopyPassButton.TabIndex = 19;
            this.CopyPassButton.UseVisualStyleBackColor = true;
            this.CopyPassButton.Click += new System.EventHandler(this.CopyPassButton_Click);
            // 
            // SiteButton
            // 
            this.SiteButton.Location = new System.Drawing.Point(627, 322);
            this.SiteButton.Name = "SiteButton";
            this.SiteButton.Size = new System.Drawing.Size(26, 26);
            this.SiteButton.TabIndex = 20;
            this.SiteButton.UseVisualStyleBackColor = true;
            this.SiteButton.Click += new System.EventHandler(this.SiteButton_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 553);
            this.Controls.Add(this.SiteButton);
            this.Controls.Add(this.CopyPassButton);
            this.Controls.Add(this.PassCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CommentTextbox);
            this.Controls.Add(this.PassDatagrid);
            this.Controls.Add(this.FilterCombobox);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.CategoryCombobox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SiteTextbox);
            this.Controls.Add(this.SiteLabel);
            this.Controls.Add(this.PassTextbox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LoginTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.LoginLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(682, 592);
            this.MinimumSize = new System.Drawing.Size(682, 592);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassManager | Менеджер";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PassDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FilterCombobox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoryCombobox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox SiteTextbox;
        private System.Windows.Forms.Label SiteLabel;
        private System.Windows.Forms.TextBox PassTextbox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox LoginTextbox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView PassDatagrid;
        private System.Windows.Forms.TextBox CommentTextbox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PassCheckbox;
        private System.Windows.Forms.Button CopyPassButton;
        private System.Windows.Forms.Button SiteButton;
    }
}

