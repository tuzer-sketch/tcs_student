using UnityEngine;
using UnityEngine.SceneManagement;

public class doorscript : MonoBehaviour
{
    [SerializeField] private string toScene;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(toScene);
        }
    }
        
}
     
