namespace WinApp.UniversidadTresCapas
{
	partial class frmPrincipal
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
			this.btnCrearCarrera = new System.Windows.Forms.Button();
			this.txtNombreCarrera = new System.Windows.Forms.TextBox();
			this.lblNombreCarrera = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombreDecano = new System.Windows.Forms.TextBox();
			this.btnVerCarreras = new System.Windows.Forms.Button();
			this.cboxCarreras = new System.Windows.Forms.ComboBox();
			this.btnVerDatosCarrera = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCrearCarrera
			// 
			this.btnCrearCarrera.Location = new System.Drawing.Point(126, 130);
			this.btnCrearCarrera.Name = "btnCrearCarrera";
			this.btnCrearCarrera.Size = new System.Drawing.Size(284, 113);
			this.btnCrearCarrera.TabIndex = 0;
			this.btnCrearCarrera.Text = "Crear carrera";
			this.btnCrearCarrera.UseVisualStyleBackColor = true;
			this.btnCrearCarrera.Click += new System.EventHandler(this.btnCrearCarrera_Click);
			// 
			// txtNombreCarrera
			// 
			this.txtNombreCarrera.Location = new System.Drawing.Point(237, 41);
			this.txtNombreCarrera.Name = "txtNombreCarrera";
			this.txtNombreCarrera.Size = new System.Drawing.Size(249, 20);
			this.txtNombreCarrera.TabIndex = 1;
			// 
			// lblNombreCarrera
			// 
			this.lblNombreCarrera.AutoSize = true;
			this.lblNombreCarrera.Location = new System.Drawing.Point(53, 41);
			this.lblNombreCarrera.Name = "lblNombreCarrera";
			this.lblNombreCarrera.Size = new System.Drawing.Size(80, 13);
			this.lblNombreCarrera.TabIndex = 2;
			this.lblNombreCarrera.Text = "Nombre carrera";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nombre decano";
			// 
			// txtNombreDecano
			// 
			this.txtNombreDecano.Location = new System.Drawing.Point(237, 74);
			this.txtNombreDecano.Name = "txtNombreDecano";
			this.txtNombreDecano.Size = new System.Drawing.Size(249, 20);
			this.txtNombreDecano.TabIndex = 3;
			// 
			// btnVerCarreras
			// 
			this.btnVerCarreras.Location = new System.Drawing.Point(480, 293);
			this.btnVerCarreras.Name = "btnVerCarreras";
			this.btnVerCarreras.Size = new System.Drawing.Size(75, 23);
			this.btnVerCarreras.TabIndex = 5;
			this.btnVerCarreras.Text = "Ver carreras";
			this.btnVerCarreras.UseVisualStyleBackColor = true;
			this.btnVerCarreras.Click += new System.EventHandler(this.btnVerCarreras_Click);
			// 
			// cboxCarreras
			// 
			this.cboxCarreras.FormattingEnabled = true;
			this.cboxCarreras.Location = new System.Drawing.Point(126, 270);
			this.cboxCarreras.Name = "cboxCarreras";
			this.cboxCarreras.Size = new System.Drawing.Size(121, 21);
			this.cboxCarreras.TabIndex = 6;
			// 
			// btnVerDatosCarrera
			// 
			this.btnVerDatosCarrera.Location = new System.Drawing.Point(321, 267);
			this.btnVerDatosCarrera.Name = "btnVerDatosCarrera";
			this.btnVerDatosCarrera.Size = new System.Drawing.Size(75, 23);
			this.btnVerDatosCarrera.TabIndex = 7;
			this.btnVerDatosCarrera.Text = "Ver datos de la carrera";
			this.btnVerDatosCarrera.UseVisualStyleBackColor = true;
			this.btnVerDatosCarrera.Click += new System.EventHandler(this.btnVerDatosCarrera_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 348);
			this.Controls.Add(this.btnVerDatosCarrera);
			this.Controls.Add(this.cboxCarreras);
			this.Controls.Add(this.btnVerCarreras);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombreDecano);
			this.Controls.Add(this.lblNombreCarrera);
			this.Controls.Add(this.txtNombreCarrera);
			this.Controls.Add(this.btnCrearCarrera);
			this.Name = "frmPrincipal";
			this.Text = "Gestor de carreras";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCrearCarrera;
		private System.Windows.Forms.TextBox txtNombreCarrera;
		private System.Windows.Forms.Label lblNombreCarrera;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombreDecano;
		private System.Windows.Forms.Button btnVerCarreras;
		private System.Windows.Forms.ComboBox cboxCarreras;
		private System.Windows.Forms.Button btnVerDatosCarrera;
	}
}

