﻿namespace interior
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnObjCreate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이미지로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.제작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWarn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listRoom = new System.Windows.Forms.ListBox();
            this.btnRoomCreate = new System.Windows.Forms.Button();
            this.btnRoomRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listObj = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObjCreate
            // 
            this.btnObjCreate.Location = new System.Drawing.Point(1127, 113);
            this.btnObjCreate.Name = "btnObjCreate";
            this.btnObjCreate.Size = new System.Drawing.Size(80, 41);
            this.btnObjCreate.TabIndex = 0;
            this.btnObjCreate.Text = "객체 추가";
            this.btnObjCreate.UseVisualStyleBackColor = true;
            this.btnObjCreate.Click += new System.EventHandler(this.btnObjCreate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1407, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.이미지로저장ToolStripMenuItem,
            this.toolStripSeparator2,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.새로만들기ToolStripMenuItem.Text = "새로 만들기";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 이미지로저장ToolStripMenuItem
            // 
            this.이미지로저장ToolStripMenuItem.Name = "이미지로저장ToolStripMenuItem";
            this.이미지로저장ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.이미지로저장ToolStripMenuItem.Text = "이미지로 저장";
            this.이미지로저장ToolStripMenuItem.Click += new System.EventHandler(this.이미지로저장ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.제작ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 제작ToolStripMenuItem
            // 
            this.제작ToolStripMenuItem.Name = "제작ToolStripMenuItem";
            this.제작ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.제작ToolStripMenuItem.Text = "제작";
            this.제작ToolStripMenuItem.Click += new System.EventHandler(this.제작ToolStripMenuItem_Click);
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.Location = new System.Drawing.Point(12, 693);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(60, 15);
            this.lblWarn.TabIndex = 0;
            this.lblWarn.Text = "Warning";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 659);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // listRoom
            // 
            this.listRoom.FormattingEnabled = true;
            this.listRoom.ItemHeight = 15;
            this.listRoom.Location = new System.Drawing.Point(841, 160);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(270, 289);
            this.listRoom.TabIndex = 4;
            // 
            // btnRoomCreate
            // 
            this.btnRoomCreate.Location = new System.Drawing.Point(841, 113);
            this.btnRoomCreate.Name = "btnRoomCreate";
            this.btnRoomCreate.Size = new System.Drawing.Size(80, 41);
            this.btnRoomCreate.TabIndex = 5;
            this.btnRoomCreate.Text = "방 추가";
            this.btnRoomCreate.UseVisualStyleBackColor = true;
            // 
            // btnRoomRemove
            // 
            this.btnRoomRemove.Location = new System.Drawing.Point(1031, 113);
            this.btnRoomRemove.Name = "btnRoomRemove";
            this.btnRoomRemove.Size = new System.Drawing.Size(80, 41);
            this.btnRoomRemove.TabIndex = 6;
            this.btnRoomRemove.Text = "방 삭제";
            this.btnRoomRemove.UseVisualStyleBackColor = true;
            this.btnRoomRemove.Click += new System.EventHandler(this.btnRoomRemove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(936, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "방 편집";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1224, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "객체 편집";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1317, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "객체 삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listObj
            // 
            this.listObj.FormattingEnabled = true;
            this.listObj.ItemHeight = 15;
            this.listObj.Location = new System.Drawing.Point(1127, 160);
            this.listObj.Name = "listObj";
            this.listObj.Size = new System.Drawing.Size(270, 289);
            this.listObj.TabIndex = 10;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1407, 717);
            this.Controls.Add(this.listObj);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRoomRemove);
            this.Controls.Add(this.btnRoomCreate);
            this.Controls.Add(this.listRoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.btnObjCreate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Self Interior Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObjCreate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이미지로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 제작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listRoom;
        private System.Windows.Forms.Button btnRoomCreate;
        private System.Windows.Forms.Button btnRoomRemove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listObj;
    }
}

