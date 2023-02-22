using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public Text Scoree;
    public static int scoretotal;
    void Update()
    {
        scoretotal = Collide_Red.points_red + Collide_Yellow.points_yellow + Collide_Green.points_green - ArrowsLeft.used*5;
        Scoree.text = scoretotal.ToString("0");
    }

}
