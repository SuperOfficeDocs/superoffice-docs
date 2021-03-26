---
title: GET List/Credited/Items/{id}/UserGroups
id: v1CreditedList_GetCreditedUserGroupsForListItem
---

# GET List/Credited/Items/{id}/UserGroups

```http
GET /api/v1/List/Credited/Items/{itemId}/UserGroups
```

Gets user groups visible for the Credited list's item.

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
GET /api/v1/List/Credited/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 507,
    "Name": "Gaylord, Von and Hegmann",
    "ToolTip": "At aperiam.",
    "Deleted": true,
    "Rank": 628,
    "Type": "voluptates",
    "ColorBlock": 412,
    "IconHint": "similique",
    "Selected": true,
    "LastChanged": "1996-04-11T09:41:00.316367+02:00",
    "ChildItems": [
      {
        "Id": 131,
        "Name": "Rodriguez Group",
        "ToolTip": "Quos sapiente consequuntur aut tenetur in sint.",
        "Deleted": false,
        "Rank": 812,
        "Type": "recusandae",
        "ColorBlock": 120,
        "IconHint": "quae",
        "Selected": false,
        "LastChanged": "1996-01-14T09:41:00.316367+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "deleniti",
        "StyleHint": "sapiente",
        "Hidden": false,
        "FullName": "Enrique Ortiz Jr.",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "unleash clicks-and-mortar infomediaries"
            },
            "FieldType": "System.Int32",
            "FieldLength": 340
          }
        }
      }
    ],
    "ExtraInfo": "distinctio",
    "StyleHint": "nostrum",
    "Hidden": false,
    "FullName": "Clare Kirlin IV",
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
        "FieldLength": 319
      }
    }
  }
]
```