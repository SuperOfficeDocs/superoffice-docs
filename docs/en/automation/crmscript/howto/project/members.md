---
uid: crmscript-project-members
title: Project members
description: How to work with project members in CRMScript.
keywords: CRMScript, project, project member, ProjectAgent
author: Bergfrid Skaara Dias
date: 05.31.2023
version: 9
content_type: howto
redirect_from: /en/project/howto/crmscript/members
---

# Project members

A project always has a project manager or owner. In addition, it can have (and usually has) project members.

> [!TIP]
> Read about [working with persons][1].

## View project member info

```crmscript!
Integer projectMemberId = 9;
NSProjectAgent agent;
NSProjectMember member = agent.GetProjectMember(projectMemberId);

printLine(member.GetFullName());
```

## List project members

### NSProjectMember[] GetProjectMembers(Integer projectId)

```crmscript!
Integer projectId = 1;
NSProjectAgent agent;
NSProjectMember[] memberList = agent.GetProjectMembers(projectId);

foreach (NSProjectMember m in memberList) {
  printLine(m.GetLastname());
}
```

### NSProjectMember[] GetProjectMembersById(Integer[] projectIds)

```crmscript!
NSProjectAgent agent;

Integer[] projectIds;
projectIds.pushBack(1);
projectIds.pushBack(3);
projectIds.pushBack(42);

NSProjectMember[] memberList = agent.GetProjectMembersById(projectIds);
```

### Get members from current project

```crmscript
NSProjectAgent agent;
NSProjectEntity p = agent.GetProjectEntity(1);
NSProjectMember[] memberList = p.GetProjectMembers();
```

## Register a member

```crmscript!
NSProjectAgent agent;
NSProjectMember member = agent.CreateDefaultProjectMember();

member.SetPersonId(7);
member.SetProjectId(4);
member.SetProjectMemberTypeId(2);

member = agent.SaveProjectMember(member);

printLine(member.GetProjectmemberId().toString());
```

### List available roles

```crmscript!
SearchEngine se;
se.addFields("PMembType", "PMembType_id,name");
print(se.executeTextTable());
```

## Add members to project

`AddProjectMembers()` will connect 1 or more project members to a project.

```crmscript
NSProjectAgent agent;
NSProjectMember member = agent.GetProjectMember(4);

Integer projectId = 1;

NSProjectMember[] memberList;
memberList.pushBack(member);

agent.AddProjectMembers(projectId, memberList);
```

## Update a member

To update a member, you have to get the member, set the appropriate values, and then call `UpdateProjectMember()`.

```crmscript
NSProjectAgent agent;
NSProjectMember member = agent.GetProjectMember(5);
member.SetProjectMemberTypeId(3);
member = agent.UpdateProjectMember(member);
```

## Delete members

### Void DeleteProjectMemberByIds(Integer[] projectMemberIds)

```crmscript
NSProjectAgent agent;

Integer[] memberIds;
memberIds.pushBack(5);
memberIds.pushBack(17);
memberIds.pushBack(23);

agent.DeleteProjectMemberByIds(memberIds);
```

### Void DeleteProjectMembers(Integer projectId, Integer[] memberIds)

Removes members from a selected project.

```crmscript
NSProjectAgent agent;

Integer[] memberIds;
memberIds.pushBack(5);

agent.DeleteProjectMembers(8,memberIds);
```

## Reference

### NSProjectMember

| Field            | Get method               | Description        |
|:-----------------|:-------------------------|:-------------------|
| projectmember_id | GetProjectmemberId()     | ID                 |
| project_id       | GetProjectId()           | project            |
| mtype_idx        | GetProjectMemberTypeId() | role (member type) |
| person_id        | GetPersonId()            | ID of person       |

For a complete list of fields, see the [database reference][2].

<!-- Referenced links -->
[1]: ../contact/index.md
[2]: ../../../../database/tables/projectmember.md
