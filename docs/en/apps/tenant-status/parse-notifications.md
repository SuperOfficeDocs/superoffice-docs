---
title: Parse notifications
uid: parse_status_notifications
description: Parse notifications when tenant status changes
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# Parse notifications

The application **must** take advantage of these notifications to ensure their environments are kept up-to-date with the status of SuperOffice CRM Online tenants.

While there are several ways to accomplish processing [tenant status changes notification][1], the following is a short example of what that might look like using .NET and C#.

## CustomerStateChangeNotificationType Enumeration

[!code-csharp[CS](includes/CustomerStateChangeNotificationType.cs)]

## NotificationMessage

[!code-csharp[CS](includes/NotificationMessage.cs)]

## API Controller and JWT Validation

[!code-csharp[CS](includes/ApiController.cs)]

<!-- Referenced links -->
[1]: notifications.md
