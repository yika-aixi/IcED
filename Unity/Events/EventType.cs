//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年07月02日-22:12
//Assembly-CSharp

using System;

namespace CabinIcarus.IcED.Events.Core
{
    [Flags]
    public enum EventType
    {
        /// <summary>
        /// 全局
        /// </summary>
        Global = 1,
        
        /// <summary>
        /// 目标
        /// </summary>
        Target = 2,
        
        /// <summary>
        /// 目标及父物体事件
        /// </summary>
        TargetAndParent = 4,
        
        /// <summary>
        /// 目标及孩子不含子孙事件
        /// </summary>
        TargetAndChild = 8,
        
        /// <summary>
        /// 目标及子孙事件
        /// </summary>
        TargetAndOffspring = 16,
        
        /// <summary>
        /// 所有事件
        /// </summary>
        All = Global | Target | TargetAndChild | TargetAndOffspring | TargetAndParent,

        /// <summary>
        /// 目标所有事件
        /// </summary>
        TargetAll = Target | TargetAndChild | TargetAndOffspring | TargetAndParent,
    }
}