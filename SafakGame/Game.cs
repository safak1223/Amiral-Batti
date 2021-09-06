using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafakGame
{
    public partial class Game : Form
    {
        int[] dizi;

        public Game()
        {
            InitializeComponent();
            dizi = new int[100];
        }

        private void Game_Load(object sender, EventArgs e)
        {


            for (int i = 0; i <= 99; i++)
            {
                dizi[i] = 0;
            }


            A1p.Text = dizi[0].ToString();
            A2p.Text = dizi[10].ToString();
            A3p.Text = dizi[20].ToString();
            A4p.Text = dizi[30].ToString();
            A5p.Text = dizi[40].ToString();
            A6p.Text = dizi[50].ToString();
            A7p.Text = dizi[60].ToString();
            A8p.Text = dizi[70].ToString();
            A9p.Text = dizi[80].ToString();
            A10p.Text = dizi[90].ToString();

            B1p.Text = dizi[1].ToString();
            B2p.Text = dizi[11].ToString();
            B3p.Text = dizi[21].ToString();
            B4p.Text = dizi[31].ToString();
            B5p.Text = dizi[41].ToString();
            B6p.Text = dizi[51].ToString();
            B7p.Text = dizi[61].ToString();
            B8p.Text = dizi[71].ToString();
            B9p.Text = dizi[81].ToString();
            B10p.Text = dizi[91].ToString();

            C1p.Text = dizi[2].ToString();
            C2p.Text = dizi[12].ToString();
            C3p.Text = dizi[22].ToString();
            C4p.Text = dizi[32].ToString();
            C5p.Text = dizi[42].ToString();
            C6p.Text = dizi[52].ToString();
            C7p.Text = dizi[62].ToString();
            C8p.Text = dizi[72].ToString();
            C9p.Text = dizi[82].ToString();
            C10p.Text = dizi[92].ToString();

            D1p.Text = dizi[3].ToString();
            D2p.Text = dizi[13].ToString();
            D3p.Text = dizi[23].ToString();
            D4p.Text = dizi[33].ToString();
            D5p.Text = dizi[43].ToString();
            D6p.Text = dizi[53].ToString();
            D7p.Text = dizi[63].ToString();
            D8p.Text = dizi[73].ToString();
            D9p.Text = dizi[83].ToString();
            D10p.Text = dizi[93].ToString();

            E1p.Text = dizi[4].ToString();
            E2p.Text = dizi[14].ToString();
            E3p.Text = dizi[24].ToString();
            E4p.Text = dizi[34].ToString();
            E5p.Text = dizi[44].ToString();
            E6p.Text = dizi[54].ToString();
            E7p.Text = dizi[64].ToString();
            E8p.Text = dizi[74].ToString();
            E9p.Text = dizi[84].ToString();
            E10p.Text = dizi[94].ToString();

            F1p.Text = dizi[5].ToString();
            F2p.Text = dizi[15].ToString();
            F3p.Text = dizi[25].ToString();
            F4p.Text = dizi[35].ToString();
            F5p.Text = dizi[45].ToString();
            F6p.Text = dizi[55].ToString();
            F7p.Text = dizi[65].ToString();
            F8p.Text = dizi[75].ToString();
            F9p.Text = dizi[85].ToString();
            F10p.Text = dizi[95].ToString();

            G1p.Text = dizi[6].ToString();
            G2p.Text = dizi[16].ToString();
            G3p.Text = dizi[26].ToString();
            G4p.Text = dizi[36].ToString();
            G5p.Text = dizi[46].ToString();
            G6p.Text = dizi[56].ToString();
            G7p.Text = dizi[66].ToString();
            G8p.Text = dizi[76].ToString();
            G9p.Text = dizi[86].ToString();
            G10p.Text = dizi[96].ToString();

            H1p.Text = dizi[7].ToString();
            H2p.Text = dizi[17].ToString();
            H3p.Text = dizi[27].ToString();
            H4p.Text = dizi[37].ToString();
            H5p.Text = dizi[47].ToString();
            H6p.Text = dizi[57].ToString();
            H7p.Text = dizi[67].ToString();
            H8p.Text = dizi[77].ToString();
            H9p.Text = dizi[87].ToString();
            H10p.Text = dizi[97].ToString();

            I1p.Text = dizi[8].ToString();
            I2p.Text = dizi[18].ToString();
            I3p.Text = dizi[28].ToString();
            I4p.Text = dizi[38].ToString();
            I5p.Text = dizi[48].ToString();
            I6p.Text = dizi[58].ToString();
            I7p.Text = dizi[68].ToString();
            I8p.Text = dizi[78].ToString();
            I9p.Text = dizi[88].ToString();
            I10p.Text = dizi[98].ToString();




            J1p.Text = dizi[9].ToString();
            J2p.Text = dizi[19].ToString();
            J3p.Text = dizi[29].ToString();
            J4p.Text = dizi[39].ToString();
            J5p.Text = dizi[49].ToString();
            J6p.Text = dizi[59].ToString();
            J7p.Text = dizi[69].ToString();
            J8p.Text = dizi[79].ToString();
            J9p.Text = dizi[89].ToString();
            J10p.Text = dizi[99].ToString();







        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {

        }

        private void C7_Click(object sender, EventArgs e)
        {

        }

        private void A1_Click(object sender, EventArgs e)
        {
            Button btn = this.A1;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full-1] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }



        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void G9_Click(object sender, EventArgs e)
        {

        }

        private void A2_Click(object sender, EventArgs e)
        {

        }

        private void Attack_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (Kordinat.Text == "A1")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[0] = 1;
                        dizi[1] = 1;
                        dizi[2] = 1;
                        dizi[3] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[0] = 1;
                        dizi[10] = 1;
                        dizi[20] = 1;
                        dizi[30] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[0] = 1;
                        dizi[1] = 1;
                        dizi[2] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[0] = 1;
                        dizi[10] = 1;
                        dizi[20] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[0] = 1;
                        dizi[1] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[0] = 1;
                        dizi[10] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[0] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[0] = 1;


                            label5.Text = "Basarılı";
                        }





                    }



                }
            }
            if (Kordinat.Text == "A2")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[10] = 1;
                        dizi[11] = 1;
                        dizi[12] = 1;
                        dizi[13] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[40] = 1;
                        dizi[10] = 1;
                        dizi[20] = 1;
                        dizi[30] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[10] = 1;
                        dizi[11] = 1;
                        dizi[12] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[30] = 1;
                        dizi[10] = 1;
                        dizi[20] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[10] = 1;
                        dizi[11] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[20] = 1;
                        dizi[10] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[10] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[10] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "A3")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[20] = 1;
                        dizi[21] = 1;
                        dizi[22] = 1;
                        dizi[23] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[40] = 1;
                        dizi[50] = 1;
                        dizi[20] = 1;
                        dizi[30] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[20] = 1;
                        dizi[21] = 1;
                        dizi[22] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[20] = 1;
                        dizi[30] = 1;
                        dizi[40] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[20] = 1;
                        dizi[21] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[20] = 1;
                        dizi[30] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[20] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[20] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "A4")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[30] = 1;
                        dizi[31] = 1;
                        dizi[32] = 1;
                        dizi[33] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[60] = 1;
                        dizi[50] = 1;
                        dizi[40] = 1;
                        dizi[30] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[30] = 1;
                        dizi[31] = 1;
                        dizi[32] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[30] = 1;
                        dizi[40] = 1;
                        dizi[50] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[30] = 1;
                        dizi[31] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[30] = 1;
                        dizi[40] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[30] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[30] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "A5")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[40] = 1;
                        dizi[41] = 1;
                        dizi[42] = 1;
                        dizi[43] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[70] = 1;
                        dizi[60] = 1;
                        dizi[50] = 1;
                        dizi[40] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[40] = 1;
                        dizi[41] = 1;
                        dizi[42] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[40] = 1;
                        dizi[50] = 1;
                        dizi[60] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[40] = 1;
                        dizi[41] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[40] = 1;
                        dizi[50] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[40] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[40] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "A6")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[50] = 1;
                        dizi[51] = 1;
                        dizi[52] = 1;
                        dizi[53] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[60] = 1;
                        dizi[50] = 1;
                        dizi[70] = 1;
                        dizi[80] = 1;

                        label5.Text = "Basarılı";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[50] = 1;
                        dizi[51] = 1;
                        dizi[52] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[50] = 1;
                        dizi[60] = 1;
                        dizi[70] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[50] = 1;
                        dizi[51] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[50] = 1;
                        dizi[60] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[50] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[50] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "A7")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[60] = 1;
                        dizi[61] = 1;
                        dizi[62] = 1;
                        dizi[63] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[60] = 1;
                        dizi[70] = 1;
                        dizi[90] = 1;
                        dizi[80] = 1;

                        label5.Text = "Basarılı";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[60] = 1;
                        dizi[61] = 1;
                        dizi[62] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[60] = 1;
                        dizi[70] = 1;
                        dizi[80] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[60] = 1;
                        dizi[61] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[60] = 1;
                        dizi[70] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[60] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[60] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "A8")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[70] = 1;
                        dizi[71] = 1;
                        dizi[72] = 1;
                        dizi[73] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi A8 den dikey şekilde koyulamaz.";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[70] = 1;
                        dizi[71] = 1;
                        dizi[72] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[70] = 1;
                        dizi[80] = 1;
                        dizi[90] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[70] = 1;
                        dizi[71] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[70] = 1;
                        dizi[80] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[70] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[70] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "A9")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[80] = 1;
                        dizi[81] = 1;
                        dizi[82] = 1;
                        dizi[83] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi A9 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[80] = 1;
                        dizi[81] = 1;
                        dizi[82] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör GemisiA9 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[80] = 1;
                        dizi[81] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[80] = 1;
                        dizi[90] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[80] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[80] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "A10")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[90] = 1;
                        dizi[91] = 1;
                        dizi[92] = 1;
                        dizi[93] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi A10 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[90] = 1;
                        dizi[91] = 1;
                        dizi[92] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi A10 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[90] = 1;
                        dizi[91] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        label5.Text = "Basarılı değil MiHRAP Gemisi A10 dan dikey şekilde koyulamaz. ";

                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[90] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[90] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }

            if (Kordinat.Text == "B1")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[4] = 1;
                        dizi[1] = 1;
                        dizi[2] = 1;
                        dizi[3] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[1] = 1;
                        dizi[11] = 1;
                        dizi[21] = 1;
                        dizi[31] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[1] = 1;
                        dizi[2] = 1;
                        dizi[3] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[1] = 1;
                        dizi[11] = 1;
                        dizi[21] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[1] = 1;
                        dizi[2] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[1] = 1;
                        dizi[11] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[1] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[1] = 1;


                            label5.Text = "Basarılı";
                        }





                    }


                }
            }
            if (Kordinat.Text == "B2")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[14] = 1;
                        dizi[11] = 1;
                        dizi[12] = 1;
                        dizi[13] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[41] = 1;
                        dizi[11] = 1;
                        dizi[21] = 1;
                        dizi[31] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[13] = 1;
                        dizi[11] = 1;
                        dizi[12] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[31] = 1;
                        dizi[11] = 1;
                        dizi[21] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[12] = 1;
                        dizi[11] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[21] = 1;
                        dizi[11] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[11] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[11] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "B3")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[24] = 1;
                        dizi[21] = 1;
                        dizi[22] = 1;
                        dizi[23] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[41] = 1;
                        dizi[51] = 1;
                        dizi[21] = 1;
                        dizi[31] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[23] = 1;
                        dizi[21] = 1;
                        dizi[22] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[21] = 1;
                        dizi[31] = 1;
                        dizi[41] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[22] = 1;
                        dizi[21] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[21] = 1;
                        dizi[31] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[21] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[21] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "B4")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[34] = 1;
                        dizi[31] = 1;
                        dizi[32] = 1;
                        dizi[33] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[61] = 1;
                        dizi[51] = 1;
                        dizi[41] = 1;
                        dizi[31] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[33] = 1;
                        dizi[31] = 1;
                        dizi[32] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[31] = 1;
                        dizi[41] = 1;
                        dizi[51] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[32] = 1;
                        dizi[31] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[31] = 1;
                        dizi[41] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[31] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[31] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "B5")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[44] = 1;
                        dizi[41] = 1;
                        dizi[42] = 1;
                        dizi[43] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[71] = 1;
                        dizi[61] = 1;
                        dizi[51] = 1;
                        dizi[41] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[43] = 1;
                        dizi[41] = 1;
                        dizi[42] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[41] = 1;
                        dizi[51] = 1;
                        dizi[61] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[42] = 1;
                        dizi[41] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[41] = 1;
                        dizi[51] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[41] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[41] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "B6")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[44] = 1;
                        dizi[41] = 1;
                        dizi[42] = 1;
                        dizi[43] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[71] = 1;
                        dizi[61] = 1;
                        dizi[51] = 1;
                        dizi[41] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[43] = 1;
                        dizi[41] = 1;
                        dizi[42] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[41] = 1;
                        dizi[51] = 1;
                        dizi[61] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[42] = 1;
                        dizi[41] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[41] = 1;
                        dizi[51] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[41] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[41] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "B7")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[64] = 1;
                        dizi[61] = 1;
                        dizi[62] = 1;
                        dizi[63] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[61] = 1;
                        dizi[71] = 1;
                        dizi[91] = 1;
                        dizi[81] = 1;

                        label5.Text = "Basarılı";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[63] = 1;
                        dizi[61] = 1;
                        dizi[62] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[61] = 1;
                        dizi[71] = 1;
                        dizi[81] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[62] = 1;
                        dizi[61] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[61] = 1;
                        dizi[71] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[61] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[61] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "B8")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[74] = 1;
                        dizi[71] = 1;
                        dizi[72] = 1;
                        dizi[73] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi B8 den dikey şekilde koyulamaz.";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[73] = 1;
                        dizi[71] = 1;
                        dizi[72] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[71] = 1;
                        dizi[81] = 1;
                        dizi[91] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[72] = 1;
                        dizi[71] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[71] = 1;
                        dizi[81] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[71] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[71] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "B9")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[84] = 1;
                        dizi[81] = 1;
                        dizi[82] = 1;
                        dizi[83] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi B9 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[83] = 1;
                        dizi[81] = 1;
                        dizi[82] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi B9 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[82] = 1;
                        dizi[81] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[81] = 1;
                        dizi[91] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[81] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[81] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "B10")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[94] = 1;
                        dizi[91] = 1;
                        dizi[92] = 1;
                        dizi[93] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi B10 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[93] = 1;
                        dizi[91] = 1;
                        dizi[92] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi B10 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[92] = 1;
                        dizi[91] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        label5.Text = "Basarılı değil MiHRAP Gemisi B10 dan dikey şekilde koyulamaz. ";

                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[91] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[91] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }

            if (Kordinat.Text == "C1")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[4] = 1;
                        dizi[5] = 1;
                        dizi[2] = 1;
                        dizi[3] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[2] = 1;
                        dizi[12] = 1;
                        dizi[22] = 1;
                        dizi[32] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[2] = 1;
                        dizi[3] = 1;
                        dizi[4] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[2] = 1;
                        dizi[12] = 1;
                        dizi[22] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[2] = 1;
                        dizi[3] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[2] = 1;
                        dizi[12] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[2] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[2] = 1;


                            label5.Text = "Basarılı";
                        }





                    }



                }
            }
            if (Kordinat.Text == "C2")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[14] = 1;
                        dizi[15] = 1;
                        dizi[12] = 1;
                        dizi[13] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[42] = 1;
                        dizi[12] = 1;
                        dizi[22] = 1;
                        dizi[32] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[13] = 1;
                        dizi[14] = 1;
                        dizi[12] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[32] = 1;
                        dizi[12] = 1;
                        dizi[22] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[12] = 1;
                        dizi[13] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[22] = 1;
                        dizi[12] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[12] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[12] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "C3")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[24] = 1;
                        dizi[25] = 1;
                        dizi[22] = 1;
                        dizi[23] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[42] = 1;
                        dizi[52] = 1;
                        dizi[22] = 1;
                        dizi[32] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[23] = 1;
                        dizi[24] = 1;
                        dizi[22] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[22] = 1;
                        dizi[32] = 1;
                        dizi[42] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[22] = 1;
                        dizi[23] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[22] = 1;
                        dizi[32] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[22] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[22] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "C4")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[32] = 1;
                        dizi[33] = 1;
                        dizi[34] = 1;
                        dizi[35] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[62] = 1;
                        dizi[52] = 1;
                        dizi[42] = 1;
                        dizi[32] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[32] = 1;
                        dizi[34] = 1;
                        dizi[33] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[32] = 1;
                        dizi[42] = 1;
                        dizi[52] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[32] = 1;
                        dizi[33] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[32] = 1;
                        dizi[42] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[32] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[32] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "C5")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[44] = 1;
                        dizi[45] = 1;
                        dizi[42] = 1;
                        dizi[43] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[72] = 1;
                        dizi[62] = 1;
                        dizi[52] = 1;
                        dizi[42] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[43] = 1;
                        dizi[44] = 1;
                        dizi[42] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[42] = 1;
                        dizi[52] = 1;
                        dizi[62] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[42] = 1;
                        dizi[43] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[42] = 1;
                        dizi[52] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[42] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[42] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "C6")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[44] = 1;
                        dizi[45] = 1;
                        dizi[42] = 1;
                        dizi[43] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[72] = 1;
                        dizi[62] = 1;
                        dizi[52] = 1;
                        dizi[42] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[43] = 1;
                        dizi[44] = 1;
                        dizi[42] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[42] = 1;
                        dizi[52] = 1;
                        dizi[62] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[42] = 1;
                        dizi[43] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[42] = 1;
                        dizi[52] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[42] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[42] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "C7")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[64] = 1;
                        dizi[65] = 1;
                        dizi[62] = 1;
                        dizi[63] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[62] = 1;
                        dizi[72] = 1;
                        dizi[92] = 1;
                        dizi[82] = 1;

                        label5.Text = "Basarılı";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[63] = 1;
                        dizi[64] = 1;
                        dizi[62] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[62] = 1;
                        dizi[72] = 1;
                        dizi[82] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[62] = 1;
                        dizi[63] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[62] = 1;
                        dizi[72] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[62] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[62] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "C8")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[74] = 1;
                        dizi[75] = 1;
                        dizi[72] = 1;
                        dizi[73] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi C8 den dikey şekilde koyulamaz.";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[73] = 1;
                        dizi[74] = 1;
                        dizi[72] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[72] = 1;
                        dizi[82] = 1;
                        dizi[92] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[72] = 1;
                        dizi[73] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[72] = 1;
                        dizi[82] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[72] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[72] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "C9")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[84] = 1;
                        dizi[85] = 1;
                        dizi[82] = 1;
                        dizi[83] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi C9 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[83] = 1;
                        dizi[84] = 1;
                        dizi[82] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi C9 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[83] = 1;
                        dizi[82] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[82] = 1;
                        dizi[92] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[82] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[82] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "C10")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[94] = 1;
                        dizi[95] = 1;
                        dizi[92] = 1;
                        dizi[93] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi C10 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[93] = 1;
                        dizi[94] = 1;
                        dizi[92] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi C10 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[92] = 1;
                        dizi[93] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        label5.Text = "Basarılı değil MiHRAP Gemisi C10 dan dikey şekilde koyulamaz. ";

                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[92] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[92] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }

            if (Kordinat.Text == "D1")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[4] = 1;
                        dizi[5] = 1;
                        dizi[6] = 1;
                        dizi[3] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[3] = 1;
                        dizi[13] = 1;
                        dizi[23] = 1;
                        dizi[33] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[5] = 1;
                        dizi[3] = 1;
                        dizi[4] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[3] = 1;
                        dizi[13] = 1;
                        dizi[23] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[4] = 1;
                        dizi[3] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[3] = 1;
                        dizi[13] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[3] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[3] = 1;


                            label5.Text = "Basarılı";
                        }





                    }



                }
            }
            if (Kordinat.Text == "D2")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[14] = 1;
                        dizi[15] = 1;
                        dizi[16] = 1;
                        dizi[13] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[43] = 1;
                        dizi[13] = 1;
                        dizi[23] = 1;
                        dizi[33] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[13] = 1;
                        dizi[14] = 1;
                        dizi[15] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[33] = 1;
                        dizi[13] = 1;
                        dizi[23] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[14] = 1;
                        dizi[13] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[23] = 1;
                        dizi[13] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[13] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[13] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "D3")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[24] = 1;
                        dizi[25] = 1;
                        dizi[26] = 1;
                        dizi[23] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[43] = 1;
                        dizi[53] = 1;
                        dizi[23] = 1;
                        dizi[33] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[23] = 1;
                        dizi[24] = 1;
                        dizi[25] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[23] = 1;
                        dizi[33] = 1;
                        dizi[43] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[24] = 1;
                        dizi[23] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[23] = 1;
                        dizi[33] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[23] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[23] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "D4")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[33] = 1;
                        dizi[36] = 1;
                        dizi[34] = 1;
                        dizi[35] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[63] = 1;
                        dizi[53] = 1;
                        dizi[43] = 1;
                        dizi[33] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[35] = 1;
                        dizi[34] = 1;
                        dizi[33] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[33] = 1;
                        dizi[43] = 1;
                        dizi[53] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[34] = 1;
                        dizi[33] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[33] = 1;
                        dizi[43] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[33] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[33] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "D5")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[44] = 1;
                        dizi[45] = 1;
                        dizi[46] = 1;
                        dizi[43] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[73] = 1;
                        dizi[63] = 1;
                        dizi[53] = 1;
                        dizi[43] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[43] = 1;
                        dizi[44] = 1;
                        dizi[45] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[43] = 1;
                        dizi[53] = 1;
                        dizi[63] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[44] = 1;
                        dizi[43] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[43] = 1;
                        dizi[53] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[43] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[43] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "D6")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[54] = 1;
                        dizi[55] = 1;
                        dizi[56] = 1;
                        dizi[53] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[73] = 1;
                        dizi[63] = 1;
                        dizi[53] = 1;
                        dizi[83] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[53] = 1;
                        dizi[54] = 1;
                        dizi[55] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[73] = 1;
                        dizi[53] = 1;
                        dizi[63] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[54] = 1;
                        dizi[53] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[53] = 1;
                        dizi[63] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[53] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[53] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "D7")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[64] = 1;
                        dizi[65] = 1;
                        dizi[66] = 1;
                        dizi[63] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[63] = 1;
                        dizi[73] = 1;
                        dizi[93] = 1;
                        dizi[83] = 1;

                        label5.Text = "Basarılı";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[63] = 1;
                        dizi[64] = 1;
                        dizi[65] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[63] = 1;
                        dizi[73] = 1;
                        dizi[83] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[64] = 1;
                        dizi[63] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[63] = 1;
                        dizi[73] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[63] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[63] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "D8")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[74] = 1;
                        dizi[75] = 1;
                        dizi[76] = 1;
                        dizi[73] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi D8 den dikey şekilde koyulamaz.";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[73] = 1;
                        dizi[74] = 1;
                        dizi[75] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[73] = 1;
                        dizi[83] = 1;
                        dizi[93] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[74] = 1;
                        dizi[73] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[73] = 1;
                        dizi[83] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[73] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[73] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "D9")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[84] = 1;
                        dizi[85] = 1;
                        dizi[86] = 1;
                        dizi[83] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi D9 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[83] = 1;
                        dizi[84] = 1;
                        dizi[85] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi D9 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[83] = 1;
                        dizi[84] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[83] = 1;
                        dizi[93] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[83] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[83] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "D10")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[94] = 1;
                        dizi[95] = 1;
                        dizi[96] = 1;
                        dizi[93] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi D10 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[93] = 1;
                        dizi[94] = 1;
                        dizi[95] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi D10 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[94] = 1;
                        dizi[93] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        label5.Text = "Basarılı değil MiHRAP Gemisi D10 dan dikey şekilde koyulamaz. ";

                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[93] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[93] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }

            if (Kordinat.Text == "E1")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[4] = 1;
                        dizi[5] = 1;
                        dizi[6] = 1;
                        dizi[7] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[4] = 1;
                        dizi[14] = 1;
                        dizi[24] = 1;
                        dizi[34] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[5] = 1;
                        dizi[6] = 1;
                        dizi[4] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[4] = 1;
                        dizi[14] = 1;
                        dizi[24] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[4] = 1;
                        dizi[5] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[4] = 1;
                        dizi[14] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[4] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[4] = 1;


                            label5.Text = "Basarılı";
                        }





                    }



                }
            }
            if (Kordinat.Text == "E2")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[14] = 1;
                        dizi[15] = 1;
                        dizi[16] = 1;
                        dizi[17] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[44] = 1;
                        dizi[14] = 1;
                        dizi[24] = 1;
                        dizi[34] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[16] = 1;
                        dizi[14] = 1;
                        dizi[15] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[34] = 1;
                        dizi[14] = 1;
                        dizi[24] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[14] = 1;
                        dizi[15] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[24] = 1;
                        dizi[14] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[14] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[14] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "E3")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[24] = 1;
                        dizi[25] = 1;
                        dizi[26] = 1;
                        dizi[27] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[44] = 1;
                        dizi[54] = 1;
                        dizi[24] = 1;
                        dizi[34] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[26] = 1;
                        dizi[24] = 1;
                        dizi[25] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[24] = 1;
                        dizi[34] = 1;
                        dizi[44] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[24] = 1;
                        dizi[25] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[24] = 1;
                        dizi[34] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[24] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[24] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "E4")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[37] = 1;
                        dizi[36] = 1;
                        dizi[34] = 1;
                        dizi[35] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[64] = 1;
                        dizi[54] = 1;
                        dizi[44] = 1;
                        dizi[34] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[35] = 1;
                        dizi[34] = 1;
                        dizi[36] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[34] = 1;
                        dizi[44] = 1;
                        dizi[54] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[34] = 1;
                        dizi[35] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[34] = 1;
                        dizi[44] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[34] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[34] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "E5")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[44] = 1;
                        dizi[45] = 1;
                        dizi[46] = 1;
                        dizi[47] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[74] = 1;
                        dizi[64] = 1;
                        dizi[54] = 1;
                        dizi[44] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[46] = 1;
                        dizi[44] = 1;
                        dizi[45] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[44] = 1;
                        dizi[54] = 1;
                        dizi[64] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[44] = 1;
                        dizi[45] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[44] = 1;
                        dizi[54] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[44] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[44] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "E6")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[54] = 1;
                        dizi[55] = 1;
                        dizi[56] = 1;
                        dizi[57] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[74] = 1;
                        dizi[64] = 1;
                        dizi[54] = 1;
                        dizi[84] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[56] = 1;
                        dizi[54] = 1;
                        dizi[55] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[74] = 1;
                        dizi[54] = 1;
                        dizi[64] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[54] = 1;
                        dizi[55] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[54] = 1;
                        dizi[64] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[54] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[54] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "E7")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[64] = 1;
                        dizi[65] = 1;
                        dizi[66] = 1;
                        dizi[67] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[64] = 1;
                        dizi[74] = 1;
                        dizi[94] = 1;
                        dizi[84] = 1;

                        label5.Text = "Basarılı";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[66] = 1;
                        dizi[64] = 1;
                        dizi[65] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[64] = 1;
                        dizi[74] = 1;
                        dizi[84] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[64] = 1;
                        dizi[65] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[64] = 1;
                        dizi[74] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[64] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[64] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "E8")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[74] = 1;
                        dizi[75] = 1;
                        dizi[76] = 1;
                        dizi[77] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi E8 den dikey şekilde koyulamaz.";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[76] = 1;
                        dizi[74] = 1;
                        dizi[75] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[74] = 1;
                        dizi[84] = 1;
                        dizi[94] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[74] = 1;
                        dizi[75] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[74] = 1;
                        dizi[84] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[74] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[74] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "E9")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[84] = 1;
                        dizi[85] = 1;
                        dizi[86] = 1;
                        dizi[87] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi E9 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[86] = 1;
                        dizi[84] = 1;
                        dizi[85] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi E9 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[85] = 1;
                        dizi[84] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[84] = 1;
                        dizi[94] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[84] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[84] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "E10")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[94] = 1;
                        dizi[95] = 1;
                        dizi[96] = 1;
                        dizi[97] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi E10 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[96] = 1;
                        dizi[94] = 1;
                        dizi[95] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi E10 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[94] = 1;
                        dizi[95] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        label5.Text = "Basarılı değil MiHRAP Gemisi E10 dan dikey şekilde koyulamaz. ";

                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[94] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[94] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }

            if (Kordinat.Text == "F1")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[8] = 1;
                        dizi[5] = 1;
                        dizi[6] = 1;
                        dizi[7] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[5] = 1;
                        dizi[15] = 1;
                        dizi[25] = 1;
                        dizi[35] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[5] = 1;
                        dizi[6] = 1;
                        dizi[7] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[5] = 1;
                        dizi[15] = 1;
                        dizi[25] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[6] = 1;
                        dizi[5] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[5] = 1;
                        dizi[15] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[5] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[5] = 1;


                            label5.Text = "Basarılı";
                        }





                    }



                }
            }
            if (Kordinat.Text == "F2")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[18] = 1;
                        dizi[15] = 1;
                        dizi[16] = 1;
                        dizi[17] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[45] = 1;
                        dizi[15] = 1;
                        dizi[25] = 1;
                        dizi[35] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[16] = 1;
                        dizi[17] = 1;
                        dizi[15] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[35] = 1;
                        dizi[15] = 1;
                        dizi[25] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[16] = 1;
                        dizi[15] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[25] = 1;
                        dizi[15] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[15] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[15] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "F3")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[28] = 1;
                        dizi[25] = 1;
                        dizi[26] = 1;
                        dizi[27] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[45] = 1;
                        dizi[55] = 1;
                        dizi[25] = 1;
                        dizi[35] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[26] = 1;
                        dizi[27] = 1;
                        dizi[25] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[25] = 1;
                        dizi[35] = 1;
                        dizi[45] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[26] = 1;
                        dizi[25] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[25] = 1;
                        dizi[35] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[25] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[25] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "F4")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[37] = 1;
                        dizi[36] = 1;
                        dizi[38] = 1;
                        dizi[35] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[65] = 1;
                        dizi[55] = 1;
                        dizi[45] = 1;
                        dizi[35] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[35] = 1;
                        dizi[37] = 1;
                        dizi[36] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[35] = 1;
                        dizi[45] = 1;
                        dizi[55] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[36] = 1;
                        dizi[35] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[35] = 1;
                        dizi[45] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[35] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[35] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "F5")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[48] = 1;
                        dizi[45] = 1;
                        dizi[46] = 1;
                        dizi[47] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[75] = 1;
                        dizi[65] = 1;
                        dizi[55] = 1;
                        dizi[45] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[46] = 1;
                        dizi[47] = 1;
                        dizi[45] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[45] = 1;
                        dizi[55] = 1;
                        dizi[65] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[46] = 1;
                        dizi[45] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[45] = 1;
                        dizi[55] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[45] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[45] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "F6")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[58] = 1;
                        dizi[55] = 1;
                        dizi[56] = 1;
                        dizi[57] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[75] = 1;
                        dizi[65] = 1;
                        dizi[55] = 1;
                        dizi[85] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[56] = 1;
                        dizi[57] = 1;
                        dizi[55] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[75] = 1;
                        dizi[55] = 1;
                        dizi[65] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[56] = 1;
                        dizi[55] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[55] = 1;
                        dizi[65] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[55] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[55] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "F7")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[68] = 1;
                        dizi[65] = 1;
                        dizi[66] = 1;
                        dizi[67] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[65] = 1;
                        dizi[75] = 1;
                        dizi[95] = 1;
                        dizi[85] = 1;

                        label5.Text = "Basarılı";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[66] = 1;
                        dizi[67] = 1;
                        dizi[65] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[65] = 1;
                        dizi[75] = 1;
                        dizi[85] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[65] = 1;
                        dizi[66] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[65] = 1;
                        dizi[75] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[65] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[65] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "F8")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[78] = 1;
                        dizi[75] = 1;
                        dizi[76] = 1;
                        dizi[77] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi F8 den dikey şekilde koyulamaz.";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[76] = 1;
                        dizi[77] = 1;
                        dizi[75] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[75] = 1;
                        dizi[85] = 1;
                        dizi[95] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[76] = 1;
                        dizi[75] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[75] = 1;
                        dizi[85] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[75] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[75] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "F9")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[88] = 1;
                        dizi[85] = 1;
                        dizi[86] = 1;
                        dizi[87] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi F9 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[86] = 1;
                        dizi[87] = 1;
                        dizi[85] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi F9 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[85] = 1;
                        dizi[86] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[85] = 1;
                        dizi[95] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[85] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[85] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "F10")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[98] = 1;
                        dizi[95] = 1;
                        dizi[96] = 1;
                        dizi[97] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi F10 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[96] = 1;
                        dizi[97] = 1;
                        dizi[95] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi F10 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[96] = 1;
                        dizi[95] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        label5.Text = "Basarılı değil MiHRAP Gemisi F10 dan dikey şekilde koyulamaz. ";

                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[95] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[95] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }

            if (Kordinat.Text == "G1")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[8] = 1;
                        dizi[9] = 1;
                        dizi[6] = 1;
                        dizi[7] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[6] = 1;
                        dizi[16] = 1;
                        dizi[26] = 1;
                        dizi[36] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[8] = 1;
                        dizi[6] = 1;
                        dizi[7] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[6] = 1;
                        dizi[16] = 1;
                        dizi[26] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[6] = 1;
                        dizi[7] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[6] = 1;
                        dizi[16] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[6] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[6] = 1;


                            label5.Text = "Basarılı";
                        }





                    }



                }
            }
            if (Kordinat.Text == "G2")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[18] = 1;
                        dizi[19] = 1;
                        dizi[16] = 1;
                        dizi[17] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[46] = 1;
                        dizi[16] = 1;
                        dizi[26] = 1;
                        dizi[36] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[16] = 1;
                        dizi[17] = 1;
                        dizi[18] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[36] = 1;
                        dizi[16] = 1;
                        dizi[26] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[16] = 1;
                        dizi[17] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[26] = 1;
                        dizi[16] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[16] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[16] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "G3")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[28] = 1;
                        dizi[29] = 1;
                        dizi[26] = 1;
                        dizi[27] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[46] = 1;
                        dizi[56] = 1;
                        dizi[26] = 1;
                        dizi[36] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[26] = 1;
                        dizi[27] = 1;
                        dizi[28] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[26] = 1;
                        dizi[36] = 1;
                        dizi[46] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[26] = 1;
                        dizi[27] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[26] = 1;
                        dizi[36] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[26] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[26] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "G4")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[37] = 1;
                        dizi[36] = 1;
                        dizi[38] = 1;
                        dizi[39] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[66] = 1;
                        dizi[56] = 1;
                        dizi[46] = 1;
                        dizi[36] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[38] = 1;
                        dizi[37] = 1;
                        dizi[36] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[36] = 1;
                        dizi[46] = 1;
                        dizi[56] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[36] = 1;
                        dizi[37] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[36] = 1;
                        dizi[46] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[36] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[36] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "G5")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[48] = 1;
                        dizi[49] = 1;
                        dizi[46] = 1;
                        dizi[47] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[76] = 1;
                        dizi[66] = 1;
                        dizi[56] = 1;
                        dizi[46] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[46] = 1;
                        dizi[47] = 1;
                        dizi[48] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[46] = 1;
                        dizi[56] = 1;
                        dizi[66] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[46] = 1;
                        dizi[47] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[46] = 1;
                        dizi[56] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[46] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[46] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "G6")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[58] = 1;
                        dizi[59] = 1;
                        dizi[56] = 1;
                        dizi[57] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[76] = 1;
                        dizi[66] = 1;
                        dizi[56] = 1;
                        dizi[86] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[56] = 1;
                        dizi[57] = 1;
                        dizi[58] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[76] = 1;
                        dizi[56] = 1;
                        dizi[66] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[56] = 1;
                        dizi[57] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[56] = 1;
                        dizi[66] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[56] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[56] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "G7")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[68] = 1;
                        dizi[69] = 1;
                        dizi[66] = 1;
                        dizi[67] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[66] = 1;
                        dizi[76] = 1;
                        dizi[96] = 1;
                        dizi[86] = 1;

                        label5.Text = "Basarılı";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[66] = 1;
                        dizi[67] = 1;
                        dizi[68] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[66] = 1;
                        dizi[76] = 1;
                        dizi[86] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[67] = 1;
                        dizi[66] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[66] = 1;
                        dizi[76] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[66] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[66] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "G8")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[78] = 1;
                        dizi[79] = 1;
                        dizi[76] = 1;
                        dizi[77] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi G8 den dikey şekilde koyulamaz.";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[76] = 1;
                        dizi[77] = 1;
                        dizi[78] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[76] = 1;
                        dizi[86] = 1;
                        dizi[96] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[77] = 1;
                        dizi[76] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[76] = 1;
                        dizi[86] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[76] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[76] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "G9")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[88] = 1;
                        dizi[89] = 1;
                        dizi[86] = 1;
                        dizi[87] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi G9 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[86] = 1;
                        dizi[87] = 1;
                        dizi[88] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi G9 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[87] = 1;
                        dizi[86] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[86] = 1;
                        dizi[96] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[86] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[86] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "G10")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[98] = 1;
                        dizi[99] = 1;
                        dizi[96] = 1;
                        dizi[97] = 1;

                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi G10 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[96] = 1;
                        dizi[97] = 1;
                        dizi[98] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi G10 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[96] = 1;
                        dizi[97] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        label5.Text = "Basarılı değil MiHRAP Gemisi G10 dan dikey şekilde koyulamaz. ";

                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[96] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[96] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }

            if (Kordinat.Text == "H1")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {

                        label5.Text = "Basarılı değil Amiral Gemisi H1 den yatay yerleşemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[7] = 1;
                        dizi[17] = 1;
                        dizi[27] = 1;
                        dizi[37] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[8] = 1;
                        dizi[9] = 1;
                        dizi[7] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[7] = 1;
                        dizi[17] = 1;
                        dizi[27] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[8] = 1;
                        dizi[7] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[7] = 1;
                        dizi[17] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[7] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[7] = 1;


                            label5.Text = "Basarılı";
                        }





                    }



                }
            }
            if (Kordinat.Text == "H2")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi H2 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[47] = 1;
                        dizi[17] = 1;
                        dizi[27] = 1;
                        dizi[37] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[19] = 1;
                        dizi[17] = 1;
                        dizi[18] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[37] = 1;
                        dizi[17] = 1;
                        dizi[27] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[18] = 1;
                        dizi[17] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[27] = 1;
                        dizi[17] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[17] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[17] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "H3")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi H3 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[47] = 1;
                        dizi[57] = 1;
                        dizi[27] = 1;
                        dizi[37] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[29] = 1;
                        dizi[27] = 1;
                        dizi[28] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[27] = 1;
                        dizi[37] = 1;
                        dizi[47] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[28] = 1;
                        dizi[27] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[27] = 1;
                        dizi[37] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[27] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[27] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "H4")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi H4 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[67] = 1;
                        dizi[57] = 1;
                        dizi[47] = 1;
                        dizi[37] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[38] = 1;
                        dizi[37] = 1;
                        dizi[39] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[37] = 1;
                        dizi[47] = 1;
                        dizi[57] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[38] = 1;
                        dizi[37] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[37] = 1;
                        dizi[47] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[37] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[37] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "H5")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi H5 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[77] = 1;
                        dizi[67] = 1;
                        dizi[57] = 1;
                        dizi[47] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[49] = 1;
                        dizi[47] = 1;
                        dizi[48] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[47] = 1;
                        dizi[57] = 1;
                        dizi[67] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[48] = 1;
                        dizi[47] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[47] = 1;
                        dizi[57] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[47] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[47] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "H6")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi H6 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[77] = 1;
                        dizi[67] = 1;
                        dizi[57] = 1;
                        dizi[87] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[59] = 1;
                        dizi[57] = 1;
                        dizi[58] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[77] = 1;
                        dizi[57] = 1;
                        dizi[67] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[58] = 1;
                        dizi[57] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[57] = 1;
                        dizi[67] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[57] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[57] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "H7")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi H7 den yatay yerleşemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[67] = 1;
                        dizi[77] = 1;
                        dizi[97] = 1;
                        dizi[87] = 1;

                        label5.Text = "Basarılı";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[69] = 1;
                        dizi[67] = 1;
                        dizi[68] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[67] = 1;
                        dizi[77] = 1;
                        dizi[87] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[67] = 1;
                        dizi[68] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[67] = 1;
                        dizi[77] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[67] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[67] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "H8")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi H8 den yatay şekilde koyulamaz.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi H8 den dikey şekilde koyulamaz.";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[79] = 1;
                        dizi[77] = 1;
                        dizi[78] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[77] = 1;
                        dizi[87] = 1;
                        dizi[97] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[77] = 1;
                        dizi[78] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[77] = 1;
                        dizi[87] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[77] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[77] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "H9")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {

                        label5.Text = "Basarılı değil Amiral Gemisi H9 dan yatay şekilde koyulamaz. ";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi H9 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[89] = 1;
                        dizi[87] = 1;
                        dizi[88] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi H9 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[87] = 1;
                        dizi[88] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[87] = 1;
                        dizi[97] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[87] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[87] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "H10")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi H10 dan yatay   şekilde koyulamaz. ";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi H10 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[99] = 1;
                        dizi[97] = 1;
                        dizi[98] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi G10 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[98] = 1;
                        dizi[97] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        label5.Text = "Basarılı değil MiHRAP Gemisi H10 dan dikey şekilde koyulamaz. ";

                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[97] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[97] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }

            if (Kordinat.Text == "I1")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {

                        label5.Text = "Basarılı değil Amiral Gemisi I1 den yatay yerleşemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[8] = 1;
                        dizi[18] = 1;
                        dizi[28] = 1;
                        dizi[38] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör I1 den yatay yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[8] = 1;
                        dizi[18] = 1;
                        dizi[28] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[8] = 1;
                        dizi[9] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[8] = 1;
                        dizi[18] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[8] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[8] = 1;


                            label5.Text = "Basarılı";
                        }





                    }



                }
            }
            if (Kordinat.Text == "I2")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi I2 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[48] = 1;
                        dizi[18] = 1;
                        dizi[28] = 1;
                        dizi[38] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör I2 den yatay yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[38] = 1;
                        dizi[18] = 1;
                        dizi[28] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[18] = 1;
                        dizi[19] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[28] = 1;
                        dizi[18] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[18] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[18] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "I3")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi I3 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[48] = 1;
                        dizi[58] = 1;
                        dizi[28] = 1;
                        dizi[38] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör I3 den yatay yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[28] = 1;
                        dizi[38] = 1;
                        dizi[48] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[28] = 1;
                        dizi[29] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[28] = 1;
                        dizi[38] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[28] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[28] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "I4")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi I4 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[68] = 1;
                        dizi[58] = 1;
                        dizi[48] = 1;
                        dizi[38] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör I4 den yatay yerleşemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[38] = 1;
                        dizi[48] = 1;
                        dizi[58] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[38] = 1;
                        dizi[39] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[38] = 1;
                        dizi[48] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[38] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[38] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "I5")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi I5 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[78] = 1;
                        dizi[68] = 1;
                        dizi[58] = 1;
                        dizi[48] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör I5 den yatay yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[48] = 1;
                        dizi[58] = 1;
                        dizi[68] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[48] = 1;
                        dizi[49] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[48] = 1;
                        dizi[58] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[48] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[48] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "I6")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi I6 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[78] = 1;
                        dizi[68] = 1;
                        dizi[58] = 1;
                        dizi[88] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör I6 dan yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[78] = 1;
                        dizi[58] = 1;
                        dizi[68] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[59] = 1;
                        dizi[58] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[58] = 1;
                        dizi[68] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[58] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[58] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "I7")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi I7 den yatay yerleşemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[68] = 1;
                        dizi[78] = 1;
                        dizi[98] = 1;
                        dizi[88] = 1;

                        label5.Text = "Basarılı";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruzavör I7 den yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[68] = 1;
                        dizi[78] = 1;
                        dizi[88] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[68] = 1;
                        dizi[69] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[68] = 1;
                        dizi[78] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[68] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[68] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "I8")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi I8 den yatay şekilde koyulamaz.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi I8 den dikey şekilde koyulamaz.";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Kruvazör I8 den yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[78] = 1;
                        dizi[88] = 1;
                        dizi[98] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[79] = 1;
                        dizi[78] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[78] = 1;
                        dizi[88] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[78] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[78] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "I9")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {

                        label5.Text = "Basarılı değil Amiral Gemisi I9 dan yatay şekilde koyulamaz. ";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi I9 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {



                        label5.Text = "Basarılı değil Kruvazör I9 dan yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi I9 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[89] = 1;
                        dizi[88] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[88] = 1;
                        dizi[98] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[88] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[88] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "I10")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi I10 dan yatay   şekilde koyulamaz. ";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi I10 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör I10 dan yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi I10 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        dizi[98] = 1;
                        dizi[99] = 1;


                        label5.Text = "Basarılı";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        label5.Text = "Basarılı değil MiHRAP Gemisi I10 dan dikey şekilde koyulamaz. ";

                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[98] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[98] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }

            if (Kordinat.Text == "J1")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {

                        label5.Text = "Basarılı değil Amiral Gemisi J1 den yatay yerleşemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[9] = 1;
                        dizi[19] = 1;
                        dizi[29] = 1;
                        dizi[39] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör J1 den yatay yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[9] = 1;
                        dizi[19] = 1;
                        dizi[29] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Mihrap J1 den yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[9] = 1;
                        dizi[19] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[9] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[9] = 1;


                            label5.Text = "Basarılı";
                        }





                    }



                }
            }
            if (Kordinat.Text == "J2")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi J2 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[49] = 1;
                        dizi[19] = 1;
                        dizi[29] = 1;
                        dizi[39] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör J2 den yatay yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[39] = 1;
                        dizi[19] = 1;
                        dizi[29] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Mihrap J2 den yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[29] = 1;
                        dizi[19] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[19] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[19] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "J3")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi J3 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[49] = 1;
                        dizi[59] = 1;
                        dizi[29] = 1;
                        dizi[39] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör J3 den yatay yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[29] = 1;
                        dizi[39] = 1;
                        dizi[49] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Mihrap J3 den yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[29] = 1;
                        dizi[39] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[29] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[29] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "J4")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi J4 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[69] = 1;
                        dizi[59] = 1;
                        dizi[49] = 1;
                        dizi[39] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör J4 den yatay yerleşemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[39] = 1;
                        dizi[49] = 1;
                        dizi[59] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {

                        label5.Text = "Basarılı değil Mihrap I4 den yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[39] = 1;
                        dizi[49] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[39] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[39] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "J5")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi J5 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[79] = 1;
                        dizi[69] = 1;
                        dizi[59] = 1;
                        dizi[49] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör J5 den yatay yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[49] = 1;
                        dizi[59] = 1;
                        dizi[69] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Mihrap I5 den yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[49] = 1;
                        dizi[59] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[49] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[49] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "J6")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi J6 den yatay yerleşemez.";

                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[79] = 1;
                        dizi[69] = 1;
                        dizi[59] = 1;
                        dizi[89] = 1;

                        label5.Text = "Basarılı";
                    }




                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör J6 dan yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[79] = 1;
                        dizi[59] = 1;
                        dizi[69] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Mihrap I6 dan yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[59] = 1;
                        dizi[69] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[59] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[59] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "J7")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi J7 den yatay yerleşemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[69] = 1;
                        dizi[79] = 1;
                        dizi[99] = 1;
                        dizi[89] = 1;

                        label5.Text = "Basarılı";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruzavör J7 den yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[69] = 1;
                        dizi[79] = 1;
                        dizi[89] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Mihrap I7 den yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[69] = 1;
                        dizi[79] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[69] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[69] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "J8")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi J8 den yatay şekilde koyulamaz.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi J8 den dikey şekilde koyulamaz.";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Kruvazör J8 den yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[79] = 1;
                        dizi[89] = 1;
                        dizi[99] = 1;


                        label5.Text = "Basarılı";
                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Mihrap I8 den yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[79] = 1;
                        dizi[89] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[79] = 1;


                            label5.Text = "Basarılı";
                        }





                    }
                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[79] = 1;


                            label5.Text = "Basarılı";
                        }





                    }





                }












            }
            if (Kordinat.Text == "J9")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {

                        label5.Text = "Basarılı değil Amiral Gemisi J9 dan yatay şekilde koyulamaz. ";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi J9 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {



                        label5.Text = "Basarılı değil Kruvazör J9 dan yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi J9 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {



                        label5.Text = "Basarılı değil Mihrap J9 dan yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        dizi[89] = 1;
                        dizi[99] = 1;


                        label5.Text = "Basarılı";
                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[89] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[89] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }
            if (Kordinat.Text == "J10")
            {
                if (GemiSeç.Text == "Amiral Gemisi")
                {
                    if (YönSeç.Text == "Yatay")
                    {
                        label5.Text = "Basarılı değil Amiral Gemisi J10 dan yatay   şekilde koyulamaz. ";
                    }
                    if (YönSeç.Text == "Dikey")
                    {


                        label5.Text = "Basarılı değil Amiral Gemisi J10 dan dikey şekilde koyulamaz. ";
                    }
                }
                if (GemiSeç.Text == "Kruvazör")
                {
                    if (YönSeç.Text == "Yatay")
                    {


                        label5.Text = "Basarılı değil Kruvazör J10 dan yatay olarak yerleştirilemez.";
                    }
                    if (YönSeç.Text == "Dikey")
                    {



                        label5.Text = "Basarılı değil Kruvazör Gemisi J10 dan dikey şekilde koyulamaz. ";

                    }




                }

                if (GemiSeç.Text == "Mihrap")
                {
                    if (YönSeç.Text == "Yatay")
                    {



                        label5.Text = "Basarılı değil MiHRAP Gemisi J10 dan yatay şekilde koyulamaz. ";
                    }
                    if (YönSeç.Text == "Dikey")
                    {
                        label5.Text = "Basarılı değil MiHRAP Gemisi J10 dan dikey şekilde koyulamaz. ";

                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Yatay")
                        {
                            dizi[99] = 1;


                            label5.Text = "Basarılı";
                        }





                    }

                    if (GemiSeç.Text == "Denizaltı")
                    {
                        if (YönSeç.Text == "Dikey")
                        {
                            dizi[99] = 1;


                            label5.Text = "Basarılı";
                        }





                    }




                }












            }


            A1p.Text = dizi[0].ToString();
            A2p.Text = dizi[10].ToString();
            A3p.Text = dizi[20].ToString();
            A4p.Text = dizi[30].ToString();
            A5p.Text = dizi[40].ToString();
            A6p.Text = dizi[50].ToString();
            A7p.Text = dizi[60].ToString();
            A8p.Text = dizi[70].ToString();
            A9p.Text = dizi[80].ToString();
            A10p.Text = dizi[90].ToString();

            B1p.Text = dizi[1].ToString();
            B2p.Text = dizi[11].ToString();
            B3p.Text = dizi[21].ToString();
            B4p.Text = dizi[31].ToString();
            B5p.Text = dizi[41].ToString();
            B6p.Text = dizi[51].ToString();
            B7p.Text = dizi[61].ToString();
            B8p.Text = dizi[71].ToString();
            B9p.Text = dizi[81].ToString();
            B10p.Text = dizi[91].ToString();

            C1p.Text = dizi[2].ToString();
            C2p.Text = dizi[12].ToString();
            C3p.Text = dizi[22].ToString();
            C4p.Text = dizi[32].ToString();
            C5p.Text = dizi[42].ToString();
            C6p.Text = dizi[52].ToString();
            C7p.Text = dizi[62].ToString();
            C8p.Text = dizi[72].ToString();
            C9p.Text = dizi[82].ToString();
            C10p.Text = dizi[92].ToString();

            D1p.Text = dizi[3].ToString();
            D2p.Text = dizi[13].ToString();
            D3p.Text = dizi[23].ToString();
            D4p.Text = dizi[33].ToString();
            D5p.Text = dizi[43].ToString();
            D6p.Text = dizi[53].ToString();
            D7p.Text = dizi[63].ToString();
            D8p.Text = dizi[73].ToString();
            D9p.Text = dizi[83].ToString();
            D10p.Text = dizi[93].ToString();

            E1p.Text = dizi[4].ToString();
            E2p.Text = dizi[14].ToString();
            E3p.Text = dizi[24].ToString();
            E4p.Text = dizi[34].ToString();
            E5p.Text = dizi[44].ToString();
            E6p.Text = dizi[54].ToString();
            E7p.Text = dizi[64].ToString();
            E8p.Text = dizi[74].ToString();
            E9p.Text = dizi[84].ToString();
            E10p.Text = dizi[94].ToString();

            F1p.Text = dizi[5].ToString();
            F2p.Text = dizi[15].ToString();
            F3p.Text = dizi[25].ToString();
            F4p.Text = dizi[35].ToString();
            F5p.Text = dizi[45].ToString();
            F6p.Text = dizi[55].ToString();
            F7p.Text = dizi[65].ToString();
            F8p.Text = dizi[75].ToString();
            F9p.Text = dizi[85].ToString();
            F10p.Text = dizi[95].ToString();

            G1p.Text = dizi[6].ToString();
            G2p.Text = dizi[16].ToString();
            G3p.Text = dizi[26].ToString();
            G4p.Text = dizi[36].ToString();
            G5p.Text = dizi[46].ToString();
            G6p.Text = dizi[56].ToString();
            G7p.Text = dizi[66].ToString();
            G8p.Text = dizi[76].ToString();
            G9p.Text = dizi[86].ToString();
            G10p.Text = dizi[96].ToString();

            H1p.Text = dizi[7].ToString();
            H2p.Text = dizi[17].ToString();
            H3p.Text = dizi[27].ToString();
            H4p.Text = dizi[37].ToString();
            H5p.Text = dizi[47].ToString();
            H6p.Text = dizi[57].ToString();
            H7p.Text = dizi[67].ToString();
            H8p.Text = dizi[77].ToString();
            H9p.Text = dizi[87].ToString();
            H10p.Text = dizi[97].ToString();

            I1p.Text = dizi[8].ToString();
            I2p.Text = dizi[18].ToString();
            I3p.Text = dizi[28].ToString();
            I4p.Text = dizi[38].ToString();
            I5p.Text = dizi[48].ToString();
            I6p.Text = dizi[58].ToString();
            I7p.Text = dizi[68].ToString();
            I8p.Text = dizi[78].ToString();
            I9p.Text = dizi[88].ToString();
            I10p.Text = dizi[98].ToString();




            J1p.Text = dizi[9].ToString();
            J2p.Text = dizi[19].ToString();
            J3p.Text = dizi[29].ToString();
            J4p.Text = dizi[39].ToString();
            J5p.Text = dizi[49].ToString();
            J6p.Text = dizi[59].ToString();
            J7p.Text = dizi[69].ToString();
            J8p.Text = dizi[79].ToString();
            J9p.Text = dizi[89].ToString();
            J10p.Text = dizi[99].ToString();
        }










        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void E9p_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void TahtaSil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 99; i++)
            {
                dizi[i] = 0;
            }
            A1p.Text = dizi[0].ToString();
            A2p.Text = dizi[10].ToString();
            A3p.Text = dizi[20].ToString();
            A4p.Text = dizi[30].ToString();
            A5p.Text = dizi[40].ToString();
            A6p.Text = dizi[50].ToString();
            A7p.Text = dizi[60].ToString();
            A8p.Text = dizi[70].ToString();
            A9p.Text = dizi[80].ToString();
            A10p.Text = dizi[90].ToString();

            B1p.Text = dizi[1].ToString();
            B2p.Text = dizi[11].ToString();
            B3p.Text = dizi[21].ToString();
            B4p.Text = dizi[31].ToString();
            B5p.Text = dizi[41].ToString();
            B6p.Text = dizi[51].ToString();
            B7p.Text = dizi[61].ToString();
            B8p.Text = dizi[71].ToString();
            B9p.Text = dizi[81].ToString();
            B10p.Text = dizi[91].ToString();

            C1p.Text = dizi[2].ToString();
            C2p.Text = dizi[12].ToString();
            C3p.Text = dizi[22].ToString();
            C4p.Text = dizi[32].ToString();
            C5p.Text = dizi[42].ToString();
            C6p.Text = dizi[52].ToString();
            C7p.Text = dizi[62].ToString();
            C8p.Text = dizi[72].ToString();
            C9p.Text = dizi[82].ToString();
            C10p.Text = dizi[92].ToString();

            D1p.Text = dizi[3].ToString();
            D2p.Text = dizi[13].ToString();
            D3p.Text = dizi[23].ToString();
            D4p.Text = dizi[33].ToString();
            D5p.Text = dizi[43].ToString();
            D6p.Text = dizi[53].ToString();
            D7p.Text = dizi[63].ToString();
            D8p.Text = dizi[73].ToString();
            D9p.Text = dizi[83].ToString();
            D10p.Text = dizi[93].ToString();

            E1p.Text = dizi[4].ToString();
            E2p.Text = dizi[14].ToString();
            E3p.Text = dizi[24].ToString();
            E4p.Text = dizi[34].ToString();
            E5p.Text = dizi[44].ToString();
            E6p.Text = dizi[54].ToString();
            E7p.Text = dizi[64].ToString();
            E8p.Text = dizi[74].ToString();
            E9p.Text = dizi[84].ToString();
            E10p.Text = dizi[94].ToString();

            F1p.Text = dizi[5].ToString();
            F2p.Text = dizi[15].ToString();
            F3p.Text = dizi[25].ToString();
            F4p.Text = dizi[35].ToString();
            F5p.Text = dizi[45].ToString();
            F6p.Text = dizi[55].ToString();
            F7p.Text = dizi[65].ToString();
            F8p.Text = dizi[75].ToString();
            F9p.Text = dizi[85].ToString();
            F10p.Text = dizi[95].ToString();

            G1p.Text = dizi[6].ToString();
            G2p.Text = dizi[16].ToString();
            G3p.Text = dizi[26].ToString();
            G4p.Text = dizi[36].ToString();
            G5p.Text = dizi[46].ToString();
            G6p.Text = dizi[56].ToString();
            G7p.Text = dizi[66].ToString();
            G8p.Text = dizi[76].ToString();
            G9p.Text = dizi[86].ToString();
            G10p.Text = dizi[96].ToString();

            H1p.Text = dizi[7].ToString();
            H2p.Text = dizi[17].ToString();
            H3p.Text = dizi[27].ToString();
            H4p.Text = dizi[37].ToString();
            H5p.Text = dizi[47].ToString();
            H6p.Text = dizi[57].ToString();
            H7p.Text = dizi[67].ToString();
            H8p.Text = dizi[77].ToString();
            H9p.Text = dizi[87].ToString();
            H10p.Text = dizi[97].ToString();

            I1p.Text = dizi[8].ToString();
            I2p.Text = dizi[18].ToString();
            I3p.Text = dizi[28].ToString();
            I4p.Text = dizi[38].ToString();
            I5p.Text = dizi[48].ToString();
            I6p.Text = dizi[58].ToString();
            I7p.Text = dizi[68].ToString();
            I8p.Text = dizi[78].ToString();
            I9p.Text = dizi[88].ToString();
            I10p.Text = dizi[98].ToString();




            J1p.Text = dizi[9].ToString();
            J2p.Text = dizi[19].ToString();
            J3p.Text = dizi[29].ToString();
            J4p.Text = dizi[39].ToString();
            J5p.Text = dizi[49].ToString();
            J6p.Text = dizi[59].ToString();
            J7p.Text = dizi[69].ToString();
            J8p.Text = dizi[79].ToString();
            J9p.Text = dizi[89].ToString();
            J10p.Text = dizi[99].ToString();




        }

        private void YönSeç_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GemiSeç_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Kordinat_TextChanged(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {
            Button btn = this.B1;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }



        private void A10_Click(object sender, EventArgs e)
        {
            Button btn = this.A10;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Button btn = this.B2;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void J3_Click(object sender, EventArgs e)
        {
            Button btn = this.J3;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void J10_Click(object sender, EventArgs e)
        {
            Button btn = this.J10;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void I10_Click(object sender, EventArgs e)
        {
            Button btn = this.I10;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            Button btn = this.C1;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void D1_Click(object sender, EventArgs e)
        {
            Button btn = this.D1;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void E1_Click(object sender, EventArgs e)
        {
            Button btn = this.E1;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void F1_Click(object sender, EventArgs e)
        {
            Button btn = this.F1;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void G1_Click(object sender, EventArgs e)
        {
            Button btn = this.G1;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void H1_Click(object sender, EventArgs e)
        {
            Button btn = this.H1;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void I1_Click(object sender, EventArgs e)
        {
            Button btn = this.I1;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void J1_Click(object sender, EventArgs e)
        {
            Button btn = this.J1;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void A2_Click_1(object sender, EventArgs e)
        {
            Button btn = this.A2;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            Button btn = this.C2;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void D2_Click(object sender, EventArgs e)
        {
            Button btn = this.D2;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void E2_Click(object sender, EventArgs e)
        {
            Button btn = this.E2;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void F2_Click(object sender, EventArgs e)
        {
            Button btn = this.F2;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void G2_Click(object sender, EventArgs e)
        {
            Button btn = this.G2;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void H2_Click(object sender, EventArgs e)
        {
            Button btn = this.H2;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void I2_Click(object sender, EventArgs e)
        {
            Button btn = this.I2;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void J2_Click(object sender, EventArgs e)
        {
            Button btn = this.J2;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            Button btn = this.A3;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void A4_Click(object sender, EventArgs e)
        {
            Button btn = this.A4;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void A5_Click(object sender, EventArgs e)
        {
            Button btn = this.A5;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void A6_Click(object sender, EventArgs e)
        {
            Button btn = this.A6;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void A7_Click(object sender, EventArgs e)
        {
            Button btn = this.A7;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void A8_Click(object sender, EventArgs e)
        {
            Button btn = this.A8;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void A9_Click(object sender, EventArgs e)
        {
            Button btn = this.A9;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Button btn = this.B4;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Button btn = this.B5;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Button btn = this.B6;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            Button btn = this.B7;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Button btn = this.B8;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            Button btn = this.B9;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void B10_Click(object sender, EventArgs e)
        {
            Button btn = this.B10;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void C4_Click(object sender, EventArgs e)
        {
            Button btn = this.C4;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void C5_Click(object sender, EventArgs e)
        {
            Button btn = this.C5;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void C6_Click(object sender, EventArgs e)
        {
            Button btn = this.C6;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void C7_Click_1(object sender, EventArgs e)
        {
            Button btn = this.C7;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void C8_Click(object sender, EventArgs e)
        {
            Button btn = this.C8;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void C9_Click(object sender, EventArgs e)
        {
            Button btn = this.C9;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void C10_Click(object sender, EventArgs e)
        {
            Button btn = this.C10;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void D10_Click(object sender, EventArgs e)
        {

            Button btn = this.D10;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void E10_Click(object sender, EventArgs e)
        {
            Button btn = this.E10;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void F10_Click(object sender, EventArgs e)
        {
            Button btn = this.F10;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void G10_Click(object sender, EventArgs e)
        {
            Button btn = this.G10;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void H10_Click(object sender, EventArgs e)
        {
            Button btn = this.H10;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void J9_Click(object sender, EventArgs e)
        {
            Button btn = this.J9;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void I9_Click(object sender, EventArgs e)
        {
            Button btn = this.I9;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void H9_Click(object sender, EventArgs e)
        {
            Button btn = this.H9;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void G9_Click_1(object sender, EventArgs e)
        {
            Button btn = this.G9;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void F9_Click(object sender, EventArgs e)
        {
            Button btn = this.F9;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void E9_Click(object sender, EventArgs e)
        {
            Button btn = this.E9;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void D9_Click(object sender, EventArgs e)
        {
            Button btn = this.D9;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void D7_Click(object sender, EventArgs e)
        {
            Button btn = this.D7;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void D8_Click(object sender, EventArgs e)
        {
            Button btn = this.D8;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void D6_Click(object sender, EventArgs e)
        {
            Button btn = this.D6;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void D5_Click(object sender, EventArgs e)
        {
            Button btn = this.D5;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void D4_Click(object sender, EventArgs e)
        {
            Button btn = this.D4;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void D3_Click(object sender, EventArgs e)
        {
            Button btn = this.D3;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void E3_Click(object sender, EventArgs e)
        {
            Button btn = this.E3;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void F3_Click(object sender, EventArgs e)
        {
            Button btn = this.F3;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void G3_Click(object sender, EventArgs e)
        {
            Button btn = this.G3;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void H3_Click(object sender, EventArgs e)
        {
            Button btn = this.H3;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void I3_Click(object sender, EventArgs e)
        {
            Button btn = this.I3;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void J4_Click(object sender, EventArgs e)
        {
            Button btn = this.J4;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void J5_Click(object sender, EventArgs e)
        {
            Button btn = this.J5;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void J6_Click(object sender, EventArgs e)
        {
            Button btn = this.J6;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void J7_Click(object sender, EventArgs e)
        {
            Button btn = this.J7;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void J8_Click(object sender, EventArgs e)
        {
            Button btn = this.J8;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void I8_Click(object sender, EventArgs e)
        {
            Button btn = this.I8;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void I7_Click(object sender, EventArgs e)
        {
            Button btn = this.I7;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void I6_Click(object sender, EventArgs e)
        {
            Button btn = this.I6;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void I5_Click(object sender, EventArgs e)
        {
            Button btn = this.I5;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void I4_Click(object sender, EventArgs e)
        {
            Button btn = this.I4;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void H4_Click(object sender, EventArgs e)
        {
            Button btn = this.H4;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void G4_Click(object sender, EventArgs e)
        {
            Button btn = this.G4;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void F4_Click(object sender, EventArgs e)
        {
            Button btn = this.F4;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void E4_Click(object sender, EventArgs e)
        {
            Button btn = this.E4;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void F5_Click(object sender, EventArgs e)
        {
            Button btn = this.F5;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void E5_Click(object sender, EventArgs e)
        {
            Button btn = this.E5;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void G5_Click(object sender, EventArgs e)
        {
            Button btn = this.G5;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void H5_Click(object sender, EventArgs e)
        {
            Button btn = this.H5;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void H7_Click(object sender, EventArgs e)
        {
            Button btn = this.H7;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void H6_Click(object sender, EventArgs e)
        {
            Button btn = this.H6;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void H8_Click(object sender, EventArgs e)
        {
            Button btn = this.H8;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void G8_Click(object sender, EventArgs e)
        {
            Button btn = this.G8;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void G7_Click(object sender, EventArgs e)
        {
            Button btn = this.G7;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void G6_Click(object sender, EventArgs e)
        {
            Button btn = this.G6;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void F8_Click(object sender, EventArgs e)
        {
            Button btn = this.F8;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void F7_Click(object sender, EventArgs e)
        {
            Button btn = this.F7;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void F6_Click(object sender, EventArgs e)
        {
            Button btn = this.F6;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void E6_Click(object sender, EventArgs e)
        {
            Button btn = this.E6;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void E7_Click(object sender, EventArgs e)
        {
            Button btn = this.E7;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void E8_Click(object sender, EventArgs e)
        {
            Button btn = this.E8;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Button btn = this.B3;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            Button btn = this.C3;
            String letter = btn.Name.Substring(0, 1);
            String coorY = btn.Name.Substring(1);

            int i;

            i = char.Parse(letter) - 'A';

            int cory = Int32.Parse(coorY);


            String coryy = i.ToString();

            if (cory == 1)
            {



                int full = Int32.Parse(coryy);
                label6.Text = coryy;


                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }
            }

            else
            {
                cory = cory - 1;
                String coor = cory.ToString() + i.ToString();

                int full = Int32.Parse(coor);
                label6.Text = coor;

                if (dizi[full] == 1)
                {
                    btn.Text = "X".ToString();

                }
                if (dizi[full] == 0)
                {
                    btn.Text = "O".ToString();
                }

            }
        }
    }

}