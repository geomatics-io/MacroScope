using System;
using System.Data;
using System.Data.Common;

namespace Glaze
{
    /// <summary>
    /// Interface for <see cref="GlazeConnection"/> used by
    /// <see cref="GlazeCommand"/>.
    /// </summary>
    internal interface IGlazeConnection
    {
        DbConnection Inner { get; }
    }
}
