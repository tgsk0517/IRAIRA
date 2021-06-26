using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void OnClick()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        UnityEngine.Application.Quit();
    }
}
