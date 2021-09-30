namespace Lab2_TheQuest
{
    partial class QuestGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestGame));
            this.MoveLable = new System.Windows.Forms.Label();
            this.Move_Up_BTN = new System.Windows.Forms.Button();
            this.Move_Left_BTN = new System.Windows.Forms.Button();
            this.Move_Right_BTN = new System.Windows.Forms.Button();
            this.Move_Down_BTN = new System.Windows.Forms.Button();
            this.Attack_Down_BTN = new System.Windows.Forms.Button();
            this.Attack_Right_BTN = new System.Windows.Forms.Button();
            this.Attack_Left_BTN = new System.Windows.Forms.Button();
            this.Attack_Up_BTN = new System.Windows.Forms.Button();
            this.Attack_Lable = new System.Windows.Forms.Label();
            this.infoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPointLabel = new System.Windows.Forms.Label();
            this.ghostHitPointLabel = new System.Windows.Forms.Label();
            this.batHitPointLabel = new System.Windows.Forms.Label();
            this.playerHitPointLabel = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.Enemy_BatLabel = new System.Windows.Forms.Label();
            this.Enemy_GhostLabel = new System.Windows.Forms.Label();
            this.Enemy_GhoulLabel = new System.Windows.Forms.Label();
            this.Inventory_Sword = new System.Windows.Forms.PictureBox();
            this.Inventory_Bow = new System.Windows.Forms.PictureBox();
            this.Inventory_Mace = new System.Windows.Forms.PictureBox();
            this.Inventory_RedPotion = new System.Windows.Forms.PictureBox();
            this.Inventory_BluePotion = new System.Windows.Forms.PictureBox();
            this.Map_Player = new System.Windows.Forms.PictureBox();
            this.Map_Bat = new System.Windows.Forms.PictureBox();
            this.Map_Ghost = new System.Windows.Forms.PictureBox();
            this.Map_Ghoul = new System.Windows.Forms.PictureBox();
            this.Map_Sword = new System.Windows.Forms.PictureBox();
            this.Map_Bow = new System.Windows.Forms.PictureBox();
            this.Map_Mace = new System.Windows.Forms.PictureBox();
            this.Map_RedPotion = new System.Windows.Forms.PictureBox();
            this.Map_BluePotion = new System.Windows.Forms.PictureBox();
            this.infoTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_RedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_BluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_RedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_BluePotion)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveLable
            // 
            this.MoveLable.AutoSize = true;
            this.MoveLable.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MoveLable.Location = new System.Drawing.Point(610, 10);
            this.MoveLable.Name = "MoveLable";
            this.MoveLable.Size = new System.Drawing.Size(48, 15);
            this.MoveLable.TabIndex = 1;
            this.MoveLable.Text = "Move";
            // 
            // Move_Up_BTN
            // 
            this.Move_Up_BTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Move_Up_BTN.Location = new System.Drawing.Point(655, 28);
            this.Move_Up_BTN.Name = "Move_Up_BTN";
            this.Move_Up_BTN.Size = new System.Drawing.Size(80, 20);
            this.Move_Up_BTN.TabIndex = 2;
            this.Move_Up_BTN.Text = "Up";
            this.Move_Up_BTN.UseVisualStyleBackColor = true;
            this.Move_Up_BTN.Click += new System.EventHandler(this.Move_Up_BTN_Click);
            // 
            // Move_Left_BTN
            // 
            this.Move_Left_BTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Move_Left_BTN.Location = new System.Drawing.Point(606, 54);
            this.Move_Left_BTN.Name = "Move_Left_BTN";
            this.Move_Left_BTN.Size = new System.Drawing.Size(80, 20);
            this.Move_Left_BTN.TabIndex = 3;
            this.Move_Left_BTN.Text = "Left";
            this.Move_Left_BTN.UseVisualStyleBackColor = true;
            this.Move_Left_BTN.Click += new System.EventHandler(this.Move_Left_BTN_Click);
            // 
            // Move_Right_BTN
            // 
            this.Move_Right_BTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Move_Right_BTN.Location = new System.Drawing.Point(692, 54);
            this.Move_Right_BTN.Name = "Move_Right_BTN";
            this.Move_Right_BTN.Size = new System.Drawing.Size(80, 20);
            this.Move_Right_BTN.TabIndex = 4;
            this.Move_Right_BTN.Text = "Right";
            this.Move_Right_BTN.UseVisualStyleBackColor = true;
            this.Move_Right_BTN.Click += new System.EventHandler(this.Move_Right_BTN_Click);
            // 
            // Move_Down_BTN
            // 
            this.Move_Down_BTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Move_Down_BTN.Location = new System.Drawing.Point(655, 80);
            this.Move_Down_BTN.Name = "Move_Down_BTN";
            this.Move_Down_BTN.Size = new System.Drawing.Size(80, 20);
            this.Move_Down_BTN.TabIndex = 5;
            this.Move_Down_BTN.Text = "Down";
            this.Move_Down_BTN.UseVisualStyleBackColor = true;
            this.Move_Down_BTN.Click += new System.EventHandler(this.Move_Down_BTN_Click);
            // 
            // Attack_Down_BTN
            // 
            this.Attack_Down_BTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Attack_Down_BTN.Location = new System.Drawing.Point(655, 196);
            this.Attack_Down_BTN.Name = "Attack_Down_BTN";
            this.Attack_Down_BTN.Size = new System.Drawing.Size(80, 20);
            this.Attack_Down_BTN.TabIndex = 10;
            this.Attack_Down_BTN.Text = "Down";
            this.Attack_Down_BTN.UseVisualStyleBackColor = true;
            this.Attack_Down_BTN.Click += new System.EventHandler(this.Attack_Down_BTN_Click);
            // 
            // Attack_Right_BTN
            // 
            this.Attack_Right_BTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Attack_Right_BTN.Location = new System.Drawing.Point(692, 165);
            this.Attack_Right_BTN.Name = "Attack_Right_BTN";
            this.Attack_Right_BTN.Size = new System.Drawing.Size(80, 20);
            this.Attack_Right_BTN.TabIndex = 9;
            this.Attack_Right_BTN.Text = "Right";
            this.Attack_Right_BTN.UseVisualStyleBackColor = true;
            this.Attack_Right_BTN.Click += new System.EventHandler(this.Attack_Right_BTN_Click);
            // 
            // Attack_Left_BTN
            // 
            this.Attack_Left_BTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Attack_Left_BTN.Location = new System.Drawing.Point(606, 165);
            this.Attack_Left_BTN.Name = "Attack_Left_BTN";
            this.Attack_Left_BTN.Size = new System.Drawing.Size(80, 20);
            this.Attack_Left_BTN.TabIndex = 8;
            this.Attack_Left_BTN.Text = "Left";
            this.Attack_Left_BTN.UseVisualStyleBackColor = true;
            this.Attack_Left_BTN.Click += new System.EventHandler(this.Attack_Left_BTN_Click);
            // 
            // Attack_Up_BTN
            // 
            this.Attack_Up_BTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Attack_Up_BTN.Location = new System.Drawing.Point(655, 134);
            this.Attack_Up_BTN.Name = "Attack_Up_BTN";
            this.Attack_Up_BTN.Size = new System.Drawing.Size(80, 20);
            this.Attack_Up_BTN.TabIndex = 7;
            this.Attack_Up_BTN.Text = "Up";
            this.Attack_Up_BTN.UseVisualStyleBackColor = true;
            this.Attack_Up_BTN.Click += new System.EventHandler(this.Attack_Up_BTN_Click);
            // 
            // Attack_Lable
            // 
            this.Attack_Lable.AutoSize = true;
            this.Attack_Lable.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Attack_Lable.Location = new System.Drawing.Point(610, 116);
            this.Attack_Lable.Name = "Attack_Lable";
            this.Attack_Lable.Size = new System.Drawing.Size(53, 15);
            this.Attack_Lable.TabIndex = 6;
            this.Attack_Lable.Text = "Attack";
            // 
            // infoTableLayoutPanel
            // 
            this.infoTableLayoutPanel.ColumnCount = 2;
            this.infoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.99371F));
            this.infoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.00629F));
            this.infoTableLayoutPanel.Controls.Add(this.ghoulHitPointLabel, 1, 3);
            this.infoTableLayoutPanel.Controls.Add(this.ghostHitPointLabel, 1, 2);
            this.infoTableLayoutPanel.Controls.Add(this.batHitPointLabel, 1, 1);
            this.infoTableLayoutPanel.Controls.Add(this.playerHitPointLabel, 1, 0);
            this.infoTableLayoutPanel.Controls.Add(this.PlayerLabel, 0, 0);
            this.infoTableLayoutPanel.Controls.Add(this.Enemy_BatLabel, 0, 1);
            this.infoTableLayoutPanel.Controls.Add(this.Enemy_GhostLabel, 0, 2);
            this.infoTableLayoutPanel.Controls.Add(this.Enemy_GhoulLabel, 0, 3);
            this.infoTableLayoutPanel.Location = new System.Drawing.Point(613, 236);
            this.infoTableLayoutPanel.Name = "infoTableLayoutPanel";
            this.infoTableLayoutPanel.RowCount = 4;
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infoTableLayoutPanel.Size = new System.Drawing.Size(159, 153);
            this.infoTableLayoutPanel.TabIndex = 11;
            // 
            // ghoulHitPointLabel
            // 
            this.ghoulHitPointLabel.AutoSize = true;
            this.ghoulHitPointLabel.Location = new System.Drawing.Point(64, 114);
            this.ghoulHitPointLabel.Name = "ghoulHitPointLabel";
            this.ghoulHitPointLabel.Size = new System.Drawing.Size(78, 12);
            this.ghoulHitPointLabel.TabIndex = 7;
            this.ghoulHitPointLabel.Text = "ghoulHitPoint";
            this.ghoulHitPointLabel.Visible = false;
            // 
            // ghostHitPointLabel
            // 
            this.ghostHitPointLabel.AutoSize = true;
            this.ghostHitPointLabel.Location = new System.Drawing.Point(64, 76);
            this.ghostHitPointLabel.Name = "ghostHitPointLabel";
            this.ghostHitPointLabel.Size = new System.Drawing.Size(78, 12);
            this.ghostHitPointLabel.TabIndex = 6;
            this.ghostHitPointLabel.Text = "ghostHitPoint";
            this.ghostHitPointLabel.Visible = false;
            // 
            // batHitPointLabel
            // 
            this.batHitPointLabel.AutoSize = true;
            this.batHitPointLabel.Location = new System.Drawing.Point(64, 38);
            this.batHitPointLabel.Name = "batHitPointLabel";
            this.batHitPointLabel.Size = new System.Drawing.Size(64, 12);
            this.batHitPointLabel.TabIndex = 5;
            this.batHitPointLabel.Text = "batHitPoint";
            this.batHitPointLabel.Visible = false;
            // 
            // playerHitPointLabel
            // 
            this.playerHitPointLabel.AutoSize = true;
            this.playerHitPointLabel.Location = new System.Drawing.Point(64, 0);
            this.playerHitPointLabel.Name = "playerHitPointLabel";
            this.playerHitPointLabel.Size = new System.Drawing.Size(82, 12);
            this.playerHitPointLabel.TabIndex = 4;
            this.playerHitPointLabel.Text = "playerHitPoint";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(3, 0);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(41, 12);
            this.PlayerLabel.TabIndex = 0;
            this.PlayerLabel.Text = "Player";
            // 
            // Enemy_BatLabel
            // 
            this.Enemy_BatLabel.AutoSize = true;
            this.Enemy_BatLabel.Location = new System.Drawing.Point(3, 38);
            this.Enemy_BatLabel.Name = "Enemy_BatLabel";
            this.Enemy_BatLabel.Size = new System.Drawing.Size(23, 12);
            this.Enemy_BatLabel.TabIndex = 1;
            this.Enemy_BatLabel.Text = "Bat";
            // 
            // Enemy_GhostLabel
            // 
            this.Enemy_GhostLabel.AutoSize = true;
            this.Enemy_GhostLabel.Location = new System.Drawing.Point(3, 76);
            this.Enemy_GhostLabel.Name = "Enemy_GhostLabel";
            this.Enemy_GhostLabel.Size = new System.Drawing.Size(38, 12);
            this.Enemy_GhostLabel.TabIndex = 2;
            this.Enemy_GhostLabel.Text = "Ghost";
            // 
            // Enemy_GhoulLabel
            // 
            this.Enemy_GhoulLabel.AutoSize = true;
            this.Enemy_GhoulLabel.Location = new System.Drawing.Point(3, 114);
            this.Enemy_GhoulLabel.Name = "Enemy_GhoulLabel";
            this.Enemy_GhoulLabel.Size = new System.Drawing.Size(38, 12);
            this.Enemy_GhoulLabel.TabIndex = 3;
            this.Enemy_GhoulLabel.Text = "Ghoul";
            // 
            // Inventory_Sword
            // 
            this.Inventory_Sword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.Inventory_Sword.Image = ((System.Drawing.Image)(resources.GetObject("Inventory_Sword.Image")));
            this.Inventory_Sword.Location = new System.Drawing.Point(77, 318);
            this.Inventory_Sword.Name = "Inventory_Sword";
            this.Inventory_Sword.Size = new System.Drawing.Size(50, 50);
            this.Inventory_Sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Inventory_Sword.TabIndex = 12;
            this.Inventory_Sword.TabStop = false;
            this.Inventory_Sword.Visible = false;
            this.Inventory_Sword.Click += new System.EventHandler(this.Inventory_Sword_Click);
            // 
            // Inventory_Bow
            // 
            this.Inventory_Bow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.Inventory_Bow.Image = ((System.Drawing.Image)(resources.GetObject("Inventory_Bow.Image")));
            this.Inventory_Bow.Location = new System.Drawing.Point(133, 318);
            this.Inventory_Bow.Name = "Inventory_Bow";
            this.Inventory_Bow.Size = new System.Drawing.Size(50, 50);
            this.Inventory_Bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Inventory_Bow.TabIndex = 13;
            this.Inventory_Bow.TabStop = false;
            this.Inventory_Bow.Visible = false;
            this.Inventory_Bow.Click += new System.EventHandler(this.Inventory_Bow_Click);
            // 
            // Inventory_Mace
            // 
            this.Inventory_Mace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.Inventory_Mace.Image = ((System.Drawing.Image)(resources.GetObject("Inventory_Mace.Image")));
            this.Inventory_Mace.Location = new System.Drawing.Point(189, 318);
            this.Inventory_Mace.Name = "Inventory_Mace";
            this.Inventory_Mace.Size = new System.Drawing.Size(50, 50);
            this.Inventory_Mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Inventory_Mace.TabIndex = 14;
            this.Inventory_Mace.TabStop = false;
            this.Inventory_Mace.Visible = false;
            this.Inventory_Mace.Click += new System.EventHandler(this.Inventory_Mace_Click);
            // 
            // Inventory_RedPotion
            // 
            this.Inventory_RedPotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.Inventory_RedPotion.Image = ((System.Drawing.Image)(resources.GetObject("Inventory_RedPotion.Image")));
            this.Inventory_RedPotion.Location = new System.Drawing.Point(357, 318);
            this.Inventory_RedPotion.Name = "Inventory_RedPotion";
            this.Inventory_RedPotion.Size = new System.Drawing.Size(50, 50);
            this.Inventory_RedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Inventory_RedPotion.TabIndex = 15;
            this.Inventory_RedPotion.TabStop = false;
            this.Inventory_RedPotion.Visible = false;
            this.Inventory_RedPotion.Click += new System.EventHandler(this.Inventory_RedPotion_Click);
            // 
            // Inventory_BluePotion
            // 
            this.Inventory_BluePotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.Inventory_BluePotion.Image = ((System.Drawing.Image)(resources.GetObject("Inventory_BluePotion.Image")));
            this.Inventory_BluePotion.Location = new System.Drawing.Point(413, 318);
            this.Inventory_BluePotion.Name = "Inventory_BluePotion";
            this.Inventory_BluePotion.Size = new System.Drawing.Size(50, 50);
            this.Inventory_BluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Inventory_BluePotion.TabIndex = 16;
            this.Inventory_BluePotion.TabStop = false;
            this.Inventory_BluePotion.Visible = false;
            this.Inventory_BluePotion.Click += new System.EventHandler(this.Inventory_BluePotion_Click);
            // 
            // Map_Player
            // 
            this.Map_Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Map_Player.Image = ((System.Drawing.Image)(resources.GetObject("Map_Player.Image")));
            this.Map_Player.Location = new System.Drawing.Point(77, 60);
            this.Map_Player.Name = "Map_Player";
            this.Map_Player.Size = new System.Drawing.Size(40, 40);
            this.Map_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map_Player.TabIndex = 17;
            this.Map_Player.TabStop = false;
            // 
            // Map_Bat
            // 
            this.Map_Bat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Map_Bat.Image = ((System.Drawing.Image)(resources.GetObject("Map_Bat.Image")));
            this.Map_Bat.Location = new System.Drawing.Point(77, 106);
            this.Map_Bat.Name = "Map_Bat";
            this.Map_Bat.Size = new System.Drawing.Size(40, 40);
            this.Map_Bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map_Bat.TabIndex = 18;
            this.Map_Bat.TabStop = false;
            this.Map_Bat.Visible = false;
            // 
            // Map_Ghost
            // 
            this.Map_Ghost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Map_Ghost.Image = ((System.Drawing.Image)(resources.GetObject("Map_Ghost.Image")));
            this.Map_Ghost.Location = new System.Drawing.Point(123, 106);
            this.Map_Ghost.Name = "Map_Ghost";
            this.Map_Ghost.Size = new System.Drawing.Size(40, 40);
            this.Map_Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map_Ghost.TabIndex = 19;
            this.Map_Ghost.TabStop = false;
            this.Map_Ghost.Visible = false;
            // 
            // Map_Ghoul
            // 
            this.Map_Ghoul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Map_Ghoul.Image = ((System.Drawing.Image)(resources.GetObject("Map_Ghoul.Image")));
            this.Map_Ghoul.Location = new System.Drawing.Point(169, 106);
            this.Map_Ghoul.Name = "Map_Ghoul";
            this.Map_Ghoul.Size = new System.Drawing.Size(40, 40);
            this.Map_Ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map_Ghoul.TabIndex = 20;
            this.Map_Ghoul.TabStop = false;
            this.Map_Ghoul.Visible = false;
            // 
            // Map_Sword
            // 
            this.Map_Sword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Map_Sword.Image = ((System.Drawing.Image)(resources.GetObject("Map_Sword.Image")));
            this.Map_Sword.Location = new System.Drawing.Point(77, 152);
            this.Map_Sword.Name = "Map_Sword";
            this.Map_Sword.Size = new System.Drawing.Size(40, 40);
            this.Map_Sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map_Sword.TabIndex = 21;
            this.Map_Sword.TabStop = false;
            this.Map_Sword.Visible = false;
            // 
            // Map_Bow
            // 
            this.Map_Bow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Map_Bow.Image = ((System.Drawing.Image)(resources.GetObject("Map_Bow.Image")));
            this.Map_Bow.Location = new System.Drawing.Point(123, 152);
            this.Map_Bow.Name = "Map_Bow";
            this.Map_Bow.Size = new System.Drawing.Size(40, 40);
            this.Map_Bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map_Bow.TabIndex = 22;
            this.Map_Bow.TabStop = false;
            this.Map_Bow.Visible = false;
            // 
            // Map_Mace
            // 
            this.Map_Mace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Map_Mace.Image = ((System.Drawing.Image)(resources.GetObject("Map_Mace.Image")));
            this.Map_Mace.Location = new System.Drawing.Point(169, 152);
            this.Map_Mace.Name = "Map_Mace";
            this.Map_Mace.Size = new System.Drawing.Size(40, 40);
            this.Map_Mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map_Mace.TabIndex = 24;
            this.Map_Mace.TabStop = false;
            this.Map_Mace.Visible = false;
            // 
            // Map_RedPotion
            // 
            this.Map_RedPotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Map_RedPotion.Image = ((System.Drawing.Image)(resources.GetObject("Map_RedPotion.Image")));
            this.Map_RedPotion.Location = new System.Drawing.Point(215, 152);
            this.Map_RedPotion.Name = "Map_RedPotion";
            this.Map_RedPotion.Size = new System.Drawing.Size(40, 40);
            this.Map_RedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map_RedPotion.TabIndex = 25;
            this.Map_RedPotion.TabStop = false;
            this.Map_RedPotion.Visible = false;
            // 
            // Map_BluePotion
            // 
            this.Map_BluePotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Map_BluePotion.Image = ((System.Drawing.Image)(resources.GetObject("Map_BluePotion.Image")));
            this.Map_BluePotion.Location = new System.Drawing.Point(261, 152);
            this.Map_BluePotion.Name = "Map_BluePotion";
            this.Map_BluePotion.Size = new System.Drawing.Size(40, 40);
            this.Map_BluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map_BluePotion.TabIndex = 26;
            this.Map_BluePotion.TabStop = false;
            this.Map_BluePotion.Visible = false;
            // 
            // QuestGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.Map_BluePotion);
            this.Controls.Add(this.Map_RedPotion);
            this.Controls.Add(this.Map_Mace);
            this.Controls.Add(this.Map_Bow);
            this.Controls.Add(this.Map_Sword);
            this.Controls.Add(this.Map_Ghoul);
            this.Controls.Add(this.Map_Ghost);
            this.Controls.Add(this.Map_Bat);
            this.Controls.Add(this.Map_Player);
            this.Controls.Add(this.Inventory_BluePotion);
            this.Controls.Add(this.Inventory_RedPotion);
            this.Controls.Add(this.Inventory_Mace);
            this.Controls.Add(this.Inventory_Bow);
            this.Controls.Add(this.Inventory_Sword);
            this.Controls.Add(this.infoTableLayoutPanel);
            this.Controls.Add(this.Attack_Down_BTN);
            this.Controls.Add(this.Attack_Right_BTN);
            this.Controls.Add(this.Attack_Left_BTN);
            this.Controls.Add(this.Attack_Up_BTN);
            this.Controls.Add(this.Attack_Lable);
            this.Controls.Add(this.Move_Down_BTN);
            this.Controls.Add(this.Move_Right_BTN);
            this.Controls.Add(this.Move_Left_BTN);
            this.Controls.Add(this.Move_Up_BTN);
            this.Controls.Add(this.MoveLable);
            this.DoubleBuffered = true;
            this.Name = "QuestGame";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.QuestGame_Load);
            this.infoTableLayoutPanel.ResumeLayout(false);
            this.infoTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_RedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_BluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_RedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_BluePotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MoveLable;
        private System.Windows.Forms.Button Move_Up_BTN;
        private System.Windows.Forms.Button Move_Left_BTN;
        private System.Windows.Forms.Button Move_Right_BTN;
        private System.Windows.Forms.Button Move_Down_BTN;
        private System.Windows.Forms.Label Attack_Lable;
        private System.Windows.Forms.Button Attack_Up_BTN;
        private System.Windows.Forms.Button Attack_Left_BTN;
        private System.Windows.Forms.Button Attack_Right_BTN;
        private System.Windows.Forms.Button Attack_Down_BTN;
        private System.Windows.Forms.TableLayoutPanel infoTableLayoutPanel;
        private System.Windows.Forms.PictureBox Inventory_Sword;
        private System.Windows.Forms.PictureBox Inventory_Bow;
        private System.Windows.Forms.PictureBox Inventory_Mace;
        private System.Windows.Forms.PictureBox Inventory_RedPotion;
        private System.Windows.Forms.PictureBox Inventory_BluePotion;
        private System.Windows.Forms.PictureBox Map_Player;
        private System.Windows.Forms.PictureBox Map_Bat;
        private System.Windows.Forms.PictureBox Map_Ghost;
        private System.Windows.Forms.PictureBox Map_Ghoul;
        private System.Windows.Forms.PictureBox Map_Sword;
        private System.Windows.Forms.PictureBox Map_Bow;
        private System.Windows.Forms.PictureBox Map_Mace;
        private System.Windows.Forms.PictureBox Map_RedPotion;
        private System.Windows.Forms.PictureBox Map_BluePotion;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label ghoulHitPointLabel;
        private System.Windows.Forms.Label ghostHitPointLabel;
        private System.Windows.Forms.Label batHitPointLabel;
        private System.Windows.Forms.Label playerHitPointLabel;
        private System.Windows.Forms.Label Enemy_BatLabel;
        private System.Windows.Forms.Label Enemy_GhostLabel;
        private System.Windows.Forms.Label Enemy_GhoulLabel;
    }
}

