using System;

namespace TrustedUninstaller.GUI.UninstallUpdateDialog
{
    public interface IUninstallUpdateModule
    {
        event EventHandler Completed;

        void StartOperations();

        void SetLast();

        int Height();
    }
}