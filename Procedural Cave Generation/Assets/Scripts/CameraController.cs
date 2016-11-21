using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Transform target;
    public float distance;

    void Update()
    {
        transform.position = new Vector3 (target.position.x, target.position.y + distance, target.position.z);
    }
}
