// Decompiled with JetBrains decompiler
// Type: Space_Forces.v0__menu_principal
// Assembly: Space Forces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F1F84538-E895-48C3-8596-7C330F22B69D
// Assembly location: C:\Users\Yarko\AppData\Local\Apps\2.0\LAZGQ9DQ.MM4\33WNND2T.LTO\spac..tion_55dd54f316dd7825_0001.0000_d2c45c90b68e6c08\Space Forces.exe

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
  public class v0__menu_principal : Form
  {
    private IContainer components;
    [AccessedThroughProperty("pbsalir")]
    private PictureBox _pbsalir;
    [AccessedThroughProperty("lbsalir")]
    private Label _lbsalir;
    [AccessedThroughProperty("pbnivel2")]
    private PictureBox _pbnivel2;
    [AccessedThroughProperty("lbnivel1")]
    private Label _lbnivel1;
    [AccessedThroughProperty("lbnivel2")]
    private Label _lbnivel2;
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;
    [AccessedThroughProperty("lbinstrucciones")]
    private Label _lbinstrucciones;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("lbnivel")]
    private Label _lbnivel;
    [AccessedThroughProperty("pbpreguntasalir")]
    private PictureBox _pbpreguntasalir;
    [AccessedThroughProperty("bsi")]
    private Button _bsi;
    [AccessedThroughProperty("lbseguroquedeseassalir")]
    private Label _lbseguroquedeseassalir;
    [AccessedThroughProperty("bno")]
    private Button _bno;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("lbinstruccionesdeverdad")]
    private Label _lbinstruccionesdeverdad;
    [AccessedThroughProperty("lbplf")]
    private Label _lbplf;
    [AccessedThroughProperty("lbnivel3")]
    private Label _lbnivel3;
    [AccessedThroughProperty("PictureBox4")]
    private PictureBox _PictureBox4;
    [AccessedThroughProperty("PictureBox5")]
    private PictureBox _PictureBox5;
    [AccessedThroughProperty("PictureBox6")]
    private PictureBox _PictureBox6;
    [AccessedThroughProperty("PictureBox7")]
    private PictureBox _PictureBox7;
    [AccessedThroughProperty("PictureBox8")]
    private PictureBox _PictureBox8;
    [AccessedThroughProperty("bc")]
    private Button _bc;
    [AccessedThroughProperty("bnuevousuario")]
    private Button _bnuevousuario;

    [DebuggerNonUserCode]
    public v0__menu_principal()
    {
      this.Load += new EventHandler(this.v0__menu_principal_Load);
      this.MouseMove += new MouseEventHandler(this.v0__menu_principal_MouseMove);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (v0__menu_principal));
      this.pbsalir = new PictureBox();
      this.lbsalir = new Label();
      this.pbnivel2 = new PictureBox();
      this.lbnivel1 = new Label();
      this.lbnivel2 = new Label();
      this.PictureBox2 = new PictureBox();
      this.lbinstrucciones = new Label();
      this.Label1 = new Label();
      this.lbnivel = new Label();
      this.pbpreguntasalir = new PictureBox();
      this.bsi = new Button();
      this.lbseguroquedeseassalir = new Label();
      this.bno = new Button();
      this.Label3 = new Label();
      this.lbinstruccionesdeverdad = new Label();
      this.lbplf = new Label();
      this.lbnivel3 = new Label();
      this.PictureBox4 = new PictureBox();
      this.PictureBox5 = new PictureBox();
      this.PictureBox6 = new PictureBox();
      this.PictureBox7 = new PictureBox();
      this.PictureBox8 = new PictureBox();
      this.bc = new Button();
      this.bnuevousuario = new Button();
      ((ISupportInitialize) this.pbsalir).BeginInit();
      ((ISupportInitialize) this.pbnivel2).BeginInit();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      ((ISupportInitialize) this.pbpreguntasalir).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((ISupportInitialize) this.PictureBox7).BeginInit();
      ((ISupportInitialize) this.PictureBox8).BeginInit();
      this.SuspendLayout();
      this.pbsalir.BackColor = Color.Transparent;
      this.pbsalir.Cursor = Cursors.Hand;
      this.pbsalir.Image = (Image) componentResourceManager.GetObject("pbsalir.Image");
      PictureBox pbsalir1 = this.pbsalir;
      Point point1 = new Point(805, 321);
      Point point2 = point1;
      pbsalir1.Location = point2;
      this.pbsalir.Name = "pbsalir";
      PictureBox pbsalir2 = this.pbsalir;
      Size size1 = new Size(207, 98);
      Size size2 = size1;
      pbsalir2.Size = size2;
      this.pbsalir.TabIndex = 3;
      this.pbsalir.TabStop = false;
      this.lbsalir.AutoSize = true;
      this.lbsalir.BackColor = Color.Transparent;
      this.lbsalir.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbsalir.ForeColor = Color.White;
      Label lbsalir1 = this.lbsalir;
      point1 = new Point(878, 324);
      Point point3 = point1;
      lbsalir1.Location = point3;
      this.lbsalir.Name = "lbsalir";
      Label lbsalir2 = this.lbsalir;
      size1 = new Size(73, 15);
      Size size3 = size1;
      lbsalir2.Size = size3;
      this.lbsalir.TabIndex = 4;
      this.lbsalir.Text = "Salir";
      this.pbnivel2.BackColor = Color.Transparent;
      this.pbnivel2.Cursor = Cursors.Hand;
      this.pbnivel2.Image = (Image) componentResourceManager.GetObject("pbnivel2.Image");
      PictureBox pbnivel2_1 = this.pbnivel2;
      point1 = new Point(340, 26);
      Point point4 = point1;
      pbnivel2_1.Location = point4;
      this.pbnivel2.Name = "pbnivel2";
      PictureBox pbnivel2_2 = this.pbnivel2;
      size1 = new Size(137, 158);
      Size size4 = size1;
      pbnivel2_2.Size = size4;
      this.pbnivel2.TabIndex = 5;
      this.pbnivel2.TabStop = false;
      this.pbnivel2.Visible = false;
      this.lbnivel1.BackColor = Color.Transparent;
      this.lbnivel1.Cursor = Cursors.Hand;
      this.lbnivel1.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbnivel1.ForeColor = Color.White;
      Label lbnivel1_1 = this.lbnivel1;
      point1 = new Point(39, 172);
      Point point5 = point1;
      lbnivel1_1.Location = point5;
      this.lbnivel1.Name = "lbnivel1";
      Label lbnivel1_2 = this.lbnivel1;
      size1 = new Size(153, 175);
      Size size5 = size1;
      lbnivel1_2.Size = size5;
      this.lbnivel1.TabIndex = 8;
      this.lbnivel1.Text = "NIVEL 1 Lluvia de Meteoritos";
      this.lbnivel1.TextAlign = ContentAlignment.BottomCenter;
      this.lbnivel2.BackColor = Color.Transparent;
      this.lbnivel2.Cursor = Cursors.Hand;
      this.lbnivel2.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbnivel2.ForeColor = Color.White;
      Label lbnivel2_1 = this.lbnivel2;
      point1 = new Point(324, 113);
      Point point6 = point1;
      lbnivel2_1.Location = point6;
      this.lbnivel2.Name = "lbnivel2";
      Label lbnivel2_2 = this.lbnivel2;
      size1 = new Size(153, 69);
      Size size6 = size1;
      lbnivel2_2.Size = size6;
      this.lbnivel2.TabIndex = 9;
      this.lbnivel2.Text = "NIVEL 2 Protege tu Flota";
      this.lbnivel2.TextAlign = ContentAlignment.MiddleCenter;
      this.lbnivel2.Visible = false;
      this.PictureBox2.BackColor = Color.Transparent;
      this.PictureBox2.BackgroundImage = (Image) Space_Forces.My.Resources.Resources.Tablero;
      PictureBox pictureBox2_1 = this.PictureBox2;
      point1 = new Point(0, 440);
      Point point7 = point1;
      pictureBox2_1.Location = point7;
      this.PictureBox2.Name = "PictureBox2";
      PictureBox pictureBox2_2 = this.PictureBox2;
      size1 = new Size(1024, 159);
      Size size7 = size1;
      pictureBox2_2.Size = size7;
      this.PictureBox2.TabIndex = 11;
      this.PictureBox2.TabStop = false;
      this.lbinstrucciones.BackColor = Color.Black;
      this.lbinstrucciones.Font = new Font("Starcraft", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbinstrucciones.ForeColor = Color.Lime;
      Label lbinstrucciones1 = this.lbinstrucciones;
      point1 = new Point(258, 503);
      Point point8 = point1;
      lbinstrucciones1.Location = point8;
      this.lbinstrucciones.Name = "lbinstrucciones";
      Label lbinstrucciones2 = this.lbinstrucciones;
      size1 = new Size(391, 42);
      Size size8 = size1;
      lbinstrucciones2.Size = size8;
      this.lbinstrucciones.TabIndex = 12;
      this.Label1.BackColor = Color.Black;
      this.Label1.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Lime;
      Label label1_1 = this.Label1;
      point1 = new Point(262, 477);
      Point point9 = point1;
      label1_1.Location = point9;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(245, 21);
      Size size9 = size1;
      label1_2.Size = size9;
      this.Label1.TabIndex = 13;
      this.Label1.Text = "Instrucciones del";
      this.Label1.TextAlign = ContentAlignment.MiddleCenter;
      this.lbnivel.BackColor = Color.Black;
      this.lbnivel.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbnivel.ForeColor = Color.Lime;
      Label lbnivel1 = this.lbnivel;
      point1 = new Point(513, 477);
      Point point10 = point1;
      lbnivel1.Location = point10;
      this.lbnivel.Name = "lbnivel";
      Label lbnivel2 = this.lbnivel;
      size1 = new Size(136, 21);
      Size size10 = size1;
      lbnivel2.Size = size10;
      this.lbnivel.TabIndex = 14;
      this.lbnivel.TextAlign = ContentAlignment.MiddleCenter;
      PictureBox pbpreguntasalir1 = this.pbpreguntasalir;
      point1 = new Point(366, 216);
      Point point11 = point1;
      pbpreguntasalir1.Location = point11;
      this.pbpreguntasalir.Name = "pbpreguntasalir";
      PictureBox pbpreguntasalir2 = this.pbpreguntasalir;
      size1 = new Size(310, 147);
      Size size11 = size1;
      pbpreguntasalir2.Size = size11;
      this.pbpreguntasalir.TabIndex = 15;
      this.pbpreguntasalir.TabStop = false;
      this.pbpreguntasalir.Visible = false;
      this.bsi.BackColor = Color.Red;
      this.bsi.Cursor = Cursors.Hand;
      this.bsi.FlatStyle = FlatStyle.Popup;
      this.bsi.Font = new Font("Starcraft", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button bsi1 = this.bsi;
      point1 = new Point(396, 316);
      Point point12 = point1;
      bsi1.Location = point12;
      this.bsi.Name = "bsi";
      Button bsi2 = this.bsi;
      size1 = new Size(90, 31);
      Size size12 = size1;
      bsi2.Size = size12;
      this.bsi.TabIndex = 17;
      this.bsi.Text = "Si";
      this.bsi.UseVisualStyleBackColor = false;
      this.bsi.Visible = false;
      this.lbseguroquedeseassalir.BackColor = Color.Silver;
      this.lbseguroquedeseassalir.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbseguroquedeseassalir.ForeColor = Color.Black;
      Label lbseguroquedeseassalir1 = this.lbseguroquedeseassalir;
      point1 = new Point(397, 240);
      Point point13 = point1;
      lbseguroquedeseassalir1.Location = point13;
      this.lbseguroquedeseassalir.Name = "lbseguroquedeseassalir";
      Label lbseguroquedeseassalir2 = this.lbseguroquedeseassalir;
      size1 = new Size(245, 47);
      Size size13 = size1;
      lbseguroquedeseassalir2.Size = size13;
      this.lbseguroquedeseassalir.TabIndex = 18;
      this.lbseguroquedeseassalir.Text = "seguro que deseas salir?";
      this.lbseguroquedeseassalir.TextAlign = ContentAlignment.MiddleCenter;
      this.lbseguroquedeseassalir.Visible = false;
      this.bno.BackColor = Color.Blue;
      this.bno.Cursor = Cursors.Hand;
      this.bno.FlatStyle = FlatStyle.Popup;
      this.bno.Font = new Font("Starcraft", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Button bno1 = this.bno;
      point1 = new Point(559, 316);
      Point point14 = point1;
      bno1.Location = point14;
      this.bno.Name = "bno";
      Button bno2 = this.bno;
      size1 = new Size(90, 31);
      Size size14 = size1;
      bno2.Size = size14;
      this.bno.TabIndex = 19;
      this.bno.Text = "No";
      this.bno.UseVisualStyleBackColor = false;
      this.bno.Visible = false;
      this.Label3.BackColor = Color.Black;
      this.Label3.Font = new Font("Comic Sans MS", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Red;
      Label label3_1 = this.Label3;
      point1 = new Point(695, 534);
      Point point15 = point1;
      label3_1.Location = point15;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(302, 55);
      Size size15 = size1;
      label3_2.Size = size15;
      this.Label3.TabIndex = 20;
      this.Label3.Text = "Pasa el puntero sobre un nivel para ver las instrucciones";
      this.Label3.TextAlign = ContentAlignment.MiddleCenter;
      this.lbinstruccionesdeverdad.BackColor = Color.Black;
      this.lbinstruccionesdeverdad.Font = new Font("Comic Sans MS", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbinstruccionesdeverdad.ForeColor = Color.Red;
      Label lbinstruccionesdeverdad1 = this.lbinstruccionesdeverdad;
      point1 = new Point(258, 551);
      Point point16 = point1;
      lbinstruccionesdeverdad1.Location = point16;
      this.lbinstruccionesdeverdad.Name = "lbinstruccionesdeverdad";
      Label lbinstruccionesdeverdad2 = this.lbinstruccionesdeverdad;
      size1 = new Size(391, 42);
      Size size16 = size1;
      lbinstruccionesdeverdad2.Size = size16;
      this.lbinstruccionesdeverdad.TabIndex = 21;
      this.lbplf.BackColor = Color.Black;
      this.lbplf.Font = new Font("Comic Sans MS", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbplf.ForeColor = Color.Blue;
      Label lbplf1 = this.lbplf;
      point1 = new Point(693, 524);
      Point point17 = point1;
      lbplf1.Location = point17;
      this.lbplf.Name = "lbplf";
      Label lbplf2 = this.lbplf;
      size1 = new Size(302, 75);
      Size size17 = size1;
      lbplf2.Size = size17;
      this.lbplf.TabIndex = 22;
      this.lbplf.TextAlign = ContentAlignment.MiddleCenter;
      this.lbplf.Visible = false;
      this.lbnivel3.BackColor = Color.Transparent;
      this.lbnivel3.Cursor = Cursors.Hand;
      this.lbnivel3.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbnivel3.ForeColor = Color.White;
      Label lbnivel3_1 = this.lbnivel3;
      point1 = new Point(720, 77);
      Point point18 = point1;
      lbnivel3_1.Location = point18;
      this.lbnivel3.Name = "lbnivel3";
      Label lbnivel3_2 = this.lbnivel3;
      size1 = new Size(137, 160);
      Size size18 = size1;
      lbnivel3_2.Size = size18;
      this.lbnivel3.TabIndex = 23;
      this.lbnivel3.Text = "nivel 3  cristales de nimidio";
      this.lbnivel3.TextAlign = ContentAlignment.BottomCenter;
      this.lbnivel3.Visible = false;
      this.PictureBox4.BackColor = Color.Transparent;
      this.PictureBox4.Cursor = Cursors.Hand;
      PictureBox pictureBox4_1 = this.PictureBox4;
      point1 = new Point(949, 440);
      Point point19 = point1;
      pictureBox4_1.Location = point19;
      this.PictureBox4.Name = "PictureBox4";
      PictureBox pictureBox4_2 = this.PictureBox4;
      size1 = new Size(75, 39);
      Size size19 = size1;
      pictureBox4_2.Size = size19;
      this.PictureBox4.TabIndex = 103;
      this.PictureBox4.TabStop = false;
      this.PictureBox5.BackColor = Color.Transparent;
      this.PictureBox5.Cursor = Cursors.Hand;
      PictureBox pictureBox5_1 = this.PictureBox5;
      point1 = new Point(881, 440);
      Point point20 = point1;
      pictureBox5_1.Location = point20;
      this.PictureBox5.Name = "PictureBox5";
      PictureBox pictureBox5_2 = this.PictureBox5;
      size1 = new Size(75, 35);
      Size size20 = size1;
      pictureBox5_2.Size = size20;
      this.PictureBox5.TabIndex = 104;
      this.PictureBox5.TabStop = false;
      this.PictureBox6.BackColor = Color.Transparent;
      this.PictureBox6.Cursor = Cursors.Hand;
      PictureBox pictureBox6_1 = this.PictureBox6;
      point1 = new Point(810, 440);
      Point point21 = point1;
      pictureBox6_1.Location = point21;
      this.PictureBox6.Name = "PictureBox6";
      PictureBox pictureBox6_2 = this.PictureBox6;
      size1 = new Size(75, 29);
      Size size21 = size1;
      pictureBox6_2.Size = size21;
      this.PictureBox6.TabIndex = 105;
      this.PictureBox6.TabStop = false;
      this.PictureBox7.BackColor = Color.Transparent;
      this.PictureBox7.Cursor = Cursors.Hand;
      PictureBox pictureBox7_1 = this.PictureBox7;
      point1 = new Point(745, 440);
      Point point22 = point1;
      pictureBox7_1.Location = point22;
      this.PictureBox7.Name = "PictureBox7";
      PictureBox pictureBox7_2 = this.PictureBox7;
      size1 = new Size(75, 21);
      Size size22 = size1;
      pictureBox7_2.Size = size22;
      this.PictureBox7.TabIndex = 106;
      this.PictureBox7.TabStop = false;
      this.PictureBox8.BackColor = Color.Transparent;
      this.PictureBox8.Cursor = Cursors.Hand;
      PictureBox pictureBox8_1 = this.PictureBox8;
      point1 = new Point(671, 439);
      Point point23 = point1;
      pictureBox8_1.Location = point23;
      this.PictureBox8.Name = "PictureBox8";
      PictureBox pictureBox8_2 = this.PictureBox8;
      size1 = new Size(75, 13);
      Size size23 = size1;
      pictureBox8_2.Size = size23;
      this.PictureBox8.TabIndex = 107;
      this.PictureBox8.TabStop = false;
      this.bc.BackColor = Color.Black;
      this.bc.Font = new Font("Starcraft", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bc.ForeColor = Color.Blue;
      Button bc1 = this.bc;
      point1 = new Point(375, 375);
      Point point24 = point1;
      bc1.Location = point24;
      this.bc.Name = "bc";
      Button bc2 = this.bc;
      size1 = new Size(273, 43);
      Size size24 = size1;
      bc2.Size = size24;
      this.bc.TabIndex = 108;
      this.bc.Text = "creditos";
      this.bc.UseVisualStyleBackColor = false;
      this.bc.Visible = false;
      this.bnuevousuario.BackColor = Color.Black;
      this.bnuevousuario.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bnuevousuario.ForeColor = Color.Lime;
      Button bnuevousuario1 = this.bnuevousuario;
      point1 = new Point(12, 375);
      Point point25 = point1;
      bnuevousuario1.Location = point25;
      this.bnuevousuario.Name = "bnuevousuario";
      Button bnuevousuario2 = this.bnuevousuario;
      size1 = new Size(160, 69);
      Size size25 = size1;
      bnuevousuario2.Size = size25;
      this.bnuevousuario.TabIndex = 109;
      this.bnuevousuario.Text = "Nuevo usuario";
      this.bnuevousuario.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      size1 = new Size(1024, 600);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.bnuevousuario);
      this.Controls.Add((Control) this.bc);
      this.Controls.Add((Control) this.PictureBox8);
      this.Controls.Add((Control) this.PictureBox7);
      this.Controls.Add((Control) this.PictureBox6);
      this.Controls.Add((Control) this.PictureBox5);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.lbnivel3);
      this.Controls.Add((Control) this.lbplf);
      this.Controls.Add((Control) this.lbinstruccionesdeverdad);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.bno);
      this.Controls.Add((Control) this.lbseguroquedeseassalir);
      this.Controls.Add((Control) this.bsi);
      this.Controls.Add((Control) this.pbpreguntasalir);
      this.Controls.Add((Control) this.lbnivel);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.lbinstrucciones);
      this.Controls.Add((Control) this.PictureBox2);
      this.Controls.Add((Control) this.lbnivel2);
      this.Controls.Add((Control) this.lbnivel1);
      this.Controls.Add((Control) this.pbnivel2);
      this.Controls.Add((Control) this.lbsalir);
      this.Controls.Add((Control) this.pbsalir);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (v0__menu_principal);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (v0__menu_principal);
      ((ISupportInitialize) this.pbsalir).EndInit();
      ((ISupportInitialize) this.pbnivel2).EndInit();
      ((ISupportInitialize) this.PictureBox2).EndInit();
      ((ISupportInitialize) this.pbpreguntasalir).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      ((ISupportInitialize) this.PictureBox5).EndInit();
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((ISupportInitialize) this.PictureBox7).EndInit();
      ((ISupportInitialize) this.PictureBox8).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual PictureBox pbsalir
    {
      [DebuggerNonUserCode] get => this._pbsalir;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.pbsalir_Click);
        if (this._pbsalir != null)
          this._pbsalir.Click -= eventHandler;
        this._pbsalir = value;
        if (this._pbsalir == null)
          return;
        this._pbsalir.Click += eventHandler;
      }
    }

    internal virtual Label lbsalir
    {
      [DebuggerNonUserCode] get => this._lbsalir;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbsalir = value;
    }

    internal virtual PictureBox pbnivel2
    {
      [DebuggerNonUserCode] get => this._pbnivel2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.pbnivel2_MouseMove);
        EventHandler eventHandler = new EventHandler(this.pbnivel2_Click);
        if (this._pbnivel2 != null)
        {
          this._pbnivel2.MouseMove -= mouseEventHandler;
          this._pbnivel2.Click -= eventHandler;
        }
        this._pbnivel2 = value;
        if (this._pbnivel2 == null)
          return;
        this._pbnivel2.MouseMove += mouseEventHandler;
        this._pbnivel2.Click += eventHandler;
      }
    }

    internal virtual Label lbnivel1
    {
      [DebuggerNonUserCode] get => this._lbnivel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.lbnivel1_MouseMove);
        EventHandler eventHandler = new EventHandler(this.lbnivel1_Click);
        if (this._lbnivel1 != null)
        {
          this._lbnivel1.MouseMove -= mouseEventHandler;
          this._lbnivel1.Click -= eventHandler;
        }
        this._lbnivel1 = value;
        if (this._lbnivel1 == null)
          return;
        this._lbnivel1.MouseMove += mouseEventHandler;
        this._lbnivel1.Click += eventHandler;
      }
    }

    internal virtual Label lbnivel2
    {
      [DebuggerNonUserCode] get => this._lbnivel2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.lbnivel2_MouseMove);
        EventHandler eventHandler = new EventHandler(this.lbnivel2_Click);
        if (this._lbnivel2 != null)
        {
          this._lbnivel2.MouseMove -= mouseEventHandler;
          this._lbnivel2.Click -= eventHandler;
        }
        this._lbnivel2 = value;
        if (this._lbnivel2 == null)
          return;
        this._lbnivel2.MouseMove += mouseEventHandler;
        this._lbnivel2.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox2
    {
      [DebuggerNonUserCode] get => this._PictureBox2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox2 = value;
    }

    internal virtual Label lbinstrucciones
    {
      [DebuggerNonUserCode] get => this._lbinstrucciones;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbinstrucciones = value;
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual Label lbnivel
    {
      [DebuggerNonUserCode] get => this._lbnivel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbnivel = value;
    }

    internal virtual PictureBox pbpreguntasalir
    {
      [DebuggerNonUserCode] get => this._pbpreguntasalir;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pbpreguntasalir = value;
    }

    internal virtual Button bsi
    {
      [DebuggerNonUserCode] get => this._bsi;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bsi_Click);
        if (this._bsi != null)
          this._bsi.Click -= eventHandler;
        this._bsi = value;
        if (this._bsi == null)
          return;
        this._bsi.Click += eventHandler;
      }
    }

    internal virtual Label lbseguroquedeseassalir
    {
      [DebuggerNonUserCode] get => this._lbseguroquedeseassalir;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbseguroquedeseassalir = value;
    }

    internal virtual Button bno
    {
      [DebuggerNonUserCode] get => this._bno;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bno_Click);
        if (this._bno != null)
          this._bno.Click -= eventHandler;
        this._bno = value;
        if (this._bno == null)
          return;
        this._bno.Click += eventHandler;
      }
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual Label lbinstruccionesdeverdad
    {
      [DebuggerNonUserCode] get => this._lbinstruccionesdeverdad;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbinstruccionesdeverdad = value;
    }

    internal virtual Label lbplf
    {
      [DebuggerNonUserCode] get => this._lbplf;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbplf = value;
    }

    internal virtual Label lbnivel3
    {
      [DebuggerNonUserCode] get => this._lbnivel3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.lbnivel3_MouseMove);
        EventHandler eventHandler = new EventHandler(this.lbnivel3_Click);
        if (this._lbnivel3 != null)
        {
          this._lbnivel3.MouseMove -= mouseEventHandler;
          this._lbnivel3.Click -= eventHandler;
        }
        this._lbnivel3 = value;
        if (this._lbnivel3 == null)
          return;
        this._lbnivel3.MouseMove += mouseEventHandler;
        this._lbnivel3.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox4
    {
      [DebuggerNonUserCode] get => this._PictureBox4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox4 = value;
    }

    internal virtual PictureBox PictureBox5
    {
      [DebuggerNonUserCode] get => this._PictureBox5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox5 = value;
    }

    internal virtual PictureBox PictureBox6
    {
      [DebuggerNonUserCode] get => this._PictureBox6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox6 = value;
    }

    internal virtual PictureBox PictureBox7
    {
      [DebuggerNonUserCode] get => this._PictureBox7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox7 = value;
    }

    internal virtual PictureBox PictureBox8
    {
      [DebuggerNonUserCode] get => this._PictureBox8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox8 = value;
    }

    internal virtual Button bc
    {
      [DebuggerNonUserCode] get => this._bc;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bc_Click);
        if (this._bc != null)
          this._bc.Click -= eventHandler;
        this._bc = value;
        if (this._bc == null)
          return;
        this._bc.Click += eventHandler;
      }
    }

    internal virtual Button bnuevousuario
    {
      [DebuggerNonUserCode] get => this._bnuevousuario;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bnuevousuario_Click);
        if (this._bnuevousuario != null)
          this._bnuevousuario.Click -= eventHandler;
        this._bnuevousuario = value;
        if (this._bnuevousuario == null)
          return;
        this._bnuevousuario.Click += eventHandler;
      }
    }

    private void v0__menu_principal_Load(object sender, EventArgs e)
    {
      this.lbnivel1.Focus();
      int gda = Variables_Publicas.gda;
      if (gda == 0)
        return;
      if (gda == 1)
      {
        this.pbnivel2.Visible = true;
        this.lbnivel2.Visible = true;
      }
      else if (gda == 3)
      {
        this.pbnivel2.Visible = true;
        this.lbnivel2.Visible = true;
        this.lbnivel3.Visible = true;
      }
      else if (gda >= 4)
      {
        this.pbnivel2.Visible = true;
        this.lbnivel2.Visible = true;
        this.lbnivel3.Visible = true;
      }
      else
      {
        if (gda < 6)
          return;
        this.pbnivel2.Visible = true;
        this.lbnivel2.Visible = true;
        this.lbnivel3.Visible = true;
        this.bc.Visible = true;
      }
    }

    private void pbsalir_Click(object sender, EventArgs e)
    {
      this.lbseguroquedeseassalir.Visible = true;
      this.pbsalir.Visible = true;
      this.bsi.Visible = true;
      this.bno.Visible = true;
      this.pbpreguntasalir.Visible = true;
    }

    private void lbnivel1_Click(object sender, EventArgs e)
    {
      MyProject.Forms.v1__nivel1.Close();
      MyProject.Forms.v2__nivel2.Close();
      MyProject.Forms.v3__nivel3.Close();
      MyProject.Forms.v1__nivel1.Show();
      this.Close();
      MyProject.Forms.v00__menu_de_nivel_y_nombre.Close();
    }

    private void pbnivel2_Click(object sender, EventArgs e)
    {
      MyProject.Forms.v1__nivel1.Close();
      MyProject.Forms.v2__nivel2.Close();
      MyProject.Forms.v3__nivel3.Close();
      MyProject.Forms.v2__nivel2.Show();
      this.Close();
      MyProject.Forms.v00__menu_de_nivel_y_nombre.Close();
    }

    private void lbnivel1_MouseMove(object sender, MouseEventArgs e)
    {
      this.lbnivel.Text = "Nivel 1";
      this.lbinstrucciones.Text = "Una nave se a descompuesto , y una lluvia de meteoritos se aproxima, protegela  durante 3 minutos destruyendo los meteoritos.";
      this.lbinstruccionesdeverdad.Text = "Cada meteorito tiene una coordenada en forma de operación, ingresa el resultado del meteorito que quieres destruir. ";
      this.lbplf.Text = "Si en algun momento queieres cerrar el juego por alguna emergencia, ingresa una letra en ves de un número durante el juego. ";
      this.lbplf.Visible = true;
    }

    private void bsi_Click(object sender, EventArgs e)
    {
      this.Close();
      MyProject.Forms.v00__menu_de_nivel_y_nombre.Close();
      MyProject.Forms.v000__video.Close();
      MyProject.Forms.v1__nivel1.Close();
      MyProject.Forms.v2__nivel2.Close();
      MyProject.Forms.v3__nivel3.Close();
      MyProject.Forms.vp__ventanapuntaje.Close();
    }

    private void bno_Click(object sender, EventArgs e)
    {
      this.lbseguroquedeseassalir.Visible = false;
      this.pbsalir.Visible = false;
      this.bsi.Visible = false;
      this.bno.Visible = false;
      this.pbpreguntasalir.Visible = false;
    }

    private void pbnivel2_MouseMove(object sender, MouseEventArgs e)
    {
      this.lbnivel.Text = "Nivel 2";
      this.lbinstrucciones.Text = "De regreso a tu base te encuentras con un banco de asteroides.";
      this.lbinstruccionesdeverdad.Text = "Ingresa la coordenada faltante de la serie hasta completar 3 series y esquivar el meteorito. ";
      this.lbplf.Text = "Si la coordenada faltante dice 3, resuelvel la serie, no importa que ya la hubieraas resuelto antes.  Si en algun momento queieres cerrar el juego por alguna emergencia, ingresa una letra en ves de un número durante el juego. ";
      this.lbplf.Visible = true;
    }

    private void lbnivel2_Click(object sender, EventArgs e)
    {
      MyProject.Forms.v2__nivel2.Show();
      this.Close();
      MyProject.Forms.v00__menu_de_nivel_y_nombre.Close();
    }

    private void v0__menu_principal_MouseMove(object sender, MouseEventArgs e) => this.lbplf.Visible = false;

    private void lbnivel2_MouseMove(object sender, MouseEventArgs e)
    {
      this.lbnivel.Text = "Nivel 2";
      this.lbinstrucciones.Text = "De regreso a tu base te encuentras con un banco de asteroides.";
      this.lbinstruccionesdeverdad.Text = "Ingresa la coordenada faltante de la serie hasta completar 3 series y esquivar el meteorito. ";
      this.lbplf.Text = "Si la coordenada faltante dice 3, resuelvel la serie, no importa que ya la hubieraas resuelto antes.  Si en algun momento queieres cerrar el juego por alguna emergencia, ingresa una letra en ves de un número durante el juego. ";
      this.lbplf.Visible = true;
    }

    private void lbnivel3_Click(object sender, EventArgs e)
    {
      MyProject.Forms.v3__nivel3.Close();
      MyProject.Forms.v1__nivel1.Close();
      MyProject.Forms.v2__nivel2.Close();
      MyProject.Forms.v00__menu_de_nivel_y_nombre.Close();
      MyProject.Forms.v3__nivel3.Show();
      this.Close();
    }

    private void c6_Click(object sender, EventArgs e)
    {
      MyProject.Forms.v3__nivel3.Show();
      MyProject.Forms.v1__nivel1.Close();
      MyProject.Forms.v2__nivel2.Close();
      this.Close();
    }

    private void c7_Click(object sender, EventArgs e)
    {
      MyProject.Forms.v3__nivel3.Show();
      MyProject.Forms.v1__nivel1.Close();
      MyProject.Forms.v2__nivel2.Close();
      this.Close();
    }

    private void c8_Click(object sender, EventArgs e)
    {
      MyProject.Forms.v3__nivel3.Show();
      MyProject.Forms.v1__nivel1.Close();
      MyProject.Forms.v2__nivel2.Close();
      this.Close();
    }

    private void c9_Click(object sender, EventArgs e)
    {
      MyProject.Forms.v3__nivel3.Show();
      MyProject.Forms.v1__nivel1.Close();
      MyProject.Forms.v2__nivel2.Close();
      this.Close();
    }

    private void lbnivel3_MouseMove(object sender, MouseEventArgs e)
    {
      this.lbnivel.Text = "Nivel 3";
      this.lbinstrucciones.Text = "Viajando por el espacio, te encuentras con una nube de valiosísimos cristales de nimidio.";
      this.lbinstruccionesdeverdad.Text = "Ingresa el resaultado de la operacion en pantalla, para aumentar la velocidad de tu nave y asi ganar los cristales. ";
      this.lbplf.Text = "Responde rapido, ya que tu velocidad disminuye cada 2 segundos.  Si en algun momento queieres cerrar el juego por alguna emergencia, ingresa una letra en ves de un número durante el juego. ";
      this.lbplf.Visible = true;
    }

    private void c10_Click(object sender, EventArgs e)
    {
    }

    private void bc_Click(object sender, EventArgs e)
    {
      MyProject.Forms.vc__ventanadecreditos.Close();
      MyProject.Forms.v3__nivel3.Close();
      MyProject.Forms.v1__nivel1.Close();
      MyProject.Forms.v2__nivel2.Close();
      MyProject.Forms.v00__menu_de_nivel_y_nombre.Close();
      MyProject.Forms.vc__ventanadecreditos.Show();
      this.Close();
    }

    private void bnuevousuario_Click(object sender, EventArgs e)
    {
      MyProject.Forms.v00__menu_de_nivel_y_nombre.Show();
      this.Close();
    }
  }
}
