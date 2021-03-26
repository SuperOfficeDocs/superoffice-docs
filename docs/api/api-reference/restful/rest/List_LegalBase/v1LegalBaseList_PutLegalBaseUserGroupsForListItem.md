---
title: PUT List/LegalBase/Items/{id}/UserGroups
id: v1LegalBaseList_PutLegalBaseUserGroupsForListItem
---

# PUT List/LegalBase/Items/{id}/UserGroups

```http
PUT /api/v1/List/LegalBase/Items/{itemId}/UserGroups
```

Saves user groups visible for the LegalBase list's item.

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
PUT /api/v1/List/LegalBase/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 789,
    "Name": "Torp-Wolff",
    "ToolTip": "Quam necessitatibus qui in quod ut incidunt.",
    "Deleted": false,
    "Rank": 846,
    "Type": "est",
    "ColorBlock": 530,
    "IconHint": "voluptatum",
    "Selected": true,
    "LastChanged": "2007-09-11T09:41:00.4443815+02:00",
    "ChildItems": [
      {
        "Id": 671,
        "Name": "Gaylord-Legros",
        "ToolTip": "Consequatur aperiam.",
        "Deleted": true,
        "Rank": 829,
        "Type": "repellat",
        "ColorBlock": 712,
        "IconHint": "ab",
        "Selected": true,
        "LastChanged": "1999-05-05T09:41:00.4443815+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "doloribus",
        "StyleHint": "fugiat",
        "Hidden": true,
        "FullName": "Rosanna Will"
      }
    ],
    "ExtraInfo": "aperiam",
    "StyleHint": "officiis",
    "Hidden": true,
    "FullName": "Misael Hansen I"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 791,
    "Name": "Dibbert LLC",
    "ToolTip": "Sunt quibusdam ipsam.",
    "Deleted": false,
    "Rank": 965,
    "Type": "voluptas",
    "ColorBlock": 497,
    "IconHint": "porro",
    "Selected": false,
    "LastChanged": "2003-01-24T09:41:00.4453835+01:00",
    "ChildItems": [
      {
        "Id": 702,
        "Name": "Pfannerstill-Spinka",
        "ToolTip": "Tempora placeat exercitationem.",
        "Deleted": true,
        "Rank": 34,
        "Type": "nobis",
        "ColorBlock": 475,
        "IconHint": "dolorum",
        "Selected": false,
        "LastChanged": "1997-03-20T09:41:00.4453835+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "doloribus",
        "StyleHint": "ullam",
        "Hidden": false,
        "FullName": "Kimberly Ankunding",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 924
          }
        }
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "sit",
    "Hidden": true,
    "FullName": "Elizabeth Reinger",
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
        "FieldLength": 199
      }
    }
  }
]
```