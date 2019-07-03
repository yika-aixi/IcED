//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年05月28日-21:12
//Icarus.EditorFrame

using System;
using UnityEngine;

namespace CabinIcarus.EditorFrame.Log
{
    public class IcUnityDebugLog:IIcLog
    {
        [RuntimeInitializeOnLoadMethod]
        static void _setLog()
        {
            _checkoutLog();
        }

        private static void _checkoutLog()
        {
            if (IcLog._IcLogInstance == null)
            {
                IcLog.SetEditorFrameLog(new IcUnityDebugLog());
            }
        }

        public void Log(object message)
        {
            Debug.Log(message);
        }

        public void Warning(object message)
        {
            Debug.LogWarning(message);
        }

        public void Error(object message)
        {
            Debug.LogError(message);
        }

        public void Exception(Exception exception)
        {
            Debug.LogException(exception);
        }
    }
}