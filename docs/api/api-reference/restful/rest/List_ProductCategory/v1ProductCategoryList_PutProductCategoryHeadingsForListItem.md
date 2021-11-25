---
title: PUT List/ProductCategory/Items/{id}/Headings
id: v1ProductCategoryList_PutProductCategoryHeadingsForListItem
---

# PUT List/ProductCategory/Items/{id}/Headings

```http
PUT /api/v1/List/ProductCategory/Items/{itemId}/Headings
```

Saves headings for the ProductCategory list's item.

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
PUT /api/v1/List/ProductCategory/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 964,
    "Name": "Kiehn-Hauck",
    "ToolTip": "Est aliquid expedita.",
    "Deleted": false,
    "Rank": 403,
    "Type": "debitis",
    "ColorBlock": 148,
    "IconHint": "amet",
    "Selected": true,
    "LastChanged": "2000-05-25T18:25:52.0022126+02:00",
    "ChildItems": [
      {
        "Id": 998,
        "Name": "Romaguera, Ferry and Wolff",
        "ToolTip": "Nihil quae harum dolore tempore aut.",
        "Deleted": true,
        "Rank": 331,
        "Type": "ullam",
        "ColorBlock": 93,
        "IconHint": "harum",
        "Selected": true,
        "LastChanged": "2002-02-09T18:25:52.0022126+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "facere",
        "StyleHint": "animi",
        "Hidden": false,
        "FullName": "Keira Fay"
      }
    ],
    "ExtraInfo": "aut",
    "StyleHint": "quidem",
    "Hidden": false,
    "FullName": "Bernice Moore Jr."
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 336,
    "Name": "Anderson, Schulist and Klein",
    "ToolTip": "Et ipsum et incidunt rerum.",
    "Deleted": true,
    "Rank": 340,
    "Type": "neque",
    "ColorBlock": 233,
    "IconHint": "laudantium",
    "Selected": false,
    "LastChanged": "2019-03-21T18:25:52.0032124+01:00",
    "ChildItems": [
      {
        "Id": 701,
        "Name": "Reilly-Murphy",
        "ToolTip": "Sed omnis a nisi at.",
        "Deleted": false,
        "Rank": 67,
        "Type": "enim",
        "ColorBlock": 475,
        "IconHint": "nesciunt",
        "Selected": true,
        "LastChanged": "1998-01-18T18:25:52.0042123+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rerum",
        "StyleHint": "eaque",
        "Hidden": false,
        "FullName": "Dennis Nolan",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 391
          }
        }
      }
    ],
    "ExtraInfo": "sit",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Geovanni Gottlieb II",
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
        "FieldLength": 823
      }
    }
  }
]
```