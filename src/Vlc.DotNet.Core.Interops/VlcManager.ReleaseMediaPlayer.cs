using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
        public void ReleaseMediaPlayer(VlcMediaPlayerInstance mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                return;
            try
            {
                GetInteropDelegate<ReleaseMediaPlayer>().Invoke(mediaPlayerInstance);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debugger.Log(0, "Exception", "Vlc.DotNet.Core.Interops.VlcManager.ReleaseMediaPlayer threw an Exception: " + ex.Message + Environment.NewLine);
            }

            finally
            {
                mediaPlayerInstance.Pointer = IntPtr.Zero;
            }
        }
    }
}
