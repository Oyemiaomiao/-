using UnityEngine;
using UnityEngine.UI;  // 导入UI命名空间

public class ActivateButtonOnSpecificCollision : MonoBehaviour
{
    public Button buttonToActivate; // 指向要激活的按钮的引用

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 检查碰撞的物体是否为我们指定的“Activator”标签
        if (collision.gameObject.CompareTag("Activator"))
        {
            // 激活按钮，使其可点击
            buttonToActivate.interactable = true;
        }
    }
}
