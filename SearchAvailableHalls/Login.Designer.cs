
namespace Login_Placeholder
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.TxtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxUserId = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.ckBxShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Location = new System.Drawing.Point(202, 174);
            this.BtnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(81, 27);
            this.BtnLogIn.TabIndex = 4;
            this.BtnLogIn.Text = "Log In";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // TxtBoxPass
            // 
            this.TxtBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPass.Location = new System.Drawing.Point(167, 112);
            this.TxtBoxPass.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBoxPass.Name = "TxtBoxPass";
            this.TxtBoxPass.Size = new System.Drawing.Size(152, 26);
            this.TxtBoxPass.TabIndex = 3;
            // 
            // txtBoxUserId
            // 
            this.txtBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserId.Location = new System.Drawing.Point(167, 70);
            this.txtBoxUserId.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUserId.Name = "txtBoxUserId";
            this.txtBoxUserId.Size = new System.Drawing.Size(152, 26);
            this.txtBoxUserId.TabIndex = 1;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(50, 76);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(48, 15);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(50, 118);
            this.lblPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 15);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(97, 174);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 27);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New User";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ckBxShow
            // 
            this.ckBxShow.AutoSize = true;
            this.ckBxShow.BackColor = System.Drawing.Color.Transparent;
            this.ckBxShow.Location = new System.Drawing.Point(167, 142);
            this.ckBxShow.Margin = new System.Windows.Forms.Padding(2);
            this.ckBxShow.Name = "ckBxShow";
            this.ckBxShow.Size = new System.Drawing.Size(102, 17);
            this.ckBxShow.TabIndex = 12;
            this.ckBxShow.Text = "Show Password";
            this.ckBxShow.UseVisualStyleBackColor = false;
            this.ckBxShow.CheckedChanged += new System.EventHandler(this.ckBxShow_CheckedChanged);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SearchAvailableHalls.Properties.Resources.loginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(376, 232);
            this.Controls.Add(this.ckBxShow);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtBoxUserId);
            this.Controls.Add(this.TxtBoxPass);
            this.Controls.Add(this.BtnLogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmLogIn";
            this.Text = "Log In : Lecture Hall Reservation";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.TextBox TxtBoxPass;
        private System.Windows.Forms.TextBox txtBoxUserId;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.CheckBox ckBxShow;
    }
}

