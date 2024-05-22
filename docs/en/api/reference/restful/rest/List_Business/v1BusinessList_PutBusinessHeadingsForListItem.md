---
title: PUT List/Business/Items/{id}/Headings
uid: v1BusinessList_PutBusinessHeadingsForListItem
generated: true
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
PUT /api/v1/List/Business/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 253,
    "Name": "Lindgren-Kuhn",
    "ToolTip": "Recusandae cumque quia nihil expedita qui cumque nam.",
    "Deleted": false,
    "Rank": 71,
    "Type": "non",
    "ColorBlock": 293,
    "IconHint": "eveniet",
    "Selected": false,
    "LastChanged": "2010-11-22T12:57:43.3239611+01:00",
    "ChildItems": [
      {
        "Id": 562,
        "Name": "Jerde-Halvorson",
        "ToolTip": "Distinctio debitis.",
        "Deleted": false,
        "Rank": 205,
        "Type": "est",
        "ColorBlock": 623,
        "IconHint": "modi",
        "Selected": true,
        "LastChanged": "1999-11-27T12:57:43.3239611+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "in",
        "StyleHint": "est",
        "Hidden": true,
        "FullName": "Bulah Effertz"
      }
    ],
    "ExtraInfo": "nam",
    "StyleHint": "nobis",
    "Hidden": false,
    "FullName": "Sylvester McKenzie"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 231,
    "Name": "Armstrong-Swaniawski",
    "ToolTip": "Ut dolorum facere rerum saepe quos minima.",
    "Deleted": false,
    "Rank": 518,
    "Type": "qui",
    "ColorBlock": 284,
    "IconHint": "voluptatum",
    "Selected": false,
    "LastChanged": "2010-01-01T12:57:43.3395828+01:00",
    "ChildItems": [
      {
        "Id": 544,
        "Name": "Hackett, Lehner and Boehm",
        "ToolTip": "Et dolorem beatae voluptatem omnis qui.",
        "Deleted": false,
        "Rank": 429,
        "Type": "sint",
        "ColorBlock": 145,
        "IconHint": "harum",
        "Selected": true,
        "LastChanged": "2003-08-28T12:57:43.3395828+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "magni",
        "Hidden": false,
        "FullName": "Marisa Roberts",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 517
          }
        }
      }
    ],
    "ExtraInfo": "error",
    "StyleHint": "nemo",
    "Hidden": false,
    "FullName": "Miss Shad Dooley",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 137
      }
    }
  }
]
```