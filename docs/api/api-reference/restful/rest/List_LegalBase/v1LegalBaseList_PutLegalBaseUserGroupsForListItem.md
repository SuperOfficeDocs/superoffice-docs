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
    "Id": 376,
    "Name": "Herman Group",
    "ToolTip": "Vitae perspiciatis.",
    "Deleted": true,
    "Rank": 126,
    "Type": "animi",
    "ColorBlock": 302,
    "IconHint": "officia",
    "Selected": true,
    "LastChanged": "2012-03-31T15:05:43.5065624+02:00",
    "ChildItems": [
      {
        "Id": 514,
        "Name": "Stracke LLC",
        "ToolTip": "Facere autem facere nihil deserunt.",
        "Deleted": false,
        "Rank": 579,
        "Type": "veniam",
        "ColorBlock": 259,
        "IconHint": "dolores",
        "Selected": true,
        "LastChanged": "1995-09-14T15:05:43.5065624+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "architecto",
        "StyleHint": "maxime",
        "Hidden": true,
        "FullName": "Lavinia Armstrong V"
      }
    ],
    "ExtraInfo": "repellendus",
    "StyleHint": "qui",
    "Hidden": false,
    "FullName": "Dasia Rempel"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 773,
    "Name": "Nikolaus, Towne and Dach",
    "ToolTip": "Ipsam expedita autem laborum quis inventore.",
    "Deleted": true,
    "Rank": 417,
    "Type": "omnis",
    "ColorBlock": 464,
    "IconHint": "nihil",
    "Selected": false,
    "LastChanged": "2011-05-08T15:05:43.5085652+02:00",
    "ChildItems": [
      {
        "Id": 181,
        "Name": "Green LLC",
        "ToolTip": "Provident odio.",
        "Deleted": true,
        "Rank": 3,
        "Type": "corrupti",
        "ColorBlock": 557,
        "IconHint": "nulla",
        "Selected": true,
        "LastChanged": "2000-04-03T15:05:43.5085652+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Constantin Wiegand MD",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 543
          }
        }
      }
    ],
    "ExtraInfo": "nihil",
    "StyleHint": "reprehenderit",
    "Hidden": false,
    "FullName": "Kiara Heller",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "empower user-centric supply-chains"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 504
      }
    }
  }
]
```