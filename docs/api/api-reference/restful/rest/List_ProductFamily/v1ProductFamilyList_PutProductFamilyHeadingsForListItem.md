---
title: PUT List/ProductFamily/Items/{id}/Headings
id: v1ProductFamilyList_PutProductFamilyHeadingsForListItem
---

# PUT List/ProductFamily/Items/{id}/Headings

```http
PUT /api/v1/List/ProductFamily/Items/{itemId}/Headings
```

Saves headings for the ProductFamily list's item.

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
PUT /api/v1/List/ProductFamily/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 329,
    "Name": "Quitzon Group",
    "ToolTip": "Omnis voluptatem et inventore.",
    "Deleted": true,
    "Rank": 698,
    "Type": "rerum",
    "ColorBlock": 502,
    "IconHint": "necessitatibus",
    "Selected": false,
    "LastChanged": "2006-09-28T15:05:43.6340798+02:00",
    "ChildItems": [
      {
        "Id": 275,
        "Name": "Huel, Pacocha and Bechtelar",
        "ToolTip": "Dolor et perferendis at id.",
        "Deleted": false,
        "Rank": 98,
        "Type": "non",
        "ColorBlock": 516,
        "IconHint": "libero",
        "Selected": false,
        "LastChanged": "2019-08-22T15:05:43.6340798+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatem",
        "StyleHint": "cupiditate",
        "Hidden": false,
        "FullName": "Orlo Trantow DVM"
      }
    ],
    "ExtraInfo": "ab",
    "StyleHint": "voluptatem",
    "Hidden": true,
    "FullName": "Lukas Nitzsche"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 561,
    "Name": "Bosco-O'Hara",
    "ToolTip": "Ut eum blanditiis.",
    "Deleted": true,
    "Rank": 836,
    "Type": "mollitia",
    "ColorBlock": 710,
    "IconHint": "molestiae",
    "Selected": true,
    "LastChanged": "2008-01-10T15:05:43.6350795+01:00",
    "ChildItems": [
      {
        "Id": 569,
        "Name": "Williamson-Prohaska",
        "ToolTip": "Explicabo illo.",
        "Deleted": true,
        "Rank": 833,
        "Type": "atque",
        "ColorBlock": 518,
        "IconHint": "eaque",
        "Selected": true,
        "LastChanged": "2021-05-11T15:05:43.6350795+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tenetur",
        "StyleHint": "molestiae",
        "Hidden": false,
        "FullName": "Daren Dibbert",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 362
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "distinctio",
    "Hidden": true,
    "FullName": "Lambert Yost Sr.",
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
        "FieldLength": 456
      }
    }
  }
]
```