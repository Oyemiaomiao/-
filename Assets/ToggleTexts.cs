using UnityEngine;
using UnityEngine.UI; // 确保导入UnityEngine.UI命名空间

public class ToggleTexts : MonoBehaviour
{
    public GameObject[] textObjects; // 存储三个文本框的数组
    private int currentIndex = 0;    // 当前应显示的文本框索引

    void Start()
    {
        // 初始时，确保所有文本框都被隐藏
        foreach (GameObject text in textObjects)
        {
            text.SetActive(false);
        }
    }

    public void ShowNextText()
    {
        // 隐藏当前显示的文本框
        if (textObjects[currentIndex].activeSelf)
        {
            textObjects[currentIndex].SetActive(false);
        }

        // 更新索引到下一个文本框
        currentIndex = (currentIndex + 1) % textObjects.Length;

        // 显示下一个文本框
        textObjects[currentIndex].SetActive(true);
    }
}
