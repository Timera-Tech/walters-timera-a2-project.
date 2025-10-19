// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //Set window canvas
            Window.SetTitle("Random Circle");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // clear the screen
            Window.ClearBackground(Color.Green);

            //Draw the circle

            Draw.FillColor = Color.Blue;
            Draw.LineColor = Color.Magenta;
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 25);
        }
    }

}
