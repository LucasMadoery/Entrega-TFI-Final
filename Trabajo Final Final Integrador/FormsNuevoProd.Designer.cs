namespace Trabajo_Final_Final_Integrador
{
    partial class FormsNuevoProd
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
            components = new System.ComponentModel.Container();
            lblCategory = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblTitle = new Label();
            lblId = new Label();
            txtBoxId = new TextBox();
            btnCancel = new Button();
            btnAccept = new Button();
            txtBoxCategory = new TextBox();
            txtBoxDescription = new TextBox();
            txtBoxPrice = new TextBox();
            txtBoxTitle = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(108, 197);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(61, 15);
            lblCategory.TabIndex = 35;
            lblCategory.Text = "Categoria:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(180, 134);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(72, 15);
            lblDescription.TabIndex = 34;
            lblDescription.Text = "Descripcion:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(38, 134);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(43, 15);
            lblPrice.TabIndex = 33;
            lblPrice.Text = "Precio:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(41, 71);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(40, 15);
            lblTitle.TabIndex = 32;
            lblTitle.Text = "Titulo:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(199, 71);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 31;
            lblId.Text = "ID:";
            // 
            // txtBoxId
            // 
            txtBoxId.BackColor = SystemColors.ButtonHighlight;
            txtBoxId.Location = new Point(148, 89);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.ReadOnly = true;
            txtBoxId.Size = new Size(131, 23);
            txtBoxId.TabIndex = 30;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkSalmon;
            btnCancel.Location = new Point(98, 321);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(83, 23);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.DarkSalmon;
            btnAccept.Location = new Point(98, 282);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(83, 23);
            btnAccept.TabIndex = 28;
            btnAccept.Text = "Aceptar";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtBoxCategory
            // 
            txtBoxCategory.Location = new Point(71, 224);
            txtBoxCategory.Name = "txtBoxCategory";
            txtBoxCategory.Size = new Size(149, 23);
            txtBoxCategory.TabIndex = 27;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(148, 152);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(131, 23);
            txtBoxDescription.TabIndex = 26;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(3, 152);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(121, 23);
            txtBoxPrice.TabIndex = 25;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(3, 89);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(126, 23);
            txtBoxTitle.TabIndex = 24;
            txtBoxTitle.TextChanged += txtBoxTitle_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 27);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 36;
            label2.Text = "Agregar un producto";
            // 
            // FormsNuevoProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(291, 356);
            Controls.Add(label2);
            Controls.Add(lblCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblTitle);
            Controls.Add(lblId);
            Controls.Add(txtBoxId);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtBoxCategory);
            Controls.Add(txtBoxDescription);
            Controls.Add(txtBoxPrice);
            Controls.Add(txtBoxTitle);
            MaximizeBox = false;
            Name = "FormsNuevoProd";
            Text = "Agregar Prod";
            Load += FrmNew_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblTitle;
        private Label lblId;
        private TextBox txtBoxId;
        private Button btnCancel;
        private Button btnAccept;
        private TextBox txtBoxCategory;
        private TextBox txtBoxDescription;
        private TextBox txtBoxPrice;
        private TextBox txtBoxTitle;
        private ErrorProvider errorProvider1;
        private Label label2;
    }
}