using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public class Dog
    {
        public int StartPosX; // 개 시작 위치
        public int StartPosY; // 트랙에서 개 위치
        public int RaceTrack; // 트랙 길이
        public int Location = 0;
        public PictureBox pictureBox;
        static public Random random;

        public bool Run()
        {
            // 1 ~ 4번의 개들의 이미지를 랜덤하게 이동
            // 개가 통과하면 true 리턴
            int distance = random.Next(1, 5);
            Location += distance;

            Point curLocation = pictureBox.Location;
            curLocation.X += distance;
            pictureBox.Location = curLocation;

            // 개 위치 + 개 그림 길이 >= 트랙 길이 이면 승리
            if (curLocation.X + pictureBox.Width >= RaceTrack)
                return true;
            return false;
        }

        public void TakeStartPos()
        {
            // 시작 지점으로 개들을 되돌림
            pictureBox.Location = new Point(StartPosX, StartPosY);
        }
    }
}
