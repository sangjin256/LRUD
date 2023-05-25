using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLR : MonoBehaviour
{
    private bool isCollision;

    private void Update()
    {
        if (isCollision)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("LR¼¼ÄÚ~");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LRPlayer")) isCollision = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("LRPlayer")) isCollision = false;
    }
}
