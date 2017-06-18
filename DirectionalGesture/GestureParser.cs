//using System.Collections;
using System.Collections.Generic;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // (needs NetworkBehaviour)
//using UnityEngine.UI;
using UnityEngine;
using System;

namespace DirectionalGesture
{
    /// <summary>
    /// 操作の組み合わせから、どんなジェスチャーが行われたのか分析するクラス。
    /// </summary>
    public class GestureParser
    {

        public GestureParser()
        {
        }

        /// <summary>
        /// 動作のリストからジェスチャーを分析。
        /// </summary>
        /// <param name="directions"></param>
        public void Parse(List<Direction> directions)
        {
            // デバッグ中
            string s = "";

            foreach(Direction element in directions)
            {
                s += element.ToString();
            }


            Debug.Log(s);
        }
    }
}