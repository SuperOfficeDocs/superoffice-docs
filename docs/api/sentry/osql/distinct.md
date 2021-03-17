---
title: sentry_distinct
description: Sentry and distinct
author: {github-id}
so.date: 11.05.2016
keywords: access control
so.topic: concept
---

# Sentry and distinct

The automatic manipulation of queries by automatically added sentries can cause unexpected side-effects, especially when the DISTINCT operator is involved.

Here is an example that shows how a join with the `ProjectMember` table is used to make a restriction on which projects are to be returned. DISTINCT has been added to avoid returning the same project twice.

The automatic sentry detector looks at all tables in the query, not just the returned fields. This causes the `ProjectMember` table to be considered, which ends up adding extra project member fields to the return fields list. This changes the result since DISTINCT now applies to a bunch of extra fields from the `ProjectMember` table.

The `ProjectMember` sentry will also add extra joins, making the query more complex. It joins in `contact` and `person` as well as adding fields required by the `Project` sentry to determine if the project member rows can be read. Person and contact sentries also add extra fields. Hence, what used to be distinct is no longer distinct.

To avoid this, we turn off automatic sentry for the `ProjectMember` table. This leaves the table alone (which is what we want) while avoiding extra joins caused by the sentry.

```SQL
SELECT DISTINCT p.* FROM Project p
INNER JOIN ProjectMember pm
ON p.ProjectId = pm.ProjectId
WHERE pm.PersonId = 20 OR p.AssociateId = 29
```

```csharp
ProjectRows.CustomSearch query = new ProjectRows.CustomSearch();
ProjectMemberTableInfo pm = TablesInfo.GetProjectMemberTableInfo();

query.IsDistinct = true;

query.Restriction = pm.PersonId.Equal( S.Parameter( 20 ) ).
                      Or( query.TableInfo.AssociateId.Equal( S.Parameter( 29 ) ) );
query.JoinRestriction.InnerJoin( query.TableInfo.ProjectId.Equal( pm.ProjectId ) );

// Auto sentry needs to be turned off for the distinct to return the right number of rows
query.AddIgnoreAutoSentryTableInfo(pm);

ProjectRows c = query;
```

## IgnoreAutoSentry

Below is an extract of the internal code showing how the project member sentry manipulates the query. This chunk of logic is turned off by the `IgnoreAutoSentry()` call.

```csharp
public class SentryQueryProjectMemberTableUpdater : ISentryQueryTableUpdater
{
  public void ModifySelect(Select sql, TableInfo tableInfo)
  {
    ProjectMemberTableInfo pm = (ProjectMemberTableInfo)tableInfo;
    ProjectTableInfo p = TablesInfo.GetProjectTableInfo();
    ContactTableInfo c = TablesInfo.GetContactTableInfo();
    PersonTableInfo pe = TablesInfo.GetPersonTableInfo();

    sql.ReturnFields.Add(
        pm.ProjectmemberId,
        pm.Registered,
        pm.RegisteredAssociateId);

    // Project relations
    RelationInfo[] projectRelations = sql.GetRelations(pm, p.Definition);
    if (projectRelations == null || projectRelations.Length == 0)
    {
      sql.JoinRestriction.InnerJoin(pm.ProjectId.Equal(p.ProjectId));
      new SentryQueryProjectTableUpdater().ModifySelect(sql, p);
    }

    // Contact relation
    RelationInfo[] contactRelations = sql.GetRelations(pm, c.Definition);
    if (contactRelations == null || contactRelations.Length == 0)
    {
      sql.JoinRestriction.LeftOuterJoin(pm.ContactId.Equal(c.ContactId));
      new SentryQueryContactTableUpdater().ModifySelect(sql, c);
    }

    // Person relation
    RelationInfo[] personRelations = sql.GetRelations(pm, pe.Definition);
    if (personRelations == null || personRelations.Length == 0)
    {
      sql.JoinRestriction.LeftOuterJoin(pm.PersonId.Equal(pe.PersonId));
      new SentryQueryPersonTableUpdater().ModifySelect(sql, pe);
    }
  }
}
```
