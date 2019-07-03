//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年07月03日-18:14
//Assembly-CSharp

using UnityEngine;

namespace CabinIcarus.IcED.Events.Core
{
    public class RegisterEventTest : MonoBehaviour
    {
        public string EventName = "test";
        void Start()
        {
            EventManager.UnityEvent.Register<GameObject>(gameObject,EventName,_testAction);
        }
        
        private void _testAction(GameObject obj)
        {
            Debug.LogError($"Trigger:{obj.gameObject} Click Log locate Handle Object",gameObject);
        }
    }
}