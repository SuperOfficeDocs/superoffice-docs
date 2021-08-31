---
title: PUT List/Competitor/Items/{id}/Headings
id: v1CompetitorList_PutCompetitorHeadingsForListItem
---

# PUT List/Competitor/Items/{id}/Headings

```http
PUT /api/v1/List/Competitor/Items/{itemId}/Headings
```

Saves headings for the Competitor list's item.

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
PUT /api/v1/List/Competitor/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 832,
    "Name": "Goyette-Powlowski",
    "ToolTip": "Fugiat nemo voluptatem velit blanditiis.",
    "Deleted": true,
    "Rank": 801,
    "Type": "explicabo",
    "ColorBlock": 800,
    "IconHint": "ipsum",
    "Selected": true,
    "LastChanged": "2001-09-04T15:05:43.3245403+02:00",
    "ChildItems": [
      {
        "Id": 838,
        "Name": "Keebler, Christiansen and Crona",
        "ToolTip": "Et possimus repudiandae eaque labore.",
        "Deleted": true,
        "Rank": 963,
        "Type": "natus",
        "ColorBlock": 586,
        "IconHint": "possimus",
        "Selected": true,
        "LastChanged": "2020-04-06T15:05:43.3245403+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vel",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Casey Koch"
      }
    ],
    "ExtraInfo": "rerum",
    "StyleHint": "non",
    "Hidden": true,
    "FullName": "Miss Mikayla Hyatt"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 894,
    "Name": "Hammes-Stanton",
    "ToolTip": "Qui fuga aut.",
    "Deleted": false,
    "Rank": 401,
    "Type": "optio",
    "ColorBlock": 548,
    "IconHint": "ut",
    "Selected": true,
    "LastChanged": "2014-10-12T15:05:43.32654+02:00",
    "ChildItems": [
      {
        "Id": 452,
        "Name": "Howe, Rath and Leuschke",
        "ToolTip": "Id occaecati adipisci molestiae non non.",
        "Deleted": true,
        "Rank": 613,
        "Type": "quaerat",
        "ColorBlock": 708,
        "IconHint": "fugiat",
        "Selected": false,
        "LastChanged": "1996-03-17T15:05:43.32654+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "vitae",
        "Hidden": true,
        "FullName": "Heaven Baumbach",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 634
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "ex",
    "Hidden": false,
    "FullName": "Kelvin Rau",
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
        "FieldLength": 539
      }
    }
  }
]
```