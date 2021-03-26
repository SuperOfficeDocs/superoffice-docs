---
title: PUT List/ProductFamily/Items/{id}/UserGroups
id: v1ProductFamilyList_PutProductFamilyUserGroupsForListItem
---

# PUT List/ProductFamily/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProductFamily/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProductFamily list's item.

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
PUT /api/v1/List/ProductFamily/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 538,
    "Name": "Barton Group",
    "ToolTip": "Blanditiis ab modi recusandae laborum minus.",
    "Deleted": true,
    "Rank": 498,
    "Type": "iure",
    "ColorBlock": 743,
    "IconHint": "vitae",
    "Selected": true,
    "LastChanged": "2011-06-22T09:41:00.5603815+02:00",
    "ChildItems": [
      {
        "Id": 305,
        "Name": "Bradtke, Wintheiser and Jenkins",
        "ToolTip": "Voluptatem totam impedit qui.",
        "Deleted": true,
        "Rank": 808,
        "Type": "eum",
        "ColorBlock": 768,
        "IconHint": "saepe",
        "Selected": true,
        "LastChanged": "2018-05-21T09:41:00.5603815+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "occaecati",
        "StyleHint": "possimus",
        "Hidden": true,
        "FullName": "Delilah Block"
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "ducimus",
    "Hidden": false,
    "FullName": "Howell Kerluke"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 446,
    "Name": "Runolfsson, McGlynn and Osinski",
    "ToolTip": "Illo dolorem molestiae dolorem voluptatem est.",
    "Deleted": true,
    "Rank": 105,
    "Type": "enim",
    "ColorBlock": 11,
    "IconHint": "non",
    "Selected": false,
    "LastChanged": "2010-09-29T09:41:00.5633816+02:00",
    "ChildItems": [
      {
        "Id": 199,
        "Name": "Murphy Group",
        "ToolTip": "Aliquam autem inventore rerum ducimus.",
        "Deleted": false,
        "Rank": 604,
        "Type": "accusantium",
        "ColorBlock": 968,
        "IconHint": "et",
        "Selected": true,
        "LastChanged": "2014-11-11T09:41:00.5633816+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quibusdam",
        "StyleHint": "excepturi",
        "Hidden": true,
        "FullName": "Maureen Torp",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 360
          }
        }
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "dolore",
    "Hidden": false,
    "FullName": "Marilyne Christiansen III",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "integrate dynamic platforms"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 932
      }
    }
  }
]
```