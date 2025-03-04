---
title: PUT List/DocumentTemplate/Items/{id}/UserGroups
uid: v1DocumentTemplateList_PutDocumentTemplateEntityUserGroupsForListItem
generated: true
---

# PUT List/DocumentTemplate/Items/{id}/UserGroups

```http
PUT /api/v1/List/DocumentTemplate/Items/{itemId}/UserGroups
```

Saves user groups visible for the DocumentTemplateEntity list's item.


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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/DocumentTemplate/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 38,
    "Name": "Willms-Balistreri",
    "ToolTip": "Animi quam ullam at et labore qui architecto.",
    "Deleted": false,
    "Rank": 155,
    "Type": "reiciendis",
    "ColorBlock": 180,
    "IconHint": "maxime",
    "Selected": true,
    "LastChanged": "2020-10-22T14:13:49.9625606+02:00",
    "ChildItems": [
      {
        "Id": 667,
        "Name": "Graham Inc and Sons",
        "ToolTip": "Illo omnis dignissimos placeat dignissimos mollitia.",
        "Deleted": true,
        "Rank": 249,
        "Type": "maxime",
        "ColorBlock": 361,
        "IconHint": "minus",
        "Selected": false,
        "LastChanged": "2004-03-21T14:13:49.9625606+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rerum",
        "StyleHint": "nemo",
        "Hidden": false,
        "FullName": "Albina Lehner"
      }
    ],
    "ExtraInfo": "modi",
    "StyleHint": "laborum",
    "Hidden": false,
    "FullName": "Dr. Jayde Stanton Jr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 959,
    "Name": "Mayer, Breitenberg and Wuckert",
    "ToolTip": "Sit impedit.",
    "Deleted": true,
    "Rank": 252,
    "Type": "unde",
    "ColorBlock": 272,
    "IconHint": "dolorem",
    "Selected": true,
    "LastChanged": "2001-05-15T14:13:49.9781847+02:00",
    "ChildItems": [
      {
        "Id": 616,
        "Name": "Kerluke-West",
        "ToolTip": "Modi sapiente nobis sed voluptate veritatis qui.",
        "Deleted": false,
        "Rank": 290,
        "Type": "dignissimos",
        "ColorBlock": 262,
        "IconHint": "maxime",
        "Selected": false,
        "LastChanged": "2010-09-30T14:13:49.9781847+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "fugit",
        "StyleHint": "dolores",
        "Hidden": false,
        "FullName": "Jordyn Bauch",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 708
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "mollitia",
    "Hidden": false,
    "FullName": "Jan Heathcote",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 731
      }
    }
  }
]
```