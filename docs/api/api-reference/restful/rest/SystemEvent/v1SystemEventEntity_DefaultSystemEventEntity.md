---
title: GET SystemEvent/default
id: v1SystemEventEntity_DefaultSystemEventEntity
---

# GET SystemEvent/default

```http
GET /api/v1/SystemEvent/default
```

Set default values into a new SystemEventEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Configuration agent service CreateDefaultSystemEventEntity.






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
GET /api/v1/SystemEvent/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 261,
  "Scope": "Database",
  "Eta": "2020-12-19T15:05:42.7636619+01:00",
  "Eventkey": "consequatur",
  "Eventmess": "nemo",
  "ExtraInfo": 455,
  "Owner": 387,
  "UpdatedCount": 559,
  "Registered": "1999-04-05T15:05:42.7636619+02:00",
  "ActivatedBy": {
    "AssociateId": 357,
    "Name": "Bruen, Larkin and Kuphal",
    "PersonId": 497,
    "Rank": 347,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 427,
    "FullName": "Lorena Abbott",
    "FormalName": "Wunsch LLC",
    "Deleted": false,
    "EjUserId": 595,
    "UserName": "Swaniawski Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 221
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
        "Reason": "scale bleeding-edge experiences"
      },
      "FieldType": "System.Int32",
      "FieldLength": 466
    }
  }
}
```