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
            Window.ClearBackground(Color.Green);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // clear the screen
            //Window.ClearBackground(Color.Green);

            //Draw a circle
            // Check if mouse left is clicked
            if (Input.IsMouseButtonDown(MouseInput.Left))
            {
                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 10);
                // If it is, make circle color red
                if (Input.IsMouseButtonDown(MouseInput.Left))
                    Draw.FillColor = Color.Red;
            }

            
 
            //Draw a rectangle
            if (Input.IsMouseButtonDown(MouseInput.Right))
            {
                Draw.Rectangle(Input.GetMouseX(), Input.GetMouseY(), 25, 25);
                // If it is, make rectangle magenta
                if (Input.IsMouseButtonDown (MouseInput.Right))
                Draw.FillColor = Color.Blue;
            }

        }
    }

}
