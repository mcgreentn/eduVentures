public class NPC {
    public string Name {get; set;}
    public SubjectType Subject {get;set;}

    public NPC(string name, SubjectType subject) {
        Name = name;
        Subject = subject;
    }
}
