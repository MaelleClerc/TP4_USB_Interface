namespace TP4_USB_Interface
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Forme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Frequence = new System.Windows.Forms.TrackBar();
            this.Amplitude = new System.Windows.Forms.TrackBar();
            this.Offset = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Envoi = new System.Windows.Forms.Button();
            this.Sauvegarde = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.ValeurFrequence = new System.Windows.Forms.TextBox();
            this.ValeurAmplitude = new System.Windows.Forms.TextBox();
            this.ValeurOffset = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Frequence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Offset)).BeginInit();
            this.SuspendLayout();
            // 
            // Forme
            // 
            this.Forme.FormattingEnabled = true;
            this.Forme.Items.AddRange(new object[] {
            "Sinus",
            "Carre",
            "Dent de Scie",
            "Triangle"});
            this.Forme.Location = new System.Drawing.Point(33, 89);
            this.Forme.Name = "Forme";
            this.Forme.Size = new System.Drawing.Size(121, 21);
            this.Forme.TabIndex = 0;
            this.Forme.SelectedIndexChanged += new System.EventHandler(this.Forme_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forme";
            // 
            // Frequence
            // 
            this.Frequence.LargeChange = 1;
            this.Frequence.Location = new System.Drawing.Point(33, 140);
            this.Frequence.Maximum = 100;
            this.Frequence.Minimum = 1;
            this.Frequence.Name = "Frequence";
            this.Frequence.Size = new System.Drawing.Size(444, 45);
            this.Frequence.TabIndex = 2;
            this.Frequence.Value = 20;
            this.Frequence.Scroll += new System.EventHandler(this.Frequence_Scroll);
            // 
            // Amplitude
            // 
            this.Amplitude.LargeChange = 1;
            this.Amplitude.Location = new System.Drawing.Point(33, 217);
            this.Amplitude.Maximum = 100;
            this.Amplitude.Name = "Amplitude";
            this.Amplitude.Size = new System.Drawing.Size(444, 45);
            this.Amplitude.TabIndex = 3;
            this.Amplitude.Scroll += new System.EventHandler(this.Amplitude_Scroll);
            // 
            // Offset
            // 
            this.Offset.LargeChange = 1;
            this.Offset.Location = new System.Drawing.Point(33, 289);
            this.Offset.Maximum = 50;
            this.Offset.Minimum = -50;
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(444, 45);
            this.Offset.TabIndex = 4;
            this.Offset.Scroll += new System.EventHandler(this.Offset_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fréquence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amplitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Offset";
            // 
            // Envoi
            // 
            this.Envoi.Location = new System.Drawing.Point(637, 319);
            this.Envoi.Name = "Envoi";
            this.Envoi.Size = new System.Drawing.Size(95, 71);
            this.Envoi.TabIndex = 8;
            this.Envoi.Text = "Envoi";
            this.Envoi.UseVisualStyleBackColor = true;
            this.Envoi.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Sauvegarde
            // 
            this.Sauvegarde.Location = new System.Drawing.Point(637, 124);
            this.Sauvegarde.Name = "Sauvegarde";
            this.Sauvegarde.Size = new System.Drawing.Size(95, 71);
            this.Sauvegarde.TabIndex = 9;
            this.Sauvegarde.Text = "Sauvegarde";
            this.Sauvegarde.UseVisualStyleBackColor = true;
            this.Sauvegarde.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 396);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 10;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Port série";
            // 
            // ValeurFrequence
            // 
            this.ValeurFrequence.Location = new System.Drawing.Point(492, 140);
            this.ValeurFrequence.Name = "ValeurFrequence";
            this.ValeurFrequence.Size = new System.Drawing.Size(100, 20);
            this.ValeurFrequence.TabIndex = 13;
            // 
            // ValeurAmplitude
            // 
            this.ValeurAmplitude.Location = new System.Drawing.Point(492, 217);
            this.ValeurAmplitude.Name = "ValeurAmplitude";
            this.ValeurAmplitude.Size = new System.Drawing.Size(100, 20);
            this.ValeurAmplitude.TabIndex = 14;
            // 
            // ValeurOffset
            // 
            this.ValeurOffset.Location = new System.Drawing.Point(492, 289);
            this.ValeurOffset.Name = "ValeurOffset";
            this.ValeurOffset.Size = new System.Drawing.Size(100, 20);
            this.ValeurOffset.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comboBox1.Location = new System.Drawing.Point(356, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ValeurOffset);
            this.Controls.Add(this.ValeurAmplitude);
            this.Controls.Add(this.ValeurFrequence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sauvegarde);
            this.Controls.Add(this.Envoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.Amplitude);
            this.Controls.Add(this.Frequence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Forme);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Frequence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Offset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Forme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Frequence;
        private System.Windows.Forms.TrackBar Amplitude;
        private System.Windows.Forms.TrackBar Offset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Envoi;
        private System.Windows.Forms.Button Sauvegarde;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ValeurFrequence;
        private System.Windows.Forms.TextBox ValeurAmplitude;
        private System.Windows.Forms.TextBox ValeurOffset;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

