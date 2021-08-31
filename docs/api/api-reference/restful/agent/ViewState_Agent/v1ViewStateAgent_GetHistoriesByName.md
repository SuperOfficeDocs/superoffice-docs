---
title: GetHistoriesByName
id: v1ViewStateAgent_GetHistoriesByName
---

# GetHistoriesByName

```http
POST /api/v1/Agents/ViewState/GetHistoriesByName
```

Returns the named history list that belong to the currently logged in user







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ViewState/GetHistoriesByName?$select=name,department,category/id
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

HistoryName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| HistoryName | string |  |


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
POST /api/v1/Agents/ViewState/GetHistoriesByName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HistoryName": "Ankunding Inc and Sons"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Rank": 429,
    "Id": 802,
    "HistoryName": "Johnston-Tillman",
    "HistoryId": 84,
    "AssociateId": 921,
    "Name": "Lesch, Veum and Jacobs",
    "ItemInfo": "excepturi",
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
        "FieldLength": 64
      }
    }
  }
]
```