

let controller = new HelloWorld.Dnn.Dnn.HelloWorld.Services.Implementations.KérdésekController();

    function válasz(sorszam) {
    document.getElementById("question").innerHTML = controller.FindKérdésByID(sorszam).QuestionText
    document.getElementById("answear1").innerHTML =controller.FindVálaszokByQuestion(sorszam)[0].AnswerText 
    document.getElementById("answear2").innerHTML =controller.FindVálaszokByQuestion(sorszam)[1].AnswerText 
    document.getElementById("answear3").innerHTML =controller.FindVálaszokByQuestion(sorszam)[2].AnswerText 
};