using TMPro;
using UnityEngine;

public class DialougeController : MonoBehaviour
{
    public TextMeshProUGUI textbox;
    public string dialouge;
    public string[] conversation;
    public int place;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialouge = conversation[place];
        textbox.text = dialouge;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       var quack= Input.GetKeyDown(KeyCode.Space);
        if (quack)
        {
            place += 1;
            if (place >= conversation.Length) {
                gameObject.SetActive(!gameObject.activeSelf);
                return;
            }
            dialouge = conversation[place];
            textbox.text = dialouge;
        }
        var duck=Input.GetKeyDown(KeyCode.Escape);
        if (duck )
        {
            gameObject.SetActive(!gameObject.activeSelf); 
        }
    }
}
