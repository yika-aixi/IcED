//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年05月28日-21:04
//Icarus.EditorFrame

using System;

namespace CabinIcarus.EditorFrame.Log
{
    public interface IIcLog
    {
        void Log(object message);
        
        void Warning(object message);
        
        void Error(object message);

        void Exception(Exception exception);
    }
}