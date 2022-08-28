
namespace Profile_Creator
{
    partial class ProfileCreator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Source = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Class = new System.Windows.Forms.TextBox();
            this.btn_Source = new System.Windows.Forms.Button();
            this.rb_File = new System.Windows.Forms.RadioButton();
            this.rb_Folder = new System.Windows.Forms.RadioButton();
            this.btn_Destination = new System.Windows.Forms.Button();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Guide = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Temp = new System.Windows.Forms.TextBox();
            this.btn_Temp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.btn_Destination);
            this.groupBox1.Controls.Add(this.txt_Destination);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rb_Folder);
            this.groupBox1.Controls.Add(this.rb_File);
            this.groupBox1.Controls.Add(this.btn_Temp);
            this.groupBox1.Controls.Add(this.btn_Source);
            this.groupBox1.Controls.Add(this.txt_Class);
            this.groupBox1.Controls.Add(this.txt_Temp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Source);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "مبدأ:";
            // 
            // txt_Source
            // 
            this.txt_Source.Location = new System.Drawing.Point(93, 88);
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.ReadOnly = true;
            this.txt_Source.Size = new System.Drawing.Size(326, 23);
            this.txt_Source.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام کلاس:";
            // 
            // txt_Class
            // 
            this.txt_Class.Location = new System.Drawing.Point(6, 161);
            this.txt_Class.Name = "txt_Class";
            this.txt_Class.Size = new System.Drawing.Size(413, 23);
            this.txt_Class.TabIndex = 1;
            // 
            // btn_Source
            // 
            this.btn_Source.Location = new System.Drawing.Point(6, 83);
            this.btn_Source.Name = "btn_Source";
            this.btn_Source.Size = new System.Drawing.Size(81, 33);
            this.btn_Source.TabIndex = 2;
            this.btn_Source.Text = "انتخاب";
            this.btn_Source.UseVisualStyleBackColor = true;
            this.btn_Source.Click += new System.EventHandler(this.btn_Source_Click);
            // 
            // rb_File
            // 
            this.rb_File.AutoSize = true;
            this.rb_File.Location = new System.Drawing.Point(372, 22);
            this.rb_File.Name = "rb_File";
            this.rb_File.Size = new System.Drawing.Size(53, 21);
            this.rb_File.TabIndex = 3;
            this.rb_File.Text = "فایل";
            this.rb_File.UseVisualStyleBackColor = true;
            // 
            // rb_Folder
            // 
            this.rb_Folder.AutoSize = true;
            this.rb_Folder.Checked = true;
            this.rb_Folder.Location = new System.Drawing.Point(431, 22);
            this.rb_Folder.Name = "rb_Folder";
            this.rb_Folder.Size = new System.Drawing.Size(61, 21);
            this.rb_Folder.TabIndex = 3;
            this.rb_Folder.TabStop = true;
            this.rb_Folder.Text = "پوشه";
            this.rb_Folder.UseVisualStyleBackColor = true;
            this.rb_Folder.CheckedChanged += new System.EventHandler(this.rb_Folder_CheckedChanged);
            // 
            // btn_Destination
            // 
            this.btn_Destination.Location = new System.Drawing.Point(6, 122);
            this.btn_Destination.Name = "btn_Destination";
            this.btn_Destination.Size = new System.Drawing.Size(81, 33);
            this.btn_Destination.TabIndex = 6;
            this.btn_Destination.Text = "انتخاب";
            this.btn_Destination.UseVisualStyleBackColor = true;
            this.btn_Destination.Click += new System.EventHandler(this.btn_Destination_Click);
            // 
            // txt_Destination
            // 
            this.txt_Destination.Location = new System.Drawing.Point(93, 127);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.ReadOnly = true;
            this.txt_Destination.Size = new System.Drawing.Size(326, 23);
            this.txt_Destination.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "مقصد:";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(429, 257);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(81, 33);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "شروع";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Guide
            // 
            this.btn_Guide.Location = new System.Drawing.Point(12, 257);
            this.btn_Guide.Name = "btn_Guide";
            this.btn_Guide.Size = new System.Drawing.Size(81, 33);
            this.btn_Guide.TabIndex = 8;
            this.btn_Guide.Text = "راهنما";
            this.btn_Guide.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 194);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(486, 39);
            this.progressBar.TabIndex = 9;
            this.progressBar.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "قالب:";
            // 
            // txt_Temp
            // 
            this.txt_Temp.Location = new System.Drawing.Point(93, 49);
            this.txt_Temp.Name = "txt_Temp";
            this.txt_Temp.ReadOnly = true;
            this.txt_Temp.Size = new System.Drawing.Size(326, 23);
            this.txt_Temp.TabIndex = 1;
            // 
            // btn_Temp
            // 
            this.btn_Temp.Location = new System.Drawing.Point(6, 44);
            this.btn_Temp.Name = "btn_Temp";
            this.btn_Temp.Size = new System.Drawing.Size(81, 33);
            this.btn_Temp.TabIndex = 2;
            this.btn_Temp.Text = "انتخاب";
            this.btn_Temp.UseVisualStyleBackColor = true;
            this.btn_Temp.Click += new System.EventHandler(this.btn_Temp_Click);
            // 
            // ProfileCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 302);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Guide);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProfileCreator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ساخت پروفایل";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btn_Destination;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_Folder;
        private System.Windows.Forms.RadioButton rb_File;
        private System.Windows.Forms.Button btn_Source;
        private System.Windows.Forms.TextBox txt_Class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Guide;
        private System.Windows.Forms.Button btn_Temp;
        private System.Windows.Forms.TextBox txt_Temp;
        private System.Windows.Forms.Label label4;
    }
}