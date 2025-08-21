---
title: Find contact by udef
uid: find_contact_by_udef
description: Find a contact using a user-defined field
author: Bergfrid Skaara Dias
date: 11.05.2021
keywords: udef, user-defined field, custom field, API, FindAgent, GetSpecifiedCriteriaInformationWithDefaults
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/custom-objects/udef/howto/services/find-contact-by-udef
  - /en/api/netserver/web-services/howto/custom-objects/find-contact-by-udef
---

# Find a contact using a udef field

This example creates the criteria directly on the client and saves and executes the find in one call.

> [!NOTE]
> The code examples on this page use the nuget SOAP proxies, [SuperOffice.NetServer.Services][2].

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists
using(SoSession.Authenticate( "SAL1", "" ))
{
  using(FindAgent agent = new FindAgent())
  {
    string[] fields = new string[1] { "contactUdef/SuperOffice:1" };
    ArchiveRestrictionInfo[] restrictions = agent.GetSpecifiedCriteriaInformationWithDefaults( "Criteria", "findcontact", "associate=12345", fields, null ).Restrictions;
    restrictions[0].Values = new string[1] { "s" };
    restrictions[0].IsActive = true
    FindResults find = agent.FindFromRestrictions( restrictions, "findcontact", 50, 0 );
    DumpResult( find.ArchiveColumns, find.ArchiveRows );
  }
}
```

> [!NOTE]
> [DumpResult()][1] is a private helper method that you can easily add to your code.

<!-- Referenced links -->
[1]: ../../../search/ifindagent/dump-result.md
[2]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
