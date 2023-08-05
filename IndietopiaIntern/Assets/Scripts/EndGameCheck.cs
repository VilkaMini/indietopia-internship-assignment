using UnityEngine;

public class EndGameCheck : MonoBehaviour
{
    public GameObject endText;

    private void OnTriggerEnter(Collider other)
    {
        endText.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
