---
title: PUT List/Credited/Items/{id}/UserGroups
id: v1CreditedList_PutCreditedUserGroupsForListItem
---

# PUT List/Credited/Items/{id}/UserGroups

```http
PUT /api/v1/List/Credited/Items/{itemId}/UserGroups
```

Saves user groups visible for the Credited list's item.

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
PUT /api/v1/List/Credited/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 522,
    "Name": "Zboncak Group",
    "ToolTip": "Cum reiciendis voluptatem enim rerum blanditiis.",
    "Deleted": true,
    "Rank": 497,
    "Type": "omnis",
    "ColorBlock": 856,
    "IconHint": "qui",
    "Selected": false,
    "LastChanged": "2008-08-06T09:41:00.3173668+02:00",
    "ChildItems": [
      {
        "Id": 429,
        "Name": "Pfannerstill, Cole and Willms",
        "ToolTip": "Et dignissimos suscipit.",
        "Deleted": true,
        "Rank": 106,
        "Type": "qui",
        "ColorBlock": 143,
        "IconHint": "error",
        "Selected": true,
        "LastChanged": "2000-04-27T09:41:00.3173668+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "distinctio",
        "StyleHint": "rerum",
        "Hidden": false,
        "FullName": "Ernie Corwin"
      }
    ],
    "ExtraInfo": "sit",
    "StyleHint": "harum",
    "Hidden": false,
    "FullName": "Mrs. Rickey Towne"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 104,
    "Name": "Cole, Ortiz and Luettgen",
    "ToolTip": "Voluptas rerum quo aut sint labore.",
    "Deleted": true,
    "Rank": 254,
    "Type": "consequuntur",
    "ColorBlock": 904,
    "IconHint": "libero",
    "Selected": false,
    "LastChanged": "1997-12-25T09:41:00.318367+01:00",
    "ChildItems": [
      {
        "Id": 152,
        "Name": "Metz Inc and Sons",
        "ToolTip": "Magni reiciendis exercitationem delectus nam.",
        "Deleted": false,
        "Rank": 108,
        "Type": "labore",
        "ColorBlock": 785,
        "IconHint": "magni",
        "Selected": false,
        "LastChanged": "2003-11-10T09:41:00.318367+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptate",
        "StyleHint": "autem",
        "Hidden": false,
        "FullName": "Brooke Miller",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 977
          }
        }
      }
    ],
    "ExtraInfo": "id",
    "StyleHint": "tenetur",
    "Hidden": false,
    "FullName": "Kelly Walter",
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
        "FieldLength": 305
      }
    }
  }
]
```