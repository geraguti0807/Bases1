namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrupaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalJoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renombrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intersecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoCartesianoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diferenciaDeConjuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyecciónGeneralizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.uniónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 460);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agrupaciónToolStripMenuItem,
            this.agregaciónToolStripMenuItem,
            this.naturalJoinToolStripMenuItem,
            this.joinToolStripMenuItem,
            this.renombrarToolStripMenuItem,
            this.divisiónToolStripMenuItem,
            this.intersecciónToolStripMenuItem,
            this.productoCartesianoToolStripMenuItem,
            this.diferenciaDeConjuntosToolStripMenuItem,
            this.uniónToolStripMenuItem,
            this.proyecciónGeneralizadaToolStripMenuItem,
            this.selecciónToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // agrupaciónToolStripMenuItem
            // 
            this.agrupaciónToolStripMenuItem.Name = "agrupaciónToolStripMenuItem";
            this.agrupaciónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.agrupaciónToolStripMenuItem.Text = "Agrupación";
            this.agrupaciónToolStripMenuItem.Click += new System.EventHandler(this.agrupaciónToolStripMenuItem_Click);
            // 
            // agregaciónToolStripMenuItem
            // 
            this.agregaciónToolStripMenuItem.Name = "agregaciónToolStripMenuItem";
            this.agregaciónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.agregaciónToolStripMenuItem.Text = "Agregación";
            this.agregaciónToolStripMenuItem.Click += new System.EventHandler(this.agregaciónToolStripMenuItem_Click);
            // 
            // naturalJoinToolStripMenuItem
            // 
            this.naturalJoinToolStripMenuItem.Name = "naturalJoinToolStripMenuItem";
            this.naturalJoinToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.naturalJoinToolStripMenuItem.Text = "Natural Join";
            this.naturalJoinToolStripMenuItem.Click += new System.EventHandler(this.naturalJoinToolStripMenuItem_Click);
            // 
            // joinToolStripMenuItem
            // 
            this.joinToolStripMenuItem.Name = "joinToolStripMenuItem";
            this.joinToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.joinToolStripMenuItem.Text = "Join";
            this.joinToolStripMenuItem.Click += new System.EventHandler(this.joinToolStripMenuItem_Click);
            // 
            // renombrarToolStripMenuItem
            // 
            this.renombrarToolStripMenuItem.Name = "renombrarToolStripMenuItem";
            this.renombrarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.renombrarToolStripMenuItem.Text = "Renombrar";
            this.renombrarToolStripMenuItem.Click += new System.EventHandler(this.renombrarToolStripMenuItem_Click);
            // 
            // divisiónToolStripMenuItem
            // 
            this.divisiónToolStripMenuItem.Name = "divisiónToolStripMenuItem";
            this.divisiónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.divisiónToolStripMenuItem.Text = "División";
            this.divisiónToolStripMenuItem.Click += new System.EventHandler(this.divisiónToolStripMenuItem_Click);
            // 
            // intersecciónToolStripMenuItem
            // 
            this.intersecciónToolStripMenuItem.Name = "intersecciónToolStripMenuItem";
            this.intersecciónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.intersecciónToolStripMenuItem.Text = "Intersección";
            this.intersecciónToolStripMenuItem.Click += new System.EventHandler(this.intersecciónToolStripMenuItem_Click);
            // 
            // productoCartesianoToolStripMenuItem
            // 
            this.productoCartesianoToolStripMenuItem.Name = "productoCartesianoToolStripMenuItem";
            this.productoCartesianoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.productoCartesianoToolStripMenuItem.Text = "Producto Cartesiano";
            this.productoCartesianoToolStripMenuItem.Click += new System.EventHandler(this.productoCartesianoToolStripMenuItem_Click);
            // 
            // diferenciaDeConjuntosToolStripMenuItem
            // 
            this.diferenciaDeConjuntosToolStripMenuItem.Name = "diferenciaDeConjuntosToolStripMenuItem";
            this.diferenciaDeConjuntosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.diferenciaDeConjuntosToolStripMenuItem.Text = "Diferencia de Conjuntos";
            this.diferenciaDeConjuntosToolStripMenuItem.Click += new System.EventHandler(this.diferenciaDeConjuntosToolStripMenuItem_Click);
            // 
            // proyecciónGeneralizadaToolStripMenuItem
            // 
            this.proyecciónGeneralizadaToolStripMenuItem.Name = "proyecciónGeneralizadaToolStripMenuItem";
            this.proyecciónGeneralizadaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.proyecciónGeneralizadaToolStripMenuItem.Text = "Proyección Generalizada";
            this.proyecciónGeneralizadaToolStripMenuItem.Click += new System.EventHandler(this.proyecciónGeneralizadaToolStripMenuItem_Click);
            // 
            // selecciónToolStripMenuItem
            // 
            this.selecciónToolStripMenuItem.Name = "selecciónToolStripMenuItem";
            this.selecciónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.selecciónToolStripMenuItem.Text = "Selección";
            this.selecciónToolStripMenuItem.Click += new System.EventHandler(this.selecciónToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 87);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interpretador \r\nde \r\nÁlgebra Relacional";
            // 
            // uniónToolStripMenuItem
            // 
            this.uniónToolStripMenuItem.Name = "uniónToolStripMenuItem";
            this.uniónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.uniónToolStripMenuItem.Text = "Unión";
            this.uniónToolStripMenuItem.Click += new System.EventHandler(this.uniónToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I.A.R";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrupaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalJoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renombrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intersecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoCartesianoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diferenciaDeConjuntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyecciónGeneralizadaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem uniónToolStripMenuItem;
    }
}

