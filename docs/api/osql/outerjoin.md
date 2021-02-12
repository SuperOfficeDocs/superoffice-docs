---
title: osql_join_outer
description: SuperOffice Objectified SQL - RIGHT OUTER JOIN
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# SuperOffice Objectified SQL - RIGHT OUTER JOIN

You may need to use **joins** in database queries very often. The examples below show how the following SQL query is converted to SuperOffice Objectified SQL.

You can add joins to the `JoinRestriction` property of the query. Here, we have used the `RightOuterJoin`. Similarly, all the other types of joins can be added to the query.

## Example 1

```SQL
SELECT p.Firstname, p.Lastname, a.Associate_Id, a.Name
FROM CRM.associate a RIGHT OUTER JOIN CRM.person p
ON (p.Person_Id = a.Person_Id)
WHERE (p.Firstname LIKE 'F%' OR p.Lastname LIKE 'E%')
```

```csharp
SoConnection _con = ConnectionFactory.GetConnection();
SoCommand _cmd = _con.CreateCommand();
_con.Open();
PersonTableInfo p = TablesInfo.GetPersonTableInfo();
AssociateTableInfo a = TablesInfo.GetAssociateTableInfo();
Select select = S.NewSelect();
select.ReturnFields.Add( p.Firstname );
select.ReturnFields.Add( p.Lastname );
select.ReturnFields.Add( a.AssociateId );
select.ReturnFields.Add( a.Name );
select.JoinRestriction.RightOuterJoin( p.PersonId.Equal( a.PersonId ), p.Firstname.Like("F%").Or(p.Lastname.Like("E%")) );
_cmd.SqlCommand = select;
SoDataReader reader = _cmd.ExecuteReader();
reader.Close();
_con.Close();
_con = null;
_cmd = null;
```

## Example 2

```SQL
SELECT COUNT(d.appointment_id) FROM CRM.document d
RIGHT OUTER JOIN CRM.appointment a ON a.appointment_id = d.appointment_id RIGHT OUTER JOIN CRM.text t ON d.text_id = t.text_id
```

```csharp
using SuperOffice.Data;
using SuperOffice.CRM.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession newSession = SoSession.Authenticate ("SAL0", ""))
{
  //Create a new connection
  SoConnection connection = ConnectionFactory.GetConnection ();
  SoCommand command = connection.CreateCommand ();
  connection.Open ();
  AppointmentTableInfo a = TablesInfo.GetAppointmentTableInfo ();
  TextTableInfo t = TablesInfo.GetTextTableInfo ();
  DocumentTableInfo d = TablesInfo.GetDocumentTableInfo ();
  Select select = S.NewSelect ();
  select.ReturnFields.Add(S.FieldExpression.Count(d.AppointmentId));
  //a Right Outer Join d where a.AppointmentId = d.AppointmentId
  select.JoinRestriction.RightOuterJoin (a.AppointmentId.Equal(d.AppointmentId));
  //d Right Outer Join t where d.TextId = t.TextId
  select.JoinRestriction.RightOuterJoin (d.TextId.Equal(t.TextId));
  command.SqlCommand = select;
  SoDataReader reader = command.ExecuteReader ();
  while(reader.Read ())
    listBox1.Items.Add (reader [0].ToString ());
  reader.Close ();
  connection.Close ();
}
```

See Also: SoConnection SoCommand TablesInfo Select SoDataReader
