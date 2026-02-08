using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTimer : MonoBehaviour
{
    IEnumerator makeTurn()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
    private void Awake()
    {
        StartCoroutine(makeTurn());
    }

    private void OnDisable()
    {
        Destroy(gameObject);
    }

}
