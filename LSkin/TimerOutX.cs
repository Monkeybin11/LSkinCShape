using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// 倒计时类
/// </summary>
public static class TimerOutX
{
    public delegate void ActionSleep(Control control, int time, CallBackTag d, object Tag);
    public delegate void CallBackTag(object Tag);

    public static void Start(Control control, int time, CallBackTag callBack, object Tag)
    {
        ActionSleep sleep = sleepFunction;

        sleep.BeginInvoke(control, time, callBack, Tag, null, null);
    }

    private static void sleepFunction(Control control, int time, CallBackTag d, object Tag)
    {

        System.Threading.Thread.Sleep(time);

        if (d != null && !control.IsDisposed)
        {

            try
            {
                control.Invoke(d, Tag);
            }
            catch (Exception)
            {

            }

        }
    }
}
