namespace Lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RaceBtn = new System.Windows.Forms.Button();
            this.BettingParlor = new System.Windows.Forms.GroupBox();
            this.GuyBet3 = new System.Windows.Forms.Label();
            this.GuyBet2 = new System.Windows.Forms.Label();
            this.GuyBet1 = new System.Windows.Forms.Label();
            this.Bet_Info = new System.Windows.Forms.Label();
            this.dogNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bucks = new System.Windows.Forms.NumericUpDown();
            this.BetBtn = new System.Windows.Forms.Button();
            this.selectName = new System.Windows.Forms.Label();
            this.GuyRadio3 = new System.Windows.Forms.RadioButton();
            this.GuyRadio2 = new System.Windows.Forms.RadioButton();
            this.GuyRadio1 = new System.Windows.Forms.RadioButton();
            this.MinBet_Info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.BettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceBtn
            // 
            this.RaceBtn.Location = new System.Drawing.Point(474, 136);
            this.RaceBtn.Name = "RaceBtn";
            this.RaceBtn.Size = new System.Drawing.Size(121, 36);
            this.RaceBtn.TabIndex = 19;
            this.RaceBtn.Text = "Race!";
            this.RaceBtn.UseVisualStyleBackColor = true;
            this.RaceBtn.Click += new System.EventHandler(this.Race_Click);
            // 
            // BettingParlor
            // 
            this.BettingParlor.Controls.Add(this.GuyBet3);
            this.BettingParlor.Controls.Add(this.GuyBet2);
            this.BettingParlor.Controls.Add(this.GuyBet1);
            this.BettingParlor.Controls.Add(this.Bet_Info);
            this.BettingParlor.Controls.Add(this.dogNum);
            this.BettingParlor.Controls.Add(this.label1);
            this.BettingParlor.Controls.Add(this.bucks);
            this.BettingParlor.Controls.Add(this.BetBtn);
            this.BettingParlor.Controls.Add(this.selectName);
            this.BettingParlor.Controls.Add(this.GuyRadio3);
            this.BettingParlor.Controls.Add(this.GuyRadio2);
            this.BettingParlor.Controls.Add(this.GuyRadio1);
            this.BettingParlor.Controls.Add(this.MinBet_Info);
            this.BettingParlor.Controls.Add(this.RaceBtn);
            this.BettingParlor.Location = new System.Drawing.Point(12, 220);
            this.BettingParlor.Name = "BettingParlor";
            this.BettingParlor.Size = new System.Drawing.Size(601, 178);
            this.BettingParlor.TabIndex = 5;
            this.BettingParlor.TabStop = false;
            this.BettingParlor.Text = "Betting Parlor";
            // 
            // GuyBet3
            // 
            this.GuyBet3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuyBet3.Location = new System.Drawing.Point(358, 108);
            this.GuyBet3.Name = "GuyBet3";
            this.GuyBet3.Size = new System.Drawing.Size(237, 14);
            this.GuyBet3.TabIndex = 18;
            this.GuyBet3.Text = "Al bets";
            // 
            // GuyBet2
            // 
            this.GuyBet2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuyBet2.Location = new System.Drawing.Point(358, 85);
            this.GuyBet2.Name = "GuyBet2";
            this.GuyBet2.Size = new System.Drawing.Size(237, 14);
            this.GuyBet2.TabIndex = 17;
            this.GuyBet2.Text = "Bob bets";
            // 
            // GuyBet1
            // 
            this.GuyBet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuyBet1.Location = new System.Drawing.Point(358, 60);
            this.GuyBet1.Name = "GuyBet1";
            this.GuyBet1.Size = new System.Drawing.Size(237, 14);
            this.GuyBet1.TabIndex = 16;
            this.GuyBet1.Text = "Joe bets";
            // 
            // Bet_Info
            // 
            this.Bet_Info.AutoSize = true;
            this.Bet_Info.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bet_Info.Location = new System.Drawing.Point(355, 27);
            this.Bet_Info.Name = "Bet_Info";
            this.Bet_Info.Size = new System.Drawing.Size(45, 16);
            this.Bet_Info.TabIndex = 15;
            this.Bet_Info.Text = "Bets";
            // 
            // dogNum
            // 
            this.dogNum.Location = new System.Drawing.Point(339, 151);
            this.dogNum.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNum.Name = "dogNum";
            this.dogNum.Size = new System.Drawing.Size(64, 21);
            this.dogNum.TabIndex = 14;
            this.dogNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "bucks on dog number";
            // 
            // bucks
            // 
            this.bucks.Location = new System.Drawing.Point(134, 151);
            this.bucks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bucks.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bucks.Name = "bucks";
            this.bucks.Size = new System.Drawing.Size(64, 21);
            this.bucks.TabIndex = 12;
            this.bucks.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BetBtn
            // 
            this.BetBtn.Location = new System.Drawing.Point(53, 151);
            this.BetBtn.Name = "BetBtn";
            this.BetBtn.Size = new System.Drawing.Size(75, 23);
            this.BetBtn.TabIndex = 11;
            this.BetBtn.Text = "Bets";
            this.BetBtn.UseVisualStyleBackColor = true;
            this.BetBtn.Click += new System.EventHandler(this.BetBtn_Click);
            // 
            // selectName
            // 
            this.selectName.AutoSize = true;
            this.selectName.Location = new System.Drawing.Point(10, 156);
            this.selectName.Name = "selectName";
            this.selectName.Size = new System.Drawing.Size(37, 12);
            this.selectName.TabIndex = 10;
            this.selectName.Text = "name";
            // 
            // GuyRadio3
            // 
            this.GuyRadio3.AutoSize = true;
            this.GuyRadio3.Location = new System.Drawing.Point(9, 106);
            this.GuyRadio3.Name = "GuyRadio3";
            this.GuyRadio3.Size = new System.Drawing.Size(34, 16);
            this.GuyRadio3.TabIndex = 9;
            this.GuyRadio3.TabStop = true;
            this.GuyRadio3.Text = "Al";
            this.GuyRadio3.UseVisualStyleBackColor = true;
            this.GuyRadio3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // GuyRadio2
            // 
            this.GuyRadio2.AutoSize = true;
            this.GuyRadio2.Location = new System.Drawing.Point(9, 83);
            this.GuyRadio2.Name = "GuyRadio2";
            this.GuyRadio2.Size = new System.Drawing.Size(45, 16);
            this.GuyRadio2.TabIndex = 8;
            this.GuyRadio2.TabStop = true;
            this.GuyRadio2.Text = "Bob";
            this.GuyRadio2.UseVisualStyleBackColor = true;
            this.GuyRadio2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // GuyRadio1
            // 
            this.GuyRadio1.AutoSize = true;
            this.GuyRadio1.Location = new System.Drawing.Point(9, 60);
            this.GuyRadio1.Name = "GuyRadio1";
            this.GuyRadio1.Size = new System.Drawing.Size(43, 16);
            this.GuyRadio1.TabIndex = 7;
            this.GuyRadio1.TabStop = true;
            this.GuyRadio1.Text = "Joe";
            this.GuyRadio1.UseVisualStyleBackColor = true;
            this.GuyRadio1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MinBet_Info
            // 
            this.MinBet_Info.AutoSize = true;
            this.MinBet_Info.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinBet_Info.Location = new System.Drawing.Point(6, 26);
            this.MinBet_Info.Name = "MinBet_Info";
            this.MinBet_Info.Size = new System.Drawing.Size(192, 16);
            this.MinBet_Info.TabIndex = 6;
            this.MinBet_Info.Text = "Minimum bet : 5 bucks";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dog1
            // 
            this.Dog1.Image = ((System.Drawing.Image)(resources.GetObject("Dog1.Image")));
            this.Dog1.Location = new System.Drawing.Point(24, 12);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(76, 22);
            this.Dog1.TabIndex = 1;
            this.Dog1.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.Image = ((System.Drawing.Image)(resources.GetObject("Dog2.Image")));
            this.Dog2.Location = new System.Drawing.Point(24, 62);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(76, 22);
            this.Dog2.TabIndex = 2;
            this.Dog2.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.Image = ((System.Drawing.Image)(resources.GetObject("Dog3.Image")));
            this.Dog3.Location = new System.Drawing.Point(24, 112);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(76, 22);
            this.Dog3.TabIndex = 3;
            this.Dog3.TabStop = false;
            // 
            // Dog4
            // 
            this.Dog4.Image = ((System.Drawing.Image)(resources.GetObject("Dog4.Image")));
            this.Dog4.Location = new System.Drawing.Point(24, 162);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(76, 22);
            this.Dog4.TabIndex = 4;
            this.Dog4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 404);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BettingParlor);
            this.Name = "Form1";
            this.Text = "A Day at the Race";
            this.BettingParlor.ResumeLayout(false);
            this.BettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RaceBtn;
        private System.Windows.Forms.GroupBox BettingParlor;
        private System.Windows.Forms.Label Bet_Info;
        private System.Windows.Forms.NumericUpDown dogNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown bucks;
        private System.Windows.Forms.Button BetBtn;
        private System.Windows.Forms.Label selectName;
        private System.Windows.Forms.RadioButton GuyRadio3;
        private System.Windows.Forms.RadioButton GuyRadio2;
        private System.Windows.Forms.RadioButton GuyRadio1;
        private System.Windows.Forms.Label MinBet_Info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.Label GuyBet3;
        private System.Windows.Forms.Label GuyBet2;
        private System.Windows.Forms.Label GuyBet1;
    }
}

