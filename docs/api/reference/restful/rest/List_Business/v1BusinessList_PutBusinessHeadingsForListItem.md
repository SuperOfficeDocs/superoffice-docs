---
title: PUT List/Business/Items/{id}/Headings
id: v1BusinessList_PutBusinessHeadingsForListItem
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

## Sample Request

```http!
PUT /api/v1/List/Business/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 204,
    "Name": "Beahan LLC",
    "ToolTip": "Voluptatem doloremque consequatur qui dignissimos.",
    "Deleted": true,
    "Rank": 803,
    "Type": "et",
    "ColorBlock": 549,
    "IconHint": "doloribus",
    "Selected": true,
    "LastChanged": "2017-12-14T18:25:51.6262944+01:00",
    "ChildItems": [
      {
        "Id": 413,
        "Name": "Hills Inc and Sons",
        "ToolTip": "Doloribus est qui ducimus necessitatibus possimus.",
        "Deleted": false,
        "Rank": 876,
        "Type": "fuga",
        "ColorBlock": 420,
        "IconHint": "nostrum",
        "Selected": true,
        "LastChanged": "2009-04-12T18:25:51.6262944+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aspernatur",
        "StyleHint": "doloremque",
        "Hidden": false,
        "FullName": "Nedra Rath"
      }
    ],
    "ExtraInfo": "fugiat",
    "StyleHint": "quibusdam",
    "Hidden": true,
    "FullName": "Cordie Hane"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 677,
    "Name": "Ruecker, Bogisich and Fadel",
    "ToolTip": "Odio ratione nisi veritatis consectetur et ipsa.",
    "Deleted": false,
    "Rank": 571,
    "Type": "suscipit",
    "ColorBlock": 792,
    "IconHint": "voluptatem",
    "Selected": false,
    "LastChanged": "2021-03-03T18:25:51.6272946+01:00",
    "ChildItems": [
      {
        "Id": 77,
        "Name": "Stokes, Bashirian and Botsford",
        "ToolTip": "Ad sequi omnis ut omnis.",
        "Deleted": false,
        "Rank": 719,
        "Type": "quaerat",
        "ColorBlock": 823,
        "IconHint": "sapiente",
        "Selected": false,
        "LastChanged": "2000-08-28T18:25:51.6272946+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "error",
        "StyleHint": "explicabo",
        "Hidden": true,
        "FullName": "Shakira Gutmann",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 703
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "quasi",
    "Hidden": true,
    "FullName": "Nova Stark PhD",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 232
      }
    }
  }
]
```