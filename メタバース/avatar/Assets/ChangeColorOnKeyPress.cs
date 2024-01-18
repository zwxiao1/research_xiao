using UnityEngine;
using UnityEngine.UI;

public class ChangeColorOnKeyPress : MonoBehaviour
{
    // 定义要改变颜色的UI对象
    private Image bgImage;

    void Start()
    {
        bgImage = GetComponent<Image>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            bgImage.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}