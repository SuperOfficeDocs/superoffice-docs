---
title: POST Agents/Configuration/CreateDefaultSystemEventEntity
uid: v1ConfigurationAgent_CreateDefaultSystemEventEntity
---

# POST Agents/Configuration/CreateDefaultSystemEventEntity

```http
POST /api/v1/Agents/Configuration/CreateDefaultSystemEventEntity
```

Set default values into a new SystemEventEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| ActivatedBy |  | The associate that first created the SystemEvent. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Configuration/CreateDefaultSystemEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 934,
  "Scope": "Database",
  "Eta": "1996-08-22T02:49:43.8566571+02:00",
  "Eventkey": "nisi",
  "Eventmess": "aut",
  "ExtraInfo": 544,
  "Owner": 913,
  "UpdatedCount": 164,
  "Registered": "2012-07-14T02:49:43.8566571+02:00",
  "ActivatedBy": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 634
    }
  }
}
```