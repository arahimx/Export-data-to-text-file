namespace A2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.nud_age = new System.Windows.Forms.NumericUpDown();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.pb_profile = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.btn_selectpic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.save_db = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nud_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(49, 64);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(26, 13);
            this.lbl_age.TabIndex = 0;
            this.lbl_age.Text = "Age";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(49, 35);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(52, 13);
            this.lbl_fname.TabIndex = 0;
            this.lbl_fname.Text = "Full name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Profile Photo";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(49, 83);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(73, 13);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email Address";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(155, 31);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(322, 20);
            this.tb_name.TabIndex = 1;
            // 
            // nud_age
            // 
            this.nud_age.Location = new System.Drawing.Point(155, 57);
            this.nud_age.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nud_age.Name = "nud_age";
            this.nud_age.Size = new System.Drawing.Size(54, 20);
            this.nud_age.TabIndex = 2;
            this.nud_age.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(155, 83);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(322, 20);
            this.tb_email.TabIndex = 1;
            // 
            // pb_profile
            // 
            this.pb_profile.Image = ((System.Drawing.Image)(resources.GetObject("pb_profile.Image")));
            this.pb_profile.Location = new System.Drawing.Point(279, 135);
            this.pb_profile.Name = "pb_profile";
            this.pb_profile.Size = new System.Drawing.Size(157, 158);
            this.pb_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_profile.TabIndex = 3;
            this.pb_profile.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(213, 319);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_url
            // 
            this.tb_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_url.Location = new System.Drawing.Point(155, 109);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(281, 20);
            this.tb_url.TabIndex = 5;
            // 
            // btn_selectpic
            // 
            this.btn_selectpic.Location = new System.Drawing.Point(444, 109);
            this.btn_selectpic.Name = "btn_selectpic";
            this.btn_selectpic.Size = new System.Drawing.Size(33, 23);
            this.btn_selectpic.TabIndex = 6;
            this.btn_selectpic.Text = "...";
            this.btn_selectpic.UseVisualStyleBackColor = true;
            this.btn_selectpic.Click += new System.EventHandler(this.btn_selectpic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "(JPEG file only)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 354);
            this.Controls.Add(this.btn_selectpic);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.pb_profile);
            this.Controls.Add(this.nud_age);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_age);
            this.Name = "Form1";
            this.Text = "Assignment 2";
            ((System.ComponentModel.ISupportInitialize)(this.nud_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.NumericUpDown nud_age;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.PictureBox pb_profile;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button btn_selectpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog save_db;
    }
}

