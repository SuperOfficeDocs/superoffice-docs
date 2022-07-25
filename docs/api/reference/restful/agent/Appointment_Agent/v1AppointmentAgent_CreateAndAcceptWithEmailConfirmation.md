---
title: POST Agents/Appointment/CreateAndAcceptWithEmailConfirmation
id: v1AppointmentAgent_CreateAndAcceptWithEmailConfirmation
---

# POST Agents/Appointment/CreateAndAcceptWithEmailConfirmation

```http
POST /api/v1/Agents/Appointment/CreateAndAcceptWithEmailConfirmation
```

Creating an appointment from an emailItem invitation and accepting it with email confirmation to the meeting organizer.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateAndAcceptWithEmailConfirmation?$select=name,department,category/id
```

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request

EmailItemId, UpdateMode

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailItemId | int32 |  |
| UpdateMode | string |  |

## Response

| Response | Description |
|----------------|-------------|
| 204 | No Content |
