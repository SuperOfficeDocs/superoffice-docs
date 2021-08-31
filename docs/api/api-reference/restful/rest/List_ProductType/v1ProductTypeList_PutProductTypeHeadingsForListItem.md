---
title: PUT List/ProductType/Items/{id}/Headings
id: v1ProductTypeList_PutProductTypeHeadingsForListItem
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
PUT /api/v1/List/ProductType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 378,
    "Name": "Kuvalis, Koelpin and Ortiz",
    "ToolTip": "Omnis nulla.",
    "Deleted": false,
    "Rank": 631,
    "Type": "et",
    "ColorBlock": 706,
    "IconHint": "doloremque",
    "Selected": true,
    "LastChanged": "1999-10-15T15:05:43.6830845+02:00",
    "ChildItems": [
      {
        "Id": 13,
        "Name": "Corkery Group",
        "ToolTip": "Illum officia.",
        "Deleted": true,
        "Rank": 775,
        "Type": "reprehenderit",
        "ColorBlock": 769,
        "IconHint": "nihil",
        "Selected": false,
        "LastChanged": "1998-10-11T15:05:43.6830845+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "earum",
        "StyleHint": "reprehenderit",
        "Hidden": false,
        "FullName": "Ms. Harold Schiller"
      }
    ],
    "ExtraInfo": "consequatur",
    "StyleHint": "minus",
    "Hidden": true,
    "FullName": "Dorcas Eichmann"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 286,
    "Name": "Lebsack LLC",
    "ToolTip": "Dolor qui quis corporis et unde ratione.",
    "Deleted": false,
    "Rank": 464,
    "Type": "qui",
    "ColorBlock": 831,
    "IconHint": "ipsa",
    "Selected": false,
    "LastChanged": "2014-10-15T15:05:43.6851119+02:00",
    "ChildItems": [
      {
        "Id": 12,
        "Name": "Hessel, Glover and Brakus",
        "ToolTip": "Temporibus ab vero.",
        "Deleted": true,
        "Rank": 779,
        "Type": "et",
        "ColorBlock": 979,
        "IconHint": "consectetur",
        "Selected": true,
        "LastChanged": "1996-12-05T15:05:43.6861121+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sed",
        "StyleHint": "dolorum",
        "Hidden": true,
        "FullName": "Jolie Brakus",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 44
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "doloremque",
    "Hidden": true,
    "FullName": "Casandra Brown",
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
        "FieldLength": 638
      }
    }
  }
]
```