namespace KonkursyMuzyczne
{
    partial class Konkursy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Konkursy));
            this.konkursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pełnyEkranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzDokumentacjęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzPrzewodnikPoAplikacjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.informacjeOProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.powrotSG = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bazaKonkursowDataSet = new KonkursyMuzyczne.BazaKonkursowDataSet();
            this.iDKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cyklicznoscKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokalizacjaKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zasiegKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizatorKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zalozycielKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konkursTableAdapter = new KonkursyMuzyczne.BazaKonkursowDataSetTableAdapters.KonkursTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.konkursBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaKonkursowDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // konkursBindingSource
            // 
            this.konkursBindingSource.DataMember = "Konkurs";
            this.konkursBindingSource.DataSource = this.bazaKonkursowDataSet;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::KonkursyMuzyczne.Properties.Resources.no_person_3221109_1920;
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.powrotSG);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(868, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 487);
            this.panel1.TabIndex = 3;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(868, 25);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pełnyEkranToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // pełnyEkranToolStripMenuItem
            // 
            this.pełnyEkranToolStripMenuItem.CheckOnClick = true;
            this.pełnyEkranToolStripMenuItem.Name = "pełnyEkranToolStripMenuItem";
            this.pełnyEkranToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.pełnyEkranToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pełnyEkranToolStripMenuItem.Text = "Pełny ekran";
            this.pełnyEkranToolStripMenuItem.Click += new System.EventHandler(this.pełnyEkranToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzDokumentacjęToolStripMenuItem,
            this.otwórzPrzewodnikPoAplikacjiToolStripMenuItem,
            this.toolStripSeparator1,
            this.informacjeOProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // otwórzDokumentacjęToolStripMenuItem
            // 
            this.otwórzDokumentacjęToolStripMenuItem.Name = "otwórzDokumentacjęToolStripMenuItem";
            this.otwórzDokumentacjęToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.otwórzDokumentacjęToolStripMenuItem.Text = "Otwórz dokumentację";
            this.otwórzDokumentacjęToolStripMenuItem.Click += new System.EventHandler(this.otwórzDokumentacjęToolStripMenuItem_Click);
            // 
            // otwórzPrzewodnikPoAplikacjiToolStripMenuItem
            // 
            this.otwórzPrzewodnikPoAplikacjiToolStripMenuItem.Name = "otwórzPrzewodnikPoAplikacjiToolStripMenuItem";
            this.otwórzPrzewodnikPoAplikacjiToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.otwórzPrzewodnikPoAplikacjiToolStripMenuItem.Text = "Otwórz przewodnik po aplikacji";
            this.otwórzPrzewodnikPoAplikacjiToolStripMenuItem.Click += new System.EventHandler(this.otwórzPrzewodnikPoAplikacjiToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // informacjeOProgramieToolStripMenuItem
            // 
            this.informacjeOProgramieToolStripMenuItem.Name = "informacjeOProgramieToolStripMenuItem";
            this.informacjeOProgramieToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.informacjeOProgramieToolStripMenuItem.Text = "Informacje o programie";
            this.informacjeOProgramieToolStripMenuItem.Click += new System.EventHandler(this.informacjeOProgramieToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(418, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Konkursy";
            // 
            // powrotSG
            // 
            this.powrotSG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powrotSG.Location = new System.Drawing.Point(12, 59);
            this.powrotSG.Name = "powrotSG";
            this.powrotSG.Size = new System.Drawing.Size(147, 23);
            this.powrotSG.TabIndex = 3;
            this.powrotSG.Text = "Powrót do Strony Głównej";
            this.powrotSG.UseVisualStyleBackColor = true;
            this.powrotSG.Click += new System.EventHandler(this.powrotSG_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKonkursuDataGridViewTextBoxColumn,
            this.nazwaKonkursuDataGridViewTextBoxColumn,
            this.rodzajKonkursuDataGridViewTextBoxColumn,
            this.cyklicznoscKonkursuDataGridViewTextBoxColumn,
            this.lokalizacjaKonkursuDataGridViewTextBoxColumn,
            this.zasiegKonkursuDataGridViewTextBoxColumn,
            this.organizatorKonkursuDataGridViewTextBoxColumn,
            this.zalozycielKonkursuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.konkursBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 390);
            this.dataGridView1.TabIndex = 2;
            // 
            // bazaKonkursowDataSet
            // 
            this.bazaKonkursowDataSet.DataSetName = "BazaKonkursowDataSet";
            this.bazaKonkursowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDKonkursuDataGridViewTextBoxColumn
            // 
            this.iDKonkursuDataGridViewTextBoxColumn.DataPropertyName = "IDKonkursu";
            this.iDKonkursuDataGridViewTextBoxColumn.HeaderText = "IDKonkursu";
            this.iDKonkursuDataGridViewTextBoxColumn.Name = "iDKonkursuDataGridViewTextBoxColumn";
            this.iDKonkursuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaKonkursuDataGridViewTextBoxColumn
            // 
            this.nazwaKonkursuDataGridViewTextBoxColumn.DataPropertyName = "NazwaKonkursu";
            this.nazwaKonkursuDataGridViewTextBoxColumn.HeaderText = "NazwaKonkursu";
            this.nazwaKonkursuDataGridViewTextBoxColumn.Name = "nazwaKonkursuDataGridViewTextBoxColumn";
            // 
            // rodzajKonkursuDataGridViewTextBoxColumn
            // 
            this.rodzajKonkursuDataGridViewTextBoxColumn.DataPropertyName = "RodzajKonkursu";
            this.rodzajKonkursuDataGridViewTextBoxColumn.HeaderText = "RodzajKonkursu";
            this.rodzajKonkursuDataGridViewTextBoxColumn.Name = "rodzajKonkursuDataGridViewTextBoxColumn";
            // 
            // cyklicznoscKonkursuDataGridViewTextBoxColumn
            // 
            this.cyklicznoscKonkursuDataGridViewTextBoxColumn.DataPropertyName = "CyklicznoscKonkursu";
            this.cyklicznoscKonkursuDataGridViewTextBoxColumn.HeaderText = "CyklicznoscKonkursu";
            this.cyklicznoscKonkursuDataGridViewTextBoxColumn.Name = "cyklicznoscKonkursuDataGridViewTextBoxColumn";
            // 
            // lokalizacjaKonkursuDataGridViewTextBoxColumn
            // 
            this.lokalizacjaKonkursuDataGridViewTextBoxColumn.DataPropertyName = "LokalizacjaKonkursu";
            this.lokalizacjaKonkursuDataGridViewTextBoxColumn.HeaderText = "LokalizacjaKonkursu";
            this.lokalizacjaKonkursuDataGridViewTextBoxColumn.Name = "lokalizacjaKonkursuDataGridViewTextBoxColumn";
            // 
            // zasiegKonkursuDataGridViewTextBoxColumn
            // 
            this.zasiegKonkursuDataGridViewTextBoxColumn.DataPropertyName = "ZasiegKonkursu";
            this.zasiegKonkursuDataGridViewTextBoxColumn.HeaderText = "ZasiegKonkursu";
            this.zasiegKonkursuDataGridViewTextBoxColumn.Name = "zasiegKonkursuDataGridViewTextBoxColumn";
            // 
            // organizatorKonkursuDataGridViewTextBoxColumn
            // 
            this.organizatorKonkursuDataGridViewTextBoxColumn.DataPropertyName = "OrganizatorKonkursu";
            this.organizatorKonkursuDataGridViewTextBoxColumn.HeaderText = "OrganizatorKonkursu";
            this.organizatorKonkursuDataGridViewTextBoxColumn.Name = "organizatorKonkursuDataGridViewTextBoxColumn";
            // 
            // zalozycielKonkursuDataGridViewTextBoxColumn
            // 
            this.zalozycielKonkursuDataGridViewTextBoxColumn.DataPropertyName = "ZalozycielKonkursu";
            this.zalozycielKonkursuDataGridViewTextBoxColumn.HeaderText = "ZalozycielKonkursu";
            this.zalozycielKonkursuDataGridViewTextBoxColumn.Name = "zalozycielKonkursuDataGridViewTextBoxColumn";
            // 
            // konkursTableAdapter
            // 
            this.konkursTableAdapter.ClearBeforeFill = true;
            // 
            // Konkursy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 487);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(884, 526);
            this.Name = "Konkursy";
            this.Text = "Konkursy";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Konkursy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.konkursBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaKonkursowDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource konkursBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button powrotSG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pełnyEkranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzDokumentacjęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzPrzewodnikPoAplikacjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem informacjeOProgramieToolStripMenuItem;
        private BazaKonkursowDataSet bazaKonkursowDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cyklicznoscKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokalizacjaKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zasiegKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizatorKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zalozycielKonkursuDataGridViewTextBoxColumn;
        private BazaKonkursowDataSetTableAdapters.KonkursTableAdapter konkursTableAdapter;
    }
}