public class Question {
    public string Q {get;set;}
    public string ChoiceA {get; set;}
    public string ChoiceB {get; set;}
    public string ChoiceC {get; set;}
    public string ChoiceD {get; set;}
    public string Answer  {get; set;}

    public Question(string q, string a, string b, string c, string d, string answer) {
        Q = q;
        ChoiceA = a;
        ChoiceB = b;
        ChoiceC = c;
        ChoiceD = d;
        Answer = answer;
    }

    public Question() {
        
    }
}
