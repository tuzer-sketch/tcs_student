using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Playermovement : MonoBehaviour
{
    Vector3 teleportposition;
    bool isnexttodoor;
    private Rigidbody2D rb;
    public static Playermovement instance;
    public itempickup pickup;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(gameObject);
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float movevertical = Input.GetAxis("Vertical") * 7;
        float movehorizontal = Input.GetAxis("Horizontal") * 7;
        rb.linearVelocity = new Vector2(movehorizontal, movevertical);
        var pickup = Input.GetButtonDown("pickup");
        if (pickup && this.pickup)
        {
            var inventory = GameObject.FindFirstObjectByType<Inventoryhandlerchocomint>();
            inventory.additem(this.pickup.pcikpu);
            Destroy(this.pickup.gameObject);
            this.pickup = null;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();

        }
    }

    private void Interact()
    {
        if (isnexttodoor)
        {
            transform.position = teleportposition;
        }
        Debug.Log("notnexttodoor");

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("poor guy gets yeeted"))
        {
            Destroy(gameObject);
        }

    }

    public void SetTeleportPosition(Vector3 teleportposition)
    {
        this.teleportposition = teleportposition;
        Debug.Log(teleportposition);
    }
    public void SetIsNextToDoor(bool state)
    {
        isnexttodoor = state;
    }

}
