namespace TESOAR_MARK2.SERVER
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultsServer = new System.Windows.Forms.TextBox();
            this.Toolbar = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.startServerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseServerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manualMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblClientNumberConected = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.Toolbar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.resultsServer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 402);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Servidor";
            // 
            // resultsServer
            // 
            this.resultsServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultsServer.Enabled = false;
            this.resultsServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsServer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.resultsServer.Location = new System.Drawing.Point(6, 34);
            this.resultsServer.Multiline = true;
            this.resultsServer.Name = "resultsServer";
            this.resultsServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsServer.Size = new System.Drawing.Size(693, 362);
            this.resultsServer.TabIndex = 7;
            this.resultsServer.Text = "Servidor > En Espera....";
            // 
            // Toolbar
            // 
            this.Toolbar.BackColor = System.Drawing.Color.Lavender;
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.settingsMenu,
            this.helpToolStripMenuItem});
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(731, 24);
            this.Toolbar.TabIndex = 36;
            this.Toolbar.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServerMenu,
            this.CloseServerMenu,
            this.CloseMenu});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(60, 20);
            this.MenuFile.Text = "Archivo";
            // 
            // startServerMenu
            // 
            this.startServerMenu.Name = "startServerMenu";
            this.startServerMenu.Size = new System.Drawing.Size(150, 22);
            this.startServerMenu.Text = "Iniciar Servicio";
            // 
            // CloseServerMenu
            // 
            this.CloseServerMenu.Name = "CloseServerMenu";
            this.CloseServerMenu.Size = new System.Drawing.Size(150, 22);
            this.CloseServerMenu.Text = "Stop Servicio";
            // 
            // CloseMenu
            // 
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(150, 22);
            this.CloseMenu.Text = "Salir";
            // 
            // settingsMenu
            // 
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(57, 20);
            this.settingsMenu.Text = "Ajustes";
            this.settingsMenu.Click += new System.EventHandler(this.settingsMenu_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenu,
            this.aboutMenu,
            this.manualMenu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.helpToolStripMenuItem.Text = "Ayuda";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(177, 22);
            this.helpMenu.Text = "Contactarnos";
            this.helpMenu.Click += new System.EventHandler(this.helpMenu_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Enabled = false;
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(177, 22);
            this.aboutMenu.Text = "Acerca de Solavinte";
            // 
            // manualMenu
            // 
            this.manualMenu.Name = "manualMenu";
            this.manualMenu.Size = new System.Drawing.Size(177, 22);
            this.manualMenu.Text = "Manual";
            this.manualMenu.Click += new System.EventHandler(this.manualMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(731, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(95, 17);
            this.statusLabel.Text = "Servidor iniciado";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // lblClientNumberConected
            // 
            this.lblClientNumberConected.AutoSize = true;
            this.lblClientNumberConected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblClientNumberConected.Location = new System.Drawing.Point(25, 39);
            this.lblClientNumberConected.Name = "lblClientNumberConected";
            this.lblClientNumberConected.Size = new System.Drawing.Size(77, 16);
            this.lblClientNumberConected.TabIndex = 39;
            this.lblClientNumberConected.Text = "Nº Clientes:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox2.Location = new System.Drawing.Point(18, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(693, 1);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TESOAR_MARK2.SERVER.Properties.Resources.logo_solavinte150;
            this.pictureBox1.Location = new System.Drawing.Point(12, 474);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(731, 543);
            this.Controls.Add(this.lblClientNumberConected);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TesoAR - ServidorAPP";
            this.Load += new System.EventHandler(this.Server_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox resultsServer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip Toolbar;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem startServerMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseServerMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem manualMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblClientNumberConected;
    }
}

