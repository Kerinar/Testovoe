using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateJump : PlayerState
{
    public override void Enter(Player player)
    {
        player._animator.Play("Jump");
        player._velocity.y = 5f;
    }

    public override void Update(Player player)
    {
        
        Vector3 moving = player.transform.forward * Input.GetAxis("Vertical") + player.transform.right * Input.GetAxis("Horizontal");
        moving *= player._speed;

        player._velocity.x = moving.x;
        player._velocity.z = moving.z;
        
        if (player._characterController.isGrounded)
        {
            player.SwitchState(player._idleState);
        }
    }
}
