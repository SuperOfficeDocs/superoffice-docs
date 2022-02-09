---
title: PUT List/DeliveryTerm/Items/{id}/UserGroups
id: v1DeliveryTermsList_PutDeliveryTermUserGroupsForListItem
---

# PUT List/DeliveryTerm/Items/{id}/UserGroups

```http
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/UserGroups
```

Saves user groups visible for the DeliveryTerm list's item.

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
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 740,
    "Name": "Labadie Inc and Sons",
    "ToolTip": "Iusto distinctio.",
    "Deleted": false,
    "Rank": 995,
    "Type": "exercitationem",
    "ColorBlock": 249,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2015-11-20T18:25:51.800328+01:00",
    "ChildItems": [
      {
        "Id": 185,
        "Name": "Dibbert-Hessel",
        "ToolTip": "Sequi ad repellendus aut aspernatur.",
        "Deleted": false,
        "Rank": 514,
        "Type": "magni",
        "ColorBlock": 257,
        "IconHint": "voluptatem",
        "Selected": true,
        "LastChanged": "1996-06-06T18:25:51.800328+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aliquid",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Howard Beatty"
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "doloremque",
    "Hidden": false,
    "FullName": "Isabelle Heller DVM"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 511,
    "Name": "Emard LLC",
    "ToolTip": "Molestias officia vero ut.",
    "Deleted": true,
    "Rank": 517,
    "Type": "laborum",
    "ColorBlock": 723,
    "IconHint": "architecto",
    "Selected": false,
    "LastChanged": "2008-03-18T18:25:51.8023264+01:00",
    "ChildItems": [
      {
        "Id": 373,
        "Name": "Bernhard Group",
        "ToolTip": "Qui nobis debitis cupiditate.",
        "Deleted": false,
        "Rank": 352,
        "Type": "occaecati",
        "ColorBlock": 485,
        "IconHint": "voluptatem",
        "Selected": false,
        "LastChanged": "2019-01-23T18:25:51.8023264+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "accusantium",
        "StyleHint": "consectetur",
        "Hidden": true,
        "FullName": "Eveline Zboncak",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 580
          }
        }
      }
    ],
    "ExtraInfo": "natus",
    "StyleHint": "possimus",
    "Hidden": false,
    "FullName": "Melvin Nolan",
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
        "FieldLength": 725
      }
    }
  }
]
```