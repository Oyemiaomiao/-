using UnityEngine;
using UnityEngine.UI;  // 导入UI命名空间

public class ClickToShowText : MonoBehaviour
{
    public GameObject textObject;  // 指向UI文本对象的引用

    void Start()
    {
        // 确保游戏开始时文本是隐藏的
        textObject.SetActive(false);
    }
 void OnMouseDown()
    {
       textObject.SetActive(true);
    }
}
