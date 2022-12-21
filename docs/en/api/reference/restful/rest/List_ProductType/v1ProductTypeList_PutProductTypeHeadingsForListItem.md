---
title: PUT List/ProductType/Items/{id}/Headings
uid: v1ProductTypeList_PutProductTypeHeadingsForListItem
---

# PUT List/ProductType/Items/{id}/Headings

```http
PUT /api/v1/List/ProductType/Items/{itemId}/Headings
```

Saves headings for the ProductType list's item.


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
PUT /api/v1/List/ProductType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 947,
    "Name": "Pfannerstill-O'Hara",
    "ToolTip": "Ea et placeat voluptas.",
    "Deleted": false,
    "Rank": 39,
    "Type": "sit",
    "ColorBlock": 720,
    "IconHint": "ea",
    "Selected": false,
    "LastChanged": "1997-08-05T02:49:52.3909486+02:00",
    "ChildItems": [
      {
        "Id": 593,
        "Name": "Harris, Kling and Davis",
        "ToolTip": "Voluptates accusantium blanditiis ad a dicta.",
        "Deleted": false,
        "Rank": 221,
        "Type": "aspernatur",
        "ColorBlock": 177,
        "IconHint": "vitae",
        "Selected": true,
        "LastChanged": "2001-05-25T02:49:52.3909486+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vel",
        "StyleHint": "ab",
        "Hidden": false,
        "FullName": "Prof. Eldon Stokes PhD"
      }
    ],
    "ExtraInfo": "fuga",
    "StyleHint": "necessitatibus",
    "Hidden": true,
    "FullName": "Eda Howell"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 460,
    "Name": "Nader, Wyman and Kemmer",
    "ToolTip": "Illo non minus dolor voluptatem sint suscipit est.",
    "Deleted": false,
    "Rank": 250,
    "Type": "voluptate",
    "ColorBlock": 166,
    "IconHint": "occaecati",
    "Selected": false,
    "LastChanged": "2018-08-07T02:49:52.3909486+02:00",
    "ChildItems": [
      {
        "Id": 774,
        "Name": "Donnelly Inc and Sons",
        "ToolTip": "Dolores dolores.",
        "Deleted": false,
        "Rank": 94,
        "Type": "eaque",
        "ColorBlock": 965,
        "IconHint": "quam",
        "Selected": true,
        "LastChanged": "2005-12-03T02:49:52.3909486+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quia",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Matilde Kilback",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 343
          }
        }
      }
    ],
    "ExtraInfo": "quisquam",
    "StyleHint": "odio",
    "Hidden": true,
    "FullName": "Miss Trudie Keebler",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 161
      }
    }
  }
]
```