namespace MyApplication
{
    partial class SettingsScreen
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
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonCategories = new System.Windows.Forms.Button();
            this.ButtonRooms = new System.Windows.Forms.Button();
            this.ButtonRates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(693, 408);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonCategories
            // 
            this.ButtonCategories.Location = new System.Drawing.Point(12, 12);
            this.ButtonCategories.Name = "ButtonCategories";
            this.ButtonCategories.Size = new System.Drawing.Size(83, 73);
            this.ButtonCategories.TabIndex = 1;
            this.ButtonCategories.Text = "Categories";
            this.ButtonCategories.UseVisualStyleBackColor = true;
            this.ButtonCategories.Click += new System.EventHandler(this.ButtonCategories_Click);
            // 
            // ButtonRooms
            // 
            this.ButtonRooms.Location = new System.Drawing.Point(102, 12);
            this.ButtonRooms.Name = "ButtonRooms";
            this.ButtonRooms.Size = new System.Drawing.Size(87, 73);
            this.ButtonRooms.TabIndex = 2;
            this.ButtonRooms.Text = "Rooms";
            this.ButtonRooms.UseVisualStyleBackColor = true;
            this.ButtonRooms.Click += new System.EventHandler(this.ButtonRooms_Click);
            // 
            // ButtonRates
            // 
            this.ButtonRates.Location = new System.Drawing.Point(12, 91);
            this.ButtonRates.Name = "ButtonRates";
            this.ButtonRates.Size = new System.Drawing.Size(83, 73);
            this.ButtonRates.TabIndex = 3;
            this.ButtonRates.Text = "Rates";
            this.ButtonRates.UseVisualStyleBackColor = true;
            this.ButtonRates.Click += new System.EventHandler(this.ButtonRates_Click);
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonRates);
            this.Controls.Add(this.ButtonRooms);
            this.Controls.Add(this.ButtonCategories);
            this.Controls.Add(this.ButtonExit);
            this.Name = "SettingsScreen";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonCategories;
        private System.Windows.Forms.Button ButtonRooms;
        private System.Windows.Forms.Button ButtonRates;
    }
}