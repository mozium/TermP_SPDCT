using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.25f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && !isMoving)
        {
            StartCoroutine(movePlayer(Vector3.up));
        }

        if (Input.GetKey(KeyCode.DownArrow) && !isMoving)
        {
            StartCoroutine(movePlayer(Vector3.down));
        }

        if (Input.GetKey(KeyCode.RightArrow) && !isMoving)
        {
            StartCoroutine(movePlayer(Vector3.right));
        }

        if (Input.GetKey(KeyCode.LeftArrow) && !isMoving)
        {
            StartCoroutine(movePlayer(Vector3.left));
        }
    }

    private IEnumerator movePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0f;

        origPos = transform.position;
        targetPos = origPos + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;
    }
}
