namespace Bismillah
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lbCondition = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            this.lbSunrise = new System.Windows.Forms.Label();
            this.SunriseNA = new System.Windows.Forms.Label();
            this.lbSunset = new System.Windows.Forms.Label();
            this.SunsetNA = new System.Windows.Forms.Label();
            this.lbWindSpeed = new System.Windows.Forms.Label();
            this.WindNA = new System.Windows.Forms.Label();
            this.lbPressure = new System.Windows.Forms.Label();
            this.PressureNA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1107, -11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 78);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(215, 92);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(374, 31);
            this.tbCity.TabIndex = 1;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.BackColor = System.Drawing.Color.Transparent;
            this.City.Font = new System.Drawing.Font("Montserrat SemiBold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(93, 79);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(116, 51);
            this.City.TabIndex = 2;
            this.City.Text = "City :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(628, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 60);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(75, 165);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(264, 123);
            this.picIcon.TabIndex = 4;
            this.picIcon.TabStop = false;
            // 
            // lbCondition
            // 
            this.lbCondition.AutoSize = true;
            this.lbCondition.BackColor = System.Drawing.Color.Transparent;
            this.lbCondition.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCondition.Location = new System.Drawing.Point(88, 318);
            this.lbCondition.Name = "lbCondition";
            this.lbCondition.Size = new System.Drawing.Size(204, 44);
            this.lbCondition.TabIndex = 5;
            this.lbCondition.Text = "Condition :";
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.BackColor = System.Drawing.Color.Transparent;
            this.lbDetail.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.Location = new System.Drawing.Point(88, 373);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(120, 44);
            this.lbDetail.TabIndex = 5;
            this.lbDetail.Text = "Detail";
            // 
            // lbSunrise
            // 
            this.lbSunrise.AutoSize = true;
            this.lbSunrise.BackColor = System.Drawing.Color.Transparent;
            this.lbSunrise.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSunrise.Location = new System.Drawing.Point(88, 427);
            this.lbSunrise.Name = "lbSunrise";
            this.lbSunrise.Size = new System.Drawing.Size(164, 44);
            this.lbSunrise.TabIndex = 5;
            this.lbSunrise.Text = "Sunrise :";
            // 
            // SunriseNA
            // 
            this.SunriseNA.AutoSize = true;
            this.SunriseNA.BackColor = System.Drawing.Color.Transparent;
            this.SunriseNA.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunriseNA.Location = new System.Drawing.Point(258, 427);
            this.SunriseNA.Name = "SunriseNA";
            this.SunriseNA.Size = new System.Drawing.Size(81, 44);
            this.SunriseNA.TabIndex = 5;
            this.SunriseNA.Text = "N/A";
            // 
            // lbSunset
            // 
            this.lbSunset.AutoSize = true;
            this.lbSunset.BackColor = System.Drawing.Color.Transparent;
            this.lbSunset.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSunset.Location = new System.Drawing.Point(88, 486);
            this.lbSunset.Name = "lbSunset";
            this.lbSunset.Size = new System.Drawing.Size(154, 44);
            this.lbSunset.TabIndex = 5;
            this.lbSunset.Text = "Sunset :";
            // 
            // SunsetNA
            // 
            this.SunsetNA.AutoSize = true;
            this.SunsetNA.BackColor = System.Drawing.Color.Transparent;
            this.SunsetNA.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunsetNA.Location = new System.Drawing.Point(258, 486);
            this.SunsetNA.Name = "SunsetNA";
            this.SunsetNA.Size = new System.Drawing.Size(81, 44);
            this.SunsetNA.TabIndex = 5;
            this.SunsetNA.Text = "N/A";
            // 
            // lbWindSpeed
            // 
            this.lbWindSpeed.AutoSize = true;
            this.lbWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lbWindSpeed.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWindSpeed.Location = new System.Drawing.Point(641, 318);
            this.lbWindSpeed.Name = "lbWindSpeed";
            this.lbWindSpeed.Size = new System.Drawing.Size(241, 44);
            this.lbWindSpeed.TabIndex = 5;
            this.lbWindSpeed.Text = "Wind speed :";
            // 
            // WindNA
            // 
            this.WindNA.AutoSize = true;
            this.WindNA.BackColor = System.Drawing.Color.Transparent;
            this.WindNA.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindNA.Location = new System.Drawing.Point(900, 318);
            this.WindNA.Name = "WindNA";
            this.WindNA.Size = new System.Drawing.Size(81, 44);
            this.WindNA.TabIndex = 5;
            this.WindNA.Text = "N/A";
            // 
            // lbPressure
            // 
            this.lbPressure.AutoSize = true;
            this.lbPressure.BackColor = System.Drawing.Color.Transparent;
            this.lbPressure.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPressure.Location = new System.Drawing.Point(641, 377);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(184, 44);
            this.lbPressure.TabIndex = 5;
            this.lbPressure.Text = "Pressure :";
            // 
            // PressureNA
            // 
            this.PressureNA.AutoSize = true;
            this.PressureNA.BackColor = System.Drawing.Color.Transparent;
            this.PressureNA.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureNA.Location = new System.Drawing.Point(900, 377);
            this.PressureNA.Name = "PressureNA";
            this.PressureNA.Size = new System.Drawing.Size(81, 44);
            this.PressureNA.TabIndex = 5;
            this.PressureNA.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Bismillah.Properties.Resources.Pink_desktop_wallpaper_laptop_computer_background_4k_full_HD_sky_clouds_sunset_home_screen_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1181, 651);
            this.Controls.Add(this.PressureNA);
            this.Controls.Add(this.lbPressure);
            this.Controls.Add(this.SunsetNA);
            this.Controls.Add(this.WindNA);
            this.Controls.Add(this.lbSunset);
            this.Controls.Add(this.lbWindSpeed);
            this.Controls.Add(this.SunriseNA);
            this.Controls.Add(this.lbSunrise);
            this.Controls.Add(this.lbDetail);
            this.Controls.Add(this.lbCondition);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.City);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.btnClose);
            this.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lbCondition;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.Label lbSunrise;
        private System.Windows.Forms.Label SunriseNA;
        private System.Windows.Forms.Label lbSunset;
        private System.Windows.Forms.Label SunsetNA;
        private System.Windows.Forms.Label lbWindSpeed;
        private System.Windows.Forms.Label WindNA;
        private System.Windows.Forms.Label lbPressure;
        private System.Windows.Forms.Label PressureNA;
    }
}

