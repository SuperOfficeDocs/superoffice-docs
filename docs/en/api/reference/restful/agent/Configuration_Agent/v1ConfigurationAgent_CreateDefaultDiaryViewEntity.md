---
title: POST Agents/Configuration/CreateDefaultDiaryViewEntity
uid: v1ConfigurationAgent_CreateDefaultDiaryViewEntity
generated: true
content_type: reference
---

# POST Agents/Configuration/CreateDefaultDiaryViewEntity

```http
POST /api/v1/Agents/Configuration/CreateDefaultDiaryViewEntity
```

Loading default values into a new DiaryViewEntity.








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

### Response body: TimeZoneData

| Property Name | Type |  Description |
|----------------|------|--------------|
| DiaryViewId | int32 |  |
| Name | string |  |
| Tooltip | string |  |
| VisibleColumns | int32 |  |
| Rank | int32 |  |
| AssocId | int32 |  |
| AssociateList | array |  |
| TzLocationId | int32 |  |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Configuration/CreateDefaultDiaryViewEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 890,
  "Name": "Lynch, Carter and Schulist",
  "Tooltip": "nam",
  "VisibleColumns": 168,
  "Rank": 131,
  "AssocId": 352,
  "AssociateList": [
    {
      "Id": 786,
      "Name": "Luettgen-Kilback",
      "ToolTip": "Ut cumque aut ut similique iure quisquam.",
      "Deleted": false,
      "Rank": 945,
      "Type": "eum",
      "ColorBlock": 925,
      "IconHint": "animi",
      "Selected": false,
      "LastChanged": "2023-02-27T11:24:47.7189228+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eaque",
      "StyleHint": "doloremque",
      "Hidden": true,
      "FullName": "Dr. Lafayette Schumm Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 707
        }
      }
    }
  ],
  "TzLocationId": 495,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 225
    }
  }
}
```