using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GridGenerator Grid;
    public float destination_row;
    public float destination_column;
    public float current_row = 1;
    public float current_column = 1;

    // Start is called before the first frame update
    void Start()
    {
        destination_row = Grid.rows;
        destination_column = Grid.column;
    }

    // Update is called once per frame
    public void OnClick_Start()
    {
        InvokeRepeating("Player_Move",0.5f,0.5f);
    }



    void Player_Move()
    {
        var index = -1;
        if (current_row < destination_row)
        {
            index = Convert.ToInt32((current_row * destination_column) + (current_column - 1));
            transform.position = Grid.transform.GetChild(index).position;
            current_row++;
        }
        if (current_column < destination_column)
        {
            index = Convert.ToInt32(((current_row - 1) * destination_column) + (current_column));
            //index = Convert.ToInt32((((current_row - 1) * destination_column) + current_column));
            transform.position = Grid.transform.GetChild(index).position;
            current_column++;
        }

    }

}
