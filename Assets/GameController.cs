using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    private const int FIELD_SIZE = 8;

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
        {   B,   N,   T,   N,   N,   N,   N, T|B },
        {   T,   N,   N,   N,   N,   N,   R, T|L },
    };
    private int[,] mTileWallAB = {
        {   N,   R,   L,   N,   N,   B,   N,   N },
        {   N,   N,   N,   N,   N, T|R,   L,   N },
        {   N,   B,   N,   N,   N,   N,   N,   N },
        {   R, T|L,   N,   N,   N,   N,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   B },
        {   N,   N,   N,   N,   N,   N,   N,   T },
        {   B,   N, B|R,   L,   N,   R, B|L,   N },
        { T|R,   L,   T,   N,   N,   N,   T,   N },
    };
    private int[,] mTileWallAC = {
        {   N,   N,   N,   N,   N,   N,   R, B|L },
        {   N,   N,   N, B|R,   L,   N,   N,   T },
        {   B,   N,   N,   T,   N,   B,   N,   N },
        {   T,   N,   N,   N,   R, T|L,   N,   N },
        {   N,   N,   N,   N,   N,   N,   N,   N },
        {   R, B|L,   N,   N,   N,   N,   B,   N },
        {   N,   T,   N,   N,   N,   N, T|R,   L },
        {   N,   N,   N,   N,   R,   L,   N,   N },
    };
    private int[,] mTileWallAD = {
        { B|R,   L,   N,   N,   N,   N,   N,   N },
        { T|B,   N,   N,   N,   N,   N, B|R,   L },
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

    private enum RobotColor {
        Red = 0,
        Blue,
        Yellow,
        Green,
        Max
    };

    // Use this for initialization
    void Start () {
        int[][] offsets = new int[4][] {
            new int[] { -75, -75 },
            new int[] { -75,   5 },
            new int[] {   5, -75 },
            new int[] {   5,   5 }
        };
        int[][,] tmaps = new int[4][,] {
            mTileMapAA,
            mTileMapAB,
            mTileMapAC,
            mTileMapAD
        };
        createTiles(tmaps, offsets);
        int[][,] wmaps = new int[4][,] {
            mTileWallAA,
            mTileWallAB,
            mTileWallAC,
            mTileWallAD
        };
        createWalls(wmaps, offsets);
    }

    private bool createTiles(int[][,] maps, int[][] offsets) {
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
            GameObject.Find("TileUnused")
        };
        for (int i = 0; i < 4; ++i) {
            for (int y = 0; y < FIELD_SIZE; ++y) {
                for (int x = 0; x < FIELD_SIZE; ++x) {
                    GameObject copied = Object.Instantiate(originals[maps[i][y, x]]) as GameObject;
                    copied.transform.Translate(y * 10 + offsets[i][0], 0, x * 10 + offsets[i][1]);
                    copied.SetActive(true);
                }
            }
        }

        for (int i = 0; i < originals.Length; ++i) {
            originals[i].SetActive(false);
        }

        System.Random random = new System.Random();
        int[,] robots = new int[FIELD_SIZE, FIELD_SIZE];
        for (int y = 0; y < FIELD_SIZE; ++y) {
            for (int x = 0; x < FIELD_SIZE; ++x) {
                robots[y, x] = 0;
            }
        }
        const int robotNum = (int)RobotColor.Max;
        for (int i = 0; i < robotNum; ++i) {
            do {
                int x = random.Next(FIELD_SIZE);
                int y = random.Next(FIELD_SIZE);
                if (robots[y, x] == 0) {
                    robots[y, x] = i;
                    break;
                }
            } while (true);
        }
        return true;
    }

    private bool createWalls(int[][,] maps, int[][] offsets) {
        GameObject original = GameObject.Find("Wall");
        for (int i = 0; i < 4; ++i) {
            for (int y = 0; y < FIELD_SIZE; ++y) {
                for (int x = 0; x < FIELD_SIZE; ++x) {
                    if (maps[i][y, x] > N) {                        
                        if ((maps[i][y, x] & B) > 0) {
                            GameObject copied = Object.Instantiate(original) as GameObject;
                            copied.transform.Translate(y * 10 + offsets[i][0] + 5, 0, x * 10 + offsets[i][1]);
                            copied.transform.Rotate(0, 90, 0);
                            copied.SetActive(true);
                        }
                        if ((maps[i][y, x] & T) > 0) {
                            GameObject copied = Object.Instantiate(original) as GameObject;
                            copied.transform.Translate(y * 10 + offsets[i][0] - 5, 0, x * 10 + offsets[i][1]);
                            copied.transform.Rotate(0, 90, 0);
                            copied.SetActive(true);
                        }
                        if ((maps[i][y, x] & L) > 0) {
                            GameObject copied = Object.Instantiate(original) as GameObject;
                            copied.transform.Translate(y * 10 + offsets[i][0], 0, x * 10 + offsets[i][1] - 5);
                            copied.SetActive(true);
                        }
                        if ((maps[i][y, x] & R) > 0) {
                            GameObject copied = Object.Instantiate(original) as GameObject;
                            copied.transform.Translate(y * 10 + offsets[i][0], 0, x * 10 + offsets[i][1] + 5);
                            copied.SetActive(true);
                        }
                    }
                }
            }
        }

        original.SetActive(false);
        return true;
    }

    private class Point {
        private int x;
        private int y;

        public Point() {
            this.x = 0;
            this.y = 0;
        }
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public int X {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y {
            get { return this.y; }
            set { this.y = value; }
        }
    };
    private Point[] searchRoute(int[][,] maps, int[][,] walls, int[,] robots) {
        return null;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
