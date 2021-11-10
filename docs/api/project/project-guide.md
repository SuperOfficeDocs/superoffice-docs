---
title: Project guide
uid: api_project_guide
description: How to work with project guides in SuperOffice APIs with raw SQL.
author: Bergfrid Dias
so.date: 11.05.2021
keywords: project, project management, SQL, API, project guide, projtype, hasGuide, ProjectTypeStatusLink, SuggestedAppointment, SuggestedDocument
so.topic: howto
# so.envir:
# so.client:
---

# Project guides

![Project guide -screenshot][img1]

## Does my project have a guide?

The `project.type_idx` says if the project is guided or not:

Use your favorite query tool and try this query:

```SQL
 SELECT * FROM projtype WHERE hasGuide = 1
```

Now locate all guided projects in the database with this query:

```SQL
SELECT * FROM project WHERE type_idx in (SELECT projtype_id FROM projtype WHERE hasGuide = 1)
```

| project_id | name | project_number | type_idx | status_idx | text_id | registered | registered_associate |
|---|---|---|---|---|---|---|---|
| 27 | Test flight | 10051 | 5 | 9 | 1 | 0 | 2021-11-04 11:30:00 | 1 |
| 29 | Developer portal | 10053 | 4 | 6| 5 | 283 | 2021-11-05 10:57:03 | 5 |

## Check status

If a project is guided it will also have several statuses, if you know the `project_id` you may check the current status:

```SQL
SELECT * FROM projStatus WHERE projstatus_id = (SELECT status_idx FROM project WHERE project_id = 29)
```

| ProjStatus_id | name | rank | tooltip | deleted | registered | ... |
|---|---|---|---|---|---|---|
| 6 | Implementation | 7 | Implementation | 0 | 2021-11-05 10:57:03 | |

The different stages defined for a project's different statuses are found in the `ProjectTypeStatusLink` table:

```SQL
SELECT * FROM projecttypestatuslink WHERE projtype_id = (SELECT type_idx FROM project WHERE project_id = 29)
```

| ProjectTypeStatusLink_id | projType_id | projStatus_id | rank | deleted | registered |
|---|---|---|---|---|---|
| 1 | 4 | 5 | 0 | 0 | 2021-11-05 10:57:03 |
| 2 | 4 | 6 | 0 | 0 | 2021-11-05 10:57:03 |
| 3 | 4 | 7 | 0 | 0 | 2021-11-05 10:57:03 |

The different status names are found in table `ProjeStatus`:

```SQL
SELECT * FROM PROJSTATUS WHERE ProjStatus_id IN 
    (SELECT ProjStatus_id FROM PROJECTTYPESTATUSLINK WHERE projType_id = 4)
```

| ProjStatus_id | name | rank | tooltip | deleted | registered | ... |
|---|---|---|---|---|---|---|
| 5 | Project planning | 4 | Project planning | 0 | 2021-11-05 10:57:03 | |
| 6 | Implementation | 7 | Implementation | 0 | 2021-11-05 10:57:03 | |
| 7 | Completion | 9 | Completion | 0 | 2021-11-05 10:57:03 | |

## Tasks

The different tasks defined for a project's different statuses is found in the `ProjectTypeStatusLink` table:

```SQL
SELECT * FROM suggestedappointment WHERE projectTypeStatusLinkId = 2
```

| SuggestedAppointment_id | name | rank | tooltip | projectTypeStatusLink_id | task_id | ...|
|---|---|---|---|---|---|---|
| 25 | Consultant on site | 1 | Book consultant on site to implement | 2 | 10 | |
| 26 | Call out | 2 | | 2 | 3 | |

The different tasks defined for a project's different statuses are found in the `ProjectTypeStatusLink` table:

```SQL
SELECT * FROM suggesteddocument WHERE projectTypeStatusLinkId = 2
```

| SuggestedDocument_id | name | rank | tooltip | projectTypeStatusLink_id | doctmpl_id | ...|
|---|---|---|---|---|---|---|
| 17 | Consultant work task | 1 | Project plan | 2 | 58 | |

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/project-guide.png
