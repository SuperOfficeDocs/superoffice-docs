---
title: PUT List/{id}/Items/{id}/Headings
uid: v1ListItemEntity_SaveHeadingsForListItemFromListDefinition
---

# PUT List/{id}/Items/{id}/Headings

```http
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
```

Saves the active headings for the list item.

| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list definition, indicating which list to delete the items from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
| listItemId | int32 | The identity of the list item to delete **Required** |

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

## Request Body: headings

The headings to save.

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
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 961,
    "Name": "Leuschke, Murphy and Crist",
    "ToolTip": "Enim saepe accusantium.",
    "Deleted": true,
    "Rank": 138,
    "Type": "corporis",
    "ColorBlock": 565,
    "IconHint": "in",
    "Selected": false,
    "LastChanged": "2018-05-07T11:10:53.8972124+02:00",
    "ChildItems": [
      {
        "Id": 687,
        "Name": "Schumm LLC",
        "ToolTip": "Animi optio aut quo sit delectus et quae.",
        "Deleted": false,
        "Rank": 219,
        "Type": "velit",
        "ColorBlock": 970,
        "IconHint": "aliquam",
        "Selected": false,
        "LastChanged": "1997-02-27T11:10:53.8972124+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "laudantium",
        "Hidden": false,
        "FullName": "Holly Wilderman"
      }
    ],
    "ExtraInfo": "fuga",
    "StyleHint": "ad",
    "Hidden": false,
    "FullName": "Ms. Tomas Swaniawski V"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 523,
    "Name": "Kozey-Morissette",
    "ToolTip": "Id in tenetur totam recusandae dolore fuga.",
    "Deleted": false,
    "Rank": 444,
    "Type": "nam",
    "ColorBlock": 536,
    "IconHint": "nisi",
    "Selected": false,
    "LastChanged": "2010-08-30T11:10:53.898213+02:00",
    "ChildItems": [
      {
        "Id": 939,
        "Name": "Hane, McLaughlin and Schneider",
        "ToolTip": "Asperiores earum qui omnis quod.",
        "Deleted": false,
        "Rank": 328,
        "Type": "expedita",
        "ColorBlock": 697,
        "IconHint": "maxime",
        "Selected": false,
        "LastChanged": "2002-06-18T11:10:53.898213+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "provident",
        "StyleHint": "consequuntur",
        "Hidden": false,
        "FullName": "Prof. Edythe Jaiden Abbott",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 743
          }
        }
      }
    ],
    "ExtraInfo": "molestias",
    "StyleHint": "labore",
    "Hidden": false,
    "FullName": "Drew Eichmann III",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 927
      }
    }
  }
]
```
