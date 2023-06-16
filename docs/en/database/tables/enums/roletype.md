---
uid: enum-roletype
title: Enum values for RoleType
description: Lists the enum values for RoleType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# RoleType Enum

0 = employee, 1 = external user, 2 = anonymous

| Name | Value | Description |
|------|-------|-------------|
|Employee|0|Normal employee|
|ExternalUser|1|External User|
|Anonymous|2|Anonymous (implicit) users.|
|System|3|System users - sentry is bypassed for this kind of users.|

## Usage

* [Role](../role.md).roleType - User roles for role-based security, names and tooltips are in LocaleText. For more information regarding role based security, see http://techdoc.superoffice.com
