// Decompiled with JetBrains decompiler
// Type: Space_Forces.v2__nivel2
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
  public class v2__nivel2 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;
    [AccessedThroughProperty("m1")]
    private PictureBox _m1;
    [AccessedThroughProperty("lbcoordenadas")]
    private Label _lbcoordenadas;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("tbcoordenada")]
    private TextBox _tbcoordenada;
    [AccessedThroughProperty("lbnombre")]
    private Label _lbnombre;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("lbdistanciadelmeteorito")]
    private Label _lbdistanciadelmeteorito;
    [AccessedThroughProperty("Timer1")]
    private Timer _Timer1;
    [AccessedThroughProperty("rwm")]
    private AxWindowsMediaPlayer _rwm;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("lbedln")]
    private Label _lbedln;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("pbv1")]
    private PictureBox _pbv1;
    [AccessedThroughProperty("pbv2")]
    private PictureBox _pbv2;
    [AccessedThroughProperty("pbv3")]
    private PictureBox _pbv3;
    [AccessedThroughProperty("pbv4")]
    private PictureBox _pbv4;
    [AccessedThroughProperty("pbv5")]
    private PictureBox _pbv5;
    [AccessedThroughProperty("bsalir")]
    private Button _bsalir;
    [AccessedThroughProperty("bpausa")]
    private Button _bpausa;
    [AccessedThroughProperty("lbcoordenadasfaltantes")]
    private Label _lbcoordenadasfaltantes;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("m3")]
    private PictureBox _m3;
    [AccessedThroughProperty("Timer2")]
    private Timer _Timer2;
    [AccessedThroughProperty("m2")]
    private PictureBox _m2;
    [AccessedThroughProperty("m4")]
    private PictureBox _m4;
    [AccessedThroughProperty("m5")]
    private PictureBox _m5;
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

    [DebuggerNonUserCode]
    public v2__nivel2()
    {
      this.Load += new EventHandler(this.v2__nivel2_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (v2__nivel2));
      this.PictureBox2 = new PictureBox();
      this.m1 = new PictureBox();
      this.lbcoordenadas = new Label();
      this.Label1 = new Label();
      this.tbcoordenada = new TextBox();
      this.lbnombre = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.lbdistanciadelmeteorito = new Label();
      this.Timer1 = new Timer(this.components);
      this.rwm = new AxWindowsMediaPlayer();
      this.Label5 = new Label();
      this.lbedln = new Label();
      this.Label10 = new Label();
      this.pbv1 = new PictureBox();
      this.pbv2 = new PictureBox();
      this.pbv3 = new PictureBox();
      this.pbv4 = new PictureBox();
      this.pbv5 = new PictureBox();
      this.bsalir = new Button();
      this.bpausa = new Button();
      this.lbcoordenadasfaltantes = new Label();
      this.Label4 = new Label();
      this.m3 = new PictureBox();
      this.Timer2 = new Timer(this.components);
      this.m2 = new PictureBox();
      this.m4 = new PictureBox();
      this.m5 = new PictureBox();
      this.lbjuegoenpausa = new Label();
      this.br = new Button();
      this.PictureBox8 = new PictureBox();
      this.PictureBox7 = new PictureBox();
      this.PictureBox6 = new PictureBox();
      this.PictureBox5 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      ((ISupportInitialize) this.m1).BeginInit();
      this.rwm.BeginInit();
      ((ISupportInitialize) this.pbv1).BeginInit();
      ((ISupportInitialize) this.pbv2).BeginInit();
      ((ISupportInitialize) this.pbv3).BeginInit();
      ((ISupportInitialize) this.pbv4).BeginInit();
      ((ISupportInitialize) this.pbv5).BeginInit();
      ((ISupportInitialize) this.m3).BeginInit();
      ((ISupportInitialize) this.m2).BeginInit();
      ((ISupportInitialize) this.m4).BeginInit();
      ((ISupportInitialize) this.m5).BeginInit();
      ((ISupportInitialize) this.PictureBox8).BeginInit();
      ((ISupportInitialize) this.PictureBox7).BeginInit();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      this.SuspendLayout();
      this.PictureBox2.BackColor = Color.Transparent;
      this.PictureBox2.BackgroundImage = (Image) Space_Forces.My.Resources.Resources.Tablero;
      this.PictureBox2.Image = (Image) componentResourceManager.GetObject("PictureBox2.Image");
      PictureBox pictureBox2_1 = this.PictureBox2;
      Point point1 = new Point(0, 441);
      Point point2 = point1;
      pictureBox2_1.Location = point2;
      this.PictureBox2.Name = "PictureBox2";
      PictureBox pictureBox2_2 = this.PictureBox2;
      Size size1 = new Size(1024, 159);
      Size size2 = size1;
      pictureBox2_2.Size = size2;
      this.PictureBox2.TabIndex = 12;
      this.PictureBox2.TabStop = false;
      this.m1.BackColor = Color.Transparent;
      this.m1.BackgroundImage = (Image) componentResourceManager.GetObject("m1.BackgroundImage");
      this.m1.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox m1_1 = this.m1;
      point1 = new Point(90, 75);
      Point point3 = point1;
      m1_1.Location = point3;
      this.m1.Name = "m1";
      PictureBox m1_2 = this.m1;
      size1 = new Size(10, 10);
      Size size3 = size1;
      m1_2.Size = size3;
      this.m1.TabIndex = 13;
      this.m1.TabStop = false;
      this.lbcoordenadas.BackColor = Color.Black;
      this.lbcoordenadas.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbcoordenadas.ForeColor = Color.Lime;
      Label lbcoordenadas1 = this.lbcoordenadas;
      point1 = new Point(257, 506);
      Point point4 = point1;
      lbcoordenadas1.Location = point4;
      this.lbcoordenadas.Name = "lbcoordenadas";
      Label lbcoordenadas2 = this.lbcoordenadas;
      size1 = new Size(211, 23);
      Size size4 = size1;
      lbcoordenadas2.Size = size4;
      this.lbcoordenadas.TabIndex = 14;
      this.lbcoordenadas.TextAlign = ContentAlignment.MiddleRight;
      this.Label1.BackColor = Color.Black;
      this.Label1.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Lime;
      Label label1_1 = this.Label1;
      point1 = new Point(292, 474);
      Point point5 = point1;
      label1_1.Location = point5;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(215, 23);
      Size size5 = size1;
      label1_2.Size = size5;
      this.Label1.TabIndex = 15;
      this.Label1.Text = "Coordenadas";
      this.Label1.TextAlign = ContentAlignment.MiddleCenter;
      this.tbcoordenada.BackColor = Color.Gray;
      this.tbcoordenada.Cursor = Cursors.Hand;
      this.tbcoordenada.Font = new Font("Starcraft", 15.75f);
      this.tbcoordenada.ForeColor = Color.Lime;
      TextBox tbcoordenada1 = this.tbcoordenada;
      point1 = new Point(471, 506);
      Point point6 = point1;
      tbcoordenada1.Location = point6;
      this.tbcoordenada.Name = "tbcoordenada";
      TextBox tbcoordenada2 = this.tbcoordenada;
      size1 = new Size(71, 23);
      Size size6 = size1;
      tbcoordenada2.Size = size6;
      this.tbcoordenada.TabIndex = 16;
      this.lbnombre.BackColor = Color.Black;
      this.lbnombre.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbnombre.ForeColor = Color.Lime;
      Label lbnombre1 = this.lbnombre;
      point1 = new Point(347, 568);
      Point point7 = point1;
      lbnombre1.Location = point7;
      this.lbnombre.Name = "lbnombre";
      Label lbnombre2 = this.lbnombre;
      size1 = new Size(231, 23);
      Size size7 = size1;
      lbnombre2.Size = size7;
      this.lbnombre.TabIndex = 72;
      this.lbnombre.TextAlign = ContentAlignment.MiddleCenter;
      this.Label2.BackColor = Color.Black;
      this.Label2.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Lime;
      Label label2_1 = this.Label2;
      point1 = new Point(404, 537);
      Point point8 = point1;
      label2_1.Location = point8;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(120, 28);
      Size size8 = size1;
      label2_2.Size = size8;
      this.Label2.TabIndex = 71;
      this.Label2.Text = "Piloto:";
      this.Label2.TextAlign = ContentAlignment.MiddleCenter;
      this.Label3.BackColor = Color.Black;
      this.Label3.Font = new Font("Starcraft", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Lime;
      Label label3_1 = this.Label3;
      point1 = new Point(70, 490);
      Point point9 = point1;
      label3_1.Location = point9;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(131, 43);
      Size size9 = size1;
      label3_2.Size = size9;
      this.Label3.TabIndex = 73;
      this.Label3.Text = "Distancia del Meteorito";
      this.Label3.TextAlign = ContentAlignment.MiddleCenter;
      this.lbdistanciadelmeteorito.BackColor = Color.Black;
      this.lbdistanciadelmeteorito.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbdistanciadelmeteorito.ForeColor = Color.Lime;
      Label lbdistanciadelmeteorito1 = this.lbdistanciadelmeteorito;
      point1 = new Point(62, 538);
      Point point10 = point1;
      lbdistanciadelmeteorito1.Location = point10;
      this.lbdistanciadelmeteorito.Name = "lbdistanciadelmeteorito";
      Label lbdistanciadelmeteorito2 = this.lbdistanciadelmeteorito;
      size1 = new Size(114, 28);
      Size size10 = size1;
      lbdistanciadelmeteorito2.Size = size10;
      this.lbdistanciadelmeteorito.TabIndex = 74;
      this.lbdistanciadelmeteorito.TextAlign = ContentAlignment.MiddleRight;
      this.Timer1.Enabled = true;
      this.rwm.Enabled = true;
      AxWindowsMediaPlayer rwm1 = this.rwm;
      point1 = new Point(653, 427);
      Point point11 = point1;
      rwm1.Location = point11;
      this.rwm.Name = "rwm";
      this.rwm.OcxState = (AxHost.State) componentResourceManager.GetObject("rwm.OcxState");
      AxWindowsMediaPlayer rwm2 = this.rwm;
      size1 = new Size(65, 57);
      Size size11 = size1;
      rwm2.Size = size11;
      this.rwm.TabIndex = 75;
      this.rwm.Visible = false;
      this.Label5.BackColor = Color.Black;
      this.Label5.Font = new Font("Starcraft", 17.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.Lime;
      Label label5_1 = this.Label5;
      point1 = new Point(180, 538);
      Point point12 = point1;
      label5_1.Location = point12;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(22, 28);
      Size size12 = size1;
      label5_2.Size = size12;
      this.Label5.TabIndex = 76;
      this.Label5.Text = "m";
      this.Label5.TextAlign = ContentAlignment.MiddleCenter;
      this.lbedln.BackColor = Color.Lime;
      this.lbedln.Font = new Font("Starcraft", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label lbedln1 = this.lbedln;
      point1 = new Point(770, 557);
      Point point13 = point1;
      lbedln1.Location = point13;
      this.lbedln.Name = "lbedln";
      Label lbedln2 = this.lbedln;
      size1 = new Size(171, 26);
      Size size13 = size1;
      lbedln2.Size = size13;
      this.lbedln.TabIndex = 83;
      this.lbedln.Text = "Optimo";
      this.lbedln.TextAlign = ContentAlignment.MiddleCenter;
      this.Label10.Font = new Font("Starcraft", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label10_1 = this.Label10;
      point1 = new Point(770, 527);
      Point point14 = point1;
      label10_1.Location = point14;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(171, 26);
      Size size14 = size1;
      label10_2.Size = size14;
      this.Label10.TabIndex = 82;
      this.Label10.Text = "Estado de la Nave";
      this.Label10.TextAlign = ContentAlignment.MiddleCenter;
      this.pbv1.BackColor = Color.Lime;
      this.pbv1.BackgroundImage = (Image) componentResourceManager.GetObject("pbv1.BackgroundImage");
      this.pbv1.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox pbv1_1 = this.pbv1;
      point1 = new Point(693, 527);
      Point point15 = point1;
      pbv1_1.Location = point15;
      PictureBox pbv1_2 = this.pbv1;
      Padding padding1 = new Padding(3, 4, 3, 4);
      Padding padding2 = padding1;
      pbv1_2.Margin = padding2;
      this.pbv1.Name = "pbv1";
      PictureBox pbv1_3 = this.pbv1;
      size1 = new Size(67, 56);
      Size size15 = size1;
      pbv1_3.Size = size15;
      this.pbv1.TabIndex = 81;
      this.pbv1.TabStop = false;
      this.pbv2.BackColor = Color.Lime;
      this.pbv2.BackgroundImage = (Image) componentResourceManager.GetObject("pbv2.BackgroundImage");
      this.pbv2.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox pbv2_1 = this.pbv2;
      point1 = new Point(693, 527);
      Point point16 = point1;
      pbv2_1.Location = point16;
      PictureBox pbv2_2 = this.pbv2;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding3 = padding1;
      pbv2_2.Margin = padding3;
      this.pbv2.Name = "pbv2";
      PictureBox pbv2_3 = this.pbv2;
      size1 = new Size(67, 56);
      Size size16 = size1;
      pbv2_3.Size = size16;
      this.pbv2.TabIndex = 80;
      this.pbv2.TabStop = false;
      this.pbv3.BackColor = Color.Lime;
      this.pbv3.BackgroundImage = (Image) componentResourceManager.GetObject("pbv3.BackgroundImage");
      this.pbv3.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox pbv3_1 = this.pbv3;
      point1 = new Point(693, 527);
      Point point17 = point1;
      pbv3_1.Location = point17;
      PictureBox pbv3_2 = this.pbv3;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding4 = padding1;
      pbv3_2.Margin = padding4;
      this.pbv3.Name = "pbv3";
      PictureBox pbv3_3 = this.pbv3;
      size1 = new Size(67, 56);
      Size size17 = size1;
      pbv3_3.Size = size17;
      this.pbv3.TabIndex = 79;
      this.pbv3.TabStop = false;
      this.pbv4.BackColor = Color.Lime;
      this.pbv4.BackgroundImage = (Image) componentResourceManager.GetObject("pbv4.BackgroundImage");
      this.pbv4.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox pbv4_1 = this.pbv4;
      point1 = new Point(693, 527);
      Point point18 = point1;
      pbv4_1.Location = point18;
      PictureBox pbv4_2 = this.pbv4;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding5 = padding1;
      pbv4_2.Margin = padding5;
      this.pbv4.Name = "pbv4";
      PictureBox pbv4_3 = this.pbv4;
      size1 = new Size(67, 56);
      Size size18 = size1;
      pbv4_3.Size = size18;
      this.pbv4.TabIndex = 78;
      this.pbv4.TabStop = false;
      this.pbv5.BackColor = Color.Lime;
      this.pbv5.BackgroundImage = (Image) componentResourceManager.GetObject("pbv5.BackgroundImage");
      this.pbv5.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox pbv5_1 = this.pbv5;
      point1 = new Point(693, 527);
      Point point19 = point1;
      pbv5_1.Location = point19;
      PictureBox pbv5_2 = this.pbv5;
      padding1 = new Padding(3, 4, 3, 4);
      Padding padding6 = padding1;
      pbv5_2.Margin = padding6;
      this.pbv5.Name = "pbv5";
      PictureBox pbv5_3 = this.pbv5;
      size1 = new Size(67, 56);
      Size size19 = size1;
      pbv5_3.Size = size19;
      this.pbv5.TabIndex = 77;
      this.pbv5.TabStop = false;
      this.bsalir.BackColor = SystemColors.WindowFrame;
      this.bsalir.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bsalir.ForeColor = Color.White;
      Button bsalir1 = this.bsalir;
      point1 = new Point(12, 564);
      Point point20 = point1;
      bsalir1.Location = point20;
      this.bsalir.Name = "bsalir";
      Button bsalir2 = this.bsalir;
      size1 = new Size(36, 35);
      Size size20 = size1;
      bsalir2.Size = size20;
      this.bsalir.TabIndex = 85;
      this.bsalir.Text = "S";
      this.bsalir.UseVisualStyleBackColor = false;
      this.bpausa.BackColor = SystemColors.WindowFrame;
      this.bpausa.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bpausa.ForeColor = Color.White;
      Button bpausa1 = this.bpausa;
      point1 = new Point(210, 564);
      Point point21 = point1;
      bpausa1.Location = point21;
      this.bpausa.Name = "bpausa";
      Button bpausa2 = this.bpausa;
      size1 = new Size(35, 35);
      Size size21 = size1;
      bpausa2.Size = size21;
      this.bpausa.TabIndex = 84;
      this.bpausa.Text = "II";
      this.bpausa.UseVisualStyleBackColor = false;
      this.lbcoordenadasfaltantes.BackColor = Color.Black;
      this.lbcoordenadasfaltantes.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbcoordenadasfaltantes.ForeColor = Color.Lime;
      Label lbcoordenadasfaltantes1 = this.lbcoordenadasfaltantes;
      point1 = new Point(599, 506);
      Point point22 = point1;
      lbcoordenadasfaltantes1.Location = point22;
      this.lbcoordenadasfaltantes.Name = "lbcoordenadasfaltantes";
      Label lbcoordenadasfaltantes2 = this.lbcoordenadasfaltantes;
      size1 = new Size(40, 23);
      Size size22 = size1;
      lbcoordenadasfaltantes2.Size = size22;
      this.lbcoordenadasfaltantes.TabIndex = 86;
      this.lbcoordenadasfaltantes.TextAlign = ContentAlignment.MiddleCenter;
      this.Label4.BackColor = Color.Black;
      this.Label4.Font = new Font("Starcraft", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.Lime;
      Label label4_1 = this.Label4;
      point1 = new Point(569, 480);
      Point point23 = point1;
      label4_1.Location = point23;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(78, 23);
      Size size23 = size1;
      label4_2.Size = size23;
      this.Label4.TabIndex = 87;
      this.Label4.Text = "Faltan:";
      this.Label4.TextAlign = ContentAlignment.MiddleCenter;
      this.m3.BackColor = Color.Transparent;
      this.m3.BackgroundImage = (Image) componentResourceManager.GetObject("m3.BackgroundImage");
      this.m3.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox m3_1 = this.m3;
      point1 = new Point(166, 48);
      Point point24 = point1;
      m3_1.Location = point24;
      this.m3.Name = "m3";
      PictureBox m3_2 = this.m3;
      size1 = new Size(10, 10);
      Size size24 = size1;
      m3_2.Size = size24;
      this.m3.TabIndex = 88;
      this.m3.TabStop = false;
      this.Timer2.Enabled = true;
      this.Timer2.Interval = 1000;
      this.m2.BackColor = Color.Transparent;
      this.m2.BackgroundImage = (Image) componentResourceManager.GetObject("m2.BackgroundImage");
      this.m2.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox m2_1 = this.m2;
      point1 = new Point(829, 48);
      Point point25 = point1;
      m2_1.Location = point25;
      this.m2.Name = "m2";
      PictureBox m2_2 = this.m2;
      size1 = new Size(10, 10);
      Size size25 = size1;
      m2_2.Size = size25;
      this.m2.TabIndex = 90;
      this.m2.TabStop = false;
      this.m4.BackColor = Color.Transparent;
      this.m4.BackgroundImage = (Image) componentResourceManager.GetObject("m4.BackgroundImage");
      this.m4.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox m4_1 = this.m4;
      point1 = new Point(912, 75);
      Point point26 = point1;
      m4_1.Location = point26;
      this.m4.Name = "m4";
      PictureBox m4_2 = this.m4;
      size1 = new Size(10, 10);
      Size size26 = size1;
      m4_2.Size = size26;
      this.m4.TabIndex = 91;
      this.m4.TabStop = false;
      this.m5.BackColor = Color.Transparent;
      this.m5.BackgroundImage = (Image) componentResourceManager.GetObject("m5.BackgroundImage");
      this.m5.BackgroundImageLayout = ImageLayout.Stretch;
      PictureBox m5_1 = this.m5;
      point1 = new Point(507, 89);
      Point point27 = point1;
      m5_1.Location = point27;
      this.m5.Name = "m5";
      PictureBox m5_2 = this.m5;
      size1 = new Size(10, 10);
      Size size27 = size1;
      m5_2.Size = size27;
      this.m5.TabIndex = 93;
      this.m5.TabStop = false;
      this.lbjuegoenpausa.BackColor = Color.Gray;
      this.lbjuegoenpausa.Font = new Font("Starcraft", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbjuegoenpausa.ForeColor = Color.Lime;
      Label lbjuegoenpausa1 = this.lbjuegoenpausa;
      point1 = new Point(359, 336);
      Point point28 = point1;
      lbjuegoenpausa1.Location = point28;
      this.lbjuegoenpausa.Name = "lbjuegoenpausa";
      Label lbjuegoenpausa2 = this.lbjuegoenpausa;
      size1 = new Size(307, 102);
      Size size28 = size1;
      lbjuegoenpausa2.Size = size28;
      this.lbjuegoenpausa.TabIndex = 94;
      this.lbjuegoenpausa.Text = "Juego en Pausa";
      this.lbjuegoenpausa.TextAlign = ContentAlignment.MiddleCenter;
      this.lbjuegoenpausa.Visible = false;
      this.br.BackColor = Color.Black;
      this.br.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.br.ForeColor = Color.White;
      Button br1 = this.br;
      point1 = new Point(12, 468);
      Point point29 = point1;
      br1.Location = point29;
      this.br.Name = "br";
      Button br2 = this.br;
      size1 = new Size(36, 35);
      Size size29 = size1;
      br2.Size = size29;
      this.br.TabIndex = 95;
      this.br.Text = "R";
      this.br.UseVisualStyleBackColor = false;
      this.PictureBox8.BackColor = Color.Transparent;
      this.PictureBox8.Cursor = Cursors.Hand;
      PictureBox pictureBox8_1 = this.PictureBox8;
      point1 = new Point(671, 440);
      Point point30 = point1;
      pictureBox8_1.Location = point30;
      this.PictureBox8.Name = "PictureBox8";
      PictureBox pictureBox8_2 = this.PictureBox8;
      size1 = new Size(75, 13);
      Size size30 = size1;
      pictureBox8_2.Size = size30;
      this.PictureBox8.TabIndex = 112;
      this.PictureBox8.TabStop = false;
      this.PictureBox7.BackColor = Color.Transparent;
      this.PictureBox7.Cursor = Cursors.Hand;
      PictureBox pictureBox7_1 = this.PictureBox7;
      point1 = new Point(745, 441);
      Point point31 = point1;
      pictureBox7_1.Location = point31;
      this.PictureBox7.Name = "PictureBox7";
      PictureBox pictureBox7_2 = this.PictureBox7;
      size1 = new Size(75, 21);
      Size size31 = size1;
      pictureBox7_2.Size = size31;
      this.PictureBox7.TabIndex = 111;
      this.PictureBox7.TabStop = false;
      this.PictureBox6.BackColor = Color.Transparent;
      this.PictureBox6.Cursor = Cursors.Hand;
      PictureBox pictureBox6_1 = this.PictureBox6;
      point1 = new Point(810, 441);
      Point point32 = point1;
      pictureBox6_1.Location = point32;
      this.PictureBox6.Name = "PictureBox6";
      PictureBox pictureBox6_2 = this.PictureBox6;
      size1 = new Size(75, 29);
      Size size32 = size1;
      pictureBox6_2.Size = size32;
      this.PictureBox6.TabIndex = 110;
      this.PictureBox6.TabStop = false;
      this.PictureBox5.BackColor = Color.Transparent;
      this.PictureBox5.Cursor = Cursors.Hand;
      PictureBox pictureBox5_1 = this.PictureBox5;
      point1 = new Point(881, 441);
      Point point33 = point1;
      pictureBox5_1.Location = point33;
      this.PictureBox5.Name = "PictureBox5";
      PictureBox pictureBox5_2 = this.PictureBox5;
      size1 = new Size(75, 35);
      Size size33 = size1;
      pictureBox5_2.Size = size33;
      this.PictureBox5.TabIndex = 109;
      this.PictureBox5.TabStop = false;
      this.PictureBox4.BackColor = Color.Transparent;
      this.PictureBox4.Cursor = Cursors.Hand;
      PictureBox pictureBox4_1 = this.PictureBox4;
      point1 = new Point(949, 441);
      Point point34 = point1;
      pictureBox4_1.Location = point34;
      this.PictureBox4.Name = "PictureBox4";
      PictureBox pictureBox4_2 = this.PictureBox4;
      size1 = new Size(75, 39);
      Size size34 = size1;
      pictureBox4_2.Size = size34;
      this.PictureBox4.TabIndex = 108;
      this.PictureBox4.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      this.BackgroundImageLayout = ImageLayout.Stretch;
      size1 = new Size(1024, 600);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.PictureBox8);
      this.Controls.Add((Control) this.PictureBox7);
      this.Controls.Add((Control) this.PictureBox6);
      this.Controls.Add((Control) this.PictureBox5);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.br);
      this.Controls.Add((Control) this.lbjuegoenpausa);
      this.Controls.Add((Control) this.m5);
      this.Controls.Add((Control) this.m4);
      this.Controls.Add((Control) this.m2);
      this.Controls.Add((Control) this.m3);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.lbcoordenadasfaltantes);
      this.Controls.Add((Control) this.bsalir);
      this.Controls.Add((Control) this.bpausa);
      this.Controls.Add((Control) this.lbedln);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.pbv1);
      this.Controls.Add((Control) this.pbv2);
      this.Controls.Add((Control) this.pbv3);
      this.Controls.Add((Control) this.pbv4);
      this.Controls.Add((Control) this.pbv5);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.rwm);
      this.Controls.Add((Control) this.lbdistanciadelmeteorito);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.lbnombre);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.tbcoordenada);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.lbcoordenadas);
      this.Controls.Add((Control) this.m1);
      this.Controls.Add((Control) this.PictureBox2);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (v2__nivel2);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ç+up`f llnbnlbnol";
      ((ISupportInitialize) this.PictureBox2).EndInit();
      ((ISupportInitialize) this.m1).EndInit();
      this.rwm.EndInit();
      ((ISupportInitialize) this.pbv1).EndInit();
      ((ISupportInitialize) this.pbv2).EndInit();
      ((ISupportInitialize) this.pbv3).EndInit();
      ((ISupportInitialize) this.pbv4).EndInit();
      ((ISupportInitialize) this.pbv5).EndInit();
      ((ISupportInitialize) this.m3).EndInit();
      ((ISupportInitialize) this.m2).EndInit();
      ((ISupportInitialize) this.m4).EndInit();
      ((ISupportInitialize) this.m5).EndInit();
      ((ISupportInitialize) this.PictureBox8).EndInit();
      ((ISupportInitialize) this.PictureBox7).EndInit();
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((ISupportInitialize) this.PictureBox5).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual PictureBox PictureBox2
    {
      [DebuggerNonUserCode] get => this._PictureBox2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox2 = value;
    }

    internal virtual PictureBox m1
    {
      [DebuggerNonUserCode] get => this._m1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m1 = value;
    }

    internal virtual Label lbcoordenadas
    {
      [DebuggerNonUserCode] get => this._lbcoordenadas;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbcoordenadas = value;
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual TextBox tbcoordenada
    {
      [DebuggerNonUserCode] get => this._tbcoordenada;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.tbcoordenada_KeyPress);
        if (this._tbcoordenada != null)
          this._tbcoordenada.KeyPress -= pressEventHandler;
        this._tbcoordenada = value;
        if (this._tbcoordenada == null)
          return;
        this._tbcoordenada.KeyPress += pressEventHandler;
      }
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

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual Label lbdistanciadelmeteorito
    {
      [DebuggerNonUserCode] get => this._lbdistanciadelmeteorito;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbdistanciadelmeteorito = value;
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

    internal virtual AxWindowsMediaPlayer rwm
    {
      [DebuggerNonUserCode] get => this._rwm;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rwm = value;
    }

    internal virtual Label Label5
    {
      [DebuggerNonUserCode] get => this._Label5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal virtual Label lbedln
    {
      [DebuggerNonUserCode] get => this._lbedln;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbedln = value;
    }

    internal virtual Label Label10
    {
      [DebuggerNonUserCode] get => this._Label10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
    }

    internal virtual PictureBox pbv1
    {
      [DebuggerNonUserCode] get => this._pbv1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbv1 = value;
    }

    internal virtual PictureBox pbv2
    {
      [DebuggerNonUserCode] get => this._pbv2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbv2 = value;
    }

    internal virtual PictureBox pbv3
    {
      [DebuggerNonUserCode] get => this._pbv3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbv3 = value;
    }

    internal virtual PictureBox pbv4
    {
      [DebuggerNonUserCode] get => this._pbv4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbv4 = value;
    }

    internal virtual PictureBox pbv5
    {
      [DebuggerNonUserCode] get => this._pbv5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbv5 = value;
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

    internal virtual Label lbcoordenadasfaltantes
    {
      [DebuggerNonUserCode] get => this._lbcoordenadasfaltantes;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbcoordenadasfaltantes = value;
    }

    internal virtual Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal virtual PictureBox m3
    {
      [DebuggerNonUserCode] get => this._m3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m3 = value;
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

    internal virtual PictureBox m2
    {
      [DebuggerNonUserCode] get => this._m2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m2 = value;
    }

    internal virtual PictureBox m4
    {
      [DebuggerNonUserCode] get => this._m4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m4 = value;
    }

    internal virtual PictureBox m5
    {
      [DebuggerNonUserCode] get => this._m5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._m5 = value;
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

    private void v2__nivel2_Load(object sender, EventArgs e)
    {
      VBMath.Randomize();
      this.tbcoordenada.Focus();
      Variables_Publicas.c2 = 0;
      Variables_Publicas.d = 5000;
      Variables_Publicas.cfal = 3;
      Variables_Publicas.ct22 = 0;
      Variables_Publicas.met = 1;
      this.lbcoordenadasfaltantes.ForeColor = Color.Red;
      this.lbcoordenadasfaltantes.Text = Conversions.ToString(Variables_Publicas.cfal);
      this.lbnombre.Text = Variables_Publicas.nj;
      Variables_Publicas.rndyes = 0;
      switch (Variables_Publicas.ndd)
      {
        case 1:
          Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
          Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 6f)));
          if (Variables_Publicas.nr < 1)
            checked { ++Variables_Publicas.nr; }
          Variables_Publicas.x2 = checked (Variables_Publicas.x1 + Variables_Publicas.nr);
          Variables_Publicas.x3 = checked (Variables_Publicas.x2 + Variables_Publicas.nr);
          Variables_Publicas.x4 = checked (Variables_Publicas.x3 + Variables_Publicas.nr);
          Variables_Publicas.x5 = checked (Variables_Publicas.x4 + Variables_Publicas.nr);
          break;
        case 2:
          Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
          Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
          if (Variables_Publicas.nr < 1)
            checked { ++Variables_Publicas.nr; }
          Variables_Publicas.x2 = checked (Variables_Publicas.x1 + Variables_Publicas.nr);
          Variables_Publicas.x3 = checked (Variables_Publicas.x2 + Variables_Publicas.nr);
          Variables_Publicas.x4 = checked (Variables_Publicas.x3 + Variables_Publicas.nr);
          Variables_Publicas.x5 = checked (Variables_Publicas.x4 + Variables_Publicas.nr);
          break;
        case 3:
          Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
          Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
          if (Variables_Publicas.nr < 5)
            checked { Variables_Publicas.nr += 5; }
          if (Variables_Publicas.x1 < 5)
            checked { Variables_Publicas.x1 += 5; }
          Variables_Publicas.x2 = checked (Variables_Publicas.x1 + Variables_Publicas.nr);
          Variables_Publicas.x3 = checked (Variables_Publicas.x2 + Variables_Publicas.nr);
          Variables_Publicas.x4 = checked (Variables_Publicas.x3 + Variables_Publicas.nr);
          Variables_Publicas.x5 = checked (Variables_Publicas.x4 + Variables_Publicas.nr);
          break;
        case 4:
          Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
          Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
          if (Variables_Publicas.nr < 10)
            checked { Variables_Publicas.nr += 10; }
          if (Variables_Publicas.x1 < 10)
            checked { Variables_Publicas.x1 += 10; }
          Variables_Publicas.x2 = checked (Variables_Publicas.x1 + Variables_Publicas.nr);
          Variables_Publicas.x3 = checked (Variables_Publicas.x2 + Variables_Publicas.nr);
          Variables_Publicas.x4 = checked (Variables_Publicas.x3 + Variables_Publicas.nr);
          Variables_Publicas.x5 = checked (Variables_Publicas.x4 + Variables_Publicas.nr);
          break;
      }
      this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      switch (Variables_Publicas.met)
      {
        case 1:
          if (this.m1.Width < 251 | Variables_Publicas.c2 == 1)
          {
            this.m1.Width = checked ((int) Math.Round(unchecked ((double) this.m1.Width + 1.8)));
            this.m1.Height = checked ((int) Math.Round(unchecked ((double) this.m1.Height + 1.8)));
            checked { Variables_Publicas.d -= 41; }
            this.lbdistanciadelmeteorito.Text = Conversions.ToString(Variables_Publicas.d);
          }
          if (this.m1.Width >= 250)
          {
            if (this.m1.Left >= 1025)
            {
              Variables_Publicas.rndyes = 1;
              Variables_Publicas.d = 5000;
              Variables_Publicas.met = 2;
              if (Variables_Publicas.cfal == 0)
              {
                checked { Variables_Publicas.pn2 += 1000; }
                this.lbcoordenadasfaltantes.Text = Conversions.ToString(Variables_Publicas.cfal);
              }
              else if (this.pbv1.Visible)
              {
                this.pbv1.Visible = false;
                this.lbedln.Text = "bueno";
                this.lbedln.BackColor = Color.Yellow;
                checked { Variables_Publicas.p -= 500; }
                Variables_Publicas.dañonave = 1;
              }
              else if (!this.pbv1.Visible)
              {
                if (this.pbv2.Visible)
                {
                  this.pbv2.Visible = false;
                  this.lbedln.Text = "Regular";
                  this.lbedln.BackColor = Color.Orange;
                  checked { Variables_Publicas.p -= 500; }
                  Variables_Publicas.dañonave = 2;
                }
                else if (!this.pbv2.Visible)
                {
                  if (this.pbv3.Visible)
                  {
                    this.pbv3.Visible = false;
                    this.lbedln.Text = "Malo";
                    this.lbedln.BackColor = Color.Red;
                    checked { Variables_Publicas.p -= 500; }
                    Variables_Publicas.dañonave = 3;
                  }
                  else if (!this.pbv3.Visible)
                  {
                    this.pbv4.Visible = false;
                    this.lbedln.Text = "Inservible";
                    this.lbedln.BackColor = Color.Black;
                    this.lbedln.ForeColor = Color.White;
                    checked { Variables_Publicas.p -= 500; }
                    Variables_Publicas.dañonave = 4;
                  }
                }
              }
              Variables_Publicas.cfal = 3;
              this.lbcoordenadasfaltantes.Text = Conversions.ToString(Variables_Publicas.cfal);
              break;
            }
            checked { this.m1.Left += 100; }
            checked { this.m1.Top += 20; }
            break;
          }
          break;
        case 2:
          if (this.m2.Width < 251)
          {
            this.m2.Width = checked ((int) Math.Round(unchecked ((double) this.m2.Width + 1.8)));
            this.m2.Height = checked ((int) Math.Round(unchecked ((double) this.m2.Height + 1.8)));
            this.m2.Left = checked ((int) Math.Round(unchecked ((double) this.m2.Left - 1.8)));
            checked { Variables_Publicas.d -= 41; }
            this.lbdistanciadelmeteorito.Text = Conversions.ToString(Variables_Publicas.d);
          }
          if (this.m2.Width >= 250)
          {
            if (this.m2.Left <= -260)
            {
              Variables_Publicas.rndyes = 1;
              Variables_Publicas.d = 5000;
              Variables_Publicas.met = 3;
              if (Variables_Publicas.cfal == 0)
              {
                checked { Variables_Publicas.pn2 += 1000; }
                this.lbcoordenadasfaltantes.Text = Conversions.ToString(Variables_Publicas.cfal);
              }
              else if (this.pbv1.Visible)
              {
                this.pbv1.Visible = false;
                this.lbedln.Text = "bueno";
                this.lbedln.BackColor = Color.Yellow;
                checked { Variables_Publicas.p -= 500; }
                Variables_Publicas.dañonave = 1;
              }
              else if (!this.pbv1.Visible)
              {
                if (this.pbv2.Visible)
                {
                  this.pbv2.Visible = false;
                  this.lbedln.Text = "Regular";
                  this.lbedln.BackColor = Color.Orange;
                  checked { Variables_Publicas.p -= 500; }
                  Variables_Publicas.dañonave = 2;
                }
                else if (!this.pbv2.Visible)
                {
                  if (this.pbv3.Visible)
                  {
                    this.pbv3.Visible = false;
                    this.lbedln.Text = "Malo";
                    this.lbedln.BackColor = Color.Red;
                    checked { Variables_Publicas.p -= 500; }
                    Variables_Publicas.dañonave = 3;
                  }
                  else if (!this.pbv3.Visible)
                  {
                    this.pbv4.Visible = false;
                    this.lbedln.Text = "Inservible";
                    this.lbedln.BackColor = Color.Black;
                    this.lbedln.ForeColor = Color.White;
                    checked { Variables_Publicas.p -= 500; }
                    Variables_Publicas.dañonave = 4;
                  }
                }
              }
              Variables_Publicas.cfal = 3;
              this.lbcoordenadasfaltantes.Text = Conversions.ToString(Variables_Publicas.cfal);
              break;
            }
            checked { this.m2.Left -= 100; }
            checked { this.m2.Top += 20; }
            break;
          }
          break;
        case 3:
          if (this.m3.Width < 251)
          {
            this.m3.Width = checked ((int) Math.Round(unchecked ((double) this.m3.Width + 1.8)));
            this.m3.Height = checked ((int) Math.Round(unchecked ((double) this.m3.Height + 1.8)));
            checked { Variables_Publicas.d -= 41; }
            this.lbdistanciadelmeteorito.Text = Conversions.ToString(Variables_Publicas.d);
            break;
          }
          if (this.m3.Left > 1025)
          {
            Variables_Publicas.rndyes = 1;
            Variables_Publicas.d = 5000;
            Variables_Publicas.met = 4;
            if (Variables_Publicas.cfal == 0)
            {
              checked { Variables_Publicas.pn2 += 1000; }
              this.lbcoordenadasfaltantes.Text = Conversions.ToString(Variables_Publicas.cfal);
            }
            else if (this.pbv1.Visible)
            {
              this.pbv1.Visible = false;
              this.lbedln.Text = "bueno";
              this.lbedln.BackColor = Color.Yellow;
              checked { Variables_Publicas.p -= 500; }
              Variables_Publicas.dañonave = 1;
            }
            else if (!this.pbv1.Visible)
            {
              if (this.pbv2.Visible)
              {
                this.pbv2.Visible = false;
                this.lbedln.Text = "Regular";
                this.lbedln.BackColor = Color.Orange;
                checked { Variables_Publicas.p -= 500; }
                Variables_Publicas.dañonave = 2;
              }
              else if (!this.pbv2.Visible)
              {
                if (this.pbv3.Visible)
                {
                  this.pbv3.Visible = false;
                  this.lbedln.Text = "Malo";
                  this.lbedln.BackColor = Color.Red;
                  checked { Variables_Publicas.p -= 500; }
                  Variables_Publicas.dañonave = 3;
                }
                else if (!this.pbv3.Visible)
                {
                  this.pbv4.Visible = false;
                  this.lbedln.Text = "Inservible";
                  this.lbedln.BackColor = Color.Black;
                  this.lbedln.ForeColor = Color.White;
                  checked { Variables_Publicas.p -= 500; }
                  Variables_Publicas.dañonave = 4;
                }
              }
            }
            Variables_Publicas.cfal = 3;
            this.lbcoordenadasfaltantes.Text = Conversions.ToString(Variables_Publicas.cfal);
            break;
          }
          checked { this.m3.Left += 100; }
          checked { this.m3.Top += 20; }
          break;
        case 4:
          if (this.m4.Width < 251)
          {
            this.m4.Width = checked ((int) Math.Round(unchecked ((double) this.m4.Width + 1.8)));
            this.m4.Height = checked ((int) Math.Round(unchecked ((double) this.m4.Height + 1.8)));
            this.m4.Left = checked ((int) Math.Round(unchecked ((double) this.m4.Left - 1.8)));
            checked { Variables_Publicas.d -= 41; }
            this.lbdistanciadelmeteorito.Text = Conversions.ToString(Variables_Publicas.d);
            break;
          }
          if (this.m4.Left <= -260)
          {
            Variables_Publicas.rndyes = 1;
            Variables_Publicas.d = 5000;
            Variables_Publicas.met = 5;
            checked { this.m4.Left -= 80; }
            if (Variables_Publicas.cfal == 0)
            {
              checked { Variables_Publicas.pn2 += 1000; }
              this.lbcoordenadasfaltantes.Text = Conversions.ToString(Variables_Publicas.cfal);
            }
            else if (this.pbv1.Visible)
            {
              this.pbv1.Visible = false;
              this.lbedln.Text = "bueno";
              this.lbedln.BackColor = Color.Yellow;
              checked { Variables_Publicas.p -= 500; }
              Variables_Publicas.dañonave = 1;
            }
            else if (!this.pbv1.Visible)
            {
              if (this.pbv2.Visible)
              {
                this.pbv2.Visible = false;
                this.lbedln.Text = "Regular";
                this.lbedln.BackColor = Color.Orange;
                checked { Variables_Publicas.p -= 500; }
                Variables_Publicas.dañonave = 2;
              }
              else if (!this.pbv2.Visible)
              {
                if (this.pbv3.Visible)
                {
                  this.pbv3.Visible = false;
                  this.lbedln.Text = "Malo";
                  this.lbedln.BackColor = Color.Red;
                  checked { Variables_Publicas.p -= 500; }
                  Variables_Publicas.dañonave = 3;
                }
                else if (!this.pbv3.Visible)
                {
                  this.pbv4.Visible = false;
                  this.lbedln.Text = "Inservible";
                  this.lbedln.BackColor = Color.Black;
                  this.lbedln.ForeColor = Color.White;
                  checked { Variables_Publicas.p -= 500; }
                  Variables_Publicas.dañonave = 4;
                }
              }
            }
            Variables_Publicas.cfal = 3;
            this.lbcoordenadasfaltantes.Text = Conversions.ToString(Variables_Publicas.cfal);
            break;
          }
          checked { this.m4.Left -= 100; }
          checked { this.m4.Top += 20; }
          break;
        case 5:
          if (this.m5.Width < 251)
          {
            this.m5.Width = checked ((int) Math.Round(unchecked ((double) this.m5.Width + 1.8)));
            this.m5.Height = checked ((int) Math.Round(unchecked ((double) this.m5.Height + 1.8)));
            this.m5.Left = checked ((int) Math.Round(unchecked ((double) this.m5.Left - 1.8)));
            checked { Variables_Publicas.d -= 41; }
            this.lbdistanciadelmeteorito.Text = Conversions.ToString(Variables_Publicas.d);
            break;
          }
          if (this.m5.Left <= -230)
          {
            Variables_Publicas.d = 0;
            this.lbcoordenadasfaltantes.Text = "-";
            Variables_Publicas.d = 0;
            this.lbdistanciadelmeteorito.Text = Conversions.ToString(Variables_Publicas.d);
            this.lbcoordenadas.Text = "fuera de peligro";
            this.tbcoordenada.Visible = false;
            if (Variables_Publicas.cfal == 0)
              checked { Variables_Publicas.pn2 += 1000; }
            else if (this.pbv1.Visible)
            {
              this.pbv1.Visible = false;
              this.lbedln.Text = "bueno";
              this.lbedln.BackColor = Color.Yellow;
              checked { Variables_Publicas.p -= 500; }
              Variables_Publicas.dañonave = 1;
              Variables_Publicas.gda = 2;
            }
            else if (!this.pbv1.Visible)
            {
              if (this.pbv2.Visible)
              {
                this.pbv2.Visible = false;
                this.lbedln.Text = "Regular";
                this.lbedln.BackColor = Color.Orange;
                checked { Variables_Publicas.p -= 500; }
                Variables_Publicas.dañonave = 2;
              }
              else if (!this.pbv2.Visible)
              {
                if (this.pbv3.Visible)
                {
                  this.pbv3.Visible = false;
                  this.lbedln.Text = "Malo";
                  this.lbedln.BackColor = Color.Red;
                  checked { Variables_Publicas.p -= 500; }
                  Variables_Publicas.dañonave = 3;
                }
                else if (!this.pbv3.Visible)
                {
                  this.pbv4.Visible = false;
                  this.lbedln.Text = "Inservible";
                  this.lbedln.BackColor = Color.Black;
                  this.lbedln.ForeColor = Color.White;
                  checked { Variables_Publicas.p -= 500; }
                  Variables_Publicas.dañonave = 4;
                }
              }
            }
            this.Timer1.Enabled = false;
            this.Timer2.Enabled = false;
            int num = (int) Interaction.MsgBox((object) "Nivel Completado");
            MyProject.Forms.vp__ventanapuntaje.Show();
            this.Hide();
            break;
          }
          checked { this.m5.Left -= 100; }
          checked { this.m5.Top += 10; }
          break;
      }
      int d = Variables_Publicas.d;
      if (d > 2499)
        this.lbdistanciadelmeteorito.ForeColor = Color.Blue;
      else if (d < 2500)
        this.lbdistanciadelmeteorito.ForeColor = Color.Red;
      if (Variables_Publicas.d != 0)
        return;
      Variables_Publicas.ct22 = 2;
    }

    private void tbcoordenada_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Strings.Asc(e.KeyChar) != 13 || Conversions.ToDouble(this.tbcoordenada.Text) != (double) Variables_Publicas.x5)
        return;
      if (Variables_Publicas.cfal == 0)
      {
        this.tbcoordenada.Focus();
        Interaction.Beep();
      }
      else
        checked { --Variables_Publicas.cfal; }
      switch (Variables_Publicas.cfal)
      {
        case 1:
          VBMath.Randomize();
          switch (Variables_Publicas.ndd)
          {
            case 1:
              Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
              Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 3f)));
              if (Variables_Publicas.nr < 1)
                Variables_Publicas.nr = 1;
              if (Variables_Publicas.x1 < 5)
                Variables_Publicas.x1 = 5;
              Variables_Publicas.x2 = checked (Variables_Publicas.x1 - Variables_Publicas.nr);
              Variables_Publicas.x3 = checked (Variables_Publicas.x2 - Variables_Publicas.nr);
              Variables_Publicas.x4 = checked (Variables_Publicas.x3 - Variables_Publicas.nr);
              Variables_Publicas.x5 = checked (Variables_Publicas.x4 - Variables_Publicas.nr);
              this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
              break;
            case 2:
              Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 26f)));
              Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 6f)));
              if (Variables_Publicas.nr < 3)
                Variables_Publicas.nr = 3;
              if (Variables_Publicas.x1 < 10)
                Variables_Publicas.x1 = 10;
              Variables_Publicas.x2 = checked (Variables_Publicas.x1 - Variables_Publicas.nr);
              Variables_Publicas.x3 = checked (Variables_Publicas.x2 - Variables_Publicas.nr);
              Variables_Publicas.x4 = checked (Variables_Publicas.x3 - Variables_Publicas.nr);
              Variables_Publicas.x5 = checked (Variables_Publicas.x4 - Variables_Publicas.nr);
              this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
              break;
            case 3:
              Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 41f)));
              Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
              if (Variables_Publicas.nr < 5)
                Variables_Publicas.nr = 5;
              if (Variables_Publicas.x1 < 10)
                Variables_Publicas.x1 = 10;
              Variables_Publicas.x2 = checked (Variables_Publicas.x1 - Variables_Publicas.nr);
              Variables_Publicas.x3 = checked (Variables_Publicas.x2 - Variables_Publicas.nr);
              Variables_Publicas.x4 = checked (Variables_Publicas.x3 - Variables_Publicas.nr);
              Variables_Publicas.x5 = checked (Variables_Publicas.x4 - Variables_Publicas.nr);
              this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
              break;
            case 4:
              Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 51f)));
              Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
              if (Variables_Publicas.nr < 10)
                Variables_Publicas.nr = 10;
              if (Variables_Publicas.x1 < 10)
                checked { Variables_Publicas.x1 += 10; }
              Variables_Publicas.x2 = checked (Variables_Publicas.x1 - Variables_Publicas.nr);
              Variables_Publicas.x3 = checked (Variables_Publicas.x2 - Variables_Publicas.nr);
              Variables_Publicas.x4 = checked (Variables_Publicas.x3 - Variables_Publicas.nr);
              Variables_Publicas.x5 = checked (Variables_Publicas.x4 - Variables_Publicas.nr);
              this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
              break;
          }
          break;
        case 2:
          VBMath.Randomize();
          switch (Variables_Publicas.ndd)
          {
            case 1:
              Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 5f)));
              Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 3f)));
              if (Variables_Publicas.nr < 1)
                Variables_Publicas.nr = 2;
              if (Variables_Publicas.x1 < 1)
                Variables_Publicas.x1 = 1;
              Variables_Publicas.x2 = checked (Variables_Publicas.x1 * Variables_Publicas.nr);
              Variables_Publicas.x3 = checked (Variables_Publicas.x2 * Variables_Publicas.nr);
              Variables_Publicas.x4 = checked (Variables_Publicas.x3 * Variables_Publicas.nr);
              Variables_Publicas.x5 = checked (Variables_Publicas.x4 * Variables_Publicas.nr);
              this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
              break;
            case 2:
              Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 6f)));
              Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 4f)));
              if (Variables_Publicas.nr < 1)
                Variables_Publicas.nr = 2;
              if (Variables_Publicas.x1 < 1)
                Variables_Publicas.x1 = 1;
              Variables_Publicas.x2 = checked (Variables_Publicas.x1 * Variables_Publicas.nr);
              Variables_Publicas.x3 = checked (Variables_Publicas.x2 * Variables_Publicas.nr);
              Variables_Publicas.x4 = checked (Variables_Publicas.x3 * Variables_Publicas.nr);
              Variables_Publicas.x5 = checked (Variables_Publicas.x4 * Variables_Publicas.nr);
              this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
              break;
            case 3:
              Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 6f)));
              Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 6f)));
              if (Variables_Publicas.nr < 1)
                Variables_Publicas.nr = 2;
              if (Variables_Publicas.x1 < 1)
                Variables_Publicas.x1 = 1;
              Variables_Publicas.x2 = checked (Variables_Publicas.x1 * Variables_Publicas.nr);
              Variables_Publicas.x3 = checked (Variables_Publicas.x2 * Variables_Publicas.nr);
              Variables_Publicas.x4 = checked (Variables_Publicas.x3 * Variables_Publicas.nr);
              Variables_Publicas.x5 = checked (Variables_Publicas.x4 * Variables_Publicas.nr);
              this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
              break;
            case 4:
              Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
              Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 6f)));
              if (Variables_Publicas.nr < 2)
                Variables_Publicas.nr = 2;
              if (Variables_Publicas.x1 < 10)
                checked { Variables_Publicas.x1 += 10; }
              Variables_Publicas.x2 = checked (Variables_Publicas.x1 * Variables_Publicas.nr);
              Variables_Publicas.x3 = checked (Variables_Publicas.x2 * Variables_Publicas.nr);
              Variables_Publicas.x4 = checked (Variables_Publicas.x3 * Variables_Publicas.nr);
              Variables_Publicas.x5 = checked (Variables_Publicas.x4 * Variables_Publicas.nr);
              this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
              break;
          }
          break;
        case 3:
          VBMath.Randomize();
          int ndd = Variables_Publicas.ndd;
          if (ndd == (1 | -(Variables_Publicas.rndyes == 1 ? 1 : 0)))
          {
            Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
            Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 6f)));
            if (Variables_Publicas.nr < 1)
              Variables_Publicas.nr = 2;
            Variables_Publicas.x2 = checked (Variables_Publicas.x1 + Variables_Publicas.nr);
            Variables_Publicas.x3 = checked (Variables_Publicas.x2 + Variables_Publicas.nr);
            Variables_Publicas.x4 = checked (Variables_Publicas.x3 + Variables_Publicas.nr);
            Variables_Publicas.x5 = checked (Variables_Publicas.x4 + Variables_Publicas.nr);
            this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
            break;
          }
          switch (ndd)
          {
            case 2:
              Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
              Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
              if (Variables_Publicas.nr < 1)
                Variables_Publicas.nr = 3;
              Variables_Publicas.x2 = checked (Variables_Publicas.x1 + Variables_Publicas.nr);
              Variables_Publicas.x3 = checked (Variables_Publicas.x2 + Variables_Publicas.nr);
              Variables_Publicas.x4 = checked (Variables_Publicas.x3 + Variables_Publicas.nr);
              Variables_Publicas.x5 = checked (Variables_Publicas.x4 + Variables_Publicas.nr);
              this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
              break;
            case 3:
              Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 16f)));
              Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 11f)));
              if (Variables_Publicas.nr < 5)
                Variables_Publicas.nr = 5;
              if (Variables_Publicas.x1 < 5)
                checked { Variables_Publicas.x1 += 5; }
              Variables_Publicas.x2 = checked (Variables_Publicas.x1 + Variables_Publicas.nr);
              Variables_Publicas.x3 = checked (Variables_Publicas.x2 + Variables_Publicas.nr);
              Variables_Publicas.x4 = checked (Variables_Publicas.x3 + Variables_Publicas.nr);
              Variables_Publicas.x5 = checked (Variables_Publicas.x4 + Variables_Publicas.nr);
              this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
              break;
            case 4:
              Variables_Publicas.x1 = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
              Variables_Publicas.nr = checked ((int) Math.Round((double) unchecked (VBMath.Rnd() * 21f)));
              if (Variables_Publicas.nr < 10)
                checked { Variables_Publicas.nr += 10; }
              if (Variables_Publicas.x1 < 10)
                Variables_Publicas.x1 = 10;
              Variables_Publicas.x2 = checked (Variables_Publicas.x1 + Variables_Publicas.nr);
              Variables_Publicas.x3 = checked (Variables_Publicas.x2 + Variables_Publicas.nr);
              Variables_Publicas.x4 = checked (Variables_Publicas.x3 + Variables_Publicas.nr);
              Variables_Publicas.x5 = checked (Variables_Publicas.x4 + Variables_Publicas.nr);
              this.lbcoordenadas.Text = Conversions.ToString(Variables_Publicas.x1) + " . " + Conversions.ToString(Variables_Publicas.x2) + " . " + Conversions.ToString(Variables_Publicas.x3) + " . " + Conversions.ToString(Variables_Publicas.x4) + " . ";
              break;
          }
          break;
      }
      this.lbcoordenadasfaltantes.Text = Conversions.ToString(Variables_Publicas.cfal);
      switch (Variables_Publicas.cfal)
      {
        case 0:
          this.lbcoordenadasfaltantes.ForeColor = Color.Blue;
          break;
        case 1:
          this.lbcoordenadasfaltantes.ForeColor = Color.MediumSpringGreen;
          break;
        case 2:
          this.lbcoordenadasfaltantes.ForeColor = Color.Yellow;
          break;
        case 3:
          this.lbcoordenadasfaltantes.ForeColor = Color.Red;
          break;
      }
      this.tbcoordenada.Text = "";
    }

    private void Timer2_Tick(object sender, EventArgs e)
    {
      checked { ++Variables_Publicas.c2; }
      if (Variables_Publicas.c2 == 60)
      {
        checked { ++Variables_Publicas.ctminutos; }
        Variables_Publicas.c2 = 0;
      }
      if (Variables_Publicas.ctminutos != 60)
        return;
      checked { ++Variables_Publicas.cthoras; }
    }

    private void bpausa_Click(object sender, EventArgs e)
    {
      if (!Variables_Publicas.pausa2)
      {
        Variables_Publicas.pausa2 = true;
        this.Timer1.Enabled = false;
        this.Timer2.Enabled = false;
        this.lbcoordenadas.Visible = false;
        this.lbjuegoenpausa.Visible = true;
      }
      else
      {
        Variables_Publicas.pausa2 = false;
        this.Timer1.Enabled = true;
        this.Timer2.Enabled = true;
        this.lbcoordenadas.Visible = true;
        this.lbjuegoenpausa.Visible = false;
      }
    }

    private void bsalir_Click(object sender, EventArgs e)
    {
      Variables_Publicas.rsn2 = Interaction.InputBox("¿Deseas avandonar el nivel? ", "Salir");
      if (Operators.CompareString(Variables_Publicas.rsn2, "SI", false) == 0)
      {
        MyProject.Forms.v0__menu_principal.Show();
        this.Close();
        Variables_Publicas.pn2 = Variables_Publicas.p;
      }
      if (Operators.CompareString(Variables_Publicas.rsn2, "si", false) == 0)
      {
        MyProject.Forms.v0__menu_principal.Show();
        this.Close();
        Variables_Publicas.pn2 = Variables_Publicas.p;
      }
      if (Operators.CompareString(Variables_Publicas.rsn2, "Si", false) == 0)
      {
        MyProject.Forms.v0__menu_principal.Show();
        this.Close();
        Variables_Publicas.pn2 = Variables_Publicas.p;
      }
      if (Operators.CompareString(Variables_Publicas.rsn2, "sI", false) != 0)
        return;
      MyProject.Forms.v0__menu_principal.Show();
      this.Close();
      Variables_Publicas.pn2 = Variables_Publicas.p;
    }

    private void br_Click(object sender, EventArgs e)
    {
      this.Close();
      MyProject.Forms.v0__menu_principal.Show();
    }
  }
}
