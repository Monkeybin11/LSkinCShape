using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public static class StringTool
    {
        /// <summary>
        /// 字符串转16进制
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string StringToHexText(string input)
        {
            input = input.Replace(" ", "");
            string str = "";
            char[] values = input.ToCharArray();
            foreach (char letter in values)
            {
                int value = Convert.ToInt32(letter);
                string hexOutput = String.Format("{0:X}", value);
                str += hexOutput;
            }
            return str;
        }

        /// <summary>
        /// 字符串转16进制字节数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] HexTextToByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }
        /// <summary>
        /// 返回字符个数
        /// </summary>
        /// <param name="str"></param>
        /// <param name="char"></param>
        /// <returns></returns>
        public static int SubstringCount(string str, string @char)
        {
            if (str.Contains(@char))
            {
                string strReplaced = str.Replace(@char, "");
                return (str.Length - strReplaced.Length) / @char.Length;
            }

            return 0;
        }
    }
