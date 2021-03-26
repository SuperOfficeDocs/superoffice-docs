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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 705,
    "Name": "Homenick, Gleichner and Hudson",
    "ToolTip": "Adipisci fugiat vel.",
    "Deleted": true,
    "Rank": 958,
    "Type": "facere",
    "ColorBlock": 461,
    "IconHint": "vitae",
    "Selected": true,
    "LastChanged": "2012-06-12T09:41:00.5653878+02:00",
    "ChildItems": [
      {
        "Id": 333,
        "Name": "Leuschke-Jerde",
        "ToolTip": "Quis et exercitationem vel minus.",
        "Deleted": true,
        "Rank": 772,
        "Type": "vel",
        "ColorBlock": 479,
        "IconHint": "quasi",
        "Selected": false,
        "LastChanged": "2020-10-17T09:41:00.5653878+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "velit",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Hollis Erdman MD"
      }
    ],
    "ExtraInfo": "quae",
    "StyleHint": "quo",
    "Hidden": false,
    "FullName": "Jacinto Durgan"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 495,
    "Name": "Sauer, Murazik and Kuphal",
    "ToolTip": "Commodi veritatis nihil deserunt omnis.",
    "Deleted": true,
    "Rank": 261,
    "Type": "saepe",
    "ColorBlock": 74,
    "IconHint": "deserunt",
    "Selected": false,
    "LastChanged": "2015-07-14T09:41:00.5663859+02:00",
    "ChildItems": [
      {
        "Id": 856,
        "Name": "O'Keefe-Mann",
        "ToolTip": "Doloremque soluta corrupti ratione tempora.",
        "Deleted": true,
        "Rank": 429,
        "Type": "numquam",
        "ColorBlock": 130,
        "IconHint": "exercitationem",
        "Selected": true,
        "LastChanged": "2017-01-18T09:41:00.5663859+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "recusandae",
        "Hidden": true,
        "FullName": "Ms. Leo Lind",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 263
          }
        }
      }
    ],
    "ExtraInfo": "omnis",
    "StyleHint": "sit",
    "Hidden": true,
    "FullName": "Willow Koss DVM",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate enterprise web-readiness"
        },
        "FieldType": "System.Int32",
        "FieldLength": 622
      }
    }
  }
]
```