namespace ElevatorControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_lift_down = new System.Windows.Forms.Timer(this.components);
            this.timer_lift_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_up = new System.Windows.Forms.Timer(this.components);
            this.database_listbox = new System.Windows.Forms.ListBox();
            this.btn_displaylog = new System.Windows.Forms.Button();
            this.btn_clearlog = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.door_left_up = new System.Windows.Forms.PictureBox();
            this.door_right_up = new System.Windows.Forms.PictureBox();
            this.door_left_down = new System.Windows.Forms.PictureBox();
            this.door_right_down = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_G = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.display_bottom = new System.Windows.Forms.PictureBox();
            this.display_panel = new System.Windows.Forms.PictureBox();
            this.display_top = new System.Windows.Forms.PictureBox();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.bg_panel = new System.Windows.Forms.PictureBox();
            this.picture_lift = new System.Windows.Forms.PictureBox();
            this.concrete = new System.Windows.Forms.PictureBox();
            this.bg_firstfloor = new System.Windows.Forms.PictureBox();
            this.bg_groundfloor = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concrete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_firstfloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_groundfloor)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_lift_down
            // 
            this.timer_lift_down.Interval = 15;
            this.timer_lift_down.Tick += new System.EventHandler(this.timer_lift_down_Tick);
            // 
            // timer_lift_up
            // 
            this.timer_lift_up.Interval = 15;
            this.timer_lift_up.Tick += new System.EventHandler(this.timer_lift_up_Tick);
            // 
            // timer_door_open_down
            // 
            this.timer_door_open_down.Interval = 5;
            this.timer_door_open_down.Tick += new System.EventHandler(this.door_open_down_Tick);
            // 
            // timer_door_close_down
            // 
            this.timer_door_close_down.Interval = 5;
            this.timer_door_close_down.Tick += new System.EventHandler(this.door_close_down_Tick);
            // 
            // timer_door_open_up
            // 
            this.timer_door_open_up.Interval = 5;
            this.timer_door_open_up.Tick += new System.EventHandler(this.timer_door_open_up_Tick);
            // 
            // timer_door_close_up
            // 
            this.timer_door_close_up.Interval = 5;
            this.timer_door_close_up.Tick += new System.EventHandler(this.timer_door_close_up_Tick);
            // 
            // database_listbox
            // 
            this.database_listbox.FormattingEnabled = true;
            this.database_listbox.Location = new System.Drawing.Point(500, 51);
            this.database_listbox.Name = "database_listbox";
            this.database_listbox.Size = new System.Drawing.Size(465, 550);
            this.database_listbox.TabIndex = 20;
            // 
            // btn_displaylog
            // 
            this.btn_displaylog.Location = new System.Drawing.Point(980, 76);
            this.btn_displaylog.Name = "btn_displaylog";
            this.btn_displaylog.Size = new System.Drawing.Size(129, 35);
            this.btn_displaylog.TabIndex = 21;
            this.btn_displaylog.Text = "Display Log";
            this.btn_displaylog.UseVisualStyleBackColor = true;
            this.btn_displaylog.Click += new System.EventHandler(this.btn_displaylog_Click);
            // 
            // btn_clearlog
            // 
            this.btn_clearlog.Location = new System.Drawing.Point(980, 126);
            this.btn_clearlog.Name = "btn_clearlog";
            this.btn_clearlog.Size = new System.Drawing.Size(128, 33);
            this.btn_clearlog.TabIndex = 22;
            this.btn_clearlog.Text = "Clear Log";
            this.btn_clearlog.UseVisualStyleBackColor = true;
            this.btn_clearlog.Click += new System.EventHandler(this.btn_clearlog_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(980, 584);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(128, 30);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Action";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(489, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 604);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elevator Log";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(309, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 485);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Panel";
            // 
            // door_left_up
            // 
            this.door_left_up.BackColor = System.Drawing.SystemColors.Control;
            this.door_left_up.Image = global::ElevatorControl.Properties.Resources.lift_door_left;
            this.door_left_up.Location = new System.Drawing.Point(74, 63);
            this.door_left_up.Name = "door_left_up";
            this.door_left_up.Size = new System.Drawing.Size(66, 196);
            this.door_left_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_left_up.TabIndex = 18;
            this.door_left_up.TabStop = false;
            // 
            // door_right_up
            // 
            this.door_right_up.Image = global::ElevatorControl.Properties.Resources.lift_door_right;
            this.door_right_up.Location = new System.Drawing.Point(139, 63);
            this.door_right_up.Name = "door_right_up";
            this.door_right_up.Size = new System.Drawing.Size(65, 196);
            this.door_right_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_right_up.TabIndex = 19;
            this.door_right_up.TabStop = false;
            // 
            // door_left_down
            // 
            this.door_left_down.BackColor = System.Drawing.SystemColors.Control;
            this.door_left_down.Image = global::ElevatorControl.Properties.Resources.lift_door_left;
            this.door_left_down.Location = new System.Drawing.Point(74, 377);
            this.door_left_down.Name = "door_left_down";
            this.door_left_down.Size = new System.Drawing.Size(66, 196);
            this.door_left_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_left_down.TabIndex = 16;
            this.door_left_down.TabStop = false;
            // 
            // door_right_down
            // 
            this.door_right_down.Image = global::ElevatorControl.Properties.Resources.lift_door_right;
            this.door_right_down.Location = new System.Drawing.Point(139, 377);
            this.door_right_down.Name = "door_right_down";
            this.door_right_down.Size = new System.Drawing.Size(65, 196);
            this.door_right_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_right_down.TabIndex = 17;
            this.door_right_down.TabStop = false;
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.White;
            this.btn_open.BackgroundImage = global::ElevatorControl.Properties.Resources.opendoorbutton;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_open.Location = new System.Drawing.Point(396, 394);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(46, 42);
            this.btn_open.TabIndex = 14;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.BackgroundImage = global::ElevatorControl.Properties.Resources.closedoorsbutton;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.Location = new System.Drawing.Point(339, 394);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(46, 42);
            this.btn_close.TabIndex = 13;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_G
            // 
            this.btn_G.BackColor = System.Drawing.Color.White;
            this.btn_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_G.BackgroundImage")));
            this.btn_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_G.Location = new System.Drawing.Point(364, 317);
            this.btn_G.Name = "btn_G";
            this.btn_G.Size = new System.Drawing.Size(51, 48);
            this.btn_G.TabIndex = 12;
            this.btn_G.UseVisualStyleBackColor = false;
            this.btn_G.Click += new System.EventHandler(this.btn_G_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.White;
            this.btn_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_1.BackgroundImage")));
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_1.Location = new System.Drawing.Point(364, 263);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(51, 48);
            this.btn_1.TabIndex = 11;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // display_bottom
            // 
            this.display_bottom.BackColor = System.Drawing.Color.Transparent;
            this.display_bottom.BackgroundImage = global::ElevatorControl.Properties.Resources.black;
            this.display_bottom.Location = new System.Drawing.Point(132, 339);
            this.display_bottom.Name = "display_bottom";
            this.display_bottom.Size = new System.Drawing.Size(13, 14);
            this.display_bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_bottom.TabIndex = 9;
            this.display_bottom.TabStop = false;
            // 
            // display_panel
            // 
            this.display_panel.BackColor = System.Drawing.Color.Black;
            this.display_panel.BackgroundImage = global::ElevatorControl.Properties.Resources.black;
            this.display_panel.Location = new System.Drawing.Point(357, 135);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(64, 71);
            this.display_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_panel.TabIndex = 10;
            this.display_panel.TabStop = false;
            // 
            // display_top
            // 
            this.display_top.BackColor = System.Drawing.Color.Black;
            this.display_top.BackgroundImage = global::ElevatorControl.Properties.Resources.black;
            this.display_top.Location = new System.Drawing.Point(132, 28);
            this.display_top.Name = "display_top";
            this.display_top.Size = new System.Drawing.Size(13, 14);
            this.display_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_top.TabIndex = 8;
            this.display_top.TabStop = false;
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_down.BackgroundImage")));
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_down.Location = new System.Drawing.Point(223, 454);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(40, 39);
            this.btn_down.TabIndex = 7;
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_up.BackgroundImage")));
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_up.Location = new System.Drawing.Point(223, 148);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(40, 39);
            this.btn_up.TabIndex = 6;
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // bg_panel
            // 
            this.bg_panel.Image = global::ElevatorControl.Properties.Resources.panel;
            this.bg_panel.Location = new System.Drawing.Point(317, 98);
            this.bg_panel.Name = "bg_panel";
            this.bg_panel.Size = new System.Drawing.Size(143, 454);
            this.bg_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_panel.TabIndex = 4;
            this.bg_panel.TabStop = false;
            // 
            // picture_lift
            // 
            this.picture_lift.BackColor = System.Drawing.Color.Transparent;
            this.picture_lift.Image = global::ElevatorControl.Properties.Resources.Inside_of_the_lift;
            this.picture_lift.Location = new System.Drawing.Point(74, 63);
            this.picture_lift.Name = "picture_lift";
            this.picture_lift.Size = new System.Drawing.Size(130, 192);
            this.picture_lift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_lift.TabIndex = 3;
            this.picture_lift.TabStop = false;
            // 
            // concrete
            // 
            this.concrete.Image = global::ElevatorControl.Properties.Resources.concrete;
            this.concrete.Location = new System.Drawing.Point(1, 290);
            this.concrete.Name = "concrete";
            this.concrete.Size = new System.Drawing.Size(276, 27);
            this.concrete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.concrete.TabIndex = 2;
            this.concrete.TabStop = false;
            // 
            // bg_firstfloor
            // 
            this.bg_firstfloor.BackColor = System.Drawing.Color.Transparent;
            this.bg_firstfloor.Image = global::ElevatorControl.Properties.Resources.First_Floor;
            this.bg_firstfloor.Location = new System.Drawing.Point(1, 0);
            this.bg_firstfloor.Name = "bg_firstfloor";
            this.bg_firstfloor.Size = new System.Drawing.Size(276, 317);
            this.bg_firstfloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bg_firstfloor.TabIndex = 0;
            this.bg_firstfloor.TabStop = false;
            // 
            // bg_groundfloor
            // 
            this.bg_groundfloor.BackColor = System.Drawing.Color.Transparent;
            this.bg_groundfloor.Image = global::ElevatorControl.Properties.Resources.Ground_Floor;
            this.bg_groundfloor.Location = new System.Drawing.Point(1, 311);
            this.bg_groundfloor.Name = "bg_groundfloor";
            this.bg_groundfloor.Size = new System.Drawing.Size(276, 317);
            this.bg_groundfloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bg_groundfloor.TabIndex = 1;
            this.bg_groundfloor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1121, 626);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clearlog);
            this.Controls.Add(this.btn_displaylog);
            this.Controls.Add(this.database_listbox);
            this.Controls.Add(this.door_left_up);
            this.Controls.Add(this.door_right_up);
            this.Controls.Add(this.door_left_down);
            this.Controls.Add(this.door_right_down);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_G);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.display_bottom);
            this.Controls.Add(this.display_panel);
            this.Controls.Add(this.display_top);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.bg_panel);
            this.Controls.Add(this.picture_lift);
            this.Controls.Add(this.concrete);
            this.Controls.Add(this.bg_firstfloor);
            this.Controls.Add(this.bg_groundfloor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Florin Tudor Elevator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concrete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_firstfloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_groundfloor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bg_firstfloor;
        private System.Windows.Forms.PictureBox bg_groundfloor;
        private System.Windows.Forms.PictureBox concrete;
        private System.Windows.Forms.PictureBox picture_lift;
        private System.Windows.Forms.Timer timer_lift_down;
        private System.Windows.Forms.PictureBox bg_panel;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Timer timer_lift_up;
        private System.Windows.Forms.PictureBox display_top;
        private System.Windows.Forms.PictureBox display_bottom;
        private System.Windows.Forms.PictureBox display_panel;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_G;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.PictureBox door_left_down;
        private System.Windows.Forms.PictureBox door_right_down;
        private System.Windows.Forms.Timer timer_door_open_down;
        private System.Windows.Forms.Timer timer_door_close_down;
        private System.Windows.Forms.PictureBox door_left_up;
        private System.Windows.Forms.PictureBox door_right_up;
        private System.Windows.Forms.Timer timer_door_open_up;
        private System.Windows.Forms.Timer timer_door_close_up;
        private System.Windows.Forms.ListBox database_listbox;
        private System.Windows.Forms.Button btn_displaylog;
        private System.Windows.Forms.Button btn_clearlog;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

