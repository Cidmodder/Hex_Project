using System.Collections.Generic;
using System.Collections;
using System;
using UnityEngine;

public class HexagonGenerator : MonoBehaviour
{
    public GameObject hexagonPrefab;
    public int sideLength = 12; // Number of smaller hexagons on each side

    void Start()
    {
        GenerateHexagon();
    }

    void GenerateHexagon()
    {
        Quaternion rot = Quaternion.Euler(0.0f, 0.0f, 0.0f);

        const int maxTilesX = 27;
        const int halfMaxTilesX = 27 / 2;
        const int maxTilesY = 27;

        int xMin = -halfMaxTilesX;
        int xMax = halfMaxTilesX + (maxTilesX % 2); // add one if nr of tiles is odd

        const float tileSizeX = 0.75F;
        const float tileSizeY =.91F;
        const float halTileSizeY = tileSizeY * 0.5F;

        for (int x = xMin; x < xMax; x++)
        {
            float xPos = x * tileSizeX;

            int tilesY = maxTilesY - Math.Abs(x);
            int halfTilesY = tilesY / 2;

            int yMin = -halfTilesY;
            int yMax = halfTilesY + (tilesY % 2);

            float yOffset = halTileSizeY * Math.Abs(x % 2);

            for (int y = yMin; y < yMax; y++)
            {
                float yPos = (y * tileSizeY) + yOffset;
                Instantiate(hexagonPrefab, new Vector3(xPos,0, yPos), rot);
            }
        }
    }
}