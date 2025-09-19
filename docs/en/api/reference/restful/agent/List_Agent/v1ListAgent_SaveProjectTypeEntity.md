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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjTypeId": 815,
  "Name": "Schuppe LLC",
  "Tooltip": "explicabo",
  "Rank": 934,
  "DurationUnit": "Century",
  "ProjectDuration": 44,
  "Deleted": false,
  "HasGuide": false,
  "IsAutoAdvance": true,
  "Stages": [
    {
      "Id": 387,
      "Name": "Wintheiser-Hudson",
      "ToolTip": "Aut numquam voluptatibus.",
      "Deleted": false,
      "Rank": 394,
      "Type": "numquam",
      "ColorBlock": 266,
      "IconHint": "consequuntur",
      "Selected": false,
      "LastChanged": "2010-07-18T03:41:53.6213534+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Ayden Kirlin Jr."
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjTypeId": 686,
  "Name": "Larkin-Bruen",
  "Tooltip": "velit",
  "Rank": 549,
  "DurationUnit": "Century",
  "ProjectDuration": 703,
  "Deleted": true,
  "HasGuide": false,
  "IsAutoAdvance": true,
  "Stages": [
    {
      "Id": 297,
      "Name": "Larson Group",
      "ToolTip": "Nulla reprehenderit nemo amet dolorum saepe beatae.",
      "Deleted": true,
      "Rank": 831,
      "Type": "est",
      "ColorBlock": 49,
      "IconHint": "quis",
      "Selected": true,
      "LastChanged": "2011-12-04T03:41:53.6213534+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iste",
      "StyleHint": "voluptatem",
      "Hidden": true,
      "FullName": "Ms. Eloise Morar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 447
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 284
    }
  }
}
```