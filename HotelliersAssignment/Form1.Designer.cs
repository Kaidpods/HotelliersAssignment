using System;

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
            this.BookingTab = new System.Windows.Forms.TabPage();
            this.BookingSubBtn = new System.Windows.Forms.Button();
            this.TelephoneTxt = new System.Windows.Forms.TextBox();
            this.PostcodeTxt = new System.Windows.Forms.TextBox();
            this.CountyTxt = new System.Windows.Forms.TextBox();
            this.TownTxt = new System.Windows.Forms.TextBox();
            this.StrTxt = new System.Windows.Forms.TextBox();
            this.StrNumTxt = new System.Windows.Forms.TextBox();
            this.CustTxt = new System.Windows.Forms.TextBox();
            this.CountyLbl = new System.Windows.Forms.Label();
            this.StreetLbl = new System.Windows.Forms.Label();
            this.TeleLbl = new System.Windows.Forms.Label();
            this.PostcodeLbl = new System.Windows.Forms.Label();
            this.TownLbl = new System.Windows.Forms.Label();
            this.StNumLbl = new System.Windows.Forms.Label();
            this.CustLbl = new System.Windows.Forms.Label();
            this.RoomPersonTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dropDownPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RoomPersonPnl = new System.Windows.Forms.Panel();
            this.dropRoomBtn = new System.Windows.Forms.Button();
            this.RoomLbl = new System.Windows.Forms.Label();
            this.IncDRoom = new System.Windows.Forms.Button();
            this.RoomTxt = new System.Windows.Forms.TextBox();
            this.IncARoom = new System.Windows.Forms.Button();
            this.AdultsLbl = new System.Windows.Forms.Label();
            this.IncDAdult = new System.Windows.Forms.Button();
            this.AdultTxt = new System.Windows.Forms.TextBox();
            this.IncAAdult = new System.Windows.Forms.Button();
            this.ChildrenLbl = new System.Windows.Forms.Label();
            this.IncDChild = new System.Windows.Forms.Button();
            this.ChildTxt = new System.Windows.Forms.TextBox();
            this.IncAChild = new System.Windows.Forms.Button();
            this.InfantLbl = new System.Windows.Forms.Label();
            this.IncDInfants = new System.Windows.Forms.Button();
            this.InfantTxt = new System.Windows.Forms.TextBox();
            this.IncAInfant = new System.Windows.Forms.Button();
            this.EndDateLbl = new System.Windows.Forms.Label();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.BookEndDate = new System.Windows.Forms.DateTimePicker();
            this.BookStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.PrefIDLbl = new System.Windows.Forms.Label();
            this.PrefIDTxt = new System.Windows.Forms.TextBox();
            this.HotelLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UsernameErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.StartDateErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.EndDateErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.DropTimer = new System.Windows.Forms.Timer(this.components);
            this.AddressErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.StaffLogTab.SuspendLayout();
            this.BookingTab.SuspendLayout();
            this.dropDownPanel.SuspendLayout();
            this.RoomPersonPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StaffLogTab);
            this.tabControl1.Controls.Add(this.StaffTab);
            this.tabControl1.Controls.Add(this.BookingTab);
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
            // BookingTab
            // 
            this.BookingTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(168)))));
            this.BookingTab.Controls.Add(this.BookingSubBtn);
            this.BookingTab.Controls.Add(this.TelephoneTxt);
            this.BookingTab.Controls.Add(this.PostcodeTxt);
            this.BookingTab.Controls.Add(this.CountyTxt);
            this.BookingTab.Controls.Add(this.TownTxt);
            this.BookingTab.Controls.Add(this.StrTxt);
            this.BookingTab.Controls.Add(this.StrNumTxt);
            this.BookingTab.Controls.Add(this.CustTxt);
            this.BookingTab.Controls.Add(this.CountyLbl);
            this.BookingTab.Controls.Add(this.StreetLbl);
            this.BookingTab.Controls.Add(this.TeleLbl);
            this.BookingTab.Controls.Add(this.PostcodeLbl);
            this.BookingTab.Controls.Add(this.TownLbl);
            this.BookingTab.Controls.Add(this.StNumLbl);
            this.BookingTab.Controls.Add(this.CustLbl);
            this.BookingTab.Controls.Add(this.RoomPersonTxt);
            this.BookingTab.Controls.Add(this.label7);
            this.BookingTab.Controls.Add(this.label6);
            this.BookingTab.Controls.Add(this.dropDownPanel);
            this.BookingTab.Controls.Add(this.EndDateLbl);
            this.BookingTab.Controls.Add(this.StartDateLbl);
            this.BookingTab.Controls.Add(this.BookEndDate);
            this.BookingTab.Controls.Add(this.BookStartDate);
            this.BookingTab.Controls.Add(this.label3);
            this.BookingTab.Controls.Add(this.PrefIDLbl);
            this.BookingTab.Controls.Add(this.PrefIDTxt);
            this.BookingTab.Controls.Add(this.HotelLbl);
            this.BookingTab.Controls.Add(this.label2);
            this.BookingTab.Controls.Add(this.label4);
            this.BookingTab.Controls.Add(this.label5);
            this.BookingTab.Location = new System.Drawing.Point(4, 22);
            this.BookingTab.Name = "BookingTab";
            this.BookingTab.Size = new System.Drawing.Size(790, 420);
            this.BookingTab.TabIndex = 2;
            this.BookingTab.Text = "Booking";
            // 
            // BookingSubBtn
            // 
            this.BookingSubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BookingSubBtn.Location = new System.Drawing.Point(56, 342);
            this.BookingSubBtn.Name = "BookingSubBtn";
            this.BookingSubBtn.Size = new System.Drawing.Size(75, 23);
            this.BookingSubBtn.TabIndex = 30;
            this.BookingSubBtn.Text = "Submit";
            this.BookingSubBtn.UseVisualStyleBackColor = true;
            this.BookingSubBtn.Click += new System.EventHandler(this.BookingSubBtn_Click);
            // 
            // TelephoneTxt
            // 
            this.TelephoneTxt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneTxt.Location = new System.Drawing.Point(597, 380);
            this.TelephoneTxt.Name = "TelephoneTxt";
            this.TelephoneTxt.Size = new System.Drawing.Size(136, 27);
            this.TelephoneTxt.TabIndex = 29;
            this.TelephoneTxt.Validating += new System.ComponentModel.CancelEventHandler(this.Address_Validating);
            // 
            // PostcodeTxt
            // 
            this.PostcodeTxt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostcodeTxt.Location = new System.Drawing.Point(597, 319);
            this.PostcodeTxt.Name = "PostcodeTxt";
            this.PostcodeTxt.Size = new System.Drawing.Size(136, 27);
            this.PostcodeTxt.TabIndex = 28;
            this.PostcodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.Address_Validating);
            // 
            // CountyTxt
            // 
            this.CountyTxt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountyTxt.Location = new System.Drawing.Point(597, 259);
            this.CountyTxt.Name = "CountyTxt";
            this.CountyTxt.Size = new System.Drawing.Size(136, 27);
            this.CountyTxt.TabIndex = 27;
            this.CountyTxt.Leave += new System.EventHandler(this.AddressStr_Leave);
            this.CountyTxt.Validating += new System.ComponentModel.CancelEventHandler(this.Address_Validating);
            // 
            // TownTxt
            // 
            this.TownTxt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TownTxt.Location = new System.Drawing.Point(597, 200);
            this.TownTxt.Name = "TownTxt";
            this.TownTxt.Size = new System.Drawing.Size(136, 27);
            this.TownTxt.TabIndex = 26;
            this.TownTxt.Leave += new System.EventHandler(this.AddressStr_Leave);
            this.TownTxt.Validating += new System.ComponentModel.CancelEventHandler(this.Address_Validating);
            // 
            // StrTxt
            // 
            this.StrTxt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrTxt.Location = new System.Drawing.Point(597, 139);
            this.StrTxt.Name = "StrTxt";
            this.StrTxt.Size = new System.Drawing.Size(136, 27);
            this.StrTxt.TabIndex = 25;
            this.StrTxt.Validating += new System.ComponentModel.CancelEventHandler(this.Address_Validating);
            // 
            // StrNumTxt
            // 
            this.StrNumTxt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrNumTxt.Location = new System.Drawing.Point(597, 80);
            this.StrNumTxt.Name = "StrNumTxt";
            this.StrNumTxt.Size = new System.Drawing.Size(136, 27);
            this.StrNumTxt.TabIndex = 24;
            this.StrNumTxt.Validating += new System.ComponentModel.CancelEventHandler(this.Address_Validating);
            // 
            // CustTxt
            // 
            this.CustTxt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustTxt.Location = new System.Drawing.Point(597, 19);
            this.CustTxt.Name = "CustTxt";
            this.CustTxt.Size = new System.Drawing.Size(136, 27);
            this.CustTxt.TabIndex = 23;
            this.CustTxt.Leave += new System.EventHandler(this.AddressStr_Leave);
            this.CustTxt.Validating += new System.ComponentModel.CancelEventHandler(this.Address_Validating);
            // 
            // CountyLbl
            // 
            this.CountyLbl.AutoSize = true;
            this.CountyLbl.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.CountyLbl.Location = new System.Drawing.Point(489, 260);
            this.CountyLbl.Name = "CountyLbl";
            this.CountyLbl.Size = new System.Drawing.Size(73, 21);
            this.CountyLbl.TabIndex = 22;
            this.CountyLbl.Text = "County:";
            // 
            // StreetLbl
            // 
            this.StreetLbl.AutoSize = true;
            this.StreetLbl.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.StreetLbl.Location = new System.Drawing.Point(489, 140);
            this.StreetLbl.Name = "StreetLbl";
            this.StreetLbl.Size = new System.Drawing.Size(73, 21);
            this.StreetLbl.TabIndex = 21;
            this.StreetLbl.Text = "Street:";
            // 
            // TeleLbl
            // 
            this.TeleLbl.AutoSize = true;
            this.TeleLbl.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.TeleLbl.Location = new System.Drawing.Point(426, 380);
            this.TeleLbl.Name = "TeleLbl";
            this.TeleLbl.Size = new System.Drawing.Size(136, 21);
            this.TeleLbl.TabIndex = 20;
            this.TeleLbl.Text = "Telephone Num:";
            // 
            // PostcodeLbl
            // 
            this.PostcodeLbl.AutoSize = true;
            this.PostcodeLbl.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.PostcodeLbl.Location = new System.Drawing.Point(471, 320);
            this.PostcodeLbl.Name = "PostcodeLbl";
            this.PostcodeLbl.Size = new System.Drawing.Size(91, 21);
            this.PostcodeLbl.TabIndex = 19;
            this.PostcodeLbl.Text = "Postcode:";
            // 
            // TownLbl
            // 
            this.TownLbl.AutoSize = true;
            this.TownLbl.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.TownLbl.Location = new System.Drawing.Point(507, 200);
            this.TownLbl.Name = "TownLbl";
            this.TownLbl.Size = new System.Drawing.Size(55, 21);
            this.TownLbl.TabIndex = 18;
            this.TownLbl.Text = "Town:";
            // 
            // StNumLbl
            // 
            this.StNumLbl.AutoSize = true;
            this.StNumLbl.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.StNumLbl.Location = new System.Drawing.Point(426, 80);
            this.StNumLbl.Name = "StNumLbl";
            this.StNumLbl.Size = new System.Drawing.Size(136, 21);
            this.StNumLbl.TabIndex = 17;
            this.StNumLbl.Text = "Street Number:";
            // 
            // CustLbl
            // 
            this.CustLbl.AutoSize = true;
            this.CustLbl.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.CustLbl.Location = new System.Drawing.Point(426, 20);
            this.CustLbl.Name = "CustLbl";
            this.CustLbl.Size = new System.Drawing.Size(136, 21);
            this.CustLbl.TabIndex = 16;
            this.CustLbl.Text = "Customer Name:";
            // 
            // RoomPersonTxt
            // 
            this.RoomPersonTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.RoomPersonTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomPersonTxt.Location = new System.Drawing.Point(14, 213);
            this.RoomPersonTxt.Multiline = true;
            this.RoomPersonTxt.Name = "RoomPersonTxt";
            this.RoomPersonTxt.ReadOnly = true;
            this.RoomPersonTxt.Size = new System.Drawing.Size(159, 68);
            this.RoomPersonTxt.TabIndex = 15;
            this.RoomPersonTxt.Text = "1 Room | 1 Adult";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(174)))), ((int)(((byte)(111)))));
            this.label7.Location = new System.Drawing.Point(-1, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 2);
            this.label7.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(174)))), ((int)(((byte)(111)))));
            this.label6.Location = new System.Drawing.Point(-1, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(395, 2);
            this.label6.TabIndex = 13;
            // 
            // dropDownPanel
            // 
            this.dropDownPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(186)))), ((int)(((byte)(175)))));
            this.dropDownPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropDownPanel.Controls.Add(this.RoomPersonPnl);
            this.dropDownPanel.Controls.Add(this.RoomLbl);
            this.dropDownPanel.Controls.Add(this.IncDRoom);
            this.dropDownPanel.Controls.Add(this.RoomTxt);
            this.dropDownPanel.Controls.Add(this.IncARoom);
            this.dropDownPanel.Controls.Add(this.AdultsLbl);
            this.dropDownPanel.Controls.Add(this.IncDAdult);
            this.dropDownPanel.Controls.Add(this.AdultTxt);
            this.dropDownPanel.Controls.Add(this.IncAAdult);
            this.dropDownPanel.Controls.Add(this.ChildrenLbl);
            this.dropDownPanel.Controls.Add(this.IncDChild);
            this.dropDownPanel.Controls.Add(this.ChildTxt);
            this.dropDownPanel.Controls.Add(this.IncAChild);
            this.dropDownPanel.Controls.Add(this.InfantLbl);
            this.dropDownPanel.Controls.Add(this.IncDInfants);
            this.dropDownPanel.Controls.Add(this.InfantTxt);
            this.dropDownPanel.Controls.Add(this.IncAInfant);
            this.dropDownPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dropDownPanel.Location = new System.Drawing.Point(188, 213);
            this.dropDownPanel.MaximumSize = new System.Drawing.Size(200, 201);
            this.dropDownPanel.MinimumSize = new System.Drawing.Size(200, 30);
            this.dropDownPanel.Name = "dropDownPanel";
            this.dropDownPanel.Size = new System.Drawing.Size(200, 30);
            this.dropDownPanel.TabIndex = 12;
            // 
            // RoomPersonPnl
            // 
            this.RoomPersonPnl.Controls.Add(this.dropRoomBtn);
            this.RoomPersonPnl.Location = new System.Drawing.Point(0, 0);
            this.RoomPersonPnl.Margin = new System.Windows.Forms.Padding(0);
            this.RoomPersonPnl.Name = "RoomPersonPnl";
            this.RoomPersonPnl.Size = new System.Drawing.Size(200, 30);
            this.RoomPersonPnl.TabIndex = 0;
            // 
            // dropRoomBtn
            // 
            this.dropRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.dropRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dropRoomBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropRoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("dropRoomBtn.Image")));
            this.dropRoomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dropRoomBtn.Location = new System.Drawing.Point(0, 0);
            this.dropRoomBtn.Name = "dropRoomBtn";
            this.dropRoomBtn.Size = new System.Drawing.Size(200, 30);
            this.dropRoomBtn.TabIndex = 13;
            this.dropRoomBtn.Text = "Room and Person(s)";
            this.dropRoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dropRoomBtn.UseVisualStyleBackColor = false;
            this.dropRoomBtn.Click += new System.EventHandler(this.DropRoomBtn_Click);
            // 
            // RoomLbl
            // 
            this.RoomLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLbl.Location = new System.Drawing.Point(3, 33);
            this.RoomLbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 17);
            this.RoomLbl.Name = "RoomLbl";
            this.RoomLbl.Size = new System.Drawing.Size(72, 28);
            this.RoomLbl.TabIndex = 1;
            this.RoomLbl.Text = "Rooms";
            this.RoomLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IncDRoom
            // 
            this.IncDRoom.BackColor = System.Drawing.Color.White;
            this.IncDRoom.BackgroundImage = global::HotelliersAssignment.Properties.Resources.icons8_minus_24;
            this.IncDRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IncDRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IncDRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IncDRoom.Location = new System.Drawing.Point(98, 33);
            this.IncDRoom.Margin = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.IncDRoom.Name = "IncDRoom";
            this.IncDRoom.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.IncDRoom.Size = new System.Drawing.Size(31, 29);
            this.IncDRoom.TabIndex = 2;
            this.IncDRoom.UseVisualStyleBackColor = false;
            this.IncDRoom.Click += new System.EventHandler(this.IncDRoom_Click);
            // 
            // RoomTxt
            // 
            this.RoomTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTxt.Location = new System.Drawing.Point(129, 33);
            this.RoomTxt.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.RoomTxt.Name = "RoomTxt";
            this.RoomTxt.Size = new System.Drawing.Size(28, 29);
            this.RoomTxt.TabIndex = 3;
            this.RoomTxt.Text = "1";
            this.RoomTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomTxt.TextChanged += new System.EventHandler(this.RoomPersonCheck_Changed);
            this.RoomTxt.Leave += new System.EventHandler(this.RoomPerson_Leave);
            // 
            // IncARoom
            // 
            this.IncARoom.BackColor = System.Drawing.Color.White;
            this.IncARoom.BackgroundImage = global::HotelliersAssignment.Properties.Resources.icons8_plus_24;
            this.IncARoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IncARoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IncARoom.Location = new System.Drawing.Point(157, 33);
            this.IncARoom.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.IncARoom.Name = "IncARoom";
            this.IncARoom.Size = new System.Drawing.Size(31, 29);
            this.IncARoom.TabIndex = 4;
            this.IncARoom.UseVisualStyleBackColor = false;
            this.IncARoom.Click += new System.EventHandler(this.IncARoom_Click);
            // 
            // AdultsLbl
            // 
            this.AdultsLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdultsLbl.Location = new System.Drawing.Point(3, 78);
            this.AdultsLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
            this.AdultsLbl.Name = "AdultsLbl";
            this.AdultsLbl.Size = new System.Drawing.Size(72, 28);
            this.AdultsLbl.TabIndex = 5;
            this.AdultsLbl.Text = "Adults";
            this.AdultsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IncDAdult
            // 
            this.IncDAdult.BackColor = System.Drawing.Color.White;
            this.IncDAdult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IncDAdult.BackgroundImage")));
            this.IncDAdult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IncDAdult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IncDAdult.Location = new System.Drawing.Point(98, 78);
            this.IncDAdult.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.IncDAdult.Name = "IncDAdult";
            this.IncDAdult.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.IncDAdult.Size = new System.Drawing.Size(31, 29);
            this.IncDAdult.TabIndex = 6;
            this.IncDAdult.UseVisualStyleBackColor = false;
            this.IncDAdult.Click += new System.EventHandler(this.IncDAdult_Click);
            // 
            // AdultTxt
            // 
            this.AdultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdultTxt.Location = new System.Drawing.Point(129, 78);
            this.AdultTxt.Margin = new System.Windows.Forms.Padding(0);
            this.AdultTxt.Name = "AdultTxt";
            this.AdultTxt.Size = new System.Drawing.Size(28, 29);
            this.AdultTxt.TabIndex = 7;
            this.AdultTxt.Text = "1";
            this.AdultTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdultTxt.TextChanged += new System.EventHandler(this.RoomPersonCheck_Changed);
            this.AdultTxt.Leave += new System.EventHandler(this.RoomPerson_Leave);
            // 
            // IncAAdult
            // 
            this.IncAAdult.BackColor = System.Drawing.Color.White;
            this.IncAAdult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IncAAdult.BackgroundImage")));
            this.IncAAdult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IncAAdult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IncAAdult.Location = new System.Drawing.Point(157, 78);
            this.IncAAdult.Margin = new System.Windows.Forms.Padding(0);
            this.IncAAdult.Name = "IncAAdult";
            this.IncAAdult.Size = new System.Drawing.Size(31, 29);
            this.IncAAdult.TabIndex = 8;
            this.IncAAdult.UseVisualStyleBackColor = false;
            this.IncAAdult.Click += new System.EventHandler(this.IncAAdult_Click);
            // 
            // ChildrenLbl
            // 
            this.ChildrenLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildrenLbl.Location = new System.Drawing.Point(3, 123);
            this.ChildrenLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
            this.ChildrenLbl.Name = "ChildrenLbl";
            this.ChildrenLbl.Size = new System.Drawing.Size(72, 28);
            this.ChildrenLbl.TabIndex = 9;
            this.ChildrenLbl.Text = "Childs";
            this.ChildrenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IncDChild
            // 
            this.IncDChild.BackColor = System.Drawing.Color.White;
            this.IncDChild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IncDChild.BackgroundImage")));
            this.IncDChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IncDChild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IncDChild.Location = new System.Drawing.Point(98, 123);
            this.IncDChild.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.IncDChild.Name = "IncDChild";
            this.IncDChild.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.IncDChild.Size = new System.Drawing.Size(31, 29);
            this.IncDChild.TabIndex = 10;
            this.IncDChild.UseVisualStyleBackColor = false;
            this.IncDChild.Click += new System.EventHandler(this.IncDChild_Click);
            // 
            // ChildTxt
            // 
            this.ChildTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildTxt.Location = new System.Drawing.Point(129, 123);
            this.ChildTxt.Margin = new System.Windows.Forms.Padding(0);
            this.ChildTxt.Name = "ChildTxt";
            this.ChildTxt.Size = new System.Drawing.Size(28, 29);
            this.ChildTxt.TabIndex = 11;
            this.ChildTxt.Text = "0";
            this.ChildTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChildTxt.TextChanged += new System.EventHandler(this.RoomPersonCheck_Changed);
            this.ChildTxt.Leave += new System.EventHandler(this.RoomPerson_Leave);
            // 
            // IncAChild
            // 
            this.IncAChild.BackColor = System.Drawing.Color.White;
            this.IncAChild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IncAChild.BackgroundImage")));
            this.IncAChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IncAChild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IncAChild.Location = new System.Drawing.Point(157, 123);
            this.IncAChild.Margin = new System.Windows.Forms.Padding(0);
            this.IncAChild.Name = "IncAChild";
            this.IncAChild.Size = new System.Drawing.Size(31, 29);
            this.IncAChild.TabIndex = 12;
            this.IncAChild.UseVisualStyleBackColor = false;
            this.IncAChild.Click += new System.EventHandler(this.IncAChild_Click);
            // 
            // InfantLbl
            // 
            this.InfantLbl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfantLbl.Location = new System.Drawing.Point(3, 168);
            this.InfantLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 17);
            this.InfantLbl.Name = "InfantLbl";
            this.InfantLbl.Size = new System.Drawing.Size(72, 28);
            this.InfantLbl.TabIndex = 13;
            this.InfantLbl.Text = "Infants";
            this.InfantLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IncDInfants
            // 
            this.IncDInfants.BackColor = System.Drawing.Color.White;
            this.IncDInfants.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IncDInfants.BackgroundImage")));
            this.IncDInfants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IncDInfants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IncDInfants.Location = new System.Drawing.Point(98, 168);
            this.IncDInfants.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.IncDInfants.Name = "IncDInfants";
            this.IncDInfants.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.IncDInfants.Size = new System.Drawing.Size(31, 29);
            this.IncDInfants.TabIndex = 14;
            this.IncDInfants.UseVisualStyleBackColor = false;
            this.IncDInfants.Click += new System.EventHandler(this.IncDInfants_Click);
            // 
            // InfantTxt
            // 
            this.InfantTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfantTxt.Location = new System.Drawing.Point(129, 168);
            this.InfantTxt.Margin = new System.Windows.Forms.Padding(0);
            this.InfantTxt.Name = "InfantTxt";
            this.InfantTxt.Size = new System.Drawing.Size(28, 29);
            this.InfantTxt.TabIndex = 15;
            this.InfantTxt.Text = "0";
            this.InfantTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InfantTxt.TextChanged += new System.EventHandler(this.RoomPersonCheck_Changed);
            this.InfantTxt.Leave += new System.EventHandler(this.RoomPerson_Leave);
            // 
            // IncAInfant
            // 
            this.IncAInfant.BackColor = System.Drawing.Color.White;
            this.IncAInfant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IncAInfant.BackgroundImage")));
            this.IncAInfant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IncAInfant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IncAInfant.Location = new System.Drawing.Point(157, 168);
            this.IncAInfant.Margin = new System.Windows.Forms.Padding(0);
            this.IncAInfant.Name = "IncAInfant";
            this.IncAInfant.Size = new System.Drawing.Size(31, 29);
            this.IncAInfant.TabIndex = 16;
            this.IncAInfant.UseVisualStyleBackColor = false;
            this.IncAInfant.Click += new System.EventHandler(this.IncAInfant_Click);
            // 
            // EndDateLbl
            // 
            this.EndDateLbl.AutoSize = true;
            this.EndDateLbl.BackColor = System.Drawing.Color.Transparent;
            this.EndDateLbl.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLbl.Location = new System.Drawing.Point(8, 163);
            this.EndDateLbl.Name = "EndDateLbl";
            this.EndDateLbl.Size = new System.Drawing.Size(91, 21);
            this.EndDateLbl.TabIndex = 11;
            this.EndDateLbl.Text = "End Date:";
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.BackColor = System.Drawing.Color.Transparent;
            this.StartDateLbl.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLbl.Location = new System.Drawing.Point(8, 115);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(109, 21);
            this.StartDateLbl.TabIndex = 10;
            this.StartDateLbl.Text = "Start Date:";
            // 
            // BookEndDate
            // 
            this.BookEndDate.Checked = false;
            this.BookEndDate.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookEndDate.Location = new System.Drawing.Point(155, 159);
            this.BookEndDate.Name = "BookEndDate";
            this.BookEndDate.Size = new System.Drawing.Size(233, 26);
            this.BookEndDate.TabIndex = 9;
            this.BookEndDate.Value = new System.DateTime(2024, 1, 24, 22, 55, 19, 0);
            // 
            // BookStartDate
            // 
            this.BookStartDate.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookStartDate.Location = new System.Drawing.Point(155, 111);
            this.BookStartDate.MinDate = new System.DateTime(2024, 1, 24, 0, 0, 0, 0);
            this.BookStartDate.Name = "BookStartDate";
            this.BookStartDate.Size = new System.Drawing.Size(233, 26);
            this.BookStartDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(174)))), ((int)(((byte)(111)))));
            this.label3.Location = new System.Drawing.Point(-1, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 2);
            this.label3.TabIndex = 6;
            // 
            // PrefIDLbl
            // 
            this.PrefIDLbl.AutoSize = true;
            this.PrefIDLbl.BackColor = System.Drawing.Color.Transparent;
            this.PrefIDLbl.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrefIDLbl.Location = new System.Drawing.Point(5, 58);
            this.PrefIDLbl.Name = "PrefIDLbl";
            this.PrefIDLbl.Size = new System.Drawing.Size(188, 25);
            this.PrefIDLbl.TabIndex = 5;
            this.PrefIDLbl.Text = "Preferential ID:";
            // 
            // PrefIDTxt
            // 
            this.PrefIDTxt.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrefIDTxt.Location = new System.Drawing.Point(211, 55);
            this.PrefIDTxt.Name = "PrefIDTxt";
            this.PrefIDTxt.Size = new System.Drawing.Size(177, 30);
            this.PrefIDTxt.TabIndex = 4;
            // 
            // HotelLbl
            // 
            this.HotelLbl.AutoSize = true;
            this.HotelLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(189)))), ((int)(((byte)(137)))));
            this.HotelLbl.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelLbl.Location = new System.Drawing.Point(4, 4);
            this.HotelLbl.Name = "HotelLbl";
            this.HotelLbl.Size = new System.Drawing.Size(127, 35);
            this.HotelLbl.TabIndex = 1;
            this.HotelLbl.Text = "Hotel: ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(394, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 420);
            this.label2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(189)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 47);
            this.label4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(174)))), ((int)(((byte)(111)))));
            this.label5.Location = new System.Drawing.Point(-1, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 10);
            this.label5.TabIndex = 3;
            // 
            // UsernameErr
            // 
            this.UsernameErr.ContainerControl = this;
            // 
            // PasswordErr
            // 
            this.PasswordErr.ContainerControl = this;
            // 
            // StartDateErr
            // 
            this.StartDateErr.ContainerControl = this;
            // 
            // EndDateErr
            // 
            this.EndDateErr.ContainerControl = this;
            // 
            // DropTimer
            // 
            this.DropTimer.Interval = 1;
            this.DropTimer.Tick += new System.EventHandler(this.DropTimer_Tick);
            // 
            // AddressErrorProv
            // 
            this.AddressErrorProv.ContainerControl = this;
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hoteliers_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.StaffLogTab.ResumeLayout(false);
            this.StaffLogTab.PerformLayout();
            this.BookingTab.ResumeLayout(false);
            this.BookingTab.PerformLayout();
            this.dropDownPanel.ResumeLayout(false);
            this.dropDownPanel.PerformLayout();
            this.RoomPersonPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsernameErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressErrorProv)).EndInit();
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
        private System.Windows.Forms.ErrorProvider UsernameErr;
        private System.Windows.Forms.ErrorProvider PasswordErr;
        private System.Windows.Forms.Button StaffLoginBtn;
        private System.Windows.Forms.TabPage BookingTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HotelLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrefIDTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PrefIDLbl;
        private System.Windows.Forms.DateTimePicker BookEndDate;
        private System.Windows.Forms.DateTimePicker BookStartDate;
        private System.Windows.Forms.ErrorProvider StartDateErr;
        private System.Windows.Forms.ErrorProvider EndDateErr;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.FlowLayoutPanel dropDownPanel;
        private System.Windows.Forms.Label EndDateLbl;
        private System.Windows.Forms.Button dropRoomBtn;
        private System.Windows.Forms.Panel RoomPersonPnl;
        private System.Windows.Forms.Timer DropTimer;
        private System.Windows.Forms.Label RoomLbl;
        private System.Windows.Forms.Button IncDRoom;
        private System.Windows.Forms.TextBox RoomTxt;
        private System.Windows.Forms.Button IncARoom;
        private System.Windows.Forms.Label AdultsLbl;
        private System.Windows.Forms.Button IncDAdult;
        private System.Windows.Forms.TextBox AdultTxt;
        private System.Windows.Forms.Button IncAAdult;
        private System.Windows.Forms.Label ChildrenLbl;
        private System.Windows.Forms.Button IncDChild;
        private System.Windows.Forms.TextBox ChildTxt;
        private System.Windows.Forms.Button IncAChild;
        private System.Windows.Forms.Label InfantLbl;
        private System.Windows.Forms.Button IncDInfants;
        private System.Windows.Forms.TextBox InfantTxt;
        private System.Windows.Forms.Button IncAInfant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RoomPersonTxt;
        private System.Windows.Forms.Label CustLbl;
        private System.Windows.Forms.Label TeleLbl;
        private System.Windows.Forms.Label PostcodeLbl;
        private System.Windows.Forms.Label TownLbl;
        private System.Windows.Forms.Label StNumLbl;
        private System.Windows.Forms.Label StreetLbl;
        private System.Windows.Forms.TextBox TelephoneTxt;
        private System.Windows.Forms.TextBox PostcodeTxt;
        private System.Windows.Forms.TextBox CountyTxt;
        private System.Windows.Forms.TextBox TownTxt;
        private System.Windows.Forms.TextBox StrTxt;
        private System.Windows.Forms.TextBox StrNumTxt;
        private System.Windows.Forms.TextBox CustTxt;
        private System.Windows.Forms.Label CountyLbl;
        private System.Windows.Forms.Button BookingSubBtn;
        private System.Windows.Forms.ErrorProvider AddressErrorProv;
    }
}

