
namespace Trabajo_Final_Integrador
{
    partial class FormsEditar
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
            lblCategoryEdit = new Label();
            lblDescriptionEdit = new Label();
            lblPriceEdit = new Label();
            lblTitleEdit = new Label();
            lblIdEdit = new Label();
            txtBoxIdEdit = new TextBox();
            btnCancelEdit = new Button();
            btnAcceptEdit = new Button();
            txtBoxCategoryEdit = new TextBox();
            txtBoxDescriptionEdit = new TextBox();
            txtBoxPriceEdit = new TextBox();
            txtBoxTitleEdit = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCategoryEdit
            // 
            lblCategoryEdit.AutoSize = true;
            lblCategoryEdit.Location = new Point(98, 191);
            lblCategoryEdit.Name = "lblCategoryEdit";
            lblCategoryEdit.Size = new Size(61, 15);
            lblCategoryEdit.TabIndex = 47;
            lblCategoryEdit.Text = "Categoria:";
            // 
            // lblDescriptionEdit
            // 
            lblDescriptionEdit.AutoSize = true;
            lblDescriptionEdit.Location = new Point(134, 126);
            lblDescriptionEdit.Name = "lblDescriptionEdit";
            lblDescriptionEdit.Size = new Size(72, 15);
            lblDescriptionEdit.TabIndex = 46;
            lblDescriptionEdit.Text = "Descripcion:";
            // 
            // lblPriceEdit
            // 
            lblPriceEdit.AutoSize = true;
            lblPriceEdit.Location = new Point(17, 127);
            lblPriceEdit.Name = "lblPriceEdit";
            lblPriceEdit.Size = new Size(43, 15);
            lblPriceEdit.TabIndex = 45;
            lblPriceEdit.Text = "Precio:";
            // 
            // lblTitleEdit
            // 
            lblTitleEdit.AutoSize = true;
            lblTitleEdit.Location = new Point(148, 55);
            lblTitleEdit.Name = "lblTitleEdit";
            lblTitleEdit.Size = new Size(40, 15);
            lblTitleEdit.TabIndex = 44;
            lblTitleEdit.Text = "Titulo:";
            // 
            // lblIdEdit
            // 
            lblIdEdit.AutoSize = true;
            lblIdEdit.Location = new Point(17, 55);
            lblIdEdit.Name = "lblIdEdit";
            lblIdEdit.Size = new Size(21, 15);
            lblIdEdit.TabIndex = 43;
            lblIdEdit.Text = "ID:";
            // 
            // txtBoxIdEdit
            // 
            txtBoxIdEdit.Location = new Point(17, 73);
            txtBoxIdEdit.Name = "txtBoxIdEdit";
            txtBoxIdEdit.ReadOnly = true;
            txtBoxIdEdit.Size = new Size(111, 23);
            txtBoxIdEdit.TabIndex = 42;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.DarkSalmon;
            btnCancelEdit.Location = new Point(86, 288);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(83, 23);
            btnCancelEdit.TabIndex = 41;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // btnAcceptEdit
            // 
            btnAcceptEdit.BackColor = Color.DarkSalmon;
            btnAcceptEdit.Location = new Point(86, 250);
            btnAcceptEdit.Name = "btnAcceptEdit";
            btnAcceptEdit.Size = new Size(83, 23);
            btnAcceptEdit.TabIndex = 40;
            btnAcceptEdit.Text = "Aceptar";
            btnAcceptEdit.UseVisualStyleBackColor = false;
            btnAcceptEdit.Click += btnAcceptEdit_Click;
            // 
            // txtBoxCategoryEdit
            // 
            txtBoxCategoryEdit.Location = new Point(57, 209);
            txtBoxCategoryEdit.Name = "txtBoxCategoryEdit";
            txtBoxCategoryEdit.Size = new Size(149, 23);
            txtBoxCategoryEdit.TabIndex = 39;
            // 
            // txtBoxDescriptionEdit
            // 
            txtBoxDescriptionEdit.Location = new Point(134, 144);
            txtBoxDescriptionEdit.Name = "txtBoxDescriptionEdit";
            txtBoxDescriptionEdit.Size = new Size(126, 23);
            txtBoxDescriptionEdit.TabIndex = 38;
            // 
            // txtBoxPriceEdit
            // 
            txtBoxPriceEdit.Location = new Point(17, 144);
            txtBoxPriceEdit.Name = "txtBoxPriceEdit";
            txtBoxPriceEdit.Size = new Size(111, 23);
            txtBoxPriceEdit.TabIndex = 37;
            // 
            // txtBoxTitleEdit
            // 
            txtBoxTitleEdit.Location = new Point(134, 74);
            txtBoxTitleEdit.Name = "txtBoxTitleEdit";
            txtBoxTitleEdit.Size = new Size(126, 23);
            txtBoxTitleEdit.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 22);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 48;
            label1.Text = "Editar Producto Seleccionado:";
            label1.Click += this.label1_Click;
            // 
            // FormsEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(277, 329);
            Controls.Add(label1);
            Controls.Add(lblCategoryEdit);
            Controls.Add(lblDescriptionEdit);
            Controls.Add(lblPriceEdit);
            Controls.Add(lblTitleEdit);
            Controls.Add(lblIdEdit);
            Controls.Add(txtBoxIdEdit);
            Controls.Add(btnCancelEdit);
            Controls.Add(btnAcceptEdit);
            Controls.Add(txtBoxCategoryEdit);
            Controls.Add(txtBoxDescriptionEdit);
            Controls.Add(txtBoxPriceEdit);
            Controls.Add(txtBoxTitleEdit);
            MaximizeBox = false;
            Name = "FormsEditar";
            Text = "Editar";
            Load += FormsEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryEdit;
        private Label lblDescriptionEdit;
        private Label lblPriceEdit;
        private Label lblTitleEdit;
        private Label lblIdEdit;
        private TextBox txtBoxIdEdit;
        private Button btnCancelEdit;
        private Button btnAcceptEdit;
        private TextBox txtBoxCategoryEdit;
        private TextBox txtBoxDescriptionEdit;
        private TextBox txtBoxPriceEdit;
        private TextBox txtBoxTitleEdit;
        private Label label1;
        private readonly EventHandler label1_Click;
    }
}