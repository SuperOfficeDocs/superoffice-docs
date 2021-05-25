---
title: Upper
uid: osql_upper
description: SuperOffice Objectified SQL - Upper
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# Upper

A simple join on the `associate_id` field in the tables `associate` and `contact`:

```SQL
SELECT upper( firstname + ' ' + lastname ), firstname
FROM crm.person
WHERE person_id between 10 AND 30
ORDER BY firstname asc
```

```csharp
SoConnection _con = ConnectionFactory.GetConnection();
SoCommand _cmd = _con.CreateCommand();
_con.Open();
PersonTableInfo p = TablesInfo.GetPersonTableInfo();
Select query = S.NewSelect();
Parameter spaceParam = S.Parameter( " " );
spaceParam.DataType = FieldDataType.dbString;
query.ReturnFields.Add( S.ArgumentFunctions.Upper( S.Math.NewAdd( p.Firstname, spaceParam, p.Lastname ) ), p.Firstname );
query.Restriction = p.PersonId.Between( S.Parameter( 10 ), S.Parameter( 30 ) );
query.OrderBy.Add( p.Firstname, OrderBySortType.ASC );
_cmd.SqlCommand = query;
SoDataReader reader = _cmd.ExecuteReader();
int result = 0;
string arjan = "";      // person number 1
string cato = "";       // person number 12
string hans = "";       // person number 20
while( reader.Read() )
{
  if( result == 0 )
    arjan = Convert.ToString( reader[0] );
  if( result == 11 )
    cato = Convert.ToString( reader[0] );
  if( result == 19 )
    hans = Convert.ToString( reader[0] );
  ++result;
}
reader.Close();
Assert.AreEqual( "ARJAN ABELSEN", arjan , "Name of Arjan was wrong!" );
Assert.AreEqual( "CATO CARLSSON", cato , "Name of Cato was wrong!" );
Assert.AreEqual( "HANS HANSEN", hans , "Name of Hans was wrong!" );
Assert.AreEqual( 21, result, "Number of persons was not correct!" );
_con.Close();
_con = null;
_cmd = null;
```

See Also: SoConnection SoCommand TablesInfo Select SoDataReader Upper
