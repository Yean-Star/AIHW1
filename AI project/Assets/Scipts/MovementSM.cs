using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSM : StateMachine
{
    [Header("RigidBody Speed")]
    public float speed = 4f;
    public float jumpHeight = 5f; 
    public Rigidbody rigidbody;
    //public SpriteRenderer spriteRenderer;
    [Header("Setting Material")]
    public Material color;
    public Material happy;
    public Renderer material;

    public PlayerPickup pickup;

    [HideInInspector]
    public Idle idleState;
    [HideInInspector]
    public Moving movingState;
    [HideInInspector]
    public HappyReaction happyState;

    private void Awake()
    {
        // _TODO_ :
        // create states
        idleState = new Idle(this);
        movingState = new Moving(this);
        happyState = new HappyReaction(this);
    }

    protected override BaseState GetInitialState()
    {
        return idleState;
    }
}
