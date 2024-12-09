---
title: Open Project
uid: open-project-more
description: How to create a Project using the soprotocol
author: Eivind Fasting
date: 11.26.2024
keywords: soprotocol, project
topic: howto
---

# Open Project

The soprotocol should be on the format: ```soprotocol:project.main?project_id={{id}}```

## Open Project with project_id equals 1000

```soprotocol:project.main?project_id=1000```

## Open Project and display more

```soprotocol:project.udef?project_id=1```

Here, *project* is the target panel, and *udef* is the target upper tab view.

![01][img1]

## Open Project and display links and project members

```soprotocol:project.links.projectmembersarchive?project_id=1```

This link opens the project page displaying the links tab above and the project members grid tab below:

```http://localhost/SuperOfficeWeb/default.aspx?project.links.projectmembersarchive```

![02][img2]

<!-- Referenced images -->
[img1]: ../media/project-udef.png
[img2]: ../media/project-note-projectmembersarchive.png