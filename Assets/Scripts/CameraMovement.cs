using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float clampArea = 1f;

    private void Update() {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended){
            Vector2 TouchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-TouchDeltaPosition.x* speed* Time.deltaTime, -TouchDeltaPosition.y * speed * Time.deltaTime, 0f);

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -clampArea, clampArea), Mathf.Clamp(transform.position.y, -clampArea, clampArea), -10f);
        }
    }
}
