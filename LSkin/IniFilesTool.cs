using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using LSkin;
using System.Reflection;
using System.Drawing;

public static class IniFunction
{

    //声明API函数
    [DllImport("kernel32")]
    public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
    [DllImport("kernel32")]
    public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
    [DllImport("kernel32", EntryPoint = "GetPrivateProfileString")]
    public static extern uint GetPrivateProfileStringA(string section, string key,
          string def, Byte[] retVal, int size, string filePath);

}


public class IniFiles
{
    /// <summary>
    /// ini文件路径
    /// </summary>
    public string inipath = null;
    /// <summary> 
    /// 构造方法  INIPath一定要绝对路径
    /// </summary> 
    /// <param name="INIPath">文件路径</param> 
    public IniFiles(string INIPath)
    {
        if (DebugTool.IsDesignMode) return;
        if (!File.Exists(INIPath)) File.CreateText(INIPath);
        inipath = INIPath;

    }
    public IniFiles() { }
    /// <summary> 
    /// 写入INI文件 
    /// </summary> 
    /// <param name="Section">项目名称(如 [TypeName] )</param> 
    /// <param name="Key">键</param> 
    /// <param name="Value">值</param> 
    public void WriteValue(object Section, object Key, object Value)
    {
        IniFunction.WritePrivateProfileString(Section.ToString(), Key.ToString(), Value.ToString(), inipath);
    }
    /// <summary> 
    /// 读出INI文件 
    /// </summary> 
    /// <param name="Section">项目名称(如 [TypeName] )</param> 
    /// <param name="Key">键</param> 
    public string ReadValue(object Section, object Key)
    {
        StringBuilder temp = new StringBuilder(500);
        int i = IniFunction.GetPrivateProfileString(Section.ToString(), Key.ToString(), "", temp, 500, inipath);
        return temp.ToString();


    }


    /// <summary>
    /// ini文件读写 一气呵成
    /// </summary>
    /// <param name="session"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public object this[object session, object key]
    {
        get
        {
            return ReadValue(session, key);
        }
        set
        {
            WriteValue(session, key, value);
        }
    }


    public List<MemberInfo> GetClassProperties<T>(T model)
    {
        Type t = model.GetType();
        List<MemberInfo> list = new List<MemberInfo>();
        foreach (FieldInfo item in t.GetFields())
        {
            list.Add(item);
        }
        foreach (PropertyInfo item in t.GetProperties())
        {
            list.Add(item);
        }
        return list;
    }
    public void SetClassProperties<T>(T model)
    {

    }

    /// <summary>
    /// 将一个对象写入配置文件，支持常用数据类型 和Color 反射
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="model"></param>
    /// <param name="sessionName"></param>
    /// 
    public void WriteObj<T>(T model, string sessionName)
    {
        string className = model.GetType().Name;
        List<MemberInfo> list = GetClassProperties(model);
        foreach (var item in list)
        {
            //if (!IsConstType(item.GetType()))
            //{
            //    continue;
            //}

            string name = item.Name;

            if (GetValue(model, item) == null) {
                continue;
            }

            string value = GetValue(model, item).ToString();
            if (sessionName != null)
            {
                WriteValue(sessionName, name, value);
            }
            else
            {
                WriteValue(className, name, value);
            }
        }
    }

    public bool IsConstType(Type type)
    {
        Console.WriteLine(type);
        if (typeof(String) == type)
        {
            return true;
        }
        if (typeof(Int32) == type)
        {
            return true;
        }
        if (typeof(float) == type)
        {
            return true;
        }
        if (typeof(Double) == type)
        {
            return true;
        }
        if (typeof(Decimal) == type)
        {
            return true;
        }
        if (typeof(Boolean) == type)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// 将一个对象写入配置文件 ，支持常用数据类型 和Color类 反射
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="model"></param>
    public void WriteObj<T>(T model)
    {
        WriteObj(model, null);
    }

    /// <summary>
    /// 从配置文件获得一个对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public object GetObj<T>(T model)
    {
        return GetObj(model, null);
    }
    /// <summary>
    /// 从配置文件获得一个对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="model"></param>
    /// <param name="sessionName"></param>
    /// <returns></returns>
    public object GetObj<T>(T model, string sessionName)
    {
        string className = model.GetType().Name;
        List<MemberInfo> list = GetClassProperties(model);
        List<string> sessionS = ReadSections();

        foreach (var item in list)
        {
            string value = "";
            if (sessionName != null)
            {
                value = ReadValue(sessionName, item.Name);
            }
            else
            {
                value = ReadValue(className, item.Name);
            }
            Type type = null;

            FieldInfo it = item as FieldInfo;
            if (it != null) type = it.FieldType;

            PropertyInfo it2 = item as PropertyInfo;
            if (it2 != null) type = it2.PropertyType;

            if (typeof(Color) == type)
            {
                string[] argbs = value.Split(',');
                int a = 0, r = 0, g = 0, b = 0;
                if (argbs.Length == 4)
                { //支持透明色
                    a = int.Parse(argbs[0]);
                    r = int.Parse(argbs[1]);
                    g = int.Parse(argbs[2]);
                    b = int.Parse(argbs[3]);
                }
                Color val = Color.FromArgb(a, r, g, b);
                SetValue(model, item, val);
            }

            try
            {
                if (typeof(String) == type)
                {
                    SetValue(model, item, value);
                }
                if (typeof(Int32) == type)
                {
                    SetValue(model, item, int.Parse(value));
                }
                if (typeof(float) == type)
                {
                    SetValue(model, item, float.Parse(value));
                }
                if (typeof(Double) == type)
                {
                    SetValue(model, item, double.Parse(value));
                }
                if (typeof(Decimal) == type)
                {
                    SetValue(model, item, decimal.Parse(value));
                }

                if (typeof(Boolean) == type)
                {

                    SetValue(model, item, bool.Parse(value));

                }
            }
            catch (Exception)
            {

                continue;
            }


        }
        return model;
    }

    void SetValue<T>(T model, MemberInfo mb, object value)
    {

        PropertyInfo it = mb as PropertyInfo;
        if (it != null) it.SetValue(model, value, null);
        FieldInfo it2 = mb as FieldInfo;
        if (it2 != null) it2.SetValue(model, value);

    }

    object GetValue<T>(T model, MemberInfo mb)
    {
        object value = null;

        bool ok = true;
        PropertyInfo it = mb as PropertyInfo;
        if (it != null) {
            value = it.GetValue(model, null);
            ok = IsConstType(it.PropertyType);
        }

        FieldInfo it2 = mb as FieldInfo;
        if (it2 != null) {
            value = it2.GetValue(model);
            ok = IsConstType(it2.FieldType);
        }

        if (null == value) {
            return null;
        }

        if (value.GetType() == typeof(Color))
        {
            return ConvertColor((Color)value);
        }

        if (!ok) return null;

        if (value == null) return "";

        return value.ToString();
    }

    private string ConvertColor(Color color)
    {

        int a = color.A;
        int r = color.R;
        int g = color.G;
        int b = color.B;



        return a + "," + r + "," + g + "," + b;

    }
    //public string getSession {

    //    return "";
    //}

    /// <summary> 
    /// 验证文件是否存在 
    /// </summary> 
    /// <returns>布尔值</returns> 
    public bool ExistINIFile()
    {
        return File.Exists(inipath);
    }
    public List<string> ReadSections()
    {
        return ReadSections(inipath);
    }
    public static void CreateIniFile(string fileName)
    {
        if (DebugTool.IsDesignMode) return;

        fileName = fileName.Replace(@"\", "/");
        string fileDir = fileName.Substring(0, fileName.LastIndexOf('/') + 1);
        string iniName = fileName.Substring(fileName.LastIndexOf('/') + 1, fileName.Length - fileName.LastIndexOf('/') - 1);
        Directory.CreateDirectory(fileDir);
        File.CreateText(fileDir + iniName).Close(); //创建文件并且释放
    }

    public List<string> ReadSections(string iniFilename)
    {
        List<string> result = new List<string>();
        Byte[] buf = new Byte[65536];
        uint len = IniFunction.GetPrivateProfileStringA(null, null, null, buf, buf.Length, iniFilename);
        int j = 0;
        for (int i = 0; i < len; i++)
            if (buf[i] == 0)
            {
                result.Add(Encoding.Default.GetString(buf, j, i - j));
                j = i + 1;
            }
        return result;
    }

}
