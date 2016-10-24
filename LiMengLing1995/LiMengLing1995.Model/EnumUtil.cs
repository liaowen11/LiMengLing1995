using System;
using System.Collections.Generic;
using LiMengLing1995.Model;

namespace LiMengLing1995.Model
{
    /// <summary>
    /// 枚举扩展类
    /// </summary>
    public class EnumUtil
    {
        private static Dictionary<string, Dictionary<int, string>> _EnumList = new Dictionary<string, Dictionary<int, string>>(); //枚举缓存池

        /// <summary>
        /// 将枚举转换成Dictionary&lt;int, string&gt;
        /// Dictionary中，key为枚举项对应的int值；value为：若定义了EnumShowName属性，则取它，否则取name
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <returns></returns>
        public static Dictionary<int, string> EnumToDictionary(Type enumType)
        {
            string keyName = enumType.FullName;

            if (!_EnumList.ContainsKey(keyName))
            {
                Dictionary<int, string> list = new Dictionary<int, string>();

                foreach (int i in Enum.GetValues(enumType))
                {
                    string name = Enum.GetName(enumType, i);

                    //取显示名称
                    string showName = string.Empty;
                    object[] atts = enumType.GetField(name).GetCustomAttributes(typeof(EnumShowNameAttribute), false);
                    if (atts.Length > 0) showName = ((EnumShowNameAttribute)atts[0]).ShowName;

                    list.Add(i, string.IsNullOrEmpty(showName) ? name : showName);
                }

                object syncObj = new object();

                if (!_EnumList.ContainsKey(keyName))
                {
                    lock (syncObj)
                    {
                        if (!_EnumList.ContainsKey(keyName))
                        {
                            _EnumList.Add(keyName, list);
                        }
                    }
                }
            }

            return _EnumList[keyName];
        }


        /// <summary>
        /// 获取枚举值对应的显示名称
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="intValue">枚举项对应的int值</param>
        /// <returns></returns>
        public static string GetEnumShowName(Type enumType, int intValue)
        {
            return EnumToDictionary(enumType)[intValue];
        }
    }
}
