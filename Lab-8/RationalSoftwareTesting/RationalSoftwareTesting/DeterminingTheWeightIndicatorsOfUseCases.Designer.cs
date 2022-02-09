
namespace RationalSoftwareTesting
{
    partial class DeterminingTheWeightIndicatorsOfUseCases
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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUCP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUUCP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(15, 415);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(80, 23);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "Вернуться";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(712, 415);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(80, 23);
            this.buttonContinue.TabIndex = 1;
            this.buttonContinue.Text = "Продолжить";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Тип";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Вариант использования";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(389, 72);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(308, 72);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBox
            // 
            this.comboBox.DisplayMember = "Character";
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(268, 45);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(196, 21);
            this.comboBox.TabIndex = 12;
            this.comboBox.ValueMember = "Type";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 45);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(250, 21);
            this.textBox.TabIndex = 11;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 116);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 259);
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Вариант использования";
            this.columnHeader1.Width = 389;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тип";
            this.columnHeader2.Width = 371;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "UCP";
            // 
            // textBoxUCP
            // 
            this.textBoxUCP.Location = new System.Drawing.Point(538, 45);
            this.textBoxUCP.Name = "textBoxUCP";
            this.textBoxUCP.ReadOnly = true;
            this.textBoxUCP.Size = new System.Drawing.Size(100, 20);
            this.textBoxUCP.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "UUCP";
            // 
            // textBoxUUCP
            // 
            this.textBoxUUCP.Location = new System.Drawing.Point(644, 45);
            this.textBoxUUCP.Name = "textBoxUUCP";
            this.textBoxUUCP.ReadOnly = true;
            this.textBoxUUCP.Size = new System.Drawing.Size(100, 20);
            this.textBoxUUCP.TabIndex = 19;
            // 
            // DeterminingTheWeightIndicatorsOfUseCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUUCP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUCP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonReturn);
            this.Name = "DeterminingTheWeightIndicatorsOfUseCases";
            this.Text = "Определение весовых показателей вариантов использования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUUCP;
    }
}