﻿namespace KonkursyMuzyczne
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
            this.bazaKonkursowDataSet = new KonkursyMuzyczne.BazaKonkursowDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zalozyciel = new System.Windows.Forms.TextBox();
            this.organizator = new System.Windows.Forms.TextBox();
            this.zasieg = new System.Windows.Forms.TextBox();
            this.cyklicznosc = new System.Windows.Forms.NumericUpDown();
            this.lokalizacja = new System.Windows.Forms.TextBox();
            this.rodzaj = new System.Windows.Forms.TextBox();
            this.nazwa = new System.Windows.Forms.TextBox();
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
            this.iDKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cyklicznoscKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokalizacjaKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zasiegKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizatorKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zalozycielKonkursuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konkursTableAdapter = new KonkursyMuzyczne.BazaKonkursowDataSetTableAdapters.KonkursTableAdapter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.konkursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaKonkursowDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyklicznosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // konkursBindingSource
            // 
            this.konkursBindingSource.DataMember = "Konkurs";
            this.konkursBindingSource.DataSource = this.bazaKonkursowDataSet;
            // 
            // bazaKonkursowDataSet
            // 
            this.bazaKonkursowDataSet.DataSetName = "BazaKonkursowDataSet";
            this.bazaKonkursowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::KonkursyMuzyczne.Properties.Resources.no_person_3221109_1920;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.zalozyciel);
            this.panel1.Controls.Add(this.organizator);
            this.panel1.Controls.Add(this.zasieg);
            this.panel1.Controls.Add(this.cyklicznosc);
            this.panel1.Controls.Add(this.lokalizacja);
            this.panel1.Controls.Add(this.rodzaj);
            this.panel1.Controls.Add(this.nazwa);
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.powrotSG);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(1004, 563);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 563);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(894, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Założyciel";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(755, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Organizator";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Zasięg";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lokalizacja";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cykliczność";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rodzaj";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nazwa";
            // 
            // zalozyciel
            // 
            this.zalozyciel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zalozyciel.Location = new System.Drawing.Point(858, 126);
            this.zalozyciel.Name = "zalozyciel";
            this.zalozyciel.Size = new System.Drawing.Size(131, 20);
            this.zalozyciel.TabIndex = 13;
            // 
            // organizator
            // 
            this.organizator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.organizator.Location = new System.Drawing.Point(721, 126);
            this.organizator.Name = "organizator";
            this.organizator.Size = new System.Drawing.Size(131, 20);
            this.organizator.TabIndex = 12;
            // 
            // zasieg
            // 
            this.zasieg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zasieg.Location = new System.Drawing.Point(591, 126);
            this.zasieg.Name = "zasieg";
            this.zasieg.Size = new System.Drawing.Size(124, 20);
            this.zasieg.TabIndex = 11;
            // 
            // cyklicznosc
            // 
            this.cyklicznosc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cyklicznosc.Location = new System.Drawing.Point(393, 126);
            this.cyklicznosc.Name = "cyklicznosc";
            this.cyklicznosc.Size = new System.Drawing.Size(84, 20);
            this.cyklicznosc.TabIndex = 10;
            // 
            // lokalizacja
            // 
            this.lokalizacja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lokalizacja.Location = new System.Drawing.Point(483, 126);
            this.lokalizacja.Name = "lokalizacja";
            this.lokalizacja.Size = new System.Drawing.Size(102, 20);
            this.lokalizacja.TabIndex = 9;
            // 
            // rodzaj
            // 
            this.rodzaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rodzaj.Location = new System.Drawing.Point(250, 126);
            this.rodzaj.Name = "rodzaj";
            this.rodzaj.Size = new System.Drawing.Size(137, 20);
            this.rodzaj.TabIndex = 8;
            // 
            // nazwa
            // 
            this.nazwa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nazwa.Location = new System.Drawing.Point(63, 126);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(181, 20);
            this.nazwa.TabIndex = 7;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.konkursBindingSource;
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
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(1004, 25);
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
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
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(212)))), ((int)(((byte)(189)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(449, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Konkursy";
            // 
            // powrotSG
            // 
            this.powrotSG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.powrotSG.Location = new System.Drawing.Point(12, 73);
            this.powrotSG.Name = "powrotSG";
            this.powrotSG.Size = new System.Drawing.Size(147, 23);
            this.powrotSG.TabIndex = 3;
            this.powrotSG.Text = "Powrót do Strony Głównej";
            this.powrotSG.UseVisualStyleBackColor = true;
            this.powrotSG.Click += new System.EventHandler(this.powrotSG_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(977, 390);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDKonkursuDataGridViewTextBoxColumn
            // 
            this.iDKonkursuDataGridViewTextBoxColumn.DataPropertyName = "IDKonkursu";
            this.iDKonkursuDataGridViewTextBoxColumn.HeaderText = "IDKonkursu";
            this.iDKonkursuDataGridViewTextBoxColumn.Name = "iDKonkursuDataGridViewTextBoxColumn";
            this.iDKonkursuDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDKonkursuDataGridViewTextBoxColumn.Width = 88;
            // 
            // nazwaKonkursuDataGridViewTextBoxColumn
            // 
            this.nazwaKonkursuDataGridViewTextBoxColumn.DataPropertyName = "NazwaKonkursu";
            this.nazwaKonkursuDataGridViewTextBoxColumn.HeaderText = "NazwaKonkursu";
            this.nazwaKonkursuDataGridViewTextBoxColumn.Name = "nazwaKonkursuDataGridViewTextBoxColumn";
            this.nazwaKonkursuDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwaKonkursuDataGridViewTextBoxColumn.Width = 110;
            // 
            // rodzajKonkursuDataGridViewTextBoxColumn
            // 
            this.rodzajKonkursuDataGridViewTextBoxColumn.DataPropertyName = "RodzajKonkursu";
            this.rodzajKonkursuDataGridViewTextBoxColumn.HeaderText = "RodzajKonkursu";
            this.rodzajKonkursuDataGridViewTextBoxColumn.Name = "rodzajKonkursuDataGridViewTextBoxColumn";
            this.rodzajKonkursuDataGridViewTextBoxColumn.ReadOnly = true;
            this.rodzajKonkursuDataGridViewTextBoxColumn.Width = 110;
            // 
            // cyklicznoscKonkursuDataGridViewTextBoxColumn
            // 
            this.cyklicznoscKonkursuDataGridViewTextBoxColumn.DataPropertyName = "CyklicznoscKonkursu";
            this.cyklicznoscKonkursuDataGridViewTextBoxColumn.HeaderText = "CyklicznoscKonkursu";
            this.cyklicznoscKonkursuDataGridViewTextBoxColumn.Name = "cyklicznoscKonkursuDataGridViewTextBoxColumn";
            this.cyklicznoscKonkursuDataGridViewTextBoxColumn.ReadOnly = true;
            this.cyklicznoscKonkursuDataGridViewTextBoxColumn.Width = 133;
            // 
            // lokalizacjaKonkursuDataGridViewTextBoxColumn
            // 
            this.lokalizacjaKonkursuDataGridViewTextBoxColumn.DataPropertyName = "LokalizacjaKonkursu";
            this.lokalizacjaKonkursuDataGridViewTextBoxColumn.HeaderText = "LokalizacjaKonkursu";
            this.lokalizacjaKonkursuDataGridViewTextBoxColumn.Name = "lokalizacjaKonkursuDataGridViewTextBoxColumn";
            this.lokalizacjaKonkursuDataGridViewTextBoxColumn.ReadOnly = true;
            this.lokalizacjaKonkursuDataGridViewTextBoxColumn.Width = 130;
            // 
            // zasiegKonkursuDataGridViewTextBoxColumn
            // 
            this.zasiegKonkursuDataGridViewTextBoxColumn.DataPropertyName = "ZasiegKonkursu";
            this.zasiegKonkursuDataGridViewTextBoxColumn.HeaderText = "ZasiegKonkursu";
            this.zasiegKonkursuDataGridViewTextBoxColumn.Name = "zasiegKonkursuDataGridViewTextBoxColumn";
            this.zasiegKonkursuDataGridViewTextBoxColumn.ReadOnly = true;
            this.zasiegKonkursuDataGridViewTextBoxColumn.Width = 109;
            // 
            // organizatorKonkursuDataGridViewTextBoxColumn
            // 
            this.organizatorKonkursuDataGridViewTextBoxColumn.DataPropertyName = "OrganizatorKonkursu";
            this.organizatorKonkursuDataGridViewTextBoxColumn.HeaderText = "OrganizatorKonkursu";
            this.organizatorKonkursuDataGridViewTextBoxColumn.Name = "organizatorKonkursuDataGridViewTextBoxColumn";
            this.organizatorKonkursuDataGridViewTextBoxColumn.ReadOnly = true;
            this.organizatorKonkursuDataGridViewTextBoxColumn.Width = 131;
            // 
            // zalozycielKonkursuDataGridViewTextBoxColumn
            // 
            this.zalozycielKonkursuDataGridViewTextBoxColumn.DataPropertyName = "ZalozycielKonkursu";
            this.zalozycielKonkursuDataGridViewTextBoxColumn.HeaderText = "ZalozycielKonkursu";
            this.zalozycielKonkursuDataGridViewTextBoxColumn.Name = "zalozycielKonkursuDataGridViewTextBoxColumn";
            this.zalozycielKonkursuDataGridViewTextBoxColumn.ReadOnly = true;
            this.zalozycielKonkursuDataGridViewTextBoxColumn.Width = 124;
            // 
            // konkursTableAdapter
            // 
            this.konkursTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 127);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "ID";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Konkursy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 563);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1020, 602);
            this.Name = "Konkursy";
            this.Text = "Konkursy";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Konkursy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.konkursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaKonkursowDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyklicznosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private BazaKonkursowDataSetTableAdapters.KonkursTableAdapter konkursTableAdapter;
        private System.Windows.Forms.NumericUpDown cyklicznosc;
        private System.Windows.Forms.TextBox lokalizacja;
        private System.Windows.Forms.TextBox rodzaj;
        private System.Windows.Forms.TextBox nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cyklicznoscKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokalizacjaKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zasiegKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizatorKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zalozycielKonkursuDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox zalozyciel;
        private System.Windows.Forms.TextBox organizator;
        private System.Windows.Forms.TextBox zasieg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}