---
title: SetActivityStatus
id: v1AppointmentAgent_SetActivityStatus
---

# SetActivityStatus

```http
POST /api/v1/Agents/Appointment/SetActivityStatus
```

Sets the completed status for an array of activities.

The string activityIdentifier param may contain of a mix of appointment_id, sale_id, document_id and todo_id. The changes are saved immediately. If an invalid id is passed in (nonexistent record), no changes will be made. If there is no write access to the record being changed, a Sentry exception will be thrown in the usual manner.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/SetActivityStatus?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

ActivityIdentifier, ActivityStatus 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ActivityIdentifier | array |  |
| ActivityStatus | string |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |