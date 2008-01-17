using System;
using System.Data;
using System.Data.Common;

namespace Glaze
{
    /// <summary>
    /// Interface for <see cref="GlazeCommand"/> used by
    /// <see cref="GlazeParameterCollection"/>.
    /// </summary>
    internal interface IGlazeCommand
    {
        string DatabaseProvider { get; }

        DbCommand Inner { get; }

        bool BindByName { get; set; }

        void SetDirty();
    }
}
