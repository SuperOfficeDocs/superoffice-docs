---
title: POST Agents/Saint/GetStatusMonitor
uid: v1SaintAgent_GetStatusMonitor
---

# POST Agents/Saint/GetStatusMonitor

```http
POST /api/v1/Agents/Saint/GetStatusMonitor
```

Get a single status monitor based on its identity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Saint/GetStatusMonitor?$select=name,department,category/id
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

## Request Body: request  

Id 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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

## Sample request

```http!
POST /api/v1/Agents/Saint/GetStatusMonitor
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Id": 404
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "OwnerTable": 639,
  "Rank": 331,
  "DefaultTask": 629,
  "DefaultTaskText": "velit",
  "IsVisual": false,
  "LastGenerated": "1995-08-10T11:10:27.7744917+02:00",
  "Description": "Managed scalable encryption",
  "Name": "Thiel-Wolf",
  "StatusMonitorId": 823,
  "PictureId": 163,
  "NeedsUpdate": true,
  "Deleted": true,
  "NumMatches": 516,
  "NumNeedUpdate": 181,
  "GenerationStart": "1996-02-02T11:10:27.7744917+01:00",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 893
    }
  }
}
```