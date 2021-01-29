---
title: osql_sentry
description: SuperOffice Objectified SQL - Sentry
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# Sentry

A **Sentry** is automatically added when you query on entity tables such as `contact` or `project`. You can ask this sentry about your permission to access the various fields you get back.

```csharp
SoSession _session;
SoConnection _con = null;
SoCommand _cmd = null;
_session = SoSession.Authenticate("SAL1","");
_con = ConnectionFactory.GetConnection();
_cmd = _con.CreateCommand();
_con.Open();

ContactTableInfo c = TablesInfo.GetContactTableInfo();  //the contact table
OwnerContactLinkTableInfo own = TablesInfo.GetOwnerContactLinkTableInfo();

Select select = S.NewSelect();
// The fields we want to see
select.ReturnFields.Add( c.ContactId, c.Name, c.AssociateId, c.CountryId, c.CategoryIdx, c.BusinessIdx );
select.JoinRestriction.InnerJoin( c.ContactId.Equal( own.ContactId ) );
_cmd.SqlCommand = select;

SoDataReader reader = _cmd.ExecuteReader();
bool isReadable = false;
bool isWriteable= false;
bool isInsable  = false;
bool isDelable  = false;
bool isNameWrite= false;
// reading db owner
bool isOk = reader.Read();
Assert.IsTrue( isOk, "There is an owner contact and it's readable" );
_contId  = reader.GetInt32(0);
_assocId = reader.GetInt32(2);
isReadable = reader.Sentries.CanTableDo( TablesInfo.GetContactTableInfo(), ETableRight.Select);
isWriteable= reader.Sentries.CanTableDo( TablesInfo.GetContactTableInfo(), ETableRight.WRITE );
isInsable  = reader.Sentries.CanTableDo( TablesInfo.GetContactTableInfo(), ETableRight.Insert );
isDelable  = reader.Sentries.CanTableDo( TablesInfo.GetContactTableInfo(), ETableRight.Delete );
isNameWrite= reader.Sentries.CanFieldDo( c.Name, EFieldRight.Write );
reader.Close();
Assert.IsTrue( isReadable, "The owner contact data is readable" );
Assert.IsTrue( isWriteable, "The owner contact data is updateable" );
Assert.IsTrue( isInsable, "The owner contact data is insertable" );
Assert.IsFalse( isDelable, "The owner contact data is not deleteable" );
Assert.IsFalse( isNameWrite, "The owner contact name is not writeable" );

_con.Close();
_con = null;
_cmd = null;
_session.Close();
```
