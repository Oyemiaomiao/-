using UnityEngine;

public class ActivateObjectsOnClick : MonoBehaviour
{
    public GameObject[] objectsToActivate; // 用于存储要激活的游戏对象数组

    private void OnMouseDown()
    {
        // 点击此对象时激活所有指定的对象
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
            {
                // 激活数组中的每个对象
                obj.SetActive(true);
            }
        }

        // 激活对象后使该对象自身消失
        gameObject.SetActive(false);
    }
}
