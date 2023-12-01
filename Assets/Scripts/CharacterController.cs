using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    //Integrate this with new input system <3
    //Make it work with controller and keyboard input (WASD & Arrow Keys)
    //Actions
    //Walk, Run, Jump, Crouch, Ability

    //Sprite Renderer
    //Rigidbody2D
    //Movement Force

    //Jump Force
    //Held Jump Decay Rate



    private void Awake()
    {
        
    }
    public void OnAButton(bool pressed)
    {
        //Jump or Swim
        //When button is pressed and is on ground, jump
        //If button is held while in air, player jumps higher
        //Max Jump height is increased the faster the player is moving

        //If player is under water, button press makes player swim upwards
    }
    public void OnBButton(bool pressed)
    {
        //When button is held, speed increased
        //When button is pressed, activate ability
    }
    public void OnPowerUpTouched(/*Powerup type enum*/)
    {
        //if mushroom and small
        //make player big

        //if mushroom and big
        //increase score

        //if fire flower and not fire
        //become fire

        //if fire flower and fire
        //increase score

        //if star and not star mode
        //activate star mode
        //if star and star mode
        //reset starmode timer
        //increase score
    }
    public void OnEnemyTouched(/*Reference to Enemy*/)
    {
        //if star powered
        //Kill enemy

        //if firey or super
        //become normal

        //if normal
        //die
    }
}
