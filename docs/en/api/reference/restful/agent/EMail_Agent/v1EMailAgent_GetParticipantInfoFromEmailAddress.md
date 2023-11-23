---
title: POST Agents/EMail/GetParticipantInfoFromEmailAddress
uid: v1EMailAgent_GetParticipantInfoFromEmailAddress
generated: true
---

# POST Agents/EMail/GetParticipantInfoFromEmailAddress

```http
POST /api/v1/Agents/EMail/GetParticipantInfoFromEmailAddress
```

Get participant data associated with the participant in the emails iCal attachment


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetParticipantInfoFromEmailAddress?$select=name,department,category/id
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

EmailAddress, AppointmentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailAddress | String |  |
| AppointmentId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Person

| Property Name | Type |  Description |
|----------------|------|--------------|
| Position | string | The position. This is a predefined SuperOffice value, different from Title |
| PersonId | int32 | Primary key |
| Mrmrs | string | e.g. Mrs   sex_title |
| Firstname | string | First name |
| Lastname | string | Last name |
| MiddleName | string | Middle name or 'van' etc. |
| Title | string | Title |
| Description | string | Info text/description on person. |
| Email | string | First email on contact person. |
| FullName | string | Get the persons full name (internal name used in clients for employees). |
| DirectPhone | string | Returns the direct phone that belong to the contact person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| CountryId | int32 | Country |
| ContactId | int32 | Owning contact ID |
| ContactName | string | The persons company name |
| Retired | int32 | 1 = the user is retired and should have no rights, not appear in lists, etc. |
| Rank | int32 | Display sort sequence for default sort order |
| ActiveInterests | int32 | Number of records in pintr table; select count(*) from pintr pi where pi.person_id = this.person_id == activeInterests is always true |
| ContactDepartment | string | The persons contact department |
| ContactCountryId | int32 | The persons contact country id |
| ContactOrgNr | string | The persons contact organization number |
| FaxPhone | string | Returns the fax phone that belong to the contact person. |
| MobilePhone | string | Returns the mobile phone that belong to the contact person. |
| ContactPhone | string | Returns the direct phone that belong to the persons contact. |
| AssociateName | string | Name of the person's owner |
| AssociateId | int32 | Id of the item's owner (Associate id) |
| UsePersonAddress | bool | If 1, use person's address for mailing instead of company address |
| ContactFax | string | Actual phone number as eneterd by the user |
| Kanafname | string | Kana first name, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post3 | string | Postal address, used in Japanese versions only |
| EmailName | string | E-mail description |
| ContactFullName | string | Company full name + department |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| TicketPriorityId | int32 | Ticket priority ID |
| SupportLanguageId | int32 | Support priority ID |
| SupportAssociateId | int32 | Our support contact for this person |
| CategoryName | string | The category list item name |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetParticipantInfoFromEmailAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "wellington@willms.biz",
  "AppointmentId": 403
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Position": "quia",
  "PersonId": 750,
  "Mrmrs": "nesciunt",
  "Firstname": "Kavon",
  "Lastname": "Ledner",
  "MiddleName": "Herman-Morar",
  "Title": "perspiciatis",
  "Description": "Reactive national internet solution",
  "Email": "charlene@beerbergnaum.info",
  "FullName": "Gunner Ebert",
  "DirectPhone": "579-797-4988 x976",
  "FormalName": "Schuster Inc and Sons",
  "CountryId": 237,
  "ContactId": 333,
  "ContactName": "Hackett-Schaden",
  "Retired": 62,
  "Rank": 668,
  "ActiveInterests": 751,
  "ContactDepartment": "",
  "ContactCountryId": 898,
  "ContactOrgNr": "1310668",
  "FaxPhone": "910-220-7117 x966",
  "MobilePhone": "1-506-595-5022 x797",
  "ContactPhone": "980.146.8932",
  "AssociateName": "Kilback Group",
  "AssociateId": 211,
  "UsePersonAddress": false,
  "ContactFax": "iure",
  "Kanafname": "enim",
  "Kanalname": "distinctio",
  "Post1": "sed",
  "Post2": "aliquam",
  "Post3": "dolorem",
  "EmailName": "ahmad@lueilwitzlegros.info",
  "ContactFullName": "Ms. Kirstin Larson",
  "ActiveErpLinks": 478,
  "TicketPriorityId": 740,
  "SupportLanguageId": 154,
  "SupportAssociateId": 840,
  "CategoryName": "VIP Customer",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 51
    }
  }
}
```