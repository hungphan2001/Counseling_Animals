
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtuvan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsukien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtuvan
            // 
            this.dgvtuvan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtuvan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masukien1,
            this.motasukien1});
            this.dgvtuvan.Location = new System.Drawing.Point(547, 46);
            this.dgvtuvan.Name = "dgvtuvan";
            this.dgvtuvan.Size = new System.Drawing.Size(446, 235);
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
            this.dgvsukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsukien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masukien,
            this.motasukien});
            this.dgvsukien.Location = new System.Drawing.Point(24, 46);
            this.dgvsukien.Name = "dgvsukien";
            this.dgvsukien.Size = new System.Drawing.Size(395, 615);
            this.dgvsukien.TabIndex = 2;
            this.dgvsukien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsukien_CellClick_1);
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
            this.btnTuVan.Location = new System.Drawing.Point(547, 345);
            this.btnTuVan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTuVan.Name = "btnTuVan";
            this.btnTuVan.Size = new System.Drawing.Size(186, 49);
            this.btnTuVan.TabIndex = 23;
            this.btnTuVan.Text = "Tư vấn";
            this.btnTuVan.UseVisualStyleBackColor = true;
            this.btnTuVan.Click += new System.EventHandler(this.btnTuVan_Click);
            // 
            // ricKQ
            // 
            this.ricKQ.Enabled = false;
            this.ricKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ricKQ.Location = new System.Drawing.Point(547, 459);
            this.ricKQ.Margin = new System.Windows.Forms.Padding(4);
            this.ricKQ.Name = "ricKQ";
            this.ricKQ.ReadOnly = true;
            this.ricKQ.Size = new System.Drawing.Size(460, 193);
            this.ricKQ.TabIndex = 26;
            this.ricKQ.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Location = new System.Drawing.Point(861, 345);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 49);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(546, 414);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(461, 26);
            this.progressBar.TabIndex = 29;
            // 
            // tuvan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 767);
            this.Controls.Add(this.progressBar);
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
        private System.Windows.Forms.ProgressBar progressBar;
    }
}