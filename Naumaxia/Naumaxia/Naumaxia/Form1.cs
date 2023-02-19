using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Naumaxia.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;

namespace Naumaxia
{

    public partial class Form1 : Form
    {

        int[] Columns = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] Rows = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] ColumnsUsed = new int[14]; //0-1 submarine 2-4 polemiko 5-8 aditorpliliko 9-13 aeroplanoforo
        int[] RowsUsed = new int[14];
        int[] ColumnsUsedE = new int[14];
        int[] RowsUsedE = new int[14];
        int[] HitColumns = new int[10];
        int[] HitRows = new int[10];
        int[] HitColumnsE = new int[10];
        int[] HitRowsE = new int[10];


        int time = 0;
        int PlayerShips;
        int EnemyShips;
        int round = 0;
        int wins = 0;
        int losses = 0;
        int targetColumn;
        int targetRow;
        int targetColumnE;
        int targetRowE;
        String[] directions = { "orizodia", "katheta" };//epilogi orizodia(0) i ka8eta(1)

        public class submarine
        {
            public int direction;
            public int length = 2;
            public int[,] koutakia = new int[,] { { 0, 0 }, { 0, 0 } };//proti thesi Row (grammi), deuteri stili (Column)


        }

        submarine Ypobruxio = new submarine();
        submarine YpobruxioE = new submarine();
        public class polemiko
        {
            public int direction;
            public int length = 3;
            public int[,] koutakia = new int[,] { { 0, 0 }, { 0, 0 }, { 0, 0 } };//proti thesi Row (grammi), deuteri stili (Column)


        }

        polemiko Polemiko = new polemiko();
        polemiko PolemikoE = new polemiko();
        public class aditorpiliko
        {
            public int direction;
            public int length = 4;
            public int[,] koutakia = new int[,] { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } };//proti thesi Row (grammi), deuteri stili (Column)


        }
        aditorpiliko Aditorpiliko = new aditorpiliko();
        aditorpiliko AditorpilikoE = new aditorpiliko();

        public class aeroplanoforo
        {
            public int direction;
            public int length = 5;
            public int[,] koutakia = new int[,] { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } };//proti thesi Row (grammi), deuteri stili (Column)


        }

        aeroplanoforo Aeroplanoforo = new aeroplanoforo();
        aeroplanoforo AeroplanoforoE = new aeroplanoforo();

        public Form1()
        {

            InitializeComponent();
            textBox1.Text = "Unnamed";
            textBox1.Location = new Point(356, 250);
            this.dataGridView1.Location = new Point(20000, 75);
            Return.Location = new Point(20000, 43);
            AttackBTN.Location = new Point(20000, 20000);
            StartBTN.Text = "Start";
            StartBTN.Location = new Point(492, 478);
            StartBTN.Size = new System.Drawing.Size(121, 60);
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);
            Announce.Location = new Point(10000, 50);
        }



        //ploia topothetisi
        private void PlaceSubmarine()//upobruxio
        {

            Random rand = new Random();
            int direction1 = rand.Next(directions.Length);
            if (direction1 == 0)//orizodia
            {
                int Row1 = rand.Next(Rows.Length);
                int Column1 = rand.Next(Columns.Length);
                while (Column1 == 9)
                {
                    Column1 = rand.Next(Columns.Length);
                }                                                                                    // [ 0   ,    0]    [   1   ,   1]
                Ypobruxio.direction = direction1;//proti thesi Row (grammi), deuteri stili (Column)   { {Row1, Column1} {Row1, Column1++}}
                Ypobruxio.koutakia[0, 0] = Row1;
                Ypobruxio.koutakia[1, 0] = Row1;
                Ypobruxio.koutakia[0, 1] = Column1;
                Ypobruxio.koutakia[1, 1] = Column1 + 1;
                RowsUsed[0] = Row1;
                RowsUsed[1] = Row1;
                ColumnsUsed[0] = Column1;
                ColumnsUsed[1] = Column1 + 1;
                for (int i = Column1; i < Column1 + 2; i++)
                {
                    var lbl = new Label();
                    lbl.Dock = DockStyle.Fill;
                    lbl.Text = "Ypo";
                    lbl.ForeColor = System.Drawing.Color.SlateBlue;
                    PlayerSea.Controls.Add(lbl, i, Row1);

                }

            };

            if (direction1 == 1)//katheta
            {
                int Row1 = rand.Next(Rows.Length);
                int Column1 = rand.Next(Columns.Length);
                while (Row1 == 9)
                {
                    Row1 = rand.Next(Rows.Length);
                }
                Ypobruxio.direction = direction1;
                Ypobruxio.koutakia[0, 0] = Row1;
                Ypobruxio.koutakia[1, 0] = Row1 + 1;
                Ypobruxio.koutakia[0, 1] = Column1;
                Ypobruxio.koutakia[1, 1] = Column1;
                ColumnsUsed[0] = Column1;
                ColumnsUsed[1] = Column1;
                RowsUsed[0] = Row1;
                RowsUsed[1] = Row1 + 1;
                for (int i = Row1; i < Row1 + 2; i++)
                {
                    var lbl = new Label();
                    lbl.Dock = DockStyle.Fill;
                    lbl.Text = "Ypo";
                    lbl.ForeColor = System.Drawing.Color.SlateBlue;
                    PlayerSea.Controls.Add(lbl, Column1, i);

                }
            };

        }
        private void PlacePolemiko()//polemiko
        {
            //proti thesi Row (grammi), deuteri stili (Column)   { {Row1, Column1} {Row1, Column1++}}
            Random rand = new Random();
        TryAgain:
            int direction2 = rand.Next(directions.Length);
            if (direction2 == 0)//orizodia
            {
                int Row2 = rand.Next(Rows.Length);
                int Column2 = rand.Next(Columns.Length);
                while (Column2 >= 8)
                {
                    Column2 = rand.Next(Columns.Length);
                }
                if (RowsUsed.Contains(Row2) && (ColumnsUsed.Contains(Column2) || ColumnsUsed.Contains(Column2 + 1) || ColumnsUsed.Contains(Column2 + 2)))
                { goto TryAgain; };
                Polemiko.direction = direction2;
                Polemiko.koutakia[0, 0] = Row2;
                Polemiko.koutakia[1, 0] = Row2;
                Polemiko.koutakia[2, 0] = Row2;
                Polemiko.koutakia[0, 1] = Column2;
                Polemiko.koutakia[1, 1] = Column2 + 1;
                Polemiko.koutakia[2, 1] = Column2 + 2;
                RowsUsed[2] = Row2;
                RowsUsed[3] = Row2;
                RowsUsed[4] = Row2;
                ColumnsUsed[2] = Column2;
                ColumnsUsed[3] = Column2 + 1;
                ColumnsUsed[4] = Column2 + 2;
                for (int i = Column2; i < Column2 + 3; i++)
                {
                    var lbl = new Label();
                    lbl.Dock = DockStyle.Fill;
                    lbl.Text = "Pol";
                    lbl.ForeColor = System.Drawing.Color.Green;
                    PlayerSea.Controls.Add(lbl, i, Row2);

                }
            };

            if (direction2 == 1)//katheta
            {
                int Row2 = rand.Next(Rows.Length);
                int Column2 = rand.Next(Columns.Length);
                while (Row2 >= 8)
                {
                    Row2 = rand.Next(Rows.Length);
                }
                if (ColumnsUsed.Contains(Column2) && (RowsUsed.Contains(Row2) || RowsUsed.Contains(Row2 + 1) || RowsUsed.Contains(Row2 + 2)))
                { goto TryAgain; };
                Polemiko.direction = direction2;
                Polemiko.koutakia[0, 0] = Row2;
                Polemiko.koutakia[1, 0] = Row2 + 1;
                Polemiko.koutakia[2, 0] = Row2 + 2;
                Polemiko.koutakia[0, 1] = Column2;
                Polemiko.koutakia[1, 1] = Column2;
                Polemiko.koutakia[2, 1] = Column2;
                ColumnsUsed[2] = Column2;
                ColumnsUsed[3] = Column2;
                ColumnsUsed[4] = Column2;
                RowsUsed[2] = Row2;
                RowsUsed[3] = Row2 + 1;
                RowsUsed[4] = Row2 + 2;
                for (int i = Row2; i < Row2 + 3; i++)
                {
                    var lbl = new Label();
                    lbl.Dock = DockStyle.Fill;
                    lbl.Text = "Pol";
                    lbl.ForeColor = System.Drawing.Color.Green;
                    PlayerSea.Controls.Add(lbl, Column2, i);

                }
            };

        }

        private void PlaceAditorpiliko()//aditorpiliko
        {

            Random rand = new Random();
        TryAgain:
            int direction3 = rand.Next(directions.Length);
            if (direction3 == 0)//orizodia
            {
                int Row3 = rand.Next(Rows.Length);
                int Column3 = rand.Next(Columns.Length);
                while (Column3 >= 7)
                {
                    Column3 = rand.Next(Columns.Length);
                }
                if (RowsUsed.Contains(Row3) && (ColumnsUsed.Contains(Column3) || ColumnsUsed.Contains(Column3 + 1) || ColumnsUsed.Contains(Column3 + 2) || ColumnsUsed.Contains(Column3 + 3)))
                { goto TryAgain; };
                Aditorpiliko.direction = direction3;
                Aditorpiliko.koutakia[0, 0] = Row3;
                Aditorpiliko.koutakia[1, 0] = Row3;
                Aditorpiliko.koutakia[2, 0] = Row3;
                Aditorpiliko.koutakia[3, 0] = Row3;
                Aditorpiliko.koutakia[0, 1] = Column3;
                Aditorpiliko.koutakia[1, 1] = Column3 + 1;
                Aditorpiliko.koutakia[2, 1] = Column3 + 2;
                Aditorpiliko.koutakia[3, 1] = Column3 + 3;
                RowsUsed[5] = Row3;
                RowsUsed[6] = Row3;
                RowsUsed[7] = Row3;
                RowsUsed[8] = Row3;
                ColumnsUsed[5] = Column3;
                ColumnsUsed[6] = Column3 + 1;
                ColumnsUsed[7] = Column3 + 2;
                ColumnsUsed[8] = Column3 + 3;
                for (int i = Column3; i < Column3 + 4; i++)
                {
                    var lbl = new Label();
                    lbl.Dock = DockStyle.Fill;
                    lbl.Text = "Adi";
                    lbl.ForeColor = System.Drawing.Color.DarkBlue;
                    PlayerSea.Controls.Add(lbl, i, Row3);

                }



            };

            if (direction3 == 1)//katheta
            {
                int Row3 = rand.Next(Rows.Length);
                int Column3 = rand.Next(Columns.Length);
                while (Row3 >= 7)
                {
                    Row3 = rand.Next(Rows.Length);
                }
                if (ColumnsUsed.Contains(Column3) && (RowsUsed.Contains(Row3) || RowsUsed.Contains(Row3 + 1) || RowsUsed.Contains(Row3 + 2) || RowsUsed.Contains(Row3 + 3)))
                { goto TryAgain; };
                Aditorpiliko.direction = direction3;
                Aditorpiliko.koutakia[0, 0] = Row3;
                Aditorpiliko.koutakia[1, 0] = Row3 + 1;
                Aditorpiliko.koutakia[2, 0] = Row3 + 2;
                Aditorpiliko.koutakia[3, 0] = Row3 + 3;
                Aditorpiliko.koutakia[0, 1] = Column3;
                Aditorpiliko.koutakia[1, 1] = Column3;
                Aditorpiliko.koutakia[2, 1] = Column3;
                Aditorpiliko.koutakia[3, 1] = Column3;
                RowsUsed[5] = Row3;
                RowsUsed[6] = Row3 + 1;
                RowsUsed[7] = Row3 + 2;
                RowsUsed[8] = Row3 + 3;
                ColumnsUsed[5] = Column3;
                ColumnsUsed[6] = Column3;
                ColumnsUsed[7] = Column3;
                ColumnsUsed[8] = Column3;
                for (int i = Row3; i < Row3 + 4; i++)
                {
                    var lbl = new Label();
                    lbl.Dock = DockStyle.Fill;
                    lbl.Text = "Adi";
                    lbl.ForeColor = System.Drawing.Color.DarkBlue;
                    PlayerSea.Controls.Add(lbl, Column3, i);

                }



            };

        }

        private void PlaceAeroplanoforo()//aeroplanoforo
        {

            Random rand = new Random();
        TryAgain:
            int direction4 = rand.Next(directions.Length);
            if (direction4 == 0)//orizodia
            {
                int Row4 = rand.Next(Rows.Length);
                int Column4 = rand.Next(Columns.Length);
                while (Column4 >= 6)
                {
                    Column4 = rand.Next(Columns.Length);
                }
                if (RowsUsed.Contains(Row4) && (ColumnsUsed.Contains(Column4) || ColumnsUsed.Contains(Column4 + 1) || ColumnsUsed.Contains(Column4 + 2) || ColumnsUsed.Contains(Column4 + 3) || ColumnsUsed.Contains(Column4 + 4)))
                { goto TryAgain; };
                Aeroplanoforo.direction = direction4;
                Aeroplanoforo.koutakia[0, 0] = Row4;
                Aeroplanoforo.koutakia[1, 0] = Row4;
                Aeroplanoforo.koutakia[2, 0] = Row4;
                Aeroplanoforo.koutakia[3, 0] = Row4;
                Aeroplanoforo.koutakia[4, 0] = Row4;
                Aeroplanoforo.koutakia[0, 1] = Column4;
                Aeroplanoforo.koutakia[1, 1] = Column4 + 1;
                Aeroplanoforo.koutakia[2, 1] = Column4 + 2;
                Aeroplanoforo.koutakia[3, 1] = Column4 + 3;
                Aeroplanoforo.koutakia[4, 1] = Column4 + 4;
                RowsUsed[9] = Row4;
                RowsUsed[10] = Row4;
                RowsUsed[11] = Row4;
                RowsUsed[12] = Row4;
                RowsUsed[13] = Row4;
                ColumnsUsed[9] = Column4;
                ColumnsUsed[10] = Column4 + 1;
                ColumnsUsed[11] = Column4 + 2;
                ColumnsUsed[12] = Column4 + 3;
                ColumnsUsed[13] = Column4 + 4;
                for (int i = Column4; i < Column4 + 5; i++)
                {
                    var lbl = new Label();
                    lbl.Dock = DockStyle.Fill;
                    lbl.Text = "Aer";
                    lbl.ForeColor = System.Drawing.Color.Black;
                    PlayerSea.Controls.Add(lbl, i, Row4);

                }

            };
            if (direction4 == 1)//katheta
            {
                int Row4 = rand.Next(Rows.Length);
                int Column4 = rand.Next(Columns.Length);
                while (Row4 >= 6)
                {
                    Row4 = rand.Next(Rows.Length);
                }
                if (ColumnsUsed.Contains(Column4) && (RowsUsed.Contains(Row4) || RowsUsed.Contains(Row4 + 1) || RowsUsed.Contains(Row4 + 2) || RowsUsed.Contains(Row4 + 3) || RowsUsed.Contains(Row4 + 4)))
                { goto TryAgain; };
                Aeroplanoforo.direction = direction4;
                Aeroplanoforo.koutakia[0, 0] = Row4;
                Aeroplanoforo.koutakia[1, 0] = Row4 + 1;
                Aeroplanoforo.koutakia[2, 0] = Row4 + 2;
                Aeroplanoforo.koutakia[3, 0] = Row4 + 3;
                Aeroplanoforo.koutakia[4, 0] = Row4 + 4;
                Aeroplanoforo.koutakia[0, 1] = Column4;
                Aeroplanoforo.koutakia[1, 1] = Column4;
                Aeroplanoforo.koutakia[2, 1] = Column4;
                Aeroplanoforo.koutakia[3, 1] = Column4;
                Aeroplanoforo.koutakia[4, 1] = Column4;
                RowsUsed[9] = Row4;
                RowsUsed[10] = Row4 + 1;
                RowsUsed[11] = Row4 + 2;
                RowsUsed[12] = Row4 + 3;
                RowsUsed[13] = Row4 + 4;
                ColumnsUsed[9] = Column4;
                ColumnsUsed[10] = Column4;
                ColumnsUsed[11] = Column4;
                ColumnsUsed[12] = Column4;
                ColumnsUsed[13] = Column4;
                for (int i = Row4; i < Row4 + 5; i++)
                {
                    var lbl = new Label();
                    lbl.Dock = DockStyle.Fill;
                    lbl.Text = "Aer";
                    lbl.ForeColor = System.Drawing.Color.Black;
                    PlayerSea.Controls.Add(lbl, Column4, i);

                }

            };

        }

        //adipala ploia
        private void PlaceSubmarineE()//upobruxio adipalo
        {

            Random rand = new Random();
            int direction1E = rand.Next(directions.Length);
            if (direction1E == 0)//orizodia
            {
                int Row1E = rand.Next(Rows.Length);
                int Column1E = rand.Next(Columns.Length);
                while (Column1E == 9)
                {
                    Column1E = rand.Next(Columns.Length);
                }
                YpobruxioE.direction = direction1E;//proti thesi Row (grammi), deuteri stili (Column)   { {Row1, Column1} {Row1, Column1++}}
                YpobruxioE.koutakia[0, 0] = Row1E;
                YpobruxioE.koutakia[1, 0] = Row1E;
                YpobruxioE.koutakia[0, 1] = Column1E;
                YpobruxioE.koutakia[1, 1] = Column1E + 1;
                RowsUsedE[0] = Row1E;
                RowsUsedE[1] = Row1E;
                ColumnsUsedE[0] = Column1E;
                ColumnsUsedE[1] = Column1E + 1;

            };
            if (direction1E == 1)//katheta
            {
                int Row1E = rand.Next(Rows.Length);
                int Column1E = rand.Next(Columns.Length);
                while (Row1E == 9)
                {
                    Row1E = rand.Next(Rows.Length);
                }
                YpobruxioE.direction = direction1E;
                YpobruxioE.koutakia[0, 0] = Row1E;
                YpobruxioE.koutakia[1, 0] = Row1E + 1;
                YpobruxioE.koutakia[0, 1] = Column1E;
                YpobruxioE.koutakia[1, 1] = Column1E;
                ColumnsUsedE[0] = Column1E;
                ColumnsUsedE[1] = Column1E;
                RowsUsedE[0] = Row1E;
                RowsUsedE[1] = Row1E + 1;

            };

        }

        private void PlacePolemikoE()//polemiko adipalo
        {

            Random rand = new Random();
        TryAgain:
            int direction2E = rand.Next(directions.Length);
            if (direction2E == 0)//orizodia
            {
                int Row2E = rand.Next(Rows.Length);
                int Column2E = rand.Next(Columns.Length);
                while (Column2E >= 8)
                {
                    Column2E = rand.Next(Columns.Length);
                }
                if (RowsUsedE.Contains(Row2E) && (ColumnsUsedE.Contains(Column2E) || ColumnsUsedE.Contains(Column2E + 1) || ColumnsUsedE.Contains(Column2E + 2)))
                { goto TryAgain; };
                PolemikoE.direction = direction2E;
                PolemikoE.koutakia[0, 0] = Row2E;
                PolemikoE.koutakia[1, 0] = Row2E;
                PolemikoE.koutakia[2, 0] = Row2E;
                PolemikoE.koutakia[0, 1] = Column2E;
                PolemikoE.koutakia[1, 1] = Column2E + 1;
                PolemikoE.koutakia[2, 1] = Column2E + 2;
                RowsUsedE[2] = Row2E;
                RowsUsedE[3] = Row2E;
                RowsUsedE[4] = Row2E;
                ColumnsUsedE[2] = Column2E;
                ColumnsUsedE[3] = Column2E + 1;
                ColumnsUsedE[4] = Column2E + 2;

            };
            if (direction2E == 1)//katheta
            {
                int Row2E = rand.Next(Rows.Length);
                int Column2E = rand.Next(Columns.Length);
                while (Row2E >= 8)
                {
                    Row2E = rand.Next(Rows.Length);
                }
                if (ColumnsUsedE.Contains(Column2E) && (RowsUsedE.Contains(Row2E) || RowsUsedE.Contains(Row2E + 1) || RowsUsedE.Contains(Row2E + 2)))
                { goto TryAgain; };
                PolemikoE.direction = direction2E;
                PolemikoE.koutakia[0, 0] = Row2E;
                PolemikoE.koutakia[1, 0] = Row2E + 1;
                PolemikoE.koutakia[2, 0] = Row2E + 2;
                PolemikoE.koutakia[0, 1] = Column2E;
                PolemikoE.koutakia[1, 1] = Column2E;
                PolemikoE.koutakia[2, 1] = Column2E;
                ColumnsUsedE[2] = Column2E;
                ColumnsUsedE[3] = Column2E;
                ColumnsUsedE[4] = Column2E;
                RowsUsedE[2] = Row2E;
                RowsUsedE[3] = Row2E + 1;
                RowsUsedE[4] = Row2E + 2;

            };
        }

        private void PlaceAditorpilikoE()//aditorpiliko adipalo
        {

            Random rand = new Random();
        TryAgain:
            int direction3E = rand.Next(directions.Length);
            if (direction3E == 0)//orizodia
            {
                int Row3E = rand.Next(Rows.Length);
                int Column3E = rand.Next(Columns.Length);
                while (Column3E >= 7)
                {
                    Column3E = rand.Next(Columns.Length);
                }
                if (RowsUsedE.Contains(Row3E) && (ColumnsUsedE.Contains(Column3E) || ColumnsUsedE.Contains(Column3E + 1) || ColumnsUsedE.Contains(Column3E + 2) || ColumnsUsedE.Contains(Column3E + 3)))
                { goto TryAgain; };
                AditorpilikoE.direction = direction3E;
                AditorpilikoE.koutakia[0, 0] = Row3E;
                AditorpilikoE.koutakia[1, 0] = Row3E;
                AditorpilikoE.koutakia[2, 0] = Row3E;
                AditorpilikoE.koutakia[3, 0] = Row3E;
                AditorpilikoE.koutakia[0, 1] = Column3E;
                AditorpilikoE.koutakia[1, 1] = Column3E + 1;
                AditorpilikoE.koutakia[2, 1] = Column3E + 2;
                AditorpilikoE.koutakia[3, 1] = Column3E + 3;
                RowsUsedE[5] = Row3E;
                RowsUsedE[6] = Row3E;
                RowsUsedE[7] = Row3E;
                RowsUsedE[8] = Row3E;
                ColumnsUsedE[5] = Column3E;
                ColumnsUsedE[6] = Column3E + 1;
                ColumnsUsedE[7] = Column3E + 2;
                ColumnsUsedE[8] = Column3E + 3;

            };
            if (direction3E == 1)//katheta
            {
                int Row3E = rand.Next(Rows.Length);
                int Column3E = rand.Next(Columns.Length);
                while (Row3E >= 7)
                {
                    Row3E = rand.Next(Rows.Length);
                }
                if (ColumnsUsedE.Contains(Column3E) && (RowsUsedE.Contains(Row3E) || RowsUsedE.Contains(Row3E + 1) || RowsUsedE.Contains(Row3E + 2) || RowsUsedE.Contains(Row3E + 3)))
                { goto TryAgain; };
                AditorpilikoE.direction = direction3E;
                AditorpilikoE.koutakia[0, 0] = Row3E;
                AditorpilikoE.koutakia[1, 0] = Row3E + 1;
                AditorpilikoE.koutakia[2, 0] = Row3E + 2;
                AditorpilikoE.koutakia[3, 0] = Row3E + 3;
                AditorpilikoE.koutakia[0, 1] = Column3E;
                AditorpilikoE.koutakia[1, 1] = Column3E;
                AditorpilikoE.koutakia[2, 1] = Column3E;
                AditorpilikoE.koutakia[3, 1] = Column3E;
                RowsUsedE[5] = Row3E;
                RowsUsedE[6] = Row3E + 1;
                RowsUsedE[7] = Row3E + 2;
                RowsUsedE[8] = Row3E + 3;
                ColumnsUsedE[5] = Column3E;
                ColumnsUsedE[6] = Column3E;
                ColumnsUsedE[7] = Column3E;
                ColumnsUsedE[8] = Column3E;

            };

        }

        private void PlaceAeroplanoforoE()//aeroplanoforo adipalo
        {

            Random rand = new Random();
        TryAgain:
            int direction4E = rand.Next(directions.Length);
            if (direction4E == 0)//orizodia
            {
                int Row4E = rand.Next(Rows.Length);
                int Column4E = rand.Next(Columns.Length);
                while (Column4E >= 6)
                {
                    Column4E = rand.Next(Columns.Length);
                }
                if (RowsUsedE.Contains(Row4E) && (ColumnsUsedE.Contains(Column4E) || ColumnsUsedE.Contains(Column4E + 1) || ColumnsUsedE.Contains(Column4E + 2) || ColumnsUsedE.Contains(Column4E + 3) || ColumnsUsedE.Contains(Column4E + 4)))
                { goto TryAgain; };
                AeroplanoforoE.direction = direction4E;
                AeroplanoforoE.koutakia[0, 0] = Row4E;
                AeroplanoforoE.koutakia[1, 0] = Row4E;
                AeroplanoforoE.koutakia[2, 0] = Row4E;
                AeroplanoforoE.koutakia[3, 0] = Row4E;
                AeroplanoforoE.koutakia[4, 0] = Row4E;
                AeroplanoforoE.koutakia[0, 1] = Column4E;
                AeroplanoforoE.koutakia[1, 1] = Column4E + 1;
                AeroplanoforoE.koutakia[2, 1] = Column4E + 2;
                AeroplanoforoE.koutakia[3, 1] = Column4E + 3;
                AeroplanoforoE.koutakia[4, 1] = Column4E + 4;
                RowsUsedE[9] = Row4E;
                RowsUsedE[10] = Row4E;
                RowsUsedE[11] = Row4E;
                RowsUsedE[12] = Row4E;
                RowsUsedE[13] = Row4E;
                ColumnsUsedE[9] = Column4E;
                ColumnsUsedE[10] = Column4E + 1;
                ColumnsUsedE[11] = Column4E + 2;
                ColumnsUsedE[12] = Column4E + 3;
                ColumnsUsedE[13] = Column4E + 4;

            };
            if (direction4E == 1)//katheta
            {
                int Row4E = rand.Next(Rows.Length);
                int Column4E = rand.Next(Columns.Length);
                while (Row4E >= 6)
                {
                    Row4E = rand.Next(Rows.Length);
                }
                if (ColumnsUsedE.Contains(Column4E) && (RowsUsedE.Contains(Row4E) || RowsUsedE.Contains(Row4E + 1) || RowsUsedE.Contains(Row4E + 2) || RowsUsedE.Contains(Row4E + 3) || RowsUsedE.Contains(Row4E + 4)))
                { goto TryAgain; };
                AeroplanoforoE.direction = direction4E;
                AeroplanoforoE.koutakia[0, 0] = Row4E;
                AeroplanoforoE.koutakia[1, 0] = Row4E + 1;
                AeroplanoforoE.koutakia[2, 0] = Row4E + 2;
                AeroplanoforoE.koutakia[3, 0] = Row4E + 3;
                AeroplanoforoE.koutakia[4, 0] = Row4E + 4;
                AeroplanoforoE.koutakia[0, 1] = Column4E;
                AeroplanoforoE.koutakia[1, 1] = Column4E;
                AeroplanoforoE.koutakia[2, 1] = Column4E;
                AeroplanoforoE.koutakia[3, 1] = Column4E;
                AeroplanoforoE.koutakia[4, 1] = Column4E;
                RowsUsedE[9] = Row4E;
                RowsUsedE[10] = Row4E + 1;
                RowsUsedE[11] = Row4E + 2;
                RowsUsedE[12] = Row4E + 3;
                RowsUsedE[13] = Row4E + 4;
                ColumnsUsedE[9] = Column4E;
                ColumnsUsedE[10] = Column4E;
                ColumnsUsedE[11] = Column4E;
                ColumnsUsedE[12] = Column4E;
                ColumnsUsedE[13] = Column4E;

            };

        }



        private void Restart()
        {
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);

            textBox1.Location = new Point(10000, 250);
            Announce.Location = new Point(10000, 50);
            Time.Text = "Time: 0";
            PlayerLabel.Location = new Point(12, 9);
            PlayerLabel.Text = "Wins: " + wins.ToString();
            EnemyLabel.Text = "Losses: " + losses.ToString();
            PlayerShips = 4;
            EnemyShips = 4;
            round = 0;
            StartBTN.Location = new Point(10000, 10000);
            StartBTN.Text = "Start";

            for (int i =0; i < RowsUsed.Length; i++)
            {
                RowsUsed.Append(10);
            }
            for (int i = 0; i < ColumnsUsed.Length; i++)
            {
                ColumnsUsed.Append(10);
            }
            for (int i = 0; i < RowsUsedE.Length; i++)
            {
                RowsUsedE.Append(10);
            }
            for (int i = 0; i < ColumnsUsedE.Length; i++)
            {
               ColumnsUsedE.Append(10);
            }
            
            Array.Clear(HitColumnsE, 0, HitColumnsE.Length);
            Array.Clear(HitRowsE, 0, HitRowsE.Length);
            Array.Clear(HitColumns, 0, HitColumns.Length);
            Array.Clear(HitRows, 0, HitRows.Length);
            PlayerSea.Controls.Clear();
            EnemySea.Controls.Clear();
            //ship placements
            PlaceSubmarine();
            PlacePolemiko();
            PlaceAditorpiliko();
            PlaceAeroplanoforo();
            PlaceSubmarineE();
            PlacePolemikoE();
            PlaceAditorpilikoE();
            PlaceAeroplanoforoE();
            lblYpo.Text = "Υποβρύχιο: Alive";
            lblPol.Text = "Πολεμικό: Alive";
            lblAdi.Text = "Αντιτορπιλικό: Alive";
            lblAer.Text = "Αεροπλανοφόρο: Alive";
            lblYpoE.Text = "Αντίπαλο Υποβρύχιο: Alive";
            lblPolE.Text = "Αντίπαλο Πολεμικό: Alive";
            lblAdiE.Text = "Αντίπαλο Αντιτορπιλικό: Alive";
            lblAerE.Text = "Αντίπαλο Αεροπλανοφόρο: Alive";


            timer2.Start();
           

            Game();
        }

        private void Game()
        {

            AttackBTN.Location = new Point(487, 107);


            AttackBTN.Text = "Attack";
            Pplayerships.Text = "Ally ships remaining: " + PlayerShips.ToString();
            Eenemyships.Text = "Enemy ships remaining: " + EnemyShips.ToString();
            Rounds.Text = "Round: " + round.ToString();
            if (EnemyShips == 0)
            {
                GameWon();
            }
            if (PlayerShips == 0)
            {
                GameLost();
            }




        }

        private void AttackBTN_Click(object sender, EventArgs e)
        {
            AttackBTN.Location = new Point(20000, 20000);

            Arow.Location = new Point(200, 477);
            Brow.Location = new Point(240, 477);
            Crow.Location = new Point(280, 477);
            Drow.Location = new Point(320, 477);
            Erow.Location = new Point(360, 477);
            Zrow.Location = new Point(400, 477);
            Hrow.Location = new Point(440, 477);
            Urow.Location = new Point(480, 477);
            Irow.Location = new Point(520, 477);
            Krow.Location = new Point(560, 477);


            round++;
            Rounds.Text = "Round: " + round.ToString();
            
        }

        public void PlayerTurn()
        {
            var pic = new PictureBox();
            EnemySea.Controls.Add(pic, targetColumn, targetRow);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Dock = DockStyle.Fill;
            pic.Image = Properties.Resources.green;

            if (ColumnsUsedE.Contains(targetColumn) && RowsUsedE.Contains(targetRow)) //xtupima
            {

                for (int i = 0; i < ColumnsUsedE.Length; i++)
                {
                    if (ColumnsUsedE[i] == targetColumn)
                    {
                        for (int j = 0; j < RowsUsedE.Length; j++)
                        {
                            if (RowsUsedE[j] == targetRow)
                            {
                                if (i == j)
                                {
                                    //pio ploio xtupi8ike
                                    if (i < 2)
                                    {

                                        pic.Image = Properties.Resources.redx;
                                        YpobruxioE.length = YpobruxioE.length - 1;
                                        if (YpobruxioE.length == 0)
                                        {
                                            EnemyShips = EnemyShips - 1;
                                            lblYpoE.Text = "Αντίπαλο Υποβρύχιο: Destroyed";
                                        }
                                    }
                                    if (i >= 2 && i < 5)
                                    {

                                        pic.Image = Properties.Resources.redx;
                                        PolemikoE.length = PolemikoE.length - 1;
                                        if (PolemikoE.length == 0)
                                        {
                                            EnemyShips = EnemyShips - 1;
                                            lblPolE.Text = "Αντίπαλο Πολεμικό: Destroyed";
                                        }
                                    }
                                    if (i >= 5 && i < 9)
                                    {

                                        pic.Image = Properties.Resources.redx;
                                        AditorpilikoE.length = AditorpilikoE.length - 1;
                                        if (AditorpilikoE.length == 0)
                                        {
                                            EnemyShips = EnemyShips - 1;
                                            lblAdiE.Text = "Αντίπαλο Αντιτορπιλικό: Destroyed";
                                        }
                                    }
                                    if (i >= 9)
                                    {

                                        pic.Image = Properties.Resources.redx;
                                        AeroplanoforoE.length = AeroplanoforoE.length - 1;
                                        if (AeroplanoforoE.length == 0)
                                        {
                                            EnemyShips = EnemyShips - 1;
                                            lblAerE.Text = "Αντίπαλο Αεροπλανοφόρο: Destroyed";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
        public void EnemyTurn()
        {
            
            
                Random rand = new Random();
                Again:
                targetColumnE = rand.Next(Columns.Length);
                targetRowE = rand.Next(Rows.Length);
                if (HitColumnsE.Contains(targetColumnE) && HitRowsE.Contains(targetRowE))
                { goto Again; }
                HitColumnsE.Append(targetColumnE);
                HitRowsE.Append(targetRowE);
                
                PlayerSea.Controls.Remove(PlayerSea.GetControlFromPosition(targetColumnE, targetRowE));
                var pic = new PictureBox();
                PlayerSea.Controls.Add(pic, targetColumnE, targetRowE);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Dock = DockStyle.Fill;
                pic.Image = Properties.Resources.green;

            //PlayerSea.Controls.Add(pic, targetColumnE, targetRowE);
            if (ColumnsUsed.Contains(targetColumnE) && RowsUsed.Contains(targetRowE)) //xtupima
                {                   
                    
                    for (int i = 0; i < ColumnsUsed.Length; i++)
                    {
                        if (ColumnsUsed[i] == targetColumnE)
                        {
                            for (int j = 0; j < RowsUsed.Length; j++)
                            {
                                if (RowsUsed[j] == targetRowE)
                                {
                                    if (i == j)
                                    {
                                        //pio ploio xtupi8ike
                                        if (i < 2)
                                        {
                                        
                                        pic.Image = Properties.Resources.redx;
                                            Ypobruxio.length = Ypobruxio.length - 1;
                                            if (Ypobruxio.length == 0)
                                            {

                                                PlayerShips = PlayerShips - 1;
                                                lblYpo.Text = "Υποβρύχιο: Destroyed";
                                            }
                                        }
                                        if (i >= 2 && i < 5)
                                        {
                                        
                                        pic.Image = Properties.Resources.redx;
                                            Polemiko.length = Polemiko.length - 1;
                                            if (Polemiko.length == 0)
                                            {
                                                PlayerShips = PlayerShips - 1;
                                                lblPol.Text = "Πολεμικό: Destroyed";
                                            }
                                        }
                                        if (i >= 5 && i < 9)
                                        {
                                        
                                        pic.Image = Properties.Resources.redx;
                                            Aditorpiliko.length = Aditorpiliko.length - 1;
                                            if (Aditorpiliko.length == 0)
                                            {
                                                PlayerShips = PlayerShips - 1;
                                                lblAdi.Text = "Αντιτορπιλικό: Destroyed";
                                            }
                                        }
                                        if (i >= 9)
                                        {
                                        
                                        pic.Image = Properties.Resources.redx;
                                            Aeroplanoforo.length = Aeroplanoforo.length - 1;
                                            if (Aeroplanoforo.length == 0)
                                            {
                                                PlayerShips = PlayerShips - 1;
                                                lblAer.Text = "Αεροπλανοφόρο: Destroyed";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                
                }

            
                
            
        }
 



        private void GameLost()
        {
            losses = losses + 1;
            Announce.Text = "Defeat!";
            Announce.Location = new Point(500, 50);
            StartBTN.Text = "Start";
            PlayerLabel.Text = "Wins: " + wins.ToString();
            EnemyLabel.Text = "Losses: " + losses.ToString();
            StartBTN.Location = new Point(492, 478);
            StartBTN.Size = new Size(121, 60);
            timer2.Stop();
            AttackBTN.Location = new Point(20000, 20000);
        }

        private void GameWon()
        {
            wins = wins + 1;
            Announce.Text = "Victory!";
            Announce.Location = new Point(500, 50);
            StartBTN.Text = "Start";
            PlayerLabel.Text = "Wins: " + wins.ToString();
            EnemyLabel.Text = "Losses: " + losses.ToString();
            StartBTN.Location = new Point(492, 478);
            StartBTN.Size = new Size(121, 60);
            timer2.Stop();
            AttackBTN.Location = new Point(20000, 20000);
        }


        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StartBTN_Click(object sender, EventArgs e)//Kalei tin sunartisi Restart
        {
            Restart();
            


        }



        private void PlayerLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Time.Text = "Time: "+ time++.ToString();
        }


        private void Arow_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(200, 523);
            Clm2.Location = new Point(240, 523);
            Clm3.Location = new Point(280, 523);
            Clm4.Location = new Point(320, 523);
            Clm5.Location = new Point(360, 523);
            Clm6.Location = new Point(400, 523);
            Clm7.Location = new Point(440, 523);
            Clm8.Location = new Point(480, 523);
            Clm9.Location = new Point(520, 523);
            Clm10.Location = new Point(560, 523);
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);

            targetRow = 0;
            HitRows.Append(targetRow);
        }

        private void Brow_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(200, 523);
            Clm2.Location = new Point(240, 523);
            Clm3.Location = new Point(280, 523);
            Clm4.Location = new Point(320, 523);
            Clm5.Location = new Point(360, 523);
            Clm6.Location = new Point(400, 523);
            Clm7.Location = new Point(440, 523);
            Clm8.Location = new Point(480, 523);
            Clm9.Location = new Point(520, 523);
            Clm10.Location = new Point(560, 523);
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);

            targetRow = 1;
            HitRows.Append(targetRow);
        }

        private void Crow_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(200, 523);
            Clm2.Location = new Point(240, 523);
            Clm3.Location = new Point(280, 523);
            Clm4.Location = new Point(320, 523);
            Clm5.Location = new Point(360, 523);
            Clm6.Location = new Point(400, 523);
            Clm7.Location = new Point(440, 523);
            Clm8.Location = new Point(480, 523);
            Clm9.Location = new Point(520, 523);
            Clm10.Location = new Point(560, 523);
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);

            targetRow = 2;
            HitRows.Append(targetRow);
        }

        private void Drow_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(200, 523);
            Clm2.Location = new Point(240, 523);
            Clm3.Location = new Point(280, 523);
            Clm4.Location = new Point(320, 523);
            Clm5.Location = new Point(360, 523);
            Clm6.Location = new Point(400, 523);
            Clm7.Location = new Point(440, 523);
            Clm8.Location = new Point(480, 523);
            Clm9.Location = new Point(520, 523);
            Clm10.Location = new Point(560, 523);
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);

            targetRow = 3;
            HitRows.Append(targetRow);
        }

        private void Erow_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(200, 523);
            Clm2.Location = new Point(240, 523);
            Clm3.Location = new Point(280, 523);
            Clm4.Location = new Point(320, 523);
            Clm5.Location = new Point(360, 523);
            Clm6.Location = new Point(400, 523);
            Clm7.Location = new Point(440, 523);
            Clm8.Location = new Point(480, 523);
            Clm9.Location = new Point(520, 523);
            Clm10.Location = new Point(560, 523);
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);

            targetRow = 4;
            HitRows.Append(targetRow);
        }

        private void Zrow_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(200, 523);
            Clm2.Location = new Point(240, 523);
            Clm3.Location = new Point(280, 523);
            Clm4.Location = new Point(320, 523);
            Clm5.Location = new Point(360, 523);
            Clm6.Location = new Point(400, 523);
            Clm7.Location = new Point(440, 523);
            Clm8.Location = new Point(480, 523);
            Clm9.Location = new Point(520, 523);
            Clm10.Location = new Point(560, 523);
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);

            targetRow = 5;
            HitRows.Append(targetRow);
        }

        private void Hrow_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(200, 523);
            Clm2.Location = new Point(240, 523);
            Clm3.Location = new Point(280, 523);
            Clm4.Location = new Point(320, 523);
            Clm5.Location = new Point(360, 523);
            Clm6.Location = new Point(400, 523);
            Clm7.Location = new Point(440, 523);
            Clm8.Location = new Point(480, 523);
            Clm9.Location = new Point(520, 523);
            Clm10.Location = new Point(560, 523);
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);

            targetRow = 6;
            HitRows.Append(targetRow);
        }

        private void Urow_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(200, 523);
            Clm2.Location = new Point(240, 523);
            Clm3.Location = new Point(280, 523);
            Clm4.Location = new Point(320, 523);
            Clm5.Location = new Point(360, 523);
            Clm6.Location = new Point(400, 523);
            Clm7.Location = new Point(440, 523);
            Clm8.Location = new Point(480, 523);
            Clm9.Location = new Point(520, 523);
            Clm10.Location = new Point(560, 523);
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);

            targetRow = 7;
            HitRows.Append(targetRow);
        }

        private void Irow_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(200, 523);
            Clm2.Location = new Point(240, 523);
            Clm3.Location = new Point(280, 523);
            Clm4.Location = new Point(320, 523);
            Clm5.Location = new Point(360, 523);
            Clm6.Location = new Point(400, 523);
            Clm7.Location = new Point(440, 523);
            Clm8.Location = new Point(480, 523);
            Clm9.Location = new Point(520, 523);
            Clm10.Location = new Point(560, 523);
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);

            targetRow = 8;
            HitRows.Append(targetRow);
        }

        private void Krow_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(200, 523);
            Clm2.Location = new Point(240, 523);
            Clm3.Location = new Point(280, 523);
            Clm4.Location = new Point(320, 523);
            Clm5.Location = new Point(360, 523);
            Clm6.Location = new Point(400, 523);
            Clm7.Location = new Point(440, 523);
            Clm8.Location = new Point(480, 523);
            Clm9.Location = new Point(520, 523);
            Clm10.Location = new Point(560, 523);
            Arow.Location = new Point(20000, 477);
            Brow.Location = new Point(20000, 477);
            Crow.Location = new Point(20000, 477);
            Drow.Location = new Point(20000, 477);
            Erow.Location = new Point(20000, 477);
            Zrow.Location = new Point(20000, 477);
            Hrow.Location = new Point(20000, 477);
            Urow.Location = new Point(20000, 477);
            Irow.Location = new Point(20000, 477);
            Krow.Location = new Point(20000, 477);

            targetRow = 9;
            HitRows.Append(targetRow);
        }

        private void Clm1_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);

            targetColumn = 0;

                PlayerTurn();
                EnemyTurn();
                Game();
            
        }

        private void Clm2_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);

            targetColumn = 1;

                PlayerTurn();
                EnemyTurn();
                Game();
            
        }

        private void Clm3_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);

            targetColumn = 2;

                PlayerTurn();
                EnemyTurn();
                Game();
            
        }

        private void Clm4_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);

            targetColumn = 3;


                PlayerTurn();
                EnemyTurn();
                Game();
            
        }

        private void Clm5_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);

            targetColumn = 4;
            PlayerTurn();
            EnemyTurn();
            Game();
        }

        private void Clm6_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);

            targetColumn = 5;
            PlayerTurn();
            EnemyTurn();
            Game();
        }

        private void Clm7_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);

            targetColumn = 6;
            PlayerTurn();
            EnemyTurn();
            Game();
        }

        private void Clm8_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);

            targetColumn = 7;
            PlayerTurn();
            EnemyTurn();
            Game();
        }

        private void Clm9_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);

            targetColumn = 8;
            PlayerTurn();
            EnemyTurn();
            Game();
        }

        private void Clm10_Click(object sender, EventArgs e)
        {
            Clm1.Location = new Point(20000, 523);
            Clm2.Location = new Point(25000, 523);
            Clm3.Location = new Point(30000, 523);
            Clm4.Location = new Point(35000, 523);
            Clm5.Location = new Point(40000, 523);
            Clm6.Location = new Point(45000, 523);
            Clm7.Location = new Point(50000, 523);
            Clm8.Location = new Point(55000, 523);
            Clm9.Location = new Point(60000, 523);
            Clm10.Location = new Point(65000, 523);

            targetColumn = 9;
            PlayerTurn();
            EnemyTurn();
            Game();
        }

        private void Save_Click(object sender, EventArgs e)//Absolute path
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\stefan\\Documents\\NaumaxiaDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into DatabaseN values (@Username,@NumberOfWins,@Time)", con);
            cmd.Parameters.AddWithValue("@Username", (textBox1.Text));
            cmd.Parameters.AddWithValue("@NumberOfWins", (PlayerLabel.Text));
            cmd.Parameters.AddWithValue("@Time", (Time.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Saved Succesfully");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stats_Click(object sender, EventArgs e)//Absolute path
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\stefan\\Documents\\NaumaxiaDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from DatabaseN", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Location = new Point(343, 75);
            Return.Location = new Point(300, 43);
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Return.Location = new Point(20000, 43);
            this.dataGridView1.Location = new Point(20000, 75);
        }
    }

}
