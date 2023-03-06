---
title: GET ChatTopic/UserAgents
uid: v1ChatTopicEntity_GetUserAgentList
---

# GET ChatTopic/UserAgents

```http
GET /api/v1/ChatTopic/UserAgents
```

Get list of users that can be assigned to chat topics.


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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/ChatTopic/UserAgents
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 864,
    "Name": "O'Kon, Ortiz and Williamson",
    "ToolTip": "Fugiat quidem.",
    "Deleted": false,
    "Rank": 262,
    "Type": "fugit",
    "ChildItems": [
      {
        "Id": 9,
        "Name": "Moen-Crooks",
        "ToolTip": "Debitis iusto libero rerum incidunt placeat.",
        "Deleted": false,
        "Rank": 668,
        "Type": "maxime",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "optio",
        "ColorBlock": 141,
        "ExtraInfo": "doloremque",
        "StyleHint": "assumenda",
        "FullName": "Miss Luisa Agnes Jenkins",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 15
          }
        }
      }
    ],
    "IconHint": "qui",
    "ColorBlock": 560,
    "ExtraInfo": "iusto",
    "StyleHint": "cumque",
    "FullName": "Graham Rippin",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 980
      }
    }
  }
]
```