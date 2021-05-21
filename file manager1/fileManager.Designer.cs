
namespace file_manager1
{
    partial class fileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileManager));
            this.listDir = new System.Windows.Forms.ListBox();
            this.addressDir = new System.Windows.Forms.TextBox();
            this.goDir = new System.Windows.Forms.Button();
            this.backDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDir
            // 
            this.listDir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listDir.FormattingEnabled = true;
            this.listDir.ItemHeight = 16;
            this.listDir.Location = new System.Drawing.Point(0, 78);
            this.listDir.Name = "listDir";
            this.listDir.Size = new System.Drawing.Size(800, 372);
            this.listDir.TabIndex = 0;
            this.listDir.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listDir_MouseDoubleClick);
            // 
            // addressDir
            // 
            this.addressDir.Location = new System.Drawing.Point(12, 12);
            this.addressDir.Name = "addressDir";
            this.addressDir.Size = new System.Drawing.Size(696, 20);
            this.addressDir.TabIndex = 1;
            // 
            // goDir
            // 
            this.goDir.Location = new System.Drawing.Point(715, 12);
            this.goDir.Name = "goDir";
            this.goDir.Size = new System.Drawing.Size(75, 20);
            this.goDir.TabIndex = 2;
            this.goDir.Text = "перейти";
            this.goDir.UseVisualStyleBackColor = true;
            this.goDir.Click += new System.EventHandler(this.goDir_Click);
            // 
            // backDir
            // 
            this.backDir.Location = new System.Drawing.Point(13, 39);
            this.backDir.Name = "backDir";
            this.backDir.Size = new System.Drawing.Size(75, 23);
            this.backDir.TabIndex = 3;
            this.backDir.Text = "назад";
            this.backDir.UseVisualStyleBackColor = true;
            this.backDir.Click += new System.EventHandler(this.backDir_Click);
            // 
            // fileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backDir);
            this.Controls.Add(this.goDir);
            this.Controls.Add(this.addressDir);
            this.Controls.Add(this.listDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fileManager";
            this.Text = "fileManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDir;
        private System.Windows.Forms.TextBox addressDir;
        private System.Windows.Forms.Button goDir;
        private System.Windows.Forms.Button backDir;
    }
}

