//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // (needs NetworkBehaviour)
//using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
using UnityEngine;
using System;
using Labo;


namespace DirectionalGesture
{

    public enum Direction { Up, Down, Right, Left, None }


    public class GestureObserver 
    {
        private IIntegratedInput input;
        public float GestureThreshold { get; private set; }
        public List<Direction> DetectedGestures { get; private set; }


        public GestureObserver(IIntegratedInput _input)
        {
            // 未定
            this.input = _input;
            GestureThreshold = 0.40f;
            DetectedGestures = new List<Direction>();
        }


        public void Detect()
        {
            // None がそのままスルーされると問題になる可能性あり
            Direction direction = Direction.None;

            // しきい値よりも右方向に大きく移動した場合
            if (input.RightStick.x > GestureThreshold) { direction = Direction.Right; }

            // しきい値よりも左方向に大きく移動した場合
            if (input.RightStick.x < -GestureThreshold) { direction = Direction.Left; }

            // しきい値よりも上方向に大きく移動した場合
            if (input.RightStick.y > GestureThreshold) { direction = Direction.Up; }

            // しきい値よりも下方向に大きく移動した場合
            if (input.RightStick.y < -GestureThreshold) { direction = Direction.Down; }

            //Debug.Log(direction);

            // どの動作にも当てはまらなかった場合。
            if (direction == Direction.None)
            {
                //DetectedGestures.Clear();
                return;
            }

            // 前回検知したものと同一方向の場合、リストへの追加は行わない。
            if (SameAsLast(direction)) { return; }

            // 検知した動作をリストへ追加。
            DetectedGestures.Add(direction);
        }



        // 関数にしたほうが見栄えがよくなるかと思ったがいまいち。ボツかも。
        private bool SameAsLast(Direction currentGesture)
        {
            if (DetectedGestures.Count < 1) { return false; }

            Direction lastGesture = DetectedGestures[DetectedGestures.Count - 1];
            if (lastGesture == currentGesture) { return true; }
            return false;
        }
    }
}