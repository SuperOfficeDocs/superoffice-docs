---
title: PUT List/Rating/Items/{id}/UserGroups
id: v1RatingList_PutSaleStageEntityUserGroupsForListItem
---

# PUT List/Rating/Items/{id}/UserGroups

```http
PUT /api/v1/List/Rating/Items/{itemId}/UserGroups
```

Saves user groups visible for the SaleStageEntity list's item.

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
PUT /api/v1/List/Rating/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 309,
    "Name": "Homenick, Crooks and White",
    "ToolTip": "Repellendus dolor consequatur.",
    "Deleted": true,
    "Rank": 528,
    "Type": "consectetur",
    "ColorBlock": 488,
    "IconHint": "eius",
    "Selected": true,
    "LastChanged": "2012-05-14T18:25:52.1180192+02:00",
    "ChildItems": [
      {
        "Id": 721,
        "Name": "Upton, Frami and Collier",
        "ToolTip": "Sed sunt tenetur perspiciatis laboriosam est soluta.",
        "Deleted": true,
        "Rank": 609,
        "Type": "et",
        "ColorBlock": 28,
        "IconHint": "sed",
        "Selected": true,
        "LastChanged": "2021-07-24T18:25:52.1180192+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nisi",
        "StyleHint": "ratione",
        "Hidden": false,
        "FullName": "Moriah Beer"
      }
    ],
    "ExtraInfo": "quaerat",
    "StyleHint": "eos",
    "Hidden": false,
    "FullName": "Katrina Beier"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 765,
    "Name": "Ward, Volkman and Stokes",
    "ToolTip": "Veritatis quia.",
    "Deleted": false,
    "Rank": 767,
    "Type": "repudiandae",
    "ColorBlock": 288,
    "IconHint": "distinctio",
    "Selected": false,
    "LastChanged": "2004-02-18T18:25:52.1200204+01:00",
    "ChildItems": [
      {
        "Id": 370,
        "Name": "Boehm, Doyle and Collier",
        "ToolTip": "Recusandae quis sit voluptas sint tempore.",
        "Deleted": true,
        "Rank": 948,
        "Type": "rem",
        "ColorBlock": 496,
        "IconHint": "perferendis",
        "Selected": true,
        "LastChanged": "2006-07-03T18:25:52.1200204+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "impedit",
        "StyleHint": "consequatur",
        "Hidden": true,
        "FullName": "Susie Connelly",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 92
          }
        }
      }
    ],
    "ExtraInfo": "mollitia",
    "StyleHint": "labore",
    "Hidden": false,
    "FullName": "Taryn Zieme",
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
        "FieldType": "System.String",
        "FieldLength": 703
      }
    }
  }
]
```