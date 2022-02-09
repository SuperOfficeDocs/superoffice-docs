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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 546,
  "Scope": "Database",
  "Eta": "2012-11-11T18:25:51.1189368+01:00",
  "Eventkey": "pariatur",
  "Eventmess": "laboriosam",
  "ExtraInfo": 7,
  "Owner": 621,
  "UpdatedCount": 108,
  "Registered": "2010-05-08T18:25:51.1189368+02:00",
  "ActivatedBy": {
    "AssociateId": 674,
    "Name": "Fahey-Torp",
    "PersonId": 294,
    "Rank": 978,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 24,
    "FullName": "Alda Von",
    "FormalName": "Gottlieb-Herzog",
    "Deleted": true,
    "EjUserId": 757,
    "UserName": "Schumm, Abbott and Hermann"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 536,
  "Scope": "Database",
  "Eta": "2015-09-08T18:25:51.1199357+02:00",
  "Eventkey": "iure",
  "Eventmess": "aliquam",
  "ExtraInfo": 46,
  "Owner": 994,
  "UpdatedCount": 355,
  "Registered": "2000-11-30T18:25:51.1199357+01:00",
  "ActivatedBy": {
    "AssociateId": 262,
    "Name": "Schaefer LLC",
    "PersonId": 492,
    "Rank": 74,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 69,
    "FullName": "Edison Schuster MD",
    "FormalName": "Schamberger, Dach and Lubowitz",
    "Deleted": true,
    "EjUserId": 986,
    "UserName": "Pagac, Feil and Macejkovic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reintermediate cross-media experiences"
        },
        "FieldType": "System.String",
        "FieldLength": 832
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
      "FieldType": "System.String",
      "FieldLength": 211
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```