using UnityEngine;
using UnityEngine.UI;
public class ArrowsLeft : MonoBehaviour
{
    public static int left;
    [SerializeField] int Arrows_Total = 30;
    public Text Arrowsl;
    void Update()
    {   
        left = (Arrows_Total - BowArrow.BowController.arrowcount);
        Arrowsl.text = left.ToString("0");
    }

}

