﻿namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawPointSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawLineSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawPolygonSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawCircleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.colorSelectPickBtn = new System.Windows.Forms.ToolStripButton();
            this.fillColorChangeBtn = new System.Windows.Forms.ToolStripButton();
            this.selectedShapesColor = new System.Windows.Forms.ToolStripButton();
            this.OpacityPicker = new System.Windows.Forms.ToolStripComboBox();
            this.changeBorderWidth = new System.Windows.Forms.ToolStripLabel();
            this.triangleButton = new System.Windows.Forms.ToolStripButton();
            this.colorSelectDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fillColorSelectDialog = new System.Windows.Forms.ColorDialog();
            this.selectedShapesColorDialog = new System.Windows.Forms.ColorDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.extraMenu = new System.Windows.Forms.ToolStrip();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.groupButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.extraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(924, 30);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.loadFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedToolStripMenuItem,
            this.copySelectedToolStripMenuItem,
            this.pasteSelectedToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.resizeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.deleteSelectedToolStripMenuItem.Text = "Delete Selected";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem_Click);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.copySelectedToolStripMenuItem.Text = "Copy Selected";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.copySelectedToolStripMenuItem_Click);
            // 
            // pasteSelectedToolStripMenuItem
            // 
            this.pasteSelectedToolStripMenuItem.Name = "pasteSelectedToolStripMenuItem";
            this.pasteSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteSelectedToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.pasteSelectedToolStripMenuItem.Text = "Paste Selected";
            this.pasteSelectedToolStripMenuItem.Click += new System.EventHandler(this.pasteSelectedToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.rotateToolStripMenuItem.Text = "Rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.resizeToolStripMenuItem.Text = "Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.selectAllShapesToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.pointToolStripMenuItem,
            this.triangleToolStripMenuItem});
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.createNewToolStripMenuItem.Text = "Create New";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.pointToolStripMenuItem.Text = "Point";
            this.pointToolStripMenuItem.Click += new System.EventHandler(this.pointToolStripMenuItem_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // selectAllShapesToolStripMenuItem
            // 
            this.selectAllShapesToolStripMenuItem.Name = "selectAllShapesToolStripMenuItem";
            this.selectAllShapesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllShapesToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.selectAllShapesToolStripMenuItem.Text = "Select All Shapes";
            this.selectAllShapesToolStripMenuItem.Click += new System.EventHandler(this.selectAllShapesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 499);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(924, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawRectangleSpeedButton,
            this.pickUpSpeedButton,
            this.drawEllipseSpeedButton,
            this.DrawPointSpeedButton,
            this.drawLineSpeedButton,
            this.drawPolygonSpeedButton,
            this.drawCircleSpeedButton,
            this.colorSelectPickBtn,
            this.fillColorChangeBtn,
            this.selectedShapesColor,
            this.OpacityPicker,
            this.changeBorderWidth,
            this.triangleButton});
            this.speedMenu.Location = new System.Drawing.Point(0, 30);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(924, 31);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            this.speedMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.speedMenu_ItemClicked);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawRectangleSpeedButton.Text = "Draw a Rectangle";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.pickUpSpeedButton.Text = "Select";
            // 
            // drawEllipseSpeedButton
            // 
            this.drawEllipseSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseSpeedButton.Image")));
            this.drawEllipseSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseSpeedButton.Name = "drawEllipseSpeedButton";
            this.drawEllipseSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawEllipseSpeedButton.Text = "Draw an Ellipse";
            this.drawEllipseSpeedButton.Click += new System.EventHandler(this.drawEllipseSpeedButton_Click);
            // 
            // DrawPointSpeedButton
            // 
            this.DrawPointSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawPointSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawPointSpeedButton.Image")));
            this.DrawPointSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawPointSpeedButton.Name = "DrawPointSpeedButton";
            this.DrawPointSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.DrawPointSpeedButton.Text = "Draw a Point";
            this.DrawPointSpeedButton.Click += new System.EventHandler(this.DrawPointSpeedButton_Click);
            // 
            // drawLineSpeedButton
            // 
            this.drawLineSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawLineSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawLineSpeedButton.Image")));
            this.drawLineSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawLineSpeedButton.Name = "drawLineSpeedButton";
            this.drawLineSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawLineSpeedButton.Text = "Draw a Line";
            this.drawLineSpeedButton.Click += new System.EventHandler(this.drawLineSpeedButton_Click);
            // 
            // drawPolygonSpeedButton
            // 
            this.drawPolygonSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPolygonSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawPolygonSpeedButton.Image")));
            this.drawPolygonSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPolygonSpeedButton.Name = "drawPolygonSpeedButton";
            this.drawPolygonSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawPolygonSpeedButton.Text = "Draw a Polygon";
            this.drawPolygonSpeedButton.Click += new System.EventHandler(this.drawPolygonSpeedButton_Click);
            // 
            // drawCircleSpeedButton
            // 
            this.drawCircleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircleSpeedButton.Image = global::Draw.Properties.Resources.circlePngSpeed;
            this.drawCircleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircleSpeedButton.Name = "drawCircleSpeedButton";
            this.drawCircleSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawCircleSpeedButton.Text = "Draw a Circle";
            this.drawCircleSpeedButton.Click += new System.EventHandler(this.drawCircleSpeedButton_Click);
            // 
            // colorSelectPickBtn
            // 
            this.colorSelectPickBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorSelectPickBtn.Image = global::Draw.Properties.Resources.StrokeColorChange;
            this.colorSelectPickBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorSelectPickBtn.Name = "colorSelectPickBtn";
            this.colorSelectPickBtn.Size = new System.Drawing.Size(29, 28);
            this.colorSelectPickBtn.Text = "Pick a stroke color";
            this.colorSelectPickBtn.Click += new System.EventHandler(this.colorSelectPickBtn_Click);
            // 
            // fillColorChangeBtn
            // 
            this.fillColorChangeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillColorChangeBtn.Image = global::Draw.Properties.Resources.FillColorChange;
            this.fillColorChangeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColorChangeBtn.Name = "fillColorChangeBtn";
            this.fillColorChangeBtn.Size = new System.Drawing.Size(29, 28);
            this.fillColorChangeBtn.Text = "Pick Fill Color";
            this.fillColorChangeBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // selectedShapesColor
            // 
            this.selectedShapesColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectedShapesColor.Image = global::Draw.Properties.Resources.SelectedShapeColorIcon;
            this.selectedShapesColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectedShapesColor.Name = "selectedShapesColor";
            this.selectedShapesColor.Size = new System.Drawing.Size(29, 28);
            this.selectedShapesColor.Text = "Selected Shapes Color";
            this.selectedShapesColor.Click += new System.EventHandler(this.selectedShapesColor_Click);
            // 
            // OpacityPicker
            // 
            this.OpacityPicker.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OpacityPicker.Items.AddRange(new object[] {
            "Transparent",
            "Not transparent"});
            this.OpacityPicker.Name = "OpacityPicker";
            this.OpacityPicker.Size = new System.Drawing.Size(145, 31);
            this.OpacityPicker.Text = "Opacity";
            this.OpacityPicker.ToolTipText = "Opacity";
            this.OpacityPicker.SelectedIndexChanged += new System.EventHandler(this.OpacityPicker_SelectedIndexChanged);
            this.OpacityPicker.Click += new System.EventHandler(this.OpacityPicker_Click);
            // 
            // changeBorderWidth
            // 
            this.changeBorderWidth.ActiveLinkColor = System.Drawing.Color.Black;
            this.changeBorderWidth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeBorderWidth.BackgroundImage = global::Draw.Properties.Resources.circlePngSpeed;
            this.changeBorderWidth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.changeBorderWidth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBorderWidth.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.changeBorderWidth.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.changeBorderWidth.Name = "changeBorderWidth";
            this.changeBorderWidth.Size = new System.Drawing.Size(185, 28);
            this.changeBorderWidth.Text = "Change Border Width";
            this.changeBorderWidth.Click += new System.EventHandler(this.changeBorderWidth_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.triangleButton.Image = global::Draw.Properties.Resources.TriangleImg;
            this.triangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(29, 28);
            this.triangleButton.Text = "tringleBtn";
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // extraMenu
            // 
            this.extraMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.extraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBtn,
            this.groupButton,
            this.toolStripButton1,
            this.toolStripButton2});
            this.extraMenu.Location = new System.Drawing.Point(0, 61);
            this.extraMenu.Name = "extraMenu";
            this.extraMenu.Size = new System.Drawing.Size(924, 31);
            this.extraMenu.TabIndex = 5;
            this.extraMenu.Text = "extraMenu";
            // 
            // deleteBtn
            // 
            this.deleteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteBtn.Image = global::Draw.Properties.Resources.DeleteBtnImage;
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(29, 28);
            this.deleteBtn.Text = "Delete Selected Shapes";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // groupButton
            // 
            this.groupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupButton.Image = global::Draw.Properties.Resources.GroupImg;
            this.groupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(29, 28);
            this.groupButton.Text = "Group Shapes";
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Draw.Properties.Resources.UnGroupImg;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "UnGroup Selected Shape";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Draw.Properties.Resources.RotateBtn;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "RotateShape";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 61);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(924, 438);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.extraMenu);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.extraMenu.ResumeLayout(false);
            this.extraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton drawEllipseSpeedButton;
        private System.Windows.Forms.ToolStripButton DrawPointSpeedButton;
        private System.Windows.Forms.ToolStripButton drawLineSpeedButton;
        private System.Windows.Forms.ToolStripButton drawPolygonSpeedButton;
        private System.Windows.Forms.ToolStripButton drawCircleSpeedButton;
        private System.Windows.Forms.ToolStripButton colorSelectPickBtn;
        private System.Windows.Forms.ColorDialog colorSelectDialog;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton fillColorChangeBtn;
        private System.Windows.Forms.ToolStripButton selectedShapesColor;
        private System.Windows.Forms.ColorDialog fillColorSelectDialog;
        private System.Windows.Forms.ToolStripComboBox OpacityPicker;
        private System.Windows.Forms.ColorDialog selectedShapesColorDialog;
        private System.Windows.Forms.ToolStripLabel changeBorderWidth;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip extraMenu;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton groupButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton triangleButton;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
    }
}
