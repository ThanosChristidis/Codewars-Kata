using System;

//description

//Regular Ball Super Ball
//Create a class Ball.

//Ball objects should accept one argument for "ball type" when instantiated.

//If no arguments are given, ball objects should instantiate with a "ball type" of "regular."

//ball1 = new Ball();
//ball2 = new Ball("super");

//ball1.ballType     //=> "regular"
//ball2.ballType     //=> "super"

    class Program
    {

    }
    public class Ball
    {
        public string ballType { get; set; } = "regular";
        public Ball() { }
        public Ball(string ballType)
        {
            this.ballType = ballType;
        }
    }

