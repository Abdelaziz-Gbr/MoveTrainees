using System;

namespace MoveTrainees
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkedListBox_Trainees = new System.Windows.Forms.CheckedListBox();
            this.btn_MoveTrainee = new System.Windows.Forms.Button();
            this.btn_MoveAllTrainees = new System.Windows.Forms.Button();
            this.btn_MoceLabTrainee = new System.Windows.Forms.Button();
            this.btn_MoveAllLabTrainees = new System.Windows.Forms.Button();
            this.chkedListBox_LabTrainees = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_lab = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Traniees";
            // 
            // chkedListBox_Trainees
            // 
            this.chkedListBox_Trainees.CheckOnClick = true;
            this.chkedListBox_Trainees.FormattingEnabled = true;
            this.chkedListBox_Trainees.Location = new System.Drawing.Point(12, 111);
            this.chkedListBox_Trainees.Name = "chkedListBox_Trainees";
            this.chkedListBox_Trainees.Size = new System.Drawing.Size(219, 214);
            this.chkedListBox_Trainees.TabIndex = 1;
            // 
            // btn_MoveTrainee
            // 
            this.btn_MoveTrainee.Location = new System.Drawing.Point(352, 111);
            this.btn_MoveTrainee.Name = "btn_MoveTrainee";
            this.btn_MoveTrainee.Size = new System.Drawing.Size(75, 23);
            this.btn_MoveTrainee.TabIndex = 2;
            this.btn_MoveTrainee.Text = ">";
            this.btn_MoveTrainee.UseVisualStyleBackColor = true;
            this.btn_MoveTrainee.Click += new System.EventHandler(this.btn_MoveTrainee_Click);
            // 
            // btn_MoveAllTrainees
            // 
            this.btn_MoveAllTrainees.Location = new System.Drawing.Point(352, 140);
            this.btn_MoveAllTrainees.Name = "btn_MoveAllTrainees";
            this.btn_MoveAllTrainees.Size = new System.Drawing.Size(75, 23);
            this.btn_MoveAllTrainees.TabIndex = 3;
            this.btn_MoveAllTrainees.Text = ">>";
            this.btn_MoveAllTrainees.UseVisualStyleBackColor = true;
            this.btn_MoveAllTrainees.Click += new System.EventHandler(this.btn_MoveAllTrainees_Click);
            // 
            // btn_MoceLabTrainee
            // 
            this.btn_MoceLabTrainee.Location = new System.Drawing.Point(352, 273);
            this.btn_MoceLabTrainee.Name = "btn_MoceLabTrainee";
            this.btn_MoceLabTrainee.Size = new System.Drawing.Size(75, 23);
            this.btn_MoceLabTrainee.TabIndex = 4;
            this.btn_MoceLabTrainee.Text = "<";
            this.btn_MoceLabTrainee.UseVisualStyleBackColor = true;
            this.btn_MoceLabTrainee.Click += new System.EventHandler(this.btn_MoceLabTrainee_Click);
            // 
            // btn_MoveAllLabTrainees
            // 
            this.btn_MoveAllLabTrainees.Location = new System.Drawing.Point(352, 302);
            this.btn_MoveAllLabTrainees.Name = "btn_MoveAllLabTrainees";
            this.btn_MoveAllLabTrainees.Size = new System.Drawing.Size(75, 23);
            this.btn_MoveAllLabTrainees.TabIndex = 5;
            this.btn_MoveAllLabTrainees.Text = "<<";
            this.btn_MoveAllLabTrainees.UseVisualStyleBackColor = true;
            this.btn_MoveAllLabTrainees.Click += new System.EventHandler(this.btn_MoveAllLabTrainees_Click);
            // 
            // chkedListBox_LabTrainees
            // 
            this.chkedListBox_LabTrainees.CheckOnClick = true;
            this.chkedListBox_LabTrainees.FormattingEnabled = true;
            this.chkedListBox_LabTrainees.Location = new System.Drawing.Point(569, 111);
            this.chkedListBox_LabTrainees.Name = "chkedListBox_LabTrainees";
            this.chkedListBox_LabTrainees.Size = new System.Drawing.Size(219, 214);
            this.chkedListBox_LabTrainees.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lab Trainees";
            // 
            // comboBox_lab
            // 
            this.comboBox_lab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lab.FormattingEnabled = true;
            this.comboBox_lab.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.comboBox_lab.Location = new System.Drawing.Point(596, 33);
            this.comboBox_lab.Name = "comboBox_lab";
            this.comboBox_lab.Size = new System.Drawing.Size(121, 21);
            this.comboBox_lab.TabIndex = 8;
            this.comboBox_lab.SelectedIndexChanged += new System.EventHandler(this.comboBox_lab_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_lab);
            this.Controls.Add(this.chkedListBox_LabTrainees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_MoveAllLabTrainees);
            this.Controls.Add(this.btn_MoceLabTrainee);
            this.Controls.Add(this.btn_MoveAllTrainees);
            this.Controls.Add(this.btn_MoveTrainee);
            this.Controls.Add(this.chkedListBox_Trainees);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Trainees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkedListBox_Trainees;
        private System.Windows.Forms.Button btn_MoveTrainee;
        private System.Windows.Forms.Button btn_MoveAllTrainees;
        private System.Windows.Forms.Button btn_MoceLabTrainee;
        private System.Windows.Forms.Button btn_MoveAllLabTrainees;
        private System.Windows.Forms.CheckedListBox chkedListBox_LabTrainees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_lab;
    }
}

