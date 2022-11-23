global using System;
global using System.Numerics;
global using Raylib_cs;
global using R = Raylib_cs.Raylib;


//fixa större fönster senare
R.InitWindow(1600, 800, "JumpMaster");
R.SetTargetFPS(60);

float screenWidth = R.GetScreenWidth();
float screenHeight = R.GetScreenHeight();

Camera2D camera = new Camera2D();
camera.target = new Vector2(screenWidth / 2, screenHeight / 2);
camera.zoom = 1f;
camera.offset = new Vector2(screenWidth / 2, screenHeight / 2);

new Player();

List<Rectangle> platforms = new List<Rectangle>();


while (!R.WindowShouldClose())
{
    Gravity.UpdateAll();

    R.BeginDrawing();
    R.BeginMode2D(camera);
    R.ClearBackground(Color.WHITE);

    Gravity.Drawall();

    R.EndMode2D();
    R.EndDrawing();
    
    // Console.WriteLine(Gravity.gravityCheck(gravity));
}