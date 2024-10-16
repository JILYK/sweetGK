
using UnityEngine;
using UnityEngine.UI;

public class ImageKost : MonoBehaviour
{
    public void StartGame(GameObject image)
    {
        image.GetComponent<Image>().color = new Color(0, 0 , 0 , 0);
    }
}
