---
title: POST Contact/Validate
uid: v1ContactEntity_ValidateContactEntity
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 551,
  "Name": "Gleichner, Marquardt and Mraz",
  "Department": "",
  "OrgNr": "1079756",
  "Number1": "1234100",
  "Number2": "685169",
  "UpdatedDate": "2015-12-17T03:51:33.5366222+01:00",
  "CreatedDate": "1998-05-21T03:51:33.5366222+02:00",
  "Emails": [
    {
      "Value": "temporibus",
      "StrippedValue": "quia",
      "Description": "Multi-layered neutral application"
    },
    {
      "Value": "temporibus",
      "StrippedValue": "quia",
      "Description": "Multi-layered neutral application"
    }
  ],
  "Interests": [
    {
      "Id": 879,
      "Name": "Moore, Feest and Mohr",
      "ToolTip": "Quibusdam ut.",
      "Deleted": false,
      "Rank": 216,
      "Type": "in",
      "ColorBlock": 808,
      "IconHint": "necessitatibus",
      "Selected": true,
      "LastChanged": "2017-04-23T03:51:33.5366222+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laborum",
      "StyleHint": "reprehenderit",
      "Hidden": true,
      "FullName": "Dr. Lindsey Tara Zboncak"
    }
  ],
  "Urls": [
    {
      "Value": "laboriosam",
      "StrippedValue": "cupiditate",
      "Description": "Progressive fault-tolerant encoding"
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "cupiditate",
      "Description": "Progressive fault-tolerant encoding"
    }
  ],
  "Phones": [
    {
      "Value": "deserunt",
      "StrippedValue": "corrupti",
      "Description": "Upgradable contextually-based function"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "corrupti",
      "Description": "Upgradable contextually-based function"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "consequatur",
      "Description": "Diverse bandwidth-monitored instruction set"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "consequatur",
      "Description": "Diverse bandwidth-monitored instruction set"
    }
  ],
  "Description": "Assimilated optimal solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ad",
      "PersonId": 101,
      "Mrmrs": "rerum",
      "Firstname": "Darien",
      "Lastname": "Gorczany",
      "MiddleName": "Cassin Group",
      "Title": "est",
      "Description": "Realigned secondary matrix",
      "Email": "kattie.kirlin@huelsstamm.info",
      "FullName": "Prof. Alexane Parisian",
      "DirectPhone": "1-062-894-7342 x4977",
      "FormalName": "Jacobs Group",
      "CountryId": 578,
      "ContactId": 836,
      "ContactName": "Toy, Ziemann and Quigley",
      "Retired": 6,
      "Rank": 19,
      "ActiveInterests": 267,
      "ContactDepartment": "seize world-class content",
      "ContactCountryId": 417,
      "ContactOrgNr": "730090",
      "FaxPhone": "039-611-4712 x5105",
      "MobilePhone": "1-176-342-1886",
      "ContactPhone": "(905)712-6568 x783",
      "AssociateName": "Zboncak-O'Connell",
      "AssociateId": 992,
      "UsePersonAddress": false,
      "ContactFax": "dolores",
      "Kanafname": "debitis",
      "Kanalname": "aut",
      "Post1": "fugit",
      "Post2": "repellendus",
      "Post3": "autem",
      "EmailName": "malcolm.hirthe@stehr.co.uk",
      "ContactFullName": "Mrs. Francesca Vito Streich",
      "ActiveErpLinks": 918,
      "TicketPriorityId": 722,
      "SupportLanguageId": 200,
      "SupportAssociateId": 902,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "asperiores",
  "Xstop": false,
  "ActiveInterests": 250,
  "GroupId": 829,
  "ActiveStatusMonitorId": 979,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 427,
  "DbiAgentId": 506,
  "DbiLastSyncronized": "2019-04-13T03:51:33.5366222+02:00",
  "DbiKey": "enim",
  "DbiLastModified": "2017-09-14T03:51:33.5366222+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 790,
  "ActiveErpLinks": 466,
  "BounceEmails": [
    "melyssa@schneider.uk",
    "kari_kshlerin@denesik.info"
  ],
  "Domains": [
    "dolorum",
    "temporibus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Caitlyn Erdman",
    "SuperOffice:2": "Mrs. Creola Hudson"
  },
  "ExtraFields": {
    "ExtraFields1": "error",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "voluptatibus",
    "CustomFields2": "ipsa"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "quas",
  "2": "et"
}
```