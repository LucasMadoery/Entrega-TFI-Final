namespace Trabajo_Final_Final_Integrador
{
    partial class FormsPrincipal
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
            dataGridView1 = new DataGridView();
            CmbBoxCategorias = new ComboBox();
            BtnOrdenar = new Button();
            BtnNuevoProducto = new Button();
            panel1 = new Panel();
            BtnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.InactiveCaption;
            dataGridView1.Location = new Point(0, 86);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(944, 433);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // CmbBoxCategorias
            // 
            CmbBoxCategorias.ForeColor = SystemColors.MenuHighlight;
            CmbBoxCategorias.FormattingEnabled = true;
            CmbBoxCategorias.Location = new Point(27, 29);
            CmbBoxCategorias.Margin = new Padding(4, 3, 4, 3);
            CmbBoxCategorias.Name = "CmbBoxCategorias";
            CmbBoxCategorias.Size = new Size(140, 23);
            CmbBoxCategorias.TabIndex = 2;
            CmbBoxCategorias.SelectedIndexChanged += CmbBoxCategorias_SelectedIndexChanged;
            // 
            // BtnOrdenar
            // 
            BtnOrdenar.ForeColor = Color.Red;
            BtnOrdenar.Location = new Point(211, 24);
            BtnOrdenar.Margin = new Padding(4, 3, 4, 3);
            BtnOrdenar.Name = "BtnOrdenar";
            BtnOrdenar.Size = new Size(102, 27);
            BtnOrdenar.TabIndex = 3;
            BtnOrdenar.Text = "Descendente";
            BtnOrdenar.UseVisualStyleBackColor = true;
            BtnOrdenar.Click += btnOrdenar_Click;
            // 
            // BtnNuevoProducto
            // 
            BtnNuevoProducto.BackColor = SystemColors.ActiveBorder;
            BtnNuevoProducto.ForeColor = SystemColors.HotTrack;
            BtnNuevoProducto.Location = new Point(354, 23);
            BtnNuevoProducto.Margin = new Padding(4, 3, 4, 3);
            BtnNuevoProducto.Name = "BtnNuevoProducto";
            BtnNuevoProducto.RightToLeft = RightToLeft.No;
            BtnNuevoProducto.Size = new Size(88, 29);
            BtnNuevoProducto.TabIndex = 1;
            BtnNuevoProducto.Text = "Nuevo";
            BtnNuevoProducto.UseVisualStyleBackColor = false;
            BtnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(BtnBorrar);
            panel1.Controls.Add(BtnNuevoProducto);
            panel1.Controls.Add(CmbBoxCategorias);
            panel1.Controls.Add(BtnOrdenar);
            panel1.Location = new Point(1, 2);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 78);
            panel1.TabIndex = 4;
            // 
            // BtnBorrar
            // 
            BtnBorrar.Location = new Point(478, 25);
            BtnBorrar.Margin = new Padding(4, 3, 4, 3);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(88, 27);
            BtnBorrar.TabIndex = 4;
            BtnBorrar.Text = "Borrar";
            BtnBorrar.UseVisualStyleBackColor = true;
            BtnBorrar.Click += btnBorrar_Click;
            // 
            // FormsPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 519);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormsPrincipal";
            Text = "Form1";
            Load += FormsPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmbBoxCategorias;
        private System.Windows.Forms.Button BtnOrdenar;
        private System.Windows.Forms.Button BtnNuevoProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBorrar;
    }
}

