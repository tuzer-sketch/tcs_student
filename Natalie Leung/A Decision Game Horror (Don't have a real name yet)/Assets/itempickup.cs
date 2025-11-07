using UnityEngine;

public class itempickup : MonoBehaviour
{
    public ietm pcikpu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var inventory = GameObject.FindFirstObjectByType<Inventoryhandlerchocomint>();
         if (inventory.Contains(pcikpu))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if  (collision.gameObject.TryGetComponent<Playermovement>(out Playermovement p)){
            p.ehietm = null;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Playermovement>(out Playermovement p))
        {
            p.ehietm = this;
        }
    }
}
