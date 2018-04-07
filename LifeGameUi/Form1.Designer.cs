namespace LifeGameUi
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wyczyscButton = new System.Windows.Forms.Button();
            this.planszaPanel1 = new LifeGameUi.PlanszaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.liczbaKomorekTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(95, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wyczyscButton
            // 
            this.wyczyscButton.Location = new System.Drawing.Point(177, 13);
            this.wyczyscButton.Name = "wyczyscButton";
            this.wyczyscButton.Size = new System.Drawing.Size(75, 23);
            this.wyczyscButton.TabIndex = 3;
            this.wyczyscButton.Text = "Wyczyść";
            this.wyczyscButton.UseVisualStyleBackColor = true;
            this.wyczyscButton.Click += new System.EventHandler(this.wyczyscButton_Click);
            // 
            // planszaPanel1
            // 
            this.planszaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planszaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaPanel1.Location = new System.Drawing.Point(13, 43);
            this.planszaPanel1.Name = "planszaPanel1";
            this.planszaPanel1.Plansza = null;
            this.planszaPanel1.Size = new System.Drawing.Size(514, 410);
            this.planszaPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Startowa liczba komórek:";
            // 
            // liczbaKomorekTB
            // 
            this.liczbaKomorekTB.Location = new System.Drawing.Point(392, 15);
            this.liczbaKomorekTB.Name = "liczbaKomorekTB";
            this.liczbaKomorekTB.Size = new System.Drawing.Size(115, 20);
            this.liczbaKomorekTB.TabIndex = 5;
            this.liczbaKomorekTB.Text = "500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 465);
            this.Controls.Add(this.liczbaKomorekTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wyczyscButton);
            this.Controls.Add(this.planszaPanel1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Gra w życie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button StopButton;
        private PlanszaPanel planszaPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button wyczyscButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox liczbaKomorekTB;
    }
}

