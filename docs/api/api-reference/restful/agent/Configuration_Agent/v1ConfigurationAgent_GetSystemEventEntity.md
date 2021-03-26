---
title: POST Agents/Configuration/GetSystemEventEntity
id: v1ConfigurationAgent_GetSystemEventEntity
---

# POST Agents/Configuration/GetSystemEventEntity

```http
POST /api/v1/Agents/Configuration/GetSystemEventEntity
```

Gets a SystemEventEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| systemEventEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetSystemEventEntity?systemEventEntityId=227
POST /api/v1/Agents/Configuration/GetSystemEventEntity?$select=name,department,category/id
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



Carrier object for SystemEventEntity.
Services for the SystemEventEntity Carrier is available from the <see cref="!:IConfigurationAgent">Configuration Agent</see>.

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

## Sample Request

```http!
POST /api/v1/Agents/Configuration/GetSystemEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 840,
  "Scope": "Database",
  "Eta": "1998-10-02T16:48:29.0158979+02:00",
  "Eventkey": "sit",
  "Eventmess": "iure",
  "ExtraInfo": 4,
  "Owner": 25,
  "UpdatedCount": 530,
  "Registered": "2017-01-31T16:48:29.0158979+01:00",
  "ActivatedBy": {
    "AssociateId": 403,
    "Name": "Cronin-Turner",
    "PersonId": 673,
    "Rank": 720,
    "Tooltip": "molestias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 160,
    "FullName": "Dr. Pinkie Kihn",
    "FormalName": "Little-Gleichner",
    "Deleted": true,
    "EjUserId": 268,
    "UserName": "Bauch, White and Hahn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 459
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
      "FieldLength": 767
    }
  }
}
```