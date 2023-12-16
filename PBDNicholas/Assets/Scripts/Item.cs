using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable Object/Item")]
public class Item : ScriptableObject
{
    [Header("Somenta na Gameplay!")]
    public TileBase tile;
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);

    [Header("Somente na Interface!")]
    public bool stackable = true;
    
    [Header("Ambos!")]
    public Sprite image;

    public enum ItemType
    {
        Goiaba,
        Banana,
        Coco,
        Kiwi,
        Laranja,
        Uva
    }

    public enum ActionType
    {
        Velocidade,
        Pulo,
        Voar,
        Nadar,
        Correr,
        Vida
    }
}
