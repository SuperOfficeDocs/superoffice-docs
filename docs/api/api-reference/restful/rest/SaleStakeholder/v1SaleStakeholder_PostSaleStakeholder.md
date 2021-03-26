---
title: POST SaleStakeholder
id: v1SaleStakeholder_PostSaleStakeholder
---

# POST SaleStakeholder

```http
POST /api/v1/SaleStakeholder
```

Creates a new SaleStakeholder

Calls the Sale agent service SaveSaleStakeholder.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/SaleStakeholder?$select=name,department,category/id
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

## Request Body: newEntity  

The SaleStakeholder to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StakeholderRoleName | string | Stakeholder role name |
| Comment | string | Optional comment text |
| StakeholderRoleId | int32 | Stakeholde role list id - Primary key |
| CountryId | int32 | Country id - primary key |
| PersonId | int32 | Person id - Primary key |
| EmailDescription | string | E-mail description |
| EmailId | int32 | E-mail address id - Primary key |
| EmailAddress | string | E-mail address |
| PhoneId | int32 | Primary key |
| ContactName | string | Contact name |
| ContactId | int32 | Contact ID of person or contact who is the sale stakeholder |
| SaleId | int32 | Parent sale |
| Mrmrs | string | e.g. Mrs, Mr, Ms, Dr. |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| SaleStakeholderId | int32 | Primary key |
| Rank | int32 | Rank in list of stakeholders |
| Phone | string | Phone number |


## Response: object




SaleStakeholder entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| StakeholderRoleName | string | Stakeholder role name |
| Comment | string | Optional comment text |
| StakeholderRoleId | int32 | Stakeholde role list id - Primary key |
| CountryId | int32 | Country id - primary key |
| PersonId | int32 | Person id - Primary key |
| EmailDescription | string | E-mail description |
| EmailId | int32 | E-mail address id - Primary key |
| EmailAddress | string | E-mail address |
| PhoneId | int32 | Primary key |
| ContactName | string | Contact name |
| ContactId | int32 | Contact ID of person or contact who is the sale stakeholder |
| SaleId | int32 | Parent sale |
| Mrmrs | string | e.g. Mrs, Mr, Ms, Dr. |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| SaleStakeholderId | int32 | Primary key |
| Rank | int32 | Rank in list of stakeholders |
| Phone | string | Phone number |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/SaleStakeholder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Littel, Huels and Wuckert",
  "Comment": "eos",
  "StakeholderRoleId": 198,
  "CountryId": 78,
  "PersonId": 1000,
  "EmailDescription": "juana@lowecorkery.ca",
  "EmailId": 826,
  "EmailAddress": "juvenal.kub@hilll.name",
  "PhoneId": 432,
  "ContactName": "Feest-Toy",
  "ContactId": 288,
  "SaleId": 859,
  "Mrmrs": "sapiente",
  "Firstname": "Christian",
  "MiddleName": "Veum Group",
  "Lastname": "Nader",
  "SaleStakeholderId": 300,
  "Rank": 596,
  "Phone": "1-370-877-1820 x38322"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Yost LLC",
  "Comment": "dolorem",
  "StakeholderRoleId": 148,
  "CountryId": 429,
  "PersonId": 148,
  "EmailDescription": "leilani.hirthe@breitenberg.co.uk",
  "EmailId": 180,
  "EmailAddress": "kayley.heller@pfannerstill.co.uk",
  "PhoneId": 253,
  "ContactName": "Mohr, Klocko and Prosacco",
  "ContactId": 242,
  "SaleId": 688,
  "Mrmrs": "quia",
  "Firstname": "Kirstin",
  "MiddleName": "Zieme Inc and Sons",
  "Lastname": "Kub",
  "SaleStakeholderId": 961,
  "Rank": 587,
  "Phone": "425.358.1407 x81682",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "incubate strategic schemas"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 547
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```