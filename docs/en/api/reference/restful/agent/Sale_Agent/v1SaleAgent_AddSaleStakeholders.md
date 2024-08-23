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
  "SaleId": 931,
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Blick, Kuhlman and Lebsack",
      "Comment": "nihil",
      "StakeholderRoleId": 958,
      "CountryId": 335,
      "PersonId": 833,
      "EmailDescription": "curtis.johnston@hand.us",
      "EmailId": 779,
      "EmailAddress": "laurel@pacocha.ca",
      "PhoneId": 808,
      "ContactName": "Lind Inc and Sons",
      "ContactId": 984,
      "SaleId": 557,
      "Mrmrs": "sunt",
      "Firstname": "Raquel",
      "MiddleName": "Konopelski-Shields",
      "Lastname": "Erdman",
      "SaleStakeholderId": 513,
      "Rank": 747,
      "Phone": "(663)758-7935"
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