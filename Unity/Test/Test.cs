//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年07月02日-21:51
//

using System.Diagnostics;
using CabinIcarus.EditorFrame.Log;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
using Debug = UnityEngine.Debug;

namespace CabinIcarus.IcED.Events.Core
{
    public class Test : MonoBehaviour
    {
        public string EventName;
        public EventType EventType = EventType.All;
        
        [ContextMenu("tr")]
        void TrU()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Profiler.BeginSample("Event ---");
            EventManager.UnityEvent.Trigger(EventType,EventName,gameObject,gameObject);
            Profiler.EndSample();
            stopwatch.Stop();
            
            IcLog.Error(stopwatch.Elapsed);
        }
    }
}