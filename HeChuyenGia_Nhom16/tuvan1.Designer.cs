
namespace HeChuyenGia_Nhom2
{
    partial class tuvan1
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
            this.dgvtuvan = new System.Windows.Forms.DataGridView();
            this.masukien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motasukien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsukien = new System.Windows.Forms.DataGridView();
            this.masukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motasukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTuVan = new System.Windows.Forms.Button();
            this.ricKQ = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtuvan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsukien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtuvan
            // 
            this.dgvtuvan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvtuvan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtuvan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masukien1,
            this.motasukien1});
            this.dgvtuvan.Location = new System.Drawing.Point(967, 143);
            this.dgvtuvan.Name = "dgvtuvan";
            this.dgvtuvan.Size = new System.Drawing.Size(412, 324);
            this.dgvtuvan.TabIndex = 3;
            // 
            // masukien1
            // 
            this.masukien1.HeaderText = "Mã sự kiện";
            this.masukien1.Name = "masukien1";
            // 
            // motasukien1
            // 
            this.motasukien1.HeaderText = "Mô tả sự kiện";
            this.motasukien1.Name = "motasukien1";
            this.motasukien1.Width = 300;
            // 
            // dgvsukien
            // 
            this.dgvsukien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvsukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsukien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masukien,
            this.motasukien});
            this.dgvsukien.GridColor = System.Drawing.Color.DarkCyan;
            this.dgvsukien.Location = new System.Drawing.Point(12, 143);
            this.dgvsukien.Name = "dgvsukien";
            this.dgvsukien.Size = new System.Drawing.Size(395, 579);
            this.dgvsukien.TabIndex = 2;
            this.dgvsukien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsukien_CellClick_1);
            this.dgvsukien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsukien_CellContentClick);
            // 
            // masukien
            // 
            this.masukien.DataPropertyName = "masukien";
            this.masukien.HeaderText = "Mã sự kiện";
            this.masukien.Name = "masukien";
            // 
            // motasukien
            // 
            this.motasukien.DataPropertyName = "motasukien";
            this.motasukien.HeaderText = "Mô tả sự kiện";
            this.motasukien.Name = "motasukien";
            this.motasukien.Width = 250;
            // 
            // btnTuVan
            // 
            this.btnTuVan.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTuVan.Location = new System.Drawing.Point(616, 290);
            this.btnTuVan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTuVan.Name = "btnTuVan";
            this.btnTuVan.Size = new System.Drawing.Size(141, 49);
            this.btnTuVan.TabIndex = 23;
            this.btnTuVan.Text = "Tư vấn";
            this.btnTuVan.UseVisualStyleBackColor = true;
            this.btnTuVan.Click += new System.EventHandler(this.btnTuVan_Click);
            // 
            // ricKQ
            // 
            this.ricKQ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ricKQ.Enabled = false;
            this.ricKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ricKQ.Location = new System.Drawing.Point(443, 482);
            this.ricKQ.Margin = new System.Windows.Forms.Padding(4);
            this.ricKQ.Name = "ricKQ";
            this.ricKQ.ReadOnly = true;
            this.ricKQ.Size = new System.Drawing.Size(500, 240);
            this.ricKQ.TabIndex = 26;
            this.ricKQ.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Location = new System.Drawing.Point(641, 160);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 49);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(373, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(618, 64);
            this.button1.TabIndex = 30;
            this.button1.Text = "Nhận dạng động vật qua các thuộc tính";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(17, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Bảng luật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(963, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Luật sau khi chọn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(439, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(504, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "---------------------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(1237, 698);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Đoàn - Hưng";
            // 
            // tuvan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1391, 734);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ricKQ);
            this.Controls.Add(this.btnTuVan);
            this.Controls.Add(this.dgvtuvan);
            this.Controls.Add(this.dgvsukien);
            this.Name = "tuvan1";
            this.Text = "tuvan1";
            this.Load += new System.EventHandler(this.tuvan1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtuvan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsukien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtuvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn masukien1;
        private System.Windows.Forms.DataGridViewTextBoxColumn motasukien1;
        private System.Windows.Forms.DataGridView dgvsukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn masukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn motasukien;
        private System.Windows.Forms.Button btnTuVan;
        private System.Windows.Forms.RichTextBox ricKQ;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}