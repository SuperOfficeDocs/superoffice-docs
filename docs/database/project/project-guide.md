---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: project_guide       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Guided project # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Guided project

In 7.1 we introduce the Project Guide, for project stages, activities, and milestones. There are some [new datebase fields][1] to support this functionality.

![ProjectGuide][img1]

The `project.type_idx` says if the project is guided or not:

Use your favorite query tool and try this query:

```SQL
 SELECT * FROM projtype WHERE hasGuide = 1
```

Now locate all guided projects in the database with this query:

```SQL
SELECT * FROM project WHERE type_idx in (SELECT projtype_id FROM projtype WHERE hasGuide = 1)
```

![ProjectTable][img2]

If a project is guided it will also have several statuses, if you know the `project_id` you may check the current status:

```SQL
SELECT * FROM projStatus WHERE projstatus_id = (SELECT status_idx FROM project WHERE project_id = 29)
```

![ProjectStatusCurrent][img3]

The different stages defined for a projects different statuses is found in the ProjectTypeStatusLink table:

```SQL
SELECT * FROM projecttypestatuslink WHERE projtype_id = (SELECT type_idx FROM project WHERE project_id = 29)
```

![ProjTypeStatusLink][img4]

The different status names are found in table `ProjeStatus`:

```SQL
SELECT * FROM PROJSTATUS WHERE ProjStatus_id IN 
    (SELECT ProjStatus_id FROM PROJECTTYPESTATUSLINK WHERE projType_id = 4)
```

![ProjStatus][img5]

The different tasks defined for a projects different statuses is found in the ProjectTypeStatusLink table:

```SQL
SELECT * FROM suggestedappointment WHERE projectTypeStatusLinkId = 2
```

![SuggestedAppointment][img6]

The different tasks defined for a projects different statuses is found in the ProjectTypeStatusLink table:

```SQL
SELECT * FROM suggesteddocument WHERE projectTypeStatusLinkId = 2
```

![SuggestedDocument][img7]

<!-- Referenced links -->
[1]: ../whats-new/changes-70-71.md

<!-- Referenced images -->
[img1]: media/project-guide.png
[img2]: media/project-table.png
[img3]: media/projectstatus-current.png
[img4]: media/projtypestatuslink.png
[img5]: media/projstatus.png
[img6]: media/suggested-appointment.png
[img7]: media/suggested-document.png
