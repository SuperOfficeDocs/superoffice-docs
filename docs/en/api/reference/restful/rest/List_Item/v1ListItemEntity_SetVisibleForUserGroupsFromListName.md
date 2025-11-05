---
title: PUT List/{udListDefinitionName}/Items/{id}/UserGroups
uid: v1ListItemEntity_SetVisibleForUserGroupsFromListName
generated: true
content_type: reference
---

# PUT List/{udListDefinitionName}/Items/{id}/UserGroups

```http
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/UserGroups
```

Update User groups that this list item is visible for






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionName | string | The name of the list definition, indicating which list to update the items from. **Required** |
| listItemId | int32 | The id of the list item **Required** |



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

## Request Body: userGroups 

The selectable user groups. 

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
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 602,
    "Name": "Anderson, Barton and Williamson",
    "ToolTip": "Distinctio rerum numquam nemo sunt blanditiis.",
    "Deleted": false,
    "Rank": 439,
    "Type": "architecto",
    "ColorBlock": 150,
    "IconHint": "quo",
    "Selected": false,
    "LastChanged": "2003-11-03T02:30:53.194268+01:00",
    "ChildItems": [
      {
        "Id": 523,
        "Name": "Predovic, Klocko and Braun",
        "ToolTip": "Tenetur omnis.",
        "Deleted": false,
        "Rank": 639,
        "Type": "inventore",
        "ColorBlock": 152,
        "IconHint": "nihil",
        "Selected": false,
        "LastChanged": "2010-01-01T02:30:53.194268+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "fugit",
        "StyleHint": "dolorum",
        "Hidden": false,
        "FullName": "Glenna Tillman"
      }
    ],
    "ExtraInfo": "doloremque",
    "StyleHint": "ad",
    "Hidden": true,
    "FullName": "Mrs. Leilani Gerhold V"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 412,
    "Name": "Hudson, Bartoletti and Schroeder",
    "ToolTip": "Modi quia et omnis porro ut commodi id.",
    "Deleted": true,
    "Rank": 214,
    "Type": "quia",
    "ColorBlock": 112,
    "IconHint": "necessitatibus",
    "Selected": false,
    "LastChanged": "2013-10-17T02:30:53.194268+02:00",
    "ChildItems": [
      {
        "Id": 516,
        "Name": "Oberbrunner-Runte",
        "ToolTip": "Eius laborum et.",
        "Deleted": true,
        "Rank": 894,
        "Type": "perferendis",
        "ColorBlock": 87,
        "IconHint": "incidunt",
        "Selected": true,
        "LastChanged": "2014-03-08T02:30:53.194268+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "incidunt",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Maude Dicki",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 808
          }
        }
      }
    ],
    "ExtraInfo": "deserunt",
    "StyleHint": "ullam",
    "Hidden": false,
    "FullName": "Keven Fanny Reichert DVM",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 250
      }
    }
  }
]
```