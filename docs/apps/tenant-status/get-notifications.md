---
title: Get notifications
uid: get_status_notifications
description: Get notifications when tenant status changes
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# Register to get notifications when tenant status changes

When a tenant installation changes, SuperOffice sends a [change notification][2] to each approved application.

## To receive notifications (onetime set-up)

1. Set up a web service listening for state changes. For example:

    `https://www.awesomeapp.com/NotifyCustomerStateChange`

2. Notify SuperOffice about your **State Change URL**, which specifies where SuperOffice sends notifications.

    Soon, you can do this yourself in the Developer Portal.

You are now set to [parse notifications][1] when you get them.

<!-- Referenced links -->
[1]: parse-notifications.md
[2]: notifications.md
