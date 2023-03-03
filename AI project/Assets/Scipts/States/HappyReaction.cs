using UnityEngine;

public class HappyReaction : BaseState
{
   
    private MovementSM _sm;
    private float _cooldownTime;


    public HappyReaction(MovementSM stateMachine) : base("HappyReaction", stateMachine)
    {
        _sm = (MovementSM)stateMachine;
    }

    public override void Enter()
    {
        // _TODO_ :
        // set idle appearance : red & clear input
        base.Enter();
        _sm.material.material = _sm.happy;
        _cooldownTime = 2f;
    }

    public override void UpdateLogic()
    {
        // _TODO_ :
        // when to change state ???

        if (_cooldownTime <= 0)
        {
            _sm.pickup.isHappy = false;
            stateMachine.ChangeState(((MovementSM)stateMachine).idleState);
            
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        if(_cooldownTime >= 0)
        {
            _cooldownTime -= Time.deltaTime;
        }
    }

}
