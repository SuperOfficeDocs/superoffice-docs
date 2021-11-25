---
title: PUT List/Currency/Items/{id}/Headings
id: v1CurrencyList_PutCurrencyEntityHeadingsForListItem
---

# PUT List/Currency/Items/{id}/Headings

```http
PUT /api/v1/List/Currency/Items/{itemId}/Headings
```

Saves headings for the CurrencyEntity list's item.

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
PUT /api/v1/List/Currency/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 665,
    "Name": "Grimes Group",
    "ToolTip": "Ipsum est omnis repellendus quasi numquam.",
    "Deleted": true,
    "Rank": 188,
    "Type": "sit",
    "ColorBlock": 599,
    "IconHint": "nisi",
    "Selected": false,
    "LastChanged": "2020-11-21T18:25:51.7872932+01:00",
    "ChildItems": [
      {
        "Id": 789,
        "Name": "Greenholt, Hayes and Bergstrom",
        "ToolTip": "Quasi dolores.",
        "Deleted": false,
        "Rank": 212,
        "Type": "architecto",
        "ColorBlock": 617,
        "IconHint": "qui",
        "Selected": true,
        "LastChanged": "2013-06-12T18:25:51.7883279+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "autem",
        "StyleHint": "fugiat",
        "Hidden": true,
        "FullName": "Brody Paucek"
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "eveniet",
    "Hidden": false,
    "FullName": "Clarissa Abshire"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 369,
    "Name": "Block Group",
    "ToolTip": "Deleniti et voluptas ut itaque vel fugit.",
    "Deleted": true,
    "Rank": 287,
    "Type": "expedita",
    "ColorBlock": 214,
    "IconHint": "officiis",
    "Selected": false,
    "LastChanged": "2021-11-18T18:25:51.7893298+01:00",
    "ChildItems": [
      {
        "Id": 649,
        "Name": "Mosciski Inc and Sons",
        "ToolTip": "Consectetur dolores.",
        "Deleted": true,
        "Rank": 283,
        "Type": "non",
        "ColorBlock": 470,
        "IconHint": "velit",
        "Selected": false,
        "LastChanged": "2008-02-21T18:25:51.7893298+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "saepe",
        "StyleHint": "reprehenderit",
        "Hidden": true,
        "FullName": "Marcus Fisher",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 918
          }
        }
      }
    ],
    "ExtraInfo": "consequatur",
    "StyleHint": "ut",
    "Hidden": true,
    "FullName": "Milton Sanford IV",
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
        "FieldLength": 987
      }
    }
  }
]
```