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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 908,
  "Name": "Breitenberg Group",
  "Department": "",
  "OrgNr": "827297",
  "Number1": "1172442",
  "Number2": "814465",
  "UpdatedDate": "2008-02-02T02:38:26.011077+01:00",
  "CreatedDate": "2000-05-17T02:38:26.011077+02:00",
  "Emails": [
    {
      "Value": "natus",
      "StrippedValue": "asperiores",
      "Description": "Innovative discrete local area network"
    },
    {
      "Value": "natus",
      "StrippedValue": "asperiores",
      "Description": "Innovative discrete local area network"
    }
  ],
  "Interests": [
    {
      "Id": 65,
      "Name": "Steuber, Purdy and Hamill",
      "ToolTip": "Quo aut provident.",
      "Deleted": false,
      "Rank": 588,
      "Type": "assumenda",
      "ColorBlock": 864,
      "IconHint": "dolor",
      "Selected": false,
      "LastChanged": "2008-01-10T02:38:26.011077+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eligendi",
      "StyleHint": "vero",
      "Hidden": false,
      "FullName": "Dr. Jasmin Rogahn II"
    }
  ],
  "Urls": [
    {
      "Value": "recusandae",
      "StrippedValue": "velit",
      "Description": "Open-source assymetric pricing structure"
    },
    {
      "Value": "recusandae",
      "StrippedValue": "velit",
      "Description": "Open-source assymetric pricing structure"
    }
  ],
  "Phones": [
    {
      "Value": "nulla",
      "StrippedValue": "autem",
      "Description": "Quality-focused 24 hour internet solution"
    },
    {
      "Value": "nulla",
      "StrippedValue": "autem",
      "Description": "Quality-focused 24 hour internet solution"
    }
  ],
  "Faxes": [
    {
      "Value": "ipsa",
      "StrippedValue": "natus",
      "Description": "Operative explicit challenge"
    },
    {
      "Value": "ipsa",
      "StrippedValue": "natus",
      "Description": "Operative explicit challenge"
    }
  ],
  "Description": "Devolved multi-state concept",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ab",
      "PersonId": 310,
      "Mrmrs": "blanditiis",
      "Firstname": "Deshawn",
      "Lastname": "Heidenreich",
      "MiddleName": "Ward Inc and Sons",
      "Title": "a",
      "Description": "Pre-emptive tertiary neural-net",
      "Email": "lilyan@berge.com",
      "FullName": "Jed Schimmel II",
      "DirectPhone": "1-563-947-4779",
      "FormalName": "Hackett, Dare and Kub",
      "CountryId": 223,
      "ContactId": 21,
      "ContactName": "Kertzmann-Satterfield",
      "Retired": 115,
      "Rank": 170,
      "ActiveInterests": 740,
      "ContactDepartment": "",
      "ContactCountryId": 302,
      "ContactOrgNr": "1128472",
      "FaxPhone": "1-866-530-0992",
      "MobilePhone": "1-980-021-2397",
      "ContactPhone": "1-608-639-5669 x56844",
      "AssociateName": "Thiel, Luettgen and Padberg",
      "AssociateId": 737,
      "UsePersonAddress": false,
      "ContactFax": "animi",
      "Kanafname": "numquam",
      "Kanalname": "aliquid",
      "Post1": "quibusdam",
      "Post2": "est",
      "Post3": "accusamus",
      "EmailName": "sherwood@koelpin.ca",
      "ContactFullName": "Loy Marcella Schamberger II",
      "ActiveErpLinks": 328,
      "TicketPriorityId": 305,
      "SupportLanguageId": 966,
      "SupportAssociateId": 308,
      "CategoryName": "VIP Customer",
      "PersonNumber": "689867"
    }
  ],
  "NoMailing": true,
  "Kananame": "sed",
  "Xstop": true,
  "ActiveInterests": 952,
  "GroupId": 163,
  "ActiveStatusMonitorId": 922,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 47,
  "DbiAgentId": 331,
  "DbiLastSyncronized": "2011-04-01T02:38:26.0266945+02:00",
  "DbiKey": "itaque",
  "DbiLastModified": "1999-08-01T02:38:26.0266945+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 944,
  "ActiveErpLinks": 733,
  "BounceEmails": [
    "tressa@hahn.uk",
    "liana_runte@yost.co.uk"
  ],
  "Domains": [
    "autem",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Jessy Welch",
    "SuperOffice:2": "1933961826"
  },
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "libero"
  },
  "CustomFields": {
    "CustomFields1": "perspiciatis",
    "CustomFields2": "illo"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "suscipit",
  "2": "expedita"
}
```