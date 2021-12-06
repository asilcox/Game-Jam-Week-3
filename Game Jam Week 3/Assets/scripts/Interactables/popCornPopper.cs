using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popCornPopper : MonoBehaviour
{
    [SerializeField] GameObject[] popcornPrefabs;
    [SerializeField] GameObject[] poppedCorn;
    [SerializeField] int popcornToPop;

    private void Awake()
    {
        poppedCorn = new GameObject[popcornToPop];
        for (int i = 0; i < poppedCorn.Length; i++)
        {
            GameObject clone = Instantiate<GameObject>(popcornPrefabs[0], Vector3.zero, Quaternion.identity);

            poppedCorn[i] = clone;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void popCorn()
    {
        
    }
}
