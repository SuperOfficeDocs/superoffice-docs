---
title: PUT List/ProductCategory/Items/{id}/Headings
id: v1ProductCategoryList_PutProductCategoryHeadingsForListItem
---

# PUT List/ProductCategory/Items/{id}/Headings

```http
PUT /api/v1/List/ProductCategory/Items/{itemId}/Headings
```

Saves headings for the ProductCategory list's item.

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
PUT /api/v1/List/ProductCategory/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 929,
    "Name": "Weissnat-Ruecker",
    "ToolTip": "Autem voluptatem ullam alias minima.",
    "Deleted": true,
    "Rank": 73,
    "Type": "in",
    "ColorBlock": 131,
    "IconHint": "repellat",
    "Selected": true,
    "LastChanged": "1996-04-24T09:41:00.5483818+02:00",
    "ChildItems": [
      {
        "Id": 871,
        "Name": "Cronin-Runolfsson",
        "ToolTip": "Libero numquam eum officiis.",
        "Deleted": false,
        "Rank": 726,
        "Type": "qui",
        "ColorBlock": 532,
        "IconHint": "omnis",
        "Selected": true,
        "LastChanged": "2008-03-13T09:41:00.5483818+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "itaque",
        "StyleHint": "ratione",
        "Hidden": true,
        "FullName": "Clotilde Ernser"
      }
    ],
    "ExtraInfo": "quae",
    "StyleHint": "sint",
    "Hidden": false,
    "FullName": "Casandra Gerhold"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 762,
    "Name": "Pfeffer LLC",
    "ToolTip": "Rerum quibusdam ipsum et et.",
    "Deleted": false,
    "Rank": 287,
    "Type": "vel",
    "ColorBlock": 847,
    "IconHint": "ad",
    "Selected": true,
    "LastChanged": "2017-10-11T09:41:00.5503861+02:00",
    "ChildItems": [
      {
        "Id": 432,
        "Name": "Balistreri, Bechtelar and Predovic",
        "ToolTip": "Incidunt ea aut est praesentium fugit.",
        "Deleted": true,
        "Rank": 833,
        "Type": "rerum",
        "ColorBlock": 740,
        "IconHint": "qui",
        "Selected": false,
        "LastChanged": "2018-08-03T09:41:00.5513816+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "excepturi",
        "StyleHint": "exercitationem",
        "Hidden": true,
        "FullName": "Ole Hammes",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 962
          }
        }
      }
    ],
    "ExtraInfo": "iste",
    "StyleHint": "minus",
    "Hidden": true,
    "FullName": "Nasir Greenfelder",
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
        "FieldType": "System.String",
        "FieldLength": 191
      }
    }
  }
]
```