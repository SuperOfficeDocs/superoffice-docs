---
title: PUT List/{udListDefinitionName}/Items/{id}/UserGroups
id: v1ListItemEntity_SetVisibleForUserGroupsFromListName
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
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 938,
    "Name": "O'Reilly, Lubowitz and Kerluke",
    "ToolTip": "Mollitia quo consequatur libero harum non.",
    "Deleted": true,
    "Rank": 837,
    "Type": "adipisci",
    "ColorBlock": 828,
    "IconHint": "quasi",
    "Selected": true,
    "LastChanged": "2001-05-26T18:25:51.5832948+02:00",
    "ChildItems": [
      {
        "Id": 387,
        "Name": "Hermann Inc and Sons",
        "ToolTip": "Totam nulla velit suscipit nam exercitationem odio.",
        "Deleted": false,
        "Rank": 898,
        "Type": "odio",
        "ColorBlock": 516,
        "IconHint": "voluptatum",
        "Selected": true,
        "LastChanged": "2006-11-02T18:25:51.5832948+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "voluptas",
        "Hidden": true,
        "FullName": "Anderson Ward"
      }
    ],
    "ExtraInfo": "illo",
    "StyleHint": "accusantium",
    "Hidden": true,
    "FullName": "Jacinthe Hackett"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 389,
    "Name": "Wiegand, Hagenes and VonRueden",
    "ToolTip": "Provident deleniti excepturi consectetur nemo.",
    "Deleted": false,
    "Rank": 558,
    "Type": "aut",
    "ColorBlock": 373,
    "IconHint": "cum",
    "Selected": false,
    "LastChanged": "2008-01-13T18:25:51.5842949+01:00",
    "ChildItems": [
      {
        "Id": 530,
        "Name": "Rau-Kautzer",
        "ToolTip": "Aliquam quidem et praesentium.",
        "Deleted": true,
        "Rank": 697,
        "Type": "aperiam",
        "ColorBlock": 69,
        "IconHint": "praesentium",
        "Selected": true,
        "LastChanged": "2010-09-27T18:25:51.5842949+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "fugiat",
        "StyleHint": "alias",
        "Hidden": true,
        "FullName": "Johnnie Gottlieb",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 647
          }
        }
      }
    ],
    "ExtraInfo": "modi",
    "StyleHint": "iste",
    "Hidden": true,
    "FullName": "D'angelo Larson",
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
        "FieldLength": 99
      }
    }
  }
]
```