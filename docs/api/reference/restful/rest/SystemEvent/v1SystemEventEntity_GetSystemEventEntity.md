---
title: GET SystemEvent/{id}
id: v1SystemEventEntity_GetSystemEventEntity
---

# GET SystemEvent/{id}

```http
GET /api/v1/SystemEvent/{id}
```

Gets a SystemEventEntity object.

Calls the Configuration agent service GetSystemEventEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the SystemEventEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/SystemEvent/{id}?$select=name,department,category/id
```


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


## Response: object

Entity for system events



SystemEventEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SystemEventEntity found. |
| 404 | Not Found. |

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
GET /api/v1/SystemEvent/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 SystemEventEntity found.
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 342,
  "Scope": "Database",
  "Eta": "2002-10-23T18:25:51.1209366+02:00",
  "Eventkey": "qui",
  "Eventmess": "maiores",
  "ExtraInfo": 428,
  "Owner": 279,
  "UpdatedCount": 960,
  "Registered": "2015-05-20T18:25:51.1209366+02:00",
  "ActivatedBy": {
    "AssociateId": 504,
    "Name": "Hodkiewicz-Kassulke",
    "PersonId": 706,
    "Rank": 134,
    "Tooltip": "laborum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 694,
    "FullName": "Lenna Zboncak",
    "FormalName": "Davis, Hansen and Ziemann",
    "Deleted": true,
    "EjUserId": 667,
    "UserName": "Durgan, Runolfsson and Stamm",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 703
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
      "FieldLength": 48
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```