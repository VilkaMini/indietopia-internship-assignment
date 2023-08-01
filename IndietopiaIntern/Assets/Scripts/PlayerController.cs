using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float cameraSpeed;
    [SerializeField]
    private float movementSpeed;

    private float xRotation = 0.0f;

    public Camera cam;
    CharacterController characterController;

    private void Start()
    {
        Cursor.visible = false;
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * cameraSpeed;
        float horizontal = Input.GetAxis("Horizontal") * movementSpeed;
        float vertical = Input.GetAxis("Vertical") * movementSpeed;

        xRotation += mouseX;

        transform.eulerAngles = new Vector3(0.0f, xRotation, 0.0f);
        characterController.Move((cam.transform.right * horizontal + cam.transform.forward * vertical) * Time.deltaTime);
    }
}
