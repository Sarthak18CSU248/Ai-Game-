using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public Sprite Cross_Tile, Original_Tile;
    public GameObject Tile_prefab;
    public bool Walkable_Tile;
    
    public void Click()
    {
        if (Tile_prefab.GetComponent<SpriteRenderer>().sprite == Original_Tile)
        {
            Tile_prefab.GetComponent<SpriteRenderer>().sprite = Cross_Tile;
            Walkable_Tile = false;
        }
        else
        {
            Tile_prefab.GetComponent<SpriteRenderer>().sprite = Original_Tile;
            Walkable_Tile = true;
        }

    }
}
