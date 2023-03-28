using UnityEngine;

namespace Course.PrototypeScripting
{
    public static class RuntimeGlobal
    {

        public enum GameState { NormalGame, Cutscene, Conversation }
        public static GameState gameState;


        public static bool interactionBlockByInvCombination;

    

        

       

        public static void SwitchGameState(GameState newState)
        {
            if (newState == gameState)
                return;
            gameState = newState;
            switch(gameState)
            {
                case GameState.NormalGame:
                    if(UnityEngine.Camera.main.GetComponent<CamRotate>())
                        Cursor.lockState = CursorLockMode.Locked;
                    else
                        Cursor.lockState = CursorLockMode.None;
                    break;
                case GameState.Cutscene:
                    Cursor.lockState = CursorLockMode.Locked;
                    break;
                case GameState.Conversation:
                    Cursor.lockState = CursorLockMode.None;
                    break;
            }
        }

     

    }
}
