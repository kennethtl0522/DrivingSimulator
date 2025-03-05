using UnityEngine;

public class AIVehicle : MonoBehaviour
{
    public float speed = 20f;
    
    void Start()
    {
        Update();
    }
    
    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }


}
