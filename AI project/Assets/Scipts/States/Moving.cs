using UnityEngine;

public class Moving : BaseState
{
    private float _horizontalInput;
    private float _verticalInput;
    private MovementSM _sm;

    public Moving(MovementSM stateMachine) : base("Moving", stateMachine) 
    {
	    _sm = (MovementSM)stateMachine;
    }

    public override void Enter()
    {
        // _TODO_ :
        // set idle appearance : red & clear input
        base.Enter();
        _sm.material.material = _sm.color;
        ((MovementSM)stateMachine).color.color = Color.red;
        _horizontalInput = 0f;
        _verticalInput = 0f;
    }

    public override void UpdateLogic()
    {
        // _TODO_ :
        // when to change state ???
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        if (Mathf.Abs(_horizontalInput) < Mathf.Epsilon && Mathf.Abs(_verticalInput) < Mathf.Epsilon)
        {
            stateMachine.ChangeState(((MovementSM)stateMachine).idleState);
        }
        else if (_sm.pickup.isHappy)
        {
            stateMachine.ChangeState(((MovementSM)stateMachine).happyState);
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        var dir = new Vector3(_horizontalInput, 0, _verticalInput);
        _sm.rigidbody.velocity = dir * ((MovementSM)stateMachine).speed;
       // Vector2 vel = _sm.rigidbody.velocity;
       // vel.x = _horizontalInput * ((MovementSM)stateMachine).speed;
       //_sm.rigidbody.velocity = vel;
    }

}
