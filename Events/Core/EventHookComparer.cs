//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年07月02日-21:46
//Assembly-CSharp

using System.Collections.Generic;

namespace CabinIcarus.IcED.Events.Core
{
    public class EventHookComparer : IEqualityComparer<EventTarget>
    {
        public bool Equals(EventTarget x, EventTarget y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(EventTarget obj)
        {
            return obj.GetHashCode();
        }
    }
}