---
title: POST Agents/Saint/CreateDefaultStatusMonitor
id: v1SaintAgent_CreateDefaultStatusMonitor
---

# POST Agents/Saint/CreateDefaultStatusMonitor

```http
POST /api/v1/Agents/Saint/CreateDefaultStatusMonitor
```

Set default values into a new StatusMonitor.

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

## Response: object

Definition of all properties for a status monitor

Carrier object for StatusMonitor.
Services for the StatusMonitor Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ISaintAgent">Saint Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| OwnerTable | int32 | Id of table that owns the status monitor |
| Rank | int32 | Priority rank, in case more than one status is signalled. Lowest wins |
| DefaultTask | int32 | "Default task type for this status; the default task text is in the text table (since it can be long), and may contain template variables" |
| DefaultTaskText | string | Default task text for this status |
| IsVisual | bool | Should the status be visualized (active) in the client |
| LastGenerated | date-time | When was this status last generated (i.e., statusValue rows created) |
| Description | string | Description of the status monitor |
| Name | string | Name of status monitor |
| StatusMonitorId | int32 | Primary key |
| PictureId | int32 | Id of BinaryObject row that contains image for status monitor |
| NeedsUpdate | bool | Is the definition dirty, ie., ALL values are invalid until a recalculation; this flag is set when the status DEFINITION is changed, as opposed to the flag on StatusValue |
| Deleted | bool | Deleted flag, 1 if this record is deleted (never from the database) |
| NumMatches | int32 | Number of targets that have this status, this should be the number of rows in StatusValue pointing to this definition, and that have isSignalled set to 1 |
| NumNeedUpdate | int32 | Number of targets that had this status, but have their needsUpdate bit set due to some change |
| GenerationStart | date-time | When was the last regeneration started |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Saint/CreateDefaultStatusMonitor
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 935,
  "Rank": 159,
  "DefaultTask": 694,
  "DefaultTaskText": "est",
  "IsVisual": true,
  "LastGenerated": "2019-03-21T18:28:50.0387083+01:00",
  "Description": "Stand-alone intangible functionalities",
  "Name": "Hilll-Feil",
  "StatusMonitorId": 792,
  "PictureId": 444,
  "NeedsUpdate": true,
  "Deleted": false,
  "NumMatches": 231,
  "NumNeedUpdate": 273,
  "GenerationStart": "2012-12-20T18:28:50.0387083+01:00",
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
      "FieldLength": 394
    }
  }
}
```
