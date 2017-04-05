namespace Escritorio.Vista
{
    partial class frmMunicipio
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
            this.dgvDatosMunicipio = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pkMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMunicipio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosMunicipio
            // 
            this.dgvDatosMunicipio.AllowUserToAddRows = false;
            this.dgvDatosMunicipio.AllowUserToDeleteRows = false;
            this.dgvDatosMunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosMunicipio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkMunicipio,
            this.sMunicipio,
            this.sDescripcion,
            this.sStatus});
            this.dgvDatosMunicipio.Location = new System.Drawing.Point(12, 57);
            this.dgvDatosMunicipio.Name = "dgvDatosMunicipio";
            this.dgvDatosMunicipio.ReadOnly = true;
            this.dgvDatosMunicipio.Size = new System.Drawing.Size(549, 268);
            this.dgvDatosMunicipio.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 31);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(468, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Solo buscar por nombre de municipio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(486, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(405, 331);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(486, 332);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doble click al campo que se desea modificar";
            // 
            // pkMunicipio
            // 
            this.pkMunicipio.DataPropertyName = "pkMunicipio";
            this.pkMunicipio.HeaderText = "ID";
            this.pkMunicipio.Name = "pkMunicipio";
            this.pkMunicipio.ReadOnly = true;
            // 
            // sMunicipio
            // 
            this.sMunicipio.DataPropertyName = "sMunicipio";
            this.sMunicipio.HeaderText = "Municipio";
            this.sMunicipio.Name = "sMunicipio";
            this.sMunicipio.ReadOnly = true;
            // 
            // sDescripcion
            // 
            this.sDescripcion.DataPropertyName = "sDescripcion";
            this.sDescripcion.HeaderText = "Descripcion";
            this.sDescripcion.Name = "sDescripcion";
            this.sDescripcion.ReadOnly = true;
            this.sDescripcion.Width = 200;
            // 
            // sStatus
            // 
            this.sStatus.DataPropertyName = "bStatus";
            this.sStatus.HeaderText = "Estado";
            this.sStatus.Name = "sStatus";
            this.sStatus.ReadOnly = true;
            // 
            // frmMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvDatosMunicipio);
            this.Name = "frmMunicipio";
            this.Text = "Municipio";
            this.Load += new System.EventHandler(this.frmMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMunicipio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosMunicipio;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sStatus;
    }
}