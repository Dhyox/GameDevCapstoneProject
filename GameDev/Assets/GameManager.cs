using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int coin;
    public static int multiplier;
    // Start is called before the first frame update
    void Start()
    {
        multiplier = 1;
        coin = 0;
    }

}