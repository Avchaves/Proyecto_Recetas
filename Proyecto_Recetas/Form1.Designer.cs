namespace Proyecto_Recetas
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
            this.components = new System.ComponentModel.Container();
            this.bttbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.bttaddpost = new System.Windows.Forms.Button();
            this.bttadding = new System.Windows.Forms.Button();
            this.bttdel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtadding = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbing = new System.Windows.Forms.ListBox();
            this.txtdeling = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttdeling = new System.Windows.Forms.Button();
            this.txting = new System.Windows.Forms.TextBox();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // bttbuscar
            // 
            this.bttbuscar.Location = new System.Drawing.Point(171, 99);
            this.bttbuscar.Name = "bttbuscar";
            this.bttbuscar.Size = new System.Drawing.Size(75, 23);
            this.bttbuscar.TabIndex = 0;
            this.bttbuscar.Text = "Buscar...";
            this.bttbuscar.UseVisualStyleBackColor = true;
            this.bttbuscar.Click += new System.EventHandler(this.bttbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(18, 99);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(147, 20);
            this.txtbuscar.TabIndex = 1;
            // 
            // bttaddpost
            // 
            this.bttaddpost.BackColor = System.Drawing.Color.PapayaWhip;
            this.bttaddpost.Location = new System.Drawing.Point(524, 99);
            this.bttaddpost.Name = "bttaddpost";
            this.bttaddpost.Size = new System.Drawing.Size(109, 23);
            this.bttaddpost.TabIndex = 3;
            this.bttaddpost.Text = "Agregar Postre";
            this.bttaddpost.UseVisualStyleBackColor = false;
            this.bttaddpost.Click += new System.EventHandler(this.bttaddpost_Click);
            // 
            // bttadding
            // 
            this.bttadding.BackColor = System.Drawing.Color.PapayaWhip;
            this.bttadding.Location = new System.Drawing.Point(366, 49);
            this.bttadding.Name = "bttadding";
            this.bttadding.Size = new System.Drawing.Size(109, 26);
            this.bttadding.TabIndex = 4;
            this.bttadding.Text = "Agregar Ingrediente";
            this.bttadding.UseVisualStyleBackColor = false;
            this.bttadding.Click += new System.EventHandler(this.bttadding_Click);
            // 
            // bttdel
            // 
            this.bttdel.BackColor = System.Drawing.Color.PapayaWhip;
            this.bttdel.Location = new System.Drawing.Point(375, 194);
            this.bttdel.Name = "bttdel";
            this.bttdel.Size = new System.Drawing.Size(100, 41);
            this.bttdel.TabIndex = 5;
            this.bttdel.Text = "Eliminar Postre";
            this.bttdel.UseVisualStyleBackColor = false;
            this.bttdel.Click += new System.EventHandler(this.bttdel_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Proyecto_Recetas.Properties.Resources._63_Proveedores_de_insumos_para_reposteria_y_45_distribuidores;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txting);
            this.panel2.Controls.Add(this.bttaddpost);
            this.panel2.Controls.Add(this.bttbuscar);
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Location = new System.Drawing.Point(-6, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 414);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 62);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reposteria";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(0, 413);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1157, 41);
            this.panel3.TabIndex = 7;
            // 
            // txtadding
            // 
            this.txtadding.Location = new System.Drawing.Point(260, 55);
            this.txtadding.Name = "txtadding";
            this.txtadding.Size = new System.Drawing.Size(99, 20);
            this.txtadding.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.lbing);
            this.panel4.Controls.Add(this.txtdeling);
            this.panel4.Controls.Add(this.lblname);
            this.panel4.Controls.Add(this.txtadding);
            this.panel4.Controls.Add(this.bttadding);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.bttdeling);
            this.panel4.Controls.Add(this.bttdel);
            this.panel4.Location = new System.Drawing.Point(647, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(487, 254);
            this.panel4.TabIndex = 9;
            // 
            // lbing
            // 
            this.lbing.FormattingEnabled = true;
            this.lbing.Location = new System.Drawing.Point(26, 49);
            this.lbing.Name = "lbing";
            this.lbing.Size = new System.Drawing.Size(228, 186);
            this.lbing.TabIndex = 11;
            // 
            // txtdeling
            // 
            this.txtdeling.Location = new System.Drawing.Point(260, 86);
            this.txtdeling.Name = "txtdeling";
            this.txtdeling.Size = new System.Drawing.Size(99, 20);
            this.txtdeling.TabIndex = 10;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(76, 20);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(10, 13);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre:";
            // 
            // bttdeling
            // 
            this.bttdeling.BackColor = System.Drawing.Color.PapayaWhip;
            this.bttdeling.Location = new System.Drawing.Point(366, 81);
            this.bttdeling.Name = "bttdeling";
            this.bttdeling.Size = new System.Drawing.Size(109, 28);
            this.bttdeling.TabIndex = 6;
            this.bttdeling.Text = "Eliminar ingrediente";
            this.bttdeling.UseVisualStyleBackColor = false;
            this.bttdeling.Click += new System.EventHandler(this.bttdeling_Click);
            // 
            // txting
            // 
            this.txting.Location = new System.Drawing.Point(371, 99);
            this.txting.Name = "txting";
            this.txting.Size = new System.Drawing.Size(147, 20);
            this.txting.TabIndex = 9;
            // 
            // dgw
            // 
            this.dgw.AllowUserToOrderColumns = true;
            this.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgw.Location = new System.Drawing.Point(12, 137);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersVisible = false;
            this.dgw.Size = new System.Drawing.Size(615, 254);
            this.dgw.TabIndex = 10;
            this.dgw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre del Postre";
            this.Column1.Name = "Column1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 447);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button bttaddpost;
        private System.Windows.Forms.Button bttadding;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bttdel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtadding;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bttdeling;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbing;
        private System.Windows.Forms.TextBox txtdeling;
        private System.Windows.Forms.TextBox txting;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

