using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab1
{
    class Dog
    {
        public int StartPosX; // 개 시작 위치
        public int StartPosY; // 트랙에서 개 위치
        public int RaceTrack; // 트랙 길이
        public PictureBox pictureBox;
        public Random random;
        public int distance;

        public bool Run()
        {
            // 1 ~ 4번의 개들의 이미지를 랜덤하게 이동
            // 개가 통과하면 true 리턴
            Point curLocation = pictureBox.Location;
            // 개 위치 + 개 그림 길이 >= 트랙 길이 이면 승리
            if (curLocation.X + pictureBox.Width >= RaceTrack)
                return true;
            else
            {
                curLocation.X += distance;
                pictureBox.Location = curLocation;
                return false;
            }
        }

        public void TakeStartPos()
        {
            // 시작 지점으로 개들을 되돌림
            pictureBox.Location = new Point(StartPosX, StartPosY);
        }
    }
}
