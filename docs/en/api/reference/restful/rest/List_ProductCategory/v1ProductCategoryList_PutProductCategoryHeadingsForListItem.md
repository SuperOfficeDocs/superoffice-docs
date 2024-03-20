---
title: PUT List/ProductCategory/Items/{id}/Headings
uid: v1ProductCategoryList_PutProductCategoryHeadingsForListItem
generated: true
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
| Id | Integer | The Id of the ListItem |
| Name | String | The name of the ListItem |
| ToolTip | String | The tooltip of the ListItem |
| Deleted | Boolean | The deleted status of the ListItem |
| Rank | Integer | The rank of the ListItem |
| Type | String | The type of the ListItem. Custom field. |
| ColorBlock | Integer | The color indicator of the ListItem color block |
| IconHint | String | The Icon hint of the ListItem. Custom field. |
| Selected | Boolean | True if the ListItem is selected |
| LastChanged | String | Time of last change. |
| ChildItems | Array | The child items of the SelectableMDOListItem |
| ExtraInfo | String | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | String | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | Boolean | True if the ListItem is hidden |
| FullName | String | The name of the ListItem in its context |

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
| ColorBlock | int32 | The color indicator of the ListItem color block |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| Selected | bool | True if the ListItem is selected |
| LastChanged | date-time | Time of last change. |
| ChildItems | array | The child items of the SelectableMDOListItem |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | bool | True if the ListItem is hidden |
| FullName | string | The name of the ListItem in its context |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/ProductCategory/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 32,
    "Name": "Lubowitz Group",
    "ToolTip": "Dolorum ducimus soluta rerum nam facere.",
    "Deleted": false,
    "Rank": 470,
    "Type": "dolores",
    "ColorBlock": 221,
    "IconHint": "soluta",
    "Selected": false,
    "LastChanged": "2003-09-03T12:19:54.6958722+02:00",
    "ChildItems": [
      {
        "Id": 408,
        "Name": "Pagac, Ziemann and Flatley",
        "ToolTip": "Reiciendis repellendus soluta et nemo et pariatur quod.",
        "Deleted": false,
        "Rank": 563,
        "Type": "corporis",
        "ColorBlock": 394,
        "IconHint": "unde",
        "Selected": false,
        "LastChanged": "2009-11-07T12:19:54.6958722+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "incidunt",
        "StyleHint": "possimus",
        "Hidden": false,
        "FullName": "Prof. Janick Hagenes II"
      }
    ],
    "ExtraInfo": "repellat",
    "StyleHint": "molestiae",
    "Hidden": false,
    "FullName": "Bonnie Violette Will IV"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 268,
    "Name": "Welch LLC",
    "ToolTip": "Ut quis fuga id.",
    "Deleted": false,
    "Rank": 521,
    "Type": "dignissimos",
    "ColorBlock": 699,
    "IconHint": "qui",
    "Selected": false,
    "LastChanged": "2005-06-18T12:19:54.6958722+02:00",
    "ChildItems": [
      {
        "Id": 723,
        "Name": "McCullough-O'Hara",
        "ToolTip": "Unde aut molestiae ut dolorem eveniet sequi.",
        "Deleted": false,
        "Rank": 873,
        "Type": "minima",
        "ColorBlock": 464,
        "IconHint": "impedit",
        "Selected": false,
        "LastChanged": "2020-05-29T12:19:54.6958722+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "neque",
        "StyleHint": "laboriosam",
        "Hidden": true,
        "FullName": "Chelsie Bartell",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 534
          }
        }
      }
    ],
    "ExtraInfo": "molestias",
    "StyleHint": "sequi",
    "Hidden": true,
    "FullName": "Kevon Volkman III",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 785
      }
    }
  }
]
```