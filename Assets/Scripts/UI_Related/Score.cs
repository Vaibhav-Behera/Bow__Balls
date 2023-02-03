using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public Text Scoree;
    void Update()
    {
        int scoretotal = Collide_Red.points_red + Collide_Yellow.points_yellow + Collide_Green.points_green;
        Scoree.text = scoretotal.ToString("0");
    }

}
