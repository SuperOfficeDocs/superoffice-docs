---
title: PUT List/Rating/Items/{id}/UserGroups
uid: v1RatingList_PutSaleStageEntityUserGroupsForListItem
generated: true
---

# PUT List/Rating/Items/{id}/UserGroups

```http
PUT /api/v1/List/Rating/Items/{itemId}/UserGroups
```

Saves user groups visible for the SaleStageEntity list's item.


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
PUT /api/v1/List/Rating/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 833,
    "Name": "Harris, Jewess and Bernhard",
    "ToolTip": "Aut neque maxime perspiciatis culpa.",
    "Deleted": true,
    "Rank": 679,
    "Type": "consequatur",
    "ColorBlock": 397,
    "IconHint": "quo",
    "Selected": false,
    "LastChanged": "2016-03-22T10:18:01.1293744+01:00",
    "ChildItems": [
      {
        "Id": 13,
        "Name": "Nicolas Group",
        "ToolTip": "Praesentium vel eum minima.",
        "Deleted": true,
        "Rank": 816,
        "Type": "quia",
        "ColorBlock": 836,
        "IconHint": "odio",
        "Selected": true,
        "LastChanged": "2012-10-03T10:18:01.1293744+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "velit",
        "StyleHint": "saepe",
        "Hidden": false,
        "FullName": "Albert Reichert"
      }
    ],
    "ExtraInfo": "eum",
    "StyleHint": "iusto",
    "Hidden": false,
    "FullName": "Mario Koepp"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 923,
    "Name": "Bergstrom, O'Hara and Russel",
    "ToolTip": "Dolor nihil nam possimus.",
    "Deleted": false,
    "Rank": 989,
    "Type": "ipsa",
    "ColorBlock": 761,
    "IconHint": "odit",
    "Selected": false,
    "LastChanged": "2001-02-03T10:18:01.1293744+01:00",
    "ChildItems": [
      {
        "Id": 871,
        "Name": "Padberg Group",
        "ToolTip": "Necessitatibus et asperiores.",
        "Deleted": true,
        "Rank": 854,
        "Type": "odio",
        "ColorBlock": 404,
        "IconHint": "optio",
        "Selected": false,
        "LastChanged": "2024-09-24T10:18:01.1293744+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "autem",
        "StyleHint": "quas",
        "Hidden": false,
        "FullName": "Ms. Xzavier Lowe MD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 844
          }
        }
      }
    ],
    "ExtraInfo": "reprehenderit",
    "StyleHint": "accusantium",
    "Hidden": false,
    "FullName": "Ansel Smith",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 416
      }
    }
  }
]
```