---
title: PUT List/SaleType/Items/{id}/UserGroups
uid: v1SaleTypeList_PutSaleTypeEntityUserGroupsForListItem
---

# PUT List/SaleType/Items/{id}/UserGroups

```http
PUT /api/v1/List/SaleType/Items/{itemId}/UserGroups
```

Saves user groups visible for the SaleTypeEntity list's item.


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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/SaleType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 259,
    "Name": "Hackett, Grady and Boyle",
    "ToolTip": "Debitis porro repellat quis repellat.",
    "Deleted": true,
    "Rank": 493,
    "Type": "deleniti",
    "ColorBlock": 185,
    "IconHint": "aut",
    "Selected": false,
    "LastChanged": "2009-11-02T14:19:11.549573+01:00",
    "ChildItems": [
      {
        "Id": 889,
        "Name": "Hackett-Baumbach",
        "ToolTip": "Vitae placeat quia aperiam fugiat necessitatibus.",
        "Deleted": false,
        "Rank": 444,
        "Type": "ipsam",
        "ColorBlock": 488,
        "IconHint": "delectus",
        "Selected": false,
        "LastChanged": "2015-01-24T14:19:11.549573+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "autem",
        "StyleHint": "explicabo",
        "Hidden": true,
        "FullName": "Mr. Kaden Ortiz"
      }
    ],
    "ExtraInfo": "a",
    "StyleHint": "molestias",
    "Hidden": false,
    "FullName": "Tom Fletcher Nitzsche Jr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 539,
    "Name": "Little, Kuvalis and Cummerata",
    "ToolTip": "Amet doloribus eum.",
    "Deleted": false,
    "Rank": 968,
    "Type": "necessitatibus",
    "ColorBlock": 828,
    "IconHint": "assumenda",
    "Selected": true,
    "LastChanged": "1999-01-03T14:19:11.580827+01:00",
    "ChildItems": [
      {
        "Id": 261,
        "Name": "Tromp, Cormier and Ondricka",
        "ToolTip": "Eos sit soluta laudantium voluptate.",
        "Deleted": true,
        "Rank": 355,
        "Type": "natus",
        "ColorBlock": 922,
        "IconHint": "ipsam",
        "Selected": false,
        "LastChanged": "2004-05-08T14:19:11.580827+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "inventore",
        "StyleHint": "inventore",
        "Hidden": false,
        "FullName": "Mr. Garnett Immanuel Maggio",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 425
          }
        }
      }
    ],
    "ExtraInfo": "voluptatum",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Arthur Heaney",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 113
      }
    }
  }
]
```