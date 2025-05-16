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

    [UnityTest]
    public IEnumerator NinjaFrogMove()
    {
        yield return new WaitForSeconds(2);
        NinjaFrog = GameObject.Find("NinjaFrog");
        Assert.That(NinjaFrog.GetComponent<Rigidbody2D>().linearVelocity.y > 0);
    }


    [TearDown]
    public void TearDown()
    {
        EditorSceneManager.UnloadSceneAsync("SampleScene");
    }
    

}
