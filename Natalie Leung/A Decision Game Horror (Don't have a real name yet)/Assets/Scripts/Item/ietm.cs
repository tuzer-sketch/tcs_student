using UnityEngine;

[CreateAssetMenu(fileName = "ietm", menuName = "Scriptable Objects/ietm")]
public class ietm : ScriptableObject
{
    [SerializeField] public string itemName;
    [SerializeField] public Sprite icon;
    [SerializeField] public int maxStackSize = 16;
}
