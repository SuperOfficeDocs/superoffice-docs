---
title: POST Agents/Configuration/SaveSystemEventEntity
id: v1ConfigurationAgent_SaveSystemEventEntity
---

# POST Agents/Configuration/SaveSystemEventEntity

```http
POST /api/v1/Agents/Configuration/SaveSystemEventEntity
```

Updates the existing SystemEventEntity or creates a new SystemEventEntity if the id parameter is empty








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
POST /api/v1/Agents/Configuration/SaveSystemEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 539,
  "Scope": "Database",
  "Eta": "2000-03-15T16:48:29.0069244+01:00",
  "Eventkey": "hic",
  "Eventmess": "mollitia",
  "ExtraInfo": 470,
  "Owner": 945,
  "UpdatedCount": 89,
  "Registered": "2003-06-12T16:48:29.0069244+02:00",
  "ActivatedBy": {
    "AssociateId": 422,
    "Name": "Simonis, Hilpert and Schinner",
    "PersonId": 982,
    "Rank": 401,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 477,
    "FullName": "Veronica Considine",
    "FormalName": "Rempel, Dickinson and Turner",
    "Deleted": true,
    "EjUserId": 731,
    "UserName": "Herman Inc and Sons"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 778,
  "Scope": "Database",
  "Eta": "2011-04-21T16:48:29.0069244+02:00",
  "Eventkey": "quos",
  "Eventmess": "sed",
  "ExtraInfo": 307,
  "Owner": 362,
  "UpdatedCount": 930,
  "Registered": "1999-08-03T16:48:29.0069244+02:00",
  "ActivatedBy": {
    "AssociateId": 993,
    "Name": "Greenfelder, Gorczany and Goyette",
    "PersonId": 713,
    "Rank": 683,
    "Tooltip": "nostrum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 617,
    "FullName": "Mervin Erdman",
    "FormalName": "Wiegand Group",
    "Deleted": false,
    "EjUserId": 853,
    "UserName": "Beahan, Weissnat and Armstrong",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 46
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
      "FieldLength": 644
    }
  }
}
```