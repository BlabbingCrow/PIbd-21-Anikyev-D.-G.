namespace Sem3TecPr1
{
    partial class FormTractor
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
            this.pictureBoxTractors = new System.Windows.Forms.PictureBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractors)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTractors
            // 
            this.pictureBoxTractors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTractors.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTractors.Name = "pictureBoxTractors";
            this.pictureBoxTractors.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxTractors.TabIndex = 0;
            this.pictureBoxTractors.TabStop = false;
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::Sem3TecPr1.Properties.Resources.ArrowUp;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(762, 343);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(50, 50);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::Sem3TecPr1.Properties.Resources.ArrowDown;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(762, 399);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(50, 50);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::Sem3TecPr1.Properties.Resources.ArrowLeft;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(706, 399);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(50, 50);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::Sem3TecPr1.Properties.Resources.ArrowRight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(818, 399);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(50, 50);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // FormTractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.pictureBoxTractors);
            this.Name = "FormTractor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Трактор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTractors;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonCreate;
    }
}

