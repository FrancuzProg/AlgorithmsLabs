namespace AlgorithmsLabs
{
    partial class FindForm
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
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.tbTemplate = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbRegister = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(18, 49);
            this.rtbText.Margin = new System.Windows.Forms.Padding(4);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(749, 358);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            // 
            // tbTemplate
            // 
            this.tbTemplate.Location = new System.Drawing.Point(18, 13);
            this.tbTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.tbTemplate.Name = "tbTemplate";
            this.tbTemplate.Size = new System.Drawing.Size(454, 26);
            this.tbTemplate.TabIndex = 1;
            this.tbTemplate.TextChanged += new System.EventHandler(this.tbTemplate_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(483, 10);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 32);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Поиск";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbRegister
            // 
            this.cbRegister.AutoSize = true;
            this.cbRegister.Enabled = false;
            this.cbRegister.Location = new System.Drawing.Point(604, 15);
            this.cbRegister.Margin = new System.Windows.Forms.Padding(4);
            this.cbRegister.Name = "cbRegister";
            this.cbRegister.Size = new System.Drawing.Size(163, 22);
            this.cbRegister.TabIndex = 3;
            this.cbRegister.Text = "С учётом регистра";
            this.cbRegister.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 418);
            this.Controls.Add(this.cbRegister);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbTemplate);
            this.Controls.Add(this.rtbText);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск образа в строке";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.TextBox tbTemplate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.CheckBox cbRegister;
    }
}

