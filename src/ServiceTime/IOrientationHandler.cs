using System;

namespace ServiceTime
{
    public interface IOrientationHandler
    {
        void ForceLandscape();

        void ForcePortrait();
    }
}
