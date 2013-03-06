namespace bb_Assignment_Sorter
{
    partial class MainWindow
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
            this.folderChooser = new System.Windows.Forms.FolderBrowserDialog();
            this.keepOriginals = new System.Windows.Forms.CheckBox();
            this.chooseFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dropArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keepOriginals
            // 
            this.keepOriginals.AutoSize = true;
            this.keepOriginals.Location = new System.Drawing.Point(12, 12);
            this.keepOriginals.Name = "keepOriginals";
            this.keepOriginals.Size = new System.Drawing.Size(153, 17);
            this.keepOriginals.TabIndex = 0;
            this.keepOriginals.Text = "Do not remove original files";
            this.keepOriginals.UseVisualStyleBackColor = true;
            // 
            // chooseFolder
            // 
            this.chooseFolder.Location = new System.Drawing.Point(40, 273);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(379, 23);
            this.chooseFolder.TabIndex = 1;
            this.chooseFolder.Text = "Choose Folder";
            this.chooseFolder.UseVisualStyleBackColor = true;
            this.chooseFolder.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Or:";
            // 
            // dropArea
            // 
            this.dropArea.AllowDrop = true;
            this.dropArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropArea.Location = new System.Drawing.Point(12, 32);
            this.dropArea.Name = "dropArea";
            this.dropArea.Size = new System.Drawing.Size(407, 238);
            this.dropArea.TabIndex = 4;
            this.dropArea.Text = "Drop a Folder Here";
            this.dropArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dropArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropArea_DragDrop);
            this.dropArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropArea_DragEnter);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(431, 308);
            this.Controls.Add(this.dropArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseFolder);
            this.Controls.Add(this.keepOriginals);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "bb Assignment Sorter";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderChooser;
        private System.Windows.Forms.CheckBox keepOriginals;
        private System.Windows.Forms.Button chooseFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dropArea;
    }
}

