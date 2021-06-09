
namespace RSA_Algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbPlainEncryption = new System.Windows.Forms.TextBox();
            this.tbEncrypted = new System.Windows.Forms.TextBox();
            this.tbPlainDecryption = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopyKey = new System.Windows.Forms.Button();
            this.rTbKey = new System.Windows.Forms.RichTextBox();
            this.btnCopyEncrypts = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSavePublicKey = new System.Windows.Forms.Button();
            this.rTbPublicKey = new System.Windows.Forms.RichTextBox();
            this.btnCopyPublicKey = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPlainEncryption
            // 
            this.tbPlainEncryption.Location = new System.Drawing.Point(12, 81);
            this.tbPlainEncryption.Multiline = true;
            this.tbPlainEncryption.Name = "tbPlainEncryption";
            this.tbPlainEncryption.Size = new System.Drawing.Size(560, 37);
            this.tbPlainEncryption.TabIndex = 0;
            // 
            // tbEncrypted
            // 
            this.tbEncrypted.Location = new System.Drawing.Point(12, 196);
            this.tbEncrypted.Multiline = true;
            this.tbEncrypted.Name = "tbEncrypted";
            this.tbEncrypted.Size = new System.Drawing.Size(560, 76);
            this.tbEncrypted.TabIndex = 1;
            // 
            // tbPlainDecryption
            // 
            this.tbPlainDecryption.Location = new System.Drawing.Point(12, 664);
            this.tbPlainDecryption.Multiline = true;
            this.tbPlainDecryption.Name = "tbPlainDecryption";
            this.tbPlainDecryption.ReadOnly = true;
            this.tbPlainDecryption.Size = new System.Drawing.Size(560, 37);
            this.tbPlainDecryption.TabIndex = 2;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(160, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(263, 26);
            this.title.TabIndex = 3;
            this.title.Text = "ASYMMETRIC ENCRYPTION RSA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plain text for encryption:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encrypted text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 645);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Plain text after decryption:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(247, 124);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(92, 33);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(192, 278);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(92, 33);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Private key:";
            // 
            // btnCopyKey
            // 
            this.btnCopyKey.Location = new System.Drawing.Point(192, 431);
            this.btnCopyKey.Name = "btnCopyKey";
            this.btnCopyKey.Size = new System.Drawing.Size(92, 33);
            this.btnCopyKey.TabIndex = 11;
            this.btnCopyKey.Text = "Copy";
            this.btnCopyKey.UseVisualStyleBackColor = true;
            this.btnCopyKey.Click += new System.EventHandler(this.btnCopyKey_Click);
            // 
            // rTbKey
            // 
            this.rTbKey.Location = new System.Drawing.Point(12, 349);
            this.rTbKey.Name = "rTbKey";
            this.rTbKey.ReadOnly = true;
            this.rTbKey.Size = new System.Drawing.Size(557, 76);
            this.rTbKey.TabIndex = 12;
            this.rTbKey.Text = "";
            // 
            // btnCopyEncrypts
            // 
            this.btnCopyEncrypts.Location = new System.Drawing.Point(290, 278);
            this.btnCopyEncrypts.Name = "btnCopyEncrypts";
            this.btnCopyEncrypts.Size = new System.Drawing.Size(92, 33);
            this.btnCopyEncrypts.TabIndex = 13;
            this.btnCopyEncrypts.Text = "Copy";
            this.btnCopyEncrypts.UseVisualStyleBackColor = true;
            this.btnCopyEncrypts.Click += new System.EventHandler(this.btnCopyEncrypts_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 749);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 33);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(480, 749);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 33);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(290, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 33);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(469, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnSavePublicKey
            // 
            this.btnSavePublicKey.Location = new System.Drawing.Point(290, 582);
            this.btnSavePublicKey.Name = "btnSavePublicKey";
            this.btnSavePublicKey.Size = new System.Drawing.Size(92, 33);
            this.btnSavePublicKey.TabIndex = 21;
            this.btnSavePublicKey.Text = "Save to file";
            this.btnSavePublicKey.UseVisualStyleBackColor = true;
            this.btnSavePublicKey.Click += new System.EventHandler(this.btnSavePublicKey_Click);
            // 
            // rTbPublicKey
            // 
            this.rTbPublicKey.Location = new System.Drawing.Point(12, 500);
            this.rTbPublicKey.Name = "rTbPublicKey";
            this.rTbPublicKey.ReadOnly = true;
            this.rTbPublicKey.Size = new System.Drawing.Size(557, 76);
            this.rTbPublicKey.TabIndex = 20;
            this.rTbPublicKey.Text = "";
            // 
            // btnCopyPublicKey
            // 
            this.btnCopyPublicKey.Location = new System.Drawing.Point(192, 582);
            this.btnCopyPublicKey.Name = "btnCopyPublicKey";
            this.btnCopyPublicKey.Size = new System.Drawing.Size(92, 33);
            this.btnCopyPublicKey.TabIndex = 19;
            this.btnCopyPublicKey.Text = "Copy";
            this.btnCopyPublicKey.UseVisualStyleBackColor = true;
            this.btnCopyPublicKey.Click += new System.EventHandler(this.btnCopyPublicKey_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Public key:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 792);
            this.Controls.Add(this.btnSavePublicKey);
            this.Controls.Add(this.rTbPublicKey);
            this.Controls.Add(this.btnCopyPublicKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopyEncrypts);
            this.Controls.Add(this.rTbKey);
            this.Controls.Add(this.btnCopyKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.tbPlainDecryption);
            this.Controls.Add(this.tbEncrypted);
            this.Controls.Add(this.tbPlainEncryption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Assymetric Encryption RSA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlainEncryption;
        private System.Windows.Forms.TextBox tbEncrypted;
        private System.Windows.Forms.TextBox tbPlainDecryption;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopyKey;
        private System.Windows.Forms.RichTextBox rTbKey;
        private System.Windows.Forms.Button btnCopyEncrypts;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSavePublicKey;
        private System.Windows.Forms.RichTextBox rTbPublicKey;
        private System.Windows.Forms.Button btnCopyPublicKey;
        private System.Windows.Forms.Label label5;
    }
}

