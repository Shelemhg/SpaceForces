// Decompiled with JetBrains decompiler
// Type: Space_Forces.vp__ventanapuntaje
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
  public class vp__ventanapuntaje : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("lbnj1")]
    private Label _lbnj1;
    [AccessedThroughProperty("lbpuntosj1")]
    private Label _lbpuntosj1;
    [AccessedThroughProperty("bregresar")]
    private Button _bregresar;

    [DebuggerNonUserCode]
    public vp__ventanapuntaje()
    {
      this.Load += new EventHandler(this.vp__ventanapuntaje_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (vp__ventanapuntaje));
      this.Label1 = new Label();
      this.PictureBox1 = new PictureBox();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.lbnj1 = new Label();
      this.lbpuntosj1 = new Label();
      this.bregresar = new Button();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.Label1.BackColor = Color.Transparent;
      this.Label1.Font = new Font("Starcraft", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Lime;
      Label label1_1 = this.Label1;
      Point point1 = new Point(302, 196);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(436, 36);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Tabla de Puntajes";
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(323, 11);
      Point point3 = point1;
      pictureBox1_1.Location = point3;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(369, 145);
      Size size3 = size1;
      pictureBox1_2.Size = size3;
      this.PictureBox1.TabIndex = 1;
      this.PictureBox1.TabStop = false;
      this.Label2.BackColor = Color.Transparent;
      this.Label2.Font = new Font("Starcraft", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.Lime;
      Label label2_1 = this.Label2;
      point1 = new Point(334, 278);
      Point point4 = point1;
      label2_1.Location = point4;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(191, 36);
      Size size4 = size1;
      label2_2.Size = size4;
      this.Label2.TabIndex = 2;
      this.Label2.Text = "Jugador";
      this.Label3.BackColor = Color.Transparent;
      this.Label3.Font = new Font("Starcraft", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Lime;
      Label label3_1 = this.Label3;
      point1 = new Point(621, 274);
      Point point5 = point1;
      label3_1.Location = point5;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(191, 36);
      Size size5 = size1;
      label3_2.Size = size5;
      this.Label3.TabIndex = 3;
      this.Label3.Text = "Puntos";
      this.lbnj1.BackColor = Color.Transparent;
      this.lbnj1.Font = new Font("Starcraft", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbnj1.ForeColor = Color.Lime;
      Label lbnj1_1 = this.lbnj1;
      point1 = new Point(216, 368);
      Point point6 = point1;
      lbnj1_1.Location = point6;
      this.lbnj1.Name = "lbnj1";
      Label lbnj1_2 = this.lbnj1;
      size1 = new Size(354, 36);
      Size size6 = size1;
      lbnj1_2.Size = size6;
      this.lbnj1.TabIndex = 5;
      this.lbnj1.Text = "s";
      this.lbnj1.TextAlign = ContentAlignment.MiddleCenter;
      this.lbpuntosj1.BackColor = Color.Transparent;
      this.lbpuntosj1.Font = new Font("Starcraft", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbpuntosj1.ForeColor = Color.Lime;
      Label lbpuntosj1_1 = this.lbpuntosj1;
      point1 = new Point(621, 368);
      Point point7 = point1;
      lbpuntosj1_1.Location = point7;
      this.lbpuntosj1.Name = "lbpuntosj1";
      Label lbpuntosj1_2 = this.lbpuntosj1;
      size1 = new Size(191, 36);
      Size size7 = size1;
      lbpuntosj1_2.Size = size7;
      this.lbpuntosj1.TabIndex = 6;
      this.lbpuntosj1.Text = "100000";
      this.lbpuntosj1.TextAlign = ContentAlignment.MiddleCenter;
      this.bregresar.BackColor = Color.Black;
      this.bregresar.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bregresar.ForeColor = Color.Lime;
      Button bregresar1 = this.bregresar;
      point1 = new Point(803, 502);
      Point point8 = point1;
      bregresar1.Location = point8;
      this.bregresar.Name = "bregresar";
      Button bregresar2 = this.bregresar;
      size1 = new Size(176, 68);
      Size size8 = size1;
      bregresar2.Size = size8;
      this.bregresar.TabIndex = 8;
      this.bregresar.Text = "Regresar";
      this.bregresar.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      size1 = new Size(1024, 600);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.bregresar);
      this.Controls.Add((Control) this.lbpuntosj1);
      this.Controls.Add((Control) this.lbnj1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.Label1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (vp__ventanapuntaje);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (vp__ventanapuntaje);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual PictureBox PictureBox1
    {
      [DebuggerNonUserCode] get => this._PictureBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox1 = value;
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

    internal virtual Label lbnj1
    {
      [DebuggerNonUserCode] get => this._lbnj1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbnj1 = value;
    }

    internal virtual Label lbpuntosj1
    {
      [DebuggerNonUserCode] get => this._lbpuntosj1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbpuntosj1 = value;
    }

    internal virtual Button bregresar
    {
      [DebuggerNonUserCode] get => this._bregresar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._bregresar != null)
          this._bregresar.Click -= eventHandler;
        this._bregresar = value;
        if (this._bregresar == null)
          return;
        this._bregresar.Click += eventHandler;
      }
    }

    private void vp__ventanapuntaje_Load(object sender, EventArgs e)
    {
      this.lbnj1.Text = Variables_Publicas.nj;
      this.lbpuntosj1.Text = Conversions.ToString(checked (Variables_Publicas.pn1 + Variables_Publicas.pn2 + Variables_Publicas.pn3));
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.Close();
      MyProject.Forms.v0__menu_principal.Show();
    }
  }
}
