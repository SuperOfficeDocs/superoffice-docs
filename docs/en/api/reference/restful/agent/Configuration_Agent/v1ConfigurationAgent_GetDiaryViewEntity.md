---
title: POST Agents/Configuration/GetDiaryViewEntity
uid: v1ConfigurationAgent_GetDiaryViewEntity
generated: true
---

# POST Agents/Configuration/GetDiaryViewEntity

```http
POST /api/v1/Agents/Configuration/GetDiaryViewEntity
```

Gets a DiaryViewEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| diaryViewEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetDiaryViewEntity?diaryViewEntityId=108
POST /api/v1/Agents/Configuration/GetDiaryViewEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Configuration/GetDiaryViewEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 562,
  "Name": "Runte-Nolan",
  "Tooltip": "ratione",
  "VisibleColumns": 428,
  "Rank": 586,
  "AssocId": 848,
  "AssociateList": [
    {
      "Id": 319,
      "Name": "Kassulke-Ullrich",
      "ToolTip": "Non mollitia nesciunt sunt earum est.",
      "Deleted": true,
      "Rank": 217,
      "Type": "culpa",
      "ColorBlock": 288,
      "IconHint": "similique",
      "Selected": false,
      "LastChanged": "1998-09-26T13:38:13.2802712+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "numquam",
      "Hidden": false,
      "FullName": "Ervin Torp",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    }
  ],
  "TzLocationId": 41,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 35
    }
  }
}
```