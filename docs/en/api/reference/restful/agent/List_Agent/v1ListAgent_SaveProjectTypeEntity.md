---
title: POST Agents/List/SaveProjectTypeEntity
uid: v1ListAgent_SaveProjectTypeEntity
generated: true
content_type: reference
---

# POST Agents/List/SaveProjectTypeEntity

```http
POST /api/v1/Agents/List/SaveProjectTypeEntity
```

Updates the existing ProjectTypeEntity or creates a new ProjectTypeEntity if the id parameter is 0.








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

## Request Body: projectTypeEntity 

The ProjectTypeEntity that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjTypeId | Integer | Primary key |
| Name | String | The list item |
| Tooltip | String | Tooltip or other description |
| Rank | Integer | Rank order |
| DurationUnit | String | Units for the duration |
| ProjectDuration | Integer | Expected duration of project, in given units |
| Deleted | Boolean | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| HasGuide | Boolean | Does this project type have a guide attached |
| IsAutoAdvance | Boolean | Does the project status advance automatically, when the last guided activity in a status is completed? |
| Stages | Array | Stages (project statuses), those associated with this ProjType are selected. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectTypeEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjTypeId | int32 | Primary key |
| Name | string | The list item |
| Tooltip | string | Tooltip or other description |
| Rank | int32 | Rank order |
| DurationUnit | string | Units for the duration |
| ProjectDuration | int32 | Expected duration of project, in given units |
| Deleted | bool | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| HasGuide | bool | Does this project type have a guide attached |
| IsAutoAdvance | bool | Does the project status advance automatically, when the last guided activity in a status is completed? |
| Stages | array | Stages (project statuses), those associated with this ProjType are selected. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/SaveProjectTypeEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjTypeId": 4,
  "Name": "Feeney, Altenwerth and Kris",
  "Tooltip": "iure",
  "Rank": 27,
  "DurationUnit": "Century",
  "ProjectDuration": 567,
  "Deleted": false,
  "HasGuide": true,
  "IsAutoAdvance": false,
  "Stages": [
    {
      "Id": 396,
      "Name": "Lind Inc and Sons",
      "ToolTip": "Fugiat similique quam eos et ut.",
      "Deleted": false,
      "Rank": 868,
      "Type": "voluptatem",
      "ColorBlock": 207,
      "IconHint": "natus",
      "Selected": false,
      "LastChanged": "2019-06-10T03:46:54.9413809+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquam",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Chadrick O'Keefe"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjTypeId": 832,
  "Name": "Turner, Hirthe and Jakubowski",
  "Tooltip": "voluptates",
  "Rank": 929,
  "DurationUnit": "Century",
  "ProjectDuration": 638,
  "Deleted": true,
  "HasGuide": false,
  "IsAutoAdvance": false,
  "Stages": [
    {
      "Id": 173,
      "Name": "Sipes Inc and Sons",
      "ToolTip": "Expedita ipsam.",
      "Deleted": true,
      "Rank": 227,
      "Type": "odio",
      "ColorBlock": 528,
      "IconHint": "dolores",
      "Selected": false,
      "LastChanged": "2005-03-15T03:46:54.9413809+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magnam",
      "StyleHint": "illo",
      "Hidden": true,
      "FullName": "Enid Ankunding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 776
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 364
    }
  }
}
```