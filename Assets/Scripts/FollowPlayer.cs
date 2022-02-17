using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //transform follows an object position
    public Transform player;
    //vector3 stores 3 floats
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
