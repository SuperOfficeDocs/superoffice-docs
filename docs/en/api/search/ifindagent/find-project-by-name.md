---
title: Find a project, returning the name
uid: find_project_by_name
description: Find a project, returning the name
author: SuperOffice Product and Engineering
date: 06.24.2016
keywords:
content_type: howto
redirect_from: /en/api/netserver/search/ifindagent/find-project-by-name
---

# Find a project, returning the name

This example saves the criteria under a particular user and then executes the find using the saved restriction.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;
using(SoSession.Authenticate( "SAL1", "" ))
{
  using(FindAgent agent = new FindAgent())
  {
    ArchiveRestrictionInfo[] restrictions = new ArchiveRestrictionInfo[1];
    restrictions[0] = new ArchiveRestrictionInfo( "name", "begins", "b" );
    agent.SaveRestrictionsAndGetCriteriaInformation( "Criteria", "findproject", "associate=1234", restrictions, new string[1] { "name" } );

    ArchiveRestrictionInfo[] indirect = new ArchiveRestrictionInfo[1];
    indirect[0] = new ArchiveRestrictionInfo( "criteriaAssociate", "=", "1234" );

    FindResults result = agent.FindFromRestrictions( indirect, "findproject", 50, 0 );
    DumpResult( result.ArchiveColumns, result.ArchiveRows );
  }
}
```

> [!NOTE]
> [DumpResult()][1] is a private helper method that you can easily add to your code.

<!-- Referenced links -->
[1]: dump-result.md
