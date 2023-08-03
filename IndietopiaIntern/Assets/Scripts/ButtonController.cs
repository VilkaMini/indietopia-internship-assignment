using UnityEngine;

// Open doors on button click
public class ButtonController : MonoBehaviour
{
    public Animator doorAnimator;
    private AudioSource soundSource;

    private void Start()
    {
        soundSource = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        doorAnimator.SetTrigger("OpenDoor");
        soundSource.Play();
    }
}
