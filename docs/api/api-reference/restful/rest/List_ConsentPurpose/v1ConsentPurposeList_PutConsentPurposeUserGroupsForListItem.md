---
title: PUT List/ConsentPurpose/Items/{id}/UserGroups
id: v1ConsentPurposeList_PutConsentPurposeUserGroupsForListItem
---

# PUT List/ConsentPurpose/Items/{id}/UserGroups

```http
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/UserGroups
```

Saves user groups visible for the ConsentPurpose list's item.

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
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 548,
    "Name": "Daugherty, Morar and Oberbrunner",
    "ToolTip": "Eaque sequi.",
    "Deleted": false,
    "Rank": 217,
    "Type": "sed",
    "ColorBlock": 687,
    "IconHint": "itaque",
    "Selected": true,
    "LastChanged": "1999-11-08T09:41:00.265374+01:00",
    "ChildItems": [
      {
        "Id": 96,
        "Name": "Prosacco Group",
        "ToolTip": "Inventore iste et et molestiae nostrum.",
        "Deleted": true,
        "Rank": 381,
        "Type": "quae",
        "ColorBlock": 577,
        "IconHint": "ea",
        "Selected": true,
        "LastChanged": "1999-09-14T09:41:00.265374+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nihil",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Nash Nicolas"
      }
    ],
    "ExtraInfo": "tenetur",
    "StyleHint": "quasi",
    "Hidden": true,
    "FullName": "Shana Muller"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 526,
    "Name": "Wiza LLC",
    "ToolTip": "Iste dolores.",
    "Deleted": false,
    "Rank": 422,
    "Type": "quis",
    "ColorBlock": 657,
    "IconHint": "consectetur",
    "Selected": false,
    "LastChanged": "2012-07-17T09:41:00.2673669+02:00",
    "ChildItems": [
      {
        "Id": 925,
        "Name": "Miller, Mueller and Ledner",
        "ToolTip": "Aut porro omnis magni rem tenetur labore.",
        "Deleted": false,
        "Rank": 461,
        "Type": "eveniet",
        "ColorBlock": 535,
        "IconHint": "impedit",
        "Selected": true,
        "LastChanged": "2020-06-30T09:41:00.2673669+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolorem",
        "StyleHint": "doloremque",
        "Hidden": false,
        "FullName": "Fausto Lowe",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 67
          }
        }
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "dolores",
    "Hidden": false,
    "FullName": "Deondre Gaylord",
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
        "FieldLength": 739
      }
    }
  }
]
```