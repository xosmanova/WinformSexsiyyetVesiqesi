namespace WinformSexsiyyetVesiqesi;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        
        // GroupBoxes
        groupBoxVesiqe = new GroupBox();
        panelCard = new Panel();
        lblRespublika = new Label();
        lblVesiqeTitle = new Label();
        pictureBox1 = new PictureBox();
        lblFotoHint = new Label();
        
        // Card Labels (Titles)
        lblCardSoyadTitle = new Label();
        lblCardAdTitle = new Label();
        lblCardAtaTitle = new Label();
        lblCardDogumTarixiTitle = new Label();
        lblCardDogumYeriTitle = new Label();
        lblCardCinsTitle = new Label();
        lblCardSeriyaTitle = new Label();
        lblCardFinTitle = new Label();
        lblCardAileVezTitle = new Label();
        lblCardVerilmeTitle = new Label();
        lblCardEtibarlidirTitle = new Label();

        // Card Labels (Values)
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        label9 = new Label();
        label10 = new Label();
        label11 = new Label();

        lblSizeModeHint = new Label();
        button3 = new Button();

        groupBoxMelumatlar = new GroupBox();
        lblSeriya = new Label();
        textBox1 = new TextBox();
        lblFin = new Label();
        textBox2 = new TextBox();
        lblSoyad = new Label();
        textBox3 = new TextBox();
        lblAd = new Label();
        textBox4 = new TextBox();
        lblAta = new Label();
        textBox5 = new TextBox();
        lblCins = new Label();
        textBox6 = new TextBox();
        lblDogumTarixi = new Label();
        textBox7 = new TextBox();
        lblDogumYeri = new Label();
        textBox8 = new TextBox();
        lblAile = new Label();
        textBox9 = new TextBox();
        lblVerilme = new Label();
        textBox10 = new TextBox();
        lblEtibarli = new Label();
        textBox11 = new TextBox();
        lblVerenOrqan = new Label();
        textBox12 = new TextBox();

        button2 = new Button();
        button1 = new Button();
        progressBar1 = new ProgressBar();
        timer1 = new System.Windows.Forms.Timer(components);
        openFileDialog1 = new OpenFileDialog();

        groupBoxVesiqe.SuspendLayout();
        panelCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        groupBoxMelumatlar.SuspendLayout();
        SuspendLayout();

        // 
        // groupBoxVesiqe
        // 
        groupBoxVesiqe.Controls.Add(panelCard);
        groupBoxVesiqe.Controls.Add(lblSizeModeHint);
        groupBoxVesiqe.Controls.Add(button3);
        groupBoxVesiqe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        groupBoxVesiqe.Location = new Point(16, 12);
        groupBoxVesiqe.Name = "groupBoxVesiqe";
        groupBoxVesiqe.Size = new Size(470, 500);
        groupBoxVesiqe.TabIndex = 0;
        groupBoxVesiqe.TabStop = false;
        groupBoxVesiqe.Text = "Şəxsiyyət vəsiqəsi";

        // 
        // panelCard
        // 
        panelCard.BackColor = Color.FromArgb(242, 247, 255);
        panelCard.BorderStyle = BorderStyle.FixedSingle;
        panelCard.Controls.Add(lblRespublika);
        panelCard.Controls.Add(lblVesiqeTitle);
        panelCard.Controls.Add(pictureBox1);
        panelCard.Controls.Add(lblCardSoyadTitle);
        panelCard.Controls.Add(label3);
        panelCard.Controls.Add(lblCardAdTitle);
        panelCard.Controls.Add(label4);
        panelCard.Controls.Add(lblCardAtaTitle);
        panelCard.Controls.Add(label5);
        panelCard.Controls.Add(lblCardDogumTarixiTitle);
        panelCard.Controls.Add(label7);
        panelCard.Controls.Add(lblCardDogumYeriTitle);
        panelCard.Controls.Add(label8);
        panelCard.Controls.Add(lblCardCinsTitle);
        panelCard.Controls.Add(label6);
        panelCard.Controls.Add(lblCardSeriyaTitle);
        panelCard.Controls.Add(label1);
        panelCard.Controls.Add(lblCardFinTitle);
        panelCard.Controls.Add(label2);
        panelCard.Controls.Add(lblCardAileVezTitle);
        panelCard.Controls.Add(label9);
        panelCard.Controls.Add(lblCardVerilmeTitle);
        panelCard.Controls.Add(label10);
        panelCard.Controls.Add(lblCardEtibarlidirTitle);
        panelCard.Controls.Add(label11);
        panelCard.Location = new Point(15, 28);
        panelCard.Name = "panelCard";
        panelCard.Size = new Size(440, 375);
        panelCard.TabIndex = 0;

        // 
        // lblRespublika
        // 
        lblRespublika.AutoSize = true;
        lblRespublika.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        lblRespublika.ForeColor = Color.FromArgb(24, 73, 148);
        lblRespublika.Location = new Point(18, 18);
        lblRespublika.Name = "lblRespublika";
        lblRespublika.Size = new Size(224, 20);
        lblRespublika.TabIndex = 0;
        lblRespublika.Text = "AZƏRBAYCAN RESPUBLİKASI";

        // 
        // lblVesiqeTitle
        // 
        lblVesiqeTitle.AutoSize = true;
        lblVesiqeTitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        lblVesiqeTitle.ForeColor = Color.FromArgb(45, 105, 185);
        lblVesiqeTitle.Location = new Point(19, 40);
        lblVesiqeTitle.Name = "lblVesiqeTitle";
        lblVesiqeTitle.Size = new Size(100, 13);
        lblVesiqeTitle.TabIndex = 1;
        lblVesiqeTitle.Text = "Şəxsiyyət vəsiqəsi";

        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.FromArgb(185, 204, 228);
        pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        pictureBox1.Location = new Point(19, 68);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(100, 130);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;

        // 
        // Column 1 Titles & Values
        // 
        lblCardSoyadTitle.AutoSize = true;
        lblCardSoyadTitle.ForeColor = Color.DimGray;
        lblCardSoyadTitle.Location = new Point(130, 68);
        lblCardSoyadTitle.Name = "lblCardSoyadTitle";
        lblCardSoyadTitle.Size = new Size(42, 15);
        lblCardSoyadTitle.Text = "Soyad:";

        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label3.ForeColor = Color.Navy;
        label3.Location = new Point(185, 68);
        label3.Name = "label3";
        label3.Size = new Size(0, 15);

        lblCardAdTitle.AutoSize = true;
        lblCardAdTitle.ForeColor = Color.DimGray;
        lblCardAdTitle.Location = new Point(130, 95);
        lblCardAdTitle.Name = "lblCardAdTitle";
        lblCardAdTitle.Size = new Size(25, 15);
        lblCardAdTitle.Text = "Ad:";

        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label4.ForeColor = Color.Navy;
        label4.Location = new Point(185, 95);
        label4.Name = "label4";
        label4.Size = new Size(0, 15);

        lblCardAtaTitle.AutoSize = true;
        lblCardAtaTitle.ForeColor = Color.DimGray;
        lblCardAtaTitle.Location = new Point(130, 122);
        lblCardAtaTitle.Name = "lblCardAtaTitle";
        lblCardAtaTitle.Size = new Size(47, 15);
        lblCardAtaTitle.Text = "Ata adı:";

        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label5.ForeColor = Color.Navy;
        label5.Location = new Point(185, 122);
        label5.Name = "label5";
        label5.Size = new Size(0, 15);

        lblCardDogumTarixiTitle.AutoSize = true;
        lblCardDogumTarixiTitle.ForeColor = Color.DimGray;
        lblCardDogumTarixiTitle.Location = new Point(130, 149);
        lblCardDogumTarixiTitle.Name = "lblCardDogumTarixiTitle";
        lblCardDogumTarixiTitle.Size = new Size(77, 15);
        lblCardDogumTarixiTitle.Text = "Doğum tarixi:";

        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label7.ForeColor = Color.Navy;
        label7.Location = new Point(210, 149);
        label7.Name = "label7";
        label7.Size = new Size(0, 15);

        lblCardDogumYeriTitle.AutoSize = true;
        lblCardDogumYeriTitle.ForeColor = Color.DimGray;
        lblCardDogumYeriTitle.Location = new Point(130, 176);
        lblCardDogumYeriTitle.Name = "lblCardDogumYeriTitle";
        lblCardDogumYeriTitle.Size = new Size(71, 15);
        lblCardDogumYeriTitle.Text = "Doğum yeri:";

        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label8.ForeColor = Color.Navy;
        label8.Location = new Point(210, 176);
        label8.Name = "label8";
        label8.Size = new Size(0, 15);

        lblCardCinsTitle.AutoSize = true;
        lblCardCinsTitle.ForeColor = Color.DimGray;
        lblCardCinsTitle.Location = new Point(130, 203);
        lblCardCinsTitle.Name = "lblCardCinsTitle";
        lblCardCinsTitle.Size = new Size(33, 15);
        lblCardCinsTitle.Text = "Cins:";

        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label6.ForeColor = Color.Navy;
        label6.Location = new Point(185, 203);
        label6.Name = "label6";
        label6.Size = new Size(0, 15);

        // 
        // Column 2 Titles & Values
        // 
        lblCardSeriyaTitle.AutoSize = true;
        lblCardSeriyaTitle.ForeColor = Color.DimGray;
        lblCardSeriyaTitle.Location = new Point(285, 68);
        lblCardSeriyaTitle.Name = "lblCardSeriyaTitle";
        lblCardSeriyaTitle.Size = new Size(41, 15);
        lblCardSeriyaTitle.Text = "Seriya:";

        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = Color.Navy;
        label1.Location = new Point(345, 68);
        label1.Name = "label1";
        label1.Size = new Size(0, 15);

        lblCardFinTitle.AutoSize = true;
        lblCardFinTitle.ForeColor = Color.DimGray;
        lblCardFinTitle.Location = new Point(285, 95);
        lblCardFinTitle.Name = "lblCardFinTitle";
        lblCardFinTitle.Size = new Size(29, 15);
        lblCardFinTitle.Text = "FİN:";

        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.Navy;
        label2.Location = new Point(345, 95);
        label2.Name = "label2";
        label2.Size = new Size(0, 15);

        lblCardAileVezTitle.AutoSize = true;
        lblCardAileVezTitle.ForeColor = Color.DimGray;
        lblCardAileVezTitle.Location = new Point(285, 122);
        lblCardAileVezTitle.Name = "lblCardAileVezTitle";
        lblCardAileVezTitle.Size = new Size(55, 15);
        lblCardAileVezTitle.Text = "Ailə vəz.:";

        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label9.ForeColor = Color.Navy;
        label9.Location = new Point(345, 122);
        label9.Name = "label9";
        label9.Size = new Size(0, 15);

        lblCardVerilmeTitle.AutoSize = true;
        lblCardVerilmeTitle.ForeColor = Color.DimGray;
        lblCardVerilmeTitle.Location = new Point(285, 149);
        lblCardVerilmeTitle.Name = "lblCardVerilmeTitle";
        lblCardVerilmeTitle.Size = new Size(49, 15);
        lblCardVerilmeTitle.Text = "Verilmə:";

        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label10.ForeColor = Color.Navy;
        label10.Location = new Point(345, 149);
        label10.Name = "label10";
        label10.Size = new Size(0, 15);

        lblCardEtibarlidirTitle.AutoSize = true;
        lblCardEtibarlidirTitle.ForeColor = Color.DimGray;
        lblCardEtibarlidirTitle.Location = new Point(285, 176);
        lblCardEtibarlidirTitle.Name = "lblCardEtibarlidirTitle";
        lblCardEtibarlidirTitle.Size = new Size(62, 15);
        lblCardEtibarlidirTitle.Text = "Etibarlıdır:";

        label11.AutoSize = true;
        label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label11.ForeColor = Color.Navy;
        label11.Location = new Point(350, 176);
        label11.Name = "label11";
        label11.Size = new Size(0, 15);

        // 
        // lblSizeModeHint
        // 
        lblSizeModeHint.AutoSize = true;
        lblSizeModeHint.ForeColor = Color.Gray;
        lblSizeModeHint.Location = new Point(140, 420);
        lblSizeModeHint.Name = "lblSizeModeHint";
        lblSizeModeHint.Size = new Size(165, 15);
        lblSizeModeHint.Text = "PictureBox (SizeMode = Zoom)";

        // 
        // button3 (Şəkil yüklə)
        // 
        button3.Location = new Point(15, 450);
        button3.Name = "button3";
        button3.Size = new Size(440, 35);
        button3.TabIndex = 1;
        button3.Text = "Şəkil yüklə...";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;

        // 
        // groupBoxMelumatlar
        // 
        groupBoxMelumatlar.Controls.Add(lblSeriya);
        groupBoxMelumatlar.Controls.Add(textBox1);
        groupBoxMelumatlar.Controls.Add(lblFin);
        groupBoxMelumatlar.Controls.Add(textBox2);
        groupBoxMelumatlar.Controls.Add(lblSoyad);
        groupBoxMelumatlar.Controls.Add(textBox3);
        groupBoxMelumatlar.Controls.Add(lblAd);
        groupBoxMelumatlar.Controls.Add(textBox4);
        groupBoxMelumatlar.Controls.Add(lblAta);
        groupBoxMelumatlar.Controls.Add(textBox5);
        groupBoxMelumatlar.Controls.Add(lblCins);
        groupBoxMelumatlar.Controls.Add(textBox6);
        groupBoxMelumatlar.Controls.Add(lblDogumTarixi);
        groupBoxMelumatlar.Controls.Add(textBox7);
        groupBoxMelumatlar.Controls.Add(lblDogumYeri);
        groupBoxMelumatlar.Controls.Add(textBox8);
        groupBoxMelumatlar.Controls.Add(lblAile);
        groupBoxMelumatlar.Controls.Add(textBox9);
        groupBoxMelumatlar.Controls.Add(lblVerilme);
        groupBoxMelumatlar.Controls.Add(textBox10);
        groupBoxMelumatlar.Controls.Add(lblEtibarli);
        groupBoxMelumatlar.Controls.Add(textBox11);
        groupBoxMelumatlar.Controls.Add(lblVerenOrqan);
        groupBoxMelumatlar.Controls.Add(textBox12);
        groupBoxMelumatlar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        groupBoxMelumatlar.Location = new Point(505, 12);
        groupBoxMelumatlar.Name = "groupBoxMelumatlar";
        groupBoxMelumatlar.Size = new Size(475, 500);
        groupBoxMelumatlar.TabIndex = 1;
        groupBoxMelumatlar.TabStop = false;
        groupBoxMelumatlar.Text = "Vəsiqə məlumatları";

        // 
        // Inputs
        // 
        int startY = 30;
        int stepY = 36;
        int lblX = 15;
        int txtX = 145;
        int txtW = 310;

        // 1. Seriya və nömrə
        lblSeriya.AutoSize = true;
        lblSeriya.Location = new Point(lblX, startY);
        lblSeriya.Text = "Seriya və nömrə:";
        textBox1.Location = new Point(txtX, startY - 3);
        textBox1.Size = new Size(txtW, 23);
        textBox1.TextChanged += textBox1_TextChanged;

        // 2. FİN kod
        lblFin.AutoSize = true;
        lblFin.Location = new Point(lblX, startY + stepY * 1);
        lblFin.Text = "FİN kod:";
        textBox2.Location = new Point(txtX, startY + stepY * 1 - 3);
        textBox2.Size = new Size(txtW, 23);
        textBox2.TextChanged += textBox2_TextChanged;

        // 3. Soyad
        lblSoyad.AutoSize = true;
        lblSoyad.Location = new Point(lblX, startY + stepY * 2);
        lblSoyad.Text = "Soyad:";
        textBox3.Location = new Point(txtX, startY + stepY * 2 - 3);
        textBox3.Size = new Size(txtW, 23);
        textBox3.TextChanged += textBox3_TextChanged;

        // 4. Ad
        lblAd.AutoSize = true;
        lblAd.Location = new Point(lblX, startY + stepY * 3);
        lblAd.Text = "Ad:";
        textBox4.Location = new Point(txtX, startY + stepY * 3 - 3);
        textBox4.Size = new Size(txtW, 23);
        textBox4.TextChanged += textBox4_TextChanged;

        // 5. Ata adı
        lblAta.AutoSize = true;
        lblAta.Location = new Point(lblX, startY + stepY * 4);
        lblAta.Text = "Ata adı:";
        textBox5.Location = new Point(txtX, startY + stepY * 4 - 3);
        textBox5.Size = new Size(txtW, 23);
        textBox5.TextChanged += textBox5_TextChanged;

        // 6. Cins
        lblCins.AutoSize = true;
        lblCins.Location = new Point(lblX, startY + stepY * 5);
        lblCins.Text = "Cins:";
        textBox6.Location = new Point(txtX, startY + stepY * 5 - 3);
        textBox6.Size = new Size(txtW, 23);
        textBox6.TextChanged += textBox6_TextChanged;

        // 7. Doğum tarixi
        lblDogumTarixi.AutoSize = true;
        lblDogumTarixi.Location = new Point(lblX, startY + stepY * 6);
        lblDogumTarixi.Text = "Doğum tarixi:";
        textBox7.Location = new Point(txtX, startY + stepY * 6 - 3);
        textBox7.Size = new Size(txtW, 23);
        textBox7.TextChanged += textBox7_TextChanged;

        // 8. Doğum yeri
        lblDogumYeri.AutoSize = true;
        lblDogumYeri.Location = new Point(lblX, startY + stepY * 7);
        lblDogumYeri.Text = "Doğum yeri:";
        textBox8.Location = new Point(txtX, startY + stepY * 7 - 3);
        textBox8.Size = new Size(txtW, 23);
        textBox8.TextChanged += textBox8_TextChanged;

        // 9. Ailə vəziyyəti
        lblAile.AutoSize = true;
        lblAile.Location = new Point(lblX, startY + stepY * 8);
        lblAile.Text = "Ailə vəziyyəti:";
        textBox9.Location = new Point(txtX, startY + stepY * 8 - 3);
        textBox9.Size = new Size(txtW, 23);
        textBox9.TextChanged += textBox9_TextChanged;

        // 10. Verilmə tarixi
        lblVerilme.AutoSize = true;
        lblVerilme.Location = new Point(lblX, startY + stepY * 9);
        lblVerilme.Text = "Verilmə tarixi:";
        textBox10.Location = new Point(txtX, startY + stepY * 9 - 3);
        textBox10.Size = new Size(txtW, 23);
        textBox10.TextChanged += textBox10_TextChanged;

        // 11. Etibarlıdır
        lblEtibarli.AutoSize = true;
        lblEtibarli.Location = new Point(lblX, startY + stepY * 10);
        lblEtibarli.Text = "Etibarlıdır:";
        textBox11.Location = new Point(txtX, startY + stepY * 10 - 3);
        textBox11.Size = new Size(txtW, 23);
        textBox11.TextChanged += textBox11_TextChanged;

        // 12. Verən orqan
        lblVerenOrqan.AutoSize = true;
        lblVerenOrqan.Location = new Point(lblX, startY + stepY * 11);
        lblVerenOrqan.Text = "Verən orqan:";
        textBox12.Location = new Point(txtX, startY + stepY * 11 - 3);
        textBox12.Size = new Size(txtW, 23);

        // 
        // button2 (Təmizlə)
        // 
        button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        button2.Location = new Point(720, 525);
        button2.Name = "button2";
        button2.Size = new Size(115, 36);
        button2.TabIndex = 2;
        button2.Text = "Təmizlə";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;

        // 
        // button1 (Yadda saxla)
        // 
        button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(845, 525);
        button1.Name = "button1";
        button1.Size = new Size(135, 36);
        button1.TabIndex = 3;
        button1.Text = "Yadda saxla";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;

        // 
        // progressBar1
        // 
        progressBar1.Location = new Point(16, 525);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(680, 36);
        progressBar1.TabIndex = 4;
        progressBar1.Visible = false;

        // 
        // timer1
        // 
        timer1.Interval = 50;
        timer1.Tick += timer1_Tick;

        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 580);
        Controls.Add(progressBar1);
        Controls.Add(button1);
        Controls.Add(button2);
        Controls.Add(groupBoxMelumatlar);
        Controls.Add(groupBoxVesiqe);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Azərbaycan Şəxsiyyət Vəsiqəsi";
        Load += Form1_Load;
        groupBoxVesiqe.ResumeLayout(false);
        groupBoxVesiqe.PerformLayout();
        panelCard.ResumeLayout(false);
        panelCard.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        groupBoxMelumatlar.ResumeLayout(false);
        groupBoxMelumatlar.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxVesiqe;
    private Panel panelCard;
    private Label lblRespublika;
    private Label lblVesiqeTitle;
    private PictureBox pictureBox1;
    private Label lblFotoHint;
    private Label lblSizeModeHint;
    private Button button3;

    private Label lblCardSoyadTitle;
    private Label lblCardAdTitle;
    private Label lblCardAtaTitle;
    private Label lblCardDogumTarixiTitle;
    private Label lblCardDogumYeriTitle;
    private Label lblCardCinsTitle;
    private Label lblCardSeriyaTitle;
    private Label lblCardFinTitle;
    private Label lblCardAileVezTitle;
    private Label lblCardVerilmeTitle;
    private Label lblCardEtibarlidirTitle;

    public Label label1;
    public Label label2;
    public Label label3;
    public Label label4;
    public Label label5;
    public Label label6;
    public Label label7;
    public Label label8;
    public Label label9;
    public Label label10;
    public Label label11;

    private GroupBox groupBoxMelumatlar;
    private Label lblSeriya;
    public TextBox textBox1;
    private Label lblFin;
    public TextBox textBox2;
    private Label lblSoyad;
    public TextBox textBox3;
    private Label lblAd;
    public TextBox textBox4;
    private Label lblAta;
    public TextBox textBox5;
    private Label lblCins;
    public TextBox textBox6;
    private Label lblDogumTarixi;
    public TextBox textBox7;
    private Label lblDogumYeri;
    public TextBox textBox8;
    private Label lblAile;
    public TextBox textBox9;
    private Label lblVerilme;
    public TextBox textBox10;
    private Label lblEtibarli;
    public TextBox textBox11;
    private Label lblVerenOrqan;
    public TextBox textBox12;

    public Button button2;
    public Button button1;
    public ProgressBar progressBar1;
    public System.Windows.Forms.Timer timer1;
    public OpenFileDialog openFileDialog1;
}
