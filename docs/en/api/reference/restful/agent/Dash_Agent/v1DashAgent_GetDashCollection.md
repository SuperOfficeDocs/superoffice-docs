---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
generated: true
content_type: reference
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 48,
      "UniqueId": "omnis",
      "Name": "Rohan, Towne and Conn",
      "Description": "Balanced explicit capability",
      "AssociateId": 236,
      "Columns": 223,
      "Theme": null,
      "VisibleForAll": 911,
      "VisibleForAssociates": [
        768,
        799
      ],
      "VisibleForGroups": [
        553,
        392
      ],
      "PinForAll": 310,
      "PinForAssociates": [
        9,
        276
      ],
      "PinForGroups": [
        691,
        89
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 452
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 80,
      "UniqueId": "aut",
      "Name": "O'Conner, Barton and Mante",
      "Description": "Front-line 24/7 website",
      "AssociateId": 803,
      "Columns": 539,
      "Theme": null,
      "VisibleForAll": 579,
      "VisibleForAssociates": [
        428,
        840
      ],
      "VisibleForGroups": [
        287,
        823
      ],
      "PinForAll": 210,
      "PinForAssociates": [
        638,
        563
      ],
      "PinForGroups": [
        392,
        227
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 418
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 502,
      "UniqueId": "quam",
      "Name": "White-Green",
      "Description": "Synchronised maximized throughput",
      "AssociateId": 406,
      "Columns": 70,
      "Theme": null,
      "VisibleForAll": 965,
      "VisibleForAssociates": [
        706,
        841
      ],
      "VisibleForGroups": [
        832,
        733
      ],
      "PinForAll": 623,
      "PinForAssociates": [
        440,
        347
      ],
      "PinForGroups": [
        174,
        180
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 754
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 376
    }
  }
}
```