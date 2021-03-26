---
title: PUT List/{id}/Items/{id}/UserGroups
id: v1ListItemEntity_SetVisibleForUserGroups
---

# PUT List/{id}/Items/{id}/UserGroups

```http
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
```

Update User groups that this list item is visible for






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
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
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 416,
    "Name": "Mills-McLaughlin",
    "ToolTip": "In omnis eius animi.",
    "Deleted": true,
    "Rank": 388,
    "Type": "quasi",
    "ColorBlock": 69,
    "IconHint": "et",
    "Selected": true,
    "LastChanged": "2001-10-10T09:41:00.1303661+02:00",
    "ChildItems": [
      {
        "Id": 809,
        "Name": "Hagenes LLC",
        "ToolTip": "Modi reprehenderit sed.",
        "Deleted": false,
        "Rank": 335,
        "Type": "et",
        "ColorBlock": 635,
        "IconHint": "veritatis",
        "Selected": true,
        "LastChanged": "2009-10-28T09:41:00.1313612+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "distinctio",
        "StyleHint": "molestiae",
        "Hidden": false,
        "FullName": "Evangeline Muller"
      }
    ],
    "ExtraInfo": "reiciendis",
    "StyleHint": "excepturi",
    "Hidden": true,
    "FullName": "Nettie Huel"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 130,
    "Name": "Gerlach, Gerhold and Parisian",
    "ToolTip": "Ipsam sapiente ratione.",
    "Deleted": false,
    "Rank": 701,
    "Type": "ut",
    "ColorBlock": 318,
    "IconHint": "porro",
    "Selected": true,
    "LastChanged": "2015-12-14T09:41:00.1323619+01:00",
    "ChildItems": [
      {
        "Id": 676,
        "Name": "Pollich LLC",
        "ToolTip": "Sit esse qui dolorem corrupti ratione praesentium.",
        "Deleted": true,
        "Rank": 820,
        "Type": "asperiores",
        "ColorBlock": 333,
        "IconHint": "ut",
        "Selected": true,
        "LastChanged": "2017-01-26T09:41:00.1323619+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolores",
        "StyleHint": "quaerat",
        "Hidden": false,
        "FullName": "Delores Larkin DVM",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 620
          }
        }
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "dolores",
    "Hidden": false,
    "FullName": "Roosevelt Boyer",
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
        "FieldLength": 883
      }
    }
  }
]
```