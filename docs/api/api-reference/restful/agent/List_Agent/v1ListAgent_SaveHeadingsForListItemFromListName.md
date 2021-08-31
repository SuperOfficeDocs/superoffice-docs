---
title: SaveHeadingsForListItemFromListName
id: v1ListAgent_SaveHeadingsForListItemFromListName
---

# SaveHeadingsForListItemFromListName

```http
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListName
```

Saves the headings for the list item.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListName?$select=name,department,category/id
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

UdListDefinitionName, ListItemId, Headings 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionName | string |  |
| ListItemId | int32 |  |
| Headings | array |  |


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
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Olson Group",
  "ListItemId": 348,
  "Headings": [
    {
      "Id": 833,
      "Name": "Hoeger-Bayer",
      "ToolTip": "Delectus aut saepe repellendus incidunt ullam.",
      "Deleted": true,
      "Rank": 835,
      "Type": "aperiam",
      "ColorBlock": 421,
      "IconHint": "consequuntur",
      "Selected": false,
      "LastChanged": "1994-10-30T14:58:04.427465+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cum",
      "StyleHint": "blanditiis",
      "Hidden": true,
      "FullName": "Lottie Bogan"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 339,
    "Name": "Kris Group",
    "ToolTip": "Est quia.",
    "Deleted": false,
    "Rank": 885,
    "Type": "temporibus",
    "ColorBlock": 283,
    "IconHint": "deleniti",
    "Selected": false,
    "LastChanged": "2013-01-02T14:58:04.4284677+01:00",
    "ChildItems": [
      {
        "Id": 451,
        "Name": "Kovacek-Cummerata",
        "ToolTip": "Aperiam illo quisquam aperiam ullam atque et.",
        "Deleted": false,
        "Rank": 975,
        "Type": "earum",
        "ColorBlock": 839,
        "IconHint": "suscipit",
        "Selected": true,
        "LastChanged": "2018-02-19T14:58:04.4284677+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eligendi",
        "StyleHint": "qui",
        "Hidden": true,
        "FullName": "Flavie Hodkiewicz MD",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 963
          }
        }
      }
    ],
    "ExtraInfo": "quaerat",
    "StyleHint": "distinctio",
    "Hidden": true,
    "FullName": "Brenda Ruecker",
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
        "FieldLength": 912
      }
    }
  }
]
```