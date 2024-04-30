---
title: PUT List/Position/Items/{id}/UserGroups
uid: v1PositionList_PutPositionUserGroupsForListItem
generated: true
---

# PUT List/Position/Items/{id}/UserGroups

```http
PUT /api/v1/List/Position/Items/{itemId}/UserGroups
```

Saves user groups visible for the Position list's item.


Calls the List agent service SaveHeadingsForListItemFromListDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to save. **Required** |



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
PUT /api/v1/List/Position/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 619,
    "Name": "Stark-Homenick",
    "ToolTip": "Id corporis repellendus fuga accusantium dignissimos.",
    "Deleted": true,
    "Rank": 289,
    "Type": "distinctio",
    "ColorBlock": 255,
    "IconHint": "quia",
    "Selected": false,
    "LastChanged": "2023-10-05T11:16:14.6214085+02:00",
    "ChildItems": [
      {
        "Id": 403,
        "Name": "Cruickshank, McLaughlin and Lowe",
        "ToolTip": "Doloremque voluptas officiis veritatis rem.",
        "Deleted": true,
        "Rank": 326,
        "Type": "ullam",
        "ColorBlock": 491,
        "IconHint": "debitis",
        "Selected": false,
        "LastChanged": "2019-03-08T11:16:14.6214085+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eveniet",
        "StyleHint": "expedita",
        "Hidden": false,
        "FullName": "Alfreda Altenwerth"
      }
    ],
    "ExtraInfo": "quidem",
    "StyleHint": "voluptatibus",
    "Hidden": true,
    "FullName": "Nasir Maggio"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 157,
    "Name": "Labadie-Kerluke",
    "ToolTip": "Velit dicta sit nemo.",
    "Deleted": false,
    "Rank": 39,
    "Type": "quo",
    "ColorBlock": 531,
    "IconHint": "laborum",
    "Selected": false,
    "LastChanged": "1998-06-04T11:16:14.6214085+02:00",
    "ChildItems": [
      {
        "Id": 835,
        "Name": "Satterfield-Kiehn",
        "ToolTip": "Rerum maxime doloribus et eaque et quis.",
        "Deleted": false,
        "Rank": 154,
        "Type": "esse",
        "ColorBlock": 901,
        "IconHint": "eos",
        "Selected": true,
        "LastChanged": "2014-11-01T11:16:14.6214085+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "omnis",
        "StyleHint": "sint",
        "Hidden": true,
        "FullName": "Mariana Kaitlyn Sauer Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 851
          }
        }
      }
    ],
    "ExtraInfo": "autem",
    "StyleHint": "eaque",
    "Hidden": true,
    "FullName": "Madelynn Haag",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 571
      }
    }
  }
]
```