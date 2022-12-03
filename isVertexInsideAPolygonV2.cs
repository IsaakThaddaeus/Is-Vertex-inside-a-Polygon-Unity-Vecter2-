using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isVertexInsideAPolygonV2 : MonoBehaviour
{
    float sum;

    bool insidePolygon(Vector2 aPoint, List<Vector2> bVertList)
    {
        sum = 0;

        for (int i = 0; i < bVertList.Count; i++)
        {
            Vector2 xA;
            Vector2 xB;

            if (i + 1 != bVertList.Count)
            {
                xA = bVertList[i] - aPoint;
                xB = bVertList[i + 1] - aPoint;
            }
            else
            {
                xA = bVertList[i] - aPoint;
                xB = bVertList[0] - aPoint;
            }

            sum += Vector2.SignedAngle(xA, xB);
        }

        Debug.Log(sum);

        if (sum < -359 && sum > -361)
        {
            return true;
        }

        else
        {
            return false;
        }

    }
}
