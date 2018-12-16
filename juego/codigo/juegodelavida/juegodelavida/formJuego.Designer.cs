namespace juegodelavida
{
    partial class formJuego
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJuego));
            this.botoniniciar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.botondetener = new System.Windows.Forms.Button();
            this.botonreiniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botoniniciar
            // 
            this.botoniniciar.Location = new System.Drawing.Point(12, 1);
            this.botoniniciar.Name = "botoniniciar";
            this.botoniniciar.Size = new System.Drawing.Size(87, 26);
            this.botoniniciar.TabIndex = 0;
            this.botoniniciar.Text = "Iniciar juego";
            this.botoniniciar.UseVisualStyleBackColor = true;
            this.botoniniciar.Click += new System.EventHandler(this.botoniniciar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.juegoFuncionando);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.actualizacionJuego);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(621, 494);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 622;
            this.lineShape1.Y1 = 28;
            this.lineShape1.Y2 = 28;
            // 
            // botondetener
            // 
            this.botondetener.Location = new System.Drawing.Point(120, 1);
            this.botondetener.Name = "botondetener";
            this.botondetener.Size = new System.Drawing.Size(87, 26);
            this.botondetener.TabIndex = 2;
            this.botondetener.Text = "Detener juego";
            this.botondetener.UseVisualStyleBackColor = true;
            this.botondetener.Visible = false;
            this.botondetener.Click += new System.EventHandler(this.botondetener_Click);
            // 
            // botonreiniciar
            // 
            this.botonreiniciar.Location = new System.Drawing.Point(229, 1);
            this.botonreiniciar.Name = "botonreiniciar";
            this.botonreiniciar.Size = new System.Drawing.Size(87, 26);
            this.botonreiniciar.TabIndex = 3;
            this.botonreiniciar.Text = "Reiniciar juego";
            this.botonreiniciar.UseVisualStyleBackColor = true;
            this.botonreiniciar.Visible = false;
            this.botonreiniciar.Click += new System.EventHandler(this.botonreiniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Creado por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Christian Geovanny Sánchez Hernández";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fernando hernández Ramos";
            // 
            // formJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonreiniciar);
            this.Controls.Add(this.botondetener);
            this.Controls.Add(this.botoniniciar);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego de la vida DISOR";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.formJuego_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botoniniciar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button botondetener;
        private System.Windows.Forms.Button botonreiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

