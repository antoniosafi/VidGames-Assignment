using System.Collections;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject segmentMap01;
    public GameObject segmentMap02;
    public GameObject segmentMap03;
    public GameObject segmentMap04;
    public GameObject segmentMap05;
    public GameObject segmentMap06;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SegmentGen());
    }
    IEnumerator SegmentGen()
    {
        yield return new WaitForSeconds(4);
        segmentMap02.SetActive(true);
        yield return new WaitForSeconds(4);
        segmentMap03.SetActive(true);
    }
}
