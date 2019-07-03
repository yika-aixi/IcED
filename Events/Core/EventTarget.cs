//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年07月02日-21:30
//

using Cabin_Icarus.IcED.Utilitys;

namespace CabinIcarus.IcED.Events.Core
{
    public struct EventTarget
    {
        public readonly string name;

        public readonly object target;
        public EventTarget(string name, object target = null)
        {
            AssertionUtility.IsNotNull(nameof(name),name,string.Empty);

            this.name = name;
            this.target = target;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is EventTarget other))
            {
                return false;
            }

            return Equals(other);
        }

        public bool Equals(EventTarget other)
        {
            return name == other.name && Equals(target, other.target);
        }

        public override int GetHashCode()
        {
            return HashUtility.GetHashCode(name, target);
        }
		
        public static bool operator ==(EventTarget a, EventTarget b)
        {
            return a.Equals(b);
        }
		
        public static bool operator !=(EventTarget a, EventTarget b)
        {
            return !(a == b);
        }

        public static implicit operator EventTarget(string name)
        {
            return new EventTarget(name);
        }
    }
}