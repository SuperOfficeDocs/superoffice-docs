---
title: POST Agents/Chat/GetUserAgentList
uid: v1ChatAgent_GetUserAgentList
generated: true
content_type: reference
---

# POST Agents/Chat/GetUserAgentList

```http
POST /api/v1/Agents/Chat/GetUserAgentList
```

Get list of users that can be assigned to chat topics.


Users with Chat-CALs from the MDO list 'chatuser'






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/GetUserAgentList?$select=name,department,category/id
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

Flat, OnlyPresent 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Flat | Boolean |  |
| OnlyPresent | Boolean |  |

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
POST /api/v1/Agents/Chat/GetUserAgentList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Flat": false,
  "OnlyPresent": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 855,
    "Name": "O'Keefe-Lowe",
    "ToolTip": "Velit excepturi ipsum.",
    "Deleted": false,
    "Rank": 284,
    "Type": "nihil",
    "ChildItems": [
      {
        "Id": 845,
        "Name": "Gleason Group",
        "ToolTip": "Labore cumque quia alias rerum.",
        "Deleted": true,
        "Rank": 782,
        "Type": "cum",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "non",
        "ColorBlock": 388,
        "ExtraInfo": "et",
        "StyleHint": "quis",
        "FullName": "Dr. Zachariah Feest",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 347
          }
        }
      }
    ],
    "IconHint": "doloremque",
    "ColorBlock": 178,
    "ExtraInfo": "veritatis",
    "StyleHint": "nulla",
    "FullName": "Hillard Reynolds",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 85
      }
    }
  }
]
```