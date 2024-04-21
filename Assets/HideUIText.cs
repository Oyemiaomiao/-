using UnityEngine;
using UnityEngine.UI; // 引入UI命名空间

public class HideUIText : MonoBehaviour
{
    public GameObject textToHide; // 用于引用要隐藏的文本框

    // 为按钮添加点击事件监听
    void Start()
    {
        Button btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(HideText);
        }
    }

    // 当按钮被点击时调用此方法
    void HideText()
    {
        if (textToHide != null)
        {
            textToHide.SetActive(false); // 隐藏文本框
        }
    }
}
