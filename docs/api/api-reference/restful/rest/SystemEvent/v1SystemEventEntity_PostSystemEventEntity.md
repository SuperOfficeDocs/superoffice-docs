---
title: POST SystemEvent
id: v1SystemEventEntity_PostSystemEventEntity
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


## Response: object

Entity for system events



SystemEventEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/SystemEvent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 135,
  "Scope": "Database",
  "Eta": "1998-12-19T09:40:59.7610668+01:00",
  "Eventkey": "eum",
  "Eventmess": "explicabo",
  "ExtraInfo": 365,
  "Owner": 964,
  "UpdatedCount": 804,
  "Registered": "2009-07-31T09:40:59.7610668+02:00",
  "ActivatedBy": {
    "AssociateId": 205,
    "Name": "McClure, Okuneva and Wyman",
    "PersonId": 743,
    "Rank": 611,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 99,
    "FullName": "Angeline Grimes Sr.",
    "FormalName": "Jaskolski-Pollich",
    "Deleted": false,
    "EjUserId": 450,
    "UserName": "Rodriguez-Roob"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 861,
  "Scope": "Database",
  "Eta": "2009-03-26T09:40:59.7620662+01:00",
  "Eventkey": "provident",
  "Eventmess": "et",
  "ExtraInfo": 248,
  "Owner": 794,
  "UpdatedCount": 184,
  "Registered": "2001-05-03T09:40:59.7620662+02:00",
  "ActivatedBy": {
    "AssociateId": 928,
    "Name": "Leuschke Inc and Sons",
    "PersonId": 259,
    "Rank": 744,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 762,
    "FullName": "Brayan Nienow Sr.",
    "FormalName": "Daugherty, Hayes and Batz",
    "Deleted": true,
    "EjUserId": 708,
    "UserName": "Gusikowski, Towne and Stroman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 591
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 607
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```