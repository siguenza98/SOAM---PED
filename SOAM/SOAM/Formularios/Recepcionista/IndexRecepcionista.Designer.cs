namespace SOAM.Formularios.Recepcionista
{
    partial class IndexRecepcionista
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
            this.menuVertical = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExpediente = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(146)))));
            this.menuVertical.Controls.Add(this.button1);
            this.menuVertical.Controls.Add(this.btnSalir);
            this.menuVertical.Controls.Add(this.btnExpediente);
            this.menuVertical.Controls.Add(this.btnConsulta);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(220, 552);
            this.menuVertical.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar Expediente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 493);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(220, 59);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExpediente
            // 
            this.btnExpediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpediente.FlatAppearance.BorderSize = 0;
            this.btnExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpediente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpediente.ForeColor = System.Drawing.Color.White;
            this.btnExpediente.Location = new System.Drawing.Point(0, 147);
            this.btnExpediente.Name = "btnExpediente";
            this.btnExpediente.Size = new System.Drawing.Size(220, 59);
            this.btnExpediente.TabIndex = 1;
            this.btnExpediente.Text = "Registrar Expediente";
            this.btnExpediente.UseVisualStyleBackColor = true;
            this.btnExpediente.Click += new System.EventHandler(this.btnExpediente_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(0, 277);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(220, 59);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Crear Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Location = new System.Drawing.Point(274, 82);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(645, 386);
            this.dgvCola.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cola de Espera";
            // 
            // btnDespachar
            // 
            this.btnDespachar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnDespachar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDespachar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespachar.ForeColor = System.Drawing.Color.White;
            this.btnDespachar.Location = new System.Drawing.Point(274, 483);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(164, 56);
            this.btnDespachar.TabIndex = 6;
            this.btnDespachar.Text = "Despachar Paciente";
            this.btnDespachar.UseVisualStyleBackColor = false;
            this.btnDespachar.Click += new System.EventHandler(this.btnDespachar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciar.ForeColor = System.Drawing.Color.White;
            this.btnVaciar.Location = new System.Drawing.Point(755, 483);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(164, 56);
            this.btnVaciar.TabIndex = 8;
            this.btnVaciar.Text = "Vaciar Cola";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(755, 46);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(164, 30);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar Cola";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // IndexRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(964, 552);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnDespachar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCola);
            this.Controls.Add(this.menuVertical);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "IndexRecepcionista";
            this.Text = "SOAM";
            this.Load += new System.EventHandler(this.IndexRecepcionista_Load);
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExpediente;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDespachar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualizar;
    }
}