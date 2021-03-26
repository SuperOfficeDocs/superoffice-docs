---
title: PUT SystemEvent/{id}
id: v1SystemEventEntity_PutSystemEventEntity
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
| 200 | SystemEventEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/SystemEvent/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 397,
  "Scope": "Database",
  "Eta": "2003-12-30T09:40:59.7630659+01:00",
  "Eventkey": "libero",
  "Eventmess": "soluta",
  "ExtraInfo": 3,
  "Owner": 320,
  "UpdatedCount": 307,
  "Registered": "1993-12-06T09:40:59.7640655+01:00",
  "ActivatedBy": {
    "AssociateId": 635,
    "Name": "Franecki-Kiehn",
    "PersonId": 533,
    "Rank": 351,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 673,
    "FullName": "Napoleon Schamberger",
    "FormalName": "Fadel Group",
    "Deleted": false,
    "EjUserId": 324,
    "UserName": "Champlin LLC"
  }
}
```

```http_
HTTP/1.1 200 SystemEventEntity updated.
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 319,
  "Scope": "Database",
  "Eta": "1998-11-27T09:40:59.7650664+01:00",
  "Eventkey": "nulla",
  "Eventmess": "mollitia",
  "ExtraInfo": 290,
  "Owner": 714,
  "UpdatedCount": 600,
  "Registered": "2020-09-14T09:40:59.7650664+02:00",
  "ActivatedBy": {
    "AssociateId": 846,
    "Name": "Herzog, Gutmann and Bahringer",
    "PersonId": 752,
    "Rank": 299,
    "Tooltip": "error",
    "Type": "AnonymousAssociate",
    "GroupIdx": 4,
    "FullName": "Dr. Anissa Leuschke",
    "FormalName": "Mann-Lebsack",
    "Deleted": true,
    "EjUserId": 285,
    "UserName": "Toy-Barton",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "generate viral networks"
        },
        "FieldType": "System.String",
        "FieldLength": 582
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
      "FieldLength": 187
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```