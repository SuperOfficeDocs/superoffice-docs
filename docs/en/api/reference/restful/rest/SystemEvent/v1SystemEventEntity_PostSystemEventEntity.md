---
title: POST SystemEvent
uid: v1SystemEventEntity_PostSystemEventEntity
---

# POST SystemEvent

```http
POST /api/v1/SystemEvent
```

Creates a new SystemEventEntity


Calls the Configuration agent service SaveSystemEventEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/SystemEvent?$select=name,department,category/id
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

## Request Body: newEntity 

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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/SystemEvent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 290,
  "Scope": "Database",
  "Eta": "2008-12-27T11:22:45.225579+01:00",
  "Eventkey": "ut",
  "Eventmess": "nobis",
  "ExtraInfo": 376,
  "Owner": 535,
  "UpdatedCount": 269,
  "Registered": "2010-07-22T11:22:45.225579+02:00",
  "ActivatedBy": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 531,
  "Scope": "Database",
  "Eta": "2020-03-08T11:22:45.225579+01:00",
  "Eventkey": "aut",
  "Eventmess": "blanditiis",
  "ExtraInfo": 113,
  "Owner": 789,
  "UpdatedCount": 82,
  "Registered": "2018-07-01T11:22:45.225579+02:00",
  "ActivatedBy": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 765
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```