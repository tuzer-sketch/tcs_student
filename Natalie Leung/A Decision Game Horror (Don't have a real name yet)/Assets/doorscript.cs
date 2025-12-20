using UnityEngine;
using UnityEngine.SceneManagement;

public class doorscript : MonoBehaviour
{
    
    [SerializeField] private Transform todoor;
    [SerializeField] private int offset;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collison");
       Playermovement player = other.gameObject.GetComponent<Playermovement>();
        player.SetTeleportPosition(todoor.position + new Vector3(0, -offset, 0));
        Debug.Log("set position");
        player.SetIsNextToDoor(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Playermovement player = other.gameObject.GetComponent<Playermovement>();
        player.SetIsNextToDoor(false);
    }
}

     
