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
  "ProjTypeId": 976,
  "Name": "Schultz Inc and Sons",
  "Tooltip": "quos",
  "Rank": 212,
  "DurationUnit": "Century",
  "ProjectDuration": 424,
  "Deleted": false,
  "HasGuide": true,
  "IsAutoAdvance": false,
  "Stages": [
    {
      "Id": 673,
      "Name": "Beahan, Considine and Brown",
      "ToolTip": "Omnis laudantium qui delectus vero nisi quam voluptas.",
      "Deleted": false,
      "Rank": 323,
      "Type": "adipisci",
      "ColorBlock": 615,
      "IconHint": "adipisci",
      "Selected": false,
      "LastChanged": "2017-05-09T11:24:48.1876539+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Cathryn Holly Ernser Jr."
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjTypeId": 233,
  "Name": "Stamm Group",
  "Tooltip": "voluptas",
  "Rank": 591,
  "DurationUnit": "Century",
  "ProjectDuration": 145,
  "Deleted": false,
  "HasGuide": true,
  "IsAutoAdvance": true,
  "Stages": [
    {
      "Id": 917,
      "Name": "Gaylord LLC",
      "ToolTip": "Quas dolorum est iure eum voluptatibus.",
      "Deleted": false,
      "Rank": 58,
      "Type": "officiis",
      "ColorBlock": 456,
      "IconHint": "quae",
      "Selected": true,
      "LastChanged": "1999-11-04T11:24:48.1876539+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "suscipit",
      "StyleHint": "velit",
      "Hidden": false,
      "FullName": "Antoinette Okuneva",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 783
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 846
    }
  }
}
```