var RightAnswer = "";
var QuizStarted = false;
var Counter = 0;
var localCounter = 0;
var Points = 0;
var Questions = [];
var Question1 = {Question: "Hvilken af følgende symbol/navn-kombination af grundstoffer er forkert?",
                 A: "C/carbon",
                 B: "N/nitrogen",
                 C: "F/fluor",
                 D: "B/barium",
                 RightAnswer: "D"
                };
var Question2 = {Question: "En terning med sider på 30 mm har en masse på 108 gram. Hvad er densiteten i g/cm3?",
                 A: "0,004",
                 B: "4",
                 C: "12",
                 D: "36",
                 RightAnswer: "B"
                };

Questions.push(Question1);
Questions.push(Question2);

function OnLoad()
{
    
}



function SetQuestion(){
    if(Counter != (Questions.length))
    {
        var element = document.getElementById("question");
        element.innerHTML = Questions[Counter].Question;
        document.getElementById("A").innerHTML = Questions[Counter].A;
        document.getElementById("B").innerHTML = Questions[Counter].B;
        document.getElementById("C").innerHTML = Questions[Counter].C;
        document.getElementById("D").innerHTML = Questions[Counter].D;
        RightAnswer = Questions[Counter].RightAnswer;
        Counter++;
    }
    else
    {
        window.open ('Index.html','_self',false)    
    }
}

function StartQuiz(){ 
    QuizStarted = true;
    document.getElementById("startbtn").style.display = "None";
    SetQuestion();
}

function HandleAnswer(answer){
    
    if (RightAnswer == answer)
                return 0;
            if (localCounter == 0)
            {
                localCounter++;
                return 2;
            }
            if (localCounter == 1)
            {
                localCounter++;
                return 2;
            }
            if (localCounter == 2)
            {
                localCounter = 0;
                return 4;
            }
            return 0;
}

function UpdatePointField(point){
    var PointField = document.getElementById("Pointdiv").innerHTML;
    PointField = Points + parseFloat(PointField);
    document.getElementById("Pointdiv").innerHTML = PointField;
}

function HandleA(){
    if(QuizStarted)
        {
    Points = HandleAnswer("A"); 
    UpdatePointField(Points);
    if(Points == 4 || Points == 0)
    {
        localCounter = 0;
        SetQuestion();
    }
        }
}

function HandleB(){
    if(QuizStarted)
        {
    Points = HandleAnswer("B"); 
    UpdatePointField(Points);
    if(Points == 4 || Points == 0)
    {
        localCounter = 0;
        SetQuestion();
    }
        }
}

function HandleC(){
    if(QuizStarted)
        {
    Points = HandleAnswer("C");
    UpdatePointField(Points);
    if(Points == 4 || Points == 0)
    {
        localCounter = 0;
        SetQuestion();
    }
        }

}

function HandleD(){
    if(QuizStarted)
        {
    Points = HandleAnswer("D"); 
    UpdatePointField(Points);
    if(Points == 4 || Points == 0)
    {
        localCounter = 0;
        SetQuestion();
    }
        }
}

