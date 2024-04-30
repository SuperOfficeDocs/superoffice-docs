---
title: POST Agents/List/SaveProjectTypeEntity
uid: v1ListAgent_SaveProjectTypeEntity
generated: true
---

# POST Agents/List/SaveProjectTypeEntity

```http
POST /api/v1/Agents/List/SaveProjectTypeEntity
```

Updates the existing ProjectTypeEntity or creates a new ProjectTypeEntity if the id parameter is empty








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

The ProjectTypeEntity to be saved. 

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjTypeId": 526,
  "Name": "Quitzon, McCullough and Kuhn",
  "Tooltip": "dolorem",
  "Rank": 987,
  "DurationUnit": "Century",
  "ProjectDuration": 74,
  "Deleted": false,
  "HasGuide": false,
  "IsAutoAdvance": false,
  "Stages": [
    {
      "Id": 293,
      "Name": "Ernser, Marquardt and Miller",
      "ToolTip": "Molestiae dolor eaque magnam.",
      "Deleted": false,
      "Rank": 788,
      "Type": "sed",
      "ColorBlock": 152,
      "IconHint": "sunt",
      "Selected": true,
      "LastChanged": "2012-04-08T11:16:09.3659552+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "numquam",
      "Hidden": true,
      "FullName": "Yasmine Goyette"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjTypeId": 480,
  "Name": "Lueilwitz, Gleason and Ebert",
  "Tooltip": "eligendi",
  "Rank": 281,
  "DurationUnit": "Century",
  "ProjectDuration": 674,
  "Deleted": false,
  "HasGuide": false,
  "IsAutoAdvance": false,
  "Stages": [
    {
      "Id": 26,
      "Name": "Dibbert LLC",
      "ToolTip": "Voluptatum eveniet sapiente voluptas eligendi est voluptatibus molestiae.",
      "Deleted": false,
      "Rank": 705,
      "Type": "aperiam",
      "ColorBlock": 407,
      "IconHint": "soluta",
      "Selected": true,
      "LastChanged": "2019-05-23T11:16:09.3659552+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Yessenia Flatley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 347
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 359
    }
  }
}
```