//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年07月03日-00:05
//Assembly-CSharp

using System.Collections.Generic;
using UnityEngine;

namespace CabinIcarus.IcED.Events.Core.Utilitys
{
    public static class GameObjectUtility
    {
        
        /// <summary>
        /// 获取物体子孙
        /// </summary>
        /// <param name="self"></param>
        /// <param name="results">填充列表</param>
        public static void GetParents(this GameObject self,List<Transform> results)
        {
            results.Clear();
            
            _getParent(self.transform, results);
        }

        static void _getParent(Transform trans,List<Transform> results)
        {
            if (trans.parent == null || trans.parent == trans.root)
            {
                return;
            }

            var parent = trans.parent;
            
            results.Add(parent);
            
            _getParent(parent,results);
        }
        
        /// <summary>
        /// 获取物体子孙
        /// </summary>
        /// <param name="self"></param>
        /// <param name="results">填充列表</param>
        /// <param name="maxDeep">最大深度,-1为不限</param>
        public static void GetOffspring(this GameObject self,List<Transform> results, int maxDeep = -1)
        {
            results.Clear();
            
            _getChild(self.transform,results,maxDeep);
        }

        static void _getChild(Transform trans,List<Transform> result,int deep)
        {
            if (deep > -1)
            {
                if (deep == 0)
                {
                    return;
                }   
            }

            if (trans.childCount == 0)
            {
                return;
            }
            
            for (var i = 0; i < trans.childCount; i++)
            {
                var child = trans.GetChild(i);
                result.Add(child);

                _getChild(child, result, deep--);
            }
        }
    }
}