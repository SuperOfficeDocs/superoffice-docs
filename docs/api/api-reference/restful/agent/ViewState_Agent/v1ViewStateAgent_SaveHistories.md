---
title: SaveHistories
id: v1ViewStateAgent_SaveHistories
---

# SaveHistories

```http
POST /api/v1/Agents/ViewState/SaveHistories
```

Replaces the existing history-list for the currently logged in user.

All elements must belong to the same history list. If not they are ignored.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ViewState/SaveHistories?$select=name,department,category/id
```


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

## Request Body: request  

HistoryName, History 

| Property Name | Type |  Description |
|----------------|------|--------------|
| HistoryName | string |  |
| History | array |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Rank | int32 | Sort order, indexed so it can used for sorting in the query |
| Id | int32 | Id of the history item, for instance a contact id. Represents the history table's RecordId field, if the item is based on a history table record |
| HistoryName | string | The name of the history list, for instance contact. Represents the history table's TableId field |
| HistoryId | int32 | Primary key |
| AssociateId | int32 | Owner of history list |
| Name | string | Name of the history item, for instance contact name |
| ItemInfo | string | Extra information on the history item, e.g. The Associate Type for an associate or other relevant info. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/ViewState/SaveHistories
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "HistoryName": "Haley, Turner and Anderson",
  "History": [
    {
      "Rank": 561,
      "Id": 255,
      "HistoryName": "Waelchi-Boyle",
      "HistoryId": 840,
      "AssociateId": 754,
      "Name": "Armstrong, Rogahn and Jakubowski",
      "ItemInfo": "adipisci"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Rank": 559,
    "Id": 460,
    "HistoryName": "Emard LLC",
    "HistoryId": 392,
    "AssociateId": 762,
    "Name": "Schroeder, Hartmann and McDermott",
    "ItemInfo": "velit",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 906
      }
    }
  }
]
```