using TMPro;
using UnityEngine;

public class Player_Status : MonoBehaviour
{
    [SerializeField] private float player_health = 100f;
    [SerializeField] private TextMeshPro textMesh;
        void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision collision)
    {
        Debug.Log("yippee");
        player_health -= 10f;
        if (collision.gameObject.tag == "Enemy (deez nut)")
        {
           
        }
    }
}
