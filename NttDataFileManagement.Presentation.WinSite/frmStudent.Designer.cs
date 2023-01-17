namespace NttData.FileManagement.Presentation.WinSite
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblbirthday = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtbirthday = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblid
            // 
            resources.ApplyResources(this.lblid, "lblid");
            this.lblid.Name = "lblid";
            this.lblid.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtid
            // 
            resources.ApplyResources(this.txtid, "txtid");
            this.txtid.Name = "txtid";
            // 
            // lblname
            // 
            resources.ApplyResources(this.lblname, "lblname");
            this.lblname.Name = "lblname";
            this.lblname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblsurname
            // 
            resources.ApplyResources(this.lblsurname, "lblsurname");
            this.lblsurname.Name = "lblsurname";
            // 
            // lblbirthday
            // 
            resources.ApplyResources(this.lblbirthday, "lblbirthday");
            this.lblbirthday.Name = "lblbirthday";
            // 
            // txtname
            // 
            resources.ApplyResources(this.txtname, "txtname");
            this.txtname.Name = "txtname";
            // 
            // txtsurname
            // 
            resources.ApplyResources(this.txtsurname, "txtsurname");
            this.txtsurname.Name = "txtsurname";
            // 
            // txtbirthday
            // 
            resources.ApplyResources(this.txtbirthday, "txtbirthday");
            this.txtbirthday.Name = "txtbirthday";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStudent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbirthday);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblbirthday);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Name = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblbirthday;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtbirthday;
        private System.Windows.Forms.Button button1;
    }
}

