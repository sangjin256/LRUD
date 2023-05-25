using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public bool isLocked;

    public void Open()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        isLocked = false;
    }

    public void Close()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        isLocked = true;
    }
}