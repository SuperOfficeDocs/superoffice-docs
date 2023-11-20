---
title: PUT SystemEvent/{id}
uid: v1SystemEventEntity_PutSystemEventEntity
generated: true
---

# PUT SystemEvent/{id}

```http
PUT /api/v1/SystemEvent/{id}
```

Updates the existing SystemEventEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SystemEventEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/SystemEvent/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The SystemEventEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SystemEventId | Integer | Primary key |
| Scope | String | 1 = system-wide, 2= database, 3 = group, 4 = user |
| Eta | String | Estimated Time of Arrival, i.e., when will this event finish? |
| Eventkey | String | Event key, predefined in code |
| Eventmess | String | Message to be shown, entered by administrator |
| ExtraInfo | Integer | Extra information (area id for prototype rebuild, etc) |
| Owner | Integer | 0, 0, group_id, assoc id (see over) |
| UpdatedCount | Integer | Number of updates made to this record |
| Registered | String | Registered when  in UTC. |
| ActivatedBy | Associate | The associate that first created the SystemEvent. |

## Response:

SystemEventEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | SystemEventEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: SystemEventEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| SystemEventId | int32 | Primary key |
| Scope | string | 1 = system-wide, 2= database, 3 = group, 4 = user |
| Eta | date-time | Estimated Time of Arrival, i.e., when will this event finish? |
| Eventkey | string | Event key, predefined in code |
| Eventmess | string | Message to be shown, entered by administrator |
| ExtraInfo | int32 | Extra information (area id for prototype rebuild, etc) |
| Owner | int32 | 0, 0, group_id, assoc id (see over) |
| UpdatedCount | int32 | Number of updates made to this record |
| Registered | date-time | Registered when  in UTC. |
| ActivatedBy | Associate | The associate that first created the SystemEvent. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/SystemEvent/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 539,
  "Scope": "Database",
  "Eta": "2022-04-23T13:38:17.6711737+02:00",
  "Eventkey": "deleniti",
  "Eventmess": "id",
  "ExtraInfo": 59,
  "Owner": 64,
  "UpdatedCount": 297,
  "Registered": "2010-12-22T13:38:17.6711737+01:00",
  "ActivatedBy": null
}
```

## Sample response

```http_
HTTP/1.1 200 SystemEventEntity updated.
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 967,
  "Scope": "Database",
  "Eta": "2017-10-13T13:38:17.6711737+02:00",
  "Eventkey": "fuga",
  "Eventmess": "fuga",
  "ExtraInfo": 853,
  "Owner": 204,
  "UpdatedCount": 427,
  "Registered": "2013-01-06T13:38:17.6711737+01:00",
  "ActivatedBy": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 977
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```