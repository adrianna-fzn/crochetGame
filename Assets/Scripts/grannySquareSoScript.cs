using UnityEngine;

[CreateAssetMenu(fileName = "grannySquareScript", menuName = "Scriptable Objects/grannySquareScript")]
public class GrannySquare : ScriptableObject
{
    public GrannySquareTemplate template;
    public bool isCompleted = false;
}
