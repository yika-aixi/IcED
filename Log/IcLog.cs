//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年05月28日-21:08
//Icarus.EditorFrame

using System;

namespace CabinIcarus.EditorFrame.Log
{
    public static partial class IcLog
    {
        private static IIcLog _icLogInstance;

        public static IIcLog _IcLogInstance => _icLogInstance;
        
        /// <summary>
        /// 设置log对象
        /// </summary>
        /// <param name="editorFrameLog"></param>
        public static void SetEditorFrameLog(IIcLog icLog)
        {
            _icLogInstance = icLog;
        }

        /// <summary>
        /// 普通log
        /// </summary>
        /// <param name="message"></param>
        public static void Log(object message)
        {
            _IcLogInstance.Log(message);
        }
    
        /// <summary>
        /// 警告log
        /// </summary>
        /// <param name="message"></param>
        public static void Warning(object message)
        {
            _IcLogInstance.Warning(message);
        }

        /// <summary>
        /// 错误log
        /// </summary>
        /// <param name="message"></param>
        public static void Error(object message)
        {
            _IcLogInstance.Error(message);
        }

        /// <summary>
        /// 异常log
        /// </summary>
        /// <param name="exception"></param>
        public static void Exception(Exception exception)
        {
            _IcLogInstance.Exception(exception);
        }
    }
}