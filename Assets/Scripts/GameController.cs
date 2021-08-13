using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    /// <summary>
    /// ステートマシン
    /// </summary>
    private IceMilkTea.Core.ImtStateMachine<GameController> _stateMachine;


    /// <summary>
    /// 
    /// </summary>
    private enum StateEventId : int
    {
        Idle,
        Damage,
        Knockout,
        Max
    }

    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        _stateMachine = new IceMilkTea.Core.ImtStateMachine<GameController>(this);
        _stateMachine.AddAnyTransition<IdleState>((int)StateEventId.Idle);
        _stateMachine.SetStartState<IdleState>();

    }

    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        _stateMachine.Update();
    }

    /// <summary>
    /// Idle ステート
    /// </summary>
    private class IdleState : IceMilkTea.Core.ImtStateMachine<GameController>.State
    {
        protected internal override void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit_info = new RaycastHit();
                float max_distance = 100f * 100f;

                bool is_hit = Physics.Raycast(ray, out hit_info, max_distance);

                if (is_hit)
                {
                    Debug.Log(hit_info.transform.gameObject.name);
                }
            }
        }
    }

}
