using System;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using SpaceCore.Events;


namespace Lanturnalis.Stardew.Starlight
{

    public class ModEntry : Mod
    {

        public override void Entry(IModHelper helper)
        {
            
            Helper.Events.Input.ButtonPressed += this.OnDebugPressed;
            SpaceEvents.OnBlankSave += this.OnBlankSave;
        }

        private void OnBlankSave(object sender, EventArgs e) {
            this.Monitor.Log("OnBlankSave Detected");
        }
        
        private void OnDebugPressed(object sender, ButtonPressedEventArgs e)
        {
            if(e.Button == SButton.F10) {
                this.Monitor.Log("Debug button pressed");
            }
        }
    }
}