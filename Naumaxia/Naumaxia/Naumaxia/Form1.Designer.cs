using System;

namespace Naumaxia
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.EnemyLabel = new System.Windows.Forms.Label();
            this.Rounds = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Α = new System.Windows.Forms.Label();
            this.Αε = new System.Windows.Forms.Label();
            this.Β = new System.Windows.Forms.Label();
            this.Δ = new System.Windows.Forms.Label();
            this.Γ = new System.Windows.Forms.Label();
            this.Ζ = new System.Windows.Forms.Label();
            this.Ε = new System.Windows.Forms.Label();
            this.Θ = new System.Windows.Forms.Label();
            this.Η = new System.Windows.Forms.Label();
            this.Κ = new System.Windows.Forms.Label();
            this.Ι = new System.Windows.Forms.Label();
            this.Κε = new System.Windows.Forms.Label();
            this.Ιε = new System.Windows.Forms.Label();
            this.Θε = new System.Windows.Forms.Label();
            this.Ηε = new System.Windows.Forms.Label();
            this.Ζε = new System.Windows.Forms.Label();
            this.Εε = new System.Windows.Forms.Label();
            this.Δε = new System.Windows.Forms.Label();
            this.Γε = new System.Windows.Forms.Label();
            this.Βε = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l1e = new System.Windows.Forms.Label();
            this.PlayerSea = new System.Windows.Forms.TableLayoutPanel();
            this.EnemySea = new System.Windows.Forms.TableLayoutPanel();
            this.StartBTN = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Pplayerships = new System.Windows.Forms.Label();
            this.Eenemyships = new System.Windows.Forms.Label();
            this.AttackBTN = new System.Windows.Forms.Button();
            this.Arow = new System.Windows.Forms.Button();
            this.Brow = new System.Windows.Forms.Button();
            this.Crow = new System.Windows.Forms.Button();
            this.Drow = new System.Windows.Forms.Button();
            this.Zrow = new System.Windows.Forms.Button();
            this.Hrow = new System.Windows.Forms.Button();
            this.Urow = new System.Windows.Forms.Button();
            this.Irow = new System.Windows.Forms.Button();
            this.Erow = new System.Windows.Forms.Button();
            this.Krow = new System.Windows.Forms.Button();
            this.Clm10 = new System.Windows.Forms.Button();
            this.Clm5 = new System.Windows.Forms.Button();
            this.Clm9 = new System.Windows.Forms.Button();
            this.Clm8 = new System.Windows.Forms.Button();
            this.Clm7 = new System.Windows.Forms.Button();
            this.Clm6 = new System.Windows.Forms.Button();
            this.Clm4 = new System.Windows.Forms.Button();
            this.Clm3 = new System.Windows.Forms.Button();
            this.Clm2 = new System.Windows.Forms.Button();
            this.Clm1 = new System.Windows.Forms.Button();
            this.lblYpo = new System.Windows.Forms.Label();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblAer = new System.Windows.Forms.Label();
            this.lblAerE = new System.Windows.Forms.Label();
            this.lblAdiE = new System.Windows.Forms.Label();
            this.lblPolE = new System.Windows.Forms.Label();
            this.lblYpoE = new System.Windows.Forms.Label();
            this.Announce = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stats = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.BackColor = System.Drawing.Color.Lime;
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PlayerLabel.Location = new System.Drawing.Point(12, 9);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(141, 29);
            this.PlayerLabel.TabIndex = 0;
            this.PlayerLabel.Text = "PlayerLabel";
            this.PlayerLabel.Click += new System.EventHandler(this.PlayerLabel_Click);
            // 
            // EnemyLabel
            // 
            this.EnemyLabel.AutoSize = true;
            this.EnemyLabel.BackColor = System.Drawing.Color.Red;
            this.EnemyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EnemyLabel.Location = new System.Drawing.Point(718, 6);
            this.EnemyLabel.Name = "EnemyLabel";
            this.EnemyLabel.Size = new System.Drawing.Size(147, 29);
            this.EnemyLabel.TabIndex = 1;
            this.EnemyLabel.Text = "EnemyLabel";
            // 
            // Rounds
            // 
            this.Rounds.AutoSize = true;
            this.Rounds.BackColor = System.Drawing.Color.Transparent;
            this.Rounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Rounds.ForeColor = System.Drawing.Color.White;
            this.Rounds.Location = new System.Drawing.Point(319, 6);
            this.Rounds.Name = "Rounds";
            this.Rounds.Size = new System.Drawing.Size(109, 31);
            this.Rounds.TabIndex = 2;
            this.Rounds.Text = "Round: ";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(578, 6);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(96, 31);
            this.Time.TabIndex = 3;
            this.Time.Text = "Time:  ";
            // 
            // Α
            // 
            this.Α.AutoSize = true;
            this.Α.BackColor = System.Drawing.Color.Transparent;
            this.Α.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Α.ForeColor = System.Drawing.Color.White;
            this.Α.Location = new System.Drawing.Point(52, 111);
            this.Α.Name = "Α";
            this.Α.Size = new System.Drawing.Size(32, 31);
            this.Α.TabIndex = 204;
            this.Α.Text = "Α";
            // 
            // Αε
            // 
            this.Αε.AutoSize = true;
            this.Αε.BackColor = System.Drawing.Color.Transparent;
            this.Αε.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Αε.ForeColor = System.Drawing.Color.White;
            this.Αε.Location = new System.Drawing.Point(610, 112);
            this.Αε.Name = "Αε";
            this.Αε.Size = new System.Drawing.Size(32, 31);
            this.Αε.TabIndex = 205;
            this.Αε.Text = "Α";
            // 
            // Β
            // 
            this.Β.AutoSize = true;
            this.Β.BackColor = System.Drawing.Color.Transparent;
            this.Β.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Β.ForeColor = System.Drawing.Color.White;
            this.Β.Location = new System.Drawing.Point(52, 148);
            this.Β.Name = "Β";
            this.Β.Size = new System.Drawing.Size(32, 31);
            this.Β.TabIndex = 206;
            this.Β.Text = "Β";
            // 
            // Δ
            // 
            this.Δ.AutoSize = true;
            this.Δ.BackColor = System.Drawing.Color.Transparent;
            this.Δ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Δ.ForeColor = System.Drawing.Color.White;
            this.Δ.Location = new System.Drawing.Point(50, 222);
            this.Δ.Name = "Δ";
            this.Δ.Size = new System.Drawing.Size(32, 31);
            this.Δ.TabIndex = 208;
            this.Δ.Text = "Δ";
            // 
            // Γ
            // 
            this.Γ.AutoSize = true;
            this.Γ.BackColor = System.Drawing.Color.Transparent;
            this.Γ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Γ.ForeColor = System.Drawing.Color.White;
            this.Γ.Location = new System.Drawing.Point(50, 185);
            this.Γ.Name = "Γ";
            this.Γ.Size = new System.Drawing.Size(30, 31);
            this.Γ.TabIndex = 207;
            this.Γ.Text = "Γ";
            // 
            // Ζ
            // 
            this.Ζ.AutoSize = true;
            this.Ζ.BackColor = System.Drawing.Color.Transparent;
            this.Ζ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Ζ.ForeColor = System.Drawing.Color.White;
            this.Ζ.Location = new System.Drawing.Point(51, 296);
            this.Ζ.Name = "Ζ";
            this.Ζ.Size = new System.Drawing.Size(31, 31);
            this.Ζ.TabIndex = 210;
            this.Ζ.Text = "Ζ";
            // 
            // Ε
            // 
            this.Ε.AutoSize = true;
            this.Ε.BackColor = System.Drawing.Color.Transparent;
            this.Ε.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Ε.ForeColor = System.Drawing.Color.White;
            this.Ε.Location = new System.Drawing.Point(50, 259);
            this.Ε.Name = "Ε";
            this.Ε.Size = new System.Drawing.Size(32, 31);
            this.Ε.TabIndex = 209;
            this.Ε.Text = "Ε";
            // 
            // Θ
            // 
            this.Θ.AutoSize = true;
            this.Θ.BackColor = System.Drawing.Color.Transparent;
            this.Θ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Θ.ForeColor = System.Drawing.Color.White;
            this.Θ.Location = new System.Drawing.Point(51, 366);
            this.Θ.Name = "Θ";
            this.Θ.Size = new System.Drawing.Size(35, 31);
            this.Θ.TabIndex = 212;
            this.Θ.Text = "Θ";
            // 
            // Η
            // 
            this.Η.AutoSize = true;
            this.Η.BackColor = System.Drawing.Color.Transparent;
            this.Η.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Η.ForeColor = System.Drawing.Color.White;
            this.Η.Location = new System.Drawing.Point(52, 331);
            this.Η.Name = "Η";
            this.Η.Size = new System.Drawing.Size(34, 31);
            this.Η.TabIndex = 211;
            this.Η.Text = "Η";
            // 
            // Κ
            // 
            this.Κ.AutoSize = true;
            this.Κ.BackColor = System.Drawing.Color.Transparent;
            this.Κ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Κ.ForeColor = System.Drawing.Color.White;
            this.Κ.Location = new System.Drawing.Point(56, 441);
            this.Κ.Name = "Κ";
            this.Κ.Size = new System.Drawing.Size(32, 31);
            this.Κ.TabIndex = 214;
            this.Κ.Text = "Κ";
            // 
            // Ι
            // 
            this.Ι.AutoSize = true;
            this.Ι.BackColor = System.Drawing.Color.Transparent;
            this.Ι.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Ι.ForeColor = System.Drawing.Color.White;
            this.Ι.Location = new System.Drawing.Point(60, 403);
            this.Ι.Name = "Ι";
            this.Ι.Size = new System.Drawing.Size(22, 31);
            this.Ι.TabIndex = 213;
            this.Ι.Text = "Ι";
            // 
            // Κε
            // 
            this.Κε.AutoSize = true;
            this.Κε.BackColor = System.Drawing.Color.Transparent;
            this.Κε.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Κε.ForeColor = System.Drawing.Color.White;
            this.Κε.Location = new System.Drawing.Point(613, 440);
            this.Κε.Name = "Κε";
            this.Κε.Size = new System.Drawing.Size(32, 31);
            this.Κε.TabIndex = 223;
            this.Κε.Text = "Κ";
            // 
            // Ιε
            // 
            this.Ιε.AutoSize = true;
            this.Ιε.BackColor = System.Drawing.Color.Transparent;
            this.Ιε.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Ιε.ForeColor = System.Drawing.Color.White;
            this.Ιε.Location = new System.Drawing.Point(616, 402);
            this.Ιε.Name = "Ιε";
            this.Ιε.Size = new System.Drawing.Size(22, 31);
            this.Ιε.TabIndex = 222;
            this.Ιε.Text = "Ι";
            // 
            // Θε
            // 
            this.Θε.AutoSize = true;
            this.Θε.BackColor = System.Drawing.Color.Transparent;
            this.Θε.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Θε.ForeColor = System.Drawing.Color.White;
            this.Θε.Location = new System.Drawing.Point(608, 367);
            this.Θε.Name = "Θε";
            this.Θε.Size = new System.Drawing.Size(35, 31);
            this.Θε.TabIndex = 221;
            this.Θε.Text = "Θ";
            // 
            // Ηε
            // 
            this.Ηε.AutoSize = true;
            this.Ηε.BackColor = System.Drawing.Color.Transparent;
            this.Ηε.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Ηε.ForeColor = System.Drawing.Color.White;
            this.Ηε.Location = new System.Drawing.Point(607, 333);
            this.Ηε.Name = "Ηε";
            this.Ηε.Size = new System.Drawing.Size(34, 31);
            this.Ηε.TabIndex = 220;
            this.Ηε.Text = "Η";
            // 
            // Ζε
            // 
            this.Ζε.AutoSize = true;
            this.Ζε.BackColor = System.Drawing.Color.Transparent;
            this.Ζε.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Ζε.ForeColor = System.Drawing.Color.White;
            this.Ζε.Location = new System.Drawing.Point(607, 296);
            this.Ζε.Name = "Ζε";
            this.Ζε.Size = new System.Drawing.Size(31, 31);
            this.Ζε.TabIndex = 219;
            this.Ζε.Text = "Ζ";
            // 
            // Εε
            // 
            this.Εε.AutoSize = true;
            this.Εε.BackColor = System.Drawing.Color.Transparent;
            this.Εε.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Εε.ForeColor = System.Drawing.Color.White;
            this.Εε.Location = new System.Drawing.Point(606, 261);
            this.Εε.Name = "Εε";
            this.Εε.Size = new System.Drawing.Size(32, 31);
            this.Εε.TabIndex = 218;
            this.Εε.Text = "Ε";
            // 
            // Δε
            // 
            this.Δε.AutoSize = true;
            this.Δε.BackColor = System.Drawing.Color.Transparent;
            this.Δε.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Δε.ForeColor = System.Drawing.Color.White;
            this.Δε.Location = new System.Drawing.Point(607, 224);
            this.Δε.Name = "Δε";
            this.Δε.Size = new System.Drawing.Size(32, 31);
            this.Δε.TabIndex = 217;
            this.Δε.Text = "Δ";
            // 
            // Γε
            // 
            this.Γε.AutoSize = true;
            this.Γε.BackColor = System.Drawing.Color.Transparent;
            this.Γε.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Γε.ForeColor = System.Drawing.Color.White;
            this.Γε.Location = new System.Drawing.Point(608, 186);
            this.Γε.Name = "Γε";
            this.Γε.Size = new System.Drawing.Size(30, 31);
            this.Γε.TabIndex = 216;
            this.Γε.Text = "Γ";
            // 
            // Βε
            // 
            this.Βε.AutoSize = true;
            this.Βε.BackColor = System.Drawing.Color.Transparent;
            this.Βε.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Βε.ForeColor = System.Drawing.Color.White;
            this.Βε.Location = new System.Drawing.Point(607, 151);
            this.Βε.Name = "Βε";
            this.Βε.Size = new System.Drawing.Size(32, 31);
            this.Βε.TabIndex = 215;
            this.Βε.Text = "Β";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(97, 68);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(375, 31);
            this.l1.TabIndex = 224;
            this.l1.Text = "1    2   3   4   5   6   7   8   9   10";
            // 
            // l1e
            // 
            this.l1e.AutoSize = true;
            this.l1e.BackColor = System.Drawing.Color.Transparent;
            this.l1e.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.l1e.ForeColor = System.Drawing.Color.White;
            this.l1e.Location = new System.Drawing.Point(657, 68);
            this.l1e.Name = "l1e";
            this.l1e.Size = new System.Drawing.Size(368, 31);
            this.l1e.TabIndex = 234;
            this.l1e.Text = "1   2   3   4   5   6   7   8   9   10";
            // 
            // PlayerSea
            // 
            this.PlayerSea.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PlayerSea.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PlayerSea.ColumnCount = 10;
            this.PlayerSea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.PlayerSea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.PlayerSea.Location = new System.Drawing.Point(103, 111);
            this.PlayerSea.Name = "PlayerSea";
            this.PlayerSea.RowCount = 10;
            this.PlayerSea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PlayerSea.Size = new System.Drawing.Size(359, 360);
            this.PlayerSea.TabIndex = 245;
            this.PlayerSea.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // EnemySea
            // 
            this.EnemySea.BackColor = System.Drawing.Color.LightSkyBlue;
            this.EnemySea.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.EnemySea.ColumnCount = 10;
            this.EnemySea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.EnemySea.Location = new System.Drawing.Point(654, 111);
            this.EnemySea.Name = "EnemySea";
            this.EnemySea.RowCount = 10;
            this.EnemySea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.EnemySea.Size = new System.Drawing.Size(362, 360);
            this.EnemySea.TabIndex = 246;
            this.EnemySea.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // StartBTN
            // 
            this.StartBTN.BackColor = System.Drawing.Color.SpringGreen;
            this.StartBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StartBTN.Location = new System.Drawing.Point(325, 378);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(166, 82);
            this.StartBTN.TabIndex = 247;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = false;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Pplayerships
            // 
            this.Pplayerships.AutoSize = true;
            this.Pplayerships.BackColor = System.Drawing.Color.Transparent;
            this.Pplayerships.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Pplayerships.ForeColor = System.Drawing.Color.White;
            this.Pplayerships.Location = new System.Drawing.Point(12, 38);
            this.Pplayerships.Name = "Pplayerships";
            this.Pplayerships.Size = new System.Drawing.Size(183, 24);
            this.Pplayerships.TabIndex = 249;
            this.Pplayerships.Text = "Ally ships remaining:";
            // 
            // Eenemyships
            // 
            this.Eenemyships.AutoSize = true;
            this.Eenemyships.BackColor = System.Drawing.Color.Transparent;
            this.Eenemyships.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Eenemyships.ForeColor = System.Drawing.Color.White;
            this.Eenemyships.Location = new System.Drawing.Point(773, 35);
            this.Eenemyships.Name = "Eenemyships";
            this.Eenemyships.Size = new System.Drawing.Size(213, 24);
            this.Eenemyships.TabIndex = 250;
            this.Eenemyships.Text = "Enemy ships remaining:";
            // 
            // AttackBTN
            // 
            this.AttackBTN.BackColor = System.Drawing.Color.IndianRed;
            this.AttackBTN.Location = new System.Drawing.Point(487, 107);
            this.AttackBTN.Name = "AttackBTN";
            this.AttackBTN.Size = new System.Drawing.Size(117, 50);
            this.AttackBTN.TabIndex = 251;
            this.AttackBTN.Text = "Attack";
            this.AttackBTN.UseVisualStyleBackColor = false;
            this.AttackBTN.Click += new System.EventHandler(this.AttackBTN_Click);
            // 
            // Arow
            // 
            this.Arow.BackColor = System.Drawing.Color.Gray;
            this.Arow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Arow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Arow.Location = new System.Drawing.Point(152, 476);
            this.Arow.Name = "Arow";
            this.Arow.Size = new System.Drawing.Size(44, 40);
            this.Arow.TabIndex = 252;
            this.Arow.Text = "Α";
            this.Arow.UseVisualStyleBackColor = false;
            this.Arow.Click += new System.EventHandler(this.Arow_Click);
            // 
            // Brow
            // 
            this.Brow.BackColor = System.Drawing.Color.Gray;
            this.Brow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Brow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Brow.Location = new System.Drawing.Point(212, 476);
            this.Brow.Name = "Brow";
            this.Brow.Size = new System.Drawing.Size(44, 40);
            this.Brow.TabIndex = 253;
            this.Brow.Text = "Β";
            this.Brow.UseVisualStyleBackColor = false;
            this.Brow.Click += new System.EventHandler(this.Brow_Click);
            // 
            // Crow
            // 
            this.Crow.BackColor = System.Drawing.Color.Gray;
            this.Crow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Crow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Crow.Location = new System.Drawing.Point(271, 476);
            this.Crow.Name = "Crow";
            this.Crow.Size = new System.Drawing.Size(44, 40);
            this.Crow.TabIndex = 254;
            this.Crow.Text = "Γ";
            this.Crow.UseVisualStyleBackColor = false;
            this.Crow.Click += new System.EventHandler(this.Crow_Click);
            // 
            // Drow
            // 
            this.Drow.BackColor = System.Drawing.Color.Gray;
            this.Drow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Drow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Drow.Location = new System.Drawing.Point(330, 476);
            this.Drow.Name = "Drow";
            this.Drow.Size = new System.Drawing.Size(44, 40);
            this.Drow.TabIndex = 255;
            this.Drow.Text = "Δ";
            this.Drow.UseVisualStyleBackColor = false;
            this.Drow.Click += new System.EventHandler(this.Drow_Click);
            // 
            // Zrow
            // 
            this.Zrow.BackColor = System.Drawing.Color.Gray;
            this.Zrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Zrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Zrow.Location = new System.Drawing.Point(460, 476);
            this.Zrow.Name = "Zrow";
            this.Zrow.Size = new System.Drawing.Size(44, 40);
            this.Zrow.TabIndex = 256;
            this.Zrow.Text = "Ζ";
            this.Zrow.UseVisualStyleBackColor = false;
            this.Zrow.Click += new System.EventHandler(this.Zrow_Click);
            // 
            // Hrow
            // 
            this.Hrow.BackColor = System.Drawing.Color.Gray;
            this.Hrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Hrow.Location = new System.Drawing.Point(530, 476);
            this.Hrow.Name = "Hrow";
            this.Hrow.Size = new System.Drawing.Size(44, 40);
            this.Hrow.TabIndex = 257;
            this.Hrow.Text = "Η";
            this.Hrow.UseVisualStyleBackColor = false;
            this.Hrow.Click += new System.EventHandler(this.Hrow_Click);
            // 
            // Urow
            // 
            this.Urow.BackColor = System.Drawing.Color.Gray;
            this.Urow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Urow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Urow.Location = new System.Drawing.Point(600, 476);
            this.Urow.Name = "Urow";
            this.Urow.Size = new System.Drawing.Size(44, 40);
            this.Urow.TabIndex = 258;
            this.Urow.Text = "Θ";
            this.Urow.UseVisualStyleBackColor = false;
            this.Urow.Click += new System.EventHandler(this.Urow_Click);
            // 
            // Irow
            // 
            this.Irow.BackColor = System.Drawing.Color.Gray;
            this.Irow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Irow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Irow.Location = new System.Drawing.Point(664, 476);
            this.Irow.Name = "Irow";
            this.Irow.Size = new System.Drawing.Size(44, 40);
            this.Irow.TabIndex = 259;
            this.Irow.Text = "Ι";
            this.Irow.UseVisualStyleBackColor = false;
            this.Irow.Click += new System.EventHandler(this.Irow_Click);
            // 
            // Erow
            // 
            this.Erow.BackColor = System.Drawing.Color.Gray;
            this.Erow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Erow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Erow.Location = new System.Drawing.Point(397, 476);
            this.Erow.Name = "Erow";
            this.Erow.Size = new System.Drawing.Size(44, 40);
            this.Erow.TabIndex = 260;
            this.Erow.Text = "Ε";
            this.Erow.UseVisualStyleBackColor = false;
            this.Erow.Click += new System.EventHandler(this.Erow_Click);
            // 
            // Krow
            // 
            this.Krow.BackColor = System.Drawing.Color.Gray;
            this.Krow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Krow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Krow.Location = new System.Drawing.Point(723, 476);
            this.Krow.Name = "Krow";
            this.Krow.Size = new System.Drawing.Size(44, 40);
            this.Krow.TabIndex = 261;
            this.Krow.Text = "Κ";
            this.Krow.UseVisualStyleBackColor = false;
            this.Krow.Click += new System.EventHandler(this.Krow_Click);
            // 
            // Clm10
            // 
            this.Clm10.BackColor = System.Drawing.Color.Gray;
            this.Clm10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clm10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clm10.Location = new System.Drawing.Point(723, 522);
            this.Clm10.Name = "Clm10";
            this.Clm10.Size = new System.Drawing.Size(44, 40);
            this.Clm10.TabIndex = 271;
            this.Clm10.Text = "10";
            this.Clm10.UseVisualStyleBackColor = false;
            this.Clm10.Click += new System.EventHandler(this.Clm10_Click);
            // 
            // Clm5
            // 
            this.Clm5.BackColor = System.Drawing.Color.Gray;
            this.Clm5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clm5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clm5.Location = new System.Drawing.Point(397, 522);
            this.Clm5.Name = "Clm5";
            this.Clm5.Size = new System.Drawing.Size(44, 40);
            this.Clm5.TabIndex = 270;
            this.Clm5.Text = "5";
            this.Clm5.UseVisualStyleBackColor = false;
            this.Clm5.Click += new System.EventHandler(this.Clm5_Click);
            // 
            // Clm9
            // 
            this.Clm9.BackColor = System.Drawing.Color.Gray;
            this.Clm9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clm9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clm9.Location = new System.Drawing.Point(664, 522);
            this.Clm9.Name = "Clm9";
            this.Clm9.Size = new System.Drawing.Size(44, 40);
            this.Clm9.TabIndex = 269;
            this.Clm9.Text = "9";
            this.Clm9.UseVisualStyleBackColor = false;
            this.Clm9.Click += new System.EventHandler(this.Clm9_Click);
            // 
            // Clm8
            // 
            this.Clm8.BackColor = System.Drawing.Color.Gray;
            this.Clm8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clm8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clm8.Location = new System.Drawing.Point(600, 522);
            this.Clm8.Name = "Clm8";
            this.Clm8.Size = new System.Drawing.Size(44, 40);
            this.Clm8.TabIndex = 268;
            this.Clm8.Text = "8";
            this.Clm8.UseVisualStyleBackColor = false;
            this.Clm8.Click += new System.EventHandler(this.Clm8_Click);
            // 
            // Clm7
            // 
            this.Clm7.BackColor = System.Drawing.Color.Gray;
            this.Clm7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clm7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clm7.Location = new System.Drawing.Point(530, 522);
            this.Clm7.Name = "Clm7";
            this.Clm7.Size = new System.Drawing.Size(44, 40);
            this.Clm7.TabIndex = 267;
            this.Clm7.Text = "7";
            this.Clm7.UseVisualStyleBackColor = false;
            this.Clm7.Click += new System.EventHandler(this.Clm7_Click);
            // 
            // Clm6
            // 
            this.Clm6.BackColor = System.Drawing.Color.Gray;
            this.Clm6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clm6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clm6.Location = new System.Drawing.Point(460, 522);
            this.Clm6.Name = "Clm6";
            this.Clm6.Size = new System.Drawing.Size(44, 40);
            this.Clm6.TabIndex = 266;
            this.Clm6.Text = "6";
            this.Clm6.UseVisualStyleBackColor = false;
            this.Clm6.Click += new System.EventHandler(this.Clm6_Click);
            // 
            // Clm4
            // 
            this.Clm4.BackColor = System.Drawing.Color.Gray;
            this.Clm4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clm4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clm4.Location = new System.Drawing.Point(330, 522);
            this.Clm4.Name = "Clm4";
            this.Clm4.Size = new System.Drawing.Size(44, 40);
            this.Clm4.TabIndex = 265;
            this.Clm4.Text = "4";
            this.Clm4.UseVisualStyleBackColor = false;
            this.Clm4.Click += new System.EventHandler(this.Clm4_Click);
            // 
            // Clm3
            // 
            this.Clm3.BackColor = System.Drawing.Color.Gray;
            this.Clm3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clm3.Location = new System.Drawing.Point(271, 522);
            this.Clm3.Name = "Clm3";
            this.Clm3.Size = new System.Drawing.Size(44, 40);
            this.Clm3.TabIndex = 264;
            this.Clm3.Text = "3";
            this.Clm3.UseVisualStyleBackColor = false;
            this.Clm3.Click += new System.EventHandler(this.Clm3_Click);
            // 
            // Clm2
            // 
            this.Clm2.BackColor = System.Drawing.Color.Gray;
            this.Clm2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clm2.Location = new System.Drawing.Point(212, 522);
            this.Clm2.Name = "Clm2";
            this.Clm2.Size = new System.Drawing.Size(44, 40);
            this.Clm2.TabIndex = 263;
            this.Clm2.Text = "2";
            this.Clm2.UseVisualStyleBackColor = false;
            this.Clm2.Click += new System.EventHandler(this.Clm2_Click);
            // 
            // Clm1
            // 
            this.Clm1.BackColor = System.Drawing.Color.Gray;
            this.Clm1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clm1.Location = new System.Drawing.Point(152, 522);
            this.Clm1.Name = "Clm1";
            this.Clm1.Size = new System.Drawing.Size(44, 40);
            this.Clm1.TabIndex = 262;
            this.Clm1.Text = "1";
            this.Clm1.UseVisualStyleBackColor = false;
            this.Clm1.Click += new System.EventHandler(this.Clm1_Click);
            // 
            // lblYpo
            // 
            this.lblYpo.AutoSize = true;
            this.lblYpo.BackColor = System.Drawing.Color.OliveDrab;
            this.lblYpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblYpo.ForeColor = System.Drawing.Color.White;
            this.lblYpo.Location = new System.Drawing.Point(14, 486);
            this.lblYpo.Name = "lblYpo";
            this.lblYpo.Size = new System.Drawing.Size(121, 20);
            this.lblYpo.TabIndex = 272;
            this.lblYpo.Text = "Ypobruxio: Alive";
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.BackColor = System.Drawing.Color.OliveDrab;
            this.lblPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPol.ForeColor = System.Drawing.Color.White;
            this.lblPol.Location = new System.Drawing.Point(15, 510);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(114, 20);
            this.lblPol.TabIndex = 273;
            this.lblPol.Text = "Polemiko: Alive";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.BackColor = System.Drawing.Color.OliveDrab;
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAdi.ForeColor = System.Drawing.Color.White;
            this.lblAdi.Location = new System.Drawing.Point(15, 532);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(127, 20);
            this.lblAdi.TabIndex = 274;
            this.lblAdi.Text = "Aditorpiliko: Alive";
            // 
            // lblAer
            // 
            this.lblAer.AutoSize = true;
            this.lblAer.BackColor = System.Drawing.Color.OliveDrab;
            this.lblAer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAer.ForeColor = System.Drawing.Color.White;
            this.lblAer.Location = new System.Drawing.Point(15, 555);
            this.lblAer.Name = "lblAer";
            this.lblAer.Size = new System.Drawing.Size(151, 20);
            this.lblAer.TabIndex = 275;
            this.lblAer.Text = "Aeroplanoforo: Alive";
            // 
            // lblAerE
            // 
            this.lblAerE.AutoSize = true;
            this.lblAerE.BackColor = System.Drawing.Color.DarkRed;
            this.lblAerE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAerE.ForeColor = System.Drawing.Color.White;
            this.lblAerE.Location = new System.Drawing.Point(758, 555);
            this.lblAerE.Name = "lblAerE";
            this.lblAerE.Size = new System.Drawing.Size(204, 20);
            this.lblAerE.TabIndex = 279;
            this.lblAerE.Text = "Enemy Aeroplanoforo: Alive";
            // 
            // lblAdiE
            // 
            this.lblAdiE.AutoSize = true;
            this.lblAdiE.BackColor = System.Drawing.Color.DarkRed;
            this.lblAdiE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAdiE.ForeColor = System.Drawing.Color.White;
            this.lblAdiE.Location = new System.Drawing.Point(758, 532);
            this.lblAdiE.Name = "lblAdiE";
            this.lblAdiE.Size = new System.Drawing.Size(180, 20);
            this.lblAdiE.TabIndex = 278;
            this.lblAdiE.Text = "Enemy Aditorpiliko: Alive";
            // 
            // lblPolE
            // 
            this.lblPolE.AutoSize = true;
            this.lblPolE.BackColor = System.Drawing.Color.DarkRed;
            this.lblPolE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPolE.ForeColor = System.Drawing.Color.White;
            this.lblPolE.Location = new System.Drawing.Point(758, 510);
            this.lblPolE.Name = "lblPolE";
            this.lblPolE.Size = new System.Drawing.Size(167, 20);
            this.lblPolE.TabIndex = 277;
            this.lblPolE.Text = "Enemy Polemiko: Alive";
            // 
            // lblYpoE
            // 
            this.lblYpoE.AutoSize = true;
            this.lblYpoE.BackColor = System.Drawing.Color.DarkRed;
            this.lblYpoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblYpoE.ForeColor = System.Drawing.Color.White;
            this.lblYpoE.Location = new System.Drawing.Point(757, 486);
            this.lblYpoE.Name = "lblYpoE";
            this.lblYpoE.Size = new System.Drawing.Size(174, 20);
            this.lblYpoE.TabIndex = 276;
            this.lblYpoE.Text = "Enemy Ypobruxio: Alive";
            // 
            // Announce
            // 
            this.Announce.AutoSize = true;
            this.Announce.BackColor = System.Drawing.Color.Yellow;
            this.Announce.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Announce.Location = new System.Drawing.Point(500, 50);
            this.Announce.Name = "Announce";
            this.Announce.Size = new System.Drawing.Size(100, 37);
            this.Announce.TabIndex = 280;
            this.Announce.Text = "label1";
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.BackColor = System.Drawing.Color.NavajoWhite;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Save.Location = new System.Drawing.Point(874, 6);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(57, 24);
            this.Save.TabIndex = 281;
            this.Save.Text = "Save ";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 20);
            this.textBox1.TabIndex = 282;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 367);
            this.dataGridView1.TabIndex = 283;
            // 
            // Stats
            // 
            this.Stats.AutoSize = true;
            this.Stats.BackColor = System.Drawing.Color.NavajoWhite;
            this.Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Stats.Location = new System.Drawing.Point(937, 6);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(49, 24);
            this.Stats.TabIndex = 284;
            this.Stats.Text = "Stats";
            this.Stats.Click += new System.EventHandler(this.Stats_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.NavajoWhite;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Exit.Location = new System.Drawing.Point(1005, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 24);
            this.Exit.TabIndex = 285;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.BackColor = System.Drawing.Color.Yellow;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Return.Location = new System.Drawing.Point(464, 5);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(163, 25);
            this.Return.TabIndex = 286;
            this.Return.Text = "Return to Game";
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Naumaxia.Properties.Resources.StormySea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 611);
            this.ControlBox = false;
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Announce);
            this.Controls.Add(this.lblAerE);
            this.Controls.Add(this.lblAdiE);
            this.Controls.Add(this.lblPolE);
            this.Controls.Add(this.lblYpoE);
            this.Controls.Add(this.lblAer);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.lblYpo);
            this.Controls.Add(this.Clm10);
            this.Controls.Add(this.Clm5);
            this.Controls.Add(this.Clm9);
            this.Controls.Add(this.Clm8);
            this.Controls.Add(this.Clm7);
            this.Controls.Add(this.Clm6);
            this.Controls.Add(this.Clm4);
            this.Controls.Add(this.Clm3);
            this.Controls.Add(this.Clm2);
            this.Controls.Add(this.Clm1);
            this.Controls.Add(this.Krow);
            this.Controls.Add(this.Erow);
            this.Controls.Add(this.Irow);
            this.Controls.Add(this.Urow);
            this.Controls.Add(this.Hrow);
            this.Controls.Add(this.Zrow);
            this.Controls.Add(this.Drow);
            this.Controls.Add(this.Crow);
            this.Controls.Add(this.Brow);
            this.Controls.Add(this.Arow);
            this.Controls.Add(this.AttackBTN);
            this.Controls.Add(this.Eenemyships);
            this.Controls.Add(this.Pplayerships);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.EnemySea);
            this.Controls.Add(this.PlayerSea);
            this.Controls.Add(this.l1e);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.Κε);
            this.Controls.Add(this.Ιε);
            this.Controls.Add(this.Θε);
            this.Controls.Add(this.Ηε);
            this.Controls.Add(this.Ζε);
            this.Controls.Add(this.Εε);
            this.Controls.Add(this.Δε);
            this.Controls.Add(this.Γε);
            this.Controls.Add(this.Βε);
            this.Controls.Add(this.Κ);
            this.Controls.Add(this.Ι);
            this.Controls.Add(this.Θ);
            this.Controls.Add(this.Η);
            this.Controls.Add(this.Ζ);
            this.Controls.Add(this.Ε);
            this.Controls.Add(this.Δ);
            this.Controls.Add(this.Γ);
            this.Controls.Add(this.Β);
            this.Controls.Add(this.Αε);
            this.Controls.Add(this.Α);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Rounds);
            this.Controls.Add(this.EnemyLabel);
            this.Controls.Add(this.PlayerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battleship Game";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button64_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Enemy(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void G_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void A_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label EnemyLabel;
        private System.Windows.Forms.Label Rounds;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Α;
        private System.Windows.Forms.Label Αε;
        private System.Windows.Forms.Label Β;
        private System.Windows.Forms.Label Δ;
        private System.Windows.Forms.Label Γ;
        private System.Windows.Forms.Label Ζ;
        private System.Windows.Forms.Label Ε;
        private System.Windows.Forms.Label Θ;
        private System.Windows.Forms.Label Η;
        private System.Windows.Forms.Label Κ;
        private System.Windows.Forms.Label Ι;
        private System.Windows.Forms.Label Κε;
        private System.Windows.Forms.Label Ιε;
        private System.Windows.Forms.Label Θε;
        private System.Windows.Forms.Label Ηε;
        private System.Windows.Forms.Label Ζε;
        private System.Windows.Forms.Label Εε;
        private System.Windows.Forms.Label Δε;
        private System.Windows.Forms.Label Γε;
        private System.Windows.Forms.Label Βε;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l1e;
        private System.Windows.Forms.Button StartBTN;
        public System.Windows.Forms.TableLayoutPanel PlayerSea;
        public System.Windows.Forms.TableLayoutPanel EnemySea;
        private System.Windows.Forms.Label ExitBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label Pplayerships;
        private System.Windows.Forms.Label Eenemyships;
        private System.Windows.Forms.Button AttackBTN;
        private System.Windows.Forms.Button Arow;
        private System.Windows.Forms.Button Brow;
        private System.Windows.Forms.Button Crow;
        private System.Windows.Forms.Button Drow;
        private System.Windows.Forms.Button Zrow;
        private System.Windows.Forms.Button Hrow;
        private System.Windows.Forms.Button Urow;
        private System.Windows.Forms.Button Irow;
        private System.Windows.Forms.Button Erow;
        private System.Windows.Forms.Button Krow;
        private System.Windows.Forms.Button Clm10;
        private System.Windows.Forms.Button Clm5;
        private System.Windows.Forms.Button Clm9;
        private System.Windows.Forms.Button Clm8;
        private System.Windows.Forms.Button Clm7;
        private System.Windows.Forms.Button Clm6;
        private System.Windows.Forms.Button Clm4;
        private System.Windows.Forms.Button Clm3;
        private System.Windows.Forms.Button Clm2;
        private System.Windows.Forms.Button Clm1;
        private System.Windows.Forms.Label lblYpo;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblAer;
        private System.Windows.Forms.Label lblAerE;
        private System.Windows.Forms.Label lblAdiE;
        private System.Windows.Forms.Label lblPolE;
        private System.Windows.Forms.Label lblYpoE;
        private System.Windows.Forms.Label Announce;
        private System.Windows.Forms.Label Save;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Stats;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Return;
    }
}

