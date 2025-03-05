using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 2.5f, 0.6f);
    private Vector3 currentOffset = new Vector3(0, 5, -7);
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Update();
        LateUpdate();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            currentOffset = (currentOffset == offset1) ? offset2 : offset1;
        }
    }
    
    void LateUpdate()
    {
        transform.position = player.transform.position + currentOffset;
    }
}