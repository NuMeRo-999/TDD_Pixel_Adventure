using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

public class NinjaFrogMovementTest
{
    private GameObject NinjaFrog;
    private GameObject Ground;

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene("SampleScene");
        Debug.Log("Scene Loaded");
    }
    [UnityTest]
    public IEnumerator NinjaFrogFall()
    {   
        yield return new WaitForSeconds(2);
        NinjaFrog = GameObject.Find("NinjaFrog");
        Ground = GameObject.Find("Ground");
        Assert.That(NinjaFrog.transform.position.y > Ground.transform.position.y);
       
    }


    [TearDown]
    public void TearDown()
    {
        EditorSceneManager.UnloadSceneAsync("SampleScene");
    }
}
