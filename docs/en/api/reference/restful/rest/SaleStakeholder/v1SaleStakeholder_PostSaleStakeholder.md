---
title: POST SaleStakeholder
uid: v1SaleStakeholder_PostSaleStakeholder
generated: true
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
| StakeholderRoleName | String | Stakeholder role name |
| Comment | String | Optional comment text |
| StakeholderRoleId | Integer | Stakeholde role list id - Primary key |
| CountryId | Integer | Country id - primary key |
| PersonId | Integer | Person id - Primary key |
| EmailDescription | String | E-mail description |
| EmailId | Integer | E-mail address id - Primary key |
| EmailAddress | String | E-mail address |
| PhoneId | Integer | Primary key |
| ContactName | String | Contact name |
| ContactId | Integer | Contact ID of person or contact who is the sale stakeholder |
| SaleId | Integer | Parent sale |
| Mrmrs | String | e.g. Mrs, Mr, Ms, Dr. |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| SaleStakeholderId | Integer | Primary key |
| Rank | Integer | Rank in list of stakeholders |
| Phone | String | Phone number |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SaleStakeholderWithLinks

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/SaleStakeholder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Gerhold Group",
  "Comment": "voluptates",
  "StakeholderRoleId": 572,
  "CountryId": 967,
  "PersonId": 887,
  "EmailDescription": "aaliyah.beahan@bauchkshlerin.com",
  "EmailId": 764,
  "EmailAddress": "tyreek.greenholt@tremblaynitzsche.info",
  "PhoneId": 9,
  "ContactName": "Kuhlman, Aufderhar and Renner",
  "ContactId": 633,
  "SaleId": 31,
  "Mrmrs": "debitis",
  "Firstname": "Ocie",
  "MiddleName": "Schaefer Group",
  "Lastname": "Grimes",
  "SaleStakeholderId": 514,
  "Rank": 623,
  "Phone": "1-703-476-0085 x8948"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Lindgren-Christiansen",
  "Comment": "et",
  "StakeholderRoleId": 4,
  "CountryId": 362,
  "PersonId": 618,
  "EmailDescription": "heloise.harvey@johnstillman.ca",
  "EmailId": 745,
  "EmailAddress": "enos@streich.ca",
  "PhoneId": 746,
  "ContactName": "Feil, Cormier and Hahn",
  "ContactId": 718,
  "SaleId": 495,
  "Mrmrs": "nemo",
  "Firstname": "Golda",
  "MiddleName": "Rohan LLC",
  "Lastname": "Klein",
  "SaleStakeholderId": 925,
  "Rank": 958,
  "Phone": "085-265-9390",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 67
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```