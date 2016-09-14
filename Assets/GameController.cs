using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    private const int TP = 0;
    private const int TRSU = 1;
    private const int TRVE = 2;
    private const int TRSA = 3;
    private const int TRST = 4;
    private const int TBSU = 5;
    private const int TBVE = 6;
    private const int TBSA = 7;
    private const int TBST = 8;
    private const int TYSU = 9;
    private const int TYVE = 10;
    private const int TYSA = 11;
    private const int TYST = 12;
    private const int TGSU = 13;
    private const int TGVE = 14;
    private const int TGSA = 15;
    private const int TGST = 16;
    private const int BLHO = 17;
    private const int UU = 18;

    private int[,] mTileMapAA = { 
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP, TBVE,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP, TYSU,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP, TGSA,   TP,   TP },
        {   TP,   TP, TRST,   TP,   TP,   TP,   TP, BLHO },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   UU },
    };
    private int[,] mTileMapAB = {
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP, TGSU,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP, TRVE,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP, TBSA,   TP,   TP,   TP, TYST,   TP },
        {   UU,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
    };
    private int[,] mTileMapAC = {
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   UU },
        {   TP,   TP,   TP, TBSU,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP, TRSA,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP, TYVE,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP, TGST,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
    };
    private int[,] mTileMapAD = {
        {   UU,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP, TYSA,   TP },
        { TRSU,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP, TGVE,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP, TBST,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
    };
    private int[,] mTileMapBA = {
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
    };
    private int[,] mTileMapBB = {
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
    };
    private int[,] mTileMapBC = {
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
    };
    private int[,] mTileMapBD = {
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
        {   TP,   TP,   TP,   TP,   TP,   TP,   TP,   TP },
    };

    private const int N = 0;
    private const int L = 1 << 1;
    private const int R = 1 << 2;
    private const int T = 1 << 3;
    private const int B = 1 << 4;

    private int[,] mTileWallAA = {
        {   N,   N,   N,   R,   L,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   B,   N,   N,   N,   N,   N,   N },
        {   N, T|R,   L,   N,   N,   B,   N,   N },
        {   N,   N,   N,   N,   R, T|L,   N,   N },
        {   N,   N, B|R,   L,   N,   N,   N, B|R },
        {   B,   N,   T,   N,   N,   N,   N,   T },
        {   T,   N,   N,   N,   N,   N,   N,   N },
    };
    private int[,] mTileWallAB = {
        {   N,   R,   L,   N,   N,   B,   N,   N },
        {   N,   N,   N,   N,   N, T|R,   L,   N },
        {   N,   B,   N,   N,   N,   N,   N,   N },
        {   R, T|L,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   B },
        {   N,   N,   N,   N,   N,   N,   N,   T },
        {   N,   N, B|R,   L,   N,   R, B|L,   N },
        {   N,   N,   T,   N,   N,   N,   T,   N },
    };
    private int[,] mTileWallAC = {
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N, B|R,   L,   N,   N,   N },
        {   B,   N,   N,   T,   N,   B,   N,   N },
        {   T,   N,   N,   N,   R, T|L,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   R, B|L,   N,   N,   N,   N,   B,   N },
        {   N,   T,   N,   N,   N,   N, T|R,   L },
        {   N,   N,   N,   N,   R,   L,   N,   N },
    };
    private int[,] mTileWallAD = {
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   B,   N,   N,   N,   N,   N, B|R,   L },
        { T|R,   L,   N,   N,   N,   N,   T,   B },
        {   N,   N,   N,   N,   R, B|L,   N,   T },
        {   N,   N,   B,   N,   N,   T,   N,   N },
        {   N,   R, T|L,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   R,   L,   N,   N,   N },
    };

    private int[,] mTileWallBA = {
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
    };
    private int[,] mTileWallBB = {
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
    };
    private int[,] mTileWallBC = {
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
    };
    private int[,] mTileWallBD = {
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
    };

    // Use this for initialization
    void Start () {
        GameObject[] originals = {
            GameObject.Find("TileWhite"),
            GameObject.Find("TileRedSun"),
            GameObject.Find("TileRedVenus"),
            GameObject.Find("TileRedSaturn"),
            GameObject.Find("TileRedStar"),
            GameObject.Find("TileBlueSun"),
            GameObject.Find("TileBlueVenus"),
            GameObject.Find("TileBlueSaturn"),
            GameObject.Find("TileBlueStar"),
            GameObject.Find("TileYellowSun"),
            GameObject.Find("TileYellowVenus"),
            GameObject.Find("TileYellowSaturn"),
            GameObject.Find("TileYellowStar"),
            GameObject.Find("TileGreenSun"),
            GameObject.Find("TileGreenVenus"),
            GameObject.Find("TileGreenSaturn"),
            GameObject.Find("TileGreenStar"),
            GameObject.Find("TileWhite"),
            GameObject.Find("TileWhite")
        };
        int[][] offsets = new int[4][] {
            new int[] { -40, -40 },
            new int[] { -40,  40 },
            new int[] {  40, -40 },
            new int[] {  40,  40 }
        };
        int[][,] maps = new int[4][,] {
            mTileMapAA,
            mTileMapAB,
            mTileMapAC,
            mTileMapAD
        };
        for (int i = 0; i < 4; ++i) {
            for (int y = 0; y < 8; ++y) {
                for (int x = 0; x < 8; ++x) {
                    GameObject copied = Object.Instantiate(originals[maps[i][y, x]]) as GameObject;
                    copied.transform.Translate(y * 10 + offsets[i][0], 0, x * 10 + offsets[i][1]);
                    copied.SetActive(true);
                }
            }
        }

        for (int i = 0; i < originals.Length; ++i) {
            originals[i].SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
