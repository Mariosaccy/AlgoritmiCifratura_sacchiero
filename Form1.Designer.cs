namespace AlgoritmiCifratura_Sacchiero
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_input = new System.Windows.Forms.TextBox();
            this.nmr_numero = new System.Windows.Forms.NumericUpDown();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.btn_cripta = new System.Windows.Forms.Button();
            this.btn_decripta = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.lbl_inputfldr = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.cmb_scelta = new System.Windows.Forms.ComboBox();
            this.lbl_alg = new System.Windows.Forms.Label();
            this.flp_shiftIn = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_keyIn = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_chiave = new System.Windows.Forms.Label();
            this.txt_chiave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_numero)).BeginInit();
            this.flp_shiftIn.SuspendLayout();
            this.flp_keyIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(70, 124);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(290, 20);
            this.txt_input.TabIndex = 0;
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // nmr_numero
            // 
            this.nmr_numero.Location = new System.Drawing.Point(3, 16);
            this.nmr_numero.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.nmr_numero.Minimum = new decimal(new int[] {
            25000,
            0,
            0,
            -2147483648});
            this.nmr_numero.Name = "nmr_numero";
            this.nmr_numero.Size = new System.Drawing.Size(120, 20);
            this.nmr_numero.TabIndex = 2;
            this.nmr_numero.ValueChanged += new System.EventHandler(this.nmr_numero_ValueChanged);
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(3, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(90, 13);
            this.lbl_numero.TabIndex = 3;
            this.lbl_numero.Text = "numero da 0 a 25";
            this.lbl_numero.Click += new System.EventHandler(this.lbl_numero_Click);
            // 
            // btn_cripta
            // 
            this.btn_cripta.Location = new System.Drawing.Point(70, 173);
            this.btn_cripta.Name = "btn_cripta";
            this.btn_cripta.Size = new System.Drawing.Size(75, 23);
            this.btn_cripta.TabIndex = 4;
            this.btn_cripta.Text = "cripta";
            this.btn_cripta.UseVisualStyleBackColor = true;
            this.btn_cripta.Click += new System.EventHandler(this.btn_cripta_Click);
            // 
            // btn_decripta
            // 
            this.btn_decripta.Location = new System.Drawing.Point(170, 173);
            this.btn_decripta.Name = "btn_decripta";
            this.btn_decripta.Size = new System.Drawing.Size(75, 23);
            this.btn_decripta.TabIndex = 5;
            this.btn_decripta.Text = "decripta";
            this.btn_decripta.UseVisualStyleBackColor = true;
            this.btn_decripta.Click += new System.EventHandler(this.btn_decripta_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(70, 227);
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(290, 20);
            this.txt_output.TabIndex = 1;
            this.txt_output.TextChanged += new System.EventHandler(this.txt_output_TextChanged);
            // 
            // lbl_inputfldr
            // 
            this.lbl_inputfldr.AutoSize = true;
            this.lbl_inputfldr.Location = new System.Drawing.Point(67, 108);
            this.lbl_inputfldr.Name = "lbl_inputfldr";
            this.lbl_inputfldr.Size = new System.Drawing.Size(30, 13);
            this.lbl_inputfldr.TabIndex = 7;
            this.lbl_inputfldr.Text = "input";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(67, 211);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(37, 13);
            this.lbl_output.TabIndex = 8;
            this.lbl_output.Text = "output";
            // 
            // cmb_scelta
            // 
            this.cmb_scelta.FormattingEnabled = true;
            this.cmb_scelta.Location = new System.Drawing.Point(170, 17);
            this.cmb_scelta.Name = "cmb_scelta";
            this.cmb_scelta.Size = new System.Drawing.Size(121, 21);
            this.cmb_scelta.TabIndex = 9;
            this.cmb_scelta.SelectedIndexChanged += new System.EventHandler(this.cmb_scelta_SelectedIndexChanged);
            // 
            // lbl_alg
            // 
            this.lbl_alg.AutoSize = true;
            this.lbl_alg.Location = new System.Drawing.Point(83, 20);
            this.lbl_alg.Name = "lbl_alg";
            this.lbl_alg.Size = new System.Drawing.Size(49, 13);
            this.lbl_alg.TabIndex = 10;
            this.lbl_alg.Text = "algoritmo";
            // 
            // flp_shiftIn
            // 
            this.flp_shiftIn.Controls.Add(this.lbl_numero);
            this.flp_shiftIn.Controls.Add(this.nmr_numero);
            this.flp_shiftIn.Location = new System.Drawing.Point(70, 44);
            this.flp_shiftIn.Name = "flp_shiftIn";
            this.flp_shiftIn.Size = new System.Drawing.Size(136, 51);
            this.flp_shiftIn.TabIndex = 11;
            // 
            // flp_keyIn
            // 
            this.flp_keyIn.Controls.Add(this.lbl_chiave);
            this.flp_keyIn.Controls.Add(this.txt_chiave);
            this.flp_keyIn.Location = new System.Drawing.Point(226, 44);
            this.flp_keyIn.Name = "flp_keyIn";
            this.flp_keyIn.Size = new System.Drawing.Size(134, 51);
            this.flp_keyIn.TabIndex = 12;
            // 
            // lbl_chiave
            // 
            this.lbl_chiave.AutoSize = true;
            this.lbl_chiave.Location = new System.Drawing.Point(3, 0);
            this.lbl_chiave.Name = "lbl_chiave";
            this.lbl_chiave.Size = new System.Drawing.Size(79, 13);
            this.lbl_chiave.TabIndex = 0;
            this.lbl_chiave.Text = "inserisci chiave";
            // 
            // txt_chiave
            // 
            this.txt_chiave.Location = new System.Drawing.Point(3, 16);
            this.txt_chiave.Name = "txt_chiave";
            this.txt_chiave.Size = new System.Drawing.Size(100, 20);
            this.txt_chiave.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 264);
            this.Controls.Add(this.flp_keyIn);
            this.Controls.Add(this.flp_shiftIn);
            this.Controls.Add(this.lbl_alg);
            this.Controls.Add(this.cmb_scelta);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_inputfldr);
            this.Controls.Add(this.btn_decripta);
            this.Controls.Add(this.btn_cripta);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Algoritmi di cifratura Sacchiero";
            ((System.ComponentModel.ISupportInitialize)(this.nmr_numero)).EndInit();
            this.flp_shiftIn.ResumeLayout(false);
            this.flp_shiftIn.PerformLayout();
            this.flp_keyIn.ResumeLayout(false);
            this.flp_keyIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.NumericUpDown nmr_numero;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Button btn_cripta;
        private System.Windows.Forms.Button btn_decripta;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label lbl_inputfldr;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.ComboBox cmb_scelta;
        private System.Windows.Forms.Label lbl_alg;
        private System.Windows.Forms.FlowLayoutPanel flp_shiftIn;
        private System.Windows.Forms.FlowLayoutPanel flp_keyIn;
        private System.Windows.Forms.Label lbl_chiave;
        private System.Windows.Forms.TextBox txt_chiave;
    }
}

