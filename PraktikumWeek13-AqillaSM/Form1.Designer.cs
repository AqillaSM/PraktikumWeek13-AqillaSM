namespace PraktikumWeek13_AqillaSM
{
    partial class FormPlayer
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
            this.ButtonFirst = new System.Windows.Forms.Button();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonLast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxPlayerID = new System.Windows.Forms.TextBox();
            this.TextBoxPlayerName = new System.Windows.Forms.TextBox();
            this.DateTimeBirthdate = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxTeam = new System.Windows.Forms.ComboBox();
            this.NumericTeamNumber = new System.Windows.Forms.NumericUpDown();
            this.LabelAvail = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ComboBoxNation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.Location = new System.Drawing.Point(97, 58);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(114, 46);
            this.ButtonFirst.TabIndex = 0;
            this.ButtonFirst.Text = "<<";
            this.ButtonFirst.UseVisualStyleBackColor = true;
            this.ButtonFirst.Click += new System.EventHandler(this.ButtonFirst_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.Location = new System.Drawing.Point(233, 58);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(114, 46);
            this.ButtonPrev.TabIndex = 1;
            this.ButtonPrev.Text = "<";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(375, 58);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(114, 46);
            this.ButtonNext.TabIndex = 2;
            this.ButtonNext.Text = ">";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonLast
            // 
            this.ButtonLast.Location = new System.Drawing.Point(513, 58);
            this.ButtonLast.Name = "ButtonLast";
            this.ButtonLast.Size = new System.Drawing.Size(114, 46);
            this.ButtonLast.TabIndex = 3;
            this.ButtonLast.Text = ">>";
            this.ButtonLast.UseVisualStyleBackColor = true;
            this.ButtonLast.Click += new System.EventHandler(this.ButtonLast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "BirthDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Team Number";
            // 
            // TextBoxPlayerID
            // 
            this.TextBoxPlayerID.Location = new System.Drawing.Point(292, 115);
            this.TextBoxPlayerID.Name = "TextBoxPlayerID";
            this.TextBoxPlayerID.Size = new System.Drawing.Size(291, 22);
            this.TextBoxPlayerID.TabIndex = 11;
            // 
            // TextBoxPlayerName
            // 
            this.TextBoxPlayerName.Location = new System.Drawing.Point(292, 150);
            this.TextBoxPlayerName.Name = "TextBoxPlayerName";
            this.TextBoxPlayerName.Size = new System.Drawing.Size(291, 22);
            this.TextBoxPlayerName.TabIndex = 12;
            // 
            // DateTimeBirthdate
            // 
            this.DateTimeBirthdate.Location = new System.Drawing.Point(292, 186);
            this.DateTimeBirthdate.Name = "DateTimeBirthdate";
            this.DateTimeBirthdate.Size = new System.Drawing.Size(291, 22);
            this.DateTimeBirthdate.TabIndex = 13;
            // 
            // ComboBoxTeam
            // 
            this.ComboBoxTeam.FormattingEnabled = true;
            this.ComboBoxTeam.Location = new System.Drawing.Point(292, 262);
            this.ComboBoxTeam.Name = "ComboBoxTeam";
            this.ComboBoxTeam.Size = new System.Drawing.Size(291, 24);
            this.ComboBoxTeam.TabIndex = 14;
            // 
            // NumericTeamNumber
            // 
            this.NumericTeamNumber.Location = new System.Drawing.Point(292, 303);
            this.NumericTeamNumber.Name = "NumericTeamNumber";
            this.NumericTeamNumber.Size = new System.Drawing.Size(291, 22);
            this.NumericTeamNumber.TabIndex = 15;
            this.NumericTeamNumber.ValueChanged += new System.EventHandler(this.NumericTeamNumber_ValueChanged);
            // 
            // LabelAvail
            // 
            this.LabelAvail.AutoSize = true;
            this.LabelAvail.Location = new System.Drawing.Point(605, 305);
            this.LabelAvail.Name = "LabelAvail";
            this.LabelAvail.Size = new System.Drawing.Size(88, 16);
            this.LabelAvail.TabIndex = 16;
            this.LabelAvail.Text = "Not Available";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(204, 341);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(114, 46);
            this.ButtonSave.TabIndex = 17;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(401, 341);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(114, 46);
            this.ButtonCancel.TabIndex = 18;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ComboBoxNation
            // 
            this.ComboBoxNation.FormattingEnabled = true;
            this.ComboBoxNation.Location = new System.Drawing.Point(292, 220);
            this.ComboBoxNation.Name = "ComboBoxNation";
            this.ComboBoxNation.Size = new System.Drawing.Size(291, 24);
            this.ComboBoxNation.TabIndex = 19;
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBoxNation);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelAvail);
            this.Controls.Add(this.NumericTeamNumber);
            this.Controls.Add(this.ComboBoxTeam);
            this.Controls.Add(this.DateTimeBirthdate);
            this.Controls.Add(this.TextBoxPlayerName);
            this.Controls.Add(this.TextBoxPlayerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonLast);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonPrev);
            this.Controls.Add(this.ButtonFirst);
            this.Name = "FormPlayer";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericTeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFirst;
        private System.Windows.Forms.Button ButtonPrev;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxPlayerID;
        private System.Windows.Forms.TextBox TextBoxPlayerName;
        private System.Windows.Forms.DateTimePicker DateTimeBirthdate;
        private System.Windows.Forms.ComboBox ComboBoxTeam;
        private System.Windows.Forms.NumericUpDown NumericTeamNumber;
        private System.Windows.Forms.Label LabelAvail;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ComboBox ComboBoxNation;
    }
}

