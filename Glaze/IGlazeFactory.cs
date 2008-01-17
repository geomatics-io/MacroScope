using System;

namespace Glaze
{
    /// <summary>
    /// Interface for <see cref="GlazeFactory"/> used by
    /// <see cref="GlazeConnection"/>.
    /// </summary>
    internal interface IGlazeFactory
    {
        string DatabaseProvider { get; }
    }
}
