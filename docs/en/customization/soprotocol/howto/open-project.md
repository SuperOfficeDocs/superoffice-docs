---
uid: sop-open-project-more
title: Open Project
description: How to open a Project using the soprotocol
keywords: soprotocol, project
author: Eivind Fasting
date: 11.26.2024
content_type: howto
category: customization
topic: soprotocol
redirect_from: /en/ui/soprotocol/howto/open-project
language: en
---

# Open project

The soprotocol should be on the format: ```soprotocol:project.main?project_id={{id}}```

## Open project with ID = 1000

```soprotocol:project.main?project_id=1000```

## Open project and display more

```soprotocol:project.udef?project_id=1```

Here, *project* is the target panel, and *udef* is the target upper tab view.

![01 -screenshot][img1]

## Open project and display links and project members

```soprotocol:project.links.projectmembersarchive?project_id=1```

This link opens the Project page displaying the Links tab above and the project members grid tab below:

```http://localhost/SuperOfficeWeb/default.aspx?project.links.projectmembersarchive```

![02 -screenshot][img2]

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/soprotocol-project-udef.png
[img2]: ../../../../media/loc/en/customization/soprotocol-project-note-projectmembersarchive.png
