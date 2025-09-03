---
title: Configure
uid: configure_email_invitations
description: How to configure video meetings in SuperOffice
author: SuperOffice Product and Engineering
keywords: video meetings
content_type: howto
deployment: online
platform: web
---

# How to configure email invitations for video meetings

To be able to send and receive email invitations to video meetings (to/from attendees), you must have configured your email setup in SuperOffice CRM (user client) or use SuperOffice Mail Link.

## With SuperOffice Inbox

1. Configure your email setup in [SuperOffice Inbox][2].
2. To be able to send the Video Meeting URL to external users, we recommend to [edit your invitation template][3] to add the new variable {burl}.

## With SuperOffice Mail Link

1. Set the [SuperOffice Mail Link][4] preference under "Invitations": 'Add / update appointments in SuperOffice...'

This feature is currently not supported if you use [Synchronizer for SuperOffice][1] - as they don't support this yet.

<!-- Referenced links -->
[1]: https://online.superoffice.com/appstore/infobridge-software-b-v-/synchronizer-for-superoffice
[2]: ../../../docs/en/email/inbox/learn/index.md
[3]: ../../../docs/en/admin/lists/learn/add-email-template.md
[4]: ../../../docs/en/email/mail-link/learn/index.md
