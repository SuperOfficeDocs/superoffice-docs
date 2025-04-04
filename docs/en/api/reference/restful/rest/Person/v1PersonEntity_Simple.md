---
title: GET Person/{id}/Simple
uid: v1PersonEntity_Simple
generated: true
---

# GET Person/{id}/Simple

```http
GET /api/v1/Person/{id}/Simple
```

A simple Person object.


This is a simpler, smaller variation of the full PersonEntity. Calls the Person agent service GetPerson.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the Person to return. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

PersonEntity found.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity found. |
| 404 | Not Found. |

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
| PersonNumber | string | Alphanumeric user field |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Person/{id}/Simple
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity found.
Content-Type: application/json; charset=utf-8

{
  "Position": "veritatis",
  "PersonId": 206,
  "Mrmrs": "et",
  "Firstname": "Efrain",
  "Lastname": "Pacocha",
  "MiddleName": "Heaney LLC",
  "Title": "quasi",
  "Description": "Automated client-driven application",
  "Email": "margarett.crist@larkindavis.info",
  "FullName": "Michelle Smith",
  "DirectPhone": "(768)330-8378 x36605",
  "FormalName": "Auer-Hills",
  "CountryId": 125,
  "ContactId": 619,
  "ContactName": "Wilderman, Hagenes and Kautzer",
  "Retired": 684,
  "Rank": 749,
  "ActiveInterests": 300,
  "ContactDepartment": "",
  "ContactCountryId": 982,
  "ContactOrgNr": "1011084",
  "FaxPhone": "705-047-8991 x476",
  "MobilePhone": "(308)397-4377 x49809",
  "ContactPhone": "461.535.3905",
  "AssociateName": "Dietrich, Leffler and Champlin",
  "AssociateId": 58,
  "UsePersonAddress": true,
  "ContactFax": "sed",
  "Kanafname": "assumenda",
  "Kanalname": "perspiciatis",
  "Post1": "numquam",
  "Post2": "dignissimos",
  "Post3": "voluptas",
  "EmailName": "donato.bosco@sporerjewess.info",
  "ContactFullName": "Dr. Alexie Bergstrom Sr.",
  "ActiveErpLinks": 541,
  "TicketPriorityId": 524,
  "SupportLanguageId": 428,
  "SupportAssociateId": 961,
  "CategoryName": "VIP Customer",
  "PersonNumber": "1230106",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 317
    }
  }
}
```