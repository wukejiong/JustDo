namespace Justdo
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

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.todoView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.completeView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnCloseTodo = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.labelOneWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(666, 60);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "╂";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // todoView
            // 
            this.todoView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.todoView.Location = new System.Drawing.Point(9, 34);
            this.todoView.Margin = new System.Windows.Forms.Padding(2);
            this.todoView.Name = "todoView";
            this.todoView.Size = new System.Drawing.Size(637, 469);
            this.todoView.TabIndex = 3;
            this.todoView.UseCompatibleStateImageBehavior = false;
            this.todoView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.todoView_ColumnClick);
            this.todoView.SelectedIndexChanged += new System.EventHandler(this.todoView_SelectedIndexChanged);
            this.todoView.DoubleClick += new System.EventHandler(this.todoView_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(599, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Todo";
            // 
            // completeView
            // 
            this.completeView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.completeView.Location = new System.Drawing.Point(722, 36);
            this.completeView.Margin = new System.Windows.Forms.Padding(2);
            this.completeView.Name = "completeView";
            this.completeView.Size = new System.Drawing.Size(334, 467);
            this.completeView.TabIndex = 5;
            this.completeView.UseCompatibleStateImageBehavior = false;
            this.completeView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.completeView_ColumnClick);
            this.completeView.SelectedIndexChanged += new System.EventHandler(this.completeView_SelectedIndexChanged);
            this.completeView.DoubleClick += new System.EventHandler(this.completeView_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1008, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Done";
            // 
            // btnComplete
            // 
            this.btnComplete.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btnComplete.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnComplete.Location = new System.Drawing.Point(666, 108);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(30, 27);
            this.btnComplete.TabIndex = 7;
            this.btnComplete.Text = ">>";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnCloseTodo
            // 
            this.btnCloseTodo.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTodo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCloseTodo.Location = new System.Drawing.Point(666, 210);
            this.btnCloseTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseTodo.Name = "btnCloseTodo";
            this.btnCloseTodo.Size = new System.Drawing.Size(30, 27);
            this.btnCloseTodo.TabIndex = 8;
            this.btnCloseTodo.Text = "X";
            this.btnCloseTodo.UseVisualStyleBackColor = true;
            this.btnCloseTodo.Click += new System.EventHandler(this.btnCloseTodo_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRestore.Location = new System.Drawing.Point(666, 159);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(30, 26);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "<<";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInfo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnInfo.Location = new System.Drawing.Point(666, 264);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(30, 26);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.Text = "？";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // labelOneWord
            // 
            this.labelOneWord.AutoSize = true;
            this.labelOneWord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOneWord.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelOneWord.Location = new System.Drawing.Point(11, 6);
            this.labelOneWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOneWord.Name = "labelOneWord";
            this.labelOneWord.Size = new System.Drawing.Size(82, 21);
            this.labelOneWord.TabIndex = 12;
            this.labelOneWord.Text = "just do it!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 514);
            this.Controls.Add(this.labelOneWord);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnCloseTodo);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.completeView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todoView);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just do it";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView todoView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView completeView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCloseTodo;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label labelOneWord;

    }
}

