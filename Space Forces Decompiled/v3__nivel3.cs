// Decompiled with JetBrains decompiler
// Type: Space_Forces.v3__nivel3
// Assembly: Space Forces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F1F84538-E895-48C3-8596-7C330F22B69D
// Assembly location: C:\Users\Yarko\AppData\Local\Apps\2.0\LAZGQ9DQ.MM4\33WNND2T.LTO\spac..tion_55dd54f316dd7825_0001.0000_d2c45c90b68e6c08\Space Forces.exe

using AxWMPLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Space_Forces.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Space_Forces
{
  [DesignerGenerated]
  public class v3__nivel3 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("bsalir")]
    private Button _bsalir;
    [AccessedThroughProperty("nave")]
    private PictureBox _nave;
    [AccessedThroughProperty("platillo")]
    private PictureBox _platillo;
    [AccessedThroughProperty("Timer1")]
    private Timer _Timer1;
    [AccessedThroughProperty("c1")]
    private PictureBox _c1;
    [AccessedThroughProperty("c3")]
    private PictureBox _c3;
    [AccessedThroughProperty("c5")]
    private PictureBox _c5;
    [AccessedThroughProperty("c2")]
    private PictureBox _c2;
    [AccessedThroughProperty("c4")]
    private PictureBox _c4;
    [AccessedThroughProperty("c7")]
    private PictureBox _c7;
    [AccessedThroughProperty("c6")]
    private PictureBox _c6;
    [AccessedThroughProperty("Timer2")]
    private Timer _Timer2;
    [AccessedThroughProperty("Timer3")]
    private Timer _Timer3;
    [AccessedThroughProperty("Timer4")]
    private Timer _Timer4;
    [AccessedThroughProperty("Timer5")]
    private Timer _Timer5;
    [AccessedThroughProperty("Timer6")]
    private Timer _Timer6;
    [AccessedThroughProperty("Timer7")]
    private Timer _Timer7;
    [AccessedThroughProperty("Timer8")]
    private Timer _Timer8;
    [AccessedThroughProperty("Timer9")]
    private Timer _Timer9;
    [AccessedThroughProperty("c9")]
    private PictureBox _c9;
    [AccessedThroughProperty("c8")]
    private PictureBox _c8;
    [AccessedThroughProperty("c13")]
    private PictureBox _c13;
    [AccessedThroughProperty("c12")]
    private PictureBox _c12;
    [AccessedThroughProperty("c11")]
    private PictureBox _c11;
    [AccessedThroughProperty("c10")]
    private PictureBox _c10;
    [AccessedThroughProperty("Timer11")]
    private Timer _Timer11;
    [AccessedThroughProperty("Timer12")]
    private Timer _Timer12;
    [AccessedThroughProperty("Timer13")]
    private Timer _Timer13;
    [AccessedThroughProperty("Timer14")]
    private Timer _Timer14;
    [AccessedThroughProperty("Timer15")]
    private Timer _Timer15;
    [AccessedThroughProperty("Timer16")]
    private Timer _Timer16;
    [AccessedThroughProperty("Timer17")]
    private Timer _Timer17;
    [AccessedThroughProperty("Timer18")]
    private Timer _Timer18;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("lbnombre")]
    private Label _lbnombre;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("lbvelocidad")]
    private Label _lbvelocidad;
    [AccessedThroughProperty("tbrespuesta")]
    private TextBox _tbrespuesta;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("lboperacion")]
    private Label _lboperacion;
    [AccessedThroughProperty("lblpuntaje")]
    private Label _lblpuntaje;
    [AccessedThroughProperty("lbpuntos")]
    private Label _lbpuntos;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("lbcristales")]
    private Label _lbcristales;
    [AccessedThroughProperty("br")]
    private Button _br;
    [AccessedThroughProperty("PictureBox8")]
    private PictureBox _PictureBox8;
    [AccessedThroughProperty("PictureBox7")]
    private PictureBox _PictureBox7;
    [AccessedThroughProperty("PictureBox6")]
    private PictureBox _PictureBox6;
    [AccessedThroughProperty("PictureBox5")]
    private PictureBox _PictureBox5;
    [AccessedThroughProperty("PictureBox4")]
    private PictureBox _PictureBox4;
    [AccessedThroughProperty("bpausa")]
    private Button _bpausa;
    [AccessedThroughProperty("AxWindowsMediaPlayer1")]
    private AxWindowsMediaPlayer _AxWindowsMediaPlayer1;

    [DebuggerNonUserCode]
    public v3__nivel3()
    {
      this.Load += new EventHandler(this.v3__nivel3_Load);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (v3__nivel3));
      this.PictureBox1 = new PictureBox();
      this.bsalir = new Button();
      this.nave = new PictureBox();
      this.platillo = new PictureBox();
      this.Timer1 = new Timer(this.components);
      this.c1 = new PictureBox();
      this.c3 = new PictureBox();
      this.c5 = new PictureBox();
      this.c2 = new PictureBox();
      this.c4 = new PictureBox();
      this.c7 = new PictureBox();
      this.c6 = new PictureBox();
      this.Timer2 = new Timer(this.components);
      this.Timer3 = new Timer(this.components);
      this.Timer4 = new Timer(this.components);
      this.Timer5 = new Timer(this.components);
      this.Timer6 = new Timer(this.components);
      this.Timer7 = new Timer(this.components);
      this.Timer8 = new Timer(this.components);
      this.Timer9 = new Timer(this.components);
      this.c9 = new PictureBox();
      this.c8 = new PictureBox();
      this.c13 = new PictureBox();
      this.c12 = new PictureBox();
      this.c11 = new PictureBox();
      this.c10 = new PictureBox();
      this.Timer11 = new Timer(this.components);
      this.Timer12 = new Timer(this.components);
      this.Timer13 = new Timer(this.components);
      this.Timer14 = new Timer(this.components);
      this.Timer15 = new Timer(this.components);
      this.Timer16 = new Timer(this.components);
      this.Timer17 = new Timer(this.components);
      this.Timer18 = new Timer(this.components);
      this.Label3 = new Label();
      this.lbnombre = new Label();
      this.Label2 = new Label();
      this.lbvelocidad = new Label();
      this.tbrespuesta = new TextBox();
      this.Label4 = new Label();
      this.lboperacion = new Label();
      this.lblpuntaje = new Label();
      this.lbpuntos = new Label();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.lbcristales = new Label();
      this.br = new Button();
      this.PictureBox8 = new PictureBox();
      this.PictureBox7 = new PictureBox();
      this.PictureBox6 = new PictureBox();
      this.PictureBox5 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      this.bpausa = new Button();
      this.AxWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      ((ISupportInitialize) this.nave).BeginInit();
      ((ISupportInitialize) this.platillo).BeginInit();
      ((ISupportInitialize) this.c1).BeginInit();
      ((ISupportInitialize) this.c3).BeginInit();
      ((ISupportInitialize) this.c5).BeginInit();
      ((ISupportInitialize) this.c2).BeginInit();
      ((ISupportInitialize) this.c4).BeginInit();
      ((ISupportInitialize) this.c7).BeginInit();
      ((ISupportInitialize) this.c6).BeginInit();
      ((ISupportInitialize) this.c9).BeginInit();
      ((ISupportInitialize) this.c8).BeginInit();
      ((ISupportInitialize) this.c13).BeginInit();
      ((ISupportInitialize) this.c12).BeginInit();
      ((ISupportInitialize) this.c11).BeginInit();
      ((ISupportInitialize) this.c10).BeginInit();
      ((ISupportInitialize) this.PictureBox8).BeginInit();
      ((ISupportInitialize) this.PictureBox7).BeginInit();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      this.AxWindowsMediaPlayer1.BeginInit();
      this.SuspendLayout();
      this.PictureBox1.BackColor = Color.Transparent;
      this.PictureBox1.BackgroundImage = (Image) Space_Forces.My.Resources.Resources.Tablero;
      PictureBox pictureBox1_1 = this.PictureBox1;
      Point point1 = new Point(0, 441);
      Point point2 = point1;
      pictureBox1_1.Location = point2;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      Size size1 = new Size(1024, 159);
      Size size2 = size1;
      pictureBox1_2.Size = size2;
      this.PictureBox1.TabIndex = 0;
      this.PictureBox1.TabStop = false;
      this.bsalir.BackColor = SystemColors.WindowFrame;
      this.bsalir.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bsalir.ForeColor = Color.White;
      Button bsalir1 = this.bsalir;
      point1 = new Point(14, 567);
      Point point3 = point1;
      bsalir1.Location = point3;
      this.bsalir.Name = "bsalir";
      Button bsalir2 = this.bsalir;
      size1 = new Size(36, 35);
      Size size3 = size1;
      bsalir2.Size = size3;
      this.bsalir.TabIndex = 87;
      this.bsalir.Text = "S";
      this.bsalir.UseVisualStyleBackColor = false;
      this.nave.BackColor = Color.Transparent;
      this.nave.Image = (Image) componentResourceManager.GetObject("nave.Image");
      PictureBox nave1 = this.nave;
      point1 = new Point(30, 380);
      Point point4 = point1;
      nave1.Location = point4;
      this.nave.Name = "nave";
      PictureBox nave2 = this.nave;
      size1 = new Size(60, 56);
      Size size4 = size1;
      nave2.Size = size4;
      this.nave.SizeMode = PictureBoxSizeMode.StretchImage;
      this.nave.TabIndex = 88;
      this.nave.TabStop = false;
      this.platillo.BackColor = Color.Transparent;
      this.platillo.Image = (Image) componentResourceManager.GetObject("platillo.Image");
      PictureBox platillo1 = this.platillo;
      point1 = new Point(30, 319);
      Point point5 = point1;
      platillo1.Location = point5;
      this.platillo.Name = "platillo";
      PictureBox platillo2 = this.platillo;
      size1 = new Size(116, 41);
      Size size5 = size1;
      platillo2.Size = size5;
      this.platillo.SizeMode = PictureBoxSizeMode.StretchImage;
      this.platillo.TabIndex = 89;
      this.platillo.TabStop = false;
      this.Timer1.Enabled = true;
      this.Timer1.Interval = 200;
      this.c1.BackColor = Color.Transparent;
      this.c1.Image = (Image) componentResourceManager.GetObject("c1.Image");
      PictureBox c1_1 = this.c1;
      point1 = new Point(900, 351);
      Point point6 = point1;
      c1_1.Location = point6;
      this.c1.Name = "c1";
      PictureBox c1_2 = this.c1;
      size1 = new Size(30, 27);
      Size size6 = size1;
      c1_2.Size = size6;
      this.c1.TabIndex = 90;
      this.c1.TabStop = false;
      this.c3.BackColor = Color.Transparent;
      this.c3.Image = (Image) componentResourceManager.GetObject("c3.Image");
      PictureBox c3_1 = this.c3;
      point1 = new Point(20, 188);
      Point point7 = point1;
      c3_1.Location = point7;
      this.c3.Name = "c3";
      PictureBox c3_2 = this.c3;
      size1 = new Size(30, 27);
      Size size7 = size1;
      c3_2.Size = size7;
      this.c3.TabIndex = 91;
      this.c3.TabStop = false;
      this.c3.Visible = false;
      this.c5.BackColor = Color.Transparent;
      this.c5.Image = (Image) componentResourceManager.GetObject("c5.Image");
      PictureBox c5_1 = this.c5;
      point1 = new Point(844, 32);
      Point point8 = point1;
      c5_1.Location = point8;
      this.c5.Name = "c5";
      PictureBox c5_2 = this.c5;
      size1 = new Size(30, 27);
      Size size8 = size1;
      c5_2.Size = size8;
      this.c5.TabIndex = 92;
      this.c5.TabStop = false;
      this.c5.Visible = false;
      this.c2.BackColor = Color.Transparent;
      this.c2.Image = (Image) componentResourceManager.GetObject("c2.Image");
      PictureBox c2_1 = this.c2;
      point1 = new Point(900, 202);
      Point point9 = point1;
      c2_1.Location = point9;
      this.c2.Name = "c2";
      PictureBox c2_2 = this.c2;
      size1 = new Size(30, 27);
      Size size9 = size1;
      c2_2.Size = size9;
      this.c2.TabIndex = 93;
      this.c2.TabStop = false;
      this.c2.Visible = false;
      this.c4.BackColor = Color.Transparent;
      this.c4.Image = (Image) componentResourceManager.GetObject("c4.Image");
      PictureBox c4_1 = this.c4;
      point1 = new Point(20, 32);
      Point point10 = point1;
      c4_1.Location = point10;
      this.c4.Name = "c4";
      PictureBox c4_2 = this.c4;
      size1 = new Size(30, 27);
      Size size10 = size1;
      c4_2.Size = size10;
      this.c4.TabIndex = 94;
      this.c4.TabStop = false;
      this.c4.Visible = false;
      this.c7.BackColor = Color.Transparent;
      this.c7.Image = (Image) componentResourceManager.GetObject("c7.Image");
      PictureBox c7_1 = this.c7;
      point1 = new Point(56, 12);
      Point point11 = point1;
      c7_1.Location = point11;
      this.c7.Name = "c7";
      PictureBox c7_2 = this.c7;
      size1 = new Size(30, 27);
      Size size11 = size1;
      c7_2.Size = size11;
      this.c7.TabIndex = 95;
      this.c7.TabStop = false;
      this.c7.Visible = false;
      this.c6.BackColor = Color.Transparent;
      this.c6.Image = (Image) componentResourceManager.GetObject("c6.Image");
      PictureBox c6_1 = this.c6;
      point1 = new Point(77, 31);
      Point point12 = point1;
      c6_1.Location = point12;
      this.c6.Name = "c6";
      PictureBox c6_2 = this.c6;
      size1 = new Size(30, 27);
      Size size12 = size1;
      c6_2.Size = size12;
      this.c6.TabIndex = 96;
      this.c6.TabStop = false;
      this.c6.Visible = false;
      this.Timer2.Interval = 200;
      this.Timer3.Interval = 200;
      this.Timer4.Interval = 200;
      this.Timer5.Interval = 200;
      this.Timer6.Interval = 200;
      this.Timer7.Interval = 200;
      this.Timer8.Interval = 200;
      this.Timer9.Enabled = true;
      this.Timer9.Interval = 3000;
      this.c9.BackColor = Color.Transparent;
      this.c9.Image = (Image) componentResourceManager.GetObject("c9.Image");
      PictureBox c9_1 = this.c9;
      point1 = new Point(74, 267);
      Point point13 = point1;
      c9_1.Location = point13;
      this.c9.Name = "c9";
      PictureBox c9_2 = this.c9;
      size1 = new Size(30, 27);
      Size size13 = size1;
      c9_2.Size = size13;
      this.c9.TabIndex = 98;
      this.c9.TabStop = false;
      this.c9.Visible = false;
      this.c8.BackColor = Color.Transparent;
      this.c8.Image = (Image) componentResourceManager.GetObject("c8.Image");
      PictureBox c8_1 = this.c8;
      point1 = new Point(53, 248);
      Point point14 = point1;
      c8_1.Location = point14;
      this.c8.Name = "c8";
      PictureBox c8_2 = this.c8;
      size1 = new Size(30, 27);
      Size size14 = size1;
      c8_2.Size = size14;
      this.c8.TabIndex = 97;
      this.c8.TabStop = false;
      this.c8.Visible = false;
      this.c13.BackColor = Color.Transparent;
      this.c13.Image = (Image) componentResourceManager.GetObject("c13.Image");
      PictureBox c13_1 = this.c13;
      point1 = new Point(969, 267);
      Point point15 = point1;
      c13_1.Location = point15;
      this.c13.Name = "c13";
      PictureBox c13_2 = this.c13;
      size1 = new Size(30, 27);
      Size size15 = size1;
      c13_2.Size = size15;
      this.c13.TabIndex = 102;
      this.c13.TabStop = false;
      this.c13.Visible = false;
      this.c12.BackColor = Color.Transparent;
      this.c12.Image = (Image) componentResourceManager.GetObject("c12.Image");
      PictureBox c12_1 = this.c12;
      point1 = new Point(948, 248);
      Point point16 = point1;
      c12_1.Location = point16;
      this.c12.Name = "c12";
      PictureBox c12_2 = this.c12;
      size1 = new Size(30, 27);
      Size size16 = size1;
      c12_2.Size = size16;
      this.c12.TabIndex = 101;
      this.c12.TabStop = false;
      this.c12.Visible = false;
      this.c11.BackColor = Color.Transparent;
      this.c11.Image = (Image) componentResourceManager.GetObject("c11.Image");
      PictureBox c11_1 = this.c11;
      point1 = new Point(933, 281);
      Point point17 = point1;
      c11_1.Location = point17;
      this.c11.Name = "c11";
      PictureBox c11_2 = this.c11;
      size1 = new Size(30, 27);
      Size size17 = size1;
      c11_2.Size = size17;
      this.c11.TabIndex = 104;
      this.c11.TabStop = false;
      this.c11.Visible = false;
      this.c10.BackColor = Color.Transparent;
      this.c10.Image = (Image) componentResourceManager.GetObject("c10.Image");
      PictureBox c10_1 = this.c10;
      point1 = new Point(912, 262);
      Point point18 = point1;
      c10_1.Location = point18;
      this.c10.Name = "c10";
      PictureBox c10_2 = this.c10;
      size1 = new Size(30, 27);
      Size size18 = size1;
      c10_2.Size = size18;
      this.c10.TabIndex = 103;
      this.c10.TabStop = false;
      this.c10.Visible = false;
      this.Timer11.Enabled = true;
      this.Timer11.Interval = 200;
      this.Timer12.Interval = 200;
      this.Timer13.Interval = 200;
      this.Timer14.Interval = 200;
      this.Timer15.Interval = 200;
      this.Timer16.Interval = 200;
      this.Timer17.Interval = 200;
      this.Timer18.Interval = 200;
      this.Label3.BackColor = Color.Black;
      this.Label3.Font = new Font("Starcraft", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Lime;
      Label label3_1 = this.Label3;
      point1 = new Point(263, 493);
      Point point19 = point1;
      label3_1.Location = point19;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(144, 28);
      Size size19 = size1;
      label3_2.Size = size19;
      this.Label3.TabIndex = 110;
      this.Label3.Text = "Puntaje:";
      this.Label3.TextAlign = ContentAlignment.MiddleCenter;
      this.lbnombre.BackColor = Color.Black;
      this.lbnombre.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbnombre.ForeColor = Color.Lime;
      Label lbnombre1 = this.lbnombre;
      point1 = new Point(754, 565);
      Point point20 = point1;
      lbnombre1.Location = point20;
      this.lbnombre.Name = "lbnombre";
      Label lbnombre2 = this.lbnombre;
      size1 = new Size(231, 23);
      Size size20 = size1;
      lbnombre2.Size = size20;
      this.lbnombre.TabIndex = 109;
      this.lbnombre.TextAlign = ContentAlignment.MiddleCenter;
      this.Label2.BackColor = Color.Black;
      this.Label2.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Lime;
      Label label2_1 = this.Label2;
      point1 = new Point(811, 534);
      Point point21 = point1;
      label2_1.Location = point21;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(120, 28);
      Size size21 = size1;
      label2_2.Size = size21;
      this.Label2.TabIndex = 108;
      this.Label2.Text = "Piloto:";
      this.Label2.TextAlign = ContentAlignment.MiddleCenter;
      this.lbvelocidad.BackColor = Color.Black;
      this.lbvelocidad.Font = new Font("Starcraft", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbvelocidad.ForeColor = Color.Blue;
      this.lbvelocidad.ImageAlign = ContentAlignment.MiddleRight;
      Label lbvelocidad1 = this.lbvelocidad;
      point1 = new Point(50, 520);
      Point point22 = point1;
      lbvelocidad1.Location = point22;
      this.lbvelocidad.Name = "lbvelocidad";
      Label lbvelocidad2 = this.lbvelocidad;
      size1 = new Size(96, 22);
      Size size22 = size1;
      lbvelocidad2.Size = size22;
      this.lbvelocidad.TabIndex = 107;
      this.lbvelocidad.TextAlign = ContentAlignment.MiddleCenter;
      this.tbrespuesta.BackColor = Color.Gray;
      this.tbrespuesta.Cursor = Cursors.Hand;
      this.tbrespuesta.Font = new Font("Starcraft", 17.25f);
      this.tbrespuesta.ForeColor = Color.Blue;
      TextBox tbrespuesta1 = this.tbrespuesta;
      point1 = new Point(584, 491);
      Point point23 = point1;
      tbrespuesta1.Location = point23;
      this.tbrespuesta.Margin = new Padding(3, 4, 3, 4);
      this.tbrespuesta.Name = "tbrespuesta";
      TextBox tbrespuesta2 = this.tbrespuesta;
      size1 = new Size(63, 24);
      Size size23 = size1;
      tbrespuesta2.Size = size23;
      this.tbrespuesta.TabIndex = 106;
      this.Label4.BackColor = Color.Black;
      this.Label4.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.Blue;
      Label label4_1 = this.Label4;
      point1 = new Point(65, 496);
      Point point24 = point1;
      label4_1.Location = point24;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(144, 16);
      Size size24 = size1;
      label4_2.Size = size24;
      this.Label4.TabIndex = 105;
      this.Label4.Text = "Velocidad";
      this.Label4.TextAlign = ContentAlignment.MiddleCenter;
      this.lboperacion.BackColor = Color.Black;
      this.lboperacion.Font = new Font("Starcraft", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lboperacion.ForeColor = Color.Blue;
      Label lboperacion1 = this.lboperacion;
      point1 = new Point(413, 489);
      Point point25 = point1;
      lboperacion1.Location = point25;
      this.lboperacion.Name = "lboperacion";
      Label lboperacion2 = this.lboperacion;
      size1 = new Size(165, 28);
      Size size25 = size1;
      lboperacion2.Size = size25;
      this.lboperacion.TabIndex = 112;
      this.lboperacion.TextAlign = ContentAlignment.MiddleCenter;
      this.lblpuntaje.BackColor = Color.Black;
      this.lblpuntaje.Font = new Font("Starcraft", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblpuntaje.ForeColor = Color.Lime;
      Label lblpuntaje1 = this.lblpuntaje;
      point1 = new Point(263, 527);
      Point point26 = point1;
      lblpuntaje1.Location = point26;
      this.lblpuntaje.Name = "lblpuntaje";
      Label lblpuntaje2 = this.lblpuntaje;
      size1 = new Size(144, 28);
      Size size26 = size1;
      lblpuntaje2.Size = size26;
      this.lblpuntaje.TabIndex = 113;
      this.lblpuntaje.TextAlign = ContentAlignment.MiddleCenter;
      this.lbpuntos.BackColor = Color.Black;
      this.lbpuntos.Font = new Font("Starcraft", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbpuntos.ForeColor = Color.Blue;
      Label lbpuntos1 = this.lbpuntos;
      point1 = new Point(263, 563);
      Point point27 = point1;
      lbpuntos1.Location = point27;
      this.lbpuntos.Name = "lbpuntos";
      Label lbpuntos2 = this.lbpuntos;
      size1 = new Size(144, 28);
      Size size27 = size1;
      lbpuntos2.Size = size27;
      this.lbpuntos.TabIndex = 114;
      this.lbpuntos.TextAlign = ContentAlignment.MiddleCenter;
      this.Label7.BackColor = Color.Black;
      this.Label7.Font = new Font("Starcraft", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = Color.Blue;
      Label label7_1 = this.Label7;
      point1 = new Point(146, 522);
      Point point28 = point1;
      label7_1.Location = point28;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(66, 22);
      Size size28 = size1;
      label7_2.Size = size28;
      this.Label7.TabIndex = 115;
      this.Label7.Text = "km/h";
      this.Label7.TextAlign = ContentAlignment.MiddleCenter;
      this.Label8.BackColor = Color.Black;
      this.Label8.Font = new Font("Starcraft", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.Red;
      Label label8_1 = this.Label8;
      point1 = new Point(434, 522);
      Point point29 = point1;
      label8_1.Location = point29;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(144, 28);
      Size size29 = size1;
      label8_2.Size = size29;
      this.Label8.TabIndex = 116;
      this.Label8.Text = "Cristales ";
      this.Label8.TextAlign = ContentAlignment.MiddleCenter;
      this.lbcristales.BackColor = Color.Black;
      this.lbcristales.Font = new Font("Starcraft", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbcristales.ForeColor = Color.Red;
      Label lbcristales1 = this.lbcristales;
      point1 = new Point(434, 560);
      Point point30 = point1;
      lbcristales1.Location = point30;
      this.lbcristales.Name = "lbcristales";
      Label lbcristales2 = this.lbcristales;
      size1 = new Size(144, 28);
      Size size30 = size1;
      lbcristales2.Size = size30;
      this.lbcristales.TabIndex = 117;
      this.lbcristales.TextAlign = ContentAlignment.MiddleCenter;
      this.br.BackColor = Color.Black;
      this.br.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.br.ForeColor = Color.White;
      Button br1 = this.br;
      point1 = new Point(14, 469);
      Point point31 = point1;
      br1.Location = point31;
      this.br.Name = "br";
      Button br2 = this.br;
      size1 = new Size(36, 35);
      Size size31 = size1;
      br2.Size = size31;
      this.br.TabIndex = 121;
      this.br.Text = "R";
      this.br.UseVisualStyleBackColor = false;
      this.PictureBox8.BackColor = Color.Transparent;
      this.PictureBox8.Cursor = Cursors.Hand;
      PictureBox pictureBox8_1 = this.PictureBox8;
      point1 = new Point(670, 440);
      Point point32 = point1;
      pictureBox8_1.Location = point32;
      this.PictureBox8.Name = "PictureBox8";
      PictureBox pictureBox8_2 = this.PictureBox8;
      size1 = new Size(75, 13);
      Size size32 = size1;
      pictureBox8_2.Size = size32;
      this.PictureBox8.TabIndex = 126;
      this.PictureBox8.TabStop = false;
      this.PictureBox7.BackColor = Color.Transparent;
      this.PictureBox7.Cursor = Cursors.Hand;
      PictureBox pictureBox7_1 = this.PictureBox7;
      point1 = new Point(744, 441);
      Point point33 = point1;
      pictureBox7_1.Location = point33;
      this.PictureBox7.Name = "PictureBox7";
      PictureBox pictureBox7_2 = this.PictureBox7;
      size1 = new Size(75, 21);
      Size size33 = size1;
      pictureBox7_2.Size = size33;
      this.PictureBox7.TabIndex = 125;
      this.PictureBox7.TabStop = false;
      this.PictureBox6.BackColor = Color.Transparent;
      this.PictureBox6.Cursor = Cursors.Hand;
      PictureBox pictureBox6_1 = this.PictureBox6;
      point1 = new Point(809, 441);
      Point point34 = point1;
      pictureBox6_1.Location = point34;
      this.PictureBox6.Name = "PictureBox6";
      PictureBox pictureBox6_2 = this.PictureBox6;
      size1 = new Size(75, 29);
      Size size34 = size1;
      pictureBox6_2.Size = size34;
      this.PictureBox6.TabIndex = 124;
      this.PictureBox6.TabStop = false;
      this.PictureBox5.BackColor = Color.Transparent;
      this.PictureBox5.Cursor = Cursors.Hand;
      PictureBox pictureBox5_1 = this.PictureBox5;
      point1 = new Point(880, 441);
      Point point35 = point1;
      pictureBox5_1.Location = point35;
      this.PictureBox5.Name = "PictureBox5";
      PictureBox pictureBox5_2 = this.PictureBox5;
      size1 = new Size(75, 35);
      Size size35 = size1;
      pictureBox5_2.Size = size35;
      this.PictureBox5.TabIndex = 123;
      this.PictureBox5.TabStop = false;
      this.PictureBox4.BackColor = Color.Transparent;
      this.PictureBox4.Cursor = Cursors.Hand;
      PictureBox pictureBox4_1 = this.PictureBox4;
      point1 = new Point(948, 441);
      Point point36 = point1;
      pictureBox4_1.Location = point36;
      this.PictureBox4.Name = "PictureBox4";
      PictureBox pictureBox4_2 = this.PictureBox4;
      size1 = new Size(75, 39);
      Size size36 = size1;
      pictureBox4_2.Size = size36;
      this.PictureBox4.TabIndex = 122;
      this.PictureBox4.TabStop = false;
      this.bpausa.BackColor = SystemColors.WindowFrame;
      this.bpausa.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bpausa.ForeColor = Color.White;
      Button bpausa1 = this.bpausa;
      point1 = new Point(212, 567);
      Point point37 = point1;
      bpausa1.Location = point37;
      this.bpausa.Name = "bpausa";
      Button bpausa2 = this.bpausa;
      size1 = new Size(35, 35);
      Size size37 = size1;
      bpausa2.Size = size37;
      this.bpausa.TabIndex = 86;
      this.bpausa.UseVisualStyleBackColor = false;
      this.AxWindowsMediaPlayer1.Enabled = true;
      AxWindowsMediaPlayer windowsMediaPlayer1_1 = this.AxWindowsMediaPlayer1;
      point1 = new Point(338, 319);
      Point point38 = point1;
      windowsMediaPlayer1_1.Location = point38;
      this.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1";
      this.AxWindowsMediaPlayer1.OcxState = (AxHost.State) componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState");
      AxWindowsMediaPlayer windowsMediaPlayer1_2 = this.AxWindowsMediaPlayer1;
      size1 = new Size(99, 58);
      Size size38 = size1;
      windowsMediaPlayer1_2.Size = size38;
      this.AxWindowsMediaPlayer1.TabIndex = (int) sbyte.MaxValue;
      this.AxWindowsMediaPlayer1.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      size1 = new Size(1024, 600);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.AxWindowsMediaPlayer1);
      this.Controls.Add((Control) this.PictureBox8);
      this.Controls.Add((Control) this.PictureBox7);
      this.Controls.Add((Control) this.PictureBox6);
      this.Controls.Add((Control) this.PictureBox5);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.br);
      this.Controls.Add((Control) this.lbcristales);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.lbpuntos);
      this.Controls.Add((Control) this.lblpuntaje);
      this.Controls.Add((Control) this.lboperacion);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.lbnombre);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.lbvelocidad);
      this.Controls.Add((Control) this.tbrespuesta);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.c11);
      this.Controls.Add((Control) this.c10);
      this.Controls.Add((Control) this.c13);
      this.Controls.Add((Control) this.c12);
      this.Controls.Add((Control) this.c9);
      this.Controls.Add((Control) this.c8);
      this.Controls.Add((Control) this.c6);
      this.Controls.Add((Control) this.c7);
      this.Controls.Add((Control) this.c4);
      this.Controls.Add((Control) this.c2);
      this.Controls.Add((Control) this.c5);
      this.Controls.Add((Control) this.c3);
      this.Controls.Add((Control) this.c1);
      this.Controls.Add((Control) this.platillo);
      this.Controls.Add((Control) this.nave);
      this.Controls.Add((Control) this.bsalir);
      this.Controls.Add((Control) this.bpausa);
      this.Controls.Add((Control) this.PictureBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (v3__nivel3);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (v3__nivel3);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      ((ISupportInitialize) this.nave).EndInit();
      ((ISupportInitialize) this.platillo).EndInit();
      ((ISupportInitialize) this.c1).EndInit();
      ((ISupportInitialize) this.c3).EndInit();
      ((ISupportInitialize) this.c5).EndInit();
      ((ISupportInitialize) this.c2).EndInit();
      ((ISupportInitialize) this.c4).EndInit();
      ((ISupportInitialize) this.c7).EndInit();
      ((ISupportInitialize) this.c6).EndInit();
      ((ISupportInitialize) this.c9).EndInit();
      ((ISupportInitialize) this.c8).EndInit();
      ((ISupportInitialize) this.c13).EndInit();
      ((ISupportInitialize) this.c12).EndInit();
      ((ISupportInitialize) this.c11).EndInit();
      ((ISupportInitialize) this.c10).EndInit();
      ((ISupportInitialize) this.PictureBox8).EndInit();
      ((ISupportInitialize) this.PictureBox7).EndInit();
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((ISupportInitialize) this.PictureBox5).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      this.AxWindowsMediaPlayer1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual PictureBox PictureBox1
    {
      [DebuggerNonUserCode] get => this._PictureBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox1 = value;
    }

    internal virtual Button bsalir
    {
      [DebuggerNonUserCode] get => this._bsalir;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bsalir_Click);
        if (this._bsalir != null)
          this._bsalir.Click -= eventHandler;
        this._bsalir = value;
        if (this._bsalir == null)
          return;
        this._bsalir.Click += eventHandler;
      }
    }

    internal virtual PictureBox nave
    {
      [DebuggerNonUserCode] get => this._nave;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._nave = value;
    }

    internal virtual PictureBox platillo
    {
      [DebuggerNonUserCode] get => this._platillo;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.platillo_Move);
        if (this._platillo != null)
          this._platillo.Move -= eventHandler;
        this._platillo = value;
        if (this._platillo == null)
          return;
        this._platillo.Move += eventHandler;
      }
    }

    internal virtual Timer Timer1
    {
      [DebuggerNonUserCode] get => this._Timer1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        if (this._Timer1 != null)
          this._Timer1.Tick -= eventHandler;
        this._Timer1 = value;
        if (this._Timer1 == null)
          return;
        this._Timer1.Tick += eventHandler;
      }
    }

    internal virtual PictureBox c1
    {
      [DebuggerNonUserCode] get => this._c1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c1 = value;
    }

    internal virtual PictureBox c3
    {
      [DebuggerNonUserCode] get => this._c3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c3 = value;
    }

    internal virtual PictureBox c5
    {
      [DebuggerNonUserCode] get => this._c5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c5 = value;
    }

    internal virtual PictureBox c2
    {
      [DebuggerNonUserCode] get => this._c2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c2 = value;
    }

    internal virtual PictureBox c4
    {
      [DebuggerNonUserCode] get => this._c4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c4 = value;
    }

    internal virtual PictureBox c7
    {
      [DebuggerNonUserCode] get => this._c7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c7 = value;
    }

    internal virtual PictureBox c6
    {
      [DebuggerNonUserCode] get => this._c6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c6 = value;
    }

    internal virtual Timer Timer2
    {
      [DebuggerNonUserCode] get => this._Timer2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer2_Tick);
        if (this._Timer2 != null)
          this._Timer2.Tick -= eventHandler;
        this._Timer2 = value;
        if (this._Timer2 == null)
          return;
        this._Timer2.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer3
    {
      [DebuggerNonUserCode] get => this._Timer3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer3_Tick);
        if (this._Timer3 != null)
          this._Timer3.Tick -= eventHandler;
        this._Timer3 = value;
        if (this._Timer3 == null)
          return;
        this._Timer3.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer4
    {
      [DebuggerNonUserCode] get => this._Timer4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer4_Tick);
        if (this._Timer4 != null)
          this._Timer4.Tick -= eventHandler;
        this._Timer4 = value;
        if (this._Timer4 == null)
          return;
        this._Timer4.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer5
    {
      [DebuggerNonUserCode] get => this._Timer5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer5_Tick);
        if (this._Timer5 != null)
          this._Timer5.Tick -= eventHandler;
        this._Timer5 = value;
        if (this._Timer5 == null)
          return;
        this._Timer5.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer6
    {
      [DebuggerNonUserCode] get => this._Timer6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer6_Tick);
        if (this._Timer6 != null)
          this._Timer6.Tick -= eventHandler;
        this._Timer6 = value;
        if (this._Timer6 == null)
          return;
        this._Timer6.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer7
    {
      [DebuggerNonUserCode] get => this._Timer7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer7_Tick);
        if (this._Timer7 != null)
          this._Timer7.Tick -= eventHandler;
        this._Timer7 = value;
        if (this._Timer7 == null)
          return;
        this._Timer7.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer8
    {
      [DebuggerNonUserCode] get => this._Timer8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer8_Tick);
        if (this._Timer8 != null)
          this._Timer8.Tick -= eventHandler;
        this._Timer8 = value;
        if (this._Timer8 == null)
          return;
        this._Timer8.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer9
    {
      [DebuggerNonUserCode] get => this._Timer9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer9_Tick);
        if (this._Timer9 != null)
          this._Timer9.Tick -= eventHandler;
        this._Timer9 = value;
        if (this._Timer9 == null)
          return;
        this._Timer9.Tick += eventHandler;
      }
    }

    internal virtual PictureBox c9
    {
      [DebuggerNonUserCode] get => this._c9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c9 = value;
    }

    internal virtual PictureBox c8
    {
      [DebuggerNonUserCode] get => this._c8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c8 = value;
    }

    internal virtual PictureBox c13
    {
      [DebuggerNonUserCode] get => this._c13;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c13 = value;
    }

    internal virtual PictureBox c12
    {
      [DebuggerNonUserCode] get => this._c12;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c12 = value;
    }

    internal virtual PictureBox c11
    {
      [DebuggerNonUserCode] get => this._c11;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c11 = value;
    }

    internal virtual PictureBox c10
    {
      [DebuggerNonUserCode] get => this._c10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._c10 = value;
    }

    internal virtual Timer Timer11
    {
      [DebuggerNonUserCode] get => this._Timer11;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer11_Tick);
        if (this._Timer11 != null)
          this._Timer11.Tick -= eventHandler;
        this._Timer11 = value;
        if (this._Timer11 == null)
          return;
        this._Timer11.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer12
    {
      [DebuggerNonUserCode] get => this._Timer12;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer12_Tick);
        if (this._Timer12 != null)
          this._Timer12.Tick -= eventHandler;
        this._Timer12 = value;
        if (this._Timer12 == null)
          return;
        this._Timer12.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer13
    {
      [DebuggerNonUserCode] get => this._Timer13;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer13_Tick);
        if (this._Timer13 != null)
          this._Timer13.Tick -= eventHandler;
        this._Timer13 = value;
        if (this._Timer13 == null)
          return;
        this._Timer13.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer14
    {
      [DebuggerNonUserCode] get => this._Timer14;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer14_Tick);
        if (this._Timer14 != null)
          this._Timer14.Tick -= eventHandler;
        this._Timer14 = value;
        if (this._Timer14 == null)
          return;
        this._Timer14.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer15
    {
      [DebuggerNonUserCode] get => this._Timer15;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer15_Tick);
        if (this._Timer15 != null)
          this._Timer15.Tick -= eventHandler;
        this._Timer15 = value;
        if (this._Timer15 == null)
          return;
        this._Timer15.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer16
    {
      [DebuggerNonUserCode] get => this._Timer16;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer16_Tick);
        if (this._Timer16 != null)
          this._Timer16.Tick -= eventHandler;
        this._Timer16 = value;
        if (this._Timer16 == null)
          return;
        this._Timer16.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer17
    {
      [DebuggerNonUserCode] get => this._Timer17;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer17_Tick);
        if (this._Timer17 != null)
          this._Timer17.Tick -= eventHandler;
        this._Timer17 = value;
        if (this._Timer17 == null)
          return;
        this._Timer17.Tick += eventHandler;
      }
    }

    internal virtual Timer Timer18
    {
      [DebuggerNonUserCode] get => this._Timer18;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer18_Tick);
        if (this._Timer18 != null)
          this._Timer18.Tick -= eventHandler;
        this._Timer18 = value;
        if (this._Timer18 == null)
          return;
        this._Timer18.Tick += eventHandler;
      }
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual Label lbnombre
    {
      [DebuggerNonUserCode] get => this._lbnombre;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbnombre = value;
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual Label lbvelocidad
    {
      [DebuggerNonUserCode] get => this._lbvelocidad;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbvelocidad = value;
    }

    internal virtual TextBox tbrespuesta
    {
      [DebuggerNonUserCode] get => this._tbrespuesta;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.tbrespuesta_KeyPress);
        if (this._tbrespuesta != null)
          this._tbrespuesta.KeyPress -= pressEventHandler;
        this._tbrespuesta = value;
        if (this._tbrespuesta == null)
          return;
        this._tbrespuesta.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal virtual Label lboperacion
    {
      [DebuggerNonUserCode] get => this._lboperacion;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lboperacion = value;
    }

    internal virtual Label lblpuntaje
    {
      [DebuggerNonUserCode] get => this._lblpuntaje;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblpuntaje = value;
    }

    internal virtual Label lbpuntos
    {
      [DebuggerNonUserCode] get => this._lbpuntos;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbpuntos = value;
    }

    internal virtual Label Label7
    {
      [DebuggerNonUserCode] get => this._Label7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
    }

    internal virtual Label Label8
    {
      [DebuggerNonUserCode] get => this._Label8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
    }

    internal virtual Label lbcristales
    {
      [DebuggerNonUserCode] get => this._lbcristales;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbcristales = value;
    }

    internal virtual Button br
    {
      [DebuggerNonUserCode] get => this._br;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.br_Click);
        if (this._br != null)
          this._br.Click -= eventHandler;
        this._br = value;
        if (this._br == null)
          return;
        this._br.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox8
    {
      [DebuggerNonUserCode] get => this._PictureBox8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox8 = value;
    }

    internal virtual PictureBox PictureBox7
    {
      [DebuggerNonUserCode] get => this._PictureBox7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox7 = value;
    }

    internal virtual PictureBox PictureBox6
    {
      [DebuggerNonUserCode] get => this._PictureBox6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox6 = value;
    }

    internal virtual PictureBox PictureBox5
    {
      [DebuggerNonUserCode] get => this._PictureBox5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox5 = value;
    }

    internal virtual PictureBox PictureBox4
    {
      [DebuggerNonUserCode] get => this._PictureBox4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox4 = value;
    }

    internal virtual Button bpausa
    {
      [DebuggerNonUserCode] get => this._bpausa;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._bpausa = value;
    }

    internal virtual AxWindowsMediaPlayer AxWindowsMediaPlayer1
    {
      [DebuggerNonUserCode] get => this._AxWindowsMediaPlayer1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AxWindowsMediaPlayer1 = value;
    }

    private void v3__nivel3_Load(object sender, EventArgs e)
    {
      VBMath.Randomize();
      this.tbrespuesta.Focus();
      Variables_Publicas.vp = 40;
      Variables_Publicas.vn = 40;
      Variables_Publicas.pn3 = 0;
      this.lbnombre.Text = Variables_Publicas.nj;
      this.lbvelocidad.Text = Conversions.ToString(Variables_Publicas.vn);
      Variables_Publicas.ndo = 1;
      Variables_Publicas.cts = 0;
      switch (Variables_Publicas.ndd)
      {
        case 1:
          Variables_Publicas.a1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
          Variables_Publicas.b1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
          break;
        case 2:
          Variables_Publicas.a1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
          Variables_Publicas.b1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
          if (Variables_Publicas.b1 < 5)
          {
            checked { Variables_Publicas.b1 += 5; }
            break;
          }
          break;
        case 3:
          Variables_Publicas.a1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
          Variables_Publicas.b1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
          if (Variables_Publicas.b1 < 5)
            checked { Variables_Publicas.b1 += 5; }
          if (Variables_Publicas.a1 < 5)
          {
            checked { Variables_Publicas.a1 += 5; }
            break;
          }
          break;
        case 4:
          Variables_Publicas.a1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
          Variables_Publicas.b1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
          if (Variables_Publicas.a1 < 10)
            checked { Variables_Publicas.a1 += 10; }
          if (Variables_Publicas.b1 < 10)
          {
            checked { Variables_Publicas.b1 += 10; }
            break;
          }
          break;
      }
      this.lboperacion.Text = Conversions.ToString(Variables_Publicas.a1) + " + " + Conversions.ToString(Variables_Publicas.b1);
    }

    private void Timer1_Tick(object sender, EventArgs e) => (this.platillo.Left) += (Variables_Publicas.vp);

    private void Timer2_Tick(object sender, EventArgs e) => (this.platillo.Top) -= (Variables_Publicas.vp);

    private void Timer3_Tick(object sender, EventArgs e) => (this.platillo.Left) -= (Variables_Publicas.vp);

    private void Timer4_Tick(object sender, EventArgs e) => (this.platillo.Top) -= (Variables_Publicas.vp);

    private void Timer5_Tick(object sender, EventArgs e) => (this.platillo.Left) += (Variables_Publicas.vp);

    private void Timer6_Tick(object sender, EventArgs e) => (this.platillo.Left) -= (Variables_Publicas.vp);

    private void Timer7_Tick(object sender, EventArgs e) => (this.platillo.Top) += (Variables_Publicas.vp);

    private void Timer8_Tick(object sender, EventArgs e) => (this.platillo.Left) += (Variables_Publicas.vp);

    private void Timer9_Tick(object sender, EventArgs e)
    {
      switch (Variables_Publicas.ndd)
      {
        case 1:
          checked { Variables_Publicas.vn -= 10; }
          checked { Variables_Publicas.vp += 3; }
          if (Variables_Publicas.vp > 100)
          {
            Variables_Publicas.vp = 100;
            break;
          }
          break;
        case 2:
          checked { Variables_Publicas.vn -= 10; }
          checked { Variables_Publicas.vp += 4; }
          if (Variables_Publicas.vp > 110)
          {
            Variables_Publicas.vp = 110;
            break;
          }
          break;
        case 3:
          checked { Variables_Publicas.vn -= 17; }
          checked { Variables_Publicas.vp += 7; }
          if (Variables_Publicas.vp > 115)
          {
            Variables_Publicas.vp = 115;
            break;
          }
          break;
        case 4:
          checked { Variables_Publicas.vn -= 25; }
          checked { Variables_Publicas.vp += 10; }
          if (Variables_Publicas.vp > 120)
          {
            Variables_Publicas.vp = 120;
            break;
          }
          break;
      }
      if (Variables_Publicas.vn < 10)
        Variables_Publicas.vn = 10;
      this.lbvelocidad.Text = Conversions.ToString(Variables_Publicas.vn);
    }

    private void Timer11_Tick(object sender, EventArgs e) => (this.nave.Left) += (Variables_Publicas.vn);

    private void Timer12_Tick(object sender, EventArgs e) => (this.nave.Top) -= (Variables_Publicas.vn);

    private void Timer13_Tick(object sender, EventArgs e) => (this.nave.Left) -= (Variables_Publicas.vn);

    private void Timer14_Tick(object sender, EventArgs e) => (this.nave.Top) -= (Variables_Publicas.vn);

    private void Timer15_Tick(object sender, EventArgs e) => (this.nave.Left) += (Variables_Publicas.vn);

    private void Timer16_Tick(object sender, EventArgs e) => (this.nave.Left) -= (Variables_Publicas.vn);

    private void Timer17_Tick(object sender, EventArgs e) => (this.nave.Top) += (Variables_Publicas.vn);

    private void Timer18_Tick(object sender, EventArgs e) => (this.nave.Left) += (Variables_Publicas.vn);

    private void platillo_Move(object sender, EventArgs e)
    {
      if (this.Timer1.Enabled && this.platillo.Left > 900)
      {
        this.Timer1.Enabled = false;
        this.Timer2.Enabled = true;
        if (this.c1.Visible)
        {
          this.c2.Visible = true;
          this.c1.Visible = false;
        }
      }
      if (this.Timer2.Enabled && this.platillo.Top < 202)
      {
        this.Timer2.Enabled = false;
        this.Timer3.Enabled = true;
        if (this.c2.Visible)
        {
          this.c3.Visible = true;
          this.c2.Visible = false;
        }
      }
      if (this.Timer3.Enabled && this.platillo.Left < 30)
      {
        this.Timer3.Enabled = false;
        this.Timer4.Enabled = true;
        if (this.c3.Visible)
        {
          this.c4.Visible = true;
          this.c3.Visible = false;
        }
      }
      if (this.Timer4.Enabled)
      {
        if (this.platillo.Top < 32)
        {
          this.Timer4.Enabled = false;
          this.Timer5.Enabled = true;
        }
        if (this.c4.Visible)
        {
          this.c5.Visible = true;
          this.c4.Visible = false;
        }
      }
      if (this.Timer5.Enabled && this.platillo.Left > 900)
      {
        this.Timer6.Enabled = true;
        this.Timer5.Enabled = false;
        if (this.c5.Visible)
        {
          this.c5.Visible = false;
          this.c6.Visible = true;
          this.c7.Visible = true;
        }
      }
      if (this.Timer6.Enabled && this.platillo.Left < 20)
      {
        this.Timer7.Enabled = true;
        this.Timer6.Enabled = false;
        if (this.c6.Visible)
        {
          this.c6.Visible = false;
          this.c7.Visible = false;
          this.c8.Visible = true;
          this.c9.Visible = true;
        }
      }
      if (this.Timer7.Enabled && this.platillo.Top > 240)
      {
        this.Timer8.Enabled = true;
        this.Timer7.Enabled = false;
        if (this.c8.Visible)
        {
          this.c8.Visible = false;
          this.c9.Visible = false;
          this.c10.Visible = true;
          this.c11.Visible = true;
          this.c12.Visible = true;
          this.c13.Visible = true;
        }
      }
      if (this.Timer8.Enabled && this.platillo.Left > 909)
      {
        this.Timer8.Enabled = false;
        if (this.c10.Visible)
        {
          this.c10.Visible = false;
          this.c11.Visible = false;
          this.c12.Visible = false;
          this.c13.Visible = false;
          this.Timer18.Enabled = false;
          this.Timer17.Enabled = false;
          this.Timer16.Enabled = false;
          this.Timer15.Enabled = false;
          this.Timer14.Enabled = false;
          this.Timer13.Enabled = false;
          this.Timer12.Enabled = false;
          this.Timer11.Enabled = false;
          this.Timer8.Enabled = false;
          this.Timer7.Enabled = false;
          this.Timer6.Enabled = false;
          this.Timer5.Enabled = false;
          this.Timer4.Enabled = false;
          this.Timer3.Enabled = false;
          this.Timer2.Enabled = false;
          this.Timer1.Enabled = false;
          int num = (int) Interaction.MsgBox((object) "Nivel Terminado");
          this.Hide();
          MyProject.Forms.vp__ventanapuntaje.Show();
        }
      }
      if (this.Timer11.Enabled && this.nave.Left > 900)
      {
        this.Timer11.Enabled = false;
        this.Timer12.Enabled = true;
        if (this.c1.Visible)
        {
          checked { ++Variables_Publicas.cts; }
          this.lbcristales.Text = Conversions.ToString(Variables_Publicas.cts);
          checked { Variables_Publicas.pn3 += 1000; }
          this.c2.Visible = true;
          this.c1.Visible = false;
          this.lbpuntos.ForeColor = Color.Blue;
          this.lbpuntos.Text = Conversions.ToString(1000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
        else
        {
          this.lbpuntos.ForeColor = Color.Red;
          checked { Variables_Publicas.pn3 -= 1000; }
          this.lbpuntos.Text = Conversions.ToString(-1000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
      }
      if (this.Timer12.Enabled && this.nave.Top < 202)
      {
        this.Timer12.Enabled = false;
        this.Timer13.Enabled = true;
        if (this.c2.Visible)
        {
          checked { ++Variables_Publicas.cts; }
          this.lbcristales.Text = Conversions.ToString(Variables_Publicas.cts);
          checked { Variables_Publicas.pn3 += 1000; }
          this.c3.Visible = true;
          this.c2.Visible = false;
          this.lbpuntos.ForeColor = Color.Blue;
          this.lbpuntos.Text = Conversions.ToString(1000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
        else
        {
          this.lbpuntos.ForeColor = Color.Red;
          checked { Variables_Publicas.pn3 -= 1000; }
          this.lbpuntos.Text = Conversions.ToString(-1000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
      }
      if (this.Timer13.Enabled && this.nave.Left < 30)
      {
        this.Timer13.Enabled = false;
        this.Timer14.Enabled = true;
        if (this.c3.Visible)
        {
          checked { ++Variables_Publicas.cts; }
          this.lbcristales.Text = Conversions.ToString(Variables_Publicas.cts);
          checked { Variables_Publicas.pn3 += 1000; }
          this.c4.Visible = true;
          this.c3.Visible = false;
          this.lbpuntos.ForeColor = Color.Blue;
          this.lbpuntos.Text = Conversions.ToString(1000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
        else
        {
          this.lbpuntos.ForeColor = Color.Red;
          checked { Variables_Publicas.pn3 -= 1000; }
          this.lbpuntos.Text = Conversions.ToString(-1000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
      }
      if (this.Timer14.Enabled && this.nave.Top < 32)
      {
        this.Timer14.Enabled = false;
        this.Timer15.Enabled = true;
        if (this.c4.Visible)
        {
          checked { ++Variables_Publicas.cts; }
          this.lbcristales.Text = Conversions.ToString(Variables_Publicas.cts);
          checked { Variables_Publicas.pn3 += 1000; }
          this.c5.Visible = true;
          this.c4.Visible = false;
          this.lbpuntos.ForeColor = Color.Blue;
          this.lbpuntos.Text = Conversions.ToString(1000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
        else
        {
          this.lbpuntos.ForeColor = Color.Red;
          checked { Variables_Publicas.pn3 -= 1000; }
          this.lbpuntos.Text = Conversions.ToString(-1000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
      }
      if (this.Timer15.Enabled && this.nave.Left > 900)
      {
        this.Timer16.Enabled = true;
        this.Timer15.Enabled = false;
        if (this.c5.Visible)
        {
          checked { Variables_Publicas.cts += 2; }
          this.lbcristales.Text = Conversions.ToString(Variables_Publicas.cts);
          checked { Variables_Publicas.pn3 += 2000; }
          this.c5.Visible = false;
          this.c6.Visible = true;
          this.c7.Visible = true;
          this.lbpuntos.ForeColor = Color.Blue;
          this.lbpuntos.Text = Conversions.ToString(2000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
        else
        {
          this.lbpuntos.ForeColor = Color.Red;
          checked { Variables_Publicas.pn3 -= 2000; }
          this.lbpuntos.Text = Conversions.ToString(-2000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
      }
      if (this.Timer16.Enabled && this.nave.Left < 20)
      {
        this.Timer17.Enabled = true;
        this.Timer16.Enabled = false;
        if (this.c6.Visible)
        {
          checked { Variables_Publicas.cts += 2; }
          this.lbcristales.Text = Conversions.ToString(Variables_Publicas.cts);
          checked { Variables_Publicas.pn3 += 2000; }
          this.c8.Visible = true;
          this.c9.Visible = true;
          this.c6.Visible = false;
          this.c7.Visible = false;
          this.lbpuntos.ForeColor = Color.Blue;
          this.lbpuntos.Text = Conversions.ToString(2000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
        else
        {
          this.lbpuntos.ForeColor = Color.Red;
          checked { Variables_Publicas.pn3 -= 2000; }
          this.lbpuntos.Text = Conversions.ToString(-2000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
      }
      if (this.Timer17.Enabled && this.nave.Top > 240)
      {
        this.Timer18.Enabled = true;
        this.Timer17.Enabled = false;
        if (this.c8.Visible)
        {
          checked { Variables_Publicas.cts += 2; }
          this.lbcristales.Text = Conversions.ToString(Variables_Publicas.cts);
          checked { Variables_Publicas.pn3 += 2000; }
          this.c8.Visible = false;
          this.c9.Visible = false;
          this.c10.Visible = true;
          this.c11.Visible = true;
          this.c12.Visible = true;
          this.c13.Visible = true;
          this.lbpuntos.ForeColor = Color.Blue;
          this.lbpuntos.Text = Conversions.ToString(2000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
        else
        {
          this.lbpuntos.ForeColor = Color.Red;
          checked { Variables_Publicas.pn3 -= 2000; }
          this.lbpuntos.Text = Conversions.ToString(-2000);
          this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        }
      }
      if (!this.Timer18.Enabled || this.nave.Left <= 909)
        return;
      this.Timer18.Enabled = false;
      if (this.c10.Visible)
      {
        this.c10.Visible = false;
        this.c11.Visible = false;
        this.c12.Visible = false;
        this.c13.Visible = false;
        checked { Variables_Publicas.cts += 4; }
        this.lbcristales.Text = Conversions.ToString(Variables_Publicas.cts);
        checked { Variables_Publicas.pn3 += 4000; }
        this.lbpuntos.ForeColor = Color.Blue;
        this.lbpuntos.Text = Conversions.ToString(2000);
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        Variables_Publicas.gda = 3;
      }
      else
      {
        this.lbpuntos.ForeColor = Color.Red;
        checked { Variables_Publicas.pn3 -= 2000; }
        this.lbpuntos.Text = Conversions.ToString(-2000);
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
      }
      this.Timer18.Enabled = false;
      this.Timer17.Enabled = false;
      this.Timer16.Enabled = false;
      this.Timer15.Enabled = false;
      this.Timer14.Enabled = false;
      this.Timer13.Enabled = false;
      this.Timer12.Enabled = false;
      this.Timer11.Enabled = false;
      this.Timer8.Enabled = false;
      this.Timer7.Enabled = false;
      this.Timer6.Enabled = false;
      this.Timer5.Enabled = false;
      this.Timer4.Enabled = false;
      this.Timer3.Enabled = false;
      this.Timer2.Enabled = false;
      this.Timer1.Enabled = false;
      int num1 = (int) Interaction.MsgBox((object) "Nivel Terminado");
      this.Close();
      MyProject.Forms.vc__ventanadecreditos.Show();
    }

    private void tbrespuesta_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Strings.Asc(e.KeyChar) != 13)
        return;
      this.tbrespuesta.Focus();
      Interaction.Beep();
      VBMath.Randomize();
      if (Conversions.ToDouble(this.tbrespuesta.Text) == (double) checked (Variables_Publicas.a1 + Variables_Publicas.b1))
      {
        this.tbrespuesta.Text = "";
        checked { Variables_Publicas.pn3 += 50; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.pn3);
        this.lbpuntos.ForeColor = Color.Blue;
        this.lbpuntos.Text = "+50";
        checked { ++Variables_Publicas.ndo; }
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            checked { Variables_Publicas.vn += 15; }
            if (Variables_Publicas.vn > 120)
              Variables_Publicas.vn = 120;
            this.lbvelocidad.Text = Conversions.ToString(Variables_Publicas.vn);
            break;
          case 2:
            Variables_Publicas.a1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
            checked { Variables_Publicas.vn += 10; }
            if (Variables_Publicas.vn > 125)
              Variables_Publicas.vn = 125;
            this.lbvelocidad.Text = Conversions.ToString(Variables_Publicas.vn);
            if (Variables_Publicas.b1 < 5)
            {
              checked { Variables_Publicas.b1 += 5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
            Variables_Publicas.b1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            checked { Variables_Publicas.vn += 5; }
            if (Variables_Publicas.vn > 130)
              Variables_Publicas.vn = 130;
            this.lbvelocidad.Text = Conversions.ToString(Variables_Publicas.vn);
            if (Variables_Publicas.b1 < 5)
              checked { Variables_Publicas.b1 += 5; }
            if (Variables_Publicas.a1 < 5)
            {
              checked { Variables_Publicas.a1 += 5; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            Variables_Publicas.b1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            checked { Variables_Publicas.vn += 5; }
            if (Variables_Publicas.vn > 140)
              Variables_Publicas.vn = 140;
            this.lbvelocidad.Text = Conversions.ToString(Variables_Publicas.vn);
            if (Variables_Publicas.a1 < 10)
              checked { Variables_Publicas.a1 += 10; }
            if (Variables_Publicas.b1 < 10)
            {
              checked { Variables_Publicas.b1 += 10; }
              break;
            }
            break;
        }
        this.lboperacion.Text = Conversions.ToString(Variables_Publicas.a1) + " + " + Conversions.ToString(Variables_Publicas.b1);
      }
      else
      {
        checked { Variables_Publicas.pn3 -= 50; }
        this.lbpuntos.ForeColor = Color.Red;
        this.lbpuntos.Text = "-50";
      }
    }

    private void br_Click(object sender, EventArgs e)
    {
      this.Close();
      MyProject.Forms.v0__menu_principal.Show();
    }

    private void bsalir_Click(object sender, EventArgs e)
    {
      Variables_Publicas.rsn3 = Interaction.InputBox("¿Deseas avandonar el nivel? ", "Salir");
      if (Operators.CompareString(Variables_Publicas.rsn1, "SI", false) == 0)
      {
        MyProject.Forms.v0__menu_principal.Show();
        this.Hide();
        Variables_Publicas.pn1 = Variables_Publicas.p;
      }
      if (Operators.CompareString(Variables_Publicas.rsn1, "si", false) == 0)
      {
        MyProject.Forms.v0__menu_principal.Show();
        this.Hide();
        Variables_Publicas.pn1 = Variables_Publicas.p;
      }
      if (Operators.CompareString(Variables_Publicas.rsn1, "Si", false) == 0)
      {
        MyProject.Forms.v0__menu_principal.Show();
        this.Hide();
        Variables_Publicas.pn1 = Variables_Publicas.p;
      }
      if (Operators.CompareString(Variables_Publicas.rsn1, "sI", false) != 0)
        return;
      MyProject.Forms.v0__menu_principal.Show();
      this.Hide();
      Variables_Publicas.pn3 = Variables_Publicas.pn3;
    }
  }
}
