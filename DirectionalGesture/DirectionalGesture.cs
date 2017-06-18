//using System.Collections;
using System.Collections.Generic;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // (needs NetworkBehaviour)
//using UnityEngine.UI;
using UnityEngine;
using Labo;

namespace DirectionalGesture
{
    /// <summary>
    /// 入力された方向をもとにジェスチャーを検知する。
    /// </summary>
    public class DirectionalGesture : MonoBehaviour
    {
        private GestureObserver observer;
        private GestureParser parser;


        private void Start()
        {
            observer = new GestureObserver(GetComponent<IIntegratedInput>());
            parser = new GestureParser();
        }


        private void Update()
        {
            observer.Detect();
            parser.Parse(observer.DetectedGestures);
        }
    }
}