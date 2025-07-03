---
title: Open Follow-up
uid: sop-open-follow-up
description: How to create a Follow-up using the soprotocol
author: Eivind Fasting
date: 11.26.2024
keywords: soprotocol, follow-up, open
content_type: howto
redirect_from: /en/ui/soprotocol/open-appointment-dialog
---

# Open follow-up

The soprotocol should be on the format: ```soprotocol:appointment.main?appointment_id={{id}}```

## How to open the follow-up dialog

The following example shows how to open an Follow-up dialog in the current context based on a given `appointment_id`: `appointment_id = 124`. If the current context is displaying the company page, the follow-up dialog will appear over the company page.

```soprotocol:appointment.main?appointment_id=124```

![in-context-screenshot][img1]

To view the follow-up in the context of the diary, use SoProtocol to navigate to the diary page and then use the appointment_id to view the day where the follow-up appears.

```soprotocol:diary.main?appointment_id=124```

![diary-context-screenshot][img2]

<!-- Referenced images -->
[img1]: ../media/appointment-default.png
[img2]: ../media/appointment-diary.png
