---
title: POST Agents/User/GetAllFunctionalRights
id: v1UserAgent_GetAllFunctionalRights
---

# POST Agents/User/GetAllFunctionalRights

```http
POST /api/v1/Agents/User/GetAllFunctionalRights
```

Get a list of all functional rights for the given type of role.

MDO List name = 'FunctionRights', extra='roleType=0' 


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetAllFunctionalRights?$select=name,department,category/id
```


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

## Request Body: request  

RoleType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| RoleType | string |  |


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
POST /api/v1/Agents/User/GetAllFunctionalRights
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "RoleType": "Anonymous"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 793,
    "Name": "D'Amore-Jewess",
    "ToolTip": "Quod est earum quia voluptatem.",
    "Deleted": false,
    "Rank": 523,
    "Type": "temporibus",
    "ColorBlock": 721,
    "IconHint": "id",
    "Selected": true,
    "LastChanged": "1994-01-31T16:48:30.9139439+01:00",
    "ChildItems": [
      {
        "Id": 353,
        "Name": "Beahan LLC",
        "ToolTip": "Dicta sed voluptates fuga officia inventore.",
        "Deleted": false,
        "Rank": 486,
        "Type": "tempora",
        "ColorBlock": 188,
        "IconHint": "dolorem",
        "Selected": true,
        "LastChanged": "2005-12-07T16:48:30.9149449+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nesciunt",
        "StyleHint": "sapiente",
        "Hidden": false,
        "FullName": "Frederick Thiel II",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 257
          }
        }
      }
    ],
    "ExtraInfo": "vel",
    "StyleHint": "maxime",
    "Hidden": false,
    "FullName": "Erna Jewess",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "facilitate robust communities"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 604
      }
    }
  }
]
```