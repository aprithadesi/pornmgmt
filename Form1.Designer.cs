namespace vdomgr
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
            this.txtbx_filePath = new System.Windows.Forms.TextBox();
            this.txtbx_timeSeek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcat = new System.Windows.Forms.ComboBox();
            this.txttype = new System.Windows.Forms.ComboBox();
            this.btn_process = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_actor = new System.Windows.Forms.RadioButton();
            this.rb_action = new System.Windows.Forms.RadioButton();
            this.btnview = new System.Windows.Forms.Button();
            this.rb_pre = new System.Windows.Forms.RadioButton();
            this.rb_pro = new System.Windows.Forms.RadioButton();
            this.rb_must = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtbx_filePath
            // 
            this.txtbx_filePath.Location = new System.Drawing.Point(469, 85);
            this.txtbx_filePath.Multiline = true;
            this.txtbx_filePath.Name = "txtbx_filePath";
            this.txtbx_filePath.Size = new System.Drawing.Size(306, 262);
            this.txtbx_filePath.TabIndex = 0;
            this.txtbx_filePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtbx_filePath_DragDrop);
            this.txtbx_filePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbx_filePath_DragEnter);
            // 
            // txtbx_timeSeek
            // 
            this.txtbx_timeSeek.Location = new System.Drawing.Point(125, 62);
            this.txtbx_timeSeek.Name = "txtbx_timeSeek";
            this.txtbx_timeSeek.Size = new System.Drawing.Size(293, 20);
            this.txtbx_timeSeek.TabIndex = 1;
            this.txtbx_timeSeek.Text = "00:00:15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TimeSeek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type";
            // 
            // txtcat
            // 
            this.txtcat.FormattingEnabled = true;
            this.txtcat.Location = new System.Drawing.Point(125, 155);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(293, 21);
            this.txtcat.TabIndex = 8;
            this.txtcat.Text = "Test";
            // 
            // txttype
            // 
            this.txttype.FormattingEnabled = true;
            this.txttype.Location = new System.Drawing.Point(125, 186);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(293, 21);
            this.txttype.TabIndex = 9;
            this.txttype.Text = "Test";
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(190, 213);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(129, 39);
            this.btn_process.TabIndex = 10;
            this.btn_process.Text = "Process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_actor
            // 
            this.rb_actor.AutoSize = true;
            this.rb_actor.Location = new System.Drawing.Point(171, 115);
            this.rb_actor.Name = "rb_actor";
            this.rb_actor.Size = new System.Drawing.Size(50, 17);
            this.rb_actor.TabIndex = 12;
            this.rb_actor.TabStop = true;
            this.rb_actor.Text = "Actor";
            this.rb_actor.UseVisualStyleBackColor = true;
            this.rb_actor.CheckedChanged += new System.EventHandler(this.rb_actor_CheckedChanged);
            // 
            // rb_action
            // 
            this.rb_action.AutoSize = true;
            this.rb_action.Location = new System.Drawing.Point(262, 115);
            this.rb_action.Name = "rb_action";
            this.rb_action.Size = new System.Drawing.Size(52, 17);
            this.rb_action.TabIndex = 13;
            this.rb_action.TabStop = true;
            this.rb_action.Text = "Video";
            this.rb_action.UseVisualStyleBackColor = true;
            this.rb_action.CheckedChanged += new System.EventHandler(this.rb_action_CheckedChanged);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(274, 366);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(129, 39);
            this.btnview.TabIndex = 14;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // rb_pre
            // 
            this.rb_pre.AutoSize = true;
            this.rb_pre.Location = new System.Drawing.Point(12, 262);
            this.rb_pre.Name = "rb_pre";
            this.rb_pre.Size = new System.Drawing.Size(41, 17);
            this.rb_pre.TabIndex = 15;
            this.rb_pre.TabStop = true;
            this.rb_pre.Text = "Pre";
            this.rb_pre.UseVisualStyleBackColor = true;
            this.rb_pre.CheckedChanged += new System.EventHandler(this.rb_pre_CheckedChanged);
            // 
            // rb_pro
            // 
            this.rb_pro.AutoSize = true;
            this.rb_pro.Location = new System.Drawing.Point(12, 285);
            this.rb_pro.Name = "rb_pro";
            this.rb_pro.Size = new System.Drawing.Size(41, 17);
            this.rb_pro.TabIndex = 16;
            this.rb_pro.TabStop = true;
            this.rb_pro.Text = "Pro";
            this.rb_pro.UseVisualStyleBackColor = true;
            this.rb_pro.CheckedChanged += new System.EventHandler(this.rb_pro_CheckedChanged);
            // 
            // rb_must
            // 
            this.rb_must.AutoSize = true;
            this.rb_must.Location = new System.Drawing.Point(12, 308);
            this.rb_must.Name = "rb_must";
            this.rb_must.Size = new System.Drawing.Size(48, 17);
            this.rb_must.TabIndex = 17;
            this.rb_must.TabStop = true;
            this.rb_must.Text = "Must";
            this.rb_must.UseVisualStyleBackColor = true;
            this.rb_must.CheckedChanged += new System.EventHandler(this.rb_must_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_must);
            this.Controls.Add(this.rb_pro);
            this.Controls.Add(this.rb_pre);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.rb_action);
            this.Controls.Add(this.rb_actor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.txtcat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_timeSeek);
            this.Controls.Add(this.txtbx_filePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_filePath;
        private System.Windows.Forms.TextBox txtbx_timeSeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtcat;
        private System.Windows.Forms.ComboBox txttype;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_actor;
        private System.Windows.Forms.RadioButton rb_action;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.RadioButton rb_pre;
        private System.Windows.Forms.RadioButton rb_pro;
        private System.Windows.Forms.RadioButton rb_must;
    }
}

