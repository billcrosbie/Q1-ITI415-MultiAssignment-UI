using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Collection : MonoBehaviour
{
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Ups"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {

        countText.text = "Count: " + count.ToString();
        if (count > 5)
        {
            winText.text = "Now if only you could escape.";
        }
    }
}