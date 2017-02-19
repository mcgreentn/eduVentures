using System.Collections;
using System.Collections.Generic;

public class GameStats {
    public static string EnemyName;
    public static SubjectType EnemySubject;
    public static int EnemyID;
    public static string LastScene;
    public static int BattleWon;

    public static float Munnie;

    public static Dictionary<string, bool> Beaten = new Dictionary<string, bool>();
    public static bool Init = false;

    public static bool CanMove = true;

    public static int GameMode = 0;

    public static int JournalFlag = 0;
    public static int DeathFlag = 0;

    public static bool Shown;
}
