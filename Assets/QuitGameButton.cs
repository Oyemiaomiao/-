using UnityEngine;

public class QuitGameButton : MonoBehaviour
{
    // 这个方法将被绑定到按钮的点击事件
    public void QuitGame()
    {
        // 在编辑器中，这将不会有任何效果
        // 在构建的游戏中，它将关闭游戏
        Application.Quit();

        // 如果你在Unity编辑器中调试，下面这行代码将确保能够退出播放模式
        // 注意：只在开发过程中使用
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
