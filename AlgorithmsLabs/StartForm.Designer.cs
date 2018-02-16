namespace AlgorithmsLabs
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnTraversal = new System.Windows.Forms.Button();
            this.btnWay = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(37, 36);
            this.btnFind.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(138, 39);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Поиск";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(37, 85);
            this.btnSort.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(138, 39);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Сортировка";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(37, 134);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(138, 39);
            this.btnMerge.TabIndex = 2;
            this.btnMerge.Text = "Слияние";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnTraversal
            // 
            this.btnTraversal.Location = new System.Drawing.Point(37, 183);
            this.btnTraversal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTraversal.Name = "btnTraversal";
            this.btnTraversal.Size = new System.Drawing.Size(138, 39);
            this.btnTraversal.TabIndex = 3;
            this.btnTraversal.Text = "Обход";
            this.btnTraversal.UseVisualStyleBackColor = true;
            this.btnTraversal.Click += new System.EventHandler(this.btnTraversal_Click);
            // 
            // btnWay
            // 
            this.btnWay.Location = new System.Drawing.Point(37, 232);
            this.btnWay.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnWay.Name = "btnWay";
            this.btnWay.Size = new System.Drawing.Size(138, 39);
            this.btnWay.TabIndex = 4;
            this.btnWay.Text = "Путь";
            this.btnWay.UseVisualStyleBackColor = true;
            this.btnWay.Click += new System.EventHandler(this.btnWay_Click);
            // 
            // btnTree
            // 
            this.btnTree.Location = new System.Drawing.Point(37, 281);
            this.btnTree.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(138, 39);
            this.btnTree.TabIndex = 5;
            this.btnTree.Text = "Остов";
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(199, 22);
            this.label.TabIndex = 6;
            this.label.Text = "Выбор лабораторной";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 334);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.btnWay);
            this.Controls.Add(this.btnTraversal);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnFind);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторные";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnTraversal;
        private System.Windows.Forms.Button btnWay;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Label label;
    }
}

