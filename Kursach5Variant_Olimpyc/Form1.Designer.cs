namespace Kursach5Variant_Olimpyc
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
            System.Windows.Forms.Label competitonLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFiletxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OlimpycRegistrationTabIndex = new System.Windows.Forms.TabPage();
            this.RegistrationDataView = new System.Windows.Forms.DataGridView();
            this.RegistrationIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationFirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationLastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationPatronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationCountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationCompetitionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationPlaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveToDBButton = new System.Windows.Forms.Button();
            this.placeLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.competitionTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.OlimpycEditTabIndex = new System.Windows.Forms.TabPage();
            this.EditSaveChangesButton = new System.Windows.Forms.Button();
            this.EditDataView = new System.Windows.Forms.DataGridView();
            this.EditIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditFirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditLastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditPatronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCompetitionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditPlaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlimpucSearchTabIndex = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removeSearchButton = new System.Windows.Forms.Button();
            this.doppingSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.removeSearchTextBox = new System.Windows.Forms.TextBox();
            this.removeSearchLabel = new System.Windows.Forms.Label();
            this.countrySearchTextBox = new System.Windows.Forms.TextBox();
            this.countrySearchLabel = new System.Windows.Forms.Label();
            this.infoAboutPlacesButton = new System.Windows.Forms.Button();
            this.sportSearchButton = new System.Windows.Forms.Button();
            this.searchSportTextBox = new System.Windows.Forms.TextBox();
            this.sportSearchListLabel = new System.Windows.Forms.Label();
            this.searchDataView = new System.Windows.Forms.DataGridView();
            this.SearchIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchFirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchLastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchPatronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchCountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchCompetitionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchPlaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlimpycDataFromFileTabIndex = new System.Windows.Forms.TabPage();
            this.InfoFromFileRichTextBoxTaabIndex = new System.Windows.Forms.RichTextBox();
            competitonLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.OlimpycRegistrationTabIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.OlimpycEditTabIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditDataView)).BeginInit();
            this.OlimpucSearchTabIndex.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataView)).BeginInit();
            this.OlimpycDataFromFileTabIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // competitonLabel
            // 
            competitonLabel.AutoSize = true;
            competitonLabel.Location = new System.Drawing.Point(3, 166);
            competitonLabel.Name = "competitonLabel";
            competitonLabel.Size = new System.Drawing.Size(82, 17);
            competitonLabel.TabIndex = 11;
            competitonLabel.Text = "Competition";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileActionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileActionsToolStripMenuItem
            // 
            this.fileActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFiletxtToolStripMenuItem,
            this.readFromFileToolStripMenuItem});
            this.fileActionsToolStripMenuItem.Name = "fileActionsToolStripMenuItem";
            this.fileActionsToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.fileActionsToolStripMenuItem.Text = "File Actions";
            // 
            // saveToFiletxtToolStripMenuItem
            // 
            this.saveToFiletxtToolStripMenuItem.Name = "saveToFiletxtToolStripMenuItem";
            this.saveToFiletxtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToFiletxtToolStripMenuItem.Text = "Save to file (*txt)";
            this.saveToFiletxtToolStripMenuItem.Click += new System.EventHandler(this.saveToFiletxtToolStripMenuItem_Click);
            // 
            // readFromFileToolStripMenuItem
            // 
            this.readFromFileToolStripMenuItem.Name = "readFromFileToolStripMenuItem";
            this.readFromFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.readFromFileToolStripMenuItem.Text = "Read from file";
            this.readFromFileToolStripMenuItem.Click += new System.EventHandler(this.readFromFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OlimpycRegistrationTabIndex);
            this.tabControl1.Controls.Add(this.OlimpycEditTabIndex);
            this.tabControl1.Controls.Add(this.OlimpucSearchTabIndex);
            this.tabControl1.Controls.Add(this.OlimpycDataFromFileTabIndex);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1381, 461);
            this.tabControl1.TabIndex = 1;
            // 
            // OlimpycRegistrationTabIndex
            // 
            this.OlimpycRegistrationTabIndex.Controls.Add(this.RegistrationDataView);
            this.OlimpycRegistrationTabIndex.Controls.Add(this.panel1);
            this.OlimpycRegistrationTabIndex.Location = new System.Drawing.Point(4, 25);
            this.OlimpycRegistrationTabIndex.Name = "OlimpycRegistrationTabIndex";
            this.OlimpycRegistrationTabIndex.Padding = new System.Windows.Forms.Padding(3);
            this.OlimpycRegistrationTabIndex.Size = new System.Drawing.Size(1373, 432);
            this.OlimpycRegistrationTabIndex.TabIndex = 0;
            this.OlimpycRegistrationTabIndex.Text = "Registration";
            this.OlimpycRegistrationTabIndex.UseVisualStyleBackColor = true;
            // 
            // RegistrationDataView
            // 
            this.RegistrationDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RegistrationDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RegistrationDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistrationDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistrationIDColumn,
            this.RegistrationFirstNameColumn,
            this.RegistrationLastNameColumn,
            this.RegistrationPatronymicColumn,
            this.RegistrationCountryColumn,
            this.RegistrationCompetitionColumn,
            this.RegistrationPlaceColumn});
            this.RegistrationDataView.Location = new System.Drawing.Point(240, 6);
            this.RegistrationDataView.Name = "RegistrationDataView";
            this.RegistrationDataView.RowHeadersWidth = 51;
            this.RegistrationDataView.RowTemplate.Height = 24;
            this.RegistrationDataView.Size = new System.Drawing.Size(1127, 423);
            this.RegistrationDataView.TabIndex = 1;
            // 
            // RegistrationIDColumn
            // 
            this.RegistrationIDColumn.Frozen = true;
            this.RegistrationIDColumn.HeaderText = "RegistrationID";
            this.RegistrationIDColumn.MinimumWidth = 6;
            this.RegistrationIDColumn.Name = "RegistrationIDColumn";
            this.RegistrationIDColumn.ReadOnly = true;
            this.RegistrationIDColumn.Width = 126;
            // 
            // RegistrationFirstNameColumn
            // 
            this.RegistrationFirstNameColumn.Frozen = true;
            this.RegistrationFirstNameColumn.HeaderText = "FirstName";
            this.RegistrationFirstNameColumn.MinimumWidth = 6;
            this.RegistrationFirstNameColumn.Name = "RegistrationFirstNameColumn";
            this.RegistrationFirstNameColumn.ReadOnly = true;
            this.RegistrationFirstNameColumn.Width = 101;
            // 
            // RegistrationLastNameColumn
            // 
            this.RegistrationLastNameColumn.Frozen = true;
            this.RegistrationLastNameColumn.HeaderText = "LastName";
            this.RegistrationLastNameColumn.MinimumWidth = 6;
            this.RegistrationLastNameColumn.Name = "RegistrationLastNameColumn";
            this.RegistrationLastNameColumn.ReadOnly = true;
            this.RegistrationLastNameColumn.Width = 101;
            // 
            // RegistrationPatronymicColumn
            // 
            this.RegistrationPatronymicColumn.Frozen = true;
            this.RegistrationPatronymicColumn.HeaderText = "Patronymic";
            this.RegistrationPatronymicColumn.MinimumWidth = 6;
            this.RegistrationPatronymicColumn.Name = "RegistrationPatronymicColumn";
            this.RegistrationPatronymicColumn.ReadOnly = true;
            this.RegistrationPatronymicColumn.Width = 107;
            // 
            // RegistrationCountryColumn
            // 
            this.RegistrationCountryColumn.Frozen = true;
            this.RegistrationCountryColumn.HeaderText = "Country";
            this.RegistrationCountryColumn.MinimumWidth = 6;
            this.RegistrationCountryColumn.Name = "RegistrationCountryColumn";
            this.RegistrationCountryColumn.ReadOnly = true;
            this.RegistrationCountryColumn.Width = 86;
            // 
            // RegistrationCompetitionColumn
            // 
            this.RegistrationCompetitionColumn.Frozen = true;
            this.RegistrationCompetitionColumn.HeaderText = "Competition";
            this.RegistrationCompetitionColumn.MinimumWidth = 6;
            this.RegistrationCompetitionColumn.Name = "RegistrationCompetitionColumn";
            this.RegistrationCompetitionColumn.ReadOnly = true;
            this.RegistrationCompetitionColumn.Width = 111;
            // 
            // RegistrationPlaceColumn
            // 
            this.RegistrationPlaceColumn.Frozen = true;
            this.RegistrationPlaceColumn.HeaderText = "Place";
            this.RegistrationPlaceColumn.MinimumWidth = 6;
            this.RegistrationPlaceColumn.Name = "RegistrationPlaceColumn";
            this.RegistrationPlaceColumn.ReadOnly = true;
            this.RegistrationPlaceColumn.Width = 72;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveToDBButton);
            this.panel1.Controls.Add(this.placeLabel);
            this.panel1.Controls.Add(competitonLabel);
            this.panel1.Controls.Add(this.countryLabel);
            this.panel1.Controls.Add(this.patronymicLabel);
            this.panel1.Controls.Add(this.lastNameLabel);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Controls.Add(this.placeTextBox);
            this.panel1.Controls.Add(this.competitionTextBox);
            this.panel1.Controls.Add(this.countryTextBox);
            this.panel1.Controls.Add(this.patronymicTextBox);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 420);
            this.panel1.TabIndex = 0;
            // 
            // saveToDBButton
            // 
            this.saveToDBButton.Location = new System.Drawing.Point(57, 293);
            this.saveToDBButton.Name = "saveToDBButton";
            this.saveToDBButton.Size = new System.Drawing.Size(122, 44);
            this.saveToDBButton.TabIndex = 13;
            this.saveToDBButton.Text = "Save";
            this.saveToDBButton.UseVisualStyleBackColor = true;
            this.saveToDBButton.Click += new System.EventHandler(this.saveToDBButton_Click);
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Location = new System.Drawing.Point(3, 195);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(43, 17);
            this.placeLabel.TabIndex = 12;
            this.placeLabel.Text = "Place";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(3, 137);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(57, 17);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "Country";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(3, 108);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(78, 17);
            this.patronymicLabel.TabIndex = 9;
            this.patronymicLabel.Text = "Patronymic";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(3, 80);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(3, 50);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First Name";
            // 
            // placeTextBox
            // 
            this.placeTextBox.Location = new System.Drawing.Point(96, 190);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(132, 22);
            this.placeTextBox.TabIndex = 6;
            // 
            // competitionTextBox
            // 
            this.competitionTextBox.Location = new System.Drawing.Point(94, 161);
            this.competitionTextBox.Name = "competitionTextBox";
            this.competitionTextBox.Size = new System.Drawing.Size(134, 22);
            this.competitionTextBox.TabIndex = 5;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(96, 133);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(132, 22);
            this.countryTextBox.TabIndex = 4;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(96, 103);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(132, 22);
            this.patronymicTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(96, 75);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(81, 47);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(147, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(41, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(154, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Registration participant";
            // 
            // OlimpycEditTabIndex
            // 
            this.OlimpycEditTabIndex.Controls.Add(this.EditSaveChangesButton);
            this.OlimpycEditTabIndex.Controls.Add(this.EditDataView);
            this.OlimpycEditTabIndex.Location = new System.Drawing.Point(4, 25);
            this.OlimpycEditTabIndex.Name = "OlimpycEditTabIndex";
            this.OlimpycEditTabIndex.Padding = new System.Windows.Forms.Padding(3);
            this.OlimpycEditTabIndex.Size = new System.Drawing.Size(1373, 432);
            this.OlimpycEditTabIndex.TabIndex = 1;
            this.OlimpycEditTabIndex.Text = "Edit";
            this.OlimpycEditTabIndex.UseVisualStyleBackColor = true;
            // 
            // EditSaveChangesButton
            // 
            this.EditSaveChangesButton.Location = new System.Drawing.Point(58, 293);
            this.EditSaveChangesButton.Name = "EditSaveChangesButton";
            this.EditSaveChangesButton.Size = new System.Drawing.Size(123, 68);
            this.EditSaveChangesButton.TabIndex = 1;
            this.EditSaveChangesButton.Text = "Save Edit Changes";
            this.EditSaveChangesButton.UseVisualStyleBackColor = true;
            this.EditSaveChangesButton.Click += new System.EventHandler(this.EditSaveChangesButton_Click);
            // 
            // EditDataView
            // 
            this.EditDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EditDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EditDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditIDColumn,
            this.EditFirstNameColumn,
            this.EditLastNameColumn,
            this.EditPatronymicColumn,
            this.EditCountryColumn,
            this.EditCompetitionColumn,
            this.EditPlaceColumn});
            this.EditDataView.Location = new System.Drawing.Point(222, 7);
            this.EditDataView.Name = "EditDataView";
            this.EditDataView.RowHeadersWidth = 51;
            this.EditDataView.RowTemplate.Height = 24;
            this.EditDataView.Size = new System.Drawing.Size(1145, 416);
            this.EditDataView.TabIndex = 0;
            // 
            // EditIDColumn
            // 
            this.EditIDColumn.Frozen = true;
            this.EditIDColumn.HeaderText = "RegistrationID";
            this.EditIDColumn.MinimumWidth = 6;
            this.EditIDColumn.Name = "EditIDColumn";
            this.EditIDColumn.ReadOnly = true;
            this.EditIDColumn.Width = 126;
            // 
            // EditFirstNameColumn
            // 
            this.EditFirstNameColumn.Frozen = true;
            this.EditFirstNameColumn.HeaderText = "FirstName";
            this.EditFirstNameColumn.MinimumWidth = 6;
            this.EditFirstNameColumn.Name = "EditFirstNameColumn";
            this.EditFirstNameColumn.Width = 101;
            // 
            // EditLastNameColumn
            // 
            this.EditLastNameColumn.Frozen = true;
            this.EditLastNameColumn.HeaderText = "LastName";
            this.EditLastNameColumn.MinimumWidth = 6;
            this.EditLastNameColumn.Name = "EditLastNameColumn";
            this.EditLastNameColumn.Width = 101;
            // 
            // EditPatronymicColumn
            // 
            this.EditPatronymicColumn.Frozen = true;
            this.EditPatronymicColumn.HeaderText = "Patronymic";
            this.EditPatronymicColumn.MinimumWidth = 6;
            this.EditPatronymicColumn.Name = "EditPatronymicColumn";
            this.EditPatronymicColumn.Width = 107;
            // 
            // EditCountryColumn
            // 
            this.EditCountryColumn.Frozen = true;
            this.EditCountryColumn.HeaderText = "Country";
            this.EditCountryColumn.MinimumWidth = 6;
            this.EditCountryColumn.Name = "EditCountryColumn";
            this.EditCountryColumn.Width = 86;
            // 
            // EditCompetitionColumn
            // 
            this.EditCompetitionColumn.Frozen = true;
            this.EditCompetitionColumn.HeaderText = "Competition";
            this.EditCompetitionColumn.MinimumWidth = 6;
            this.EditCompetitionColumn.Name = "EditCompetitionColumn";
            this.EditCompetitionColumn.Width = 111;
            // 
            // EditPlaceColumn
            // 
            this.EditPlaceColumn.Frozen = true;
            this.EditPlaceColumn.HeaderText = "Place";
            this.EditPlaceColumn.MinimumWidth = 6;
            this.EditPlaceColumn.Name = "EditPlaceColumn";
            this.EditPlaceColumn.Width = 72;
            // 
            // OlimpucSearchTabIndex
            // 
            this.OlimpucSearchTabIndex.Controls.Add(this.panel2);
            this.OlimpucSearchTabIndex.Controls.Add(this.searchDataView);
            this.OlimpucSearchTabIndex.Location = new System.Drawing.Point(4, 25);
            this.OlimpucSearchTabIndex.Name = "OlimpucSearchTabIndex";
            this.OlimpucSearchTabIndex.Size = new System.Drawing.Size(1373, 432);
            this.OlimpucSearchTabIndex.TabIndex = 2;
            this.OlimpucSearchTabIndex.Text = "Search";
            this.OlimpucSearchTabIndex.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.removeSearchButton);
            this.panel2.Controls.Add(this.doppingSearchCheckBox);
            this.panel2.Controls.Add(this.removeSearchTextBox);
            this.panel2.Controls.Add(this.removeSearchLabel);
            this.panel2.Controls.Add(this.countrySearchTextBox);
            this.panel2.Controls.Add(this.countrySearchLabel);
            this.panel2.Controls.Add(this.infoAboutPlacesButton);
            this.panel2.Controls.Add(this.sportSearchButton);
            this.panel2.Controls.Add(this.searchSportTextBox);
            this.panel2.Controls.Add(this.sportSearchListLabel);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 423);
            this.panel2.TabIndex = 1;
            // 
            // removeSearchButton
            // 
            this.removeSearchButton.Location = new System.Drawing.Point(31, 397);
            this.removeSearchButton.Name = "removeSearchButton";
            this.removeSearchButton.Size = new System.Drawing.Size(144, 23);
            this.removeSearchButton.TabIndex = 10;
            this.removeSearchButton.Text = "Remove";
            this.removeSearchButton.UseVisualStyleBackColor = true;
            this.removeSearchButton.Click += new System.EventHandler(this.removeSearchButton_Click);
            // 
            // doppingSearchCheckBox
            // 
            this.doppingSearchCheckBox.AutoSize = true;
            this.doppingSearchCheckBox.Location = new System.Drawing.Point(16, 375);
            this.doppingSearchCheckBox.Name = "doppingSearchCheckBox";
            this.doppingSearchCheckBox.Size = new System.Drawing.Size(112, 21);
            this.doppingSearchCheckBox.TabIndex = 9;
            this.doppingSearchCheckBox.Text = "Used Doping";
            this.doppingSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeSearchTextBox
            // 
            this.removeSearchTextBox.Location = new System.Drawing.Point(16, 347);
            this.removeSearchTextBox.Name = "removeSearchTextBox";
            this.removeSearchTextBox.Size = new System.Drawing.Size(159, 22);
            this.removeSearchTextBox.TabIndex = 8;
            // 
            // removeSearchLabel
            // 
            this.removeSearchLabel.AutoSize = true;
            this.removeSearchLabel.Location = new System.Drawing.Point(28, 327);
            this.removeSearchLabel.Name = "removeSearchLabel";
            this.removeSearchLabel.Size = new System.Drawing.Size(132, 17);
            this.removeSearchLabel.TabIndex = 7;
            this.removeSearchLabel.Text = "Remove Sportsman";
            // 
            // countrySearchTextBox
            // 
            this.countrySearchTextBox.Location = new System.Drawing.Point(77, 176);
            this.countrySearchTextBox.Name = "countrySearchTextBox";
            this.countrySearchTextBox.Size = new System.Drawing.Size(139, 22);
            this.countrySearchTextBox.TabIndex = 6;
            // 
            // countrySearchLabel
            // 
            this.countrySearchLabel.AutoSize = true;
            this.countrySearchLabel.Location = new System.Drawing.Point(3, 179);
            this.countrySearchLabel.Name = "countrySearchLabel";
            this.countrySearchLabel.Size = new System.Drawing.Size(57, 17);
            this.countrySearchLabel.TabIndex = 5;
            this.countrySearchLabel.Text = "Country";
            // 
            // infoAboutPlacesButton
            // 
            this.infoAboutPlacesButton.Location = new System.Drawing.Point(58, 215);
            this.infoAboutPlacesButton.Name = "infoAboutPlacesButton";
            this.infoAboutPlacesButton.Size = new System.Drawing.Size(117, 70);
            this.infoAboutPlacesButton.TabIndex = 4;
            this.infoAboutPlacesButton.Text = "Information About Country Winners";
            this.infoAboutPlacesButton.UseVisualStyleBackColor = true;
            this.infoAboutPlacesButton.Click += new System.EventHandler(this.infoAboutPlacesButton_Click);
            // 
            // sportSearchButton
            // 
            this.sportSearchButton.Location = new System.Drawing.Point(68, 85);
            this.sportSearchButton.Name = "sportSearchButton";
            this.sportSearchButton.Size = new System.Drawing.Size(92, 47);
            this.sportSearchButton.TabIndex = 3;
            this.sportSearchButton.Text = "Search";
            this.sportSearchButton.UseVisualStyleBackColor = true;
            this.sportSearchButton.Click += new System.EventHandler(this.sportSearchButton_Click);
            // 
            // searchSportTextBox
            // 
            this.searchSportTextBox.Location = new System.Drawing.Point(77, 57);
            this.searchSportTextBox.Name = "searchSportTextBox";
            this.searchSportTextBox.Size = new System.Drawing.Size(139, 22);
            this.searchSportTextBox.TabIndex = 2;
            // 
            // sportSearchListLabel
            // 
            this.sportSearchListLabel.AutoSize = true;
            this.sportSearchListLabel.Location = new System.Drawing.Point(3, 62);
            this.sportSearchListLabel.Name = "sportSearchListLabel";
            this.sportSearchListLabel.Size = new System.Drawing.Size(68, 17);
            this.sportSearchListLabel.TabIndex = 1;
            this.sportSearchListLabel.Text = "Sport List";
            // 
            // searchDataView
            // 
            this.searchDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.searchDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SearchIDColumn,
            this.SearchFirstNameColumn,
            this.SearchLastNameColumn,
            this.SearchPatronymicColumn,
            this.SearchCountryColumn,
            this.SearchCompetitionColumn,
            this.SearchPlaceColumn});
            this.searchDataView.Location = new System.Drawing.Point(228, 3);
            this.searchDataView.Name = "searchDataView";
            this.searchDataView.RowHeadersWidth = 51;
            this.searchDataView.RowTemplate.Height = 24;
            this.searchDataView.Size = new System.Drawing.Size(1137, 423);
            this.searchDataView.TabIndex = 0;
            // 
            // SearchIDColumn
            // 
            this.SearchIDColumn.Frozen = true;
            this.SearchIDColumn.HeaderText = "RegistrationID";
            this.SearchIDColumn.MinimumWidth = 6;
            this.SearchIDColumn.Name = "SearchIDColumn";
            this.SearchIDColumn.ReadOnly = true;
            this.SearchIDColumn.Width = 126;
            // 
            // SearchFirstNameColumn
            // 
            this.SearchFirstNameColumn.Frozen = true;
            this.SearchFirstNameColumn.HeaderText = "FirstName";
            this.SearchFirstNameColumn.MinimumWidth = 6;
            this.SearchFirstNameColumn.Name = "SearchFirstNameColumn";
            this.SearchFirstNameColumn.ReadOnly = true;
            this.SearchFirstNameColumn.Width = 101;
            // 
            // SearchLastNameColumn
            // 
            this.SearchLastNameColumn.Frozen = true;
            this.SearchLastNameColumn.HeaderText = "LastName";
            this.SearchLastNameColumn.MinimumWidth = 6;
            this.SearchLastNameColumn.Name = "SearchLastNameColumn";
            this.SearchLastNameColumn.ReadOnly = true;
            this.SearchLastNameColumn.Width = 101;
            // 
            // SearchPatronymicColumn
            // 
            this.SearchPatronymicColumn.Frozen = true;
            this.SearchPatronymicColumn.HeaderText = "Patronymic";
            this.SearchPatronymicColumn.MinimumWidth = 6;
            this.SearchPatronymicColumn.Name = "SearchPatronymicColumn";
            this.SearchPatronymicColumn.ReadOnly = true;
            this.SearchPatronymicColumn.Width = 107;
            // 
            // SearchCountryColumn
            // 
            this.SearchCountryColumn.Frozen = true;
            this.SearchCountryColumn.HeaderText = "Country";
            this.SearchCountryColumn.MinimumWidth = 6;
            this.SearchCountryColumn.Name = "SearchCountryColumn";
            this.SearchCountryColumn.ReadOnly = true;
            this.SearchCountryColumn.Width = 86;
            // 
            // SearchCompetitionColumn
            // 
            this.SearchCompetitionColumn.Frozen = true;
            this.SearchCompetitionColumn.HeaderText = "Competition";
            this.SearchCompetitionColumn.MinimumWidth = 6;
            this.SearchCompetitionColumn.Name = "SearchCompetitionColumn";
            this.SearchCompetitionColumn.ReadOnly = true;
            this.SearchCompetitionColumn.Width = 111;
            // 
            // SearchPlaceColumn
            // 
            this.SearchPlaceColumn.Frozen = true;
            this.SearchPlaceColumn.HeaderText = "Place";
            this.SearchPlaceColumn.MinimumWidth = 6;
            this.SearchPlaceColumn.Name = "SearchPlaceColumn";
            this.SearchPlaceColumn.ReadOnly = true;
            this.SearchPlaceColumn.Width = 72;
            // 
            // OlimpycDataFromFileTabIndex
            // 
            this.OlimpycDataFromFileTabIndex.Controls.Add(this.InfoFromFileRichTextBoxTaabIndex);
            this.OlimpycDataFromFileTabIndex.Location = new System.Drawing.Point(4, 25);
            this.OlimpycDataFromFileTabIndex.Name = "OlimpycDataFromFileTabIndex";
            this.OlimpycDataFromFileTabIndex.Size = new System.Drawing.Size(1373, 432);
            this.OlimpycDataFromFileTabIndex.TabIndex = 3;
            this.OlimpycDataFromFileTabIndex.Text = "DataFromLoadFile";
            this.OlimpycDataFromFileTabIndex.UseVisualStyleBackColor = true;
            // 
            // InfoFromFileRichTextBoxTaabIndex
            // 
            this.InfoFromFileRichTextBoxTaabIndex.Location = new System.Drawing.Point(479, 3);
            this.InfoFromFileRichTextBoxTaabIndex.Name = "InfoFromFileRichTextBoxTaabIndex";
            this.InfoFromFileRichTextBoxTaabIndex.ReadOnly = true;
            this.InfoFromFileRichTextBoxTaabIndex.Size = new System.Drawing.Size(405, 423);
            this.InfoFromFileRichTextBoxTaabIndex.TabIndex = 0;
            this.InfoFromFileRichTextBoxTaabIndex.Text = "";
            this.InfoFromFileRichTextBoxTaabIndex.TextChanged += new System.EventHandler(this.InfoFromFileRichTextBoxTaabIndex_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 509);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.OlimpycRegistrationTabIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.OlimpycEditTabIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditDataView)).EndInit();
            this.OlimpucSearchTabIndex.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataView)).EndInit();
            this.OlimpycDataFromFileTabIndex.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFiletxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OlimpycRegistrationTabIndex;
        private System.Windows.Forms.DataGridView RegistrationDataView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage OlimpycEditTabIndex;
        private System.Windows.Forms.DataGridView EditDataView;
        private System.Windows.Forms.TabPage OlimpucSearchTabIndex;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView searchDataView;
        private System.Windows.Forms.TabPage OlimpycDataFromFileTabIndex;
        private System.Windows.Forms.RichTextBox InfoFromFileRichTextBoxTaabIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationFirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationLastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationPatronymicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationCountryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationCompetitionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationPlaceColumn;
        private System.Windows.Forms.Button saveToDBButton;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.TextBox competitionTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchFirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchLastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchPatronymicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchCountryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchCompetitionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchPlaceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditFirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditLastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditPatronymicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditCountryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditCompetitionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditPlaceColumn;
        private System.Windows.Forms.Button EditSaveChangesButton;
        private System.Windows.Forms.Label sportSearchListLabel;
        private System.Windows.Forms.TextBox searchSportTextBox;
        private System.Windows.Forms.Button sportSearchButton;
        private System.Windows.Forms.Button infoAboutPlacesButton;
        private System.Windows.Forms.TextBox countrySearchTextBox;
        private System.Windows.Forms.Label countrySearchLabel;
        private System.Windows.Forms.CheckBox doppingSearchCheckBox;
        private System.Windows.Forms.TextBox removeSearchTextBox;
        private System.Windows.Forms.Label removeSearchLabel;
        private System.Windows.Forms.Button removeSearchButton;
    }
}

