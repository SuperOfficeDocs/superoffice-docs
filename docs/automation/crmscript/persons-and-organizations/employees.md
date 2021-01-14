---
title: crmscript-employees
description: Employees (internal)
author:
so.date:
keywords:
so.topic:
---

# Employees (internal)

The **associate** database table represents employees, resources, and other users - except for external persons.
It is an MDO list item table and has therefore not a corresponding CRMScript class.

Yet, this table is important for understanding and navigating the relationship between a person and their user account as well as the relationship between employees at the organization running the CRM system and the external parties they interact with.

You may think of associates as the missing link that connects people.

## Associate types

| Value | Type           | Description     |
|:-----:|----------------|-----------------|
| 0     | Employee       | Internal person |
| 1     | Resource       | Not a person<br />Disregard `personId` |
| 2     | Anonymous      | Not authenticated for SuperOffice |
| 4     | ExternalPerson | External person<br/>No calendar |
| 7     | Anonymous      | Unknown<br />(no person (1) + not authenticated (2) + no calendar (4) |
| 8     | NoSentry       | Has full access rights<br />The Sentry mechanism is bypassed |
| 13    | System         | System user<br />(no person (1) + no calendar (4) + full access/bypass sentry (8)|

## Frequently used values

| Db field     | Description                                |
|:-------------|:-------------------------------------------|
| associate_id | ID (primary key)                           |
| person_id    | The person                                 |
| name         | Initials, sign-in name, database user name |
| group_idx    | Primary group membership                   |
| ejuserId     | ID of the user account<br />0 if not connected to an account |

## Important timestamps

| Db field   | Description                             |
|:-----------|:----------------------------------------|
| lastlogin  | The last time the associate signed in   |
| lastlogout | The last time the associate signed out  |
| registered | When the associate was registered       |
| updated    | The last time the associate was updated |

## Resources

Resources are typically meeting rooms or equipment such as projectors.

| Db field         | Description                      |
|:-----------------|:---------------------------------|
| isLocation       | True if it represents a location |
| locationAddress  | The address, if it's a location  |

[Database reference](https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-associate.htm)
