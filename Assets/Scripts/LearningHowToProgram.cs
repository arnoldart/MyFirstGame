using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(ExecuteSomething());
        StartCoroutine("ExecuteSomething");
        StopCoroutine("ExecuteSomething");
    }

    // Update is called once per frame
    IEnumerator ExecuteSomething() {
        yield return new WaitForSeconds(2f);

        Debug.Log("Somwthing awaowpekpa");
    }
}
