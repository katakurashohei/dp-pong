using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * tracks position of the ball, moves back to central position after hitting the ball.
 */

public class GreedyAI : MonoBehaviour
{
    public float speed = 2f;

    private Rigidbody rb;
    private Vector3 direction;
    private GameObject ball;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        direction = Vector3.right;
        ball = GameObject.Find("Ball");
    }

    void FixedUpdate() {
        Vector3 ballDirection = ball.GetComponent<Ball>().GetDirection();
        /* TODO 1.1: Uncomment below */

        // if (IsBallHeadingTowardsMe()) {
        //     MoveTowardsBall();
        // }
        // else {
        //     MoveTowardsCenter();
        // }

        rb.velocity = direction.normalized * 100 * (speed * Time.fixedDeltaTime);
    }

    bool IsBallHeadingTowardsMe() {
        Vector3 ballDirection = ball.GetComponent<Ball>().GetDirection();
        return ballDirection.z > 0;
    }

    void MoveTowardsBall() {
        /* TODO 1.2: Move the enemy AI towards the ball by setting the direction vector. 
            Use Vector3.right and Vector3.left as aliases for Vector3(1, 0, 0) and Vector3(-1, 0, 0) respectively.
        */

        //direction = ball.transform.position.x ? transform.position.x 
        //    ? Vector3.???
        //    : Vector3.???
    }

    void MoveTowardsCenter() {
        /* TODO 1.3: Move the enemy AI back to the center of the screen by setting the direction vector.
            Set the direction according to the x position of the enemy AI.

            HINT: Look above for how to read the position.
        */

        //if (0.2f < ???.x)
        //    direction = Vector3.???;
        //else if (???.x < -0.2f)
        //    direction = Vector3.???;
        //else
        //    direction = Vector3.zero; // do not move if already in center
    }
}
