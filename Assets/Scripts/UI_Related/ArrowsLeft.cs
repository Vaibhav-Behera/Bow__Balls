using UnityEngine;
using UnityEngine.UI;
public class ArrowsLeft : MonoBehaviour
{
    public static int used;
    //[SerializeField] int Arrows_Total = 30;
    public Text Arrowsl;
    void Update()
    {   
        used = (BowArrow.BowController.arrowcount);
        Arrowsl.text = used.ToString("0");
    }

}

