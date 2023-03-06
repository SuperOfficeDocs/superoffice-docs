---
title: PUT List/Category/Items/{id}/Headings
uid: v1CategoryList_PutCategoryHeadingsForListItem
---

# PUT List/Category/Items/{id}/Headings

```http
PUT /api/v1/List/Category/Items/{itemId}/Headings
```

Saves headings for the Category list's item.


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
PUT /api/v1/List/Category/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 217,
    "Name": "Schultz, Becker and Shanahan",
    "ToolTip": "Eveniet quia quis consequatur corrupti eaque.",
    "Deleted": true,
    "Rank": 816,
    "Type": "unde",
    "ColorBlock": 31,
    "IconHint": "debitis",
    "Selected": false,
    "LastChanged": "2007-11-23T14:19:11.1480931+01:00",
    "ChildItems": [
      {
        "Id": 563,
        "Name": "Gerhold-Friesen",
        "ToolTip": "Soluta qui labore.",
        "Deleted": false,
        "Rank": 952,
        "Type": "soluta",
        "ColorBlock": 419,
        "IconHint": "quaerat",
        "Selected": false,
        "LastChanged": "1996-08-28T14:19:11.1480931+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatem",
        "StyleHint": "nulla",
        "Hidden": false,
        "FullName": "Ms. Liliana Quinton Ward V"
      }
    ],
    "ExtraInfo": "omnis",
    "StyleHint": "quam",
    "Hidden": true,
    "FullName": "Mr. Ryleigh Shayna Eichmann"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 78,
    "Name": "Treutel-Gleason",
    "ToolTip": "Rerum amet non commodi eaque modi.",
    "Deleted": true,
    "Rank": 909,
    "Type": "sunt",
    "ColorBlock": 152,
    "IconHint": "qui",
    "Selected": true,
    "LastChanged": "2005-12-29T14:19:11.1480931+01:00",
    "ChildItems": [
      {
        "Id": 303,
        "Name": "Bosco Group",
        "ToolTip": "Delectus qui rerum repellat sit ut architecto nobis.",
        "Deleted": false,
        "Rank": 330,
        "Type": "illo",
        "ColorBlock": 35,
        "IconHint": "aut",
        "Selected": true,
        "LastChanged": "2010-07-24T14:19:11.1480931+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "velit",
        "StyleHint": "aperiam",
        "Hidden": false,
        "FullName": "Ms. Martina Jeanette Emmerich",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 376
          }
        }
      }
    ],
    "ExtraInfo": "inventore",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Miss Elisabeth Emmitt Rohan",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 409
      }
    }
  }
]
```