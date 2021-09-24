using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2_TheQuest
{
    public partial class QuestGame : Form
    {

        #region Variables 

        const int MAX_COUNT_WEAPON = 3;
        const int MAX_COUNT_POTION = 2;
        const int MAX_COUNT_ITEM = MAX_COUNT_WEAPON + MAX_COUNT_POTION;
        const int MAX_COUNT_ENEMY = 3;

        struct ItemInfo
        {
            public string itemName { get; private set; }
            public string itemType { get; private set; }
            public PictureBox itemPictureBox { get; private set; }

            public void Set(string _itemName, string _itemType, PictureBox _itemPictureBox)
            {
                itemName = _itemName;
                itemType = _itemType;
                itemPictureBox = _itemPictureBox;
            }
        }

        struct PlayerInfo
        {
            public int equipWeaponNumber { get; private set; }
            public string equipWeaponName { get; private set; }
            public string equipWeaponType { get; private set; }
            public PictureBox equipWeaponPictureBox { get; private set; }
            public PictureBox playerPictureBox { get; private set; }
            public Label playerLabelHitPoint { get; private set; }

            public void Set_equipWeapon(ItemInfo weapon)
            {
                equipWeaponName = weapon.itemName;
                equipWeaponType = weapon.itemType;
                equipWeaponPictureBox = weapon.itemPictureBox;
            }

            public void Set_Player(PictureBox _playerPictureBox, Label _playerLabelHitPoint)
            {
                playerPictureBox = _playerPictureBox;
                playerLabelHitPoint = _playerLabelHitPoint;
            }
        }

        struct EnemyInfo
        {
            public PictureBox enemyPictureBox { get; private set; }
            public Label enemyLabelHitPoint { get; private set; }

            public void Set(PictureBox _enemyPictureBox, Label _enemyLabelHitPoint)
            {
                enemyPictureBox = _enemyPictureBox;
                enemyLabelHitPoint = _enemyLabelHitPoint;
            }
        }
        
        PlayerInfo playerInfo = new PlayerInfo();
        ItemInfo[] weaponInfos = new ItemInfo[MAX_COUNT_WEAPON];
        ItemInfo[] potionInfos = new ItemInfo[MAX_COUNT_POTION];
        ItemInfo[] mapItems = new ItemInfo[MAX_COUNT_ITEM];
        EnemyInfo[] enemyInfos = new EnemyInfo[MAX_COUNT_ENEMY];

        private Game _game;
        private Random _random = new Random();
        private bool _isPotion = false;

        #endregion

        public QuestGame()
        {
            InitializeComponent();
            LoadDB();
        }

        private void QuestGame_Load(object sender, EventArgs e)
        {
            _game = new Game(new Rectangle(80, 60, 400, 140));
            _game.NewLevel(_random);
            UpdateCharacters();
            SetTheLevel();
        }

        #region LoadDB
        private void LoadDB()
        {
            playerInfo.Set_Player(Map_Player, playerHitPointLabel);

            enemyInfos[0].Set(Map_Bat, batHitPointLabel);
            enemyInfos[1].Set(Map_Ghost, ghostHitPointLabel);
            enemyInfos[2].Set(Map_Ghoul, ghoulHitPointLabel);

            weaponInfos[0].Set("Sword", "Weapon", Inventory_Sword);
            weaponInfos[1].Set("Bow", "Weapon", Inventory_Bow);
            weaponInfos[2].Set("Mace", "Weapon", Inventory_Mace);

            potionInfos[0].Set("Red Potion", "Potion", Inventory_RedPotion);
            potionInfos[1].Set("Blue Potion", "Potion", Inventory_BluePotion);

            mapItems[0].Set("Sword", "Weapon", Map_Sword);
            mapItems[1].Set("Bow", "Weapon", Map_Bow);
            mapItems[2].Set("Mace", "Weapon", Map_Mace);
            mapItems[3].Set("Red Potion", "Potion", Map_RedPotion);
            mapItems[4].Set("Blue Potion", "Potion", Map_BluePotion);
        }
        #endregion

        #region Update
        private void UpdateCharacters()
        {
            playerInfo.playerLabelHitPoint.Text = _game.PlayerHitPoints.ToString();
            playerInfo.playerPictureBox.Location = _game.PlayerLocation;

            int enemiesCount = 0;
            enemiesCount = CountEnemies();

            Control weaponControl = null;
            SetMapVisibility();
            weaponControl = SetVisibilityToWeaponInRoom(weaponControl);
            CheckPlayerInventory();
            weaponControl.Location = _game.WeaponInRoom.Location;

            if (_game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
            {
                weaponControl.Visible = true;
                weaponControl.Location = _game.WeaponInRoom.Location;
            }

            if (_game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died", "System...");
                Application.Exit();
            }

            if (enemiesCount < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                _game.NewLevel(_random);
                UpdateCharacters();
            }
        }
        #endregion

        #region Button Event

        #region Move
        private void Move_Up_BTN_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Up, _random);
            UpdateCharacters();
        }

        private void Move_Left_BTN_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Left, _random);
            UpdateCharacters();
        }

        private void Move_Right_BTN_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Right, _random);
            UpdateCharacters();
        }

        private void Move_Down_BTN_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Down, _random);
            UpdateCharacters();
        }
        #endregion

        #region Attack
        private void Attack_Up_BTN_Click(object sender, EventArgs e)
        {
            _game.Attack(Direction.Up, _random);
            UpdateCharacters();
        }

        private void Attack_Left_BTN_Click(object sender, EventArgs e)
        {
            _game.Attack(Direction.Left, _random);
            UpdateCharacters();
        }

        private void Attack_Right_BTN_Click(object sender, EventArgs e)
        {
            _game.Attack(Direction.Right, _random);
            UpdateCharacters();
        }

        private void Attack_Down_BTN_Click(object sender, EventArgs e)
        {
            _game.Attack(Direction.Down, _random);
            UpdateCharacters();
        }
        #endregion

        #region Inventory
        private void Inventory_Sword_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(weaponInfos[0]);
            UpdateCharacters();
        }

        private void Inventory_Bow_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(weaponInfos[1]);
            UpdateCharacters();
        }

        private void Inventory_Mace_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(weaponInfos[2]);
            UpdateCharacters();
        }

        private void Inventory_RedPotion_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(potionInfos[0]);
            UpdateCharacters();
        }

        private void Inventory_BluePotion_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(potionInfos[1]);
            UpdateCharacters();
        }
        #endregion

        #endregion

        #region Inventory

        #region 아이템 확인
        private void CheckPlayerInventory()
        {
            for (int i = 0; i < weaponInfos.Length; i++)
            {
                CheckPlayerWeapon(weaponInfos[i]);
            }
            for (int i = 0; i < potionInfos.Length; i++)
            {
                CheckPlayerPotion(potionInfos[i]);
            }
        }
        #endregion

        #region 무기 확인
        private void CheckPlayerWeapon(ItemInfo weapon)
        {
            weapon.itemPictureBox.BorderStyle = BorderStyle.None;
            if (_game.CheckPlayerInventory(weapon.itemName))
            {
                weapon.itemPictureBox.Visible = true;
                if (_game.IsWeaponEquipped(weapon.itemName))
                {
                    weapon.itemPictureBox.BorderStyle = BorderStyle.FixedSingle;
                    SetupAttackButtons(weapon.itemType);
                }
            }
        }
        #endregion

        #region 포션 확인
        private void CheckPlayerPotion(ItemInfo potion)
        {
            potion.itemPictureBox.BorderStyle = BorderStyle.None;
            if (_game.CheckPlayerInventory(potion.itemName))
            {
                if (!_game.CheckPotionUsed(potion.itemName)) // 포션을 사용하지 않은 경우
                {
                    potion.itemPictureBox.Visible = true;
                    if (_game.IsWeaponEquipped(potion.itemName))
                    {
                        potion.itemPictureBox.BorderStyle = BorderStyle.FixedSingle;
                        SetupAttackButtons(potion.itemType);
                        _isPotion = true;
                    }
                }
                else
                {
                    potion.itemPictureBox.BorderStyle = BorderStyle.None;
                    potion.itemPictureBox.Visible = false;
                    if (_isPotion)
                    {
                        _game.Equip(playerInfo.equipWeaponName);
                        CheckPlayerWeapon(weaponInfos[playerInfo.equipWeaponNumber]);
                        SetupAttackButtons(playerInfo.equipWeaponType);
                        _isPotion = false;
                    }
                }
            }
        }
        #endregion

        #region 아이템 선택
        private void SelectInventoryItem(ItemInfo itemInfo)
        {
            if(_game.CheckPlayerInventory(itemInfo.itemName))
            {
                _game.Equip(itemInfo.itemName);
                RemoveInventoryBorder();
                itemInfo.itemPictureBox.BorderStyle = BorderStyle.FixedSingle;
                SetupAttackButtons(itemInfo.itemType);
                RemoveInventoryBorder();
                ChangePlayerWeapon(itemInfo);
            }
        }
        #endregion

        #region 플레이어의 현재 무기(포션제외)
        private void ChangePlayerWeapon(ItemInfo weapon)
        {
            if ("weapon".Equals(weapon.itemType.ToLower()))
            {
                playerInfo.Set_equipWeapon(weapon);
            }
        }
        #endregion

        #region 인벤토리의 경계 지우기
        private void RemoveInventoryBorder()
        {
            for(int i = 0; i < weaponInfos.Length; i++)
            {
                weaponInfos[i].itemPictureBox.BorderStyle = BorderStyle.None;
            }
            for(int i = 0; i < potionInfos.Length; i++)
            {
                potionInfos[i].itemPictureBox.BorderStyle = BorderStyle.None;
            }
        }
        #endregion

        #region 아이템에 따른 공격버튼 설정
        private void SetupAttackButtons(string weaponType)
        {
            // #. 포션을 클릭했을 시 공격 up버튼을 사용버튼으로 변경하고, 나머지 버튼 비활성화
            if("potion".Equals(weaponType.ToLower()))
            {
                Attack_Up_BTN.Text = "Drink";
                Attack_Left_BTN.Visible = false;
                Attack_Right_BTN.Visible = false;
                Attack_Down_BTN.Visible = false;
            }
            // #. 다시 무기를 선택하면 공격버튼 활성화
            if("weapon".Equals(weaponType.ToLower()))
            {
                Attack_Up_BTN.Text = "Up";
                Attack_Left_BTN.Visible = true;
                Attack_Right_BTN.Visible = true;
                Attack_Down_BTN.Visible = true;
            }
        }
        #endregion

        #endregion

        #region Map

        #region 플레이어가 우선적으로 보이도록 설정
        private void SetTheLevel()
        {
            playerInfo.playerPictureBox.BringToFront();
            for (int i = 0; i < enemyInfos.Length; i++)
            {
                enemyInfos[i].enemyPictureBox.SendToBack();
            }
            for (int i = 0; i < mapItems.Length; i++)
            {
                mapItems[i].itemPictureBox.SendToBack();
            }
        }
        #endregion

        #region 맵 아이템 설정
        private void SetMapVisibility()
        {
            for (int i = 0; i < mapItems.Length; i++)
            {
                mapItems[i].itemPictureBox.Visible = false;
            }
        }
        private Control SetVisibilityToWeaponInRoom(Control weaponControl)
        {
            for (int i = 0; i < mapItems.Length; i++)
            {
                if (_game.WeaponInRoom.Name.Equals(mapItems[i].itemName))
                {
                    weaponControl = mapItems[i].itemPictureBox;
                    break;
                }
            }
            return weaponControl;
        }
        #endregion

        #endregion

        #region Enemy

        private bool UpdateEnemy(Enemy enemy, EnemyInfo enemyInfo)
        {
            bool isEnemyUpdated = false;
            enemyInfo.enemyLabelHitPoint.Text = enemy.HitPoints.ToString();
            enemyInfo.enemyLabelHitPoint.Visible = true;

            if (enemy.HitPoints > 0)
            {
                enemyInfo.enemyPictureBox.Location = enemy.Location;
                enemyInfo.enemyPictureBox.Visible = true;
                isEnemyUpdated = true;
            }
            else
            {
                enemyInfo.enemyPictureBox.Visible = false;
                enemyInfo.enemyLabelHitPoint.Visible = false;
            }

            return isEnemyUpdated;
        }

        private int CountEnemies()
        {
            int enemyCounts = 0;
            foreach(Enemy enemy in _game.Enemies)
            {
                if(enemy is Bat)
                {
                    if (UpdateEnemy(enemy, enemyInfos[0]))
                        enemyCounts++;
                }
                if (enemy is Ghost)
                {
                    if (UpdateEnemy(enemy, enemyInfos[1]))
                        enemyCounts++;
                }
                if (enemy is Ghoul)
                {
                    if (UpdateEnemy(enemy, enemyInfos[2]))
                        enemyCounts++;
                }
            }
            return enemyCounts;
        }
        #endregion
    }
}
