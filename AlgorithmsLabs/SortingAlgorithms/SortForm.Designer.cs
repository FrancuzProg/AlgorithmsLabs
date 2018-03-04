namespace AlgorithmsLabs
{
    partial class SortForm
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
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvArray = new System.Windows.Forms.DataGridView();
            this.btnRandom = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.lblArray = new System.Windows.Forms.Label();
            this.lblSortedArray = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSortTime = new System.Windows.Forms.Label();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnShakerSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.dgvSortedArray = new System.Windows.Forms.DataGridView();
            this.lblCompare = new System.Windows.Forms.Label();
            this.lblNumCompare = new System.Windows.Forms.Label();
            this.lblSwap = new System.Windows.Forms.Label();
            this.lblNumSwap = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortedArray)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Arial", 18F);
            this.tbNumber.Location = new System.Drawing.Point(20, 100);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(84, 35);
            this.tbNumber.TabIndex = 36;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberValidating);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(167, 94);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 45);
            this.btnRemove.TabIndex = 39;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(112, 94);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvArray
            // 
            this.dgvArray.AllowUserToAddRows = false;
            this.dgvArray.AllowUserToDeleteRows = false;
            this.dgvArray.AllowUserToResizeColumns = false;
            this.dgvArray.AllowUserToResizeRows = false;
            this.dgvArray.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArray.ColumnHeadersVisible = false;
            this.dgvArray.EnableHeadersVisualStyles = false;
            this.dgvArray.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArray.Location = new System.Drawing.Point(20, 46);
            this.dgvArray.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArray.MultiSelect = false;
            this.dgvArray.Name = "dgvArray";
            this.dgvArray.RowHeadersVisible = false;
            this.dgvArray.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvArray.Size = new System.Drawing.Size(480, 25);
            this.dgvArray.TabIndex = 37;
            this.dgvArray.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvArray_CellValidating);
            // 
            // btnRandom
            // 
            this.btnRandom.Enabled = false;
            this.btnRandom.Font = new System.Drawing.Font("Arial", 12F);
            this.btnRandom.Location = new System.Drawing.Point(230, 95);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(192, 46);
            this.btnRandom.TabIndex = 41;
            this.btnRandom.Text = "Заполнить случайными элементами";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // tbRandom
            // 
            this.tbRandom.Font = new System.Drawing.Font("Arial", 18F);
            this.tbRandom.Location = new System.Drawing.Point(430, 100);
            this.tbRandom.Margin = new System.Windows.Forms.Padding(4);
            this.tbRandom.MaxLength = 3;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.Size = new System.Drawing.Size(70, 35);
            this.tbRandom.TabIndex = 40;
            this.tbRandom.TextChanged += new System.EventHandler(this.tbRandom_TextChanged);
            this.tbRandom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberValidating);
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(17, 18);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(138, 18);
            this.lblArray.TabIndex = 43;
            this.lblArray.Text = "Исходный массив";
            // 
            // lblSortedArray
            // 
            this.lblSortedArray.AutoSize = true;
            this.lblSortedArray.Location = new System.Drawing.Point(17, 262);
            this.lblSortedArray.Name = "lblSortedArray";
            this.lblSortedArray.Size = new System.Drawing.Size(182, 18);
            this.lblSortedArray.TabIndex = 44;
            this.lblSortedArray.Text = "Сортированный массив";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(17, 339);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(152, 18);
            this.lblTime.TabIndex = 45;
            this.lblTime.Text = "Время сортировки: ";
            // 
            // lblSortTime
            // 
            this.lblSortTime.AutoSize = true;
            this.lblSortTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortTime.Location = new System.Drawing.Point(159, 342);
            this.lblSortTime.Name = "lblSortTime";
            this.lblSortTime.Size = new System.Drawing.Size(58, 16);
            this.lblSortTime.TabIndex = 46;
            this.lblSortTime.Text = "00:00:00";
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSelectionSort.Location = new System.Drawing.Point(20, 149);
            this.btnSelectionSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(239, 46);
            this.btnSelectionSort.TabIndex = 47;
            this.btnSelectionSort.Text = "Сортировка выбором";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnShakerSort
            // 
            this.btnShakerSort.Font = new System.Drawing.Font("Arial", 12F);
            this.btnShakerSort.Location = new System.Drawing.Point(20, 203);
            this.btnShakerSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnShakerSort.Name = "btnShakerSort";
            this.btnShakerSort.Size = new System.Drawing.Size(239, 46);
            this.btnShakerSort.TabIndex = 48;
            this.btnShakerSort.Text = "Шейкерная сортировка";
            this.btnShakerSort.UseVisualStyleBackColor = true;
            this.btnShakerSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Font = new System.Drawing.Font("Arial", 12F);
            this.btnQuickSort.Location = new System.Drawing.Point(267, 203);
            this.btnQuickSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(239, 46);
            this.btnQuickSort.TabIndex = 50;
            this.btnQuickSort.Text = "Быстрая сортировка";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Font = new System.Drawing.Font("Arial", 12F);
            this.btnBubbleSort.Location = new System.Drawing.Point(267, 149);
            this.btnBubbleSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(239, 46);
            this.btnBubbleSort.TabIndex = 49;
            this.btnBubbleSort.Text = "Пузырьковая сортировка";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // dgvSortedArray
            // 
            this.dgvSortedArray.AllowUserToAddRows = false;
            this.dgvSortedArray.AllowUserToDeleteRows = false;
            this.dgvSortedArray.AllowUserToResizeColumns = false;
            this.dgvSortedArray.AllowUserToResizeRows = false;
            this.dgvSortedArray.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSortedArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSortedArray.ColumnHeadersVisible = false;
            this.dgvSortedArray.EnableHeadersVisualStyles = false;
            this.dgvSortedArray.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSortedArray.Location = new System.Drawing.Point(20, 290);
            this.dgvSortedArray.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSortedArray.MultiSelect = false;
            this.dgvSortedArray.Name = "dgvSortedArray";
            this.dgvSortedArray.ReadOnly = true;
            this.dgvSortedArray.RowHeadersVisible = false;
            this.dgvSortedArray.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSortedArray.Size = new System.Drawing.Size(480, 25);
            this.dgvSortedArray.TabIndex = 51;
            // 
            // lblCompare
            // 
            this.lblCompare.AutoSize = true;
            this.lblCompare.Location = new System.Drawing.Point(175, 369);
            this.lblCompare.Name = "lblCompare";
            this.lblCompare.Size = new System.Drawing.Size(17, 18);
            this.lblCompare.TabIndex = 53;
            this.lblCompare.Text = "0";
            // 
            // lblNumCompare
            // 
            this.lblNumCompare.AutoSize = true;
            this.lblNumCompare.Location = new System.Drawing.Point(30, 369);
            this.lblNumCompare.Name = "lblNumCompare";
            this.lblNumCompare.Size = new System.Drawing.Size(139, 18);
            this.lblNumCompare.TabIndex = 52;
            this.lblNumCompare.Text = "Число сравнений: ";
            // 
            // lblSwap
            // 
            this.lblSwap.AutoSize = true;
            this.lblSwap.Location = new System.Drawing.Point(175, 391);
            this.lblSwap.Name = "lblSwap";
            this.lblSwap.Size = new System.Drawing.Size(17, 18);
            this.lblSwap.TabIndex = 55;
            this.lblSwap.Text = "0";
            // 
            // lblNumSwap
            // 
            this.lblNumSwap.AutoSize = true;
            this.lblNumSwap.Location = new System.Drawing.Point(5, 391);
            this.lblNumSwap.Name = "lblNumSwap";
            this.lblNumSwap.Size = new System.Drawing.Size(164, 18);
            this.lblNumSwap.TabIndex = 54;
            this.lblNumSwap.Text = "Число перестановок: ";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(360, 354);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 50);
            this.btnBack.TabIndex = 58;
            this.btnBack.Text = "Меню";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 416);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSwap);
            this.Controls.Add(this.lblNumSwap);
            this.Controls.Add(this.lblCompare);
            this.Controls.Add(this.lblNumCompare);
            this.Controls.Add(this.dgvSortedArray);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnShakerSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.lblSortTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSortedArray);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.tbRandom);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvArray);
            this.Controls.Add(this.tbNumber);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(530, 455);
            this.MinimumSize = new System.Drawing.Size(530, 455);
            this.Name = "SortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка массива";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SortForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortedArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvArray;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Label lblSortedArray;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSortTime;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnShakerSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.DataGridView dgvSortedArray;
        private System.Windows.Forms.Label lblCompare;
        private System.Windows.Forms.Label lblNumCompare;
        private System.Windows.Forms.Label lblSwap;
        private System.Windows.Forms.Label lblNumSwap;
        private System.Windows.Forms.Button btnBack;
    }
}