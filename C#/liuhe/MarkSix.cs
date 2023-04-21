using System;



namespace MarkSix
{

    public class Macao
    {
        //类成员

        public int[] aomenLiuHeData2020 = {
            3, 3, 3, 1, 2, 1, 2, 1, 3, 1, 3, 3, 2, 3, 1, 1, 1, 2, 1, 1, 2, 1, 1, 2, 2, 1, 1, 2, 2, 3, 3, // 1月
            3, 3, 2, 2, 3, 2, 2, 2, 2, 3, 3, 3, 3, 2, 3, 2, 1, 2, 2, 2, 3, 2, 2, 2, 1, 3, 3, 2,          // 2月
            2, 1, 1, 3, 1, 2, 2, 3, 3, 3, 2, 2, 3, 2, 1, 3, 3, 2, 1, 2, 1, 1, 2, 2, 2, 3, 3, 3, 1, 1, 2, // 3月
            1, 3, 1, 1, 1, 1, 3, 2, 1, 2, 3, 2, 2, 1, 2, 1, 3, 1, 3, 3, 3, 1, 3, 1, 3, 2, 3, 2, 3, 1,    // 4月
            3, 1, 3, 1, 3, 1, 3, 3, 1, 2, 1, 1, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 2, 1, 1, 1, 1, 2, 2, 3, // 5月
            3, 3, 2, 3, 2, 3, 1, 2, 1, 3, 3, 3, 1, 1, 2, 2, 3, 1, 1, 1, 3, 1, 3, 3, 2, 3, 1, 2, 3, 2,    // 6月
            3, 2, 3, 1, 3, 1, 1, 2, 1, 1, 3, 2, 3, 2, 3, 2, 1, 3, 2, 3, 2, 1, 1, 3, 2, 3, 2, 1, 3, 1, 2, // 7月
            2, 2, 3, 3, 2, 2, 3, 2, 2, 3, 1, 3, 1, 2, 3, 3, 3, 3, 3, 3, 3, 2, 1, 1, 3, 2, 1, 3, 2, 2, 1, // 8月
            2, 2, 1, 3, 1, 1, 3, 2, 3, 1, 2, 1, 1, 3, 2, 2, 2, 1, 2, 3, 1, 1, 2, 1, 2, 2, 1, 2, 1, 2,    // 9月
            2, 2, 1, 1, 1, 2, 3, 1, 1, 3, 3, 3, 3, 1, 3, 2, 2, 1, 3, 1, 3, 2, 3, 2, 1, 3, 3, 3, 3, 3, 1, // 10月
            1, 2, 1, 2, 1, 3, 3, 2, 1, 3, 2, 3, 1, 3, 1, 2, 2, 2, 1, 2, 3, 2, 2, 1, 1, 2, 2, 3, 2, 3,    // 11月
            3, 1, 1, 1, 2, 3, 2, 1, 2, 1, 2, 2, 3, 1, 2, 3, 1, 3, 1, 3, 2, 2, 1, 2, 2, 2, 3, 1, 3, 2, 2  // 12月
                                                                                                        
        };


        public int[] aomenLiuHeData2021 = {
            3, 3, 3, 1, 2, 1, 2, 1, 3, 1, 3, 3, 2, 3, 1, 1, 1, 2, 1, 1, 2, 1, 1, 2, 2, 1, 1, 2, 2, 3, 3, // 1月
            3, 3, 2, 2, 3, 2, 2, 2, 2, 3, 3, 3, 3, 2, 3, 2, 1, 2, 2, 2, 3, 2, 2, 2, 1, 3, 3, 2,          // 2月
            2, 1, 1, 3, 1, 2, 2, 3, 3, 3, 2, 2, 3, 2, 1, 3, 3, 2, 1, 2, 1, 1, 2, 2, 2, 3, 3, 3, 1, 1, 2, // 3月
            1, 3, 1, 1, 1, 1, 3, 2, 1, 2, 3, 2, 2, 1, 2, 1, 3, 1, 3, 3, 3, 1, 3, 1, 3, 2, 3, 2, 3, 1,    // 4月
            3, 1, 3, 1, 3, 1, 3, 3, 1, 2, 1, 1, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 2, 1, 1, 1, 1, 2, 2, 3, // 5月
            3, 3, 2, 3, 2, 3, 1, 2, 1, 3, 3, 3, 1, 1, 2, 2, 3, 1, 1, 1, 3, 1, 3, 3, 2, 3, 1, 2, 3, 2,    // 6月
            3, 2, 3, 1, 3, 1, 1, 2, 1, 1, 3, 2, 3, 2, 3, 2, 1, 3, 2, 3, 2, 1, 1, 3, 2, 3, 2, 1, 3, 1, 2, // 7月
            2, 2, 3, 3, 2, 2, 3, 2, 2, 3, 1, 3, 1, 2, 3, 3, 3, 3, 3, 3, 3, 2, 1, 1, 3, 2, 1, 3, 2, 2, 1, // 8月
            2, 2, 1, 3, 1, 1, 3, 2, 3, 1, 2, 1, 1, 3, 2, 2, 2, 1, 2, 3, 1, 1, 2, 1, 2, 2, 1, 2, 1, 2,    // 9月
            2, 2, 1, 1, 1, 2, 3, 1, 1, 3, 3, 3, 3, 1, 3, 2, 2, 1, 3, 1, 3, 2, 3, 2, 1, 3, 3, 3, 3, 3, 1, // 10月
            1, 2, 1, 2, 1, 3, 3, 2, 1, 3, 2, 3, 1, 3, 1, 2, 2, 2, 1, 2, 3, 2, 2, 1, 1, 2, 2, 3, 2, 3,    // 11月
            3, 1, 1, 1, 2, 3, 2, 1, 2, 1, 2, 2, 3, 1, 2, 3, 1, 3, 1, 3, 2, 2, 1, 2, 2, 2, 3, 1, 3, 2, 2  // 12月
                                                                                                        
        };
        public int[] aomenLiuHeData2022 = {

            2, 2, 3, 3, 3, 2, 2, 2, 1, 3, 2, 2, 2, 2, 3, 2, 1, 2, 3, 1, 3, 3, 1, 1, 2, 3, 1, 1, 2, 1, 3, // 1月
            2, 3, 1, 2, 3, 2, 2, 3, 2, 1, 1, 2, 2, 2, 2, 1, 2, 3, 3, 1, 3, 2, 1, 1, 2, 1, 2, 2,          // 2月
            1, 1, 1, 1, 1, 1, 2, 1, 1, 2, 2, 1, 3, 1, 1, 2, 1, 3, 1, 2, 2, 3, 1, 3, 2, 1, 1, 1, 2, 2, 2, // 3月
            2, 1, 3, 1, 1, 3, 1, 2, 1, 3, 2, 1, 2, 3, 2, 1, 3, 1, 2, 2, 3, 2, 3, 2, 2, 1, 2, 1, 2, 2,    // 4月
            3, 2, 2, 1, 3, 1, 3, 1, 3, 3, 1, 1, 2, 1, 3, 2, 3, 2, 2, 1, 2, 2, 1, 2, 2, 2, 3, 3, 3, 3, 2, // 5月
            3, 2, 1, 1, 1, 2, 1, 3, 3, 1, 2, 1, 2, 1, 3, 3, 1, 1, 2, 2, 1, 1, 3, 3, 3, 3, 3, 1, 2, 2,    // 6月
            3, 3, 1, 3, 3, 2, 1, 1, 3, 3, 1, 3, 1, 3, 1, 1, 1, 1, 2, 1, 2, 1, 2, 2, 1, 1, 1, 3, 1, 2, 2, // 7月
            3, 3, 3, 3, 3, 1, 3, 3, 3, 1, 3, 1, 3, 3, 2, 1, 2, 3, 3, 2, 3, 3, 3, 3, 2, 3, 2, 2, 2, 2, 2, // 8月
            3, 1, 1, 3, 3, 1, 2, 2, 3, 2, 2, 3, 1, 1, 1, 2, 1, 1, 3, 1, 2, 2, 1, 3, 3, 2, 3, 1, 1, 3,    // 9月
            3, 1, 1, 3, 3, 3, 1, 2, 2, 1, 1, 3, 3, 2, 3, 1, 1, 1, 3, 2, 2, 3, 3, 2, 2, 3, 3, 3, 2, 1, 1, // 10月
            3, 2, 1, 3, 2, 1, 3, 1, 3, 3, 3, 2, 2, 2, 3, 2, 2, 2, 2, 1, 1, 2, 2, 1, 3, 2, 1, 3, 1, 1,    // 11月
            3, 1, 2, 3, 1, 2, 1, 3, 3, 2, 3, 3, 3, 1, 3, 2, 3, 3, 1, 3, 1, 1, 1, 3, 3, 1, 3, 1, 2, 2, 2  // 12月

        };
        int length;   //引入的数据长度
        public int odds;    //赔率
        private int referenceColor;     //参考的波色，也就是前一期的波色
        public int bettingFailedMax = 0;   //最长的不中奖期数
        public int WinningNum;          //中奖次数
        public float cashPoolingMix = 0;  //资金池中最少金额

        public int[] rulesOfBetting = {
            5,  10,  15, 20, 30,  50,   //
            80, 100, 50, 80, 100,     //
            0,0,0,0,0,//
            0,0,0,0,0,//
            0,0,0,0,0,//
            0,0,0,0,0//

        };

        public int[] rulesOfBettingTwoLine = {
            30,  50,  80, 100, 120,  150,   //
            0, 0, 0, 0, 0,     //
            0,0,0,0,0,//
            0,0,0,0,0,//
            0,0,0,0,0,//
            0,0,0,0,0//

        };

        public float cashPooling;   //资金池

        public Macao()
        {
            this.WinningNum = 0;
        }

        //连波色
        public float myMethod(int[] liuHeData, int odds, int initalStake)
        {


            int indexBetting;
            int bettingCur;   //当前投注资金

            this.length = liuHeData.Length;

            indexBetting = 0;
            this.cashPoolingMix = this.cashPooling;

            for (int i = 0; i < liuHeData.Length; i++)
            {

                bettingCur = this.rulesOfBetting[indexBetting];

                if (liuHeData[i] == this.referenceColor)
                {

                    //中奖收入进入资金池
                    this.cashPooling += odds * bettingCur;
                    //下一期的投注资金
                    if (this.cashPooling > 15000)
                    { indexBetting = 1; }
                    else { indexBetting = 0; }

                    this.WinningNum++;
                }
                else
                {
                    this.cashPooling -= (bettingCur * 16);
                    if (this.cashPoolingMix > this.cashPooling)
                    {
                        this.cashPoolingMix = this.cashPooling;
                      
                    }
                    if (this.cashPooling < 0)
                    {
                        Console.WriteLine("资金不足\n");
                    }
                    //下一期的投注资金增加
                    indexBetting++;

                }
                if ((this.cashPooling < 5000) &&
                    (indexBetting > 5))
                {
                    indexBetting -= 3;
                }
                //保存当前波色，作为下一期波色的参考
                this.referenceColor = liuHeData[i];
            }


            return this.cashPooling;
        }
        //寻找同一个波色
        public float singleColor(int[] liuHeData, int odds, int initalStake)
        {
            return 0;
        }

        //反转双线
        public float twoLine_ColorInversion(int[] liuHeData, int odds, int initalStake)
        {

            int threadOneColorCur = 0;   //线程1当前投注的波色
            int threadOneBettingCur = 0;   //当前投注资金
            int threadOneindexBetting = 0;


            int threadTwoColorCur = 0;  //线程2当前投注的波色
            int threadTwoBettingCur = 0;
            int threadTwoindexBetting = 0;

            int colorReserve;       //备份波色
            int bettingFailedNum = 0;

            this.length = liuHeData.Length;
            this.cashPoolingMix = this.cashPooling;

            colorReserve = 1;
            threadOneColorCur = 2;
            threadTwoColorCur = 3;
            threadOneBettingCur = 20;
            threadTwoBettingCur = 20;
            this.WinningNum = 0;

            for (int i = 0; i < liuHeData.Length; i++)
            {
                //线程1
                if (liuHeData[i] == threadOneColorCur)
                {
                    //中奖
                    this.WinningNum++;

                    //提取备份波色
                    threadOneColorCur = colorReserve;

                    //当前波色保存到备份波色
                    colorReserve = liuHeData[i];

                    //收入资金进入资金池
                    this.cashPooling += odds * threadOneBettingCur;

                    //准备下一次的投入资金
                    threadOneindexBetting = 0;
                    threadOneBettingCur = this.rulesOfBettingTwoLine[threadOneindexBetting];

                    bettingFailedNum = 0;

                }
                else
                {
                    //资金池减去投注金额
                    this.cashPooling -= threadOneBettingCur * 16;

                    if (this.cashPoolingMix > this.cashPooling)
                    {
                        this.cashPoolingMix = this.cashPooling;
                        Console.WriteLine("第" + i + "期资金池:" + this.cashPooling);
                    }
                    if (this.cashPooling < 0)
                    {
                        Console.WriteLine("资金不足");
                    }

                    //准备下一次的投入资金
                    threadOneindexBetting++;
                    //if (threadOneindexBetting > 8)
                    //{
                    //    threadOneindexBetting -= 3;
                    //}
                    //else
                        threadOneBettingCur = this.rulesOfBettingTwoLine[threadOneindexBetting];

                    bettingFailedNum++;
                    if (bettingFailedNum > this.bettingFailedMax)
                    {
                        this.bettingFailedMax = bettingFailedNum;

                    }


                }
                //===================================================================
                //线程2
                if (liuHeData[i] == threadTwoColorCur)
                {
                    //中奖
                    //中奖
                    this.WinningNum++;
                    //提取备份波色
                    threadTwoColorCur = colorReserve;

                    //当前波色保存到备份波色
                    colorReserve = liuHeData[i];

                    //收入资金进入资金池
                    this.cashPooling += odds * threadTwoBettingCur;

                    //准备下一次的投入资金
                    threadTwoindexBetting = 0;
                    threadTwoBettingCur = this.rulesOfBettingTwoLine[threadTwoindexBetting];

                    bettingFailedNum = 0;

                }
                else
                { //资金池减去投注金额
                    this.cashPooling -= threadTwoBettingCur * 16;
                    if (this.cashPoolingMix > this.cashPooling)
                    {
                        this.cashPoolingMix = this.cashPooling;
                        Console.WriteLine("第" + i + "期资金池:" + this.cashPooling);
                    }

                    //准备下一次的投入资金
                    threadTwoindexBetting++;
                    //if (threadTwoindexBetting > 8)
                    //{
                    //    threadTwoindexBetting -= 3;
                    //}
                    //else
                        threadTwoBettingCur = this.rulesOfBettingTwoLine[threadTwoindexBetting];

                    bettingFailedNum++;
                    if (bettingFailedNum > this.bettingFailedMax)
                    {
                        this.bettingFailedMax = bettingFailedNum;

                    }
                    if (this.cashPooling < 0)
                    {
                        Console.WriteLine("资金不足");
                    }
                }


            }





            return this.cashPooling;
        }


        public float algorithmToColor(int[] liuHeData, int odds, int initalStake)
        {
            return 0;
        }
    }
    public class Hongkong
    {
        //类成员

        public int[] liuhe ={

            1,  //红
            2,  //红
            3,  //蓝
            4,  //蓝
            5,  //绿
            6,  //绿
            7,  //红
            8,  //红
            9,  //蓝
            10, //蓝

            11, //绿
            12, //红
            13, //红
            14, //蓝
            15, //蓝
            16, //绿
            17, //绿
            18, //红
            19, //红
            20, //蓝

            21, //绿色
            22, //绿色
            23, //红
            24, //红
            25, //蓝
            26, //蓝
            27, //绿
            28, //绿
            29, //红
            30, //红

            47, //蓝
            48, //蓝
            49  //绿

        };



        public int[] HongkongLiuHeData2022 = {
            3, 2, 1,    // 1月
            2, 2, 1, 2, // 2月
            1, 2, 1, 2, 3, 1, 1, 3,     // 3月
            1, 3, 1, 2, 3, 2, 3, 3, 1,  // 4月
            3, 1, 2, 3, 2, 1, 1, 1, 3,  // 5月
            1, 3, 1, 3, 3, 2, 3,    // 6月
            1, 3, 2, 1, 1, 3, 1, 2, 3,  // 7月
            3, 1, 1, 2, 3, 3, 3, 1, 2, 1, 1, 3, // 8月
            3, 2, 1, 3, 2, 1, 1, 3, 1, 2, 1, 1,    // 9月
            2, 3, 1, 3, 1, 1, 1, 1, 3, 3, 2, 3, // 10月
            3, 1, 1, 3, 3, 1, 1, 1, 3, 2, 2, 3, 1,  // 11月
            2, 2, 2, 2, 1, 3, 1, 1, 3, 3, 1, 2, 3, // 12月
                                                                                                        
        };
    }
}

