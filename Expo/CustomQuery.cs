using System;
using System.Data;
using System.Data.Common;
using MacroScope;
using Glaze;

namespace Seminar
{
    public class CustomQuery
    {
        public QueryExpression MakeQueryExpression(GlazeConnection cnn,
            string sourceCommandText)
        {
            // not allowing multiple SELECT clauses (does anybody need them?),
            // but shouldn't be that difficult to generalize...
            MacroScopeParser parser = Factory.CreateParser(sourceCommandText);
            return parser.queryExpression();
        }

        public GlazeCommand MakeSchemaQuery(GlazeConnection cnn,
            QueryExpression queryExpression)
        {
            QueryExpression schemaQuery = (QueryExpression)(queryExpression.Clone());
            schemaQuery.Top = 1;
            schemaQuery.Distinct = false;

            GlazeCommand schemaCmd = (GlazeCommand)(cnn.CreateCommand());
            schemaCmd.Statement = new SelectStatement(schemaQuery);
            return schemaCmd;
        }
    }
}
