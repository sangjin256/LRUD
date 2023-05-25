using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUD : MonoBehaviour
{
    private bool isCollision;

    private void Update()
    {
        if (isCollision)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("UD¼¼ÄÚ~");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("UDPlayer")) isCollision = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("UDPlayer")) isCollision = false;
    }
}
