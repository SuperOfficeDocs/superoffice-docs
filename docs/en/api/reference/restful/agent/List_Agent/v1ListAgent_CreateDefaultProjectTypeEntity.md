---
title: POST Agents/List/CreateDefaultProjectTypeEntity
uid: v1ListAgent_CreateDefaultProjectTypeEntity
---

# POST Agents/List/CreateDefaultProjectTypeEntity

```http
POST /api/v1/Agents/List/CreateDefaultProjectTypeEntity
```

Set default values into a new ProjectTypeEntity.


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
POST /api/v1/Agents/List/CreateDefaultProjectTypeEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjTypeId": 40,
  "Name": "Kozey, Kertzmann and Hermiston",
  "Tooltip": "est",
  "Rank": 651,
  "DurationUnit": "Century",
  "ProjectDuration": 327,
  "Deleted": false,
  "HasGuide": false,
  "IsAutoAdvance": true,
  "Stages": [
    {
      "Id": 790,
      "Name": "McCullough, Howell and Daniel",
      "ToolTip": "Veniam id aliquam asperiores maxime laudantium excepturi.",
      "Deleted": false,
      "Rank": 549,
      "Type": "dolorum",
      "ColorBlock": 585,
      "IconHint": "autem",
      "Selected": false,
      "LastChanged": "2007-11-26T03:51:27.4747952+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veritatis",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Mr. Josh Lubowitz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 930
    }
  }
}
```