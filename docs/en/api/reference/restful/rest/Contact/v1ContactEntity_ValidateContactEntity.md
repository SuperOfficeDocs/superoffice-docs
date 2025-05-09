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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 806,
  "Name": "Larkin Group",
  "Department": "",
  "OrgNr": "1460231",
  "Number1": "1137967",
  "Number2": "1010407",
  "UpdatedDate": "2020-03-06T16:32:47.3839895+01:00",
  "CreatedDate": "2020-07-08T16:32:47.3839895+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "culpa",
      "Description": "Cloned client-driven matrix"
    },
    {
      "Value": "et",
      "StrippedValue": "culpa",
      "Description": "Cloned client-driven matrix"
    }
  ],
  "Interests": [
    {
      "Id": 882,
      "Name": "Sawayn, Emard and Russel",
      "ToolTip": "Omnis voluptas ut eius dicta eius.",
      "Deleted": false,
      "Rank": 136,
      "Type": "enim",
      "ColorBlock": 346,
      "IconHint": "ab",
      "Selected": false,
      "LastChanged": "2005-12-07T16:32:47.3839895+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eius",
      "StyleHint": "consequatur",
      "Hidden": true,
      "FullName": "Ruby Ankunding"
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "pariatur",
      "Description": "Configurable high-level customer loyalty"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "pariatur",
      "Description": "Configurable high-level customer loyalty"
    }
  ],
  "Phones": [
    {
      "Value": "deserunt",
      "StrippedValue": "explicabo",
      "Description": "Diverse high-level array"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "explicabo",
      "Description": "Diverse high-level array"
    }
  ],
  "Faxes": [
    {
      "Value": "quibusdam",
      "StrippedValue": "earum",
      "Description": "Robust exuding emulation"
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "earum",
      "Description": "Robust exuding emulation"
    }
  ],
  "Description": "Cross-platform systemic internet solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 13,
      "Mrmrs": "omnis",
      "Firstname": "Hermina",
      "Lastname": "Rowe",
      "MiddleName": "Ryan LLC",
      "Title": "quia",
      "Description": "Exclusive analyzing parallelism",
      "Email": "brett.gleason@vandervort.com",
      "FullName": "Thora Bins",
      "DirectPhone": "312-498-0027 x3338",
      "FormalName": "Volkman-Heaney",
      "CountryId": 944,
      "ContactId": 359,
      "ContactName": "Will-Hudson",
      "Retired": 762,
      "Rank": 599,
      "ActiveInterests": 520,
      "ContactDepartment": "",
      "ContactCountryId": 473,
      "ContactOrgNr": "1099141",
      "FaxPhone": "444-984-8168 x52859",
      "MobilePhone": "996.103.6706 x1389",
      "ContactPhone": "118.588.8416 x3100",
      "AssociateName": "Denesik, Abbott and Sawayn",
      "AssociateId": 771,
      "UsePersonAddress": false,
      "ContactFax": "quia",
      "Kanafname": "facilis",
      "Kanalname": "neque",
      "Post1": "aut",
      "Post2": "maxime",
      "Post3": "rem",
      "EmailName": "darien.gibson@wisozk.info",
      "ContactFullName": "Miss Ezekiel Barton",
      "ActiveErpLinks": 169,
      "TicketPriorityId": 244,
      "SupportLanguageId": 228,
      "SupportAssociateId": 153,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1391141"
    }
  ],
  "NoMailing": false,
  "Kananame": "rerum",
  "Xstop": true,
  "ActiveInterests": 909,
  "GroupId": 429,
  "ActiveStatusMonitorId": 93,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 96,
  "DbiAgentId": 50,
  "DbiLastSyncronized": "2000-05-02T16:32:47.3839895+02:00",
  "DbiKey": "quo",
  "DbiLastModified": "2000-07-16T16:32:47.3839895+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 306,
  "ActiveErpLinks": 507,
  "BounceEmails": [
    "nash@mante.us",
    "beulah.nolan@keebler.biz"
  ],
  "Domains": [
    "nemo",
    "animi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "526326695",
    "SuperOffice:2": "Mr. Eve Collier"
  },
  "ExtraFields": {
    "ExtraFields1": "eius",
    "ExtraFields2": "ab"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "omnis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "unde",
  "2": "voluptate"
}
```