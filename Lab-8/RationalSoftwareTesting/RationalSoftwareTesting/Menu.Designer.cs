
namespace RationalSoftwareTesting
{
    partial class Menu
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
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.buttonResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Location = new System.Drawing.Point(317, 83);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(137, 71);
            this.buttonStartTest.TabIndex = 0;
            this.buttonStartTest.Text = "Начать тестирование";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // buttonResults
            // 
            this.buttonResults.Location = new System.Drawing.Point(317, 247);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(137, 71);
            this.buttonResults.TabIndex = 1;
            this.buttonResults.Text = "Просмотреть результаты";
            this.buttonResults.UseVisualStyleBackColor = true;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonResults);
            this.Controls.Add(this.buttonStartTest);
            this.Name = "Menu";
            this.Text = "Расчёт трудоёмкости разработки ПО в технологии ООП по методике Rational software";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.Button buttonResults;
    }
}

