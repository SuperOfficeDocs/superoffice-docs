---
title: Invitation Archive
uid: invitation_archive
description: Invitation Archive
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: diary, calendar, appointment, API, entity, ArchiveAgent, ArchiveRestrictionInfo, GetArchiveListByColumns, ArchiveListItem, ArchiveColumnData
so.topic: howto
# so.envir:
# so.client:
---

# Invitation Archive

```csharp
using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;
using(SoSession.Authenticate("SAL1" , ""))
{
  using(ArchiveAgent agent = new ArchiveAgent())
  {
    // columns: status icon, date, meeting text, name/department of company, full name of person
    string[] columns = new string[] { "invitationStatusIcon", "date", "text", "contact/nameDepartment", "person/fullName" };

    // order by: date, descending
    ArchiveOrderByInfo orderBy = new ArchiveOrderByInfo( "date", OrderBySortType.DESC );

    // restriction: associateId happens to be mandatory for this provider. Use current associate id as a good example
    ArchiveRestrictionInfo assocRestriction = 
      new ArchiveRestrictionInfo( "associateId", "=", SoContext.CurrentPrincipal.AssociateId.ToString() );

    // entities - what do we want to see. Here: everything. Leave out one or more to get rid of that kind of invitation
    string[] desiredEntities = new string[] { "invitation", "cancelled", "rejected", "repeating", "response" }; // that's all of them

    // get first page, max 50 rows, of the matching invitations
    ArchiveListItem[] carrier = agent.GetArchiveListByColumns( "Invitation", columns,
      new ArchiveOrderByInfo[] { orderBy },
      new ArchiveRestrictionInfo[] { assocRestriction },
      desiredEntities, 0, 50 );

    // for each row of the result...
    foreach( ArchiveListItem row in carrier)
    {
      // extract and display the displayValue of each cell
      // (you need to parse culturally sensitive values such as dates to get the correct client display format)
      foreach( ArchiveColumnData cell in row.ColumnData.Values )
        Console.Write( cell.DisplayValue + "\t" );
      Console.WriteLine();
    }
  }
}
```
