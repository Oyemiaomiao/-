using UnityEngine;

public class ClickToSwap : MonoBehaviour
{
    public GameObject objectToActivate; // 拖拽要激活的对象到这个字段

    void OnMouseDown()
    {
        // 点击当前对象时，将其隐藏
        gameObject.SetActive(false);

        // 检查是否设置了要激活的对象
        if (objectToActivate != null)
        {
            // 激活另一个对象
            objectToActivate.SetActive(true);
        }
    }
}
