using UnityEngine;
using UnityEngine.EventSystems; // 用于处理UI事件
using UnityEngine.UI; // 用于处理UI组件

public class ActivateMultiple2DObjects : MonoBehaviour, IPointerClickHandler // 实现点击接口
{
    public GameObject[] objectsToActivate; // 要激活的多个2D物体的数组
     public Button[] buttonsToActivate; // 要激活的按钮数组

    public void OnPointerClick(PointerEventData eventData)
    {
        // 检查是否设置了要激活的对象数组
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
            {
                // 激活数组中的每个2D物体
                obj.SetActive(true);
            }
            
        }
        
        foreach (Button btn in buttonsToActivate)
        {
            if (btn != null)
            {
                // 激活数组中的每个按钮
                btn.gameObject.SetActive(true);
            }
        }


        // 点击后使该对象自身消失
        gameObject.SetActive(false);
    }
}
