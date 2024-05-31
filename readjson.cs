public class ReadFromJson : MonoBehaviour
{
    public static string filename = "Assets/Json/data.json";
    public static Question[] CreateArrayOfQuestions()
    {
        string jsonstr = File.ReadAllText(filename);
        return JsonUtility.FromJson<Questions>(jsonstr).questions;
    }

    [System.Serializable]
    public class Question
    {
        public string sentence;
    }

    [System.Serializable]
    public class Questions
    {
        public Question[] questions;
    }
}
