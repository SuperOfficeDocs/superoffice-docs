---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
generated: true
---

# POST Agents/Dash/GetDashCollection

```http
POST /api/v1/Agents/Dash/GetDashCollection
```

Gets a collection of dashboards for the current associate







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dash/GetDashCollection?$select=name,department,category/id
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

### Response body: DashCollection

| Property Name | Type |  Description |
|----------------|------|--------------|
| Pinned | array | Dashboards pinned to the associate |
| Favourites | array | The assocates favourite dashboards |
| Other | array | Other dashboards |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Dash/GetDashCollection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 870,
      "UniqueId": "rem",
      "Name": "Kohler-Terry",
      "Description": "Optimized 6th generation website",
      "AssociateId": 966,
      "Columns": 79,
      "Theme": null,
      "VisibleForAll": 516,
      "VisibleForAssociates": [
        68,
        327
      ],
      "VisibleForGroups": [
        807,
        550
      ],
      "PinForAll": 657,
      "PinForAssociates": [
        982,
        497
      ],
      "PinForGroups": [
        916,
        511
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 848
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 19,
      "UniqueId": "non",
      "Name": "Swift, Osinski and Considine",
      "Description": "Integrated discrete encryption",
      "AssociateId": 436,
      "Columns": 936,
      "Theme": null,
      "VisibleForAll": 152,
      "VisibleForAssociates": [
        177,
        769
      ],
      "VisibleForGroups": [
        679,
        705
      ],
      "PinForAll": 649,
      "PinForAssociates": [
        766,
        617
      ],
      "PinForGroups": [
        532,
        894
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 859
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 601,
      "UniqueId": "hic",
      "Name": "Prohaska LLC",
      "Description": "Self-enabling interactive success",
      "AssociateId": 249,
      "Columns": 71,
      "Theme": null,
      "VisibleForAll": 664,
      "VisibleForAssociates": [
        18,
        519
      ],
      "VisibleForGroups": [
        845,
        588
      ],
      "PinForAll": 257,
      "PinForAssociates": [
        49,
        310
      ],
      "PinForGroups": [
        610,
        620
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 344
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 700
    }
  }
}
```