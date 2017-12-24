namespace _10._1._12
{
    partial class Form1
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
            this.InputMatrix = new System.Windows.Forms.DataGridView();
            this.ResultMatrix = new System.Windows.Forms.DataGridView();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.InputN = new System.Windows.Forms.NumericUpDown();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).BeginInit();
            this.SuspendLayout();
            // 
            // InputMatrix
            // 
            this.InputMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputMatrix.Location = new System.Drawing.Point(9, 38);
            this.InputMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputMatrix.Name = "InputMatrix";
            this.InputMatrix.RowTemplate.Height = 24;
            this.InputMatrix.Size = new System.Drawing.Size(375, 203);
            this.InputMatrix.TabIndex = 0;
            // 
            // ResultMatrix
            // 
            this.ResultMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultMatrix.Location = new System.Drawing.Point(9, 262);
            this.ResultMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultMatrix.Name = "ResultMatrix";
            this.ResultMatrix.RowTemplate.Height = 24;
            this.ResultMatrix.Size = new System.Drawing.Size(375, 203);
            this.ResultMatrix.TabIndex = 1;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(388, 125);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(56, 24);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(388, 354);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(56, 24);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(50, 490);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(56, 24);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(268, 490);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(56, 24);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InputN
            // 
            this.InputN.Location = new System.Drawing.Point(146, 12);
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(67, 20);
            this.InputN.TabIndex = 6;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(268, 9);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(56, 24);
            this.buttonRandom.TabIndex = 7;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Кол-во строк в матрице";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.ResultMatrix);
            this.Controls.Add(this.InputMatrix);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "10.1.12";
            ((System.ComponentModel.ISupportInitialize)(this.InputMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InputMatrix;
        private System.Windows.Forms.DataGridView ResultMatrix;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown InputN;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label label1;
    }
}

