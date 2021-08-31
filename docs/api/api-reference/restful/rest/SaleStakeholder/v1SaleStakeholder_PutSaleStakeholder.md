---
title: PUT SaleStakeholder/{id}
id: v1SaleStakeholder_PutSaleStakeholder
---

# PUT SaleStakeholder/{id}

```http
PUT /api/v1/SaleStakeholder/{id}
```

Updates the existing SaleStakeholder






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleStakeholder id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/SaleStakeholder/{id}?$select=name,department,category/id
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

## Request Body: entity  

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
| 200 | SaleStakeholder updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/SaleStakeholder/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Mraz, Osinski and Connelly",
  "Comment": "quasi",
  "StakeholderRoleId": 450,
  "CountryId": 448,
  "PersonId": 879,
  "EmailDescription": "caden_bode@abernathy.biz",
  "EmailId": 188,
  "EmailAddress": "eryn.rosenbaum@hettingerwuckert.biz",
  "PhoneId": 50,
  "ContactName": "Greenfelder-Mertz",
  "ContactId": 99,
  "SaleId": 311,
  "Mrmrs": "vitae",
  "Firstname": "Jeramie",
  "MiddleName": "Streich, Gottlieb and Hilll",
  "Lastname": "Haley",
  "SaleStakeholderId": 480,
  "Rank": 99,
  "Phone": "304.085.1676"
}
```

```http_
HTTP/1.1 200 SaleStakeholder updated.
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Hoeger LLC",
  "Comment": "qui",
  "StakeholderRoleId": 903,
  "CountryId": 744,
  "PersonId": 311,
  "EmailDescription": "lisa_ritchie@hudson.ca",
  "EmailId": 806,
  "EmailAddress": "florine.satterfield@champlin.us",
  "PhoneId": 244,
  "ContactName": "Jacobson, Hilpert and Johns",
  "ContactId": 575,
  "SaleId": 550,
  "Mrmrs": "tempore",
  "Firstname": "Adell",
  "MiddleName": "Steuber LLC",
  "Lastname": "Pagac",
  "SaleStakeholderId": 329,
  "Rank": 885,
  "Phone": "(804)084-2627 x734",
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
      "FieldType": "System.String",
      "FieldLength": 7
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```