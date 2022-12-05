// Decompiled with JetBrains decompiler
// Type: Space_Forces.v000__video
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
  public class v000__video : Form
  {
    private IContainer components;
    [AccessedThroughProperty("vsf")]
    private AxWindowsMediaPlayer _vsf;
    [AccessedThroughProperty("Timer1")]
    private Timer _Timer1;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;

    [DebuggerNonUserCode]
    public v000__video() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (v000__video));
      this.vsf = new AxWindowsMediaPlayer();
      this.Timer1 = new Timer(this.components);
      this.Button1 = new Button();
      this.vsf.BeginInit();
      this.SuspendLayout();
      this.vsf.Enabled = true;
      AxWindowsMediaPlayer vsf1 = this.vsf;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      vsf1.Location = point2;
      this.vsf.Name = "vsf";
      this.vsf.OcxState = (AxHost.State) componentResourceManager.GetObject("vsf.OcxState");
      AxWindowsMediaPlayer vsf2 = this.vsf;
      Size size1 = new Size(1024, 664);
      Size size2 = size1;
      vsf2.Size = size2;
      this.vsf.TabIndex = 0;
      this.Timer1.Enabled = true;
      this.Timer1.Interval = 69000;
      this.Button1.BackColor = Color.Black;
      this.Button1.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button1.ForeColor = Color.Lime;
      Button button1_1 = this.Button1;
      point1 = new Point(834, 519);
      Point point3 = point1;
      button1_1.Location = point3;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(167, 67);
      Size size3 = size1;
      button1_2.Size = size3;
      this.Button1.TabIndex = 1;
      this.Button1.Text = "Saltar Video";
      this.Button1.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(1024, 600);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.vsf);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (v000__video);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "v000_video";
      this.vsf.EndInit();
      this.ResumeLayout(false);
    }

    internal virtual AxWindowsMediaPlayer vsf
    {
      [DebuggerNonUserCode] get => this._vsf;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._vsf = value;
    }

    internal virtual Timer Timer1
    {
      [DebuggerNonUserCode] get => this._Timer1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Timer1 = value;
    }

    internal virtual Button Button1
    {
      [DebuggerNonUserCode] get => this._Button1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      MyProject.Forms.v00__menu_de_nivel_y_nombre.Show();
      this.vsf.URL = "";
      this.Hide();
    }

    private void v000__video_Load(object sender, EventArgs e) => Variables_Publicas.gda = 0;
  }
}
