using UnityEngine;

public class Idle : BaseState
{
    // Input to specify horizontal distance
    // - moves left
    // 0 idles
    // + moves right
    private MovementSM _sm;
    private float _horizontalInput;
    private float _verticalInput;

    public Idle (MovementSM stateMachine) : base("Idle", stateMachine) {
        _sm = (MovementSM)stateMachine;
    }

    public override void Enter()
    {
        // _TODO_ :
        // set idle appearance : black & clear input
        base.Enter();
        _sm.material.material = _sm.color;
        ((MovementSM)stateMachine).color.color = Color.blue;
        //((MovementSM)stateMachine).spriteRenderer.color = Color.black;
        _horizontalInput = 0f;
    }

    public override void UpdateLogic()
    {
        // _TODO_ :
        // when to change state ???
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        if (Mathf.Abs(_horizontalInput) > Mathf.Epsilon || Mathf.Abs(_verticalInput) > Mathf.Epsilon)
        {
            stateMachine.ChangeState(((MovementSM)stateMachine).movingState);
        }
        else if (_sm.pickup.isHappy)
        {
            stateMachine.ChangeState(((MovementSM)stateMachine).happyState);
        }
    }

}
