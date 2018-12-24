using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour {

    private float time = 30;
    private float time2 = 0;
    private int count = 0;
    private bool f = true;
    private int[] i = { -1, 1 };

    public TextMesh time_text;
    public TextMesh text;
    public AudioSource patyan;
    public GameObject[] ban;
    public Transform PL;
    public Transform namazu;


    void Start()
    {
        text.text = "0";
    }


    void Update()
    {
        if (time > 0 && count > 0)
        {
            time -= Time.deltaTime;
            time_text.text = time.ToString("0#.#0");
        }
        else if (count > 0)
        {
            time_text.text = "00.00";
            ban[1].SetActive(true);
            ban[0].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            time_text.text = "30.00";
            text.text = "0";
            time = 30f;
            count = 0;
            ban[1].SetActive(false);
            ban[0].SetActive(true);
        }

        if (Mathf.Abs(PL.position.x - namazu.position.x) > 2 || Mathf.Abs(PL.position.z - namazu.position.z) > 2)
        {
            namazu.position = new Vector3(Random.Range(0.6f, 1.6f) * i[Random.Range(0, 1)], 1.5f, Random.Range(0.43f, 1.43f) * i[Random.Range(0, 1)]);
            patyan.Play();
        }
    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("ok") && f)
        {
            col.GetComponent<Transform>().position = new Vector3(Random.Range(0.6f, 1.6f) * i[Random.Range(0, 1)], 1.5f, Random.Range(0.43f, 1.43f) * i[Random.Range(0, 1)]);
            count++;
            text.text = count.ToString();
            patyan.Play();
        }
    }
}
