using System;
using UnityEngine;

public class GrannySquareTemplateMBScript : MonoBehaviour
{
    private GameManager gameManager; 
    private void OnMouseDown()
    {
        Debug.Log("clicked");
        var selectedGrannySquare = ScriptableObject.CreateInstance<GrannySquare>();
        gameManager.grannySquares.Add(selectedGrannySquare);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
