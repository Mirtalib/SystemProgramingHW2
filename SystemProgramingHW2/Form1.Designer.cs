namespace SystemProgramingHW2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxFileName1 = new System.Windows.Forms.TextBox();
            this.txtBoxFileName2 = new System.Windows.Forms.TextBox();
            this.btnfrom = new System.Windows.Forms.Button();
            this.btnTo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtBoxFileName1
            // 
            this.txtBoxFileName1.Location = new System.Drawing.Point(89, 47);
            this.txtBoxFileName1.Name = "txtBoxFileName1";
            this.txtBoxFileName1.Size = new System.Drawing.Size(587, 27);
            this.txtBoxFileName1.TabIndex = 0;
            // 
            // txtBoxFileName2
            // 
            this.txtBoxFileName2.Location = new System.Drawing.Point(89, 92);
            this.txtBoxFileName2.Name = "txtBoxFileName2";
            this.txtBoxFileName2.Size = new System.Drawing.Size(587, 27);
            this.txtBoxFileName2.TabIndex = 0;
            // 
            // btnfrom
            // 
            this.btnfrom.Location = new System.Drawing.Point(694, 47);
            this.btnfrom.Name = "btnfrom";
            this.btnfrom.Size = new System.Drawing.Size(94, 29);
            this.btnfrom.TabIndex = 1;
            this.btnfrom.Text = "File...";
            this.btnfrom.UseVisualStyleBackColor = true;
            this.btnfrom.Click += new System.EventHandler(this.btnfrom_Click);
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(694, 90);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(94, 29);
            this.btnTo.TabIndex = 1;
            this.btnTo.Text = "File...";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 183);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(364, 29);
            this.progressBar1.TabIndex = 3;
            // 
            // btnSuspend
            // 
            this.btnSuspend.Location = new System.Drawing.Point(382, 183);
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Size = new System.Drawing.Size(94, 29);
            this.btnSuspend.TabIndex = 4;
            this.btnSuspend.Text = "Suspend";
            this.btnSuspend.UseVisualStyleBackColor = true;
            this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(482, 183);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(94, 29);
            this.btnResume.TabIndex = 4;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(582, 183);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(94, 29);
            this.btnAbort.TabIndex = 4;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(694, 183);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(94, 29);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 236);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnSuspend);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.btnfrom);
            this.Controls.Add(this.txtBoxFileName2);
            this.Controls.Add(this.txtBoxFileName1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxFileName1;
        private TextBox txtBoxFileName2;
        private Button btnfrom;
        private Button btnTo;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private Button btnSuspend;
        private Button btnResume;
        private Button btnAbort;
        private Button btnCopy;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
    }
}