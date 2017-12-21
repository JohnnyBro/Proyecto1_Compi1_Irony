namespace Proyecto1_200517803
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

 #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtEntrada = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRCHIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBRIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROYECTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eJECUTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eJECUTARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolito = new System.Windows.Forms.TreeView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.aRBOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntrada)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(198, 27);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtEntrada);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ENTRADA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtEntrada
            // 
            this.txtEntrada.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtEntrada.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtEntrada.BackBrush = null;
            this.txtEntrada.CharHeight = 14;
            this.txtEntrada.CharWidth = 8;
            this.txtEntrada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEntrada.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEntrada.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtEntrada.IsReplaceMode = false;
            this.txtEntrada.Location = new System.Drawing.Point(3, 3);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Paddings = new System.Windows.Forms.Padding(0);
            this.txtEntrada.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtEntrada.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtEntrada.ServiceColors")));
            this.txtEntrada.Size = new System.Drawing.Size(715, 323);
            this.txtEntrada.TabIndex = 0;
            this.txtEntrada.Zoom = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOToolStripMenuItem,
            this.eJECUTARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            this.aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBRIRToolStripMenuItem,
            this.sALIRToolStripMenuItem,
            this.sALIRToolStripMenuItem1});
            this.aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            this.aRCHIVOToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aRCHIVOToolStripMenuItem.Text = "ARCHIVO";
            // 
            // aBRIRToolStripMenuItem
            // 
            this.aBRIRToolStripMenuItem.Name = "aBRIRToolStripMenuItem";
            this.aBRIRToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aBRIRToolStripMenuItem.Text = "ABRIR";
            this.aBRIRToolStripMenuItem.Click += new System.EventHandler(this.aBRIRToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROYECTOToolStripMenuItem});
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sALIRToolStripMenuItem.Text = "NUEVO";
            // 
            // pROYECTOToolStripMenuItem
            // 
            this.pROYECTOToolStripMenuItem.Name = "pROYECTOToolStripMenuItem";
            this.pROYECTOToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.pROYECTOToolStripMenuItem.Text = "PROYECTO";
            this.pROYECTOToolStripMenuItem.Click += new System.EventHandler(this.pROYECTOToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem1
            // 
            this.sALIRToolStripMenuItem1.Name = "sALIRToolStripMenuItem1";
            this.sALIRToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.sALIRToolStripMenuItem1.Text = "SALIR";
            this.sALIRToolStripMenuItem1.Click += new System.EventHandler(this.sALIRToolStripMenuItem1_Click);
            // 
            // eJECUTARToolStripMenuItem
            // 
            this.eJECUTARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eJECUTARToolStripMenuItem1,
            this.aRBOLToolStripMenuItem});
            this.eJECUTARToolStripMenuItem.Name = "eJECUTARToolStripMenuItem";
            this.eJECUTARToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eJECUTARToolStripMenuItem.Text = "PRUEBA";
            // 
            // eJECUTARToolStripMenuItem1
            // 
            this.eJECUTARToolStripMenuItem1.Name = "eJECUTARToolStripMenuItem1";
            this.eJECUTARToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.eJECUTARToolStripMenuItem1.Text = "EJECUTAR";
            this.eJECUTARToolStripMenuItem1.Click += new System.EventHandler(this.eJECUTARToolStripMenuItem1_Click);
            // 
            // arbolito
            // 
            this.arbolito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.arbolito.LabelEdit = true;
            this.arbolito.Location = new System.Drawing.Point(12, 27);
            this.arbolito.Name = "arbolito";
            this.arbolito.Size = new System.Drawing.Size(157, 352);
            this.arbolito.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // aRBOLToolStripMenuItem
            // 
            this.aRBOLToolStripMenuItem.Name = "aRBOLToolStripMenuItem";
            this.aRBOLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aRBOLToolStripMenuItem.Text = "ARBOL";
            this.aRBOLToolStripMenuItem.Click += new System.EventHandler(this.aRBOLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(946, 449);
            this.Controls.Add(this.arbolito);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEntrada)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBRIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox txtEntrada;
        private System.Windows.Forms.ToolStripMenuItem pROYECTOToolStripMenuItem;
        private System.Windows.Forms.TreeView arbolito;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem eJECUTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eJECUTARToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aRBOLToolStripMenuItem;
    }
}

