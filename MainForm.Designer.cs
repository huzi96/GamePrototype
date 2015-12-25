namespace GamePrototype
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码


        partial class FIELD : System.Windows.Forms.Panel
        {
        }
        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Field = new GamePrototype.MainForm.FIELD();
            this.showWord = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.Location = new System.Drawing.Point(59, 59);
            this.Field.Margin = new System.Windows.Forms.Padding(50);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(482, 482);
            this.Field.TabIndex = 0;
            // 
            // showWord
            // 
            this.showWord.AutoSize = true;
            this.showWord.Location = new System.Drawing.Point(595, 59);
            this.showWord.Name = "showWord";
            this.showWord.Size = new System.Drawing.Size(74, 31);
            this.showWord.TabIndex = 1;
            this.showWord.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showWord);
            this.Controls.Add(this.Field);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Wordament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FIELD Field;
        private System.Windows.Forms.Label showWord;
        private System.Windows.Forms.Button button1;
    }
}

