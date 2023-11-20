---
title: POST Agents/Saint/SaveStatusMonitor
uid: v1SaintAgent_SaveStatusMonitor
generated: true
---

# POST Agents/Saint/SaveStatusMonitor

```http
POST /api/v1/Agents/Saint/SaveStatusMonitor
```

Updates the existing StatusMonitor or creates a new StatusMonitor if the id parameter is empty








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

The StatusMonitor to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| OwnerTable | Integer | Id of table that owns the status monitor |
| Rank | Integer | Priority rank, in case more than one status is signalled. Lowest wins |
| DefaultTask | Integer | "Default task type for this status; the default task text is in the text table (since it can be long), and may contain template variables" |
| DefaultTaskText | String | Default task text for this status |
| IsVisual | Boolean | Should the status be visualized (active) in the client |
| LastGenerated | String | When was this status last generated (i.e., statusValue rows created) |
| Description | String | Description of the status monitor |
| Name | String | Name of status monitor |
| StatusMonitorId | Integer | Primary key |
| PictureId | Integer | Id of BinaryObject row that contains image for status monitor |
| NeedsUpdate | Boolean | Is the definition dirty, ie., ALL values are invalid until a recalculation; this flag is set when the status DEFINITION is changed, as opposed to the flag on StatusValue |
| Deleted | Boolean | Deleted flag, 1 if this record is deleted (never from the database) |
| NumMatches | Integer | Number of targets that have this status, this should be the number of rows in StatusValue pointing to this definition, and that have isSignalled set to 1 |
| NumNeedUpdate | Integer | Number of targets that had this status, but have their needsUpdate bit set due to some change |
| GenerationStart | String | When was the last regeneration started |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: StatusMonitor

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Saint/SaveStatusMonitor
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 841,
  "Rank": 861,
  "DefaultTask": 342,
  "DefaultTaskText": "consequatur",
  "IsVisual": false,
  "LastGenerated": "2017-04-10T13:38:14.0615788+02:00",
  "Description": "Stand-alone coherent solution",
  "Name": "McClure-Rempel",
  "StatusMonitorId": 484,
  "PictureId": 800,
  "NeedsUpdate": false,
  "Deleted": true,
  "NumMatches": 476,
  "NumNeedUpdate": 590,
  "GenerationStart": "2005-05-24T13:38:14.0615788+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 742,
  "Rank": 438,
  "DefaultTask": 54,
  "DefaultTaskText": "sed",
  "IsVisual": false,
  "LastGenerated": "2000-04-06T13:38:14.0615788+02:00",
  "Description": "Automated interactive circuit",
  "Name": "Gibson Group",
  "StatusMonitorId": 433,
  "PictureId": 352,
  "NeedsUpdate": false,
  "Deleted": false,
  "NumMatches": 811,
  "NumNeedUpdate": 739,
  "GenerationStart": "2004-01-04T13:38:14.0615788+01:00",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 678
    }
  }
}
```