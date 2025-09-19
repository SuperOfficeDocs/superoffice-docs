---
title: POST Contact/Validate
uid: v1ContactEntity_ValidateContactEntity
generated: true
content_type: reference
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 871,
  "Name": "Rowe, Bartell and Mante",
  "Department": "",
  "OrgNr": "1059872",
  "Number1": "642307",
  "Number2": "1449081",
  "UpdatedDate": "2007-09-01T03:41:58.6211452+02:00",
  "CreatedDate": "2024-02-08T03:41:58.6211452+01:00",
  "Emails": [
    {
      "Value": "dicta",
      "StrippedValue": "quis",
      "Description": "Profound content-based productivity"
    },
    {
      "Value": "dicta",
      "StrippedValue": "quis",
      "Description": "Profound content-based productivity"
    }
  ],
  "Interests": [
    {
      "Id": 960,
      "Name": "Weber, Torphy and Abernathy",
      "ToolTip": "Ea mollitia eos fuga consequuntur veritatis corporis.",
      "Deleted": true,
      "Rank": 486,
      "Type": "possimus",
      "ColorBlock": 734,
      "IconHint": "assumenda",
      "Selected": true,
      "LastChanged": "1999-04-06T03:41:58.6211452+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "aliquam",
      "Hidden": true,
      "FullName": "Matilde Torp DDS"
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Monitored secondary complexity"
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Monitored secondary complexity"
    }
  ],
  "Phones": [
    {
      "Value": "quas",
      "StrippedValue": "dicta",
      "Description": "Up-sized mission-critical alliance"
    },
    {
      "Value": "quas",
      "StrippedValue": "dicta",
      "Description": "Up-sized mission-critical alliance"
    }
  ],
  "Faxes": [
    {
      "Value": "facere",
      "StrippedValue": "repellat",
      "Description": "Configurable neutral local area network"
    },
    {
      "Value": "facere",
      "StrippedValue": "repellat",
      "Description": "Configurable neutral local area network"
    }
  ],
  "Description": "Exclusive value-added pricing structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "accusantium",
      "PersonId": 943,
      "Mrmrs": "dignissimos",
      "Firstname": "Mitchel",
      "Lastname": "Hahn",
      "MiddleName": "Keebler-Ledner",
      "Title": "aut",
      "Description": "Networked grid-enabled info-mediaries",
      "Email": "lorena_roob@breitenberg.us",
      "FullName": "Marcel Ebert",
      "DirectPhone": "105-408-3726",
      "FormalName": "Will Inc and Sons",
      "CountryId": 444,
      "ContactId": 731,
      "ContactName": "Corkery LLC",
      "Retired": 340,
      "Rank": 516,
      "ActiveInterests": 944,
      "ContactDepartment": "",
      "ContactCountryId": 699,
      "ContactOrgNr": "301462",
      "FaxPhone": "619.728.0927",
      "MobilePhone": "1-658-651-9289",
      "ContactPhone": "(654)606-2378",
      "AssociateName": "Leffler Group",
      "AssociateId": 951,
      "UsePersonAddress": false,
      "ContactFax": "cumque",
      "Kanafname": "quibusdam",
      "Kanalname": "qui",
      "Post1": "eum",
      "Post2": "nihil",
      "Post3": "consequatur",
      "EmailName": "trent_jaskolski@grant.uk",
      "ContactFullName": "Mrs. Lloyd Wolff",
      "ActiveErpLinks": 158,
      "TicketPriorityId": 169,
      "SupportLanguageId": 590,
      "SupportAssociateId": 32,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1477801"
    }
  ],
  "NoMailing": false,
  "Kananame": "non",
  "Xstop": false,
  "ActiveInterests": 29,
  "GroupId": 159,
  "ActiveStatusMonitorId": 161,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 997,
  "DbiAgentId": 471,
  "DbiLastSyncronized": "2010-05-09T03:41:58.6211452+02:00",
  "DbiKey": "blanditiis",
  "DbiLastModified": "2016-11-01T03:41:58.6211452+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 311,
  "ActiveErpLinks": 720,
  "BounceEmails": [
    "nasir_schimmel@okonbalistreri.info",
    "gabe.lehner@bosco.us"
  ],
  "Domains": [
    "repellendus",
    "id"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Willis Gerhold V",
    "SuperOffice:2": "Prof. Raphaelle Orland Kohler DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "mollitia",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "sunt"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "quis",
  "2": "sed"
}
```