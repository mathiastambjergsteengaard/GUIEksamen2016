RightAnswer = "D";
Counter = 0;
localCounter = 0;
Points = 0;
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

function HandleA(){
    Points = HandleAnswer("A"); 
    alert(Points);
    var PointField = document.getElementById("Pointdiv");
    var appendPoint = document.createTextNode(Points);
    PointField.appendChild(appendPoint);
    
            if(point == 4 || point == 0)
            {
                quizMaster.localCounter = 0;
                if (quizMaster.Counter != quiz.Count-1)
                {
                    quizMaster.NewQuestion(currentQuestion, quiz[++quizMaster.Counter]);
                }
                else
                {
                    var window = new EndView(Points);
                    //window.WindowState = WindowState.Maximized;
                    window.Show();
                    Close();
                }
            }
}

function HandleB(){
    Points = HandleAnswer("B"); 

}

function HandleC(){
    Points = HandleAnswer("C"); 

}

function HandleD(){
    Points = HandleAnswer("D"); 

}

