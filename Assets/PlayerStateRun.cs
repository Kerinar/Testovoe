using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateRun : PlayerState
{
    public override void Enter(Player player)
    {
        player._animator.Play("Run");
    }

    public override void Update(Player player)
    {
        Vector3 moving = player.transform.forward * Input.GetAxis("Vertical") + player.transform.right * Input.GetAxis("Horizontal");
        moving *= player._speed;

        player._velocity.x = moving.x;
        player._velocity.z = moving.z;
        

        if (Input.GetAxis("Horizontal") == 0f && Input.GetAxis("Vertical") == 0f)
        {
            player.SwitchState(player._idleState);
        }

        Debug.Log(player._characterController.isGrounded);

        if (Input.GetButtonDown("Jump"))
        {
            player.SwitchState(player._jumpState);
        }
    }
}
