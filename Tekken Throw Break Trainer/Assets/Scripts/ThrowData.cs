using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ThrowData", menuName = "Create Throw Data")]
public class ThrowData : ScriptableObject
{
    [Header("Data")]
    public string move_name;
    public int total_frames; // Total frames
    public int startup_frames; // Startup frames
    public int active_frames; // Breakable Frames
    public int recovery_frames; // Might not need this as the throw break trainer will never miss a throw
    public int break_command;
    public string video_file;

    //[Tooltip("I have no clue if we're actually going to use this")]
    //public Sprite bucketSprite;
    //[Header("Also put in things like meshes here so that it's easy to find them!")]

}
