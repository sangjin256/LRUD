using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorButton : MonoBehaviour
{
    public LockedDoor triggerObject;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (triggerObject.isLocked) triggerObject.Open();
        else triggerObject.Close();
    }
}
