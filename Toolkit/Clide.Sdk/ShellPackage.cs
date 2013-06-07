using Microsoft.VisualStudio.Shell.Interop;
namespace Clide.Sdk
{
    using System;
    using System.Linq;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;

    [ProvideAutoLoad(UIContextGuids.SolutionExists)]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [ProvideMenuResource(1000, 5)]
    [Guid("10B500EC-C851-4739-9DAF-E53589678F1D")]
    [ProvideBindingPath]
    public class ShellPackage : Package
    {
    }
}