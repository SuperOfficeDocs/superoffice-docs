---
title: PUT List/SaleType/Items/{id}/Headings
id: v1SaleTypeList_PutSaleTypeEntityHeadingsForListItem
---

# PUT List/SaleType/Items/{id}/Headings

```http
PUT /api/v1/List/SaleType/Items/{itemId}/Headings
```

Saves headings for the SaleTypeEntity list's item.

Calls the List agent service SaveHeadingsForListItemFromListDefinition.




| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be saved. **Required** |



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
PUT /api/v1/List/SaleType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 870,
    "Name": "Moore Inc and Sons",
    "ToolTip": "Et qui sunt consequatur maxime.",
    "Deleted": false,
    "Rank": 285,
    "Type": "corrupti",
    "ColorBlock": 344,
    "IconHint": "officiis",
    "Selected": true,
    "LastChanged": "2012-09-14T09:41:00.741388+02:00",
    "ChildItems": [
      {
        "Id": 207,
        "Name": "Bartell-Sporer",
        "ToolTip": "Ipsam dolores.",
        "Deleted": true,
        "Rank": 572,
        "Type": "est",
        "ColorBlock": 903,
        "IconHint": "aliquid",
        "Selected": false,
        "LastChanged": "1999-09-13T09:41:00.741388+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "harum",
        "StyleHint": "eos",
        "Hidden": true,
        "FullName": "Jakob Spencer"
      }
    ],
    "ExtraInfo": "ea",
    "StyleHint": "dolore",
    "Hidden": true,
    "FullName": "Antonina Lehner Sr."
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 88,
    "Name": "Hyatt, Friesen and Cremin",
    "ToolTip": "Accusamus tenetur illo quasi dicta.",
    "Deleted": true,
    "Rank": 497,
    "Type": "est",
    "ColorBlock": 959,
    "IconHint": "nam",
    "Selected": false,
    "LastChanged": "2019-06-23T09:41:00.7423907+02:00",
    "ChildItems": [
      {
        "Id": 778,
        "Name": "Gutkowski LLC",
        "ToolTip": "Repellat adipisci eaque.",
        "Deleted": true,
        "Rank": 379,
        "Type": "qui",
        "ColorBlock": 674,
        "IconHint": "ut",
        "Selected": false,
        "LastChanged": "2020-01-27T09:41:00.7433937+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ullam",
        "StyleHint": "commodi",
        "Hidden": true,
        "FullName": "Kiel Oberbrunner",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 714
          }
        }
      }
    ],
    "ExtraInfo": "temporibus",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Sydney Kilback",
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
        "FieldLength": 750
      }
    }
  }
]
```