
function rollDices(){
    var randomNumber1  = Math.floor(Math.random() * 6) + 1;
    var img = "images/dice" + randomNumber1 + ".png";
    var randomNumber2  = Math.floor(Math.random() * 6) + 1;
    var img2 = "images/dice" + randomNumber2 + ".png";

    document.querySelectorAll("img")[0].setAttribute("src", img);

    document.querySelectorAll("img")[1].setAttribute("src", img2);

    WhoWins(randomNumber1, randomNumber2);
}

function WhoWins(random1, random2){
    if(random1 > random2)
        document.querySelector("h1").innerHTML = "🚩Player 1 Wins!";
    else if(random1 < random2)
        document.querySelector("h1").innerHTML = "Player 2 Wins!🚩";
    else
        document.querySelector("h1").innerHTML = "Draw!";
}