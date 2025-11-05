---
title: PUT List/{udListDefinitionName}/Items/{id}/Headings
uid: v1ListItemEntity_SaveHeadingsForListItemFromListName
generated: true
content_type: reference
---

# PUT List/{udListDefinitionName}/Items/{id}/Headings

```http
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings
```

Saves the headings for the list item.






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionName | string | The name of the list definition, indicating which list to update. **Required** |
| listItemId | int32 | The identity of the list item **Required** |



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
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 899,
    "Name": "Wehner-Gutkowski",
    "ToolTip": "In itaque qui.",
    "Deleted": true,
    "Rank": 12,
    "Type": "nostrum",
    "ColorBlock": 533,
    "IconHint": "possimus",
    "Selected": true,
    "LastChanged": "2023-07-10T02:30:53.194268+02:00",
    "ChildItems": [
      {
        "Id": 319,
        "Name": "Weissnat Inc and Sons",
        "ToolTip": "Voluptatum magni aut officia voluptas.",
        "Deleted": false,
        "Rank": 472,
        "Type": "praesentium",
        "ColorBlock": 321,
        "IconHint": "non",
        "Selected": true,
        "LastChanged": "2018-09-26T02:30:53.194268+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eveniet",
        "StyleHint": "rerum",
        "Hidden": false,
        "FullName": "Mrs. Gus Verla Jacobs"
      }
    ],
    "ExtraInfo": "eveniet",
    "StyleHint": "dignissimos",
    "Hidden": false,
    "FullName": "Ms. Jocelyn Anais Grant"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 883,
    "Name": "Vandervort-Larson",
    "ToolTip": "Minus et sapiente sunt distinctio.",
    "Deleted": false,
    "Rank": 718,
    "Type": "qui",
    "ColorBlock": 230,
    "IconHint": "nihil",
    "Selected": false,
    "LastChanged": "2013-11-07T02:30:53.194268+01:00",
    "ChildItems": [
      {
        "Id": 383,
        "Name": "Bashirian, Jones and Greenholt",
        "ToolTip": "Aut reprehenderit quia et.",
        "Deleted": false,
        "Rank": 130,
        "Type": "ad",
        "ColorBlock": 233,
        "IconHint": "perferendis",
        "Selected": true,
        "LastChanged": "2025-03-18T02:30:53.194268+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rerum",
        "StyleHint": "fugit",
        "Hidden": false,
        "FullName": "Elza Schowalter",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 360
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "maiores",
    "Hidden": false,
    "FullName": "Kasandra Paucek",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 536
      }
    }
  }
]
```