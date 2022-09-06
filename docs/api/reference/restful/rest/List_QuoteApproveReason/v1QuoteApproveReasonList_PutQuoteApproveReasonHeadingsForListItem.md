---
title: PUT List/QuoteApproveReason/Items/{id}/Headings
uid: v1QuoteApproveReasonList_PutQuoteApproveReasonHeadingsForListItem
---

# PUT List/QuoteApproveReason/Items/{id}/Headings

```http
PUT /api/v1/List/QuoteApproveReason/Items/{itemId}/Headings
```

Saves headings for the QuoteApproveReason list's item.

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

OK

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

## Sample request

```http!
PUT /api/v1/List/QuoteApproveReason/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 699,
    "Name": "Pfeffer-Wunsch",
    "ToolTip": "Pariatur excepturi enim.",
    "Deleted": false,
    "Rank": 371,
    "Type": "et",
    "ColorBlock": 201,
    "IconHint": "magni",
    "Selected": false,
    "LastChanged": "1999-11-29T11:10:54.509935+01:00",
    "ChildItems": [
      {
        "Id": 634,
        "Name": "Kautzer Group",
        "ToolTip": "Facilis natus quidem sint nobis iste.",
        "Deleted": true,
        "Rank": 299,
        "Type": "quis",
        "ColorBlock": 710,
        "IconHint": "exercitationem",
        "Selected": true,
        "LastChanged": "2020-10-28T11:10:54.509935+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eius",
        "StyleHint": "non",
        "Hidden": false,
        "FullName": "Kristofer Gottlieb"
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "nisi",
    "Hidden": false,
    "FullName": "Rosendo Toy"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 491,
    "Name": "Metz, Erdman and Rice",
    "ToolTip": "Minus itaque necessitatibus sunt amet.",
    "Deleted": false,
    "Rank": 45,
    "Type": "deleniti",
    "ColorBlock": 106,
    "IconHint": "molestiae",
    "Selected": true,
    "LastChanged": "2014-12-15T11:10:54.5109367+01:00",
    "ChildItems": [
      {
        "Id": 848,
        "Name": "Bruen-Skiles",
        "ToolTip": "Molestiae ut quia expedita.",
        "Deleted": false,
        "Rank": 332,
        "Type": "cumque",
        "ColorBlock": 291,
        "IconHint": "officiis",
        "Selected": true,
        "LastChanged": "2021-08-20T11:10:54.5109367+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "necessitatibus",
        "StyleHint": "voluptate",
        "Hidden": false,
        "FullName": "Alfonzo Herzog",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 592
          }
        }
      }
    ],
    "ExtraInfo": "maxime",
    "StyleHint": "sit",
    "Hidden": false,
    "FullName": "Omari Romaguera",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 395
      }
    }
  }
]
```
