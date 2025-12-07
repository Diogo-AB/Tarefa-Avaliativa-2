using UnityEngine;
using UnityEngine.EventSystems;

public class RotateObject : MonoBehaviour
{
    public Transform target; // o animal
    public float rotationSpeed = 60f;

    private bool rotatingRight = false;
    private bool rotatingLeft = false;

    void Update()
    {
        if (rotatingRight)
            target.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        if (rotatingLeft)
            target.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
    }

    public void StartRotateRight()
    {
        rotatingRight = true;
    }

    public void StopRotateRight()
    {
        rotatingRight = false;
    }

    public void StartRotateLeft()
    {
        rotatingLeft = true;
    }

    public void StopRotateLeft()
    {
        rotatingLeft = false;
    }
}
