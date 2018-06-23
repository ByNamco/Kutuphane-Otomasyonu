namespace KutuphaneOtomasyonu
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.lbybaslik = new System.Windows.Forms.Label();
            this.baslik = new System.Windows.Forms.Timer(this.components);
            this.saattarih = new System.Windows.Forms.Timer(this.components);
            this.toolstrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbltarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblsaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblkoordinat = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblkitapsayi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbluyesayi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsanasayfa = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.üyeListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kütüphaneListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayıneviListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağışListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.kitapİstatistiğiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeİstatistiğiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kütüphaneİstatistiğiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnhatirlat = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnteslimkatirlat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.kitapTurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapYeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meslekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenimDurumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniYılToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.timerhatirlatma = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnyenikullanici = new System.Windows.Forms.Button();
            this.btnkitapal = new System.Windows.Forms.Button();
            this.btnkitapver = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnyazarekle = new System.Windows.Forms.Button();
            this.btnyayineviekle = new System.Windows.Forms.Button();
            this.btnpersonelekle = new System.Windows.Forms.Button();
            this.btnkutuphaneekle = new System.Windows.Forms.Button();
            this.btnuyeekle = new System.Windows.Forms.Button();
            this.btnkitapekle = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolstrip.SuspendLayout();
            this.tsanasayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbybaslik
            // 
            this.lbybaslik.AutoSize = true;
            this.lbybaslik.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbybaslik.ForeColor = System.Drawing.Color.Blue;
            this.lbybaslik.Location = new System.Drawing.Point(413, 58);
            this.lbybaslik.Name = "lbybaslik";
            this.lbybaslik.Size = new System.Drawing.Size(64, 22);
            this.lbybaslik.TabIndex = 20;
            this.lbybaslik.Text = "Baslik";
            // 
            // baslik
            // 
            this.baslik.Tick += new System.EventHandler(this.baslik_Tick);
            // 
            // saattarih
            // 
            this.saattarih.Tick += new System.EventHandler(this.saattarih_Tick);
            // 
            // toolstrip
            // 
            this.toolstrip.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4,
            this.lbltarih,
            this.toolStripStatusLabel2,
            this.lblsaat,
            this.lblkoordinat,
            this.toolStripStatusLabel8,
            this.lblkitapsayi,
            this.toolStripStatusLabel6,
            this.lbluyesayi});
            this.toolstrip.Location = new System.Drawing.Point(0, 669);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.toolstrip.Size = new System.Drawing.Size(1080, 24);
            this.toolstrip.TabIndex = 23;
            this.toolstrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(97, 19);
            this.toolStripStatusLabel3.Text = "Aktif Kullanıcı:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 19);
            this.toolStripStatusLabel1.Text = "Mustafa";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(46, 19);
            this.toolStripStatusLabel4.Text = "Tarih :";
            // 
            // lbltarih
            // 
            this.lbltarih.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbltarih.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbltarih.ForeColor = System.Drawing.Color.Blue;
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(41, 19);
            this.lbltarih.Text = "tarih";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(40, 19);
            this.toolStripStatusLabel2.Text = "Saat :";
            // 
            // lblsaat
            // 
            this.lblsaat.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblsaat.ForeColor = System.Drawing.Color.Blue;
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(32, 19);
            this.lblsaat.Text = "saat";
            // 
            // lblkoordinat
            // 
            this.lblkoordinat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblkoordinat.ForeColor = System.Drawing.Color.Blue;
            this.lblkoordinat.Name = "lblkoordinat";
            this.lblkoordinat.Size = new System.Drawing.Size(438, 19);
            this.lblkoordinat.Spring = true;
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(133, 19);
            this.toolStripStatusLabel8.Text = "Toplam Kitap Sayısı :";
            // 
            // lblkitapsayi
            // 
            this.lblkitapsayi.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblkitapsayi.ForeColor = System.Drawing.Color.Blue;
            this.lblkitapsayi.Name = "lblkitapsayi";
            this.lblkitapsayi.Size = new System.Drawing.Size(30, 19);
            this.lblkitapsayi.Text = "tks";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(123, 19);
            this.toolStripStatusLabel6.Text = "Toplam Üye Sayısı :";
            // 
            // lbluyesayi
            // 
            this.lbluyesayi.ForeColor = System.Drawing.Color.Blue;
            this.lbluyesayi.Name = "lbluyesayi";
            this.lbluyesayi.Size = new System.Drawing.Size(26, 19);
            this.lbluyesayi.Text = "tüs";
            // 
            // tsanasayfa
            // 
            this.tsanasayfa.BackColor = System.Drawing.Color.White;
            this.tsanasayfa.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsanasayfa.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsanasayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton3,
            this.btnhatirlat,
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.tsanasayfa.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsanasayfa.Location = new System.Drawing.Point(0, 0);
            this.tsanasayfa.Name = "tsanasayfa";
            this.tsanasayfa.Size = new System.Drawing.Size(1080, 25);
            this.tsanasayfa.TabIndex = 25;
            this.tsanasayfa.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::KutuphaneOtomasyonu.Properties.Resources.library__2_;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton2";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeListesiToolStripMenuItem,
            this.kitapListesiToolStripMenuItem,
            this.kütüphaneListesiToolStripMenuItem,
            this.personelListesiToolStripMenuItem,
            this.yayıneviListesiToolStripMenuItem,
            this.yazarListesiToolStripMenuItem,
            this.bağışListesiToolStripMenuItem});
            this.toolStripDropDownButton4.ForeColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(164, 22);
            this.toolStripDropDownButton4.Text = "---------Listeler---------";
            this.toolStripDropDownButton4.ToolTipText = "Listeler";
            // 
            // üyeListesiToolStripMenuItem
            // 
            this.üyeListesiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.üyeListesiToolStripMenuItem.Name = "üyeListesiToolStripMenuItem";
            this.üyeListesiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.üyeListesiToolStripMenuItem.Text = "Üye Listesi";
            this.üyeListesiToolStripMenuItem.Click += new System.EventHandler(this.üyeListesiToolStripMenuItem_Click);
            // 
            // kitapListesiToolStripMenuItem
            // 
            this.kitapListesiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.kitapListesiToolStripMenuItem.Name = "kitapListesiToolStripMenuItem";
            this.kitapListesiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.kitapListesiToolStripMenuItem.Text = "Kitap Listesi";
            this.kitapListesiToolStripMenuItem.Click += new System.EventHandler(this.kitapListesiToolStripMenuItem_Click);
            // 
            // kütüphaneListesiToolStripMenuItem
            // 
            this.kütüphaneListesiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.kütüphaneListesiToolStripMenuItem.Name = "kütüphaneListesiToolStripMenuItem";
            this.kütüphaneListesiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.kütüphaneListesiToolStripMenuItem.Text = "Kütüphane Listesi";
            this.kütüphaneListesiToolStripMenuItem.Click += new System.EventHandler(this.kütüphaneListesiToolStripMenuItem_Click);
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            this.personelListesiToolStripMenuItem.Click += new System.EventHandler(this.personelListesiToolStripMenuItem_Click);
            // 
            // yayıneviListesiToolStripMenuItem
            // 
            this.yayıneviListesiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.yayıneviListesiToolStripMenuItem.Name = "yayıneviListesiToolStripMenuItem";
            this.yayıneviListesiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.yayıneviListesiToolStripMenuItem.Text = "Yayınevi Listesi";
            this.yayıneviListesiToolStripMenuItem.Click += new System.EventHandler(this.yayıneviListesiToolStripMenuItem_Click);
            // 
            // yazarListesiToolStripMenuItem
            // 
            this.yazarListesiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.yazarListesiToolStripMenuItem.Name = "yazarListesiToolStripMenuItem";
            this.yazarListesiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.yazarListesiToolStripMenuItem.Text = "Yazar Listesi";
            this.yazarListesiToolStripMenuItem.Click += new System.EventHandler(this.yazarListesiToolStripMenuItem_Click);
            // 
            // bağışListesiToolStripMenuItem
            // 
            this.bağışListesiToolStripMenuItem.Name = "bağışListesiToolStripMenuItem";
            this.bağışListesiToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.bağışListesiToolStripMenuItem.Text = "Bağış Listesi";
            this.bağışListesiToolStripMenuItem.Click += new System.EventHandler(this.bağışListesiToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapİstatistiğiToolStripMenuItem,
            this.üyeİstatistiğiToolStripMenuItem,
            this.kütüphaneİstatistiğiToolStripMenuItem});
            this.toolStripDropDownButton3.ForeColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(192, 22);
            this.toolStripDropDownButton3.Text = "---------İstatistikler---------";
            this.toolStripDropDownButton3.ToolTipText = "İstatistikler";
            // 
            // kitapİstatistiğiToolStripMenuItem
            // 
            this.kitapİstatistiğiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.kitapİstatistiğiToolStripMenuItem.Name = "kitapİstatistiğiToolStripMenuItem";
            this.kitapİstatistiğiToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.kitapİstatistiğiToolStripMenuItem.Text = "Kitap İstatistiği";
            this.kitapİstatistiğiToolStripMenuItem.Click += new System.EventHandler(this.kitapİstatistiğiToolStripMenuItem_Click);
            // 
            // üyeİstatistiğiToolStripMenuItem
            // 
            this.üyeİstatistiğiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.üyeİstatistiğiToolStripMenuItem.Name = "üyeİstatistiğiToolStripMenuItem";
            this.üyeİstatistiğiToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.üyeİstatistiğiToolStripMenuItem.Text = "Üye İstatistiği";
            this.üyeİstatistiğiToolStripMenuItem.Click += new System.EventHandler(this.üyeİstatistiğiToolStripMenuItem_Click);
            // 
            // kütüphaneİstatistiğiToolStripMenuItem
            // 
            this.kütüphaneİstatistiğiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.kütüphaneİstatistiğiToolStripMenuItem.Name = "kütüphaneİstatistiğiToolStripMenuItem";
            this.kütüphaneİstatistiğiToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.kütüphaneİstatistiğiToolStripMenuItem.Text = "Kütüphane İstatistiği";
            this.kütüphaneİstatistiğiToolStripMenuItem.Click += new System.EventHandler(this.kütüphaneİstatistiğiToolStripMenuItem_Click);
            // 
            // btnhatirlat
            // 
            this.btnhatirlat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnhatirlat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnteslimkatirlat});
            this.btnhatirlat.ForeColor = System.Drawing.Color.Black;
            this.btnhatirlat.Name = "btnhatirlat";
            this.btnhatirlat.Size = new System.Drawing.Size(250, 22);
            this.btnhatirlat.Text = "----------Hatırlatma Sistemi----------";
            this.btnhatirlat.ToolTipText = "Hatırlatma Sistemi";
            // 
            // btnteslimkatirlat
            // 
            this.btnteslimkatirlat.ForeColor = System.Drawing.Color.Black;
            this.btnteslimkatirlat.Name = "btnteslimkatirlat";
            this.btnteslimkatirlat.Size = new System.Drawing.Size(244, 22);
            this.btnteslimkatirlat.Text = "Kitap Teslim Hatırlatma";
            this.btnteslimkatirlat.Click += new System.EventHandler(this.btnteslimkatirlat_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapTurToolStripMenuItem,
            this.kitapYeriToolStripMenuItem,
            this.görevToolStripMenuItem,
            this.meslekToolStripMenuItem,
            this.öğrenimDurumToolStripMenuItem,
            this.dilToolStripMenuItem,
            this.yeniYılToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(214, 22);
            this.toolStripDropDownButton1.Text = "----------Parametreler----------";
            this.toolStripDropDownButton1.ToolTipText = "Parametreler";
            // 
            // kitapTurToolStripMenuItem
            // 
            this.kitapTurToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.kitapTurToolStripMenuItem.Name = "kitapTurToolStripMenuItem";
            this.kitapTurToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.kitapTurToolStripMenuItem.Text = "Kitap Tür";
            this.kitapTurToolStripMenuItem.Click += new System.EventHandler(this.kitapTurToolStripMenuItem_Click);
            // 
            // kitapYeriToolStripMenuItem
            // 
            this.kitapYeriToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.kitapYeriToolStripMenuItem.Name = "kitapYeriToolStripMenuItem";
            this.kitapYeriToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.kitapYeriToolStripMenuItem.Text = "Kitap Yeri";
            this.kitapYeriToolStripMenuItem.Click += new System.EventHandler(this.kitapYeriToolStripMenuItem_Click);
            // 
            // görevToolStripMenuItem
            // 
            this.görevToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.görevToolStripMenuItem.Name = "görevToolStripMenuItem";
            this.görevToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.görevToolStripMenuItem.Text = "Görev";
            this.görevToolStripMenuItem.Click += new System.EventHandler(this.görevToolStripMenuItem_Click);
            // 
            // meslekToolStripMenuItem
            // 
            this.meslekToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.meslekToolStripMenuItem.Name = "meslekToolStripMenuItem";
            this.meslekToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.meslekToolStripMenuItem.Text = "Meslek";
            this.meslekToolStripMenuItem.Click += new System.EventHandler(this.meslekToolStripMenuItem_Click);
            // 
            // öğrenimDurumToolStripMenuItem
            // 
            this.öğrenimDurumToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.öğrenimDurumToolStripMenuItem.Name = "öğrenimDurumToolStripMenuItem";
            this.öğrenimDurumToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.öğrenimDurumToolStripMenuItem.Text = "Öğrenim Durum";
            this.öğrenimDurumToolStripMenuItem.Click += new System.EventHandler(this.öğrenimDurumToolStripMenuItem_Click);
            // 
            // dilToolStripMenuItem
            // 
            this.dilToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.dilToolStripMenuItem.Name = "dilToolStripMenuItem";
            this.dilToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.dilToolStripMenuItem.Text = "Dil";
            this.dilToolStripMenuItem.Click += new System.EventHandler(this.dilToolStripMenuItem_Click);
            // 
            // yeniYılToolStripMenuItem
            // 
            this.yeniYılToolStripMenuItem.Name = "yeniYılToolStripMenuItem";
            this.yeniYılToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.yeniYılToolStripMenuItem.Text = "Yeni Yıl";
            this.yeniYılToolStripMenuItem.Click += new System.EventHandler(this.yeniYılToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(196, 22);
            this.toolStripButton1.Text = "----------Hakkımızda----------";
            this.toolStripButton1.ToolTipText = "Hakkımızda";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::KutuphaneOtomasyonu.Properties.Resources.library__2_;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // timerhatirlatma
            // 
            this.timerhatirlatma.Tick += new System.EventHandler(this.timerhatirlatma_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Image = global::KutuphaneOtomasyonu.Properties.Resources.email;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(882, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 52);
            this.button1.TabIndex = 29;
            this.button1.Text = "Kitap Teslim \r\nMaili Gönder";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnyenikullanici
            // 
            this.btnyenikullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnyenikullanici.Enabled = false;
            this.btnyenikullanici.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyenikullanici.ForeColor = System.Drawing.Color.Blue;
            this.btnyenikullanici.Image = global::KutuphaneOtomasyonu.Properties.Resources.Actions_user_group_new_icon11;
            this.btnyenikullanici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenikullanici.Location = new System.Drawing.Point(160, 581);
            this.btnyenikullanici.Name = "btnyenikullanici";
            this.btnyenikullanici.Size = new System.Drawing.Size(150, 52);
            this.btnyenikullanici.TabIndex = 28;
            this.btnyenikullanici.Text = "       Yeni Kullanıcı";
            this.btnyenikullanici.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnyenikullanici.UseVisualStyleBackColor = true;
            this.btnyenikullanici.Click += new System.EventHandler(this.btnyenikullanici_Click);
            // 
            // btnkitapal
            // 
            this.btnkitapal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnkitapal.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkitapal.ForeColor = System.Drawing.Color.Blue;
            this.btnkitapal.Image = global::KutuphaneOtomasyonu.Properties.Resources.Yeni_Resim__1_;
            this.btnkitapal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkitapal.Location = new System.Drawing.Point(882, 265);
            this.btnkitapal.Name = "btnkitapal";
            this.btnkitapal.Size = new System.Drawing.Size(178, 52);
            this.btnkitapal.TabIndex = 27;
            this.btnkitapal.Text = "Kitap                  Alma";
            this.btnkitapal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkitapal.UseVisualStyleBackColor = true;
            this.btnkitapal.Click += new System.EventHandler(this.btnkitapal_Click);
            // 
            // btnkitapver
            // 
            this.btnkitapver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnkitapver.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkitapver.ForeColor = System.Drawing.Color.Blue;
            this.btnkitapver.Image = global::KutuphaneOtomasyonu.Properties.Resources.Yeni_Resim;
            this.btnkitapver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkitapver.Location = new System.Drawing.Point(882, 107);
            this.btnkitapver.Name = "btnkitapver";
            this.btnkitapver.Size = new System.Drawing.Size(178, 52);
            this.btnkitapver.TabIndex = 26;
            this.btnkitapver.Text = "Kitap                 Verme";
            this.btnkitapver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkitapver.UseVisualStyleBackColor = true;
            this.btnkitapver.Click += new System.EventHandler(this.btnkitapver_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncikis.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.ForeColor = System.Drawing.Color.Blue;
            this.btncikis.Image = global::KutuphaneOtomasyonu.Properties.Resources.exit;
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.Location = new System.Drawing.Point(882, 581);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(178, 52);
            this.btncikis.TabIndex = 24;
            this.btncikis.Text = "ÇIKIŞ        ";
            this.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnyazarekle
            // 
            this.btnyazarekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnyazarekle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyazarekle.ForeColor = System.Drawing.Color.Blue;
            this.btnyazarekle.Image = global::KutuphaneOtomasyonu.Properties.Resources.stock_vector__Hand_writing_in_style_of_an_ancient_engraving;
            this.btnyazarekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyazarekle.Location = new System.Drawing.Point(84, 502);
            this.btnyazarekle.Name = "btnyazarekle";
            this.btnyazarekle.Size = new System.Drawing.Size(150, 52);
            this.btnyazarekle.TabIndex = 19;
            this.btnyazarekle.Text = "Yazar          İşlem";
            this.btnyazarekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnyazarekle.UseVisualStyleBackColor = true;
            this.btnyazarekle.Click += new System.EventHandler(this.btnyazarekle_Click);
            // 
            // btnyayineviekle
            // 
            this.btnyayineviekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnyayineviekle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyayineviekle.ForeColor = System.Drawing.Color.Blue;
            this.btnyayineviekle.Image = global::KutuphaneOtomasyonu.Properties.Resources.Old_House_icon;
            this.btnyayineviekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyayineviekle.Location = new System.Drawing.Point(29, 423);
            this.btnyayineviekle.Name = "btnyayineviekle";
            this.btnyayineviekle.Size = new System.Drawing.Size(150, 52);
            this.btnyayineviekle.TabIndex = 18;
            this.btnyayineviekle.Text = "Yayınevi     İşlem";
            this.btnyayineviekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnyayineviekle.UseVisualStyleBackColor = true;
            this.btnyayineviekle.Click += new System.EventHandler(this.btnyayineviekle_Click);
            // 
            // btnpersonelekle
            // 
            this.btnpersonelekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnpersonelekle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpersonelekle.ForeColor = System.Drawing.Color.Blue;
            this.btnpersonelekle.Image = global::KutuphaneOtomasyonu.Properties.Resources.personel;
            this.btnpersonelekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpersonelekle.Location = new System.Drawing.Point(6, 344);
            this.btnpersonelekle.Name = "btnpersonelekle";
            this.btnpersonelekle.Size = new System.Drawing.Size(150, 52);
            this.btnpersonelekle.TabIndex = 17;
            this.btnpersonelekle.Text = "Personel      İşlem";
            this.btnpersonelekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpersonelekle.UseVisualStyleBackColor = true;
            this.btnpersonelekle.Click += new System.EventHandler(this.btnpersonelekle_Click);
            // 
            // btnkutuphaneekle
            // 
            this.btnkutuphaneekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnkutuphaneekle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkutuphaneekle.ForeColor = System.Drawing.Color.Blue;
            this.btnkutuphaneekle.Image = global::KutuphaneOtomasyonu.Properties.Resources._3_gray_home_icon;
            this.btnkutuphaneekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkutuphaneekle.Location = new System.Drawing.Point(29, 265);
            this.btnkutuphaneekle.Name = "btnkutuphaneekle";
            this.btnkutuphaneekle.Size = new System.Drawing.Size(150, 52);
            this.btnkutuphaneekle.TabIndex = 16;
            this.btnkutuphaneekle.Text = "Kütüphane İşlem";
            this.btnkutuphaneekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkutuphaneekle.UseVisualStyleBackColor = true;
            this.btnkutuphaneekle.Click += new System.EventHandler(this.btnkutuphaneekle_Click);
            // 
            // btnuyeekle
            // 
            this.btnuyeekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnuyeekle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuyeekle.ForeColor = System.Drawing.Color.Blue;
            this.btnuyeekle.Image = global::KutuphaneOtomasyonu.Properties.Resources.Users_2;
            this.btnuyeekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuyeekle.Location = new System.Drawing.Point(84, 186);
            this.btnuyeekle.Name = "btnuyeekle";
            this.btnuyeekle.Size = new System.Drawing.Size(150, 52);
            this.btnuyeekle.TabIndex = 15;
            this.btnuyeekle.Text = "Üye             İşlem";
            this.btnuyeekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnuyeekle.UseVisualStyleBackColor = true;
            this.btnuyeekle.Click += new System.EventHandler(this.btnuyeekle_Click);
            // 
            // btnkitapekle
            // 
            this.btnkitapekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnkitapekle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkitapekle.ForeColor = System.Drawing.Color.Blue;
            this.btnkitapekle.Image = global::KutuphaneOtomasyonu.Properties.Resources.kitap;
            this.btnkitapekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkitapekle.Location = new System.Drawing.Point(159, 107);
            this.btnkitapekle.Name = "btnkitapekle";
            this.btnkitapekle.Size = new System.Drawing.Size(150, 52);
            this.btnkitapekle.TabIndex = 14;
            this.btnkitapekle.Text = "Kitap             İşlem";
            this.btnkitapekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkitapekle.UseVisualStyleBackColor = true;
            this.btnkitapekle.Click += new System.EventHandler(this.btnkitapekle_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.eski_kitap_69914;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Location = new System.Drawing.Point(183, 52);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(800, 600);
            this.PictureBox1.TabIndex = 7;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 693);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnyenikullanici);
            this.Controls.Add(this.btnkitapal);
            this.Controls.Add(this.btnkitapver);
            this.Controls.Add(this.tsanasayfa);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.toolstrip);
            this.Controls.Add(this.lbybaslik);
            this.Controls.Add(this.btnyazarekle);
            this.Controls.Add(this.btnyayineviekle);
            this.Controls.Add(this.btnpersonelekle);
            this.Controls.Add(this.btnkutuphaneekle);
            this.Controls.Add(this.btnuyeekle);
            this.Controls.Add(this.btnkitapekle);
            this.Controls.Add(this.PictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANASAYFA";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAnasayfa_MouseMove);
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.tsanasayfa.ResumeLayout(false);
            this.tsanasayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnyazarekle;
        internal System.Windows.Forms.Button btnyayineviekle;
        internal System.Windows.Forms.Button btnpersonelekle;
        internal System.Windows.Forms.Button btnkutuphaneekle;
        internal System.Windows.Forms.Button btnuyeekle;
        internal System.Windows.Forms.Button btnkitapekle;
        internal System.Windows.Forms.Label lbybaslik;
        private System.Windows.Forms.Timer baslik;
        private System.Windows.Forms.Timer saattarih;
        private System.Windows.Forms.StatusStrip toolstrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbltarih;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblsaat;
        internal System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.ToolStrip tsanasayfa;
        private System.Windows.Forms.ToolStripStatusLabel lblkoordinat;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripDropDownButton btnhatirlat;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem üyeListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kütüphaneListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yayıneviListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİstatistiğiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeİstatistiğiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnteslimkatirlat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        internal System.Windows.Forms.Button btnkitapver;
        internal System.Windows.Forms.Button btnkitapal;
        internal System.Windows.Forms.Button btnyenikullanici;
        private System.Windows.Forms.ToolStripMenuItem kütüphaneİstatistiğiToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel lblkitapsayi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel lbluyesayi;
        private System.Windows.Forms.ToolStripMenuItem kitapTurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapYeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meslekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenimDurumToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem dilToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem yeniYılToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağışListesiToolStripMenuItem;
        private System.Windows.Forms.Timer timerhatirlatma;
        internal System.Windows.Forms.Button button1;
    }
}

