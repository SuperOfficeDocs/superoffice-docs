---
title: POST Agents/MDO/GetSelectableListWithHistory
id: v1MDOAgent_GetSelectableListWithHistory
---

# POST Agents/MDO/GetSelectableListWithHistory

```http
POST /api/v1/Agents/MDO/GetSelectableListWithHistory
```

Method to get a Selectable MDO list with own history list.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/MDO/GetSelectableListWithHistory?$select=name,department,category/id
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
| Name | string |  |
| ForceFlatList | bool |  |
| AdditionalInfo | string |  |
| HistoryItems | array |  |
| OnlyHistory | bool |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The Id of the ListItem |
| Name | string | The name of the ListItem |
| ToolTip | string | The tooltip of the ListItem |
| Deleted | bool | The deleted status of the ListItem |
| Rank | int32 | The rank of the ListItem |
| Type | string | The type of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| Selected | bool | True if the ListItem is selected |
| LastChanged | date-time | Time of last change. |
| ChildItems | array | The child items of the SelectableMDOListItem |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | bool | True if the ListItem is hidden |
| FullName | string | The name of the ListItem in its context |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/MDO/GetSelectableListWithHistory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Name": "Marks-Brown",
  "ForceFlatList": false,
  "AdditionalInfo": "reprehenderit",
  "HistoryItems": [
    935,
    882
  ],
  "OnlyHistory": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 653,
    "Name": "Thiel, Mohr and DuBuque",
    "ToolTip": "Tempore culpa.",
    "Deleted": true,
    "Rank": 902,
    "Type": "enim",
    "ColorBlock": 514,
    "IconHint": "aut",
    "Selected": false,
    "LastChanged": "2020-03-08T16:48:29.9729277+01:00",
    "ChildItems": [
      {
        "Id": 185,
        "Name": "Padberg-Lehner",
        "ToolTip": "Quia repudiandae ut ipsa quam magnam ipsam.",
        "Deleted": false,
        "Rank": 81,
        "Type": "fugiat",
        "ColorBlock": 40,
        "IconHint": "sunt",
        "Selected": true,
        "LastChanged": "2003-08-06T16:48:29.9739244+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vel",
        "StyleHint": "est",
        "Hidden": false,
        "FullName": "Claud Wisozk",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 339
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "est",
    "Hidden": false,
    "FullName": "Lamont Wintheiser",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "repurpose killer ROI"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 439
      }
    }
  }
]
```