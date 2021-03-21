
namespace FF8_Save_Swapper
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
            this.list_saves = new System.Windows.Forms.ListBox();
            this.btn_swap = new System.Windows.Forms.Button();
            this.lbl_explanation = new System.Windows.Forms.Label();
            this.btn_setSaveFolder = new System.Windows.Forms.Button();
            this.lbl_saveFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_saves
            // 
            this.list_saves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_saves.FormattingEnabled = true;
            this.list_saves.Location = new System.Drawing.Point(12, 12);
            this.list_saves.Name = "list_saves";
            this.list_saves.Size = new System.Drawing.Size(491, 459);
            this.list_saves.TabIndex = 0;
            // 
            // btn_swap
            // 
            this.btn_swap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_swap.Location = new System.Drawing.Point(12, 506);
            this.btn_swap.Name = "btn_swap";
            this.btn_swap.Size = new System.Drawing.Size(92, 23);
            this.btn_swap.TabIndex = 1;
            this.btn_swap.Text = "Go";
            this.btn_swap.UseVisualStyleBackColor = true;
            this.btn_swap.Click += new System.EventHandler(this.btn_swap_Click);
            // 
            // lbl_explanation
            // 
            this.lbl_explanation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_explanation.AutoSize = true;
            this.lbl_explanation.Location = new System.Drawing.Point(110, 511);
            this.lbl_explanation.Name = "lbl_explanation";
            this.lbl_explanation.Size = new System.Drawing.Size(238, 13);
            this.lbl_explanation.TabIndex = 2;
            this.lbl_explanation.Text = "Clicking Go will replace the save in card 2 slot 28";
            // 
            // btn_setSaveFolder
            // 
            this.btn_setSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_setSaveFolder.Location = new System.Drawing.Point(12, 477);
            this.btn_setSaveFolder.Name = "btn_setSaveFolder";
            this.btn_setSaveFolder.Size = new System.Drawing.Size(92, 23);
            this.btn_setSaveFolder.TabIndex = 5;
            this.btn_setSaveFolder.Text = "Set User Folder";
            this.btn_setSaveFolder.UseVisualStyleBackColor = true;
            this.btn_setSaveFolder.Click += new System.EventHandler(this.btn_setSaveFolder_Click);
            // 
            // lbl_saveFolder
            // 
            this.lbl_saveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_saveFolder.AutoSize = true;
            this.lbl_saveFolder.Location = new System.Drawing.Point(110, 482);
            this.lbl_saveFolder.Name = "lbl_saveFolder";
            this.lbl_saveFolder.Size = new System.Drawing.Size(211, 13);
            this.lbl_saveFolder.TabIndex = 6;
            this.lbl_saveFolder.Text = "<-- Click first to select your FF8 saves folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 541);
            this.Controls.Add(this.lbl_saveFolder);
            this.Controls.Add(this.btn_setSaveFolder);
            this.Controls.Add(this.lbl_explanation);
            this.Controls.Add(this.btn_swap);
            this.Controls.Add(this.list_saves);
            this.MinimumSize = new System.Drawing.Size(531, 580);
            this.Name = "Form1";
            this.Text = "FFVIII Save Swapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_saves;
        private System.Windows.Forms.Button btn_swap;
        private System.Windows.Forms.Label lbl_explanation;
        private System.Windows.Forms.Button btn_setSaveFolder;
        private System.Windows.Forms.Label lbl_saveFolder;
    }
}

