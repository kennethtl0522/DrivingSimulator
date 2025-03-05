using UnityEditor.Build.Content;
using UnityEngine;

public class ObstacleOnCollide : MonoBehaviour
{
    
    public Transform explosionPrefab;
    public float forceMultiplier = 25f;
    public int scoreValue = 100;
    
    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;
        Vector3 impactDirection = (transform.position - collision.transform.position).normalized;
        gameObject.GetComponent<Rigidbody>().AddForce(impactDirection * forceMultiplier, ForceMode.Impulse);
        FindAnyObjectByType<ScoreManager>().IncreaseScore(scoreValue);
    }
    
}
