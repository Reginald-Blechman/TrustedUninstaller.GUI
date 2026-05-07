using System;

namespace TrustedUninstaller.GUI.TweakDialog
{
    public interface ITweakModule
    {
        event EventHandler Completed;

        void StartOperations();

        void SetLast();

        bool IsUninstallable();
    }
}