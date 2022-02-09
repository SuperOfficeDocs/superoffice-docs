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
  "SystemEventId": 879,
  "Scope": "Database",
  "Eta": "1999-11-15T18:25:51.1219432+01:00",
  "Eventkey": "in",
  "Eventmess": "perspiciatis",
  "ExtraInfo": 482,
  "Owner": 216,
  "UpdatedCount": 752,
  "Registered": "2019-10-19T18:25:51.1219432+02:00",
  "ActivatedBy": {
    "AssociateId": 709,
    "Name": "Nienow, O'Conner and Zboncak",
    "PersonId": 355,
    "Rank": 614,
    "Tooltip": "doloremque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 678,
    "FullName": "Conner Deckow",
    "FormalName": "Keebler-Ortiz",
    "Deleted": true,
    "EjUserId": 725,
    "UserName": "Lynch, Stanton and Gottlieb"
  }
}
```

```http_
HTTP/1.1 200 SystemEventEntity updated.
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 424,
  "Scope": "Database",
  "Eta": "2011-07-19T18:25:51.1229351+02:00",
  "Eventkey": "aut",
  "Eventmess": "quas",
  "ExtraInfo": 738,
  "Owner": 417,
  "UpdatedCount": 104,
  "Registered": "2013-02-06T18:25:51.1229351+01:00",
  "ActivatedBy": {
    "AssociateId": 590,
    "Name": "Weissnat Inc and Sons",
    "PersonId": 790,
    "Rank": 147,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 957,
    "FullName": "Joaquin Reilly",
    "FormalName": "Rowe, Kub and Kutch",
    "Deleted": false,
    "EjUserId": 416,
    "UserName": "Jones LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 498
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
      "FieldLength": 999
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```