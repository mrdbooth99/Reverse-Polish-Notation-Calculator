﻿namespace RPN
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
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Eval = new System.Windows.Forms.Button();
            this.Lbl_Output = new System.Windows.Forms.Label();
            this.radioArray = new System.Windows.Forms.RadioButton();
            this.radioLinkedList = new System.Windows.Forms.RadioButton();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlOption.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reverse Polish Notation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Input
            // 
            this.Txt_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Input.Location = new System.Drawing.Point(33, 51);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(238, 22);
            this.Txt_Input.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter expression to evaluate";
            // 
            // Btn_Eval
            // 
            this.Btn_Eval.Location = new System.Drawing.Point(195, 79);
            this.Btn_Eval.Name = "Btn_Eval";
            this.Btn_Eval.Size = new System.Drawing.Size(75, 23);
            this.Btn_Eval.TabIndex = 3;
            this.Btn_Eval.Text = "Evaluate";
            this.Btn_Eval.UseVisualStyleBackColor = true;
            this.Btn_Eval.Click += new System.EventHandler(this.Btn_Eval_Click);
            // 
            // Lbl_Output
            // 
            this.Lbl_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Output.Location = new System.Drawing.Point(-1, 101);
            this.Lbl_Output.Name = "Lbl_Output";
            this.Lbl_Output.Size = new System.Drawing.Size(311, 30);
            this.Lbl_Output.TabIndex = 4;
            this.Lbl_Output.Text = "...";
            this.Lbl_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioArray
            // 
            this.radioArray.AutoSize = true;
            this.radioArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioArray.Location = new System.Drawing.Point(87, 24);
            this.radioArray.Margin = new System.Windows.Forms.Padding(2);
            this.radioArray.Name = "radioArray";
            this.radioArray.Size = new System.Drawing.Size(57, 20);
            this.radioArray.TabIndex = 5;
            this.radioArray.Text = "Array";
            this.radioArray.UseVisualStyleBackColor = true;
            // 
            // radioLinkedList
            // 
            this.radioLinkedList.AutoSize = true;
            this.radioLinkedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLinkedList.Location = new System.Drawing.Point(153, 24);
            this.radioLinkedList.Margin = new System.Windows.Forms.Padding(2);
            this.radioLinkedList.Name = "radioLinkedList";
            this.radioLinkedList.Size = new System.Drawing.Size(88, 20);
            this.radioLinkedList.TabIndex = 6;
            this.radioLinkedList.TabStop = true;
            this.radioLinkedList.Text = "Linked List";
            this.radioLinkedList.UseVisualStyleBackColor = true;
            // 
            // pnlOption
            // 
            this.pnlOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOption.Controls.Add(this.label3);
            this.pnlOption.Controls.Add(this.radioLinkedList);
            this.pnlOption.Controls.Add(this.radioArray);
            this.pnlOption.Location = new System.Drawing.Point(6, 36);
            this.pnlOption.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(311, 49);
            this.pnlOption.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stack Implementation";
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.Btn_Eval);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.Lbl_Output);
            this.pnlMain.Controls.Add(this.Txt_Input);
            this.pnlMain.Location = new System.Drawing.Point(6, 90);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(311, 133);
            this.pnlMain.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 231);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOption.ResumeLayout(false);
            this.pnlOption.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Eval;
        private System.Windows.Forms.Label Lbl_Output;
        private System.Windows.Forms.RadioButton radioArray;
        private System.Windows.Forms.RadioButton radioLinkedList;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlMain;
    }
}

