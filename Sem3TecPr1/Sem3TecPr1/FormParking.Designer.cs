﻿namespace Sem3TecPr1
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonAddTractor = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            this.buttonTakeTractor = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1000, 680);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonAddTractor
            // 
            this.buttonAddTractor.Location = new System.Drawing.Point(1006, 314);
            this.buttonAddTractor.Name = "buttonAddTractor";
            this.buttonAddTractor.Size = new System.Drawing.Size(165, 59);
            this.buttonAddTractor.TabIndex = 1;
            this.buttonAddTractor.Text = "Заказать технику";
            this.buttonAddTractor.UseVisualStyleBackColor = true;
            this.buttonAddTractor.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxTakeCar);
            this.groupBox.Controls.Add(this.buttonTakeTractor);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Location = new System.Drawing.Point(1007, 427);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(165, 242);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Забрать машину";
            // 
            // pictureBoxTakeCar
            // 
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(6, 108);
            this.pictureBoxTakeCar.Name = "pictureBoxTakeCar";
            this.pictureBoxTakeCar.Size = new System.Drawing.Size(153, 125);
            this.pictureBoxTakeCar.TabIndex = 3;
            this.pictureBoxTakeCar.TabStop = false;
            // 
            // buttonTakeTractor
            // 
            this.buttonTakeTractor.Location = new System.Drawing.Point(43, 72);
            this.buttonTakeTractor.Name = "buttonTakeTractor";
            this.buttonTakeTractor.Size = new System.Drawing.Size(80, 30);
            this.buttonTakeTractor.TabIndex = 2;
            this.buttonTakeTractor.Text = "Забрать";
            this.buttonTakeTractor.UseVisualStyleBackColor = true;
            this.buttonTakeTractor.Click += new System.EventHandler(this.buttonTakeTractor_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(54, 28);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(79, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Место:";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(1008, 12);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(164, 82);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonAddTractor);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonAddTractor;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
        private System.Windows.Forms.Button buttonTakeTractor;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}