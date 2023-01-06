using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeArea : MonoBehaviour
{
    public GameObject safeArea;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            safeArea.SetActive(true);
            StartCoroutine(SafeAreaTimer());
        }
    }

    private IEnumerator SafeAreaTimer()
    {
        yield return new WaitForSeconds(2);
        safeArea.SetActive(false);

    }
}
