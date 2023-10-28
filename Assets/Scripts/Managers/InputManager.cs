using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class InputManager
{
    private static Controls _controls;

    public static void Init(Player myPlayer)
    {
        _controls = new Controls();

        _controls.Game.Movement.started += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());

        };

        _controls.Permanent.Enable();
    }

    public static void Gamemode()
    {
        _controls.Game.Enable();
        _controls.UI.Disable();
    }

    public static void UImode()
    {
        _controls.UI.Enable();
        _controls.Game.Disable();
    }
}
