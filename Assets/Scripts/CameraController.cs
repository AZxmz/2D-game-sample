using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*CameraController: In charge of the camera to follow the player's movement.
 */
public class CameraController : MonoBehaviour
{
    private Transform target;

    void Start()
    {
        target = FindObjectOfType<PlayerController>().transform; //Find the first 'PlayerController' and get the transform
    }

    void LateUpdate()
    {
        if (target == null)//Prevent the target is null
        {
            PlayerController player = FindObjectOfType<PlayerController>();
            if (player != null)
                target = player.transform;
        }

        if (target != null)
        {
            transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);//z is not changeing,keeping the camera' axis of z cant't change
        }
    }
}
