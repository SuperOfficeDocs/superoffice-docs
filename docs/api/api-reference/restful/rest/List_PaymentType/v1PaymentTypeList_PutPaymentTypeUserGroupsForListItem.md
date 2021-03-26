---
title: PUT List/PaymentType/Items/{id}/UserGroups
id: v1PaymentTypeList_PutPaymentTypeUserGroupsForListItem
---

# PUT List/PaymentType/Items/{id}/UserGroups

```http
PUT /api/v1/List/PaymentType/Items/{itemId}/UserGroups
```

Saves user groups visible for the PaymentType list's item.

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
PUT /api/v1/List/PaymentType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 570,
    "Name": "Aufderhar, Volkman and Paucek",
    "ToolTip": "Amet rerum id velit consequuntur est praesentium.",
    "Deleted": false,
    "Rank": 340,
    "Type": "perferendis",
    "ColorBlock": 46,
    "IconHint": "quia",
    "Selected": true,
    "LastChanged": "2010-11-21T09:41:00.4943822+01:00",
    "ChildItems": [
      {
        "Id": 728,
        "Name": "Frami-Hane",
        "ToolTip": "Illum at sed.",
        "Deleted": false,
        "Rank": 681,
        "Type": "laboriosam",
        "ColorBlock": 39,
        "IconHint": "ratione",
        "Selected": true,
        "LastChanged": "1998-03-23T09:41:00.4943822+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "quod",
        "Hidden": true,
        "FullName": "Megane Weimann"
      }
    ],
    "ExtraInfo": "optio",
    "StyleHint": "numquam",
    "Hidden": true,
    "FullName": "Keith Block"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 463,
    "Name": "Stokes, Parisian and Considine",
    "ToolTip": "Facere quisquam.",
    "Deleted": false,
    "Rank": 362,
    "Type": "nihil",
    "ColorBlock": 971,
    "IconHint": "illum",
    "Selected": false,
    "LastChanged": "2017-09-30T09:41:00.4953789+02:00",
    "ChildItems": [
      {
        "Id": 539,
        "Name": "Hamill, Lubowitz and Harris",
        "ToolTip": "Laboriosam nostrum quaerat est nam.",
        "Deleted": false,
        "Rank": 107,
        "Type": "dolores",
        "ColorBlock": 666,
        "IconHint": "fugiat",
        "Selected": false,
        "LastChanged": "1994-12-16T09:41:00.4953789+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "iusto",
        "StyleHint": "repudiandae",
        "Hidden": true,
        "FullName": "Bud Friesen",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 316
          }
        }
      }
    ],
    "ExtraInfo": "veritatis",
    "StyleHint": "nam",
    "Hidden": true,
    "FullName": "Breana Douglas",
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
        "FieldLength": 213
      }
    }
  }
]
```