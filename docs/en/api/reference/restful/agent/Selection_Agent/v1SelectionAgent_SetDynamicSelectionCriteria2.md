---
title: POST Agents/Selection/SetDynamicSelectionCriteria2
uid: v1SelectionAgent_SetDynamicSelectionCriteria2
generated: true
---

# POST Agents/Selection/SetDynamicSelectionCriteria2

```http
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria2
```

Update the criteria for this dynamic selection using string.


Criteria are parsed from the OData filter form: ''name startswith 'foo' and category in (1,2,3)''






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria2?$select=name,department,category/id
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

SelectionId, Filter 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | Integer |  |
| Filter | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | The programmatic column name, including any required prefixes |
| Operator | string | The operator, such as =, etc |
| Values | array | Value(s) to test against |
| DisplayValues | array | Display representation of value(s) - list ID's are decoded to display texts, other values are represented in a format suitable for decoding and display through the {SuperOffice.CRM.Globalization.CultureDataFormatter}. |
| ColumnInfo | ArchiveColumnInfo | Optional complete ArchiveColumnInfo for this restriction; in that case, ColumnInfo.Name == this.Name will always be true |
| IsActive | bool | Is this restriction active?  Inactive restrictions will not influence the generated query |
| SubRestrictions | array | Optional collection of sub criteria, usually null but set for Saint counter fields |
| InterParenthesis | int32 | Get or set the parenthesis (if any) associated with this restriction. Positive values indicate a number of opening parentheses (deepening nesting level), while negative numbers indicate closing parentheses. Zero means no change in nesting level (no parentheses). |
| InterOperator | string | Get or set the inter-restriction operator that describes how this restriction is related to the next one in an array. Default for new ArchiveRestrictionInfo objects is And |
| UniqueHash | int32 |  |

## Sample request

```http!
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 113,
  "Filter": "consequatur"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Kihn-Smitham",
    "Operator": "blanditiis",
    "Values": [
      "tempore",
      "qui"
    ],
    "DisplayValues": [
      "explicabo",
      "est"
    ],
    "ColumnInfo": null,
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Koepp-Farrell",
        "Operator": "et",
        "Values": [
          "similique",
          "itaque"
        ],
        "DisplayValues": [
          "totam",
          "alias"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 566,
        "InterOperator": "And",
        "UniqueHash": 340
      }
    ],
    "InterParenthesis": 985,
    "InterOperator": "And",
    "UniqueHash": 508
  }
]
```