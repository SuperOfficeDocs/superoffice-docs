---
title: PUT List/Credited/Items/{id}/Headings
uid: v1CreditedList_PutCreditedHeadingsForListItem
---

# PUT List/Credited/Items/{id}/Headings

```http
PUT /api/v1/List/Credited/Items/{itemId}/Headings
```

Saves headings for the Credited list's item.


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
| Id | Integer | The Id of the ListItem |
| Name | String | The name of the ListItem |
| ToolTip | String | The tooltip of the ListItem |
| Deleted | Boolean | The deleted status of the ListItem |
| Rank | Integer | The rank of the ListItem |
| Type | String | The type of the ListItem. Custom field. |
| ColorBlock | Integer | The color indicator of the ListItem color block |
| IconHint | String | The Icon hint of the ListItem. Custom field. |
| Selected | Boolean | True if the ListItem is selected |
| LastChanged | String | Time of last change. |
| ChildItems | Array | The child items of the SelectableMDOListItem |
| ExtraInfo | String | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | String | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | Boolean | True if the ListItem is hidden |
| FullName | String | The name of the ListItem in its context |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/Credited/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 94,
    "Name": "Jerde, Hessel and Greenholt",
    "ToolTip": "Consequatur eveniet exercitationem aliquid perferendis exercitationem aut tempore.",
    "Deleted": false,
    "Rank": 480,
    "Type": "molestias",
    "ColorBlock": 440,
    "IconHint": "maxime",
    "Selected": false,
    "LastChanged": "1999-11-27T17:37:39.9485073+01:00",
    "ChildItems": [
      {
        "Id": 341,
        "Name": "Mayer-Berge",
        "ToolTip": "Et accusamus laboriosam veritatis.",
        "Deleted": false,
        "Rank": 825,
        "Type": "assumenda",
        "ColorBlock": 826,
        "IconHint": "dicta",
        "Selected": true,
        "LastChanged": "2004-12-18T17:37:39.9485073+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "at",
        "StyleHint": "suscipit",
        "Hidden": false,
        "FullName": "Mr. Marley Nigel Goyette II"
      }
    ],
    "ExtraInfo": "quasi",
    "StyleHint": "adipisci",
    "Hidden": true,
    "FullName": "Mr. Henriette Barbara Fadel MD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 625,
    "Name": "Muller, Hackett and Kutch",
    "ToolTip": "Voluptas ad nam qui autem ut provident.",
    "Deleted": false,
    "Rank": 192,
    "Type": "veritatis",
    "ColorBlock": 953,
    "IconHint": "vel",
    "Selected": true,
    "LastChanged": "2015-05-17T17:37:39.9515055+02:00",
    "ChildItems": [
      {
        "Id": 781,
        "Name": "Bergstrom-Kutch",
        "ToolTip": "Dolorem et tenetur.",
        "Deleted": false,
        "Rank": 905,
        "Type": "impedit",
        "ColorBlock": 91,
        "IconHint": "qui",
        "Selected": false,
        "LastChanged": "2000-02-15T17:37:39.9515055+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ducimus",
        "StyleHint": "aut",
        "Hidden": true,
        "FullName": "Candice Fahey",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 617
          }
        }
      }
    ],
    "ExtraInfo": "exercitationem",
    "StyleHint": "aut",
    "Hidden": false,
    "FullName": "Macie Huels Sr.",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 433
      }
    }
  }
]
```