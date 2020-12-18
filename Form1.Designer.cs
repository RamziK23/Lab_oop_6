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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paint_box = new System.Windows.Forms.Panel();
            this.button_deletestorage = new System.Windows.Forms.Button();
            this.button_del__item_storage = new System.Windows.Forms.Button();
            this.drawellipse = new System.Windows.Forms.Button();
            this.drawline = new System.Windows.Forms.Button();
            this.drawsquare = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
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
            // button_deletestorage
            // 
            this.button_deletestorage.Location = new System.Drawing.Point(693, 55);
            this.button_deletestorage.Name = "button_deletestorage";
            this.button_deletestorage.Size = new System.Drawing.Size(95, 36);
            this.button_deletestorage.TabIndex = 2;
            this.button_deletestorage.Text = "button_deletestorage";
            this.button_deletestorage.UseVisualStyleBackColor = true;
            this.button_deletestorage.Click += new System.EventHandler(this.button_deletestorage_Click);
            this.button_deletestorage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // button_del__item_storage
            // 
            this.button_del__item_storage.Location = new System.Drawing.Point(693, 97);
            this.button_del__item_storage.Name = "button_del__item_storage";
            this.button_del__item_storage.Size = new System.Drawing.Size(95, 37);
            this.button_del__item_storage.TabIndex = 3;
            this.button_del__item_storage.Text = "button_del__item_storage";
            this.button_del__item_storage.UseVisualStyleBackColor = true;
            this.button_del__item_storage.Click += new System.EventHandler(this.button_del__item_storage_Click);
            this.button_del__item_storage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // drawellipse
            // 
            this.drawellipse.Location = new System.Drawing.Point(693, 182);
            this.drawellipse.Name = "drawellipse";
            this.drawellipse.Size = new System.Drawing.Size(75, 23);
            this.drawellipse.TabIndex = 5;
            this.drawellipse.Text = "Круг";
            this.drawellipse.UseVisualStyleBackColor = true;
            // 
            // drawline
            // 
            this.drawline.Location = new System.Drawing.Point(693, 211);
            this.drawline.Name = "drawline";
            this.drawline.Size = new System.Drawing.Size(75, 23);
            this.drawline.TabIndex = 6;
            this.drawline.Text = "Линия";
            this.drawline.UseVisualStyleBackColor = true;
            // 
            // drawsquare
            // 
            this.drawsquare.Location = new System.Drawing.Point(693, 240);
            this.drawsquare.Name = "drawsquare";
            this.drawsquare.Size = new System.Drawing.Size(75, 23);
            this.drawsquare.TabIndex = 7;
            this.drawsquare.Text = "Квадрат";
            this.drawsquare.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.CheckOnClick = true;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.CheckOnClick = true;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.drawsquare);
            this.Controls.Add(this.drawline);
            this.Controls.Add(this.drawellipse);
            this.Controls.Add(this.button_del__item_storage);
            this.Controls.Add(this.button_deletestorage);
            this.Controls.Add(this.paint_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paint_box;
        private System.Windows.Forms.Button button_deletestorage;
        private System.Windows.Forms.Button button_del__item_storage;
        private System.Windows.Forms.Button drawellipse;
        private System.Windows.Forms.Button drawline;
        private System.Windows.Forms.Button drawsquare;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

