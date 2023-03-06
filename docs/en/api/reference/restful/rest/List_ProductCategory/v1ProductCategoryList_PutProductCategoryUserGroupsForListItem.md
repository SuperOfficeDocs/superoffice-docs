---
title: PUT List/ProductCategory/Items/{id}/UserGroups
uid: v1ProductCategoryList_PutProductCategoryUserGroupsForListItem
---

# PUT List/ProductCategory/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProductCategory/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProductCategory list's item.


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
PUT /api/v1/List/ProductCategory/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 619,
    "Name": "Kuphal LLC",
    "ToolTip": "Autem saepe velit aut esse mollitia possimus.",
    "Deleted": false,
    "Rank": 764,
    "Type": "officiis",
    "ColorBlock": 506,
    "IconHint": "ratione",
    "Selected": true,
    "LastChanged": "2002-09-17T14:19:11.3680268+02:00",
    "ChildItems": [
      {
        "Id": 275,
        "Name": "Hermann, Gutkowski and Towne",
        "ToolTip": "Error est quo iste.",
        "Deleted": true,
        "Rank": 945,
        "Type": "voluptatem",
        "ColorBlock": 432,
        "IconHint": "fugiat",
        "Selected": false,
        "LastChanged": "2019-11-26T14:19:11.3680268+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sunt",
        "StyleHint": "qui",
        "Hidden": true,
        "FullName": "Felipe Hudson Jr."
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "ipsam",
    "Hidden": false,
    "FullName": "Elmore Frankie Toy I"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 330,
    "Name": "Ratke-Jaskolski",
    "ToolTip": "Et quaerat consequatur.",
    "Deleted": false,
    "Rank": 62,
    "Type": "qui",
    "ColorBlock": 79,
    "IconHint": "tenetur",
    "Selected": false,
    "LastChanged": "2019-10-28T14:19:11.3680268+01:00",
    "ChildItems": [
      {
        "Id": 741,
        "Name": "Funk, Eichmann and Kovacek",
        "ToolTip": "Et esse ut ea.",
        "Deleted": false,
        "Rank": 403,
        "Type": "eaque",
        "ColorBlock": 292,
        "IconHint": "exercitationem",
        "Selected": true,
        "LastChanged": "2014-08-20T14:19:11.3680268+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "repellat",
        "Hidden": false,
        "FullName": "Pasquale O'Connell",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 216
          }
        }
      }
    ],
    "ExtraInfo": "magnam",
    "StyleHint": "fugit",
    "Hidden": false,
    "FullName": "Rosemarie Hoeger",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 929
      }
    }
  }
]
```