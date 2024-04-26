using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class CubeChanger : MonoBehaviour
{
    public void ColorChange()
    {
        Color randomColor = Random.ColorHSV();

        GetComponent<Renderer>().material.color = randomColor;
    }
}