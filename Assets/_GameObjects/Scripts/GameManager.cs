using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private static int points = 0;
    private static int level = 1;
    private static int lives = 2;
    public static readonly string RECORD1 = "record1";
    public static readonly string RECORD2 = "record2";
    public static readonly string RECORD3 = "record3";
    public static readonly string LAST_RECORD = "lastRecord";

    public static void AddPoints(int _points)
    {
        points = points + _points;
    }
    public static void AddLive(int _lives)
    {
        lives = lives + _lives;
    }

    public static int Level {
        get {
            return level;
        }

        set {
            level = value;
        }
    }

    public static int Lives {
        get {
            return lives;
        }

        set {
            lives = value;
        }
    }

    public static int Points {
        get {
            return points;
        }

        set {
            points = value;
        }
    }
}
