
namespace William_Chamness_206_Assignment_3
{
    partial class SingleStateInfoForm
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
            this.stateNameLabel = new System.Windows.Forms.Label();
            this.stateCapitalLabel = new System.Windows.Forms.Label();
            this.stateLargestCityLabel = new System.Windows.Forms.Label();
            this.statePopulationLabel = new System.Windows.Forms.Label();
            this.stateFlowerLabel = new System.Windows.Forms.Label();
            this.stateBirdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stateNameLabel
            // 
            this.stateNameLabel.AutoSize = true;
            this.stateNameLabel.Location = new System.Drawing.Point(60, 50);
            this.stateNameLabel.Name = "stateNameLabel";
            this.stateNameLabel.Size = new System.Drawing.Size(217, 13);
            this.stateNameLabel.TabIndex = 0;
            this.stateNameLabel.Text = "state name label to be changed on form load";
            // 
            // stateCapitalLabel
            // 
            this.stateCapitalLabel.AutoSize = true;
            this.stateCapitalLabel.Location = new System.Drawing.Point(60, 63);
            this.stateCapitalLabel.Name = "stateCapitalLabel";
            this.stateCapitalLabel.Size = new System.Drawing.Size(222, 13);
            this.stateCapitalLabel.TabIndex = 1;
            this.stateCapitalLabel.Text = "state capital label to be changed on form load";
            // 
            // stateLargestCityLabel
            // 
            this.stateLargestCityLabel.AutoSize = true;
            this.stateLargestCityLabel.Location = new System.Drawing.Point(60, 76);
            this.stateLargestCityLabel.Name = "stateLargestCityLabel";
            this.stateLargestCityLabel.Size = new System.Drawing.Size(241, 13);
            this.stateLargestCityLabel.TabIndex = 2;
            this.stateLargestCityLabel.Text = "state largest city label to be changed on form load";
            // 
            // statePopulationLabel
            // 
            this.statePopulationLabel.AutoSize = true;
            this.statePopulationLabel.Location = new System.Drawing.Point(60, 89);
            this.statePopulationLabel.Name = "statePopulationLabel";
            this.statePopulationLabel.Size = new System.Drawing.Size(240, 13);
            this.statePopulationLabel.TabIndex = 3;
            this.statePopulationLabel.Text = "state population label to be changed on form load";
            // 
            // stateFlowerLabel
            // 
            this.stateFlowerLabel.AutoSize = true;
            this.stateFlowerLabel.Location = new System.Drawing.Point(60, 103);
            this.stateFlowerLabel.Name = "stateFlowerLabel";
            this.stateFlowerLabel.Size = new System.Drawing.Size(219, 13);
            this.stateFlowerLabel.TabIndex = 5;
            this.stateFlowerLabel.Text = "state flower label to be changed on form load";
            // 
            // stateBirdLabel
            // 
            this.stateBirdLabel.AutoSize = true;
            this.stateBirdLabel.Location = new System.Drawing.Point(60, 116);
            this.stateBirdLabel.Name = "stateBirdLabel";
            this.stateBirdLabel.Size = new System.Drawing.Size(208, 13);
            this.stateBirdLabel.TabIndex = 6;
            this.stateBirdLabel.Text = "state bird label to be changed on form load";
            // 
            // SingleStateInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 232);
            this.Controls.Add(this.stateBirdLabel);
            this.Controls.Add(this.stateFlowerLabel);
            this.Controls.Add(this.statePopulationLabel);
            this.Controls.Add(this.stateLargestCityLabel);
            this.Controls.Add(this.stateCapitalLabel);
            this.Controls.Add(this.stateNameLabel);
            this.Name = "SingleStateInfoForm";
            this.Text = "SingleStateInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stateNameLabel;
        private System.Windows.Forms.Label stateCapitalLabel;
        private System.Windows.Forms.Label stateLargestCityLabel;
        private System.Windows.Forms.Label statePopulationLabel;
        private System.Windows.Forms.Label stateFlowerLabel;
        private System.Windows.Forms.Label stateBirdLabel;
    }
}