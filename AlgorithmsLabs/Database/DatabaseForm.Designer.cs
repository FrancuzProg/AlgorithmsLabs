namespace AlgorithmsLabs
{
    partial class DatabaseForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSortings = new System.Windows.Forms.DataGridView();
            this.dvgIterations = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(799, 312);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 45);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Меню";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(12, 312);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(263, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 45);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvSortings
            // 
            this.dgvSortings.AllowUserToAddRows = false;
            this.dgvSortings.AllowUserToDeleteRows = false;
            this.dgvSortings.AllowUserToResizeRows = false;
            this.dgvSortings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSortings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSortings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            this.dgvSortings.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSortings.Location = new System.Drawing.Point(12, 12);
            this.dgvSortings.MultiSelect = false;
            this.dgvSortings.Name = "dgvSortings";
            this.dgvSortings.ReadOnly = true;
            this.dgvSortings.RowHeadersVisible = false;
            this.dgvSortings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSortings.Size = new System.Drawing.Size(671, 293);
            this.dgvSortings.TabIndex = 6;
            this.dgvSortings.SelectionChanged += new System.EventHandler(this.dgvSortings_SelectionChanged);
            // 
            // dvgIterations
            // 
            this.dvgIterations.AllowUserToAddRows = false;
            this.dvgIterations.AllowUserToDeleteRows = false;
            this.dvgIterations.AllowUserToResizeRows = false;
            this.dvgIterations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgIterations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgIterations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.dvgIterations.GridColor = System.Drawing.SystemColors.Control;
            this.dvgIterations.Location = new System.Drawing.Point(689, 12);
            this.dvgIterations.MultiSelect = false;
            this.dvgIterations.Name = "dvgIterations";
            this.dvgIterations.ReadOnly = true;
            this.dvgIterations.RowHeadersVisible = false;
            this.dvgIterations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgIterations.Size = new System.Drawing.Size(240, 293);
            this.dvgIterations.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Итерации сортировки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Тип";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Время";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Сравнения";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Перестановки";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Массив";
            this.Column5.MinimumWidth = 300;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 300;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 369);
            this.Controls.Add(this.dvgIterations);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvSortings);
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgIterations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSortings;
        private System.Windows.Forms.DataGridView dvgIterations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}