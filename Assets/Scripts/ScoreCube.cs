using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCube : MonoBehaviour
{
    [SerializeField]
    public float rotationSpeed;

    [SerializeField]
    public Vector3 rotationDirection = new Vector3();

    private List<Vector3> positions = new List<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
        positions.Add(new Vector3(5f, .5f, 3.2f));
        positions.Add(new Vector3(6.6f, .5f, -3.1f));
        positions.Add(new Vector3(.6f, .5f, 6.7f));
        positions.Add(new Vector3(-2.9f, .5f, 3.44f));
        positions.Add(new Vector3(-2.97f, .5f, 8.89f));
        positions.Add(new Vector3(2.82f, .5f, 10.2f));
        positions.Add(new Vector3(-2f, .5f, -1.3f));
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(rotationSpeed * rotationDirection * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        int randomIndex = Random.Range(0, positions.Count);
        this.gameObject.transform.position = positions[randomIndex];
    }
}
