---
title: POST Agents/List/CreateDefaultProjectTypeEntity
id: v1ListAgent_CreateDefaultProjectTypeEntity
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


## Response: object

Carrier object for ProjectTypeEntity.
Services for the ProjectTypeEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/List/CreateDefaultProjectTypeEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjTypeId": 251,
  "Name": "O'Reilly-Ullrich",
  "Tooltip": "eius",
  "Rank": 417,
  "DurationUnit": "Century",
  "ProjectDuration": 962,
  "Deleted": true,
  "HasGuide": true,
  "IsAutoAdvance": true,
  "Stages": [
    {
      "Id": 682,
      "Name": "Hickle-Collier",
      "ToolTip": "Nostrum occaecati et veritatis est molestias consequatur.",
      "Deleted": false,
      "Rank": 116,
      "Type": "labore",
      "ColorBlock": 840,
      "IconHint": "atque",
      "Selected": true,
      "LastChanged": "2019-12-03T18:28:49.4440902+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "placeat",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Emmy Bode",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 323
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "visualize revolutionary initiatives"
      },
      "FieldType": "System.String",
      "FieldLength": 985
    }
  }
}
```