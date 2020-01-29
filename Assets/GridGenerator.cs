using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    
    public float rows = 6;
  
    public float column = 6;
    
    public float tilesize = 1;
    public GameObject tile_prefab;


    // Start is called before the first frame update
    void Start()
    {
        var tile_sprite = tile_prefab.GetComponent<SpriteRenderer>().sprite;
        var pixels = tile_sprite.pixelsPerUnit;
        var width = tile_sprite.rect.width/pixels;
        //var unitDistance = width / pixels;
        float StartX = -column * 0.5f * width+width * 0.5f;
        float StartY = -rows * 0.5f * width+width * 0.5f;
        

        for (int row = 0; row < rows; ++row)
        {
            for (int col = 0; col < column; ++col)
            {
                var tile_instance = Instantiate(tile_prefab, new Vector2(StartX+(col*width),StartY+(row*width)), Quaternion.identity);
                /*var tile = Instantiate(tile_prefab) as GameObject;
                tile.transform.SetParent(transform);
                var Spawn_pos = Vector2.zero;
                Spawn_pos.x = StartX + col * unitDistance;
                Spawn_pos.y = StartY + row * unitDistance;
                tile.transform.position=Spawn_pos;
                */
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
