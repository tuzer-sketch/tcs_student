using TMPro;
using UnityEngine;

public class DialougeController : MonoBehaviour
{
    public TextMeshProUGUI textbox;
    public string dialouge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textbox.text = dialouge;
    }

    // Update is called once per frame
    void Update()
    {
       
        var duck=Input.GetKeyDown(KeyCode.R);
        if (duck )
        {
            gameObject.SetActive   (!gameObject.activeSelf); 
        }
    }
}
