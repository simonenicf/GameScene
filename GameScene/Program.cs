using System;
// Don't know if this is what you wanted 
namespace GameScene
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGameScene myScene = new StartGameScene();
            myScene.DoFrame(5);
        }
    }

    // Base classes
    public class GameScene
    {
       // empty for now can always add stuff for the children of this class
    }

    public class SceneRenderer
    {
        public void RenderFrames()
        {
            Console.WriteLine("frames");
            //render stuff
        }
    }

    public class SceneLogic
    {
        public void Calculate()
        {
            Console.WriteLine("1+1=2");
            //logic stuff
        }
    }

    // inherited classes
    public class StartGameScene : GameScene
    {
        // varibles
        private StartSceneRenderer startRenderer;
        private StartSceneLogic startLogic;

        public StartGameScene()
        {
            // Instantiate the classes in this class
            this.startRenderer = new StartSceneRenderer();
            this.startLogic = new StartSceneLogic();
        }

        public void DoFrame(float frametime)
        {
            // First do logic function and then renderer function
            this.startLogic.Calculate();
            this.startRenderer.RenderFrames();
        }
    }

    public class StartSceneRenderer : SceneRenderer
    {
        // inherited renderer
        // can use functions of the base class or overwrite those functions
    }

    public class StartSceneLogic : SceneLogic
    {
        // inherited logic
        // can use functions of the base class or overwrite those functions
    }
}
