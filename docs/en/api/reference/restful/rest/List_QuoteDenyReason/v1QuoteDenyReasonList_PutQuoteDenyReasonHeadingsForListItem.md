---
title: PUT List/QuoteDenyReason/Items/{id}/Headings
uid: v1QuoteDenyReasonList_PutQuoteDenyReasonHeadingsForListItem
generated: true
content_type: reference
---

# PUT List/QuoteDenyReason/Items/{id}/Headings

```http
PUT /api/v1/List/QuoteDenyReason/Items/{itemId}/Headings
```

Saves headings for the QuoteDenyReason list's item.


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
PUT /api/v1/List/QuoteDenyReason/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 841,
    "Name": "Hyatt, Rice and Stroman",
    "ToolTip": "Eum non accusamus rerum quas.",
    "Deleted": false,
    "Rank": 872,
    "Type": "quidem",
    "ColorBlock": 18,
    "IconHint": "possimus",
    "Selected": false,
    "LastChanged": "2008-12-04T02:30:53.3973865+01:00",
    "ChildItems": [
      {
        "Id": 734,
        "Name": "Raynor LLC",
        "ToolTip": "Unde quod officia.",
        "Deleted": true,
        "Rank": 521,
        "Type": "dolor",
        "ColorBlock": 499,
        "IconHint": "sint",
        "Selected": false,
        "LastChanged": "2018-08-08T02:30:53.3973865+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rem",
        "StyleHint": "modi",
        "Hidden": true,
        "FullName": "Rosalinda Fahey"
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "illum",
    "Hidden": false,
    "FullName": "Mrs. Rae Dereck Champlin"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 814,
    "Name": "Cruickshank, Kerluke and Pfannerstill",
    "ToolTip": "Ex et laborum libero qui voluptatem et.",
    "Deleted": false,
    "Rank": 209,
    "Type": "voluptates",
    "ColorBlock": 537,
    "IconHint": "ad",
    "Selected": false,
    "LastChanged": "2016-07-09T02:30:53.3973865+02:00",
    "ChildItems": [
      {
        "Id": 547,
        "Name": "Parisian LLC",
        "ToolTip": "Et suscipit.",
        "Deleted": false,
        "Rank": 456,
        "Type": "molestias",
        "ColorBlock": 1002,
        "IconHint": "explicabo",
        "Selected": false,
        "LastChanged": "2005-06-03T02:30:53.3973865+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "modi",
        "StyleHint": "aliquid",
        "Hidden": false,
        "FullName": "Miss Frankie Jordan Bauch",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 403
          }
        }
      }
    ],
    "ExtraInfo": "beatae",
    "StyleHint": "vel",
    "Hidden": true,
    "FullName": "Janick Ben Rempel V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 324
      }
    }
  }
]
```