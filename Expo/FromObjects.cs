using System;
using System.Data;
using System.Data.Common;
using MacroScope;
using Glaze;

namespace Seminar
{
    public class FromObjects
    {
        QueryExpression CreateSelectDistrictHead()
        {
            AliasedItem columns = MakeAliasedItem("district", "district_id");
            columns.Add(MakeAliasedItem("district", "name", "district_name"));

            Table districtTable = new Table(new Identifier("district"));

            Table districtGeoTable = new Table(new Identifier("district_tags"));
            districtGeoTable.JoinType = Join.Inner;
            districtGeoTable.JoinCondition = new Expression(
                MakeDbObject("district", "district_id"),
                ExpressionOperator.Equal,
                MakeDbObject("district_tags", "district_id"));
            districtTable.Add(districtGeoTable);

            QueryExpression queryExpression = new QueryExpression();
            queryExpression.SelectItems = columns;
            queryExpression.From = new AliasedItem(districtTable);
            return queryExpression;
        }

        QueryExpression MakeQueryExpressionForGetDistricts()
        {
            QueryExpression queryExpression = CreateSelectDistrictHead();

            queryExpression.Where = new Expression(
                MakeDbObject("district", "deleted"),
                ExpressionOperator.Equal,
                new IntegerValue(0));

            Expression orderBy = new Expression();
            orderBy.Left = MakeDbObject("district", "name");
            queryExpression.OrderBy = new OrderExpression(orderBy);

            return queryExpression;
        }

        static AliasedItem MakeAliasedItem(string table, string column)
        {
            return MakeAliasedItem(table, column, null);
        }

        static AliasedItem MakeAliasedItem(string table, string column, string alias)
        {
            DbObject dbObject = MakeDbObject(table, column);

            AliasedItem aliasedItem = new AliasedItem(dbObject);
            if (alias != null)
            {
                aliasedItem.Alias = new Identifier(alias);
            }

            return aliasedItem;
        }

        static DbObject MakeDbObject(string table, string column)
        {
            DbObject dbObject = new DbObject(new Identifier(table));
            dbObject.Add(new DbObject(new Identifier(column)));
            return dbObject;
        }
    }
}
