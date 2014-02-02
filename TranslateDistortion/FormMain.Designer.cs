namespace TranslateDistortion
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSourceString = new System.Windows.Forms.TextBox();
            this.lbTranslateDirections = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDownDirection = new System.Windows.Forms.Button();
            this.btnUpDirection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(654, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Запустить";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSourceString);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Строка для искажения";
            // 
            // tbSourceString
            // 
            this.tbSourceString.Location = new System.Drawing.Point(6, 22);
            this.tbSourceString.MaxLength = 140;
            this.tbSourceString.Name = "tbSourceString";
            this.tbSourceString.Size = new System.Drawing.Size(642, 20);
            this.tbSourceString.TabIndex = 1;
            // 
            // lbTranslateDirections
            // 
            this.lbTranslateDirections.FormattingEnabled = true;
            this.lbTranslateDirections.Location = new System.Drawing.Point(6, 19);
            this.lbTranslateDirections.Name = "lbTranslateDirections";
            this.lbTranslateDirections.Size = new System.Drawing.Size(162, 121);
            this.lbTranslateDirections.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbResults);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 302);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(6, 19);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(582, 277);
            this.lbResults.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDownDirection);
            this.groupBox3.Controls.Add(this.btnUpDirection);
            this.groupBox3.Controls.Add(this.lbTranslateDirections);
            this.groupBox3.Location = new System.Drawing.Point(612, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 178);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Направления перевода";
            // 
            // btnDownDirection
            // 
            this.btnDownDirection.Location = new System.Drawing.Point(43, 146);
            this.btnDownDirection.Name = "btnDownDirection";
            this.btnDownDirection.Size = new System.Drawing.Size(31, 23);
            this.btnDownDirection.TabIndex = 4;
            this.btnDownDirection.Text = "D";
            this.btnDownDirection.UseVisualStyleBackColor = true;
            // 
            // btnUpDirection
            // 
            this.btnUpDirection.Location = new System.Drawing.Point(6, 146);
            this.btnUpDirection.Name = "btnUpDirection";
            this.btnUpDirection.Size = new System.Drawing.Size(31, 23);
            this.btnUpDirection.TabIndex = 3;
            this.btnUpDirection.Text = "U";
            this.btnUpDirection.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сейчас переводится: ru -> en";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSourceString;
        private System.Windows.Forms.ListBox lbTranslateDirections;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDownDirection;
        private System.Windows.Forms.Button btnUpDirection;
        private System.Windows.Forms.Label label1;
    }
}

