
namespace GameStartApp
{
    partial class Menu
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
            this.tabBranch = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.GVClient = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFiscaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cittàDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCivicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamestart_logicDataSet = new GameStartApp.gamestart_logicDataSet();
            this.tabBranches = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAddBranch = new System.Windows.Forms.Button();
            this.CBBranchesManager = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBranchesCivic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBranchesStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelBranches = new System.Windows.Forms.Label();
            this.TxtBranchCity = new System.Windows.Forms.TextBox();
            this.GVBranches = new System.Windows.Forms.DataGridView();
            this.idFilialeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFiscaleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cittàDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCivicoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filialeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabEmployee = new System.Windows.Forms.TabPage();
            this.DateEmpBirth = new System.Windows.Forms.DateTimePicker();
            this.TxtEmpCod = new System.Windows.Forms.TextBox();
            this.TxtEmpSurname = new System.Windows.Forms.TextBox();
            this.TxtEmpName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GVEmployee = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascitaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFiscaleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cittàDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCivicoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFilialeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dipendenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new GameStartApp.gamestart_logicDataSetTableAdapters.clienteTableAdapter();
            this.filialeTableAdapter = new GameStartApp.gamestart_logicDataSetTableAdapters.filialeTableAdapter();
            this.dipendenteTableAdapter = new GameStartApp.gamestart_logicDataSetTableAdapters.dipendenteTableAdapter();
            this.TxtEmpCity = new System.Windows.Forms.TextBox();
            this.TxtEmpStreet = new System.Windows.Forms.TextBox();
            this.TxtEmpCivic = new System.Windows.Forms.TextBox();
            this.tabBranch.SuspendLayout();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamestart_logicDataSet)).BeginInit();
            this.tabBranches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVBranches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialeBindingSource)).BeginInit();
            this.TabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipendenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBranch
            // 
            this.tabBranch.Controls.Add(this.tabClient);
            this.tabBranch.Controls.Add(this.tabBranches);
            this.tabBranch.Controls.Add(this.TabEmployee);
            this.tabBranch.Location = new System.Drawing.Point(12, 12);
            this.tabBranch.Name = "tabBranch";
            this.tabBranch.SelectedIndex = 0;
            this.tabBranch.Size = new System.Drawing.Size(2100, 1031);
            this.tabBranch.TabIndex = 0;
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.label1);
            this.tabClient.Controls.Add(this.GVClient);
            this.tabClient.Location = new System.Drawing.Point(10, 47);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(2080, 974);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Clients";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operations";
            // 
            // GVClient
            // 
            this.GVClient.AutoGenerateColumns = false;
            this.GVClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.dataNascitaDataGridViewTextBoxColumn,
            this.codFiscaleDataGridViewTextBoxColumn,
            this.cittàDataGridViewTextBoxColumn,
            this.viaDataGridViewTextBoxColumn,
            this.nCivicoDataGridViewTextBoxColumn});
            this.GVClient.DataSource = this.clienteBindingSource;
            this.GVClient.Location = new System.Drawing.Point(564, 6);
            this.GVClient.Name = "GVClient";
            this.GVClient.RowHeadersVisible = false;
            this.GVClient.RowHeadersWidth = 92;
            this.GVClient.RowTemplate.Height = 37;
            this.GVClient.Size = new System.Drawing.Size(1500, 962);
            this.GVClient.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 225;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.Width = 225;
            // 
            // dataNascitaDataGridViewTextBoxColumn
            // 
            this.dataNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.HeaderText = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.dataNascitaDataGridViewTextBoxColumn.Name = "dataNascitaDataGridViewTextBoxColumn";
            this.dataNascitaDataGridViewTextBoxColumn.Width = 225;
            // 
            // codFiscaleDataGridViewTextBoxColumn
            // 
            this.codFiscaleDataGridViewTextBoxColumn.DataPropertyName = "CodFiscale";
            this.codFiscaleDataGridViewTextBoxColumn.HeaderText = "CodFiscale";
            this.codFiscaleDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.codFiscaleDataGridViewTextBoxColumn.Name = "codFiscaleDataGridViewTextBoxColumn";
            this.codFiscaleDataGridViewTextBoxColumn.Width = 225;
            // 
            // cittàDataGridViewTextBoxColumn
            // 
            this.cittàDataGridViewTextBoxColumn.DataPropertyName = "Città";
            this.cittàDataGridViewTextBoxColumn.HeaderText = "Città";
            this.cittàDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.cittàDataGridViewTextBoxColumn.Name = "cittàDataGridViewTextBoxColumn";
            this.cittàDataGridViewTextBoxColumn.Width = 225;
            // 
            // viaDataGridViewTextBoxColumn
            // 
            this.viaDataGridViewTextBoxColumn.DataPropertyName = "Via";
            this.viaDataGridViewTextBoxColumn.HeaderText = "Via";
            this.viaDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.viaDataGridViewTextBoxColumn.Name = "viaDataGridViewTextBoxColumn";
            this.viaDataGridViewTextBoxColumn.Width = 225;
            // 
            // nCivicoDataGridViewTextBoxColumn
            // 
            this.nCivicoDataGridViewTextBoxColumn.DataPropertyName = "nCivico";
            this.nCivicoDataGridViewTextBoxColumn.HeaderText = "nCivico";
            this.nCivicoDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.nCivicoDataGridViewTextBoxColumn.Name = "nCivicoDataGridViewTextBoxColumn";
            this.nCivicoDataGridViewTextBoxColumn.Width = 225;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.gamestart_logicDataSet;
            // 
            // gamestart_logicDataSet
            // 
            this.gamestart_logicDataSet.DataSetName = "gamestart_logicDataSet";
            this.gamestart_logicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabBranches
            // 
            this.tabBranches.Controls.Add(this.label5);
            this.tabBranches.Controls.Add(this.BtnAddBranch);
            this.tabBranches.Controls.Add(this.CBBranchesManager);
            this.tabBranches.Controls.Add(this.label4);
            this.tabBranches.Controls.Add(this.TxtBranchesCivic);
            this.tabBranches.Controls.Add(this.label3);
            this.tabBranches.Controls.Add(this.TxtBranchesStreet);
            this.tabBranches.Controls.Add(this.label2);
            this.tabBranches.Controls.Add(this.LabelBranches);
            this.tabBranches.Controls.Add(this.TxtBranchCity);
            this.tabBranches.Controls.Add(this.GVBranches);
            this.tabBranches.Location = new System.Drawing.Point(10, 47);
            this.tabBranches.Name = "tabBranches";
            this.tabBranches.Padding = new System.Windows.Forms.Padding(3);
            this.tabBranches.Size = new System.Drawing.Size(2080, 974);
            this.tabBranches.TabIndex = 1;
            this.tabBranches.Text = "Branches";
            this.tabBranches.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manager";
            // 
            // BtnAddBranch
            // 
            this.BtnAddBranch.Location = new System.Drawing.Point(6, 216);
            this.BtnAddBranch.Name = "BtnAddBranch";
            this.BtnAddBranch.Size = new System.Drawing.Size(408, 55);
            this.BtnAddBranch.TabIndex = 9;
            this.BtnAddBranch.Text = "Add Branch";
            this.BtnAddBranch.UseVisualStyleBackColor = true;
            // 
            // CBBranchesManager
            // 
            this.CBBranchesManager.FormattingEnabled = true;
            this.CBBranchesManager.Location = new System.Drawing.Point(6, 173);
            this.CBBranchesManager.Name = "CBBranchesManager";
            this.CBBranchesManager.Size = new System.Drawing.Size(408, 37);
            this.CBBranchesManager.TabIndex = 8;
            this.CBBranchesManager.Click += new System.EventHandler(this.CBBranchesManager_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Civic";
            // 
            // TxtBranchesCivic
            // 
            this.TxtBranchesCivic.Location = new System.Drawing.Point(6, 132);
            this.TxtBranchesCivic.Name = "TxtBranchesCivic";
            this.TxtBranchesCivic.Size = new System.Drawing.Size(408, 35);
            this.TxtBranchesCivic.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Street";
            // 
            // TxtBranchesStreet
            // 
            this.TxtBranchesStreet.Location = new System.Drawing.Point(6, 90);
            this.TxtBranchesStreet.Name = "TxtBranchesStreet";
            this.TxtBranchesStreet.Size = new System.Drawing.Size(408, 35);
            this.TxtBranchesStreet.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            // 
            // LabelBranches
            // 
            this.LabelBranches.AutoSize = true;
            this.LabelBranches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBranches.Location = new System.Drawing.Point(3, 3);
            this.LabelBranches.Name = "LabelBranches";
            this.LabelBranches.Size = new System.Drawing.Size(193, 40);
            this.LabelBranches.TabIndex = 2;
            this.LabelBranches.Text = "Operations";
            // 
            // TxtBranchCity
            // 
            this.TxtBranchCity.Location = new System.Drawing.Point(6, 49);
            this.TxtBranchCity.Name = "TxtBranchCity";
            this.TxtBranchCity.Size = new System.Drawing.Size(408, 35);
            this.TxtBranchCity.TabIndex = 1;
            // 
            // GVBranches
            // 
            this.GVBranches.AutoGenerateColumns = false;
            this.GVBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFilialeDataGridViewTextBoxColumn,
            this.codFiscaleDataGridViewTextBoxColumn1,
            this.cittàDataGridViewTextBoxColumn1,
            this.viaDataGridViewTextBoxColumn1,
            this.nCivicoDataGridViewTextBoxColumn1});
            this.GVBranches.DataSource = this.filialeBindingSource;
            this.GVBranches.Location = new System.Drawing.Point(563, 6);
            this.GVBranches.Name = "GVBranches";
            this.GVBranches.RowHeadersVisible = false;
            this.GVBranches.RowHeadersWidth = 92;
            this.GVBranches.RowTemplate.Height = 37;
            this.GVBranches.Size = new System.Drawing.Size(1500, 962);
            this.GVBranches.TabIndex = 0;
            // 
            // idFilialeDataGridViewTextBoxColumn
            // 
            this.idFilialeDataGridViewTextBoxColumn.DataPropertyName = "IdFiliale";
            this.idFilialeDataGridViewTextBoxColumn.HeaderText = "IdFiliale";
            this.idFilialeDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.idFilialeDataGridViewTextBoxColumn.Name = "idFilialeDataGridViewTextBoxColumn";
            this.idFilialeDataGridViewTextBoxColumn.Width = 225;
            // 
            // codFiscaleDataGridViewTextBoxColumn1
            // 
            this.codFiscaleDataGridViewTextBoxColumn1.DataPropertyName = "CodFiscale";
            this.codFiscaleDataGridViewTextBoxColumn1.HeaderText = "CodFiscale";
            this.codFiscaleDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.codFiscaleDataGridViewTextBoxColumn1.Name = "codFiscaleDataGridViewTextBoxColumn1";
            this.codFiscaleDataGridViewTextBoxColumn1.Width = 225;
            // 
            // cittàDataGridViewTextBoxColumn1
            // 
            this.cittàDataGridViewTextBoxColumn1.DataPropertyName = "Città";
            this.cittàDataGridViewTextBoxColumn1.HeaderText = "Città";
            this.cittàDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.cittàDataGridViewTextBoxColumn1.Name = "cittàDataGridViewTextBoxColumn1";
            this.cittàDataGridViewTextBoxColumn1.Width = 225;
            // 
            // viaDataGridViewTextBoxColumn1
            // 
            this.viaDataGridViewTextBoxColumn1.DataPropertyName = "Via";
            this.viaDataGridViewTextBoxColumn1.HeaderText = "Via";
            this.viaDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.viaDataGridViewTextBoxColumn1.Name = "viaDataGridViewTextBoxColumn1";
            this.viaDataGridViewTextBoxColumn1.Width = 225;
            // 
            // nCivicoDataGridViewTextBoxColumn1
            // 
            this.nCivicoDataGridViewTextBoxColumn1.DataPropertyName = "nCivico";
            this.nCivicoDataGridViewTextBoxColumn1.HeaderText = "nCivico";
            this.nCivicoDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.nCivicoDataGridViewTextBoxColumn1.Name = "nCivicoDataGridViewTextBoxColumn1";
            this.nCivicoDataGridViewTextBoxColumn1.Width = 225;
            // 
            // filialeBindingSource
            // 
            this.filialeBindingSource.DataMember = "filiale";
            this.filialeBindingSource.DataSource = this.gamestart_logicDataSet;
            // 
            // TabEmployee
            // 
            this.TabEmployee.Controls.Add(this.TxtEmpCivic);
            this.TabEmployee.Controls.Add(this.TxtEmpStreet);
            this.TabEmployee.Controls.Add(this.TxtEmpCity);
            this.TabEmployee.Controls.Add(this.DateEmpBirth);
            this.TabEmployee.Controls.Add(this.TxtEmpCod);
            this.TabEmployee.Controls.Add(this.TxtEmpSurname);
            this.TabEmployee.Controls.Add(this.TxtEmpName);
            this.TabEmployee.Controls.Add(this.label6);
            this.TabEmployee.Controls.Add(this.GVEmployee);
            this.TabEmployee.Location = new System.Drawing.Point(10, 47);
            this.TabEmployee.Name = "TabEmployee";
            this.TabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.TabEmployee.Size = new System.Drawing.Size(2080, 974);
            this.TabEmployee.TabIndex = 2;
            this.TabEmployee.Text = "Employees";
            this.TabEmployee.UseVisualStyleBackColor = true;
            // 
            // DateEmpBirth
            // 
            this.DateEmpBirth.Location = new System.Drawing.Point(7, 129);
            this.DateEmpBirth.Name = "DateEmpBirth";
            this.DateEmpBirth.Size = new System.Drawing.Size(408, 35);
            this.DateEmpBirth.TabIndex = 7;
            // 
            // TxtEmpCod
            // 
            this.TxtEmpCod.Location = new System.Drawing.Point(7, 170);
            this.TxtEmpCod.Name = "TxtEmpCod";
            this.TxtEmpCod.Size = new System.Drawing.Size(408, 35);
            this.TxtEmpCod.TabIndex = 6;
            // 
            // TxtEmpSurname
            // 
            this.TxtEmpSurname.Location = new System.Drawing.Point(6, 88);
            this.TxtEmpSurname.Name = "TxtEmpSurname";
            this.TxtEmpSurname.Size = new System.Drawing.Size(408, 35);
            this.TxtEmpSurname.TabIndex = 5;
            // 
            // TxtEmpName
            // 
            this.TxtEmpName.Location = new System.Drawing.Point(7, 47);
            this.TxtEmpName.Name = "TxtEmpName";
            this.TxtEmpName.Size = new System.Drawing.Size(408, 35);
            this.TxtEmpName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 40);
            this.label6.TabIndex = 3;
            this.label6.Text = "Operations";
            // 
            // GVEmployee
            // 
            this.GVEmployee.AutoGenerateColumns = false;
            this.GVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.cognomeDataGridViewTextBoxColumn1,
            this.dataNascitaDataGridViewTextBoxColumn1,
            this.codFiscaleDataGridViewTextBoxColumn2,
            this.cittàDataGridViewTextBoxColumn2,
            this.viaDataGridViewTextBoxColumn2,
            this.nCivicoDataGridViewTextBoxColumn2,
            this.idFilialeDataGridViewTextBoxColumn1});
            this.GVEmployee.DataSource = this.dipendenteBindingSource;
            this.GVEmployee.Location = new System.Drawing.Point(574, 6);
            this.GVEmployee.Name = "GVEmployee";
            this.GVEmployee.RowHeadersVisible = false;
            this.GVEmployee.RowHeadersWidth = 92;
            this.GVEmployee.RowTemplate.Height = 37;
            this.GVEmployee.Size = new System.Drawing.Size(1500, 962);
            this.GVEmployee.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.Width = 225;
            // 
            // cognomeDataGridViewTextBoxColumn1
            // 
            this.cognomeDataGridViewTextBoxColumn1.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn1.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.cognomeDataGridViewTextBoxColumn1.Name = "cognomeDataGridViewTextBoxColumn1";
            this.cognomeDataGridViewTextBoxColumn1.Width = 225;
            // 
            // dataNascitaDataGridViewTextBoxColumn1
            // 
            this.dataNascitaDataGridViewTextBoxColumn1.DataPropertyName = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn1.HeaderText = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.dataNascitaDataGridViewTextBoxColumn1.Name = "dataNascitaDataGridViewTextBoxColumn1";
            this.dataNascitaDataGridViewTextBoxColumn1.Width = 225;
            // 
            // codFiscaleDataGridViewTextBoxColumn2
            // 
            this.codFiscaleDataGridViewTextBoxColumn2.DataPropertyName = "CodFiscale";
            this.codFiscaleDataGridViewTextBoxColumn2.HeaderText = "CodFiscale";
            this.codFiscaleDataGridViewTextBoxColumn2.MinimumWidth = 11;
            this.codFiscaleDataGridViewTextBoxColumn2.Name = "codFiscaleDataGridViewTextBoxColumn2";
            this.codFiscaleDataGridViewTextBoxColumn2.Width = 225;
            // 
            // cittàDataGridViewTextBoxColumn2
            // 
            this.cittàDataGridViewTextBoxColumn2.DataPropertyName = "Città";
            this.cittàDataGridViewTextBoxColumn2.HeaderText = "Città";
            this.cittàDataGridViewTextBoxColumn2.MinimumWidth = 11;
            this.cittàDataGridViewTextBoxColumn2.Name = "cittàDataGridViewTextBoxColumn2";
            this.cittàDataGridViewTextBoxColumn2.Width = 225;
            // 
            // viaDataGridViewTextBoxColumn2
            // 
            this.viaDataGridViewTextBoxColumn2.DataPropertyName = "Via";
            this.viaDataGridViewTextBoxColumn2.HeaderText = "Via";
            this.viaDataGridViewTextBoxColumn2.MinimumWidth = 11;
            this.viaDataGridViewTextBoxColumn2.Name = "viaDataGridViewTextBoxColumn2";
            this.viaDataGridViewTextBoxColumn2.Width = 225;
            // 
            // nCivicoDataGridViewTextBoxColumn2
            // 
            this.nCivicoDataGridViewTextBoxColumn2.DataPropertyName = "nCivico";
            this.nCivicoDataGridViewTextBoxColumn2.HeaderText = "nCivico";
            this.nCivicoDataGridViewTextBoxColumn2.MinimumWidth = 11;
            this.nCivicoDataGridViewTextBoxColumn2.Name = "nCivicoDataGridViewTextBoxColumn2";
            this.nCivicoDataGridViewTextBoxColumn2.Width = 225;
            // 
            // idFilialeDataGridViewTextBoxColumn1
            // 
            this.idFilialeDataGridViewTextBoxColumn1.DataPropertyName = "IdFiliale";
            this.idFilialeDataGridViewTextBoxColumn1.HeaderText = "IdFiliale";
            this.idFilialeDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.idFilialeDataGridViewTextBoxColumn1.Name = "idFilialeDataGridViewTextBoxColumn1";
            this.idFilialeDataGridViewTextBoxColumn1.Width = 225;
            // 
            // dipendenteBindingSource
            // 
            this.dipendenteBindingSource.DataMember = "dipendente";
            this.dipendenteBindingSource.DataSource = this.gamestart_logicDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // filialeTableAdapter
            // 
            this.filialeTableAdapter.ClearBeforeFill = true;
            // 
            // dipendenteTableAdapter
            // 
            this.dipendenteTableAdapter.ClearBeforeFill = true;
            // 
            // TxtEmpCity
            // 
            this.TxtEmpCity.Location = new System.Drawing.Point(6, 211);
            this.TxtEmpCity.Name = "TxtEmpCity";
            this.TxtEmpCity.Size = new System.Drawing.Size(408, 35);
            this.TxtEmpCity.TabIndex = 8;
            // 
            // TxtEmpStreet
            // 
            this.TxtEmpStreet.Location = new System.Drawing.Point(7, 252);
            this.TxtEmpStreet.Name = "TxtEmpStreet";
            this.TxtEmpStreet.Size = new System.Drawing.Size(408, 35);
            this.TxtEmpStreet.TabIndex = 9;
            // 
            // TxtEmpCivic
            // 
            this.TxtEmpCivic.Location = new System.Drawing.Point(6, 293);
            this.TxtEmpCivic.Name = "TxtEmpCivic";
            this.TxtEmpCivic.Size = new System.Drawing.Size(408, 35);
            this.TxtEmpCivic.TabIndex = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2117, 1055);
            this.Controls.Add(this.tabBranch);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabBranch.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.tabClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamestart_logicDataSet)).EndInit();
            this.tabBranches.ResumeLayout(false);
            this.tabBranches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVBranches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialeBindingSource)).EndInit();
            this.TabEmployee.ResumeLayout(false);
            this.TabEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipendenteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBranch;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.DataGridView GVClient;
        private System.Windows.Forms.TabPage tabBranches;
        private gamestart_logicDataSet gamestart_logicDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private gamestart_logicDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFiscaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cittàDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCivicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView GVBranches;
        private System.Windows.Forms.BindingSource filialeBindingSource;
        private gamestart_logicDataSetTableAdapters.filialeTableAdapter filialeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFilialeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFiscaleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cittàDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCivicoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label LabelBranches;
        private System.Windows.Forms.TextBox TxtBranchCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBranchesCivic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBranchesStreet;
        private System.Windows.Forms.ComboBox CBBranchesManager;
        private System.Windows.Forms.Button BtnAddBranch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage TabEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GVEmployee;
        private System.Windows.Forms.BindingSource dipendenteBindingSource;
        private gamestart_logicDataSetTableAdapters.dipendenteTableAdapter dipendenteTableAdapter;
        private System.Windows.Forms.DateTimePicker DateEmpBirth;
        private System.Windows.Forms.TextBox TxtEmpCod;
        private System.Windows.Forms.TextBox TxtEmpSurname;
        private System.Windows.Forms.TextBox TxtEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFiscaleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cittàDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCivicoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFilialeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox TxtEmpCivic;
        private System.Windows.Forms.TextBox TxtEmpStreet;
        private System.Windows.Forms.TextBox TxtEmpCity;
    }
}

