using System.Collections;
using UnityEngine;

public class CoroutineFileLoad : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(LoadText());
    }
    
    private static IEnumerator LoadText()
    {
        var text = System.IO.File.ReadAllText(@"C:\TestText\Test.txt");
        Debug.Log(text);
        yield break; 
    }
}
