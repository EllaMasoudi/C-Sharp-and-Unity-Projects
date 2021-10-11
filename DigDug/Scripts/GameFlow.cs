using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public Transform chocolate1Obj;
    public Transform chocolate2Obj;
    public Transform chocolate3Obj;
    public Transform backgroundObj;

    public static string supportGone = "n";
    void Start()
    {
        for (int xPos = -8; xPos < 9; xPos++)
        {
            Instantiate(chocolate1Obj, new Vector2(xPos, 3), chocolate1Obj.rotation);
            Instantiate(backgroundObj, new Vector2(xPos, 3), backgroundObj.rotation);
            Instantiate(chocolate1Obj, new Vector2(xPos, 2), chocolate1Obj.rotation);
            Instantiate(backgroundObj, new Vector2(xPos, 2), backgroundObj.rotation);

            Instantiate(chocolate2Obj, new Vector2(xPos, 1), chocolate2Obj.rotation);
            Instantiate(backgroundObj, new Vector2(xPos, 1), backgroundObj.rotation);
            Instantiate(chocolate2Obj, new Vector2(xPos, 0), chocolate2Obj.rotation);
            Instantiate(backgroundObj, new Vector2(xPos, 0), backgroundObj.rotation);
            Instantiate(chocolate2Obj, new Vector2(xPos, -1), chocolate2Obj.rotation);
            Instantiate(backgroundObj, new Vector2(xPos, -1), backgroundObj.rotation);

            Instantiate(chocolate3Obj, new Vector2(xPos, -2), chocolate3Obj.rotation);
            Instantiate(backgroundObj, new Vector2(xPos, -2), backgroundObj.rotation);
            
            Instantiate(chocolate3Obj, new Vector2(xPos, -3), chocolate3Obj.rotation);
            Instantiate(backgroundObj, new Vector2(xPos, -3), backgroundObj.rotation);
            Instantiate(chocolate3Obj, new Vector2(xPos, -4), chocolate3Obj.rotation);
            Instantiate(backgroundObj, new Vector2(xPos, -4), backgroundObj.rotation);
            Instantiate(chocolate3Obj, new Vector2(xPos, -5), chocolate3Obj.rotation);
            Instantiate(backgroundObj, new Vector2(xPos, -5), backgroundObj.rotation);

            Instantiate(backgroundObj, new Vector2(xPos, 4), backgroundObj.rotation);
            Instantiate(backgroundObj, new Vector2(xPos, 5), backgroundObj.rotation);
            Instantiate(backgroundObj, new Vector2(xPos, 6), backgroundObj.rotation);

        }
    }

 
    void Update()
    {
        
    }
}
