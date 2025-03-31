namespace ExploringTheNet.SessionThree.AppClass;

public class StudentIndexer {
    public string[] nameList;

    public StudentIndexer(int maxSize) {
        nameList = new string[maxSize];
    }

    // Defining an indexer - <modifier> <return type> this [argument list]
    public string this[int index] {
        get { return nameList[index]; }
        set { nameList[index] = value; }
    }
}
