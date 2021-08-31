---
title: PUT List/Business/Items/{id}/Headings
id: v1BusinessList_PutBusinessHeadingsForListItem
---

# PUT List/Business/Items/{id}/Headings

```http
PUT /api/v1/List/Business/Items/{itemId}/Headings
```

Saves headings for the Business list's item.

Calls the List agent service SaveHeadingsForListItemFromListDefinition.




| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be saved. **Required** |



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

## Request Body: entities  

The headings to be saved. 

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
PUT /api/v1/List/Business/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 845,
    "Name": "Casper Inc and Sons",
    "ToolTip": "Occaecati id eos ad qui quia.",
    "Deleted": false,
    "Rank": 393,
    "Type": "fuga",
    "ColorBlock": 310,
    "IconHint": "rerum",
    "Selected": true,
    "LastChanged": "1998-07-27T15:05:43.2555479+02:00",
    "ChildItems": [
      {
        "Id": 343,
        "Name": "Satterfield-Schulist",
        "ToolTip": "Cupiditate id.",
        "Deleted": true,
        "Rank": 472,
        "Type": "omnis",
        "ColorBlock": 313,
        "IconHint": "optio",
        "Selected": false,
        "LastChanged": "1999-05-05T15:05:43.2555479+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eius",
        "StyleHint": "nesciunt",
        "Hidden": false,
        "FullName": "Destiny Williamson"
      }
    ],
    "ExtraInfo": "rem",
    "StyleHint": "ipsam",
    "Hidden": false,
    "FullName": "Ms. Carey Cole"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 77,
    "Name": "Pollich-Waters",
    "ToolTip": "Asperiores nobis necessitatibus repudiandae.",
    "Deleted": false,
    "Rank": 419,
    "Type": "aperiam",
    "ColorBlock": 444,
    "IconHint": "architecto",
    "Selected": true,
    "LastChanged": "2019-07-30T15:05:43.2565454+02:00",
    "ChildItems": [
      {
        "Id": 481,
        "Name": "Reilly-Morissette",
        "ToolTip": "Repudiandae hic odit.",
        "Deleted": false,
        "Rank": 248,
        "Type": "itaque",
        "ColorBlock": 527,
        "IconHint": "fugiat",
        "Selected": false,
        "LastChanged": "1994-05-18T15:05:43.2565454+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "excepturi",
        "StyleHint": "voluptas",
        "Hidden": true,
        "FullName": "Alvis Powlowski",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 489
          }
        }
      }
    ],
    "ExtraInfo": "reiciendis",
    "StyleHint": "nam",
    "Hidden": false,
    "FullName": "Mrs. Presley Klocko",
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
        "FieldLength": 438
      }
    }
  }
]
```