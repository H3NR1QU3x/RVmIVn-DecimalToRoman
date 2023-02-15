namespace RVmIVn
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rdbRomanNumeral = new System.Windows.Forms.RadioButton();
            this.rdbDecimal = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbRomanNumeral
            // 
            resources.ApplyResources(this.rdbRomanNumeral, "rdbRomanNumeral");
            this.rdbRomanNumeral.Checked = true;
            this.rdbRomanNumeral.Name = "rdbRomanNumeral";
            this.rdbRomanNumeral.TabStop = true;
            this.rdbRomanNumeral.UseVisualStyleBackColor = true;
            this.rdbRomanNumeral.CheckedChanged += new System.EventHandler(this.rdbRomanNumeral_CheckedChanged);
            // 
            // rdbDecimal
            // 
            resources.ApplyResources(this.rdbDecimal, "rdbDecimal");
            this.rdbDecimal.Name = "rdbDecimal";
            this.rdbDecimal.UseVisualStyleBackColor = true;
            this.rdbDecimal.CheckedChanged += new System.EventHandler(this.rdbDecimal_CheckedChanged);
            // 
            // txtOutput
            // 
            resources.ApplyResources(this.txtOutput, "txtOutput");
            this.txtOutput.Name = "txtOutput";
            // 
            // txtInput
            // 
            resources.ApplyResources(this.txtInput, "txtInput");
            this.txtInput.Name = "txtInput";
            // 
            // btnConvert
            // 
            resources.ApplyResources(this.btnConvert, "btnConvert");
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHelp
            // 
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            resources.ApplyResources(this.btnPaste, "btnPaste");
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.rdbDecimal);
            this.Controls.Add(this.rdbRomanNumeral);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbRomanNumeral;
        private System.Windows.Forms.RadioButton rdbDecimal;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
    }
}

