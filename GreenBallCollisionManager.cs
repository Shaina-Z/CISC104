using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    
    public GameObject greenBall;
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        // GreenBall Increases in Size
        greenBall.transform.localScale += new Vector3(2f, 2f, 2f);

    }
}
