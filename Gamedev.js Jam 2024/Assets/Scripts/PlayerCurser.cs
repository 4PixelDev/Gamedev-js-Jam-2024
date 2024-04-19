using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCurser : MonoBehaviour
{
    [SerializeField] private Transform playerObject;
    // Start is called before the first frame update
    private Vector3 mousePos;

    private void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;

        TestShooting();
    }

    private void TestShooting()
    {
        // make it shoot a circle in air
        if (Input.GetMouseButtonDown(0))
        {
            // move the player to the point where i clicked
            playerObject.position = mousePos;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(playerObject.position, mousePos);
    }


}
