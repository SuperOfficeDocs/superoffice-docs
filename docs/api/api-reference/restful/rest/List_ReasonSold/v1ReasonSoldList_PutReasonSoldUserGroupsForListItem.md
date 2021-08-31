---
title: PUT List/ReasonSold/Items/{id}/UserGroups
id: v1ReasonSoldList_PutReasonSoldUserGroupsForListItem
---

# PUT List/ReasonSold/Items/{id}/UserGroups

```http
PUT /api/v1/List/ReasonSold/Items/{itemId}/UserGroups
```

Saves user groups visible for the ReasonSold list's item.

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
PUT /api/v1/List/ReasonSold/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 979,
    "Name": "Schiller-Romaguera",
    "ToolTip": "Enim ut impedit qui perferendis quia.",
    "Deleted": true,
    "Rank": 430,
    "Type": "laudantium",
    "ColorBlock": 121,
    "IconHint": "neque",
    "Selected": false,
    "LastChanged": "2015-08-07T15:05:43.7621169+02:00",
    "ChildItems": [
      {
        "Id": 420,
        "Name": "Johnston-Hammes",
        "ToolTip": "Dolorem placeat occaecati.",
        "Deleted": true,
        "Rank": 383,
        "Type": "aliquid",
        "ColorBlock": 444,
        "IconHint": "cumque",
        "Selected": true,
        "LastChanged": "2009-02-05T15:05:43.7621169+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "id",
        "StyleHint": "quo",
        "Hidden": false,
        "FullName": "Stanley Powlowski"
      }
    ],
    "ExtraInfo": "numquam",
    "StyleHint": "earum",
    "Hidden": true,
    "FullName": "Maxine Johnson"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 907,
    "Name": "Schuster-Gottlieb",
    "ToolTip": "Sit laboriosam autem et quam voluptas.",
    "Deleted": false,
    "Rank": 907,
    "Type": "eos",
    "ColorBlock": 542,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2000-10-21T15:05:43.7631202+02:00",
    "ChildItems": [
      {
        "Id": 90,
        "Name": "Johnston, Brown and Haley",
        "ToolTip": "Incidunt reprehenderit.",
        "Deleted": false,
        "Rank": 399,
        "Type": "aperiam",
        "ColorBlock": 379,
        "IconHint": "voluptatum",
        "Selected": false,
        "LastChanged": "2015-07-03T15:05:43.7631202+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "porro",
        "StyleHint": "recusandae",
        "Hidden": true,
        "FullName": "Mollie Steuber",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 835
          }
        }
      }
    ],
    "ExtraInfo": "a",
    "StyleHint": "saepe",
    "Hidden": true,
    "FullName": "Trystan Conn",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "matrix rich applications"
        },
        "FieldType": "System.String",
        "FieldLength": 292
      }
    }
  }
]
```