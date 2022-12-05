// Decompiled with JetBrains decompiler
// Type: Space_Forces.v00__menu_de_nivel_y_nombre
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
  public class v00__menu_de_nivel_y_nombre : Form
  {
    private IContainer components;
    [AccessedThroughProperty("baceptar")]
    private Button _baceptar;
    [AccessedThroughProperty("lnombre")]
    private Label _lnombre;
    [AccessedThroughProperty("tbnombre")]
    private TextBox _tbnombre;
    [AccessedThroughProperty("bexperto")]
    private Button _bexperto;
    [AccessedThroughProperty("bd")]
    private Button _bd;
    [AccessedThroughProperty("bf")]
    private Button _bf;
    [AccessedThroughProperty("bm")]
    private Button _bm;
    [AccessedThroughProperty("rwm")]
    private AxWindowsMediaPlayer _rwm;

    [DebuggerNonUserCode]
    public v00__menu_de_nivel_y_nombre()
    {
      this.Load += new EventHandler(this.v00__menu_de_nivel_y_nombre_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (v00__menu_de_nivel_y_nombre));
      this.baceptar = new Button();
      this.lnombre = new Label();
      this.tbnombre = new TextBox();
      this.bexperto = new Button();
      this.bd = new Button();
      this.bf = new Button();
      this.bm = new Button();
      this.rwm = new AxWindowsMediaPlayer();
      this.rwm.BeginInit();
      this.SuspendLayout();
      this.baceptar.BackColor = Color.Black;
      this.baceptar.Font = new Font("Starcraft", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.baceptar.ForeColor = Color.Blue;
      Button baceptar1 = this.baceptar;
      Point point1 = new Point(581, 424);
      Point point2 = point1;
      baceptar1.Location = point2;
      this.baceptar.Name = "baceptar";
      Button baceptar2 = this.baceptar;
      Size size1 = new Size(125, 50);
      Size size2 = size1;
      baceptar2.Size = size2;
      this.baceptar.TabIndex = 1;
      this.baceptar.Text = "Aceptar";
      this.baceptar.UseVisualStyleBackColor = false;
      this.lnombre.BackColor = Color.Transparent;
      this.lnombre.Font = new Font("Starcraft", 20.25f);
      this.lnombre.ForeColor = Color.White;
      Label lnombre1 = this.lnombre;
      point1 = new Point(253, 354);
      Point point3 = point1;
      lnombre1.Location = point3;
      this.lnombre.Name = "lnombre";
      Label lnombre2 = this.lnombre;
      size1 = new Size(286, 19);
      Size size3 = size1;
      lnombre2.Size = size3;
      this.lnombre.TabIndex = 12;
      this.lnombre.Text = "Nombre";
      this.tbnombre.Font = new Font("Starcraft", 20.25f);
      TextBox tbnombre1 = this.tbnombre;
      point1 = new Point(257, 384);
      Point point4 = point1;
      tbnombre1.Location = point4;
      this.tbnombre.Name = "tbnombre";
      TextBox tbnombre2 = this.tbnombre;
      size1 = new Size(449, 27);
      Size size4 = size1;
      tbnombre2.Size = size4;
      this.tbnombre.TabIndex = 11;
      this.bexperto.BackColor = Color.Black;
      this.bexperto.Font = new Font("Starcraft", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bexperto.ForeColor = Color.Lime;
      Button bexperto1 = this.bexperto;
      point1 = new Point(401, 523);
      Point point5 = point1;
      bexperto1.Location = point5;
      this.bexperto.Name = "bexperto";
      Button bexperto2 = this.bexperto;
      size1 = new Size(236, 48);
      Size size5 = size1;
      bexperto2.Size = size5;
      this.bexperto.TabIndex = 10;
      this.bexperto.Text = "Experto";
      this.bexperto.UseVisualStyleBackColor = false;
      this.bexperto.Visible = false;
      this.bd.BackColor = Color.Black;
      this.bd.Font = new Font("Starcraft", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bd.ForeColor = Color.Navy;
      Button bd1 = this.bd;
      point1 = new Point(401, 441);
      Point point6 = point1;
      bd1.Location = point6;
      this.bd.Name = "bd";
      Button bd2 = this.bd;
      size1 = new Size(236, 48);
      Size size6 = size1;
      bd2.Size = size6;
      this.bd.TabIndex = 9;
      this.bd.Text = "Dificil";
      this.bd.UseVisualStyleBackColor = false;
      this.bd.Visible = false;
      this.bf.BackColor = Color.Black;
      this.bf.Font = new Font("Starcraft", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bf.ForeColor = Color.RoyalBlue;
      Button bf1 = this.bf;
      point1 = new Point(401, 262);
      Point point7 = point1;
      bf1.Location = point7;
      this.bf.Name = "bf";
      Button bf2 = this.bf;
      size1 = new Size(236, 48);
      Size size7 = size1;
      bf2.Size = size7;
      this.bf.TabIndex = 8;
      this.bf.Text = "Facil";
      this.bf.UseVisualStyleBackColor = false;
      this.bf.Visible = false;
      this.bm.BackColor = Color.Black;
      this.bm.Font = new Font("Starcraft", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bm.ForeColor = Color.Blue;
      Button bm1 = this.bm;
      point1 = new Point(401, 354);
      Point point8 = point1;
      bm1.Location = point8;
      this.bm.Name = "bm";
      Button bm2 = this.bm;
      size1 = new Size(236, 48);
      Size size8 = size1;
      bm2.Size = size8;
      this.bm.TabIndex = 7;
      this.bm.Text = "Medio";
      this.bm.UseVisualStyleBackColor = false;
      this.bm.Visible = false;
      this.rwm.Enabled = true;
      AxWindowsMediaPlayer rwm1 = this.rwm;
      point1 = new Point(489, 274);
      Point point9 = point1;
      rwm1.Location = point9;
      this.rwm.Name = "rwm";
      this.rwm.OcxState = (AxHost.State) componentResourceManager.GetObject("rwm.OcxState");
      AxWindowsMediaPlayer rwm2 = this.rwm;
      size1 = new Size(40, 29);
      Size size9 = size1;
      rwm2.Size = size9;
      this.rwm.TabIndex = 13;
      this.rwm.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      size1 = new Size(1018, 576);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.rwm);
      this.Controls.Add((Control) this.lnombre);
      this.Controls.Add((Control) this.tbnombre);
      this.Controls.Add((Control) this.bexperto);
      this.Controls.Add((Control) this.bd);
      this.Controls.Add((Control) this.bf);
      this.Controls.Add((Control) this.bm);
      this.Controls.Add((Control) this.baceptar);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (v00__menu_de_nivel_y_nombre);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.rwm.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button baceptar
    {
      [DebuggerNonUserCode] get => this._baceptar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.baceptar_Click);
        if (this._baceptar != null)
          this._baceptar.Click -= eventHandler;
        this._baceptar = value;
        if (this._baceptar == null)
          return;
        this._baceptar.Click += eventHandler;
      }
    }

    internal virtual Label lnombre
    {
      [DebuggerNonUserCode] get => this._lnombre;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lnombre = value;
    }

    internal virtual TextBox tbnombre
    {
      [DebuggerNonUserCode] get => this._tbnombre;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.tbnombre_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.tbnombre_KeyPress);
        if (this._tbnombre != null)
        {
          this._tbnombre.TextChanged -= eventHandler;
          this._tbnombre.KeyPress -= pressEventHandler;
        }
        this._tbnombre = value;
        if (this._tbnombre == null)
          return;
        this._tbnombre.TextChanged += eventHandler;
        this._tbnombre.KeyPress += pressEventHandler;
      }
    }

    internal virtual Button bexperto
    {
      [DebuggerNonUserCode] get => this._bexperto;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bexperto_Click);
        if (this._bexperto != null)
          this._bexperto.Click -= eventHandler;
        this._bexperto = value;
        if (this._bexperto == null)
          return;
        this._bexperto.Click += eventHandler;
      }
    }

    internal virtual Button bd
    {
      [DebuggerNonUserCode] get => this._bd;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bd_Click);
        if (this._bd != null)
          this._bd.Click -= eventHandler;
        this._bd = value;
        if (this._bd == null)
          return;
        this._bd.Click += eventHandler;
      }
    }

    internal virtual Button bf
    {
      [DebuggerNonUserCode] get => this._bf;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bf_Click);
        if (this._bf != null)
          this._bf.Click -= eventHandler;
        this._bf = value;
        if (this._bf == null)
          return;
        this._bf.Click += eventHandler;
      }
    }

    internal virtual Button bm
    {
      [DebuggerNonUserCode] get => this._bm;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bm_Click);
        if (this._bm != null)
          this._bm.Click -= eventHandler;
        this._bm = value;
        if (this._bm == null)
          return;
        this._bm.Click += eventHandler;
      }
    }

    internal virtual AxWindowsMediaPlayer rwm
    {
      [DebuggerNonUserCode] get => this._rwm;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rwm = value;
    }

    private void baceptar_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.tbnombre.Text, "", false) == 0)
      {
        Interaction.Beep();
      }
      else
      {
        this.baceptar.Visible = false;
        this.tbnombre.Visible = false;
        this.lnombre.Visible = false;
        this.bf.Visible = true;
        this.bm.Visible = true;
        this.bd.Visible = true;
      }
      this.bm.Focus();
    }

    private void bf_Click(object sender, EventArgs e)
    {
      Variables_Publicas.ndd = 1;
      this.bf.Focus();
      MyProject.Forms.v0__menu_principal.Show();
      this.Hide();
    }

    private void bm_Click(object sender, EventArgs e)
    {
      Variables_Publicas.ndd = 2;
      MyProject.Forms.v0__menu_principal.Show();
      this.Hide();
      this.bm.Focus();
    }

    private void bd_Click(object sender, EventArgs e)
    {
      Variables_Publicas.ndd = 3;
      MyProject.Forms.v0__menu_principal.Show();
      this.Hide();
      this.bd.Focus();
    }

    private void bexperto_Click(object sender, EventArgs e)
    {
      Variables_Publicas.ndd = 4;
      MyProject.Forms.v0__menu_principal.Show();
      this.Hide();
      this.bexperto.Focus();
    }

    private void tbnombre_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Strings.Asc(e.KeyChar) != 13)
        return;
      if (Operators.CompareString(this.tbnombre.Text, "", false) == 0)
      {
        Interaction.Beep();
      }
      else
      {
        this.baceptar.Visible = false;
        this.tbnombre.Visible = false;
        this.lnombre.Visible = false;
        this.bf.Visible = true;
        this.bm.Visible = true;
        this.bd.Visible = true;
        this.baceptar.Focus();
      }
    }

    private void tbnombre_TextChanged(object sender, EventArgs e)
    {
      checked { ++Variables_Publicas.c; }
      Variables_Publicas.nj = this.tbnombre.Text;
      switch (Variables_Publicas.c)
      {
        case 1:
          Variables_Publicas.n1 = this.tbnombre.Text;
          break;
        case 2:
          Variables_Publicas.n2 = this.tbnombre.Text;
          break;
        case 3:
          Variables_Publicas.n3 = this.tbnombre.Text;
          break;
        case 4:
          Variables_Publicas.n4 = this.tbnombre.Text;
          break;
      }
      if (Operators.CompareString(this.tbnombre.Text, "bluedunkelentertainment4321", false) != 0)
        return;
      Variables_Publicas.gda = 10;
    }

    private void v00__menu_de_nivel_y_nombre_Load(object sender, EventArgs e)
    {
      this.tbnombre.Focus();
      if (Variables_Publicas.gda < 6)
        return;
      this.bexperto.Visible = true;
    }
  }
}
