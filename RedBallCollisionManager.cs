using System;
using System.Numerics;
using UnityEngine;


public class RedBallCollisionManager : BallCollisionManager
{
    
    public GameObject redBall;
    
    public override void CollideWithBall(GameObject OtherBall)
    {
       
        Debug.Log("Red Ball Collision Manager Function");
        // Red Ball turns Magenta
        var redBallRenderer = redBall.GetComponent<Renderer>();
        
        redBallRenderer.material.SetColor("_Color", Color.magenta);
    }
}

