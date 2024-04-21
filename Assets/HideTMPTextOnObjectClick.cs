using UnityEngine;
using TMPro;  // 导入TextMeshPro命名空间

public class HideTMPTextOnObjectClick : MonoBehaviour
{
    public TextMeshProUGUI textToHide; // 可在Inspector中指定的TextMeshProUGUI组件

    private void OnMouseDown()
    {
        // 检查是否指定了TMP文本
        if (textToHide != null)
        {
            textToHide.gameObject.SetActive(false); // 隐藏TMP文本
        }
    }
}
