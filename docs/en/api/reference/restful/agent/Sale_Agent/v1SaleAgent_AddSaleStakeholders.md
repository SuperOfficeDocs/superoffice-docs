---
title: POST Agents/Sale/AddSaleStakeholders
uid: v1SaleAgent_AddSaleStakeholders
generated: true
---

# POST Agents/Sale/AddSaleStakeholders

```http
POST /api/v1/Agents/Sale/AddSaleStakeholders
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/AddSaleStakeholders?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

SaleId, SaleStakeholders 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleId | Integer |  |
| SaleStakeholders | Array |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Sale/AddSaleStakeholders
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SaleId": 125,
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Huel, Flatley and Bosco",
      "Comment": "similique",
      "StakeholderRoleId": 884,
      "CountryId": 699,
      "PersonId": 932,
      "EmailDescription": "burley.gorczany@hahn.com",
      "EmailId": 482,
      "EmailAddress": "oran_mante@simonisyost.com",
      "PhoneId": 536,
      "ContactName": "Rutherford, Hand and Johnson",
      "ContactId": 806,
      "SaleId": 169,
      "Mrmrs": "ut",
      "Firstname": "Gordon",
      "MiddleName": "Lindgren, Lebsack and Dietrich",
      "Lastname": "Dare",
      "SaleStakeholderId": 756,
      "Rank": 621,
      "Phone": "139.904.4188"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```