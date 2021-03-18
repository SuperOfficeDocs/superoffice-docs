---
uid: project_freetextsearch
title: project_freetextsearch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "project_freetextsearch" MDO List
Provider for selecting a Project.
Does keyword matching and scoring across multiple
string fields. Checks name, description, soundex fields.

User's own projects, recently added + modified projects, projects modified or created by user.
Matches on word boundaries or at start of field are scored extra highly.
<para />
Returns project items only: Id = project-id, Name = Project name, Type = "Project", IconHint="deleted_item", ExtraInfo= project-id
<para />
Completed/Done projects are marked with stylehint = "deleted_item" (but item.deleted = false)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProjectListFreetextSearchProvider">ProjectListFreetextSearchProvider</see> class.
The name of the MDO list is 'project_freetextsearch'.




## Sample Request

```http!
GET /api/v1/MDOList/project_freetextsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("project_freetextsearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|15|Prasjaakt||15|
|16|BBoBBeeBB||16|
|17|Ccocceecc||17|
|18|ddoddeedd||18|
|19|presjeekt||19|
|20|ffoffeeff||20|
|21|ggoggeegg||21|
|22|hhohheehh||22|
|23|prisjiikt||23|
|24|Jjojjeejj||24|
|25|Kkokkeekk||25|
|26|Llolleell||26|
|27|Mmommeemm||27|
|28|Nnonneenn||28|
|29|Prosjookt||29|
|30|Ppoppeepp||30|
|31|Qqoqqeeqq||31|
|32|Rrorreerr||32|
|33|Ssosseess||33|
|34|Ttotteett||34|
|35|Prusjuukt||35|


## Related MDO Lists

* "project_freetextsearchheadings"
* "project_freetextsearchheadingswithallitem"
* "project_freetextsearchheadingswithallitemwithnoselection"
* "project_freetextsearchheadingswithnoselection"
* "project_freetextsearchwithallitem"
* "project_freetextsearchwithallitemwithnoselection"
* "project_freetextsearchwithnoselection"
