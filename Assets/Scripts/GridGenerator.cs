using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{

    public float rows = 6f;
    public float column=6f;
    public float tilesize = 1;

    public GameObject tile_prefab;
    public GameObject player_Prefab;
    public GameObject Destination_Prefab;

    private GameObject player_move = null;
    private GameObject destination = null;
    //private GameObject gridGo = null;

    public bool _isGameStarted;

    private void Awake()
    {
        Tile_Spawn();
        Player_Spawn();
        End_Point();
    }

    void Tile_Spawn()
    {
        var tile_sprite = tile_prefab.GetComponent<SpriteRenderer>().sprite;
        var pixels = tile_sprite.pixelsPerUnit;
        var width = tile_sprite.rect.width / pixels;
        float StartX = -column * 0.5f * width + width * 0.5f;
        float StartY = -rows * 0.5f * width + width * 0.5f;


        for (int row = 0; row < rows; ++row)
        {
            for (int col = 0; col < column; ++col)
            {
                var tile_instance = Instantiate(tile_prefab, new Vector2(StartX + (col * width), StartY + (row * width)), Quaternion.identity);
                tile_instance.transform.SetParent(transform);
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

    void Player_Spawn()
    {
        player_move = Instantiate(player_Prefab) as GameObject;
        player_move.transform.position = transform.GetChild(0).position;
        var instance = player_move.GetComponent<Player>();
        instance.Grid = this;
    }

    void End_Point()
    {
        destination = Instantiate(Destination_Prefab) as GameObject;
        int v = Convert.ToInt32((rows * column) - 1);
        destination.transform.position = transform.GetChild(v).position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && _isGameStarted==true)
        {
            Vector3 Non_WalkablePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(Non_WalkablePoint, Vector3.forward);
            if (hit)
            {
                hit.collider.gameObject.GetComponent<TileScript>().Click();

            }
            

        }
    }
}

