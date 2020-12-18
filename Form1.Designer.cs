namespace lab_oop_6
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
            this.paint_box = new System.Windows.Forms.Panel();
            this.button_del__item_storage = new System.Windows.Forms.Button();
            this.drawellipse = new System.Windows.Forms.Button();
            this.drawline = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paint_box
            // 
            this.paint_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paint_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paint_box.Location = new System.Drawing.Point(12, 13);
            this.paint_box.Name = "paint_box";
            this.paint_box.Size = new System.Drawing.Size(675, 426);
            this.paint_box.TabIndex = 0;
            this.paint_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paint_box_MouseClick);
            // 
            // button_del__item_storage
            // 
            this.button_del__item_storage.Location = new System.Drawing.Point(693, 13);
            this.button_del__item_storage.Name = "button_del__item_storage";
            this.button_del__item_storage.Size = new System.Drawing.Size(75, 23);
            this.button_del__item_storage.TabIndex = 3;
            this.button_del__item_storage.Text = "Удалить";
            this.button_del__item_storage.UseVisualStyleBackColor = true;
            this.button_del__item_storage.Click += new System.EventHandler(this.button_del__item_storage_Click);
            this.button_del__item_storage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // drawellipse
            // 
            this.drawellipse.Location = new System.Drawing.Point(693, 42);
            this.drawellipse.Name = "drawellipse";
            this.drawellipse.Size = new System.Drawing.Size(75, 23);
            this.drawellipse.TabIndex = 5;
            this.drawellipse.Text = "Круг";
            this.drawellipse.UseVisualStyleBackColor = true;
            this.drawellipse.Click += new System.EventHandler(this.drawellipse_Click);
            // 
            // drawline
            // 
            this.drawline.Location = new System.Drawing.Point(693, 71);
            this.drawline.Name = "drawline";
            this.drawline.Size = new System.Drawing.Size(75, 23);
            this.drawline.TabIndex = 6;
            this.drawline.Text = "Линия";
            this.drawline.UseVisualStyleBackColor = true;
            this.drawline.Click += new System.EventHandler(this.drawline_Click);
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(693, 100);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(75, 23);
            this.button_color.TabIndex = 9;
            this.button_color.Text = "Цвет";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.button_color);
            this.Controls.Add(this.drawline);
            this.Controls.Add(this.drawellipse);
            this.Controls.Add(this.button_del__item_storage);
            this.Controls.Add(this.paint_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paint_box;
        private System.Windows.Forms.Button button_del__item_storage;
        private System.Windows.Forms.Button drawellipse;
        private System.Windows.Forms.Button drawline;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_color;
    }
}

