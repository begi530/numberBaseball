
namespace numberBaseball
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lvlList = new System.Windows.Forms.ListView();
            this.clIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.game = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msSet = new System.Windows.Forms.ToolStripMenuItem();
            this.msSet3 = new System.Windows.Forms.ToolStripMenuItem();
            this.msSet4 = new System.Windows.Forms.ToolStripMenuItem();
            this.msSt = new System.Windows.Forms.ToolStripMenuItem();
            this.msRe = new System.Windows.Forms.ToolStripMenuItem();
            this.msHe = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.Location = new System.Drawing.Point(6, 15);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.Location = new System.Drawing.Point(72, 15);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.Location = new System.Drawing.Point(138, 15);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn4.Location = new System.Drawing.Point(6, 81);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn5.Location = new System.Drawing.Point(72, 81);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn6.Location = new System.Drawing.Point(138, 81);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn7.Location = new System.Drawing.Point(6, 147);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn8.Location = new System.Drawing.Point(72, 147);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn9.Location = new System.Drawing.Point(138, 147);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("굴림", 20F);
            this.btnCheck.Location = new System.Drawing.Point(206, 81);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(60, 126);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "✔️";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lvlList
            // 
            this.lvlList.BackColor = System.Drawing.SystemColors.InfoText;
            this.lvlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clIn,
            this.clHit,
            this.clS,
            this.clB,
            this.clO});
            this.lvlList.Font = new System.Drawing.Font("굴림", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvlList.ForeColor = System.Drawing.SystemColors.Window;
            this.lvlList.GridLines = true;
            this.lvlList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvlList.HideSelection = false;
            this.lvlList.Location = new System.Drawing.Point(32, 29);
            this.lvlList.Name = "lvlList";
            this.lvlList.Size = new System.Drawing.Size(470, 309);
            this.lvlList.TabIndex = 14;
            this.lvlList.UseCompatibleStateImageBehavior = false;
            this.lvlList.View = System.Windows.Forms.View.Details;
            this.lvlList.Visible = false;
            // 
            // clIn
            // 
            this.clIn.Text = "Inning";
            this.clIn.Width = 80;
            // 
            // clHit
            // 
            this.clHit.Text = "Hitting";
            this.clHit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clHit.Width = 150;
            // 
            // clS
            // 
            this.clS.Text = "S";
            this.clS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clB
            // 
            this.clB.Text = "B";
            this.clB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clO
            // 
            this.clO.Text = "O";
            this.clO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Location = new System.Drawing.Point(564, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 220);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
            this.btnDel.Location = new System.Drawing.Point(204, 15);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 60);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "🠔";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNum.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.txtNum.Location = new System.Drawing.Point(564, 266);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(109, 55);
            this.txtNum.TabIndex = 13;
            this.txtNum.Visible = false;
            // 
            // game
            // 
            this.game.Interval = 1000;
            this.game.Tick += new System.EventHandler(this.game_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSet,
            this.msSt,
            this.msRe,
            this.msHe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 471);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 17;
            // 
            // msSet
            // 
            this.msSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSet3,
            this.msSet4});
            this.msSet.Name = "msSet";
            this.msSet.Size = new System.Drawing.Size(88, 24);
            this.msSet.Text = "게임 설정";
            // 
            // msSet3
            // 
            this.msSet3.Name = "msSet3";
            this.msSet3.Size = new System.Drawing.Size(215, 26);
            this.msSet3.Text = "3자리 숫자 맞추기";
            this.msSet3.Click += new System.EventHandler(this.msSet3_Click);
            // 
            // msSet4
            // 
            this.msSet4.Name = "msSet4";
            this.msSet4.Size = new System.Drawing.Size(215, 26);
            this.msSet4.Text = "4자리 숫자 맞추기";
            this.msSet4.Click += new System.EventHandler(this.msSet4_Click);
            // 
            // msSt
            // 
            this.msSt.Name = "msSt";
            this.msSt.Size = new System.Drawing.Size(88, 24);
            this.msSt.Text = "게임 시작";
            this.msSt.Click += new System.EventHandler(this.msSt_Click);
            // 
            // msRe
            // 
            this.msRe.Name = "msRe";
            this.msRe.Size = new System.Drawing.Size(83, 24);
            this.msRe.Text = "다시하기";
            this.msRe.Visible = false;
            this.msRe.Click += new System.EventHandler(this.msRe_Click);
            // 
            // msHe
            // 
            this.msHe.Name = "msHe";
            this.msHe.Size = new System.Drawing.Size(88, 24);
            this.msHe.Text = "게임 설명";
            this.msHe.Click += new System.EventHandler(this.msHe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::numberBaseball.Properties.Resources.ｂａｃｋｇｒｏｕｎｄ;
            this.ClientSize = new System.Drawing.Size(900, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvlList);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulls and Cows";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ColumnHeader clIn;
        private System.Windows.Forms.ColumnHeader clHit;
        private System.Windows.Forms.ColumnHeader clS;
        private System.Windows.Forms.ColumnHeader clB;
        private System.Windows.Forms.ColumnHeader clO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Timer game;
        private System.Windows.Forms.ListView lvlList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msHe;
        private System.Windows.Forms.ToolStripMenuItem msSt;
        private System.Windows.Forms.ToolStripMenuItem msRe;
        private System.Windows.Forms.ToolStripMenuItem msSet;
        private System.Windows.Forms.ToolStripMenuItem msSet4;
        private System.Windows.Forms.ToolStripMenuItem msSet3;
    }
}

