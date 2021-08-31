---
title: POST Person/{id}/MoveTo/{id}
id: v1PersonEntity_Move
---

# POST Person/{id}/MoveTo/{id}

```http
POST /api/v1/Person/{personId}/MoveTo/{destinationContactId}
```

Move a person to a specified contact.

You must specify the date after which activities will be moved along with the person.




| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | The identifier for the person **Required** |
| destinationContactId | int32 | The identifier for the contact which the person will be moved to **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| moveAfterDate | date-time | **Required** Move activites after this date. Activities before this date are left alone. |

```http
POST /api/v1/Person/{personId}/MoveTo/{destinationContactId}?moveAfterDate=02/25/2000 15:05:44
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |