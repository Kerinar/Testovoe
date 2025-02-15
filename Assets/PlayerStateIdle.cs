using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateIdle : PlayerState
{
    public override void Update(Player player)
    {
        if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
        {
            player._animator.Play("Run");
            player.SwitchState(player._runState);
        }

        if (Input.GetButtonDown("Jump"))
        {
            player._animator.Play("Jump");
            player._velocity = Vector3.up * 3f;
            player.SwitchState(player._jumpState);
        }
    }
}
