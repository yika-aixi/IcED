//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年07月02日-23:22
//Assembly-CSharp

using System;
using System.Collections.Generic;
using CabinIcarus.IcED.Events.Core;
using CabinIcarus.IcED.Events.Core.Utilitys;
using UnityEngine;
using EventType = CabinIcarus.IcED.Events.Core.EventType;

namespace CabinIcarus.IcED.Events
{
    public static partial class EventManager
    {
        public static class UnityEvent
        {
            public static void Register<TArgs>(GameObject target, string eventName, Action<TArgs> handler)
            {
                TargetEvent.Register(new EventTarget(eventName,target), handler);
            }

            public static void Unregister(string eventName,GameObject target, Delegate handler)
            {
                TargetEvent.Unregister(new EventTarget(eventName,target), handler);
            }
            
            private static void Trigger<TArgs>(EventType eventType, EventTarget target, TArgs args)
            {
                if ((eventType & EventType.Global) == EventType.Global)
                {
                    TargetEvent.Trigger(target.name, args);
                }

                if ((eventType & EventType.Target) == EventType.Target)
                {
                    TargetEvent.Trigger(target, args);
                }

                List<Transform> _objs = new List<Transform>();

                if ((eventType & EventType.TargetAndParent) == EventType.TargetAndParent)
                {
                    ((GameObject) target.target).GetParents(_objs);

                    _trigger(target, args, _objs);
                }

                if ((eventType & EventType.TargetAndOffspring) == EventType.TargetAndOffspring)
                {
                    ((GameObject) target.target).GetOffspring(_objs);
                
                    _trigger(target, args, _objs);
                }
                else if ((eventType & EventType.TargetAndChild) == EventType.TargetAndChild)
                {
                    ((GameObject) target.target).GetOffspring(_objs, 1);

                    _trigger(target, args, _objs);
                }
            }

            private static void _trigger<TArgs>(EventTarget target, TArgs args, List<Transform> trans)
            {
                for (var i = 0; i < trans.Count; i++)
                {
                    TargetEvent.Trigger(target.name, trans[i].gameObject, args);
                }
            }

            public static void Trigger<TArgs>(EventType eventType, string name, GameObject target, TArgs args)
            {
                Trigger(eventType, new EventTarget(name, target), args);
            }

            public static void Trigger(EventType eventType, string name, GameObject target)
            {
                Trigger(eventType, new EventTarget(name, target), new EmptyEventArgs());
            }

            public static void Trigger(EventType eventType, string name)
            {
                Trigger(eventType, new EventTarget(name, null), new EmptyEventArgs());
            }

            public static void Trigger<TArgs>(EventType eventType, string name, TArgs args)
            {
                Trigger(eventType, new EventTarget(name, null), args);
            }
        }
    }
}