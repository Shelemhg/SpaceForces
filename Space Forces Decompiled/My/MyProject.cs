// Decompiled with JetBrains decompiler
// Type: Space_Forces.My.MyProject
// Assembly: Space Forces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F1F84538-E895-48C3-8596-7C330F22B69D
// Assembly location: C:\Users\Yarko\AppData\Local\Apps\2.0\LAZGQ9DQ.MM4\33WNND2T.LTO\spac..tion_55dd54f316dd7825_0001.0000_d2c45c90b68e6c08\Space Forces.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Space_Forces.My
{
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  [HideModuleName]
  [StandardModule]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [DebuggerNonUserCode]
    static MyProject()
    {
    }

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    internal sealed class MyForms
    {
      public v000__video m_v000__video;
      public v00__menu_de_nivel_y_nombre m_v00__menu_de_nivel_y_nombre;
      public v0__menu_principal m_v0__menu_principal;
      public v1__nivel1 m_v1__nivel1;
      public v2__nivel2 m_v2__nivel2;
      public v3__nivel3 m_v3__nivel3;
      public vc__ventanadecreditos m_vc__ventanadecreditos;
      public vp__ventanapuntaje m_vp__ventanapuntaje;
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;

      public v000__video v000__video
      {
        [DebuggerNonUserCode] get
        {
          this.m_v000__video = MyProject.MyForms.Create__Instance__<v000__video>(this.m_v000__video);
          return this.m_v000__video;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_v000__video)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<v000__video>(ref this.m_v000__video);
        }
      }

      public v00__menu_de_nivel_y_nombre v00__menu_de_nivel_y_nombre
      {
        [DebuggerNonUserCode] get
        {
          this.m_v00__menu_de_nivel_y_nombre = MyProject.MyForms.Create__Instance__<v00__menu_de_nivel_y_nombre>(this.m_v00__menu_de_nivel_y_nombre);
          return this.m_v00__menu_de_nivel_y_nombre;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_v00__menu_de_nivel_y_nombre)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<v00__menu_de_nivel_y_nombre>(ref this.m_v00__menu_de_nivel_y_nombre);
        }
      }

      public v0__menu_principal v0__menu_principal
      {
        [DebuggerNonUserCode] get
        {
          this.m_v0__menu_principal = MyProject.MyForms.Create__Instance__<v0__menu_principal>(this.m_v0__menu_principal);
          return this.m_v0__menu_principal;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_v0__menu_principal)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<v0__menu_principal>(ref this.m_v0__menu_principal);
        }
      }

      public v1__nivel1 v1__nivel1
      {
        [DebuggerNonUserCode] get
        {
          this.m_v1__nivel1 = MyProject.MyForms.Create__Instance__<v1__nivel1>(this.m_v1__nivel1);
          return this.m_v1__nivel1;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_v1__nivel1)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<v1__nivel1>(ref this.m_v1__nivel1);
        }
      }

      public v2__nivel2 v2__nivel2
      {
        [DebuggerNonUserCode] get
        {
          this.m_v2__nivel2 = MyProject.MyForms.Create__Instance__<v2__nivel2>(this.m_v2__nivel2);
          return this.m_v2__nivel2;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_v2__nivel2)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<v2__nivel2>(ref this.m_v2__nivel2);
        }
      }

      public v3__nivel3 v3__nivel3
      {
        [DebuggerNonUserCode] get
        {
          this.m_v3__nivel3 = MyProject.MyForms.Create__Instance__<v3__nivel3>(this.m_v3__nivel3);
          return this.m_v3__nivel3;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_v3__nivel3)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<v3__nivel3>(ref this.m_v3__nivel3);
        }
      }

      public vc__ventanadecreditos vc__ventanadecreditos
      {
        [DebuggerNonUserCode] get
        {
          this.m_vc__ventanadecreditos = MyProject.MyForms.Create__Instance__<vc__ventanadecreditos>(this.m_vc__ventanadecreditos);
          return this.m_vc__ventanadecreditos;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_vc__ventanadecreditos)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<vc__ventanadecreditos>(ref this.m_vc__ventanadecreditos);
        }
      }

      public vp__ventanapuntaje vp__ventanapuntaje
      {
        [DebuggerNonUserCode] get
        {
          this.m_vp__ventanapuntaje = MyProject.MyForms.Create__Instance__<vp__ventanapuntaje>(this.m_vp__ventanapuntaje);
          return this.m_vp__ventanapuntaje;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_vp__ventanapuntaje)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<vp__ventanapuntaje>(ref this.m_vp__ventanapuntaje);
        }
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        if ((object) Instance != null && !Instance.IsDisposed)
          return Instance;
        if (MyProject.MyForms.m_FormBeingCreated != null)
        {
          if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
        }
        else
          MyProject.MyForms.m_FormBeingCreated = new Hashtable();
        MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
        try
        {
          return new T();
        }
        catch (TargetInvocationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          if (ex.InnerException != null)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
        }
        finally
        {
          MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
        }
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyForms()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => base.GetHashCode();

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType() => typeof (MyProject.MyForms);

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString() => base.ToString();
    }

    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyWebServices
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => base.GetHashCode();

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType() => typeof (MyProject.MyWebServices);

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override string ToString() => base.ToString();

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new() => (object) instance == null ? new T() : instance;

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public MyWebServices()
      {
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [ComVisible(false)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
