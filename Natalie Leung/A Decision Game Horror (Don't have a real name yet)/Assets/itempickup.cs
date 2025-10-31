using UnityEngine;

public class itempickup : MonoBehaviour
{
    public ietm pcikpu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Playermovement>(out Playermovement p))
        {
            p.ehietm = this;
        }
    }
}
