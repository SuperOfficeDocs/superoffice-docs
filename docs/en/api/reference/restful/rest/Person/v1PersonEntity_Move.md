---
title: POST Person/{id}/MoveTo/{id}
uid: v1PersonEntity_Move
generated: true
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
POST /api/v1/Person/{personId}/MoveTo/{destinationContactId}?moveAfterDate=03/22/2013 13:38:18
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Person/{personId}/MoveTo/{destinationContactId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```