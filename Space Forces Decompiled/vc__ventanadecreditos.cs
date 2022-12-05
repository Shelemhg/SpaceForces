// Decompiled with JetBrains decompiler
// Type: Space_Forces.vc__ventanadecreditos
// Assembly: Space Forces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F1F84538-E895-48C3-8596-7C330F22B69D
// Assembly location: C:\Users\Yarko\AppData\Local\Apps\2.0\LAZGQ9DQ.MM4\33WNND2T.LTO\spac..tion_55dd54f316dd7825_0001.0000_d2c45c90b68e6c08\Space Forces.exe

using AxWMPLib;
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
  public class vc__ventanadecreditos : Form
  {
    private IContainer components;
    [AccessedThroughProperty("tcreditos")]
    private Label _tcreditos;
    [AccessedThroughProperty("Timer1")]
    private Timer _Timer1;
    [AccessedThroughProperty("lbpensamiento")]
    private Label _lbpensamiento;
    [AccessedThroughProperty("bregresar")]
    private Button _bregresar;
    [AccessedThroughProperty("rwm")]
    private AxWindowsMediaPlayer _rwm;

    [DebuggerNonUserCode]
    public vc__ventanadecreditos()
    {
      this.Load += new EventHandler(this.vc__ventanadecreditos_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (vc__ventanadecreditos));
      this.tcreditos = new Label();
      this.Timer1 = new Timer(this.components);
      this.lbpensamiento = new Label();
      this.bregresar = new Button();
      this.rwm = new AxWindowsMediaPlayer();
      this.rwm.BeginInit();
      this.SuspendLayout();
      this.tcreditos.BackColor = Color.Transparent;
      this.tcreditos.Font = new Font("Comic Sans MS", 24.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tcreditos.ForeColor = Color.White;
      Label tcreditos1 = this.tcreditos;
      Point point1 = new Point(198, 247);
      Point point2 = point1;
      tcreditos1.Location = point2;
      this.tcreditos.Name = "tcreditos";
      Label tcreditos2 = this.tcreditos;
      Size size1 = new Size(599, 245);
      Size size2 = size1;
      tcreditos2.Size = size2;
      this.tcreditos.TabIndex = 0;
      this.tcreditos.TextAlign = ContentAlignment.MiddleCenter;
      this.Timer1.Enabled = true;
      this.Timer1.Interval = 15000;
      this.lbpensamiento.BackColor = Color.FromArgb(224, 224, 224);
      this.lbpensamiento.Font = new Font("Comic Sans MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbpensamiento.ForeColor = Color.Black;
      Label lbpensamiento1 = this.lbpensamiento;
      point1 = new Point(513, 493);
      Point point3 = point1;
      lbpensamiento1.Location = point3;
      this.lbpensamiento.Name = "lbpensamiento";
      Label lbpensamiento2 = this.lbpensamiento;
      size1 = new Size(506, 103);
      Size size3 = size1;
      lbpensamiento2.Size = size3;
      this.lbpensamiento.TabIndex = 1;
      this.lbpensamiento.TextAlign = ContentAlignment.MiddleCenter;
      this.bregresar.BackColor = Color.Black;
      this.bregresar.Font = new Font("Starcraft", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bregresar.ForeColor = Color.Blue;
      Button bregresar1 = this.bregresar;
      point1 = new Point(12, 545);
      Point point4 = point1;
      bregresar1.Location = point4;
      this.bregresar.Name = "bregresar";
      Button bregresar2 = this.bregresar;
      size1 = new Size(273, 43);
      Size size4 = size1;
      bregresar2.Size = size4;
      this.bregresar.TabIndex = 109;
      this.bregresar.Text = "regresar";
      this.bregresar.UseVisualStyleBackColor = false;
      this.bregresar.Visible = false;
      this.rwm.Enabled = true;
      AxWindowsMediaPlayer rwm1 = this.rwm;
      point1 = new Point(215, 496);
      Point point5 = point1;
      rwm1.Location = point5;
      this.rwm.Name = "rwm";
      this.rwm.OcxState = (AxHost.State) componentResourceManager.GetObject("rwm.OcxState");
      AxWindowsMediaPlayer rwm2 = this.rwm;
      size1 = new Size(83, 29);
      Size size5 = size1;
      rwm2.Size = size5;
      this.rwm.TabIndex = 110;
      this.rwm.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      size1 = new Size(1024, 600);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.rwm);
      this.Controls.Add((Control) this.bregresar);
      this.Controls.Add((Control) this.lbpensamiento);
      this.Controls.Add((Control) this.tcreditos);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (vc__ventanadecreditos);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (vc__ventanadecreditos);
      this.rwm.EndInit();
      this.ResumeLayout(false);
    }

    internal virtual Label tcreditos
    {
      [DebuggerNonUserCode] get => this._tcreditos;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._tcreditos = value;
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

    internal virtual Label lbpensamiento
    {
      [DebuggerNonUserCode] get => this._lbpensamiento;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lbpensamiento = value;
    }

    internal virtual Button bregresar
    {
      [DebuggerNonUserCode] get => this._bregresar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bregresar_Click);
        if (this._bregresar != null)
          this._bregresar.Click -= eventHandler;
        this._bregresar = value;
        if (this._bregresar == null)
          return;
        this._bregresar.Click += eventHandler;
      }
    }

    internal virtual AxWindowsMediaPlayer rwm
    {
      [DebuggerNonUserCode] get => this._rwm;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rwm = value;
    }

    private void vc__ventanadecreditos_Load(object sender, EventArgs e)
    {
      Variables_Publicas.contador = 0;
      this.tcreditos.Text = "Es un juego creado por DUNKEL ENTERTAINMENT en los estudios DUNKEL en México  DF. .";
      this.lbpensamiento.Text = "Si haces lo que siempre has hecho, obtendrás lo que siempre has obtenido";
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      checked { ++Variables_Publicas.contador; }
      switch (Variables_Publicas.contador)
      {
        case 1:
          this.tcreditos.Text = "Productor, Diseñador, Ideas, Programador, Director de Fotografia, Testing, Productor Ejecutivo y Director General: Shelem Hurtado.";
          this.lbpensamiento.Text = "Hay que iniciar con un pensamiento positivo para todo.";
          break;
        case 2:
          this.tcreditos.Text = "Este juego se terminó el sábado 5 de junio en los estudios DUNKEL, después de muchas horas de trabajo y esfuerzo.";
          this.lbpensamiento.Text = "Las estrellas son como los ideales, no las alcanzamos pero iluminan nuestro camino.";
          break;
        case 3:
          this.tcreditos.Text = "Este juego es el primero de vararios, y apesar de que tiene errores, no nos disculpamos, se hizo lo que se pudo, Y A QUIEN NO LE GUSTE... , QUE HAGA EL SUYO.";
          this.lbpensamiento.Text = "Utilizo la cabeza, no el corazón";
          break;
        case 4:
          this.tcreditos.Text = "A pesar de que no es un juego divertidsimo, costó, costó mucho, pero si se pudo.";
          this.lbpensamiento.Text = "Solo hay dos cosas infinitas, el universo y la estupidez humana.";
          this.bregresar.Visible = true;
          break;
      }
    }

    private void bregresar_Click(object sender, EventArgs e)
    {
      MyProject.Forms.vp__ventanapuntaje.Show();
      this.Hide();
    }
  }
}
