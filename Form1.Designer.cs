namespace Seminar_3011
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
            this.daybox = new System.Windows.Forms.TextBox();
            this.monthbox = new System.Windows.Forms.TextBox();
            this.yearbox = new System.Windows.Forms.TextBox();
            this.setdatebtn = new System.Windows.Forms.Button();
            this.nextdatebtn = new System.Windows.Forms.Button();
            this.datelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prevdatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daybox
            // 
            this.daybox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daybox.Location = new System.Drawing.Point(12, 50);
            this.daybox.Name = "daybox";
            this.daybox.Size = new System.Drawing.Size(77, 35);
            this.daybox.TabIndex = 0;
            this.daybox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthbox
            // 
            this.monthbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthbox.Location = new System.Drawing.Point(120, 50);
            this.monthbox.Name = "monthbox";
            this.monthbox.Size = new System.Drawing.Size(77, 35);
            this.monthbox.TabIndex = 1;
            this.monthbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearbox
            // 
            this.yearbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearbox.Location = new System.Drawing.Point(233, 50);
            this.yearbox.Name = "yearbox";
            this.yearbox.Size = new System.Drawing.Size(77, 35);
            this.yearbox.TabIndex = 2;
            this.yearbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setdatebtn
            // 
            this.setdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setdatebtn.Location = new System.Drawing.Point(12, 118);
            this.setdatebtn.Name = "setdatebtn";
            this.setdatebtn.Size = new System.Drawing.Size(298, 39);
            this.setdatebtn.TabIndex = 3;
            this.setdatebtn.Text = "установить дату";
            this.setdatebtn.UseVisualStyleBackColor = true;
            this.setdatebtn.Click += new System.EventHandler(this.setdatebtn_Click);
            // 
            // nextdatebtn
            // 
            this.nextdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextdatebtn.Location = new System.Drawing.Point(15, 163);
            this.nextdatebtn.Name = "nextdatebtn";
            this.nextdatebtn.Size = new System.Drawing.Size(298, 39);
            this.nextdatebtn.TabIndex = 4;
            this.nextdatebtn.Text = "следующая дата";
            this.nextdatebtn.UseVisualStyleBackColor = true;
            this.nextdatebtn.Click += new System.EventHandler(this.nextdatebtn_Click);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datelabel.Location = new System.Drawing.Point(5, 7);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(0, 40);
            this.datelabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "день";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(117, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(230, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "год";
            // 
            // prevdatebtn
            // 
            this.prevdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevdatebtn.Location = new System.Drawing.Point(15, 208);
            this.prevdatebtn.Name = "prevdatebtn";
            this.prevdatebtn.Size = new System.Drawing.Size(298, 39);
            this.prevdatebtn.TabIndex = 9;
            this.prevdatebtn.Text = "предыдущая дата";
            this.prevdatebtn.UseVisualStyleBackColor = true;
            this.prevdatebtn.Click += new System.EventHandler(this.prevdatebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 257);
            this.Controls.Add(this.prevdatebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.nextdatebtn);
            this.Controls.Add(this.setdatebtn);
            this.Controls.Add(this.yearbox);
            this.Controls.Add(this.monthbox);
            this.Controls.Add(this.daybox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Календарь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox daybox;
        private System.Windows.Forms.TextBox monthbox;
        private System.Windows.Forms.TextBox yearbox;
        private System.Windows.Forms.Button setdatebtn;
        private System.Windows.Forms.Button nextdatebtn;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button prevdatebtn;
    }
}

