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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Name": "Ledner Group",
  "ForceFlatList": true,
  "AdditionalInfo": "et",
  "HistoryItems": [
    303,
    323
  ],
  "OnlyHistory": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 257,
    "Name": "Toy, Grady and Toy",
    "ToolTip": "Alias aliquam quis qui accusantium libero eum.",
    "Deleted": false,
    "Rank": 468,
    "Type": "amet",
    "ColorBlock": 905,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "1997-04-08T18:28:49.48509+02:00",
    "ChildItems": [
      {
        "Id": 545,
        "Name": "Botsford-Buckridge",
        "ToolTip": "Autem aliquam at repellat eum nam.",
        "Deleted": true,
        "Rank": 647,
        "Type": "alias",
        "ColorBlock": 426,
        "IconHint": "doloribus",
        "Selected": false,
        "LastChanged": "1996-08-08T18:28:49.48509+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "soluta",
        "StyleHint": "adipisci",
        "Hidden": false,
        "FullName": "Alvena Quigley",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 836
          }
        }
      }
    ],
    "ExtraInfo": "ex",
    "StyleHint": "perspiciatis",
    "Hidden": true,
    "FullName": "Cydney Durgan",
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
        "FieldLength": 942
      }
    }
  }
]
```