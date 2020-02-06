using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ThrowData", menuName = "Create Throw Data")]
public class ThrowData : ScriptableObject
{
    [Header("Data")]
    public string move_name;
    public int break_window;
    public int start_frame;
    public int end_frame;

    //[Tooltip("I have no clue if we're actually going to use this")]
    //public Sprite bucketSprite;
    //[Header("Also put in things like meshes here so that it's easy to find them!")]

}
