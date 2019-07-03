//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年05月28日-21:19
//Icarus.EditorFrame

using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CabinIcarus.EditorFrame.Log
{
   public partial class IcLog
   {
         public static void Log(object message,Object context)
         {
            Debug.Log(message,context);
         }
         
         public static void Warning(object message,Object context)
         {
             Debug.LogWarning(message,context);
         }
         
         public static void Error(object message,Object context)
         {
             Debug.LogError(message,context);
         }
         
         public static void Exception(Exception exception,Object context)
         {
             Debug.LogException(exception,context);
         }
   }
}