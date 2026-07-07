---
uid: sofo-send-and-archive
title: Send and archive
description: Send an email and automatically archive it to SuperOffice using the SuperOffice for Outlook add-in.
keywords: SuperOffice for Outlook, Outlook, send and archive, archive email, SOFO
author: Erik Lebiko, Bergfrid Dias, schildea
date: 06.16.2026
version_sofo: 2026.6.3
content_type: howto
category: integration
topic: SuperOffice for Outlook
deployment: online
platform: web
audience: person
audience_tooltip: SuperOffice CRM
language: en
index: true
---

# Send and archive

To send an email and automatically archive it to SuperOffice, follow these steps:

1. Select **New mail** in Outlook.

1. [Open SuperOffice for Outlook][1] (if not already [pinned][3]).

1. Ensure the **Archive email in SuperOffice** slider is enabled.

    ![SuperOffice for Outlook, send and archive -screenshot][img2]

    > [!NOTE]
    > Bcc to **SuperOffice Mail Archive** is required to ensure the email is archived in SuperOffice.

1. Add recipients to the **To** field. If their email is known to SuperOffice, the Company and Contact fields will auto-fill.

1. Fill in any missing information or make adjustments as needed.

1. Click **Send** to both send the email and archive it to SuperOffice.

> [!NOTE]
> The **Visible for** drop-down is only available to users whose administrator has enabled the required license.  
> For more details, see [**Admin - User Management - Visibility**][2].

## Related content

* [Archive reminder][4]
* [Work with shared mailboxes][5]

<!-- Referenced links -->
[1]: get.md#open
[2]: ../../docs/en/admin/user-management/index.md#visible
[3]: get.md#pin
[4]: archive-reminder.md
[5]: shared-mailboxes.md

<!-- Referenced images -->
[img2]: media/outlook-send-and-archive.png
