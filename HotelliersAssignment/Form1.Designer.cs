namespace HotelliersAssignment
{
    partial class Hoteliers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoteliers));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StaffLogTab = new System.Windows.Forms.TabPage();
            this.StaffLoginBtn = new System.Windows.Forms.Button();
            this.StaffPasswordInput = new System.Windows.Forms.TextBox();
            this.StaffUserInput = new System.Windows.Forms.TextBox();
            this.staffLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffTab = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.usernameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.StaffLogTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordError)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StaffLogTab);
            this.tabControl1.Controls.Add(this.StaffTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // StaffLogTab
            // 
            this.StaffLogTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(168)))));
            this.StaffLogTab.Controls.Add(this.StaffLoginBtn);
            this.StaffLogTab.Controls.Add(this.StaffPasswordInput);
            this.StaffLogTab.Controls.Add(this.StaffUserInput);
            this.StaffLogTab.Controls.Add(this.staffLbl);
            this.StaffLogTab.Controls.Add(this.label1);
            this.StaffLogTab.Location = new System.Drawing.Point(4, 22);
            this.StaffLogTab.Name = "StaffLogTab";
            this.StaffLogTab.Padding = new System.Windows.Forms.Padding(3);
            this.StaffLogTab.Size = new System.Drawing.Size(790, 420);
            this.StaffLogTab.TabIndex = 0;
            this.StaffLogTab.Text = "Staff Login";
            // 
            // StaffLoginBtn
            // 
            this.StaffLoginBtn.Location = new System.Drawing.Point(362, 282);
            this.StaffLoginBtn.Name = "StaffLoginBtn";
            this.StaffLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.StaffLoginBtn.TabIndex = 7;
            this.StaffLoginBtn.Text = "Login";
            this.StaffLoginBtn.UseVisualStyleBackColor = true;
            this.StaffLoginBtn.Click += new System.EventHandler(this.StaffLoginBtn_Click);
            // 
            // StaffPasswordInput
            // 
            this.StaffPasswordInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPasswordInput.Location = new System.Drawing.Point(156, 182);
            this.StaffPasswordInput.Name = "StaffPasswordInput";
            this.StaffPasswordInput.Size = new System.Drawing.Size(486, 29);
            this.StaffPasswordInput.TabIndex = 6;
            this.StaffPasswordInput.Enter += new System.EventHandler(this.StaffPasswordInput_Enter);
            this.StaffPasswordInput.Leave += new System.EventHandler(this.StaffPasswordInput_Leave);
            // 
            // StaffUserInput
            // 
            this.StaffUserInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffUserInput.Location = new System.Drawing.Point(156, 96);
            this.StaffUserInput.Name = "StaffUserInput";
            this.StaffUserInput.Size = new System.Drawing.Size(486, 29);
            this.StaffUserInput.TabIndex = 5;
            this.StaffUserInput.Enter += new System.EventHandler(this.StaffUserInput_Enter);
            this.StaffUserInput.Leave += new System.EventHandler(this.StaffUserInput_Leave);
            // 
            // staffLbl
            // 
            this.staffLbl.AutoSize = true;
            this.staffLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(7)))));
            this.staffLbl.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.staffLbl.Location = new System.Drawing.Point(319, 18);
            this.staffLbl.Name = "staffLbl";
            this.staffLbl.Size = new System.Drawing.Size(153, 23);
            this.staffLbl.TabIndex = 2;
            this.staffLbl.Text = "Staff Login";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 58);
            this.label1.TabIndex = 3;
            // 
            // StaffTab
            // 
            this.StaffTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(168)))));
            this.StaffTab.Location = new System.Drawing.Point(4, 22);
            this.StaffTab.Name = "StaffTab";
            this.StaffTab.Padding = new System.Windows.Forms.Padding(3);
            this.StaffTab.Size = new System.Drawing.Size(790, 420);
            this.StaffTab.TabIndex = 1;
            this.StaffTab.Text = "Staff";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(168)))));
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(790, 420);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Booking";
            // 
            // usernameError
            // 
            this.usernameError.ContainerControl = this;
            // 
            // passwordError
            // 
            this.passwordError.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(394, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 420);
            this.label2.TabIndex = 0;
            // 
            // Hoteliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hoteliers";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.StaffLogTab.ResumeLayout(false);
            this.StaffLogTab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usernameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StaffLogTab;
        private System.Windows.Forms.TabPage StaffTab;
        private System.Windows.Forms.Label staffLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StaffUserInput;
        private System.Windows.Forms.TextBox StaffPasswordInput;
        private System.Windows.Forms.ErrorProvider usernameError;
        private System.Windows.Forms.ErrorProvider passwordError;
        private System.Windows.Forms.Button StaffLoginBtn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
    }
}

