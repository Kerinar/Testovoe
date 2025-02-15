using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateJump : PlayerState
{
    public override void Update(Player player)
    {
        player._velocity += Vector3.down * 0.01f;

        Vector3 moving = player.transform.forward * Input.GetAxis("Vertical") + player.transform.right * Input.GetAxis("Horizontal");
        player._velocity.x = moving.x;
        player._velocity.z = moving.z;

        if (player._characterController.isGrounded)
        {
            player._animator.Play("Idle");
            player.SwitchState(player._idleState);
        }
    }
}
