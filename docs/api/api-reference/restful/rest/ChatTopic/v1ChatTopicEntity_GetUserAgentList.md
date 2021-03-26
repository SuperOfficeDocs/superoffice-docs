---
title: GET ChatTopic/UserAgents
id: v1ChatTopicEntity_GetUserAgentList
---

# GET ChatTopic/UserAgents

```http
GET /api/v1/ChatTopic/UserAgents
```

Get list of users that can be assigned to topics.

Users with Chat-CALs from the MDO list 'chatuser'





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| flat | bool | **Required** Return flat list instead of grouping by usergroup. |
| onlyPresent | bool |  Only show users who are present |

```http
GET /api/v1/ChatTopic/UserAgents?flat=True
GET /api/v1/ChatTopic/UserAgents?onlyPresent=False
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
| ChildItems | array | The child items of the MDOListItem |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| FullName | string | The name of the ListItem in its context |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/ChatTopic/UserAgents
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 469,
    "Name": "Jacobs LLC",
    "ToolTip": "Dolorem doloribus nisi illo blanditiis reprehenderit.",
    "Deleted": false,
    "Rank": 188,
    "Type": "sit",
    "ChildItems": [
      {
        "Id": 784,
        "Name": "Dare-Corkery",
        "ToolTip": "Cumque voluptatem.",
        "Deleted": true,
        "Rank": 926,
        "Type": "et",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "et",
        "ColorBlock": 107,
        "ExtraInfo": "pariatur",
        "StyleHint": "similique",
        "FullName": "Luciano Mitchell",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 535
          }
        }
      }
    ],
    "IconHint": "non",
    "ColorBlock": 588,
    "ExtraInfo": "est",
    "StyleHint": "quam",
    "FullName": "Robyn Carter",
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
        "FieldType": "System.String",
        "FieldLength": 448
      }
    }
  }
]
```