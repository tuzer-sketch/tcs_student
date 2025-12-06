using UnityEngine;
using UnityEngine.SceneManagement;

public class doorscript : MonoBehaviour
{
    
    [SerializeField] private Transform todoor;
    [SerializeField] private int offset;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.transform.position = todoor.position + new Vector3(0, -offset,0);
        }
       
    }
        
}
     
