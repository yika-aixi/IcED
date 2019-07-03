//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年07月02日-21:27
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CabinIcarus.EditorFrame.Log;
using CabinIcarus.IcED.Events.Core;

namespace CabinIcarus.IcED.Events
{
    public static partial class EventManager
    {
        public static class TargetEvent
        {
            static TargetEvent()
            {
                events = new Dictionary<EventTarget, HashSet<Delegate>>(new EventTargetComparer());
            }

            private static readonly Dictionary<EventTarget, HashSet<Delegate>> events;

            public static void Register<TArgs>(EventTarget target, Action<TArgs> handler)
            {
                if (!events.TryGetValue(target, out var handlers))
                {
                    handlers = new HashSet<Delegate>();
                    events.Add(target, handlers);
                }

                handlers.Add(handler);
            }

            public static void Unregister(EventTarget target, Delegate handler)
            {
                if (events.TryGetValue(target, out var handlers))
                {
                    handlers.Remove(handler);
                }
            }

            public static void Trigger<TArgs>(EventTarget target, TArgs args)
            {
                HashSet<Action<TArgs>> handlers = null;

                if (events.TryGetValue(target, out var potentialHandlers))
                {
                    foreach (var potentialHandler in potentialHandlers)
                    {
                        if (potentialHandler is Action<TArgs> handler)
                        {
                            if (handlers == null)
                            {
                                handlers = HashSetPool<Action<TArgs>>.New();
                            }

                            handlers.Add(handler);
                        }
                    }
                }
            
                if (handlers == null || handlers.Count == 0)
                {
                    if (OpenWarning)
                    {
                        if (target.target == null)
                        {
                            IcLog.Warning($"Global Event: {target.name} No Any Handle.");
                        }
                        else
                        {
                            IcLog.Warning($"{target.name}---:---{target.target} No Any Handle.");
                        }
                        
                        return;
                    }
                }

                if (handlers != null)
                {
                    foreach (var handler in handlers)
                    {
                        handler.Invoke(args);
                    }

                    handlers.Free();
                }
            }

            public static void Trigger<TArgs>(string name, object target, TArgs args)
            {
                Trigger(new EventTarget(name, target), args);
            }

            public static void Trigger(EventTarget target)
            {
                Trigger(target, new EmptyEventArgs());
            }

            public static void Trigger(string name, object target)
            {
                Trigger(new EventTarget(name, target));
            }
            
            public static void Trigger(string name)
            {
                Trigger(new EventTarget(name, null),new EmptyEventArgs());
            }
            
            public static void Trigger<TArgs>(string name, TArgs args)
            {
                Trigger(new EventTarget(name, null), args);
            }
        }
    }
}