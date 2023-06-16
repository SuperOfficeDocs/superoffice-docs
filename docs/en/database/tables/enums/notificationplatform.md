---
uid: enum-notificationplatform
title: Enum values for NotificationPlatform
description: Lists the enum values for NotificationPlatform.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# NotificationPlatform Enum

Device platform. Apple, Google, Microsoft, etc.

| Name | Value | Description |
|------|-------|-------------|
|Apple|0|Device is by Apple|
|Google|1|Device is by Google|
|Microsoft|2|Device is by Microsoft|
|AppleDeveloper|3|Device is by Apple, used for development and debugging|
|AppleAdHoc|4|Device is by Apple, used for testing|
|GoogleDeveloper|5|Device is by Google, used for testing, development and debugging|

## Usage

* [PushNotificationService](../pushnotificationservice.md).DevicePlatform - Used for storing handles to user devices that should receive push notifications
