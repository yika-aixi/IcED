//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年07月02日-21:38
//Assembly-CSharp

using System;

namespace Cabin_Icarus.IcED.Utilitys
{
    public static class AssertionUtility
    {
        /// <summary>
        /// 是否断言
        /// </summary>
        public static bool IsAssert = true;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramName">参数名</param>
        /// <param name="value">对象值</param>
        /// <param name="extraMessage">附加消息</param>
        public static void IsNotNull(string paramName, object value, string extraMessage)
        {
            if (!IsAssert)
            {
                return;
            }

            if (value != null)
            {
                return;
            }
            
            throw new ArgumentNullException(extraMessage,paramName);
        }
    }
}