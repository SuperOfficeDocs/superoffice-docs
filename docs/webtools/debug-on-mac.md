---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: debug_webtools_on_mac       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Debug WebTools for Mac # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Debug WebTools for Mac

To get a WebTools for Mac log file for further troubleshooting:

1. Click **Go** then **Library**.

![imagewukx.png][img1]

2. Navigate to **Application Support** folder then **SuperOffice Web Tools**. Then create a new text file without an extension, call it debug and move it to the folder **SuperOffice Web Tools**. Restart WebTools.

![imagew1mo6.png][img2]

3. Open a **Console**

![imagelzq97.png][img3]

4. In the console dialog search field fill in **SuperOffice** and click **Save**. The information should be saved in the debugging file. If it doesn’t, select all the entries and right-click and click copy then paste it in the debugging file.

![imagedo4c.png][img4]

<!-- Referenced images -->
[img1]: media/imagewukx.png
[img2]: media/imagew1mo6.png
[img3]: media/imagelzq97.png
[img4]: media/imagedo4c.png
