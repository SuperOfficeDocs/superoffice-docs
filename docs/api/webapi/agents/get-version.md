---
title: How to get the API version
uid: webapi_agents_get_version
description: How to get the Agents WebAPI version
author: {github-id}
keywords:
so.topic: howto
# so.envir:
# so.client:
---

# How to get the API version

You can get the version number and build-date from the **API endpoint**: `/api`

This returns a block with the supported versions and the NetServer version number.

* If you don't ask specifically, you get the HTML representation.
* If you ask for Javascript, you get the following:

```javascript
{
  "v1": "http://www.example.com/crm/api/v1",
  "NetServerVersion": "8.8.6352.1249",
  "NetServerAssembly": "8.8.0.9729",
  "NetServerDate": "2017-05-23",
  "NetServer": "SuperOffice NetServer 8.1 Stable (Build: 6352), expires in 76 days."
}
```

## Supported URLs

If you fetch the version URL, you get back a list of supported URLs: `/api/v1`

```javascript
[
  "/api/v1/Agents/Appointment/Accept",
  "/api/v1/Agents/Appointment/AcceptRejected",
  "/api/v1/Agents/Appointment/AssignTo",
  "/api/v1/Agents/Appointment/CalculateDays",
  "/api/v1/Agents/Appointment/CanAssignToProjectMember",
  "/api/v1/Agents/Appointment/CleanUpBookingDeleted",
  "/api/v1/Agents/Appointment/CleanUpRecurringBookingDeleted",
  "/api/v1/Agents/Appointment/CreateDefaultAppointmentEntity",
  ...
  "/api/v1/Appointment",
  "/api/v1/Appointment/{id}",
  "/api/v1/Appointment/{id}/Links?$select={$select}&$filter={$filter}&$orderBy={$orderBy}&$top={$top}&$skip={$skip}&$mode={$mode}&$options={$options}&$context={$context}&$format={$format}",
  "/api/v1/Appointment/{id}/Participants?$select={$select}&$filter={$filter}&$orderBy={$orderBy}&$top={$top}&$skip={$skip}&$mode={$mode}&$options={$options}&$context={$context}&$format={$format}",
  "/api/v1/Appointment/{id}/Simple",
  "/api/v1/Appointment/default",
  "/api/v1/Appointment/UdefLayout",
  ....
```

You can use this information to determine if the server supports the features you need.
