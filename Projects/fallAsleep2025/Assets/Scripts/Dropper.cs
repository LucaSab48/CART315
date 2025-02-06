using System.Collections;
using UnityEngine;

public class Dropper : MonoBehaviour {
    public GameObject circle;
    public float dropRate = 1.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(routine: Drop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private IEnumerator Drop()
    {
        Debug.Log("Drop");
        float rX = Random.Range(-6f, 6f);
        Vector3 loc = new Vector3(rX, 6, 0);
        Instantiate(circle, loc, transform.rotation);
        float next = Random.Range(0.25f, 1.5f);
        dropRate = Mathf.Max(0.35f, dropRate * 0.98f);
        yield return new WaitForSeconds(dropRate);
        StartCoroutine(routine: Drop());
    }
}
