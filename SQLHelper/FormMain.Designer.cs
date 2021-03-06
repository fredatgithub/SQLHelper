﻿namespace SQLHelper
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.textBoxSource = new System.Windows.Forms.TextBox();
      this.listBoxToDeploy = new System.Windows.Forms.ListBox();
      this.listBoxAvailable = new System.Windows.Forms.ListBox();
      this.buttonMoveToAvailable = new System.Windows.Forms.Button();
      this.buttonMoveToDeploy = new System.Windows.Forms.Button();
      this.buttonGenerate = new System.Windows.Forms.Button();
      this.textBoxResult = new System.Windows.Forms.TextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.enregistrersousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aperçuavantimpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.sélectionnertoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personnaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sommaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonAddToAvailable = new System.Windows.Forms.Button();
      this.textBoxAvailable = new System.Windows.Forms.TextBox();
      this.labelCountDeploy = new System.Windows.Forms.Label();
      this.labelCountAvailable = new System.Windows.Forms.Label();
      this.buttonClear = new System.Windows.Forms.Button();
      this.buttonDelete = new System.Windows.Forms.Button();
      this.labelExplanation = new System.Windows.Forms.Label();
      this.labelExplanation2 = new System.Windows.Forms.Label();
      this.labelToDeploy = new System.Windows.Forms.Label();
      this.labelListServerAvailable = new System.Windows.Forms.Label();
      this.buttonSelectAll = new System.Windows.Forms.Button();
      this.buttonUnselectAll = new System.Windows.Forms.Button();
      this.buttonCopyToClipBoard = new System.Windows.Forms.Button();
      this.buttonDeployUnselectAll = new System.Windows.Forms.Button();
      this.buttonDeploySelectAll = new System.Windows.Forms.Button();
      this.buttonDeployDelete = new System.Windows.Forms.Button();
      this.buttonDeployClear = new System.Windows.Forms.Button();
      this.progressBarMain = new System.Windows.Forms.ProgressBar();
      this.buttonClearResult = new System.Windows.Forms.Button();
      this.buttonSaveToFile = new System.Windows.Forms.Button();
      this.checkBoxRemoveComments = new System.Windows.Forms.CheckBox();
      this.buttonReloadFile = new System.Windows.Forms.Button();
      this.checkBoxAddGo = new System.Windows.Forms.CheckBox();
      this.checkBoxRemoveEmptyLine = new System.Windows.Forms.CheckBox();
      this.checkBoxDisablePopUp = new System.Windows.Forms.CheckBox();
      this.labelAddDBNameTemplate = new System.Windows.Forms.Label();
      this.comboBoxDbNameTemplate = new System.Windows.Forms.ComboBox();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxSource
      // 
      this.textBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxSource.Location = new System.Drawing.Point(27, 92);
      this.textBoxSource.Multiline = true;
      this.textBoxSource.Name = "textBoxSource";
      this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxSource.Size = new System.Drawing.Size(353, 136);
      this.textBoxSource.TabIndex = 0;
      this.textBoxSource.TextChanged += new System.EventHandler(this.TextBoxSource_TextChanged);
      // 
      // listBoxToDeploy
      // 
      this.listBoxToDeploy.FormattingEnabled = true;
      this.listBoxToDeploy.Location = new System.Drawing.Point(501, 63);
      this.listBoxToDeploy.Name = "listBoxToDeploy";
      this.listBoxToDeploy.ScrollAlwaysVisible = true;
      this.listBoxToDeploy.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.listBoxToDeploy.Size = new System.Drawing.Size(159, 160);
      this.listBoxToDeploy.TabIndex = 1;
      this.listBoxToDeploy.SelectedIndexChanged += new System.EventHandler(this.ListBoxToDeploy_SelectedIndexChanged);
      this.listBoxToDeploy.SizeChanged += new System.EventHandler(this.ListBoxToDeploy_SizeChanged);
      // 
      // listBoxAvailable
      // 
      this.listBoxAvailable.FormattingEnabled = true;
      this.listBoxAvailable.Location = new System.Drawing.Point(783, 89);
      this.listBoxAvailable.Name = "listBoxAvailable";
      this.listBoxAvailable.ScrollAlwaysVisible = true;
      this.listBoxAvailable.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.listBoxAvailable.Size = new System.Drawing.Size(159, 134);
      this.listBoxAvailable.TabIndex = 2;
      this.listBoxAvailable.SelectedIndexChanged += new System.EventHandler(this.ListBoxAvailable_SelectedIndexChanged);
      this.listBoxAvailable.SizeChanged += new System.EventHandler(this.ListBoxAvailable_SizeChanged);
      // 
      // buttonMoveToAvailable
      // 
      this.buttonMoveToAvailable.Location = new System.Drawing.Point(688, 87);
      this.buttonMoveToAvailable.Name = "buttonMoveToAvailable";
      this.buttonMoveToAvailable.Size = new System.Drawing.Size(75, 23);
      this.buttonMoveToAvailable.TabIndex = 3;
      this.buttonMoveToAvailable.Text = "Move -->";
      this.buttonMoveToAvailable.UseVisualStyleBackColor = true;
      this.buttonMoveToAvailable.Click += new System.EventHandler(this.ButtonMoveToAvailable_Click);
      // 
      // buttonMoveToDeploy
      // 
      this.buttonMoveToDeploy.Location = new System.Drawing.Point(688, 162);
      this.buttonMoveToDeploy.Name = "buttonMoveToDeploy";
      this.buttonMoveToDeploy.Size = new System.Drawing.Size(75, 23);
      this.buttonMoveToDeploy.TabIndex = 4;
      this.buttonMoveToDeploy.Text = "<-- Move";
      this.buttonMoveToDeploy.UseVisualStyleBackColor = true;
      this.buttonMoveToDeploy.Click += new System.EventHandler(this.ButtonMoveToDeploy_Click);
      // 
      // buttonGenerate
      // 
      this.buttonGenerate.Location = new System.Drawing.Point(124, 251);
      this.buttonGenerate.Name = "buttonGenerate";
      this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
      this.buttonGenerate.TabIndex = 5;
      this.buttonGenerate.Text = "Generate";
      this.buttonGenerate.UseVisualStyleBackColor = true;
      this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
      // 
      // textBoxResult
      // 
      this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxResult.Location = new System.Drawing.Point(27, 313);
      this.textBoxResult.Multiline = true;
      this.textBoxResult.Name = "textBoxResult";
      this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxResult.Size = new System.Drawing.Size(1026, 219);
      this.textBoxResult.TabIndex = 6;
      this.textBoxResult.Text = "Script generated";
      this.textBoxResult.TextChanged += new System.EventHandler(this.TextBoxResult_TextChanged);
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
      this.menuStrip1.TabIndex = 7;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator,
            this.enregistrerToolStripMenuItem,
            this.enregistrersousToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimerToolStripMenuItem,
            this.aperçuavantimpressionToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // nouveauToolStripMenuItem
      // 
      this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
      this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
      this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.nouveauToolStripMenuItem.Text = "&Nouveau";
      this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.NouveauToolStripMenuItem_Click);
      // 
      // ouvrirToolStripMenuItem
      // 
      this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
      this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
      this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
      this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.OuvrirToolStripMenuItem_Click);
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
      // 
      // enregistrerToolStripMenuItem
      // 
      this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
      this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
      this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
      this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.EnregistrerToolStripMenuItem_Click);
      // 
      // enregistrersousToolStripMenuItem
      // 
      this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
      this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
      this.enregistrersousToolStripMenuItem.Click += new System.EventHandler(this.EnregistrersousToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
      // 
      // imprimerToolStripMenuItem
      // 
      this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
      this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
      this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.imprimerToolStripMenuItem.Text = "&Imprimer";
      // 
      // aperçuavantimpressionToolStripMenuItem
      // 
      this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
      this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
      this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.quitterToolStripMenuItem.Text = "&Quitter";
      this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
      // 
      // editionToolStripMenuItem
      // 
      this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem,
            this.toolStripSeparator3,
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.toolStripSeparator4,
            this.sélectionnertoutToolStripMenuItem});
      this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
      this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.editionToolStripMenuItem.Text = "&Edition";
      // 
      // annulerToolStripMenuItem
      // 
      this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
      this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.annulerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.annulerToolStripMenuItem.Text = "&Annuler";
      // 
      // rétablirToolStripMenuItem
      // 
      this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
      this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.rétablirToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
      // 
      // couperToolStripMenuItem
      // 
      this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
      this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
      this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.couperToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.couperToolStripMenuItem.Text = "&Couper";
      this.couperToolStripMenuItem.Click += new System.EventHandler(this.CouperToolStripMenuItem_Click);
      // 
      // copierToolStripMenuItem
      // 
      this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
      this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
      this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copierToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.copierToolStripMenuItem.Text = "Co&pier";
      this.copierToolStripMenuItem.Click += new System.EventHandler(this.CopierToolStripMenuItem_Click);
      // 
      // collerToolStripMenuItem
      // 
      this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
      this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
      this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.collerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.collerToolStripMenuItem.Text = "Co&ller";
      this.collerToolStripMenuItem.Click += new System.EventHandler(this.CollerToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
      // 
      // sélectionnertoutToolStripMenuItem
      // 
      this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
      this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
      this.sélectionnertoutToolStripMenuItem.Click += new System.EventHandler(this.SelectionnertoutToolStripMenuItem_Click);
      // 
      // outilsToolStripMenuItem
      // 
      this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
      this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.outilsToolStripMenuItem.Text = "&Outils";
      // 
      // personnaliserToolStripMenuItem
      // 
      this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
      this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // aideToolStripMenuItem
      // 
      this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommaireToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.toolStripSeparator5,
            this.àproposdeToolStripMenuItem});
      this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.aideToolStripMenuItem.Text = "&Aide";
      // 
      // sommaireToolStripMenuItem
      // 
      this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
      this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.sommaireToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // rechercherToolStripMenuItem
      // 
      this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
      this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.rechercherToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
      // 
      // àproposdeToolStripMenuItem
      // 
      this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
      this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.àproposdeToolStripMenuItem.Text = "À &propos de...";
      this.àproposdeToolStripMenuItem.Click += new System.EventHandler(this.ÀproposdeToolStripMenuItem_Click);
      // 
      // buttonAddToAvailable
      // 
      this.buttonAddToAvailable.Location = new System.Drawing.Point(688, 27);
      this.buttonAddToAvailable.Name = "buttonAddToAvailable";
      this.buttonAddToAvailable.Size = new System.Drawing.Size(75, 23);
      this.buttonAddToAvailable.TabIndex = 8;
      this.buttonAddToAvailable.Text = "Add";
      this.buttonAddToAvailable.UseVisualStyleBackColor = true;
      this.buttonAddToAvailable.Click += new System.EventHandler(this.ButtonAddToAvailable_Click);
      // 
      // textBoxAvailable
      // 
      this.textBoxAvailable.Location = new System.Drawing.Point(783, 29);
      this.textBoxAvailable.Name = "textBoxAvailable";
      this.textBoxAvailable.Size = new System.Drawing.Size(159, 20);
      this.textBoxAvailable.TabIndex = 9;
      this.textBoxAvailable.Text = "server123";
      this.textBoxAvailable.TextChanged += new System.EventHandler(this.TextBoxAvailable_TextChanged);
      // 
      // labelCountDeploy
      // 
      this.labelCountDeploy.AutoSize = true;
      this.labelCountDeploy.Location = new System.Drawing.Point(501, 230);
      this.labelCountDeploy.Name = "labelCountDeploy";
      this.labelCountDeploy.Size = new System.Drawing.Size(47, 13);
      this.labelCountDeploy.TabIndex = 10;
      this.labelCountDeploy.Text = "Count: 0";
      // 
      // labelCountAvailable
      // 
      this.labelCountAvailable.AutoSize = true;
      this.labelCountAvailable.Location = new System.Drawing.Point(780, 230);
      this.labelCountAvailable.Name = "labelCountAvailable";
      this.labelCountAvailable.Size = new System.Drawing.Size(47, 13);
      this.labelCountAvailable.TabIndex = 11;
      this.labelCountAvailable.Text = "Count: 0";
      // 
      // buttonClear
      // 
      this.buttonClear.Location = new System.Drawing.Point(961, 87);
      this.buttonClear.Name = "buttonClear";
      this.buttonClear.Size = new System.Drawing.Size(75, 23);
      this.buttonClear.TabIndex = 12;
      this.buttonClear.Text = "<-- Clear";
      this.buttonClear.UseVisualStyleBackColor = true;
      this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
      // 
      // buttonDelete
      // 
      this.buttonDelete.Location = new System.Drawing.Point(961, 116);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(75, 23);
      this.buttonDelete.TabIndex = 13;
      this.buttonDelete.Text = "<--Delete ";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
      // 
      // labelExplanation
      // 
      this.labelExplanation.AutoSize = true;
      this.labelExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelExplanation.Location = new System.Drawing.Point(225, 257);
      this.labelExplanation.Name = "labelExplanation";
      this.labelExplanation.Size = new System.Drawing.Size(329, 13);
      this.labelExplanation.TabIndex = 14;
      this.labelExplanation.Text = "Replace %%ServerName%% for each server in the listbox";
      // 
      // labelExplanation2
      // 
      this.labelExplanation2.AutoSize = true;
      this.labelExplanation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelExplanation2.Location = new System.Drawing.Point(24, 37);
      this.labelExplanation2.Name = "labelExplanation2";
      this.labelExplanation2.Size = new System.Drawing.Size(329, 13);
      this.labelExplanation2.TabIndex = 15;
      this.labelExplanation2.Text = "Replace %%ServerName%% for each server in the listbox";
      // 
      // labelToDeploy
      // 
      this.labelToDeploy.AutoSize = true;
      this.labelToDeploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelToDeploy.Location = new System.Drawing.Point(501, 36);
      this.labelToDeploy.Name = "labelToDeploy";
      this.labelToDeploy.Size = new System.Drawing.Size(137, 13);
      this.labelToDeploy.TabIndex = 16;
      this.labelToDeploy.Text = "List of servers to insert";
      // 
      // labelListServerAvailable
      // 
      this.labelListServerAvailable.AutoSize = true;
      this.labelListServerAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelListServerAvailable.Location = new System.Drawing.Point(780, 63);
      this.labelListServerAvailable.Name = "labelListServerAvailable";
      this.labelListServerAvailable.Size = new System.Drawing.Size(142, 13);
      this.labelListServerAvailable.TabIndex = 17;
      this.labelListServerAvailable.Text = "List of servers available";
      // 
      // buttonSelectAll
      // 
      this.buttonSelectAll.Location = new System.Drawing.Point(961, 145);
      this.buttonSelectAll.Name = "buttonSelectAll";
      this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
      this.buttonSelectAll.TabIndex = 18;
      this.buttonSelectAll.Text = "Select All";
      this.buttonSelectAll.UseVisualStyleBackColor = true;
      this.buttonSelectAll.Click += new System.EventHandler(this.ButtonSelectAll_Click);
      // 
      // buttonUnselectAll
      // 
      this.buttonUnselectAll.Location = new System.Drawing.Point(961, 174);
      this.buttonUnselectAll.Name = "buttonUnselectAll";
      this.buttonUnselectAll.Size = new System.Drawing.Size(75, 23);
      this.buttonUnselectAll.TabIndex = 19;
      this.buttonUnselectAll.Text = "Unselect All";
      this.buttonUnselectAll.UseVisualStyleBackColor = true;
      this.buttonUnselectAll.Click += new System.EventHandler(this.ButtonUnselectAll_Click);
      // 
      // buttonCopyToClipBoard
      // 
      this.buttonCopyToClipBoard.Location = new System.Drawing.Point(601, 251);
      this.buttonCopyToClipBoard.Name = "buttonCopyToClipBoard";
      this.buttonCopyToClipBoard.Size = new System.Drawing.Size(125, 23);
      this.buttonCopyToClipBoard.TabIndex = 20;
      this.buttonCopyToClipBoard.Text = "Copy to clipboard";
      this.buttonCopyToClipBoard.UseVisualStyleBackColor = true;
      this.buttonCopyToClipBoard.Click += new System.EventHandler(this.ButtonCopyToClipBoard_Click);
      // 
      // buttonDeployUnselectAll
      // 
      this.buttonDeployUnselectAll.Location = new System.Drawing.Point(408, 150);
      this.buttonDeployUnselectAll.Name = "buttonDeployUnselectAll";
      this.buttonDeployUnselectAll.Size = new System.Drawing.Size(75, 23);
      this.buttonDeployUnselectAll.TabIndex = 24;
      this.buttonDeployUnselectAll.Text = "Unselect All";
      this.buttonDeployUnselectAll.UseVisualStyleBackColor = true;
      this.buttonDeployUnselectAll.Click += new System.EventHandler(this.ButtonDeployUnselectAll_Click);
      // 
      // buttonDeploySelectAll
      // 
      this.buttonDeploySelectAll.Location = new System.Drawing.Point(408, 121);
      this.buttonDeploySelectAll.Name = "buttonDeploySelectAll";
      this.buttonDeploySelectAll.Size = new System.Drawing.Size(75, 23);
      this.buttonDeploySelectAll.TabIndex = 23;
      this.buttonDeploySelectAll.Text = "Select All";
      this.buttonDeploySelectAll.UseVisualStyleBackColor = true;
      this.buttonDeploySelectAll.Click += new System.EventHandler(this.ButtonDeploySelectAll_Click);
      // 
      // buttonDeployDelete
      // 
      this.buttonDeployDelete.Location = new System.Drawing.Point(408, 92);
      this.buttonDeployDelete.Name = "buttonDeployDelete";
      this.buttonDeployDelete.Size = new System.Drawing.Size(75, 23);
      this.buttonDeployDelete.TabIndex = 22;
      this.buttonDeployDelete.Text = "Delete -->";
      this.buttonDeployDelete.UseVisualStyleBackColor = true;
      this.buttonDeployDelete.Click += new System.EventHandler(this.ButtonDeployDelete_Click);
      // 
      // buttonDeployClear
      // 
      this.buttonDeployClear.Location = new System.Drawing.Point(408, 63);
      this.buttonDeployClear.Name = "buttonDeployClear";
      this.buttonDeployClear.Size = new System.Drawing.Size(75, 23);
      this.buttonDeployClear.TabIndex = 21;
      this.buttonDeployClear.Text = "Clear -->";
      this.buttonDeployClear.UseVisualStyleBackColor = true;
      this.buttonDeployClear.Click += new System.EventHandler(this.ButtonDeployClear_Click);
      // 
      // progressBarMain
      // 
      this.progressBarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.progressBarMain.Location = new System.Drawing.Point(0, 553);
      this.progressBarMain.Name = "progressBarMain";
      this.progressBarMain.Size = new System.Drawing.Size(1065, 23);
      this.progressBarMain.TabIndex = 25;
      // 
      // buttonClearResult
      // 
      this.buttonClearResult.Location = new System.Drawing.Point(27, 251);
      this.buttonClearResult.Name = "buttonClearResult";
      this.buttonClearResult.Size = new System.Drawing.Size(75, 23);
      this.buttonClearResult.TabIndex = 26;
      this.buttonClearResult.Text = "Clear";
      this.buttonClearResult.UseVisualStyleBackColor = true;
      this.buttonClearResult.Click += new System.EventHandler(this.ButtonClearResult_Click);
      // 
      // buttonSaveToFile
      // 
      this.buttonSaveToFile.Location = new System.Drawing.Point(783, 252);
      this.buttonSaveToFile.Name = "buttonSaveToFile";
      this.buttonSaveToFile.Size = new System.Drawing.Size(125, 23);
      this.buttonSaveToFile.TabIndex = 27;
      this.buttonSaveToFile.Text = "Save to File";
      this.buttonSaveToFile.UseVisualStyleBackColor = true;
      this.buttonSaveToFile.Click += new System.EventHandler(this.ButtonSaveToFile_Click);
      // 
      // checkBoxRemoveComments
      // 
      this.checkBoxRemoveComments.AutoSize = true;
      this.checkBoxRemoveComments.Location = new System.Drawing.Point(27, 286);
      this.checkBoxRemoveComments.Name = "checkBoxRemoveComments";
      this.checkBoxRemoveComments.Size = new System.Drawing.Size(117, 17);
      this.checkBoxRemoveComments.TabIndex = 28;
      this.checkBoxRemoveComments.Text = "Remove comments";
      this.checkBoxRemoveComments.UseVisualStyleBackColor = true;
      this.checkBoxRemoveComments.CheckedChanged += new System.EventHandler(this.CheckBoxRemoveComments_CheckedChanged);
      // 
      // buttonReloadFile
      // 
      this.buttonReloadFile.Location = new System.Drawing.Point(961, 205);
      this.buttonReloadFile.Name = "buttonReloadFile";
      this.buttonReloadFile.Size = new System.Drawing.Size(75, 23);
      this.buttonReloadFile.TabIndex = 29;
      this.buttonReloadFile.Text = "Reload File";
      this.buttonReloadFile.UseVisualStyleBackColor = true;
      this.buttonReloadFile.Click += new System.EventHandler(this.ButtonReloadFile_Click);
      // 
      // checkBoxAddGo
      // 
      this.checkBoxAddGo.AutoSize = true;
      this.checkBoxAddGo.Location = new System.Drawing.Point(150, 286);
      this.checkBoxAddGo.Name = "checkBoxAddGo";
      this.checkBoxAddGo.Size = new System.Drawing.Size(115, 17);
      this.checkBoxAddGo.TabIndex = 30;
      this.checkBoxAddGo.Text = "Add GO at the end";
      this.checkBoxAddGo.UseVisualStyleBackColor = true;
      this.checkBoxAddGo.CheckedChanged += new System.EventHandler(this.CheckBoxAddGo_CheckedChanged);
      // 
      // checkBoxRemoveEmptyLine
      // 
      this.checkBoxRemoveEmptyLine.AutoSize = true;
      this.checkBoxRemoveEmptyLine.Location = new System.Drawing.Point(271, 286);
      this.checkBoxRemoveEmptyLine.Name = "checkBoxRemoveEmptyLine";
      this.checkBoxRemoveEmptyLine.Size = new System.Drawing.Size(121, 17);
      this.checkBoxRemoveEmptyLine.TabIndex = 31;
      this.checkBoxRemoveEmptyLine.Text = "Remove Empty Line";
      this.checkBoxRemoveEmptyLine.UseVisualStyleBackColor = true;
      this.checkBoxRemoveEmptyLine.CheckedChanged += new System.EventHandler(this.CheckBoxRemoveEmptyLine_CheckedChanged);
      // 
      // checkBoxDisablePopUp
      // 
      this.checkBoxDisablePopUp.AutoSize = true;
      this.checkBoxDisablePopUp.Location = new System.Drawing.Point(398, 286);
      this.checkBoxDisablePopUp.Name = "checkBoxDisablePopUp";
      this.checkBoxDisablePopUp.Size = new System.Drawing.Size(98, 17);
      this.checkBoxDisablePopUp.TabIndex = 32;
      this.checkBoxDisablePopUp.Text = "Disable Pop-up";
      this.checkBoxDisablePopUp.UseVisualStyleBackColor = true;
      this.checkBoxDisablePopUp.CheckedChanged += new System.EventHandler(this.CheckBoxDisablePopUp_CheckedChanged);
      // 
      // labelAddDBNameTemplate
      // 
      this.labelAddDBNameTemplate.AutoSize = true;
      this.labelAddDBNameTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelAddDBNameTemplate.Location = new System.Drawing.Point(24, 63);
      this.labelAddDBNameTemplate.Name = "labelAddDBNameTemplate";
      this.labelAddDBNameTemplate.Size = new System.Drawing.Size(175, 13);
      this.labelAddDBNameTemplate.TabIndex = 33;
      this.labelAddDBNameTemplate.Text = "Add Database Name template";
      // 
      // comboBoxDbNameTemplate
      // 
      this.comboBoxDbNameTemplate.FormattingEnabled = true;
      this.comboBoxDbNameTemplate.Location = new System.Drawing.Point(214, 59);
      this.comboBoxDbNameTemplate.Name = "comboBoxDbNameTemplate";
      this.comboBoxDbNameTemplate.Size = new System.Drawing.Size(166, 21);
      this.comboBoxDbNameTemplate.TabIndex = 34;
      this.comboBoxDbNameTemplate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDbNameTemplate_SelectedIndexChanged);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(1065, 576);
      this.Controls.Add(this.comboBoxDbNameTemplate);
      this.Controls.Add(this.labelAddDBNameTemplate);
      this.Controls.Add(this.checkBoxDisablePopUp);
      this.Controls.Add(this.checkBoxRemoveEmptyLine);
      this.Controls.Add(this.checkBoxAddGo);
      this.Controls.Add(this.buttonReloadFile);
      this.Controls.Add(this.checkBoxRemoveComments);
      this.Controls.Add(this.buttonSaveToFile);
      this.Controls.Add(this.buttonClearResult);
      this.Controls.Add(this.progressBarMain);
      this.Controls.Add(this.buttonDeployUnselectAll);
      this.Controls.Add(this.buttonDeploySelectAll);
      this.Controls.Add(this.buttonDeployDelete);
      this.Controls.Add(this.buttonDeployClear);
      this.Controls.Add(this.buttonCopyToClipBoard);
      this.Controls.Add(this.buttonUnselectAll);
      this.Controls.Add(this.buttonSelectAll);
      this.Controls.Add(this.labelListServerAvailable);
      this.Controls.Add(this.labelToDeploy);
      this.Controls.Add(this.labelExplanation2);
      this.Controls.Add(this.labelExplanation);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.buttonClear);
      this.Controls.Add(this.labelCountAvailable);
      this.Controls.Add(this.labelCountDeploy);
      this.Controls.Add(this.textBoxAvailable);
      this.Controls.Add(this.buttonAddToAvailable);
      this.Controls.Add(this.textBoxResult);
      this.Controls.Add(this.buttonGenerate);
      this.Controls.Add(this.buttonMoveToDeploy);
      this.Controls.Add(this.buttonMoveToAvailable);
      this.Controls.Add(this.listBoxAvailable);
      this.Controls.Add(this.listBoxToDeploy);
      this.Controls.Add(this.textBoxSource);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormMain";
      this.Text = "SQL Helper";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.ListBox listBoxToDeploy;
        private System.Windows.Forms.ListBox listBoxAvailable;
        private System.Windows.Forms.Button buttonMoveToAvailable;
        private System.Windows.Forms.Button buttonMoveToDeploy;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aperçuavantimpressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sélectionnertoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnaliserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sommaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddToAvailable;
        private System.Windows.Forms.TextBox textBoxAvailable;
        private System.Windows.Forms.Label labelCountDeploy;
        private System.Windows.Forms.Label labelCountAvailable;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.Label labelExplanation2;
        private System.Windows.Forms.Label labelToDeploy;
        private System.Windows.Forms.Label labelListServerAvailable;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonUnselectAll;
        private System.Windows.Forms.Button buttonCopyToClipBoard;
        private System.Windows.Forms.Button buttonDeployUnselectAll;
        private System.Windows.Forms.Button buttonDeploySelectAll;
        private System.Windows.Forms.Button buttonDeployDelete;
        private System.Windows.Forms.Button buttonDeployClear;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Button buttonClearResult;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.CheckBox checkBoxRemoveComments;
        private System.Windows.Forms.Button buttonReloadFile;
        private System.Windows.Forms.CheckBox checkBoxAddGo;
        private System.Windows.Forms.CheckBox checkBoxRemoveEmptyLine;
        private System.Windows.Forms.CheckBox checkBoxDisablePopUp;
    private System.Windows.Forms.Label labelAddDBNameTemplate;
    private System.Windows.Forms.ComboBox comboBoxDbNameTemplate;
  }
}

