using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public Sprite Cross_Tile, Original_Tile;
    public GameObject Tile_prefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Click()
    {
        if (Tile_prefab.GetComponent<SpriteRenderer>().sprite == Original_Tile)
        {
            Tile_prefab.GetComponent<SpriteRenderer>().sprite = Cross_Tile;

        }
        else
        {
            Tile_prefab.GetComponent<SpriteRenderer>().sprite = Original_Tile;
        }

    }
}
