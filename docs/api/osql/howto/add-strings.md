---
title: osql_add_strings
description: SuperOffice Objectified SQL - Add strings
author: {github-id}             # Your GitHub alias.
so.date: 11.05.2016
keywords:
so.topic: howto
---

# Adding strings

```SQL
SELECT p.Firstname + " " + p.Lastname FROM CRM.person p WHERE (p.person_id = 16) 
```

```csharp
SoConnection _con = ConnectionFactory.GetConnection();
SoCommand _cmd = _con.CreateCommand();
_con.Open();

PersonTableInfo person = TablesInfo.GetPersonTableInfo();

Select select = S.NewSelect();
Parameter spaceParam = S.Parameter( " " );
spaceParam.DataType = FieldDataType.dbString;
select.ReturnFields.Add( S.Math.NewAdd( person.Firstname, spaceParam, person.Lastname ) );
select.Restriction = person.PersonId.Equal( S.Parameter( 16 ) );
_cmd.SqlCommand = select;

SoDataReader reader = _cmd.ExecuteReader();
reader.Read();
string result = reader[0].ToString();
reader.Close();

Assert.AreEqual( "Geir Grønbeck", result , "PersonConcatination failed!" );

_con.Close();
_con = null;
_cmd = null;
```

See Also: SoConnection SoCommand TablesInfo Select SoDataReader
