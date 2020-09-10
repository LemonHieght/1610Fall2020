using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent((typeof(Image)))]
public class ImageBehavior : MonoBehaviour
{
    private Image objectImage;
    public FloatScript dataObj;
    // Start is called before the first frame update
    void Start()
    {
        objectImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        objectImage.fillAmount = dataObj.value;
    }
}
