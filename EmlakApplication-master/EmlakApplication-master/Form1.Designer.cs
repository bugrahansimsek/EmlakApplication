namespace EmlakApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbCity = new ComboBox();
            lblCity = new Label();
            rbSale = new RadioButton();
            rbRental = new RadioButton();
            nudArea = new NumericUpDown();
            lblArea = new Label();
            lblYear = new Label();
            rbLand = new RadioButton();
            rbHome = new RadioButton();
            btnHesapla = new Button();
            grpBoxCategory = new GroupBox();
            dtpDate = new DateTimePicker();
            grpBoxStatus = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudArea).BeginInit();
            grpBoxCategory.SuspendLayout();
            grpBoxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Items.AddRange(new object[] { "Ankara", "İstanbul", "İzmir" });
            cmbCity.Location = new Point(110, 24);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(185, 23);
            cmbCity.TabIndex = 0;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(25, 27);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(33, 15);
            lblCity.TabIndex = 1;
            lblCity.Text = "Şehir";
            // 
            // rbSale
            // 
            rbSale.AutoSize = true;
            rbSale.Location = new Point(89, 22);
            rbSale.Name = "rbSale";
            rbSale.Size = new Size(56, 19);
            rbSale.TabIndex = 3;
            rbSale.TabStop = true;
            rbSale.Tag = "";
            rbSale.Text = "Satılık";
            rbSale.UseVisualStyleBackColor = true;
            // 
            // rbRental
            // 
            rbRental.AutoSize = true;
            rbRental.Location = new Point(201, 22);
            rbRental.Name = "rbRental";
            rbRental.Size = new Size(57, 19);
            rbRental.TabIndex = 4;
            rbRental.TabStop = true;
            rbRental.Tag = "";
            rbRental.Text = "Kiralık";
            rbRental.UseVisualStyleBackColor = true;
            // 
            // nudArea
            // 
            nudArea.Location = new Point(110, 189);
            nudArea.Name = "nudArea";
            nudArea.Size = new Size(185, 23);
            nudArea.TabIndex = 5;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(25, 191);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(67, 15);
            lblArea.TabIndex = 6;
            lblArea.Text = "Alan (M^2)";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(25, 229);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(58, 15);
            lblYear.TabIndex = 7;
            lblYear.Text = "Emlak Yılı";
            // 
            // rbLand
            // 
            rbLand.AutoSize = true;
            rbLand.Location = new Point(89, 22);
            rbLand.Name = "rbLand";
            rbLand.Size = new Size(51, 19);
            rbLand.TabIndex = 10;
            rbLand.TabStop = true;
            rbLand.Text = "Arazi";
            rbLand.UseVisualStyleBackColor = true;
            // 
            // rbHome
            // 
            rbHome.AutoSize = true;
            rbHome.Location = new Point(201, 22);
            rbHome.Name = "rbHome";
            rbHome.Size = new Size(52, 19);
            rbHome.TabIndex = 11;
            rbHome.TabStop = true;
            rbHome.Text = "Daire";
            rbHome.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(220, 262);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(75, 23);
            btnHesapla.TabIndex = 12;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // grpBoxCategory
            // 
            grpBoxCategory.Controls.Add(rbLand);
            grpBoxCategory.Controls.Add(rbHome);
            grpBoxCategory.Location = new Point(25, 127);
            grpBoxCategory.Name = "grpBoxCategory";
            grpBoxCategory.Size = new Size(270, 56);
            grpBoxCategory.TabIndex = 13;
            grpBoxCategory.TabStop = false;
            grpBoxCategory.Text = "Mülkiyet Tipi";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd.MM.yyyy";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(110, 223);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(185, 23);
            dtpDate.TabIndex = 12;
            // 
            // grpBoxStatus
            // 
            grpBoxStatus.Controls.Add(rbSale);
            grpBoxStatus.Controls.Add(rbRental);
            grpBoxStatus.Location = new Point(25, 65);
            grpBoxStatus.Name = "grpBoxStatus";
            grpBoxStatus.Size = new Size(270, 56);
            grpBoxStatus.TabIndex = 14;
            grpBoxStatus.TabStop = false;
            grpBoxStatus.Text = "Durum";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 324);
            Controls.Add(grpBoxStatus);
            Controls.Add(dtpDate);
            Controls.Add(grpBoxCategory);
            Controls.Add(btnHesapla);
            Controls.Add(lblYear);
            Controls.Add(lblArea);
            Controls.Add(nudArea);
            Controls.Add(lblCity);
            Controls.Add(cmbCity);
            Name = "Form1";
            Text = "Emlak Uygulaması";
            ((System.ComponentModel.ISupportInitialize)nudArea).EndInit();
            grpBoxCategory.ResumeLayout(false);
            grpBoxCategory.PerformLayout();
            grpBoxStatus.ResumeLayout(false);
            grpBoxStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCity;
        private Label lblCity;
        private RadioButton rbSale;
        private RadioButton rbRental;
        private NumericUpDown nudArea;
        private Label lblArea;
        private Label lblYear;
        private RadioButton rbLand;
        private RadioButton rbHome;
        private Button btnHesapla;
        private GroupBox grpBoxCategory;
        private DateTimePicker dtpDate;
        private GroupBox grpBoxStatus;
    }
}