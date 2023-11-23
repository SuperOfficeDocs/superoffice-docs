---
title: POST Agents/MDO/GetListWithHistory
uid: v1MDOAgent_GetListWithHistory
generated: true
---

# POST Agents/MDO/GetListWithHistory

```http
POST /api/v1/Agents/MDO/GetListWithHistory
```

Method to get a MDO list with own history list.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/MDO/GetListWithHistory?$select=name,department,category/id
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

Name, ForceFlatList, AdditionalInfo, HistoryItems, OnlyHistory 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | String |  |
| ForceFlatList | Boolean |  |
| AdditionalInfo | String |  |
| HistoryItems | Array |  |
| OnlyHistory | Boolean |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The Id of the ListItem |
| Name | string | The name of the ListItem |
| ToolTip | string | The tooltip of the ListItem |
| Deleted | bool | The deleted status of the ListItem |
| Rank | int32 | The rank of the ListItem |
| Type | string | The type of the ListItem. Custom field. |
| ChildItems | array | The child items of the MDOListItem |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| FullName | string | The name of the ListItem in its context |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/MDO/GetListWithHistory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Name": "Hickle, Doyle and Gorczany",
  "ForceFlatList": true,
  "AdditionalInfo": "sint",
  "HistoryItems": [
    698,
    537
  ],
  "OnlyHistory": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 538,
    "Name": "Krajcik Inc and Sons",
    "ToolTip": "Facere et maiores.",
    "Deleted": true,
    "Rank": 643,
    "Type": "error",
    "ChildItems": [
      {
        "Id": 677,
        "Name": "Streich, Skiles and Stanton",
        "ToolTip": "Temporibus molestias et pariatur.",
        "Deleted": true,
        "Rank": 913,
        "Type": "molestiae",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "optio",
        "ColorBlock": 980,
        "ExtraInfo": "rem",
        "StyleHint": "enim",
        "FullName": "Ciara Treutel",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 842
          }
        }
      }
    ],
    "IconHint": "iusto",
    "ColorBlock": 248,
    "ExtraInfo": "dolor",
    "StyleHint": "beatae",
    "FullName": "Ms. Elliott Adams I",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 327
      }
    }
  }
]
```