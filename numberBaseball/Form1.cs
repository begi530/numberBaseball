using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberBaseball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lvlList.HeaderStyle = ColumnHeaderStyle.None;
            this.lvlList.Items.Add(new ListViewItem(new string[] { "Inning", "Hitting", "S", "B", "O" }));
            lvlList.Items[0].Font = new Font("굴림", 14, FontStyle.Bold);
            baseBallNum = 3;
        }

        // 사용자가 입력한 숫자 저장
        string numStr = "";
        // 게임을 진행한 시간 저장
        int gameTime;
        // numStr에 저장된 숫자를 나눠서 저장하는데 사용
        // s, b, o 비교 && listView에 출력할 때 이용
        string[] strArr = new string[4];
        // 사용자의 게임 시도 횟수 저장
        int inning;
        // 난수를 저장할 배열
        int[] numArr = new int[4];
        // s, b
        string strike, ball;
        // o
        string numOut;
        // 숫자야구 자릿수
        int baseBallNum;
        // 간단한 문자열 저장
        string str = "";

        private void btn1_Click(object sender, EventArgs e)
        {
            inputNum(btn1.Text.ToString());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            inputNum(btn2.Text.ToString());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            inputNum(btn3.Text.ToString());
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            inputNum(btn4.Text.ToString());
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            inputNum(btn5.Text.ToString());
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            inputNum(btn6.Text.ToString());
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            inputNum(btn9.Text.ToString());
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            inputNum(btn7.Text.ToString());
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            inputNum(btn8.Text.ToString());
        }

        private void inputNum(string num)
        {
            if (numStr.Length < baseBallNum)
            {
                // numStr에 num(버튼을 숫자)이 있는지 확인
                if (numStr.Contains(num))
                {
                    MessageBox.Show("같은 숫자는 입력할 수 없어요!", "경고!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    // 없으면 문자열에 추가
                    numStr += num;
                    txtNum.Text = numStr;
                }
            }
            // 3글자를 넘기려 하면 경고 메시지 띄워줌
            else
            {
                MessageBox.Show("숫자는 "+baseBallNum+"개만 입력해 주세요!", "경고!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (numStr.Length <= 0)
            {
                MessageBox.Show("숫자를 입력해 주세요!", "경고!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // 가장 마지막 한 글자를 제외한 문자열을 저장함 == 마지막 글자를 지워줌
                numStr = numStr.Substring(0, numStr.Length - 1);
                txtNum.Text = numStr;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (numStr.Length != baseBallNum)
            {
                MessageBox.Show(baseBallNum + "개의 숫자를 모두 입력해 주세요!", "경고!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                hitBall();
            }
        }

        private void hitBall()
        {
            strike = "0";
            ball = "0";
            numOut = "";

            // 버튼을 통해 입력한 숫자를 비교하기 위해서 하나씩 배열에 저장함
            strArr[0] = numStr.Substring(0, 1);
            strArr[1] = numStr.Substring(1, 1);
            strArr[2] = numStr.Substring(2, 1);
            if(baseBallNum != 3) strArr[3] = numStr.Substring(3, 1);

            switch (inning)
            {
                // innig이 1 ~ 10일 때 스트라이크, 볼, 아웃 여부를 판단
                // numArr에 들어간 값과 입력된 값의 값을 비교해 카운트함
                case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9: case 10:

                    if (numArr[0] == Convert.ToInt32(strArr[0])) strike = (Convert.ToInt32(strike) + 1).ToString();
                    if (numArr[0] == Convert.ToInt32(strArr[1])) ball = (Convert.ToInt32(ball) + 1).ToString();
                    if (numArr[0] == Convert.ToInt32(strArr[2])) ball = (Convert.ToInt32(ball) + 1).ToString();

                    if (numArr[1] == Convert.ToInt32(strArr[1])) strike = (Convert.ToInt32(strike) + 1).ToString();
                    if (numArr[1] == Convert.ToInt32(strArr[0])) ball = (Convert.ToInt32(ball) + 1).ToString();
                    if (numArr[1] == Convert.ToInt32(strArr[2])) ball = (Convert.ToInt32(ball) + 1).ToString();

                    if (numArr[2] == Convert.ToInt32(strArr[2])) strike = (Convert.ToInt32(strike) + 1).ToString();
                    if (numArr[2] == Convert.ToInt32(strArr[0])) ball = (Convert.ToInt32(ball) + 1).ToString();
                    if (numArr[2] == Convert.ToInt32(strArr[1])) ball = (Convert.ToInt32(ball) + 1).ToString();

                    if (baseBallNum == 4)
                    {
                        if (numArr[0] == Convert.ToInt32(strArr[3])) ball = (Convert.ToInt32(ball) + 1).ToString();
                        if (numArr[1] == Convert.ToInt32(strArr[3])) ball = (Convert.ToInt32(ball) + 1).ToString();
                        if (numArr[2] == Convert.ToInt32(strArr[3])) ball = (Convert.ToInt32(ball) + 1).ToString();

                        if (numArr[3] == Convert.ToInt32(strArr[3])) strike = (Convert.ToInt32(strike) + 1).ToString();
                        if (numArr[3] == Convert.ToInt32(strArr[0])) ball = (Convert.ToInt32(ball) + 1).ToString();
                        if (numArr[3] == Convert.ToInt32(strArr[1])) ball = (Convert.ToInt32(ball) + 1).ToString();
                        if (numArr[3] == Convert.ToInt32(strArr[2])) ball = (Convert.ToInt32(ball) + 1).ToString();
                    }

                    // 스트라이크와 볼이 하나도 카운트 되지 않았다면(값이 0이라면) 아웃 표시를 해줌
                    if (strike.Equals("0") && ball.Equals("0"))
                    {
                        strike = "";
                        ball = "";
                        numOut = "🔴";
                    }
                    break;
            }
            
            str = string.Format("{0} - {1} - {2}", strArr[0], strArr[1], strArr[2]);
            if (baseBallNum == 4) str += string.Format(" - {0}", strArr[3]);

            // listView에 Item(몇 이닝인지, 입력했던 숫자가 무엇인지, 스트라이크와 볼이 몇 갠지, 아웃 여부)을 추가해줌
            this.lvlList.Items.Add(new ListViewItem(new string[] { inning.ToString(), str, strike, ball, numOut }));


            // 비교가 끝난 값들을 지워줌
            txtNum.Text = "";
            numStr = "";
            str = "";

            // 만약 스트라이크의 카운트 된 숫자가 3이라면 버튼 비활성화와 함께 타이머를 종료하고 정답 메시지를 띄워줌
            if (strike.Equals(baseBallNum.ToString()))
            {
                this.game.Enabled = false;
                txtNum.Text = gameTime + "초";

                groupBox1.Visible = false;
                MessageBox.Show("정답을 맞췄어요!\n" + "총 " + gameTime + "초 걸렸네요!", "HOMERUN!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

            // 이닝을 늘려줌
            inning += 1;

            // 만약 11이닝이고 3S가 아니라면 게임 오버 표시를 함
            // == 11이닝이 되었어도 3S면 10이닝 때 홈런을 쳤단 소리니까 게임 오버를 띄우지 않기 위함
            if (!(strike.Equals(baseBallNum.ToString())) && inning == 11)
            {
                str = "";
                game.Enabled = false;
                
                txtNum.Text = string.Format("{0}{1}{2}", numArr[0], numArr[1], numArr[2]);
                str = string.Format("{0} - {1} - {2}", numArr[0], numArr[1], numArr[2]);

                if (baseBallNum == 4)
                {
                    txtNum.Text += string.Format("{0}", numArr[3]);
                    str += string.Format(" - {0}", numArr[3]);
                }
                groupBox1.Visible = false;
                MessageBox.Show("홈런을 치지 못 했어요....\n정답은 " + str + "이었어요...!",
                "Game Over...", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }


        // 게임 시작
        private void baseballGame_start()
        {
            lvlList.Visible = true;
            groupBox1.Visible = true;
            txtNum.Visible = true;
            msSt.Visible = false;
            msRe.Visible = true;

            inning = 1;
            this.game.Enabled = true;
            randNumCreate();
            gameTime = 0;

            this.lvlList.Items.Clear();
            txtNum.Text = "";
            numStr = "";
            str = "";

            this.lvlList.Items.Add(new ListViewItem(new string[] { "Inning", "Hitting", "S", "B", "O" }));
            lvlList.Items[0].Font = new Font("굴림", 14, FontStyle.Bold);
        }


        // 게임에 사용될 난수 생성
        private void randNumCreate()
        {
            Random rand = new Random();

            int i, cnt = 0;
            while (cnt < baseBallNum)
            {
                // 1 ~ 9 사이의 난수 생성
                int r = rand.Next(1, 10);

                // 중복 검색: 이미 생성된 개수(numArr에 숫자가 저장된) 만큼만 반복
                for (i = 0; i < cnt; i++)
                {
                    // numArr[i] 번 째에 들어있는 숫자와 r의 값이 같으면 numArr에 r을 저장하지 않고 break
                    if (numArr[i] == r)
                        break;
                }
                // break 없이 cnt가 i의 값만큼 반복되었다면 중복이 없다는 의미
                // numArr에 r(새로 생성된 난수)을 저장해줌
                if (cnt == i)
                {
                    numArr[cnt] = r;
                    cnt += 1;
                }
            }


        }

        private void msSt_Click(object sender, EventArgs e)
        {
            baseballGame_start();
        }

        private void msRe_Click(object sender, EventArgs e)
        {
            baseballGame_start();
        }

        private void msSet3_Click(object sender, EventArgs e)
        {
            baseBallNum = 3;
            baseballGame_start();
        }

        private void msSet4_Click(object sender, EventArgs e)
        {
            baseBallNum = 4;
            baseballGame_start();
        }

        private void msHe_Click(object sender, EventArgs e)
        {
            explanation ex = new explanation();
            ex.ShowDialog();
        }

        private void game_Tick(object sender, EventArgs e)
        {
            gameTime++;
        }

    }
}
