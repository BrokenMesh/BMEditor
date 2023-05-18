using BMEditor.Graphics;
using GLFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMEditor {
    public class BMEditor {

        public bool keepRunning = false;

        public static BMEditor instance;
        public BMEditor() {
            instance = this;
        }

        public void Run() {
            WindowManager.CreateWindow(1000, 1200, "BMEditor");

            while (!Glfw.WindowShouldClose(WindowManager.window)) {

                if (keepRunning) Glfw.PollEvents();
                else Glfw.WaitEvents();        

                WindowManager.ClearWindowBuffer();
                Draw();
                WindowManager.SwapBuffer();
            }

            WindowManager.CloseWindow();
        }


        public void Draw() { 
            
        }

        public void SetUpCallbacks() { 
            
        }
    }
}
