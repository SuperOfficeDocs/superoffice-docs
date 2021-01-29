---
title: osql_join
description: SuperOffice Objectified SQL - JOIN
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: concept
---

# Joins

You may need to use **joins** in database queries very often. The example below shows how the following SQL query is converted to SuperOffice Objectified SQL.

You can add joins to the `JoinRestriction` property of the query.

## Example 1

A simple join on the `associate_id` field in the tables `associate` and `contact`:

```SQL
SELECT T0.associate_id, T1.category_idx, T0.lastlogin, T0.lastlogout
FROM CRM5.associate T0, CRM5.contact T1
WHERE (T0.associate_id = T1.associate_id)
AND(T0.associate_id = 5)
```

```csharp
SoConnection _con = null;
SoCommand _cmd = null;

_con = ConnectionFactory.GetConnection();
_cmd = _con.CreateCommand();
_con.Open();

AssociateTableInfo a = TablesInfo.GetAssociateTableInfo(); 

ContactTableInfo c = TablesInfo.GetContactTableInfo();
Select select = S.NewSelect();
// The fields to see
select.ReturnFields.Add( a.AssociateId, c.CategoryIdx, a.Lastlogin, a.Lastlogout );
select.Restriction = a.AssociateId.Equal( c.AssociateId).And( a.AssociateId.Equal( S.Parameter( 5 ) ) );
_cmd.SqlCommand = select;

SoDataReader reader = _cmd.ExecuteReader();
bool hasData = reader.Read();
reader.Close();

Assert.IsTrue( hasData, "There are data in the associate table" );

_con.Close();
_con = null;
_cmd = null;
```

## Example 2

This example has a join between `associate_id` in 3 different tables: associate, selection, and contact.

```SQL
SELECT T0.associate_id, T1.category_idx, T2.name
FROM CRM.associate T0, CRM.contact T1, selection T2
WHERE (T0.associate_id = T1.associate_id)
AND(T1.associate_id = T2.associate_id)
```

```csharp
SoConnection _con = null;
SoCommand _cmd = null;

_con = ConnectionFactory.GetConnection();
_cmd = _con.CreateCommand();
_con.Open();

AssociateTableInfo a = TablesInfo.GetAssociateTableInfo(); 
ContactTableInfo c = TablesInfo.GetContactTableInfo();
SelectionTableInfo s = TablesInfo.GetSelectionTableInfo();

Select select = S.NewSelect();
// The fields to see
select.ReturnFields.Add( a.AssociateId, c.CategoryIdx,s.Name );
// The restriction
select.Restriction = a.AssociateId.Equal( c.AssociateId).And( c.AssociateId.Equal( s.AssociateId ) );
_cmd.SqlCommand = select;

SoDataReader reader = _cmd.ExecuteReader();
bool hasData = reader.Read();
reader.Close();

Assert.IsTrue( hasData, "There are data in the associate table" );

_con.Close();
_con = null;
_cmd = null;
```

See Also: SoConnection SoCommand TablesInfo Select SoDataReader
