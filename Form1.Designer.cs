namespace Topic_10___Assignment
{
    partial class Form1
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
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnRAM = new System.Windows.Forms.Button();
            this.btnSSD = new System.Windows.Forms.Button();
            this.btnPSU = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.imgComponents = new System.Windows.Forms.PictureBox();
            this.lblComponentInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCPU
            // 
            this.btnCPU.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPU.Location = new System.Drawing.Point(12, 96);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(94, 29);
            this.btnCPU.TabIndex = 0;
            this.btnCPU.Text = "CPU";
            this.btnCPU.UseVisualStyleBackColor = true;
            // 
            // btnRAM
            // 
            this.btnRAM.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAM.Location = new System.Drawing.Point(12, 131);
            this.btnRAM.Name = "btnRAM";
            this.btnRAM.Size = new System.Drawing.Size(94, 29);
            this.btnRAM.TabIndex = 2;
            this.btnRAM.Text = "RAM";
            this.btnRAM.UseVisualStyleBackColor = true;
            // 
            // btnSSD
            // 
            this.btnSSD.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSD.Location = new System.Drawing.Point(12, 166);
            this.btnSSD.Name = "btnSSD";
            this.btnSSD.Size = new System.Drawing.Size(94, 29);
            this.btnSSD.TabIndex = 3;
            this.btnSSD.Text = "SSD";
            this.btnSSD.UseVisualStyleBackColor = true;
            // 
            // btnPSU
            // 
            this.btnPSU.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSU.Location = new System.Drawing.Point(12, 201);
            this.btnPSU.Name = "btnPSU";
            this.btnPSU.Size = new System.Drawing.Size(94, 29);
            this.btnPSU.TabIndex = 4;
            this.btnPSU.Text = "PSU";
            this.btnPSU.UseVisualStyleBackColor = true;
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(12, 236);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(94, 51);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Input Peripheral";
            this.btnInput.UseVisualStyleBackColor = true;
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutput.Location = new System.Drawing.Point(12, 293);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(94, 51);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "Output Peripheral";
            this.btnOutput.UseVisualStyleBackColor = true;
            // 
            // imgComponents
            // 
            this.imgComponents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgComponents.Image = global::Topic_10___Assignment.Properties.Resources.cpu;
            this.imgComponents.Location = new System.Drawing.Point(324, 104);
            this.imgComponents.Name = "imgComponents";
            this.imgComponents.Size = new System.Drawing.Size(277, 183);
            this.imgComponents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgComponents.TabIndex = 7;
            this.imgComponents.TabStop = false;
            // 
            // lblComponentInfo
            // 
            this.lblComponentInfo.BackColor = System.Drawing.Color.White;
            this.lblComponentInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComponentInfo.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentInfo.Location = new System.Drawing.Point(258, 293);
            this.lblComponentInfo.Name = "lblComponentInfo";
            this.lblComponentInfo.Size = new System.Drawing.Size(411, 93);
            this.lblComponentInfo.TabIndex = 8;
            this.lblComponentInfo.Text = "The central processing unit (CPU) is often labeled as the \"brain\" of the computer" +
    ", processing data and executing all other hardware actions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblComponentInfo);
            this.Controls.Add(this.imgComponents);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnPSU);
            this.Controls.Add(this.btnSSD);
            this.Controls.Add(this.btnRAM);
            this.Controls.Add(this.btnCPU);
            this.Name = "Form1";
            this.Text = "Computer Components!";
            ((System.ComponentModel.ISupportInitialize)(this.imgComponents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnRAM;
        private System.Windows.Forms.Button btnSSD;
        private System.Windows.Forms.Button btnPSU;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.PictureBox imgComponents;
        private System.Windows.Forms.Label lblComponentInfo;
    }
}

