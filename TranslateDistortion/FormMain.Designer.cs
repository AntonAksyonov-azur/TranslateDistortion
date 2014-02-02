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
            this.btnStartAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartCustom = new System.Windows.Forms.Button();
            this.tbSourceString = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.lTranslateStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartAll
            // 
            this.btnStartAll.Location = new System.Drawing.Point(6, 48);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(114, 23);
            this.btnStartAll.TabIndex = 0;
            this.btnStartAll.Text = "Все языки API";
            this.btnStartAll.UseVisualStyleBackColor = true;
            this.btnStartAll.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartCustom);
            this.groupBox1.Controls.Add(this.tbSourceString);
            this.groupBox1.Controls.Add(this.btnStartAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Строка для искажения";
            // 
            // btnStartCustom
            // 
            this.btnStartCustom.Location = new System.Drawing.Point(126, 48);
            this.btnStartCustom.Name = "btnStartCustom";
            this.btnStartCustom.Size = new System.Drawing.Size(114, 23);
            this.btnStartCustom.TabIndex = 2;
            this.btnStartCustom.Text = "Свой набор";
            this.btnStartCustom.UseVisualStyleBackColor = true;
            this.btnStartCustom.Click += new System.EventHandler(this.btnStartCustom_Click);
            // 
            // tbSourceString
            // 
            this.tbSourceString.Location = new System.Drawing.Point(6, 22);
            this.tbSourceString.MaxLength = 140;
            this.tbSourceString.Name = "tbSourceString";
            this.tbSourceString.Size = new System.Drawing.Size(762, 20);
            this.tbSourceString.TabIndex = 1;
            this.tbSourceString.Text = "Привет";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbResults);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 302);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(6, 13);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(756, 277);
            this.lbResults.TabIndex = 3;
            // 
            // lTranslateStatus
            // 
            this.lTranslateStatus.AutoSize = true;
            this.lTranslateStatus.Location = new System.Drawing.Point(15, 404);
            this.lTranslateStatus.Name = "lTranslateStatus";
            this.lTranslateStatus.Size = new System.Drawing.Size(153, 13);
            this.lTranslateStatus.TabIndex = 5;
            this.lTranslateStatus.Text = "Сейчас переводится: ru -> en";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 426);
            this.Controls.Add(this.lTranslateStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Translate Distortion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSourceString;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label lTranslateStatus;
        private System.Windows.Forms.Button btnStartCustom;
    }
}

