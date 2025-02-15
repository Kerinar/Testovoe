using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateIdle : PlayerState
{
    public override void Enter(Player player)
    {
        player._animator.Play("Idle");
    }

    public override void Update(Player player)
    {
        if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
        {
            player.SwitchState(player._runState);
        }

        if (Input.GetButtonDown("Jump"))
        {
            player.SwitchState(player._jumpState);
        }
    }
}
