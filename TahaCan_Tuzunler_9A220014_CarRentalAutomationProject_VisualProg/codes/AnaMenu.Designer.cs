namespace CarRentalAutomation
{
    partial class AnaMenu
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
            this.btnRentalOp = new System.Windows.Forms.Button();
            this.btnCarOp = new System.Windows.Forms.Button();
            this.btnCustomerOp = new System.Windows.Forms.Button();
            this.btnMarkaYonetimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRentalOp
            // 
            this.btnRentalOp.Location = new System.Drawing.Point(168, 118);
            this.btnRentalOp.Name = "btnRentalOp";
            this.btnRentalOp.Size = new System.Drawing.Size(188, 98);
            this.btnRentalOp.TabIndex = 0;
            this.btnRentalOp.Text = "Rental Operations";
            this.btnRentalOp.UseVisualStyleBackColor = true;
            this.btnRentalOp.Click += new System.EventHandler(this.btnRentalOp_Click);
            // 
            // btnCarOp
            // 
            this.btnCarOp.Location = new System.Drawing.Point(168, 316);
            this.btnCarOp.Name = "btnCarOp";
            this.btnCarOp.Size = new System.Drawing.Size(188, 98);
            this.btnCarOp.TabIndex = 1;
            this.btnCarOp.Text = "Car Operations";
            this.btnCarOp.UseVisualStyleBackColor = true;
            this.btnCarOp.Click += new System.EventHandler(this.btnCarOp_Click);
            // 
            // btnCustomerOp
            // 
            this.btnCustomerOp.Location = new System.Drawing.Point(532, 118);
            this.btnCustomerOp.Name = "btnCustomerOp";
            this.btnCustomerOp.Size = new System.Drawing.Size(188, 98);
            this.btnCustomerOp.TabIndex = 2;
            this.btnCustomerOp.Text = "Customer Operations";
            this.btnCustomerOp.UseVisualStyleBackColor = true;
            this.btnCustomerOp.Click += new System.EventHandler(this.btnCustomerOp_Click);
            // 
            // btnMarkaYonetimi
            // 
            this.btnMarkaYonetimi.Location = new System.Drawing.Point(532, 317);
            this.btnMarkaYonetimi.Name = "btnMarkaYonetimi";
            this.btnMarkaYonetimi.Size = new System.Drawing.Size(188, 97);
            this.btnMarkaYonetimi.TabIndex = 3;
            this.btnMarkaYonetimi.Text = "Brand Management";
            this.btnMarkaYonetimi.UseVisualStyleBackColor = true;
            this.btnMarkaYonetimi.Click += new System.EventHandler(this.btnMarkaYonetimi_Click);
            // 
            // AnaMenu
            // 
            this.ClientSize = new System.Drawing.Size(901, 542);
            this.Controls.Add(this.btnMarkaYonetimi);
            this.Controls.Add(this.btnCustomerOp);
            this.Controls.Add(this.btnCarOp);
            this.Controls.Add(this.btnRentalOp);
            this.Name = "AnaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAracIslemleri;
        private System.Windows.Forms.Button btnMusteriIslemleri;
        private System.Windows.Forms.Button btnKiralamaIslemleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRentalOp;
        private System.Windows.Forms.Button btnCarOp;
        private System.Windows.Forms.Button btnCustomerOp;
        private System.Windows.Forms.Button btnMarkaYonetimi;
    }
}