---
title: PUT List/Source/Items/{id}/Headings
id: v1SourceList_PutSourceHeadingsForListItem
---

# PUT List/Source/Items/{id}/Headings

```http
PUT /api/v1/List/Source/Items/{itemId}/Headings
```

Saves headings for the Source list's item.

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
PUT /api/v1/List/Source/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 868,
    "Name": "Upton, Bayer and Rodriguez",
    "ToolTip": "Quo nulla id perspiciatis labore iste animi.",
    "Deleted": true,
    "Rank": 527,
    "Type": "quo",
    "ColorBlock": 304,
    "IconHint": "dolor",
    "Selected": true,
    "LastChanged": "2005-01-05T18:25:52.2696376+01:00",
    "ChildItems": [
      {
        "Id": 651,
        "Name": "Rolfson-Lebsack",
        "ToolTip": "Omnis sed fuga.",
        "Deleted": true,
        "Rank": 116,
        "Type": "nam",
        "ColorBlock": 962,
        "IconHint": "ut",
        "Selected": false,
        "LastChanged": "2008-04-29T18:25:52.2696376+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatem",
        "StyleHint": "veniam",
        "Hidden": true,
        "FullName": "Mrs. Savanah Rath"
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "tempora",
    "Hidden": false,
    "FullName": "Itzel Friesen"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 844,
    "Name": "Stamm, Reilly and Ondricka",
    "ToolTip": "Ratione animi provident voluptas eum sed.",
    "Deleted": true,
    "Rank": 662,
    "Type": "nulla",
    "ColorBlock": 720,
    "IconHint": "ipsa",
    "Selected": true,
    "LastChanged": "2006-10-11T18:25:52.270637+02:00",
    "ChildItems": [
      {
        "Id": 820,
        "Name": "Dicki-Wintheiser",
        "ToolTip": "Et et corrupti nihil voluptas sint.",
        "Deleted": false,
        "Rank": 401,
        "Type": "modi",
        "ColorBlock": 680,
        "IconHint": "tempore",
        "Selected": true,
        "LastChanged": "1999-08-11T18:25:52.2716367+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rerum",
        "StyleHint": "asperiores",
        "Hidden": true,
        "FullName": "Santina Pfannerstill",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 472
          }
        }
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "numquam",
    "Hidden": false,
    "FullName": "Sandy Walker",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "revolutionize clicks-and-mortar e-tailers"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 232
      }
    }
  }
]
```