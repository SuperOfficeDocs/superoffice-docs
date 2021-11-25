---
title: POST Agents/List/GetListItemsForHeadingFromListName
id: v1ListAgent_GetListItemsForHeadingFromListName
---

# POST Agents/List/GetListItemsForHeadingFromListName

```http
POST /api/v1/Agents/List/GetListItemsForHeadingFromListName
```

List of list items that is selected if under this heading







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetListItemsForHeadingFromListName?$select=name,department,category/id
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

UdListDefinitionName, HeadingId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionName | string |  |
| HeadingId | int32 |  |


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
POST /api/v1/Agents/List/GetListItemsForHeadingFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Boyle Group",
  "HeadingId": 896
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 173,
    "Name": "Bashirian, Schumm and Tromp",
    "ToolTip": "Sunt enim.",
    "Deleted": true,
    "Rank": 318,
    "Type": "placeat",
    "ColorBlock": 517,
    "IconHint": "est",
    "Selected": false,
    "LastChanged": "2006-05-26T18:28:49.3281227+02:00",
    "ChildItems": [
      {
        "Id": 4,
        "Name": "Kemmer LLC",
        "ToolTip": "Expedita sint cum qui magni quis.",
        "Deleted": false,
        "Rank": 772,
        "Type": "veniam",
        "ColorBlock": 900,
        "IconHint": "ut",
        "Selected": false,
        "LastChanged": "1994-09-26T18:28:49.3281227+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "laboriosam",
        "StyleHint": "ab",
        "Hidden": true,
        "FullName": "Lucile Balistreri",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 693
          }
        }
      }
    ],
    "ExtraInfo": "pariatur",
    "StyleHint": "corporis",
    "Hidden": true,
    "FullName": "Ivy Daugherty",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "deploy rich channels"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 334
      }
    }
  }
]
```