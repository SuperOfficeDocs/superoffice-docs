---
title: GET List/ProductFamily/Items/{id}/UserGroups
uid: v1ProductFamilyList_GetProductFamilyUserGroupsForListItem
---

# GET List/ProductFamily/Items/{id}/UserGroups

```http
GET /api/v1/List/ProductFamily/Items/{itemId}/UserGroups
```

Gets user groups visible for the ProductFamily list's item.


Calls the List agent service GetHeadings.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to get. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/List/ProductFamily/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 814,
    "Name": "Sawayn-Reichel",
    "ToolTip": "Assumenda ex nulla veniam.",
    "Deleted": false,
    "Rank": 628,
    "Type": "odit",
    "ColorBlock": 366,
    "IconHint": "eos",
    "Selected": true,
    "LastChanged": "2010-11-29T11:10:54.4339392+01:00",
    "ChildItems": [
      {
        "Id": 812,
        "Name": "Little-Brakus",
        "ToolTip": "Et doloremque voluptatibus voluptatem voluptas.",
        "Deleted": false,
        "Rank": 659,
        "Type": "repellat",
        "ColorBlock": 154,
        "IconHint": "corrupti",
        "Selected": true,
        "LastChanged": "2005-07-29T11:10:54.4349299+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "dolores",
        "Hidden": false,
        "FullName": "Simone Treutel",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 144
          }
        }
      }
    ],
    "ExtraInfo": "occaecati",
    "StyleHint": "quisquam",
    "Hidden": false,
    "FullName": "Miss Jasen Langosh II",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 378
      }
    }
  }
]
```