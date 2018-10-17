using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float screenCenterX;

    public float rotateSpeed = 100f;

    private void Start()
    {
        screenCenterX = Screen.width * 0.5f;
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateClockwise();
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotateAntiClockwise();
        }

        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > screenCenterX)
            {
                RotateClockwise();
            }
            else if (Input.mousePosition.x < screenCenterX)
            {
                RotateAntiClockwise();
            }
        }
	}

    private void RotateClockwise()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    private void RotateAntiClockwise(){
        transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
    }

   
}
