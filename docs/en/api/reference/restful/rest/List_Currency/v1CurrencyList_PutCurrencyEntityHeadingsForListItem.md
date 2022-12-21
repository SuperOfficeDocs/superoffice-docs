---
title: PUT List/Currency/Items/{id}/Headings
uid: v1CurrencyList_PutCurrencyEntityHeadingsForListItem
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

OK

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

## Sample request

```http!
PUT /api/v1/List/Currency/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 332,
    "Name": "Miller, Hudson and Murazik",
    "ToolTip": "Inventore blanditiis aut tempore fugit voluptas.",
    "Deleted": false,
    "Rank": 393,
    "Type": "odit",
    "ColorBlock": 713,
    "IconHint": "necessitatibus",
    "Selected": false,
    "LastChanged": "2013-01-11T02:49:52.2034402+01:00",
    "ChildItems": [
      {
        "Id": 908,
        "Name": "O'Keefe-Prohaska",
        "ToolTip": "Ut qui corporis quos ex amet voluptate nesciunt.",
        "Deleted": true,
        "Rank": 846,
        "Type": "a",
        "ColorBlock": 121,
        "IconHint": "a",
        "Selected": true,
        "LastChanged": "2000-07-03T02:49:52.2034402+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quam",
        "StyleHint": "ipsam",
        "Hidden": true,
        "FullName": "Bethel Beaulah Champlin IV"
      }
    ],
    "ExtraInfo": "tempora",
    "StyleHint": "rerum",
    "Hidden": false,
    "FullName": "Garth Kris"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 823,
    "Name": "Hoeger-Kozey",
    "ToolTip": "Incidunt tenetur nobis officiis minima voluptas dolores.",
    "Deleted": false,
    "Rank": 826,
    "Type": "beatae",
    "ColorBlock": 132,
    "IconHint": "exercitationem",
    "Selected": true,
    "LastChanged": "2016-06-17T02:49:52.2034402+02:00",
    "ChildItems": [
      {
        "Id": 264,
        "Name": "Kuhn, Nienow and Reichel",
        "ToolTip": "Mollitia tempore atque rem quis sit.",
        "Deleted": true,
        "Rank": 689,
        "Type": "nostrum",
        "ColorBlock": 543,
        "IconHint": "aut",
        "Selected": false,
        "LastChanged": "2019-02-09T02:49:52.2034402+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "corrupti",
        "StyleHint": "omnis",
        "Hidden": false,
        "FullName": "Mr. Hailie Gerlach",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 205
          }
        }
      }
    ],
    "ExtraInfo": "magnam",
    "StyleHint": "voluptatem",
    "Hidden": false,
    "FullName": "Jett Sauer",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 848
      }
    }
  }
]
```