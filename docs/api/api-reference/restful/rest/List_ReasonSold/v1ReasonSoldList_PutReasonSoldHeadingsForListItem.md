---
title: PUT List/ReasonSold/Items/{id}/Headings
id: v1ReasonSoldList_PutReasonSoldHeadingsForListItem
---

# PUT List/ReasonSold/Items/{id}/Headings

```http
PUT /api/v1/List/ReasonSold/Items/{itemId}/Headings
```

Saves headings for the ReasonSold list's item.

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
PUT /api/v1/List/ReasonSold/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 443,
    "Name": "Hills Group",
    "ToolTip": "Ad omnis molestiae veritatis magni.",
    "Deleted": false,
    "Rank": 86,
    "Type": "porro",
    "ColorBlock": 346,
    "IconHint": "tenetur",
    "Selected": false,
    "LastChanged": "2010-12-08T09:41:00.703387+01:00",
    "ChildItems": [
      {
        "Id": 701,
        "Name": "West-Kris",
        "ToolTip": "Sed magnam architecto ea.",
        "Deleted": true,
        "Rank": 874,
        "Type": "ut",
        "ColorBlock": 694,
        "IconHint": "hic",
        "Selected": false,
        "LastChanged": "1999-10-20T09:41:00.7043877+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "odio",
        "StyleHint": "ratione",
        "Hidden": true,
        "FullName": "Jaunita Parisian Sr."
      }
    ],
    "ExtraInfo": "at",
    "StyleHint": "voluptas",
    "Hidden": true,
    "FullName": "Ebony Huel III"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 967,
    "Name": "Bosco LLC",
    "ToolTip": "Sunt minima dolor quod est suscipit molestiae.",
    "Deleted": false,
    "Rank": 711,
    "Type": "cum",
    "ColorBlock": 838,
    "IconHint": "dolore",
    "Selected": true,
    "LastChanged": "2008-08-09T09:41:00.7053871+02:00",
    "ChildItems": [
      {
        "Id": 501,
        "Name": "Stoltenberg, Rodriguez and Hills",
        "ToolTip": "Totam ipsa ea velit.",
        "Deleted": true,
        "Rank": 648,
        "Type": "sint",
        "ColorBlock": 776,
        "IconHint": "molestiae",
        "Selected": true,
        "LastChanged": "1998-02-12T09:41:00.7063932+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "illo",
        "StyleHint": "vitae",
        "Hidden": false,
        "FullName": "Golden Aufderhar PhD",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 383
          }
        }
      }
    ],
    "ExtraInfo": "harum",
    "StyleHint": "harum",
    "Hidden": true,
    "FullName": "Jeffrey Quigley",
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
        "FieldLength": 281
      }
    }
  }
]
```