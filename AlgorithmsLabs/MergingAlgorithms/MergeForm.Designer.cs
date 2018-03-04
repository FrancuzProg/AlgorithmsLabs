namespace AlgorithmsLabs
{
    partial class MergeForm
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
            this.btnSort = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnRandomSort = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblSortTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSort.Location = new System.Drawing.Point(13, 63);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(404, 46);
            this.btnSort.TabIndex = 48;
            this.btnSort.Text = "Внешняя сортировка естественным слиянием";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.Location = new System.Drawing.Point(13, 33);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(379, 22);
            this.tbPath.TabIndex = 49;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPath.Location = new System.Drawing.Point(12, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(50, 20);
            this.lblPath.TabIndex = 50;
            this.lblPath.Text = "Путь:";
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("Arial", 12F);
            this.btnPath.Location = new System.Drawing.Point(391, 32);
            this.btnPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(26, 23);
            this.btnPath.TabIndex = 51;
            this.btnPath.Text = "#";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnRandomSort
            // 
            this.btnRandomSort.Enabled = false;
            this.btnRandomSort.Font = new System.Drawing.Font("Arial", 12F);
            this.btnRandomSort.Location = new System.Drawing.Point(13, 117);
            this.btnRandomSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandomSort.Name = "btnRandomSort";
            this.btnRandomSort.Size = new System.Drawing.Size(336, 84);
            this.btnRandomSort.TabIndex = 52;
            this.btnRandomSort.Text = "Создать файл в корневой директории, заполнить его N случайными элементами и отсор" +
    "тировать";
            this.btnRandomSort.UseVisualStyleBackColor = true;
            this.btnRandomSort.Click += new System.EventHandler(this.btnRandomSort_Click);
            // 
            // tbN
            // 
            this.tbN.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbN.Location = new System.Drawing.Point(357, 152);
            this.tbN.Margin = new System.Windows.Forms.Padding(4);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(60, 29);
            this.tbN.TabIndex = 53;
            this.tbN.TextChanged += new System.EventHandler(this.tbN_TextChanged);
            this.tbN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberValidating);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblN.Location = new System.Drawing.Point(376, 128);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(20, 20);
            this.lblN.TabIndex = 54;
            this.lblN.Text = "N";
            // 
            // lblSortTime
            // 
            this.lblSortTime.AutoSize = true;
            this.lblSortTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortTime.Location = new System.Drawing.Point(172, 215);
            this.lblSortTime.Name = "lblSortTime";
            this.lblSortTime.Size = new System.Drawing.Size(70, 18);
            this.lblSortTime.TabIndex = 56;
            this.lblSortTime.Text = "00:00:00";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(12, 213);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(154, 20);
            this.lblTime.TabIndex = 55;
            this.lblTime.Text = "Время сортировки:";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(318, 207);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 32);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Меню";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 249);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSortTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.btnRandomSort);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnSort);
            this.MaximumSize = new System.Drawing.Size(442, 288);
            this.MinimumSize = new System.Drawing.Size(442, 288);
            this.Name = "MergeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внешняя сортировка слиянием";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MergeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnRandomSort;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblSortTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnBack;
    }
}