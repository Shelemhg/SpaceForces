// Decompiled with JetBrains decompiler
// Type: Space_Forces.v1__nivel1
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
  public class v1__nivel1 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("pb1")]
    private PictureBox _pb1;
    [AccessedThroughProperty("lbm6")]
    private Label _lbm6;
    [AccessedThroughProperty("m6")]
    private PictureBox _m6;
    [AccessedThroughProperty("lbm4")]
    private Label _lbm4;
    [AccessedThroughProperty("m4")]
    private PictureBox _m4;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("pbv5")]
    private PictureBox _pbv5;
    [AccessedThroughProperty("pbv4")]
    private PictureBox _pbv4;
    [AccessedThroughProperty("pbv3")]
    private PictureBox _pbv3;
    [AccessedThroughProperty("pbv2")]
    private PictureBox _pbv2;
    [AccessedThroughProperty("pbv1")]
    private PictureBox _pbv1;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("lbedln")]
    private Label _lbedln;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Timer1")]
    private Timer _Timer1;
    [AccessedThroughProperty("lbm1")]
    private Label _lbm1;
    [AccessedThroughProperty("m1")]
    private PictureBox _m1;
    [AccessedThroughProperty("lbm2")]
    private Label _lbm2;
    [AccessedThroughProperty("m2")]
    private PictureBox _m2;
    [AccessedThroughProperty("lbm3")]
    private Label _lbm3;
    [AccessedThroughProperty("m3")]
    private PictureBox _m3;
    [AccessedThroughProperty("lbm5")]
    private Label _lbm5;
    [AccessedThroughProperty("m5")]
    private PictureBox _m5;
    [AccessedThroughProperty("tbrespuesta")]
    private TextBox _tbrespuesta;
    [AccessedThroughProperty("lblpuntaje")]
    private Label _lblpuntaje;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("lbnombre")]
    private Label _lbnombre;
    [AccessedThroughProperty("Timer2")]
    private Timer _Timer2;
    [AccessedThroughProperty("bpausa")]
    private Button _bpausa;
    [AccessedThroughProperty("bsalir")]
    private Button _bsalir;
    [AccessedThroughProperty("lblt")]
    private Label _lblt;
    [AccessedThroughProperty("timerminutos")]
    private Timer _timerminutos;
    [AccessedThroughProperty("Timer4")]
    private Timer _Timer4;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("rwm")]
    private AxWindowsMediaPlayer _rwm;
    [AccessedThroughProperty("lbm7")]
    private Label _lbm7;
    [AccessedThroughProperty("m7")]
    private PictureBox _m7;
    [AccessedThroughProperty("lbpuntos")]
    private Label _lbpuntos;
    [AccessedThroughProperty("lbjuegoenpausa")]
    private Label _lbjuegoenpausa;
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
    [AccessedThroughProperty("Timer3")]
    private Timer _Timer3;

    [DebuggerNonUserCode]
    public v1__nivel1()
    {
      this.Load += new EventHandler(this.v1__nivel1_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (v1__nivel1));
      this.pb1 = new PictureBox();
      this.lbm6 = new Label();
      this.m6 = new PictureBox();
      this.lbm4 = new Label();
      this.m4 = new PictureBox();
      this.PictureBox1 = new PictureBox();
      this.pbv5 = new PictureBox();
      this.pbv4 = new PictureBox();
      this.pbv3 = new PictureBox();
      this.pbv2 = new PictureBox();
      this.pbv1 = new PictureBox();
      this.Label10 = new Label();
      this.lbedln = new Label();
      this.Label4 = new Label();
      this.Timer1 = new Timer(this.components);
      this.lbm1 = new Label();
      this.m1 = new PictureBox();
      this.lbm2 = new Label();
      this.m2 = new PictureBox();
      this.lbm3 = new Label();
      this.m3 = new PictureBox();
      this.lbm5 = new Label();
      this.m5 = new PictureBox();
      this.tbrespuesta = new TextBox();
      this.lblpuntaje = new Label();
      this.Label2 = new Label();
      this.lbnombre = new Label();
      this.Timer2 = new Timer(this.components);
      this.bpausa = new Button();
      this.bsalir = new Button();
      this.lblt = new Label();
      this.timerminutos = new Timer(this.components);
      this.Timer4 = new Timer(this.components);
      this.Label1 = new Label();
      this.Label3 = new Label();
      this.rwm = new AxWindowsMediaPlayer();
      this.lbm7 = new Label();
      this.m7 = new PictureBox();
      this.lbpuntos = new Label();
      this.lbjuegoenpausa = new Label();
      this.br = new Button();
      this.PictureBox8 = new PictureBox();
      this.PictureBox7 = new PictureBox();
      this.PictureBox6 = new PictureBox();
      this.PictureBox5 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      this.Timer3 = new Timer(this.components);
      ((ISupportInitialize) this.pb1).BeginInit();
      ((ISupportInitialize) this.m6).BeginInit();
      ((ISupportInitialize) this.m4).BeginInit();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      ((ISupportInitialize) this.pbv5).BeginInit();
      ((ISupportInitialize) this.pbv4).BeginInit();
      ((ISupportInitialize) this.pbv3).BeginInit();
      ((ISupportInitialize) this.pbv2).BeginInit();
      ((ISupportInitialize) this.pbv1).BeginInit();
      ((ISupportInitialize) this.m1).BeginInit();
      ((ISupportInitialize) this.m2).BeginInit();
      ((ISupportInitialize) this.m3).BeginInit();
      ((ISupportInitialize) this.m5).BeginInit();
      this.rwm.BeginInit();
      ((ISupportInitialize) this.m7).BeginInit();
      ((ISupportInitialize) this.PictureBox8).BeginInit();
      ((ISupportInitialize) this.PictureBox7).BeginInit();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      this.SuspendLayout();
      this.pb1.BackColor = Color.Transparent;
      this.pb1.BackgroundImage = (Image) componentResourceManager.GetObject("pb1.BackgroundImage");
      this.pb1.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox pb1_1 = this.pb1;
      Point point1 = new Point(958, 227);
      Point point2 = point1;
      pb1_1.Location = point2;
      PictureBox pb1_2 = this.pb1;
      Padding padding1 = new Padding(3, 4, 3, 4);
      Padding padding2 = padding1;
      pb1_2.Margin = padding2;
      this.pb1.Name = "pb1";
      PictureBox pb1_3 = this.pb1;
      Size size1 = new Size(67, 56);
      Size size2 = size1;
      pb1_3.Size = size2;
      this.pb1.TabIndex = 0;
      this.pb1.TabStop = false;
      this.lbm6.BackColor = Color.Gray;
      this.lbm6.Font = new Font("Comic Sans MS", 12f);
      this.lbm6.ForeColor = Color.Black;
      Label lbm6_1 = this.lbm6;
      point1 = new Point(-10, 380);
      Point point3 = point1;
      lbm6_1.Location = point3;
      this.lbm6.Name = "lbm6";
      Label lbm6_2 = this.lbm6;
      size1 = new Size(85, 20);
      Size size3 = size1;
      lbm6_2.Size = size3;
      this.lbm6.TabIndex = 37;
      this.lbm6.TextAlign = ContentAlignment.MiddleCenter;
      this.lbm6.Visible = false;
      this.m6.BackColor = Color.Transparent;
      this.m6.Image = (Image) componentResourceManager.GetObject("m6.Image");
      PictureBox m6_1 = this.m6;
      point1 = new Point(-12, 364);
      Point point4 = point1;
      m6_1.Location = point4;
      PictureBox m6_2 = this.m6;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding3 = padding1;
      m6_2.Margin = padding3;
      this.m6.Name = "m6";
      PictureBox m6_3 = this.m6;
      size1 = new Size(87, 58);
      Size size4 = size1;
      m6_3.Size = size4;
      this.m6.SizeMode = PictureBoxSizeMode.StretchImage;
      this.m6.TabIndex = 36;
      this.m6.TabStop = false;
      this.m6.Visible = false;
      this.lbm4.BackColor = Color.Gray;
      this.lbm4.Font = new Font("Comic Sans MS", 12f);
      this.lbm4.ForeColor = Color.Black;
      Label lbm4_1 = this.lbm4;
      point1 = new Point(268, 190);
      Point point5 = point1;
      lbm4_1.Location = point5;
      this.lbm4.Name = "lbm4";
      Label lbm4_2 = this.lbm4;
      size1 = new Size(85, 20);
      Size size5 = size1;
      lbm4_2.Size = size5;
      this.lbm4.TabIndex = 41;
      this.lbm4.TextAlign = ContentAlignment.MiddleCenter;
      this.lbm4.Visible = false;
      this.m4.BackColor = Color.Transparent;
      this.m4.Image = (Image) componentResourceManager.GetObject("m4.Image");
      PictureBox m4_1 = this.m4;
      point1 = new Point(266, 174);
      Point point6 = point1;
      m4_1.Location = point6;
      PictureBox m4_2 = this.m4;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding4 = padding1;
      m4_2.Margin = padding4;
      this.m4.Name = "m4";
      PictureBox m4_3 = this.m4;
      size1 = new Size(87, 58);
      Size size6 = size1;
      m4_3.Size = size6;
      this.m4.SizeMode = PictureBoxSizeMode.StretchImage;
      this.m4.TabIndex = 40;
      this.m4.TabStop = false;
      this.m4.Visible = false;
      this.PictureBox1.BackColor = Color.Transparent;
      this.PictureBox1.BackgroundImage = (Image) Space_Forces.My.Resources.Resources.Tablero;
      this.PictureBox1.ErrorImage = (Image) null;
      this.PictureBox1.ImageLocation = "0,0";
      this.PictureBox1.InitialImage = (Image) null;
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(0, 440);
      Point point7 = point1;
      pictureBox1_1.Location = point7;
      PictureBox pictureBox1_2 = this.PictureBox1;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding5 = padding1;
      pictureBox1_2.Margin = padding5;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_3 = this.PictureBox1;
      size1 = new Size(1024, 160);
      Size size7 = size1;
      pictureBox1_3.Size = size7;
      this.PictureBox1.TabIndex = 35;
      this.PictureBox1.TabStop = false;
      this.pbv5.BackColor = Color.Lime;
      this.pbv5.BackgroundImage = (Image) componentResourceManager.GetObject("pbv5.BackgroundImage");
      this.pbv5.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox pbv5_1 = this.pbv5;
      point1 = new Point(711, 522);
      Point point8 = point1;
      pbv5_1.Location = point8;
      PictureBox pbv5_2 = this.pbv5;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding6 = padding1;
      pbv5_2.Margin = padding6;
      this.pbv5.Name = "pbv5";
      PictureBox pbv5_3 = this.pbv5;
      size1 = new Size(67, 56);
      Size size8 = size1;
      pbv5_3.Size = size8;
      this.pbv5.TabIndex = 42;
      this.pbv5.TabStop = false;
      this.pbv4.BackColor = Color.Lime;
      this.pbv4.BackgroundImage = (Image) componentResourceManager.GetObject("pbv4.BackgroundImage");
      this.pbv4.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox pbv4_1 = this.pbv4;
      point1 = new Point(711, 522);
      Point point9 = point1;
      pbv4_1.Location = point9;
      PictureBox pbv4_2 = this.pbv4;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding7 = padding1;
      pbv4_2.Margin = padding7;
      this.pbv4.Name = "pbv4";
      PictureBox pbv4_3 = this.pbv4;
      size1 = new Size(67, 56);
      Size size9 = size1;
      pbv4_3.Size = size9;
      this.pbv4.TabIndex = 43;
      this.pbv4.TabStop = false;
      this.pbv3.BackColor = Color.Lime;
      this.pbv3.BackgroundImage = (Image) componentResourceManager.GetObject("pbv3.BackgroundImage");
      this.pbv3.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox pbv3_1 = this.pbv3;
      point1 = new Point(711, 522);
      Point point10 = point1;
      pbv3_1.Location = point10;
      PictureBox pbv3_2 = this.pbv3;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding8 = padding1;
      pbv3_2.Margin = padding8;
      this.pbv3.Name = "pbv3";
      PictureBox pbv3_3 = this.pbv3;
      size1 = new Size(67, 56);
      Size size10 = size1;
      pbv3_3.Size = size10;
      this.pbv3.TabIndex = 44;
      this.pbv3.TabStop = false;
      this.pbv2.BackColor = Color.Lime;
      this.pbv2.BackgroundImage = (Image) componentResourceManager.GetObject("pbv2.BackgroundImage");
      this.pbv2.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox pbv2_1 = this.pbv2;
      point1 = new Point(711, 522);
      Point point11 = point1;
      pbv2_1.Location = point11;
      PictureBox pbv2_2 = this.pbv2;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding9 = padding1;
      pbv2_2.Margin = padding9;
      this.pbv2.Name = "pbv2";
      PictureBox pbv2_3 = this.pbv2;
      size1 = new Size(67, 56);
      Size size11 = size1;
      pbv2_3.Size = size11;
      this.pbv2.TabIndex = 45;
      this.pbv2.TabStop = false;
      this.pbv1.BackColor = Color.Lime;
      this.pbv1.BackgroundImage = (Image) componentResourceManager.GetObject("pbv1.BackgroundImage");
      this.pbv1.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox pbv1_1 = this.pbv1;
      point1 = new Point(711, 522);
      Point point12 = point1;
      pbv1_1.Location = point12;
      PictureBox pbv1_2 = this.pbv1;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding10 = padding1;
      pbv1_2.Margin = padding10;
      this.pbv1.Name = "pbv1";
      PictureBox pbv1_3 = this.pbv1;
      size1 = new Size(67, 56);
      Size size12 = size1;
      pbv1_3.Size = size12;
      this.pbv1.TabIndex = 46;
      this.pbv1.TabStop = false;
      this.Label10.Font = new Font("Starcraft", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label10_1 = this.Label10;
      point1 = new Point(788, 522);
      Point point13 = point1;
      label10_1.Location = point13;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(171, 26);
      Size size13 = size1;
      label10_2.Size = size13;
      this.Label10.TabIndex = 47;
      this.Label10.Text = "Estado de la Nave";
      this.Label10.TextAlign = ContentAlignment.MiddleCenter;
      this.lbedln.BackColor = Color.Lime;
      this.lbedln.Font = new Font("Starcraft", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label lbedln1 = this.lbedln;
      point1 = new Point(788, 552);
      Point point14 = point1;
      lbedln1.Location = point14;
      this.lbedln.Name = "lbedln";
      Label lbedln2 = this.lbedln;
      size1 = new Size(171, 26);
      Size size14 = size1;
      lbedln2.Size = size14;
      this.lbedln.TabIndex = 48;
      this.lbedln.Text = "Optimo";
      this.lbedln.TextAlign = ContentAlignment.MiddleCenter;
      this.Label4.BackColor = Color.Black;
      this.Label4.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.Lime;
      Label label4_1 = this.Label4;
      point1 = new Point(77, 489);
      Point point15 = point1;
      label4_1.Location = point15;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(123, 14);
      Size size15 = size1;
      label4_2.Size = size15;
      this.Label4.TabIndex = 54;
      this.Label4.Text = "Puntaje";
      this.Label4.TextAlign = ContentAlignment.MiddleCenter;
      this.Timer1.Enabled = true;
      this.Timer1.Interval = 200;
      this.lbm1.BackColor = Color.Gray;
      this.lbm1.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbm1.ForeColor = Color.Black;
      Label lbm1_1 = this.lbm1;
      point1 = new Point(220, 40);
      Point point16 = point1;
      lbm1_1.Location = point16;
      this.lbm1.Name = "lbm1";
      Label lbm1_2 = this.lbm1;
      size1 = new Size(85, 20);
      Size size16 = size1;
      lbm1_2.Size = size16;
      this.lbm1.TabIndex = 57;
      this.lbm1.TextAlign = ContentAlignment.MiddleCenter;
      this.lbm1.Visible = false;
      this.m1.BackColor = Color.Transparent;
      this.m1.Image = (Image) componentResourceManager.GetObject("m1.Image");
      PictureBox m1_1 = this.m1;
      point1 = new Point(218, 24);
      Point point17 = point1;
      m1_1.Location = point17;
      PictureBox m1_2 = this.m1;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding11 = padding1;
      m1_2.Margin = padding11;
      this.m1.Name = "m1";
      PictureBox m1_3 = this.m1;
      size1 = new Size(87, 58);
      Size size17 = size1;
      m1_3.Size = size17;
      this.m1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.m1.TabIndex = 56;
      this.m1.TabStop = false;
      this.m1.Visible = false;
      this.lbm2.BackColor = Color.Gray;
      this.lbm2.Font = new Font("Comic Sans MS", 12f);
      this.lbm2.ForeColor = Color.Black;
      Label lbm2_1 = this.lbm2;
      point1 = new Point(-11, 113);
      Point point18 = point1;
      lbm2_1.Location = point18;
      this.lbm2.Name = "lbm2";
      Label lbm2_2 = this.lbm2;
      size1 = new Size(85, 20);
      Size size18 = size1;
      lbm2_2.Size = size18;
      this.lbm2.TabIndex = 59;
      this.lbm2.TextAlign = ContentAlignment.MiddleCenter;
      this.lbm2.Visible = false;
      this.m2.BackColor = Color.Transparent;
      this.m2.Image = (Image) componentResourceManager.GetObject("m2.Image");
      PictureBox m2_1 = this.m2;
      point1 = new Point(-13, 97);
      Point point19 = point1;
      m2_1.Location = point19;
      PictureBox m2_2 = this.m2;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding12 = padding1;
      m2_2.Margin = padding12;
      this.m2.Name = "m2";
      PictureBox m2_3 = this.m2;
      size1 = new Size(87, 58);
      Size size19 = size1;
      m2_3.Size = size19;
      this.m2.SizeMode = PictureBoxSizeMode.StretchImage;
      this.m2.TabIndex = 58;
      this.m2.TabStop = false;
      this.m2.Visible = false;
      this.lbm3.BackColor = Color.Gray;
      this.lbm3.Font = new Font("Comic Sans MS", 12f);
      this.lbm3.ForeColor = Color.Black;
      Label lbm3_1 = this.lbm3;
      point1 = new Point(-63, 227);
      Point point20 = point1;
      lbm3_1.Location = point20;
      this.lbm3.Name = "lbm3";
      Label lbm3_2 = this.lbm3;
      size1 = new Size(85, 20);
      Size size20 = size1;
      lbm3_2.Size = size20;
      this.lbm3.TabIndex = 61;
      this.lbm3.TextAlign = ContentAlignment.MiddleCenter;
      this.lbm3.Visible = false;
      this.m3.BackColor = Color.Transparent;
      this.m3.Image = (Image) componentResourceManager.GetObject("m3.Image");
      PictureBox m3_1 = this.m3;
      point1 = new Point(-65, 211);
      Point point21 = point1;
      m3_1.Location = point21;
      PictureBox m3_2 = this.m3;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding13 = padding1;
      m3_2.Margin = padding13;
      this.m3.Name = "m3";
      PictureBox m3_3 = this.m3;
      size1 = new Size(87, 58);
      Size size21 = size1;
      m3_3.Size = size21;
      this.m3.SizeMode = PictureBoxSizeMode.StretchImage;
      this.m3.TabIndex = 60;
      this.m3.TabStop = false;
      this.m3.Visible = false;
      this.lbm5.BackColor = Color.Gray;
      this.lbm5.Font = new Font("Comic Sans MS", 12f);
      this.lbm5.ForeColor = Color.Black;
      Label lbm5_1 = this.lbm5;
      point1 = new Point(98, 266);
      Point point22 = point1;
      lbm5_1.Location = point22;
      this.lbm5.Name = "lbm5";
      Label lbm5_2 = this.lbm5;
      size1 = new Size(85, 20);
      Size size22 = size1;
      lbm5_2.Size = size22;
      this.lbm5.TabIndex = 63;
      this.lbm5.TextAlign = ContentAlignment.MiddleCenter;
      this.lbm5.Visible = false;
      this.m5.BackColor = Color.Transparent;
      this.m5.Image = (Image) componentResourceManager.GetObject("m5.Image");
      PictureBox m5_1 = this.m5;
      point1 = new Point(96, 250);
      Point point23 = point1;
      m5_1.Location = point23;
      PictureBox m5_2 = this.m5;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding14 = padding1;
      m5_2.Margin = padding14;
      this.m5.Name = "m5";
      PictureBox m5_3 = this.m5;
      size1 = new Size(87, 58);
      Size size23 = size1;
      m5_3.Size = size23;
      this.m5.SizeMode = PictureBoxSizeMode.StretchImage;
      this.m5.TabIndex = 62;
      this.m5.TabStop = false;
      this.m5.Visible = false;
      this.tbrespuesta.BackColor = Color.Gray;
      this.tbrespuesta.Cursor = Cursors.Hand;
      this.tbrespuesta.Font = new Font("Starcraft", 17.25f);
      this.tbrespuesta.ForeColor = Color.Lime;
      TextBox tbrespuesta1 = this.tbrespuesta;
      point1 = new Point(419, 491);
      Point point24 = point1;
      tbrespuesta1.Location = point24;
      TextBox tbrespuesta2 = this.tbrespuesta;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding15 = padding1;
      tbrespuesta2.Margin = padding15;
      this.tbrespuesta.Name = "tbrespuesta";
      TextBox tbrespuesta3 = this.tbrespuesta;
      size1 = new Size(63, 24);
      Size size24 = size1;
      tbrespuesta3.Size = size24;
      this.tbrespuesta.TabIndex = 66;
      this.lblpuntaje.BackColor = Color.Black;
      this.lblpuntaje.Font = new Font("Starcraft", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblpuntaje.ForeColor = Color.Lime;
      Label lblpuntaje1 = this.lblpuntaje;
      point1 = new Point(55, 526);
      Point point25 = point1;
      lblpuntaje1.Location = point25;
      this.lblpuntaje.Name = "lblpuntaje";
      Label lblpuntaje2 = this.lblpuntaje;
      size1 = new Size(154, 22);
      Size size25 = size1;
      lblpuntaje2.Size = size25;
      this.lblpuntaje.TabIndex = 67;
      this.lblpuntaje.TextAlign = ContentAlignment.MiddleCenter;
      this.Label2.BackColor = Color.Black;
      this.Label2.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Lime;
      Label label2_1 = this.Label2;
      point1 = new Point(402, 532);
      Point point26 = point1;
      label2_1.Location = point26;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(120, 28);
      Size size26 = size1;
      label2_2.Size = size26;
      this.Label2.TabIndex = 69;
      this.Label2.Text = "Piloto:";
      this.Label2.TextAlign = ContentAlignment.MiddleCenter;
      this.lbnombre.BackColor = Color.Black;
      this.lbnombre.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbnombre.ForeColor = Color.Lime;
      Label lbnombre1 = this.lbnombre;
      point1 = new Point(345, 563);
      Point point27 = point1;
      lbnombre1.Location = point27;
      this.lbnombre.Name = "lbnombre";
      Label lbnombre2 = this.lbnombre;
      size1 = new Size(231, 23);
      Size size27 = size1;
      lbnombre2.Size = size27;
      this.lbnombre.TabIndex = 70;
      this.lbnombre.TextAlign = ContentAlignment.MiddleCenter;
      this.Timer2.Enabled = true;
      this.Timer2.Interval = 1000;
      this.bpausa.BackColor = Color.Black;
      this.bpausa.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bpausa.ForeColor = Color.White;
      Button bpausa1 = this.bpausa;
      point1 = new Point(210, 568);
      Point point28 = point1;
      bpausa1.Location = point28;
      this.bpausa.Name = "bpausa";
      Button bpausa2 = this.bpausa;
      size1 = new Size(35, 35);
      Size size28 = size1;
      bpausa2.Size = size28;
      this.bpausa.TabIndex = 71;
      this.bpausa.Text = "II";
      this.bpausa.UseVisualStyleBackColor = false;
      this.bsalir.BackColor = Color.Black;
      this.bsalir.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bsalir.ForeColor = Color.White;
      Button bsalir1 = this.bsalir;
      point1 = new Point(12, 568);
      Point point29 = point1;
      bsalir1.Location = point29;
      this.bsalir.Name = "bsalir";
      Button bsalir2 = this.bsalir;
      size1 = new Size(36, 35);
      Size size29 = size1;
      bsalir2.Size = size29;
      this.bsalir.TabIndex = 72;
      this.bsalir.Text = "S";
      this.bsalir.UseVisualStyleBackColor = false;
      this.lblt.BackColor = Color.Black;
      this.lblt.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblt.ForeColor = Color.Lime;
      Label lblt1 = this.lblt;
      point1 = new Point(516, 501);
      Point point30 = point1;
      lblt1.Location = point30;
      this.lblt.Name = "lblt";
      Label lblt2 = this.lblt;
      size1 = new Size(120, 28);
      Size size30 = size1;
      lblt2.Size = size30;
      this.lblt.TabIndex = 73;
      this.lblt.TextAlign = ContentAlignment.MiddleCenter;
      this.timerminutos.Interval = 60000;
      this.Timer4.Enabled = true;
      this.Timer4.Interval = 1;
      this.Label1.BackColor = Color.Black;
      this.Label1.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Lime;
      Label label1_1 = this.Label1;
      point1 = new Point(516, 472);
      Point point31 = point1;
      label1_1.Location = point31;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(120, 28);
      Size size31 = size1;
      label1_2.Size = size31;
      this.Label1.TabIndex = 74;
      this.Label1.Text = "Tiempo";
      this.Label1.TextAlign = ContentAlignment.MiddleCenter;
      this.Label3.BackColor = Color.Black;
      this.Label3.Font = new Font("Starcraft", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Lime;
      Label label3_1 = this.Label3;
      point1 = new Point(263, 491);
      Point point32 = point1;
      label3_1.Location = point32;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(144, 28);
      Size size32 = size1;
      label3_2.Size = size32;
      this.Label3.TabIndex = 75;
      this.Label3.Text = "Disparar a:";
      this.Label3.TextAlign = ContentAlignment.MiddleCenter;
      this.rwm.Enabled = true;
      AxWindowsMediaPlayer rwm1 = this.rwm;
      point1 = new Point(725, 446);
      Point point33 = point1;
      rwm1.Location = point33;
      this.rwm.Name = "rwm";
      this.rwm.OcxState = (AxHost.State) componentResourceManager.GetObject("rwm.OcxState");
      AxWindowsMediaPlayer rwm2 = this.rwm;
      size1 = new Size(74, 57);
      Size size33 = size1;
      rwm2.Size = size33;
      this.rwm.TabIndex = 76;
      this.rwm.Visible = false;
      this.lbm7.BackColor = Color.Gray;
      this.lbm7.Font = new Font("Comic Sans MS", 12f);
      this.lbm7.ForeColor = Color.Black;
      Label lbm7_1 = this.lbm7;
      point1 = new Point(191, 339);
      Point point34 = point1;
      lbm7_1.Location = point34;
      this.lbm7.Name = "lbm7";
      Label lbm7_2 = this.lbm7;
      size1 = new Size(85, 20);
      Size size34 = size1;
      lbm7_2.Size = size34;
      this.lbm7.TabIndex = 78;
      this.lbm7.TextAlign = ContentAlignment.MiddleCenter;
      this.lbm7.Visible = false;
      this.m7.BackColor = Color.Transparent;
      this.m7.Image = (Image) componentResourceManager.GetObject("m7.Image");
      PictureBox m7_1 = this.m7;
      point1 = new Point(189, 323);
      Point point35 = point1;
      m7_1.Location = point35;
      PictureBox m7_2 = this.m7;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding16 = padding1;
      m7_2.Margin = padding16;
      this.m7.Name = "m7";
      PictureBox m7_3 = this.m7;
      size1 = new Size(87, 58);
      Size size35 = size1;
      m7_3.Size = size35;
      this.m7.SizeMode = PictureBoxSizeMode.StretchImage;
      this.m7.TabIndex = 77;
      this.m7.TabStop = false;
      this.m7.Visible = false;
      this.lbpuntos.BackColor = Color.Black;
      this.lbpuntos.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbpuntos.ForeColor = Color.Blue;
      Label lbpuntos1 = this.lbpuntos;
      point1 = new Point(70, 552);
      Point point36 = point1;
      lbpuntos1.Location = point36;
      this.lbpuntos.Name = "lbpuntos";
      Label lbpuntos2 = this.lbpuntos;
      size1 = new Size(116, 22);
      Size size36 = size1;
      lbpuntos2.Size = size36;
      this.lbpuntos.TabIndex = 79;
      this.lbpuntos.TextAlign = ContentAlignment.MiddleCenter;
      this.lbjuegoenpausa.BackColor = Color.Black;
      this.lbjuegoenpausa.Font = new Font("Starcraft", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbjuegoenpausa.ForeColor = Color.Lime;
      Label lbjuegoenpausa1 = this.lbjuegoenpausa;
      point1 = new Point(359, 249);
      Point point37 = point1;
      lbjuegoenpausa1.Location = point37;
      this.lbjuegoenpausa.Name = "lbjuegoenpausa";
      Label lbjuegoenpausa2 = this.lbjuegoenpausa;
      size1 = new Size(307, 102);
      Size size37 = size1;
      lbjuegoenpausa2.Size = size37;
      this.lbjuegoenpausa.TabIndex = 82;
      this.lbjuegoenpausa.Text = "Juego en Pausa";
      this.lbjuegoenpausa.TextAlign = ContentAlignment.MiddleCenter;
      this.lbjuegoenpausa.Visible = false;
      this.br.BackColor = Color.Black;
      this.br.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.br.ForeColor = Color.White;
      Button br1 = this.br;
      point1 = new Point(12, 465);
      Point point38 = point1;
      br1.Location = point38;
      this.br.Name = "br";
      Button br2 = this.br;
      size1 = new Size(36, 35);
      Size size38 = size1;
      br2.Size = size38;
      this.br.TabIndex = 83;
      this.br.Text = "R";
      this.br.UseVisualStyleBackColor = false;
      this.PictureBox8.BackColor = Color.Transparent;
      this.PictureBox8.Cursor = Cursors.Hand;
      PictureBox pictureBox8_1 = this.PictureBox8;
      point1 = new Point(674, 439);
      Point point39 = point1;
      pictureBox8_1.Location = point39;
      this.PictureBox8.Name = "PictureBox8";
      PictureBox pictureBox8_2 = this.PictureBox8;
      size1 = new Size(75, 13);
      Size size39 = size1;
      pictureBox8_2.Size = size39;
      this.PictureBox8.TabIndex = 112;
      this.PictureBox8.TabStop = false;
      this.PictureBox7.BackColor = Color.Transparent;
      this.PictureBox7.Cursor = Cursors.Hand;
      PictureBox pictureBox7_1 = this.PictureBox7;
      point1 = new Point(748, 440);
      Point point40 = point1;
      pictureBox7_1.Location = point40;
      this.PictureBox7.Name = "PictureBox7";
      PictureBox pictureBox7_2 = this.PictureBox7;
      size1 = new Size(75, 21);
      Size size40 = size1;
      pictureBox7_2.Size = size40;
      this.PictureBox7.TabIndex = 111;
      this.PictureBox7.TabStop = false;
      this.PictureBox6.BackColor = Color.Transparent;
      this.PictureBox6.Cursor = Cursors.Hand;
      PictureBox pictureBox6_1 = this.PictureBox6;
      point1 = new Point(813, 440);
      Point point41 = point1;
      pictureBox6_1.Location = point41;
      this.PictureBox6.Name = "PictureBox6";
      PictureBox pictureBox6_2 = this.PictureBox6;
      size1 = new Size(75, 29);
      Size size41 = size1;
      pictureBox6_2.Size = size41;
      this.PictureBox6.TabIndex = 110;
      this.PictureBox6.TabStop = false;
      this.PictureBox5.BackColor = Color.Transparent;
      this.PictureBox5.Cursor = Cursors.Hand;
      PictureBox pictureBox5_1 = this.PictureBox5;
      point1 = new Point(884, 440);
      Point point42 = point1;
      pictureBox5_1.Location = point42;
      this.PictureBox5.Name = "PictureBox5";
      PictureBox pictureBox5_2 = this.PictureBox5;
      size1 = new Size(75, 35);
      Size size42 = size1;
      pictureBox5_2.Size = size42;
      this.PictureBox5.TabIndex = 109;
      this.PictureBox5.TabStop = false;
      this.PictureBox4.BackColor = Color.Transparent;
      this.PictureBox4.Cursor = Cursors.Hand;
      PictureBox pictureBox4_1 = this.PictureBox4;
      point1 = new Point(952, 440);
      Point point43 = point1;
      pictureBox4_1.Location = point43;
      this.PictureBox4.Name = "PictureBox4";
      PictureBox pictureBox4_2 = this.PictureBox4;
      size1 = new Size(75, 39);
      Size size43 = size1;
      pictureBox4_2.Size = size43;
      this.PictureBox4.TabIndex = 108;
      this.PictureBox4.TabStop = false;
      this.Timer3.Enabled = true;
      this.Timer3.Interval = 30000;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      size1 = new Size(1024, 600);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.PictureBox8);
      this.Controls.Add((Control) this.PictureBox7);
      this.Controls.Add((Control) this.PictureBox6);
      this.Controls.Add((Control) this.PictureBox5);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.br);
      this.Controls.Add((Control) this.lbjuegoenpausa);
      this.Controls.Add((Control) this.lbpuntos);
      this.Controls.Add((Control) this.lbm7);
      this.Controls.Add((Control) this.m7);
      this.Controls.Add((Control) this.rwm);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.lblt);
      this.Controls.Add((Control) this.bsalir);
      this.Controls.Add((Control) this.bpausa);
      this.Controls.Add((Control) this.lbnombre);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.lblpuntaje);
      this.Controls.Add((Control) this.tbrespuesta);
      this.Controls.Add((Control) this.lbm5);
      this.Controls.Add((Control) this.m5);
      this.Controls.Add((Control) this.lbm3);
      this.Controls.Add((Control) this.m3);
      this.Controls.Add((Control) this.lbm2);
      this.Controls.Add((Control) this.m2);
      this.Controls.Add((Control) this.lbm1);
      this.Controls.Add((Control) this.m1);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.lbedln);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.pbv1);
      this.Controls.Add((Control) this.pbv2);
      this.Controls.Add((Control) this.pbv3);
      this.Controls.Add((Control) this.pbv4);
      this.Controls.Add((Control) this.pbv5);
      this.Controls.Add((Control) this.lbm4);
      this.Controls.Add((Control) this.m4);
      this.Controls.Add((Control) this.lbm6);
      this.Controls.Add((Control) this.m6);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.pb1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      padding1 = new Padding(3, 4, 3, 4);
      this.Margin = padding1;
      this.Name = nameof (v1__nivel1);
      this.StartPosition = FormStartPosition.CenterScreen;
      ((ISupportInitialize) this.pb1).EndInit();
      ((ISupportInitialize) this.m6).EndInit();
      ((ISupportInitialize) this.m4).EndInit();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      ((ISupportInitialize) this.pbv5).EndInit();
      ((ISupportInitialize) this.pbv4).EndInit();
      ((ISupportInitialize) this.pbv3).EndInit();
      ((ISupportInitialize) this.pbv2).EndInit();
      ((ISupportInitialize) this.pbv1).EndInit();
      ((ISupportInitialize) this.m1).EndInit();
      ((ISupportInitialize) this.m2).EndInit();
      ((ISupportInitialize) this.m3).EndInit();
      ((ISupportInitialize) this.m5).EndInit();
      this.rwm.EndInit();
      ((ISupportInitialize) this.m7).EndInit();
      ((ISupportInitialize) this.PictureBox8).EndInit();
      ((ISupportInitialize) this.PictureBox7).EndInit();
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((ISupportInitialize) this.PictureBox5).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual PictureBox pb1
    {
      [DebuggerNonUserCode] get => this._pb1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
    }

    internal virtual Label lbm6
    {
      [DebuggerNonUserCode] get => this._lbm6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbm6 = value;
    }

    internal virtual PictureBox m6
    {
      [DebuggerNonUserCode] get => this._m6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m6 = value;
    }

    internal virtual Label lbm4
    {
      [DebuggerNonUserCode] get => this._lbm4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbm4 = value;
    }

    internal virtual PictureBox m4
    {
      [DebuggerNonUserCode] get => this._m4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m4 = value;
    }

    internal virtual PictureBox PictureBox1
    {
      [DebuggerNonUserCode] get => this._PictureBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox1 = value;
    }

    internal virtual PictureBox pbv5
    {
      [DebuggerNonUserCode] get => this._pbv5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbv5 = value;
    }

    internal virtual PictureBox pbv4
    {
      [DebuggerNonUserCode] get => this._pbv4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbv4 = value;
    }

    internal virtual PictureBox pbv3
    {
      [DebuggerNonUserCode] get => this._pbv3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbv3 = value;
    }

    internal virtual PictureBox pbv2
    {
      [DebuggerNonUserCode] get => this._pbv2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbv2 = value;
    }

    internal virtual PictureBox pbv1
    {
      [DebuggerNonUserCode] get => this._pbv1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbv1 = value;
    }

    internal virtual Label Label10
    {
      [DebuggerNonUserCode] get => this._Label10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
    }

    internal virtual Label lbedln
    {
      [DebuggerNonUserCode] get => this._lbedln;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbedln = value;
    }

    internal virtual Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
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

    internal virtual Label lbm1
    {
      [DebuggerNonUserCode] get => this._lbm1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbm1 = value;
    }

    internal virtual PictureBox m1
    {
      [DebuggerNonUserCode] get => this._m1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m1 = value;
    }

    internal virtual Label lbm2
    {
      [DebuggerNonUserCode] get => this._lbm2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbm2 = value;
    }

    internal virtual PictureBox m2
    {
      [DebuggerNonUserCode] get => this._m2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m2 = value;
    }

    internal virtual Label lbm3
    {
      [DebuggerNonUserCode] get => this._lbm3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbm3 = value;
    }

    internal virtual PictureBox m3
    {
      [DebuggerNonUserCode] get => this._m3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m3 = value;
    }

    internal virtual Label lbm5
    {
      [DebuggerNonUserCode] get => this._lbm5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbm5 = value;
    }

    internal virtual PictureBox m5
    {
      [DebuggerNonUserCode] get => this._m5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m5 = value;
    }

    internal virtual TextBox tbrespuesta
    {
      [DebuggerNonUserCode] get => this._tbrespuesta;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.tbresuesta_KeyPress);
        if (this._tbrespuesta != null)
          this._tbrespuesta.KeyPress -= pressEventHandler;
        this._tbrespuesta = value;
        if (this._tbrespuesta == null)
          return;
        this._tbrespuesta.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label lblpuntaje
    {
      [DebuggerNonUserCode] get => this._lblpuntaje;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblpuntaje = value;
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual Label lbnombre
    {
      [DebuggerNonUserCode] get => this._lbnombre;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbnombre = value;
    }

    internal virtual Timer Timer2
    {
      [DebuggerNonUserCode] get => this._Timer2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer2_Tick_1);
        if (this._Timer2 != null)
          this._Timer2.Tick -= eventHandler;
        this._Timer2 = value;
        if (this._Timer2 == null)
          return;
        this._Timer2.Tick += eventHandler;
      }
    }

    internal virtual Button bpausa
    {
      [DebuggerNonUserCode] get => this._bpausa;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bpausa_Click);
        if (this._bpausa != null)
          this._bpausa.Click -= eventHandler;
        this._bpausa = value;
        if (this._bpausa == null)
          return;
        this._bpausa.Click += eventHandler;
      }
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

    internal virtual Label lblt
    {
      [DebuggerNonUserCode] get => this._lblt;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblt = value;
    }

    internal virtual Timer timerminutos
    {
      [DebuggerNonUserCode] get => this._timerminutos;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.timerminutos_Tick);
        if (this._timerminutos != null)
          this._timerminutos.Tick -= eventHandler;
        this._timerminutos = value;
        if (this._timerminutos == null)
          return;
        this._timerminutos.Tick += eventHandler;
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

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual AxWindowsMediaPlayer rwm
    {
      [DebuggerNonUserCode] get => this._rwm;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rwm = value;
    }

    internal virtual Label lbm7
    {
      [DebuggerNonUserCode] get => this._lbm7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbm7 = value;
    }

    internal virtual PictureBox m7
    {
      [DebuggerNonUserCode] get => this._m7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m7 = value;
    }

    internal virtual Label lbpuntos
    {
      [DebuggerNonUserCode] get => this._lbpuntos;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbpuntos = value;
    }

    internal virtual Label lbjuegoenpausa
    {
      [DebuggerNonUserCode] get => this._lbjuegoenpausa;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbjuegoenpausa = value;
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

    private void v1__nivel1_Load(object sender, EventArgs e)
    {
      this.tbrespuesta.Focus();
      Variables_Publicas.c = 0;
      Variables_Publicas.p = 700;
      Variables_Publicas.ct = 0;
      Variables_Publicas.ct2 = 0;
      Variables_Publicas.ctminutos = 0;
      Variables_Publicas.cthoras = 0;
      Variables_Publicas.cvm3 = 0;
      Variables_Publicas.cvm4 = 0;
      Variables_Publicas.cvm5 = 0;
      VBMath.Randomize();
      this.lbnombre.Text = Variables_Publicas.nj;
      switch (Variables_Publicas.ndd)
      {
        case 1:
          Variables_Publicas.a = 20;
          Variables_Publicas.b = 15;
          this.Timer4.Interval = 4500;
          break;
        case 2:
          Variables_Publicas.a = 40;
          Variables_Publicas.b = 30;
          this.Timer4.Interval = 3000;
          break;
        case 3:
          Variables_Publicas.a = 60;
          Variables_Publicas.b = 50;
          this.Timer4.Interval = 2000;
          break;
        case 4:
          Variables_Publicas.a = 60;
          Variables_Publicas.b = 50;
          this.Timer4.Interval = 1000;
          break;
      }
    }

    private void timerminutos_Tick(object sender, EventArgs e) => ++Variables_Publicas.ctminutos;

    private void Timer2_Tick_1(object sender, EventArgs e)
    {
      checked { ++Variables_Publicas.ct; }
      checked { ++Variables_Publicas.ct2; }
      if (Variables_Publicas.ctminutos != 3)
        return;
      this.Timer1.Enabled = false;
      this.Timer2.Enabled = false;
      Variables_Publicas.pn1 = Variables_Publicas.p;
      if (Operators.CompareString(this.lbedln.Text, "bueno", false) == 0)
        Variables_Publicas.gda = 1;
      int num = (int) Interaction.MsgBox((object) "Nivel completado");
      this.Close();
      MyProject.Forms.vp__ventanapuntaje.Show();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      checked { ++Variables_Publicas.c; }
      this.m1.Visible = true;
      this.lbm1.Visible = true;
      this.m2.Visible = true;
      this.lbm2.Visible = true;
      this.m3.Visible = true;
      this.lbm3.Visible = true;
      this.m4.Visible = true;
      this.lbm4.Visible = true;
      this.m5.Visible = true;
      this.lbm5.Visible = true;
      this.m6.Visible = true;
      this.lbm6.Visible = true;
      this.m7.Visible = true;
      this.lbm7.Visible = true;
      if (Variables_Publicas.ct == 60)
      {
        checked { ++Variables_Publicas.ctminutos; }
        Variables_Publicas.ct = 0;
      }
      if (Variables_Publicas.ctminutos == 60)
      {
        checked { ++Variables_Publicas.cthoras; }
        Variables_Publicas.ctminutos = 0;
      }
      this.lblt.Text = Conversions.ToString(Variables_Publicas.cthoras) + " : " + Conversions.ToString(Variables_Publicas.ctminutos) + " : " + Conversions.ToString(Variables_Publicas.ct);
      Variables_Publicas.ttn1 = this.lblt.Text;
      if (this.m1.Left > 1024 | Variables_Publicas.ct2 == 1)
      {
        this.lbpuntos.ForeColor = Color.Red;
        this.lbpuntos.Text = "-100";
        checked { Variables_Publicas.p -= 100; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        this.m1.Left = -700;
        this.lbm1.Left = -700;
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
      }
      Label lbm1 = this.lbm1;
      Point point1;
      ref Point local1 = ref point1;
      Point location1 = this.lbm1.Location;
      int x1 = checked (location1.X + Variables_Publicas.a);
      Point location2 = this.lbm1.Location;
      int y1 = location2.Y;
      local1 = new Point(x1, y1);
      Point point2 = point1;
      lbm1.Location = point2;
      PictureBox m1 = this.m1;
      ref Point local2 = ref location1;
      Point location3 = this.m1.Location;
      int x2 = checked (location3.X + Variables_Publicas.a);
      location2 = this.m1.Location;
      int y2 = location2.Y;
      local2 = new Point(x2, y2);
      Point point3 = location1;
      m1.Location = point3;
      this.lbm1.Text = Conversions.ToString(Variables_Publicas.a1) + " x " + Conversions.ToString(Variables_Publicas.b1);
      Variables_Publicas.r1 = new Decimal(checked (Variables_Publicas.a1 * Variables_Publicas.b1));
      if (this.m2.Left > 1024 | Variables_Publicas.ct2 == 1)
      {
        this.lbpuntos.ForeColor = Color.Red;
        this.lbpuntos.Text = "-100";
        checked { Variables_Publicas.p -= 100; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        checked { this.m2.Left -= 1100; }
        checked { this.lbm2.Left -= 1100; }
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            Variables_Publicas.b2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 31f)));
            if (Variables_Publicas.b2 < 5)
            {
              checked { Variables_Publicas.b2 += 5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 101f)));
            Variables_Publicas.b2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            if (Variables_Publicas.b2 < 50)
              checked { Variables_Publicas.b2 += 5; }
            if (Variables_Publicas.a2 < 5)
            {
              checked { Variables_Publicas.a2 += 5; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            Variables_Publicas.b2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 401f)));
            if (Variables_Publicas.a2 < 100)
              checked { Variables_Publicas.a2 += 100; }
            if (Variables_Publicas.b2 < 100)
            {
              checked { Variables_Publicas.b2 += 100; }
              break;
            }
            break;
        }
      }
      Label lbm2 = this.lbm2;
      ref Point local3 = ref location1;
      location3 = this.lbm2.Location;
      int x3 = checked (location3.X + Variables_Publicas.b);
      location2 = this.lbm2.Location;
      int y3 = location2.Y;
      local3 = new Point(x3, y3);
      Point point4 = location1;
      lbm2.Location = point4;
      PictureBox m2 = this.m2;
      ref Point local4 = ref location1;
      location3 = this.m2.Location;
      int x4 = checked (location3.X + Variables_Publicas.b);
      location2 = this.m2.Location;
      int y4 = location2.Y;
      local4 = new Point(x4, y4);
      Point point5 = location1;
      m2.Location = point5;
      this.lbm2.Text = Conversions.ToString(Variables_Publicas.a2) + " + " + Conversions.ToString(Variables_Publicas.b2);
      Variables_Publicas.r2 = new Decimal(checked (Variables_Publicas.a2 + Variables_Publicas.b2));
      if (this.m3.Left > 1024 | Variables_Publicas.ct2 == 1)
      {
        this.lbpuntos.ForeColor = Color.Red;
        this.lbpuntos.Text = "-100";
        checked { Variables_Publicas.p -= 100; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        this.m3.Left = -500;
        this.lbm3.Left = -500;
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 6f)));
            Variables_Publicas.b3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 15f)));
            if (Variables_Publicas.b3 < 5)
            {
              checked { Variables_Publicas.b3 += 5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            if (Variables_Publicas.b3 < 5)
              checked { Variables_Publicas.b3 += 5; }
            if (Variables_Publicas.a3 < 5)
            {
              checked { Variables_Publicas.a3 += 5; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
            Variables_Publicas.b3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            if (Variables_Publicas.a3 < 10)
              checked { Variables_Publicas.a3 += 10; }
            if (Variables_Publicas.b3 < 10)
            {
              checked { Variables_Publicas.b3 += 10; }
              break;
            }
            break;
        }
      }
      Label lbm3 = this.lbm3;
      ref Point local5 = ref location1;
      location3 = this.lbm3.Location;
      int x5 = checked (location3.X + Variables_Publicas.a);
      location2 = this.lbm3.Location;
      int y5 = location2.Y;
      local5 = new Point(x5, y5);
      Point point6 = location1;
      lbm3.Location = point6;
      PictureBox m3 = this.m3;
      ref Point local6 = ref location1;
      location3 = this.m3.Location;
      int x6 = checked (location3.X + Variables_Publicas.a);
      location2 = this.m3.Location;
      int y6 = location2.Y;
      local6 = new Point(x6, y6);
      Point point7 = location1;
      m3.Location = point7;
      this.lbm3.Text = Conversions.ToString(Variables_Publicas.b3) + " - " + Conversions.ToString(Variables_Publicas.a3);
      Variables_Publicas.r3 = new Decimal(checked (Variables_Publicas.b3 - Variables_Publicas.a3));
      if (this.m4.Left > 1024 | Variables_Publicas.ct2 == 1)
      {
        this.lbpuntos.ForeColor = Color.Red;
        this.lbpuntos.Text = "-100";
        checked { Variables_Publicas.p -= 100; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        this.m4.Left = -200;
        this.lbm4.Left = -200;
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            Variables_Publicas.b4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 51f)));
            if (Variables_Publicas.b4 < 5)
            {
              checked { Variables_Publicas.b4 += 5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 101f)));
            Variables_Publicas.b4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            if (Variables_Publicas.b4 < 50)
              checked { Variables_Publicas.b4 += 50; }
            if (Variables_Publicas.a4 < 30)
            {
              checked { Variables_Publicas.a4 += 30; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            Variables_Publicas.b4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 401f)));
            if (Variables_Publicas.a4 < 50)
              checked { Variables_Publicas.a4 += 50; }
            if (Variables_Publicas.b4 < 100)
            {
              checked { Variables_Publicas.b4 += 100; }
              break;
            }
            break;
        }
      }
      Label lbm4 = this.lbm4;
      ref Point local7 = ref location1;
      location3 = this.lbm4.Location;
      int x7 = checked (location3.X + Variables_Publicas.b);
      location2 = this.lbm4.Location;
      int y7 = location2.Y;
      local7 = new Point(x7, y7);
      Point point8 = location1;
      lbm4.Location = point8;
      PictureBox m4 = this.m4;
      ref Point local8 = ref location1;
      location3 = this.m4.Location;
      int x8 = checked (location3.X + Variables_Publicas.b);
      location2 = this.m4.Location;
      int y8 = location2.Y;
      local8 = new Point(x8, y8);
      Point point9 = location1;
      m4.Location = point9;
      this.lbm4.Text = Conversions.ToString(Variables_Publicas.a4) + " + " + Conversions.ToString(Variables_Publicas.b4);
      Variables_Publicas.r4 = new Decimal(checked (Variables_Publicas.a4 + Variables_Publicas.b4));
      if (this.m5.Left > 1024 | Variables_Publicas.ct2 == 1)
      {
        this.lbpuntos.ForeColor = Color.Red;
        this.lbpuntos.Text = "-100";
        checked { Variables_Publicas.p -= 100; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        this.m5.Left = -100;
        this.lbm5.Left = -100;
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
            if (Variables_Publicas.b5 < 1)
            {
              checked { ++Variables_Publicas.b5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            if (Variables_Publicas.b5 < 5)
              checked { Variables_Publicas.b5 += 5; }
            if (Variables_Publicas.a5 < 3)
            {
              checked { Variables_Publicas.a5 += 3; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
            Variables_Publicas.b5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 31f)));
            if (Variables_Publicas.a5 < 5)
              checked { Variables_Publicas.a5 += 5; }
            if (Variables_Publicas.b5 < 10)
            {
              checked { Variables_Publicas.b5 += 10; }
              break;
            }
            break;
        }
      }
      Label lbm5 = this.lbm5;
      ref Point local9 = ref location1;
      location3 = this.lbm5.Location;
      int x9 = checked (location3.X + Variables_Publicas.a);
      location2 = this.lbm5.Location;
      int y9 = location2.Y;
      local9 = new Point(x9, y9);
      Point point10 = location1;
      lbm5.Location = point10;
      PictureBox m5 = this.m5;
      ref Point local10 = ref location1;
      location3 = this.m5.Location;
      int x10 = checked (location3.X + Variables_Publicas.a);
      location2 = this.m5.Location;
      int y10 = location2.Y;
      local10 = new Point(x10, y10);
      Point point11 = location1;
      m5.Location = point11;
      this.lbm5.Text = Conversions.ToString(Variables_Publicas.a5) + " x " + Conversions.ToString(Variables_Publicas.b5);
      Variables_Publicas.r5 = new Decimal(checked (Variables_Publicas.a5 * Variables_Publicas.b5));
      if (this.m6.Left > 1024 | Variables_Publicas.ct2 == 1)
      {
        this.lbpuntos.ForeColor = Color.Red;
        this.lbpuntos.Text = "-100";
        checked { Variables_Publicas.p -= 100; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        this.m6.Left = -200;
        this.lbm6.Left = -200;
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            Variables_Publicas.b6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 31f)));
            if (Variables_Publicas.b6 < 5)
            {
              checked { Variables_Publicas.b6 += 5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 106f)));
            Variables_Publicas.b6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            if (Variables_Publicas.b6 < 50)
              checked { Variables_Publicas.b6 += 50; }
            if (Variables_Publicas.a6 < 30)
            {
              checked { Variables_Publicas.a6 += 30; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            Variables_Publicas.b6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 401f)));
            if (Variables_Publicas.a6 < 50)
              checked { Variables_Publicas.a6 += 50; }
            if (Variables_Publicas.b6 < 100)
            {
              checked { Variables_Publicas.b6 += 100; }
              break;
            }
            break;
        }
      }
      Label lbm6 = this.lbm6;
      ref Point local11 = ref location1;
      location3 = this.lbm6.Location;
      int x11 = checked (location3.X + Variables_Publicas.a);
      location2 = this.lbm6.Location;
      int y11 = location2.Y;
      local11 = new Point(x11, y11);
      Point point12 = location1;
      lbm6.Location = point12;
      PictureBox m6 = this.m6;
      ref Point local12 = ref location1;
      location3 = this.m6.Location;
      int x12 = checked (location3.X + Variables_Publicas.a);
      location2 = this.m6.Location;
      int y12 = location2.Y;
      local12 = new Point(x12, y12);
      Point point13 = location1;
      m6.Location = point13;
      this.lbm6.Text = Conversions.ToString(Variables_Publicas.a6) + " + " + Conversions.ToString(Variables_Publicas.b6);
      Variables_Publicas.r6 = new Decimal(checked (Variables_Publicas.a6 + Variables_Publicas.b6));
      if (this.m7.Left > 1024 | Variables_Publicas.ct2 == 1)
      {
        this.lbpuntos.ForeColor = Color.Red;
        this.lbpuntos.Text = "-100";
        checked { Variables_Publicas.p -= 100; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        this.m7.Left = -100;
        this.lbm7.Left = -100;
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 6f)));
            Variables_Publicas.b7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 15f)));
            if (Variables_Publicas.b7 < 5)
            {
              checked { Variables_Publicas.b7 += 5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            if (Variables_Publicas.b7 < 5)
              checked { Variables_Publicas.b7 += 5; }
            if (Variables_Publicas.a7 < 5)
            {
              checked { Variables_Publicas.a7 += 5; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
            Variables_Publicas.b7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            if (Variables_Publicas.a7 < 10)
              checked { Variables_Publicas.a7 += 10; }
            if (Variables_Publicas.b7 < 10)
            {
              checked { Variables_Publicas.b7 += 10; }
              break;
            }
            break;
        }
      }
      Label lbm7 = this.lbm7;
      ref Point local13 = ref location1;
      location3 = this.lbm7.Location;
      int x13 = checked (location3.X + Variables_Publicas.b);
      location2 = this.lbm7.Location;
      int y13 = location2.Y;
      local13 = new Point(x13, y13);
      Point point14 = location1;
      lbm7.Location = point14;
      PictureBox m7 = this.m7;
      ref Point local14 = ref location1;
      location3 = this.m7.Location;
      int x14 = checked (location3.X + Variables_Publicas.b);
      location2 = this.m7.Location;
      int y14 = location2.Y;
      local14 = new Point(x14, y14);
      Point point15 = location1;
      m7.Location = point15;
      this.lbm7.Text = Conversions.ToString(Variables_Publicas.b7) + " - " + Conversions.ToString(Variables_Publicas.a7);
      Variables_Publicas.r7 = new Decimal(checked (Variables_Publicas.b7 - Variables_Publicas.a7));
    }

    private void tbresuesta_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Strings.Asc(e.KeyChar) != 13)
        return;
      VBMath.Randomize();
      string text = this.tbrespuesta.Text;
      if (Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.a1 * Variables_Publicas.b1)), false) == 0)
      {
        this.m1.Left = -400;
        this.lbm1.Left = -400;
        this.lbpuntos.ForeColor = Color.Blue;
        this.lbpuntos.Text = "+200";
        checked { Variables_Publicas.p += 200; }
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
      }
      else if (Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.a2 + Variables_Publicas.b2)), false) == 0)
      {
        this.m2.Left = -350;
        this.lbm2.Left = -350;
        this.lbpuntos.ForeColor = Color.Blue;
        this.lbpuntos.Text = "+100";
        checked { Variables_Publicas.p += 100; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 15f)));
            if (Variables_Publicas.b2 < 5)
            {
              checked { Variables_Publicas.b2 += 5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
            Variables_Publicas.b2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            if (Variables_Publicas.b2 < 5)
              checked { Variables_Publicas.b2 += 5; }
            if (Variables_Publicas.a2 < 5)
            {
              checked { Variables_Publicas.a2 += 5; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            Variables_Publicas.b2 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            if (Variables_Publicas.a2 < 10)
              checked { Variables_Publicas.a2 += 10; }
            if (Variables_Publicas.b2 < 10)
            {
              checked { Variables_Publicas.b2 += 10; }
              break;
            }
            break;
        }
      }
      else if (Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.b3 - Variables_Publicas.a3)), false) == 0)
      {
        this.m3.Left = -300;
        this.lbm3.Left = -300;
        this.lbpuntos.ForeColor = Color.Blue;
        this.lbpuntos.Text = "+100";
        checked { Variables_Publicas.p += 100; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 15f)));
            if (Variables_Publicas.b3 < 5)
            {
              checked { Variables_Publicas.b3 += 5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
            Variables_Publicas.b3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            if (Variables_Publicas.b3 < 5)
              checked { Variables_Publicas.b3 += 5; }
            if (Variables_Publicas.a3 < 5)
            {
              checked { Variables_Publicas.a3 += 5; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            Variables_Publicas.b3 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            if (Variables_Publicas.a3 < 10)
              checked { Variables_Publicas.a3 += 10; }
            if (Variables_Publicas.b3 < 10)
            {
              checked { Variables_Publicas.b3 += 10; }
              break;
            }
            break;
        }
      }
      else if (Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.a4 + Variables_Publicas.b4)), false) == 0)
      {
        this.m4.Left = -200;
        this.lbm4.Left = -200;
        this.lbpuntos.ForeColor = Color.Blue;
        this.lbpuntos.Text = "+100";
        checked { Variables_Publicas.p += 100; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            Variables_Publicas.b4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 51f)));
            if (Variables_Publicas.b4 < 5)
            {
              checked { Variables_Publicas.b4 += 5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 101f)));
            Variables_Publicas.b4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            if (Variables_Publicas.b4 < 50)
              checked { Variables_Publicas.b4 += 50; }
            if (Variables_Publicas.a4 < 30)
            {
              checked { Variables_Publicas.a4 += 30; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            Variables_Publicas.b4 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 401f)));
            if (Variables_Publicas.a4 < 50)
              checked { Variables_Publicas.a4 += 50; }
            if (Variables_Publicas.b4 < 100)
            {
              checked { Variables_Publicas.b4 += 100; }
              break;
            }
            break;
        }
      }
      else if (Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.a5 * Variables_Publicas.b5)), false) == 0)
      {
        this.m5.Left = -100;
        this.lbm5.Left = -100;
        this.lbpuntos.ForeColor = Color.Blue;
        this.lbpuntos.Text = "+200";
        checked { Variables_Publicas.p += 200; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
            if (Variables_Publicas.b5 < 1)
            {
              checked { ++Variables_Publicas.b5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            if (Variables_Publicas.b5 < 5)
              checked { Variables_Publicas.b5 += 5; }
            if (Variables_Publicas.a5 < 3)
            {
              checked { Variables_Publicas.a5 += 3; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
            Variables_Publicas.b5 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 31f)));
            if (Variables_Publicas.a5 < 5)
              checked { Variables_Publicas.a5 += 5; }
            if (Variables_Publicas.b5 < 10)
            {
              checked { Variables_Publicas.b5 += 10; }
              break;
            }
            break;
        }
      }
      else if (Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.a6 + Variables_Publicas.b6)), false) == 0)
      {
        this.m6.Left = -200;
        this.lbm6.Left = -200;
        checked { Variables_Publicas.p += 100; }
        this.lbpuntos.ForeColor = Color.Blue;
        this.lbpuntos.Text = "+100";
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            Variables_Publicas.b6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 31f)));
            if (Variables_Publicas.b6 < 5)
            {
              checked { Variables_Publicas.b6 += 5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 106f)));
            Variables_Publicas.b6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            if (Variables_Publicas.b6 < 50)
              checked { Variables_Publicas.b6 += 50; }
            if (Variables_Publicas.a6 < 30)
            {
              checked { Variables_Publicas.a6 += 30; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            Variables_Publicas.b6 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 401f)));
            if (Variables_Publicas.a6 < 50)
              checked { Variables_Publicas.a6 += 50; }
            if (Variables_Publicas.b6 < 100)
            {
              checked { Variables_Publicas.b6 += 100; }
              break;
            }
            break;
        }
      }
      else if (Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.b7 - Variables_Publicas.a7)), false) == 0)
      {
        this.m7.Left = -200;
        this.lbm7.Left = -200;
        this.lbpuntos.ForeColor = Color.Blue;
        this.lbpuntos.Text = "+100";
        checked { Variables_Publicas.p += 100; }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
        switch (Variables_Publicas.ndd)
        {
          case 1:
            Variables_Publicas.a7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.b7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            break;
          case 2:
            Variables_Publicas.a7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
            Variables_Publicas.b7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 31f)));
            if (Variables_Publicas.b7 < 5)
            {
              checked { Variables_Publicas.b7 += 5; }
              break;
            }
            break;
          case 3:
            Variables_Publicas.a7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 106f)));
            Variables_Publicas.b7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            if (Variables_Publicas.b7 < 50)
              checked { Variables_Publicas.b7 += 50; }
            if (Variables_Publicas.a7 < 30)
            {
              checked { Variables_Publicas.a7 += 30; }
              break;
            }
            break;
          case 4:
            Variables_Publicas.a7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 201f)));
            Variables_Publicas.b7 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 401f)));
            if (Variables_Publicas.a7 < 50)
              checked { Variables_Publicas.a7 += 50; }
            if (Variables_Publicas.b7 < 100)
            {
              checked { Variables_Publicas.b7 += 100; }
              break;
            }
            break;
        }
      }
      else if (Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.a1 * Variables_Publicas.a2)), false) != 0 || Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.a2 + Variables_Publicas.b2)), false) != 0 || Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.b3 - Variables_Publicas.a3)), false) != 0 || Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.a4 + Variables_Publicas.b4)), false) != 0 || Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.a5 * Variables_Publicas.b5)), false) != 0 || Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.a6 + Variables_Publicas.b6)), false) != 0 || Operators.CompareString(text, Conversions.ToString(checked (Variables_Publicas.b7 - Variables_Publicas.a7)), false) != 0)
      {
        if (Variables_Publicas.ndd == 1)
        {
          this.lbpuntos.ForeColor = Color.Red;
          this.lbpuntos.Text = " -10";
          checked { Variables_Publicas.p -= 10; }
        }
        if (Variables_Publicas.ndd == 2)
        {
          this.lbpuntos.ForeColor = Color.Red;
          this.lbpuntos.Text = "-50";
          checked { Variables_Publicas.p -= 50; }
        }
        if (Variables_Publicas.ndd == 3)
        {
          this.lbpuntos.ForeColor = Color.Red;
          this.lbpuntos.Text = "-100";
          checked { Variables_Publicas.p -= 100; }
        }
        if (Variables_Publicas.ndd == 4)
        {
          this.lbpuntos.ForeColor = Color.Red;
          this.lbpuntos.Text = "-300";
          checked { Variables_Publicas.p -= 300; }
        }
        this.lblpuntaje.Text = Conversions.ToString(Variables_Publicas.p);
      }
      this.tbrespuesta.Text = "";
    }

    private void bpausa_Click(object sender, EventArgs e)
    {
      if (!Variables_Publicas.pausa)
      {
        Variables_Publicas.pausa = true;
        this.Timer1.Enabled = false;
        this.Timer2.Enabled = false;
        this.lbm1.Visible = false;
        this.lbm2.Visible = false;
        this.lbm3.Visible = false;
        this.lbm4.Visible = false;
        this.lbm5.Visible = false;
        this.lbm6.Visible = false;
        this.lbm7.Visible = false;
        this.lbjuegoenpausa.Visible = true;
      }
      else
      {
        Variables_Publicas.pausa = false;
        this.Timer1.Enabled = true;
        this.Timer2.Enabled = true;
        this.lbm1.Visible = true;
        this.lbm2.Visible = true;
        this.lbm3.Visible = true;
        this.lbm4.Visible = true;
        this.lbm5.Visible = true;
        this.lbm6.Visible = true;
        this.lbm7.Visible = true;
        this.lbjuegoenpausa.Visible = false;
      }
    }

    private void bsalir_Click(object sender, EventArgs e)
    {
      Variables_Publicas.rsn1 = Interaction.InputBox("¿Deseas avandonar el nivel? ", "Salir");
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
      Variables_Publicas.pn1 = Variables_Publicas.p;
    }

    private void Timer4_Tick(object sender, EventArgs e)
    {
      if (this.m3.Left > 970)
      {
        if (this.pbv1.Visible)
        {
          this.pbv1.Visible = false;
          this.lbedln.Text = "bueno";
          this.lbedln.BackColor = Color.Yellow;
        }
        else if (!this.pbv1.Visible)
        {
          if (this.pbv2.Visible)
          {
            this.pbv2.Visible = false;
            this.lbedln.Text = "Regular";
            this.lbedln.BackColor = Color.Orange;
          }
          else if (this.pbv3.Visible)
          {
            this.pbv3.Visible = false;
            this.lbedln.Text = "Malo";
            this.lbedln.BackColor = Color.Red;
          }
          else
          {
            this.pbv4.Visible = false;
            this.lbedln.Text = "Inservible";
            this.lbedln.BackColor = Color.Black;
            this.lbedln.ForeColor = Color.White;
            this.lbpuntos.ForeColor = Color.Red;
            this.lbpuntos.Text = Conversions.ToString(-1500);
            checked { Variables_Publicas.p -= 1500; }
            Variables_Publicas.gda = 0;
          }
        }
      }
      if (this.m4.Left > 970)
      {
        if (this.pbv1.Visible)
        {
          this.pbv1.Visible = false;
          this.lbedln.Text = "bueno";
          this.lbedln.BackColor = Color.Yellow;
        }
        else if (!this.pbv1.Visible)
        {
          if (this.pbv2.Visible)
          {
            this.pbv2.Visible = false;
            this.lbedln.Text = "Regular";
            this.lbedln.BackColor = Color.Orange;
          }
          else if (this.pbv3.Visible)
          {
            this.pbv3.Visible = false;
            this.lbedln.Text = "Malo";
            this.lbedln.BackColor = Color.Red;
          }
          else
          {
            this.pbv4.Visible = false;
            this.lbedln.Text = "Inservible";
            this.lbedln.BackColor = Color.Black;
            this.lbedln.ForeColor = Color.White;
            this.lbpuntos.ForeColor = Color.Red;
            this.lbpuntos.Text = Conversions.ToString(-1500);
            checked { Variables_Publicas.p -= 1500; }
            Variables_Publicas.gda = 0;
          }
        }
      }
      if (this.m5.Left <= 970)
        return;
      if (this.pbv1.Visible)
      {
        this.pbv1.Visible = false;
        this.lbedln.Text = "bueno";
        this.lbedln.BackColor = Color.Yellow;
      }
      else
      {
        if (this.pbv1.Visible)
          return;
        if (this.pbv2.Visible)
        {
          this.pbv2.Visible = false;
          this.lbedln.Text = "Regular";
          this.lbedln.BackColor = Color.Orange;
        }
        else if (this.pbv3.Visible)
        {
          this.pbv3.Visible = false;
          this.lbedln.Text = "Malo";
          this.lbedln.BackColor = Color.Red;
        }
        else
        {
          this.pbv4.Visible = false;
          this.lbedln.Text = "Inservible";
          this.lbedln.BackColor = Color.Black;
          this.lbedln.ForeColor = Color.White;
          this.lbpuntos.ForeColor = Color.Red;
          this.lbpuntos.Text = Conversions.ToString(-1500);
          checked { Variables_Publicas.p -= 1500; }
        }
      }
    }

    private void br_Click(object sender, EventArgs e)
    {
      this.Close();
      MyProject.Forms.v0__menu_principal.Show();
    }

    private void Timer3_Tick(object sender, EventArgs e)
    {
      checked { Variables_Publicas.a += 20; }
      checked { Variables_Publicas.b += 20; }
      if (Variables_Publicas.a > 80)
        Variables_Publicas.a = 80;
      if (Variables_Publicas.b <= 90)
        return;
      Variables_Publicas.b = 90;
    }
  }
}
