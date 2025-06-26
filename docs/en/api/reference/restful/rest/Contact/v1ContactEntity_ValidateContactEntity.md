---
title: POST Contact/Validate
uid: v1ContactEntity_ValidateContactEntity
generated: true
---

# POST Contact/Validate

```http
POST /api/v1/Contact/Validate
```

Check that entity is ready for saving, return error messages by field.








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

## Request Body: contactEntity 

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Contact/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 855,
  "Name": "Langworth-Heathcote",
  "Department": "",
  "OrgNr": "578635",
  "Number1": "1637277",
  "Number2": "728067",
  "UpdatedDate": "2005-09-21T03:45:28.2171945+02:00",
  "CreatedDate": "2005-01-15T03:45:28.2171945+01:00",
  "Emails": [
    {
      "Value": "illo",
      "StrippedValue": "delectus",
      "Description": "Progressive solution-oriented secured line"
    },
    {
      "Value": "illo",
      "StrippedValue": "delectus",
      "Description": "Progressive solution-oriented secured line"
    }
  ],
  "Interests": [
    {
      "Id": 212,
      "Name": "Haag, Rosenbaum and Anderson",
      "ToolTip": "Et fuga voluptatibus magni.",
      "Deleted": true,
      "Rank": 733,
      "Type": "et",
      "ColorBlock": 247,
      "IconHint": "aut",
      "Selected": true,
      "LastChanged": "2011-10-25T03:45:28.2171945+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officiis",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Mrs. Baby Madisyn Beier"
    }
  ],
  "Urls": [
    {
      "Value": "labore",
      "StrippedValue": "et",
      "Description": "Customer-focused national benchmark"
    },
    {
      "Value": "labore",
      "StrippedValue": "et",
      "Description": "Customer-focused national benchmark"
    }
  ],
  "Phones": [
    {
      "Value": "magni",
      "StrippedValue": "enim",
      "Description": "Public-key 4th generation throughput"
    },
    {
      "Value": "magni",
      "StrippedValue": "enim",
      "Description": "Public-key 4th generation throughput"
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "quia",
      "Description": "User-friendly clear-thinking hierarchy"
    },
    {
      "Value": "quia",
      "StrippedValue": "quia",
      "Description": "User-friendly clear-thinking hierarchy"
    }
  ],
  "Description": "Sharable local archive",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "similique",
      "PersonId": 544,
      "Mrmrs": "aut",
      "Firstname": "Mateo",
      "Lastname": "Ernser",
      "MiddleName": "Kris Inc and Sons",
      "Title": "officiis",
      "Description": "User-centric transitional focus group",
      "Email": "dino.gerhold@davis.biz",
      "FullName": "Karina Beahan",
      "DirectPhone": "1-453-114-3004 x255",
      "FormalName": "Kris LLC",
      "CountryId": 729,
      "ContactId": 669,
      "ContactName": "Hane, Gibson and Wilkinson",
      "Retired": 142,
      "Rank": 272,
      "ActiveInterests": 981,
      "ContactDepartment": "",
      "ContactCountryId": 484,
      "ContactOrgNr": "281212",
      "FaxPhone": "1-782-103-1570",
      "MobilePhone": "004.834.3110",
      "ContactPhone": "(201)285-6499 x40631",
      "AssociateName": "Smith Inc and Sons",
      "AssociateId": 328,
      "UsePersonAddress": true,
      "ContactFax": "eos",
      "Kanafname": "sunt",
      "Kanalname": "consectetur",
      "Post1": "dolores",
      "Post2": "repellat",
      "Post3": "est",
      "EmailName": "dena.kunde@casper.com",
      "ContactFullName": "Dr. Quinton Golden Armstrong IV",
      "ActiveErpLinks": 223,
      "TicketPriorityId": 542,
      "SupportLanguageId": 115,
      "SupportAssociateId": 197,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1431122"
    }
  ],
  "NoMailing": false,
  "Kananame": "optio",
  "Xstop": false,
  "ActiveInterests": 664,
  "GroupId": 565,
  "ActiveStatusMonitorId": 747,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 757,
  "DbiAgentId": 384,
  "DbiLastSyncronized": "2017-06-13T03:45:28.2171945+02:00",
  "DbiKey": "qui",
  "DbiLastModified": "1999-09-24T03:45:28.2171945+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 530,
  "ActiveErpLinks": 782,
  "BounceEmails": [
    "scot@mcglynn.us",
    "jammie_tillman@faycormier.co.uk"
  ],
  "Domains": [
    "perspiciatis",
    "rem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dayna Macejkovic"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "accusamus",
    "CustomFields2": "esse"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "rerum",
  "2": "eum"
}
```