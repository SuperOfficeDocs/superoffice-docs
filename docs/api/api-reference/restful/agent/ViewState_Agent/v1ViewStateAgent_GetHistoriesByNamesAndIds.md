---
title: GetHistoriesByNamesAndIds
id: v1ViewStateAgent_GetHistoriesByNamesAndIds
---

# GetHistoriesByNamesAndIds

```http
POST /api/v1/Agents/ViewState/GetHistoriesByNamesAndIds
```

Returns history data for the named entities and the given ids - which may not directly correspond to the current history records in the database.

&lt;para/&gt;Use this method if you know exactly which items you need, regardless of whether they are in the current history or not.&lt;para/&gt;The history in the database is not changed or even looked at by this method.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ViewState/GetHistoriesByNamesAndIds?$select=name,department,category/id
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

Requests 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Requests | array |  |


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
POST /api/v1/Agents/ViewState/GetHistoriesByNamesAndIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Requests": [
    {
      "EntityName": "Douglas, Stanton and Auer",
      "EntityOrParentId": 264,
      "RequestForNewRecord": true
    },
    {
      "EntityName": "Douglas, Stanton and Auer",
      "EntityOrParentId": 264,
      "RequestForNewRecord": true
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Rank": 982,
    "Id": 559,
    "HistoryName": "Crooks LLC",
    "HistoryId": 756,
    "AssociateId": 383,
    "Name": "Pfeffer, Parisian and Romaguera",
    "ItemInfo": "est",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "matrix virtual schemas"
        },
        "FieldType": "System.String",
        "FieldLength": 37
      }
    }
  }
]
```