using UnityEditor.Animations;
using UnityEngine;

// Open doors on button click
public class ButtonController : MonoBehaviour
{
    public Animator doorAnimator;

    private void OnMouseDown()
    {
        doorAnimator.SetTrigger("OpenDoor");
    }
}
