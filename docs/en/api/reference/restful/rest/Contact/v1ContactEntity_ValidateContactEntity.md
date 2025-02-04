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
  "ContactId": 417,
  "Name": "Ritchie-Zboncak",
  "Department": "",
  "OrgNr": "964396",
  "Number1": "1653770",
  "Number2": "897956",
  "UpdatedDate": "2000-06-02T13:13:31.5738909+02:00",
  "CreatedDate": "2001-05-31T13:13:31.5738909+02:00",
  "Emails": [
    {
      "Value": "officia",
      "StrippedValue": "non",
      "Description": "Cross-group background data-warehouse"
    },
    {
      "Value": "officia",
      "StrippedValue": "non",
      "Description": "Cross-group background data-warehouse"
    }
  ],
  "Interests": [
    {
      "Id": 584,
      "Name": "Steuber Group",
      "ToolTip": "Consequatur rerum culpa nihil ducimus velit.",
      "Deleted": false,
      "Rank": 201,
      "Type": "nobis",
      "ColorBlock": 114,
      "IconHint": "animi",
      "Selected": false,
      "LastChanged": "2007-05-15T13:13:31.5738909+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Ms. Kolby Theo Rutherford PhD"
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "expedita",
      "Description": "Programmable client-driven access"
    },
    {
      "Value": "est",
      "StrippedValue": "expedita",
      "Description": "Programmable client-driven access"
    }
  ],
  "Phones": [
    {
      "Value": "sit",
      "StrippedValue": "quis",
      "Description": "Intuitive coherent product"
    },
    {
      "Value": "sit",
      "StrippedValue": "quis",
      "Description": "Intuitive coherent product"
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "aut",
      "Description": "Horizontal executive policy"
    },
    {
      "Value": "sed",
      "StrippedValue": "aut",
      "Description": "Horizontal executive policy"
    }
  ],
  "Description": "Self-enabling directional conglomeration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quas",
      "PersonId": 209,
      "Mrmrs": "et",
      "Firstname": "Mortimer",
      "Lastname": "Langworth",
      "MiddleName": "Lowe, Hoppe and Rogahn",
      "Title": "est",
      "Description": "Optional 24/7 local area network",
      "Email": "adah_will@jerde.co.uk",
      "FullName": "Dr. Milton Sofia Kozey II",
      "DirectPhone": "1-837-668-4848 x598",
      "FormalName": "Blanda-Feest",
      "CountryId": 269,
      "ContactId": 371,
      "ContactName": "White, Welch and Wilderman",
      "Retired": 170,
      "Rank": 400,
      "ActiveInterests": 302,
      "ContactDepartment": "aggregate collaborative models",
      "ContactCountryId": 239,
      "ContactOrgNr": "359112",
      "FaxPhone": "1-156-389-4114 x17233",
      "MobilePhone": "786-508-7055 x65255",
      "ContactPhone": "010.935.4819",
      "AssociateName": "Fisher, Pacocha and Conroy",
      "AssociateId": 780,
      "UsePersonAddress": false,
      "ContactFax": "culpa",
      "Kanafname": "nihil",
      "Kanalname": "quae",
      "Post1": "consequatur",
      "Post2": "voluptatem",
      "Post3": "quae",
      "EmailName": "dagmar_heller@cartwrightjacobson.name",
      "ContactFullName": "Frieda Mills",
      "ActiveErpLinks": 385,
      "TicketPriorityId": 916,
      "SupportLanguageId": 652,
      "SupportAssociateId": 467,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "laborum",
  "Xstop": false,
  "ActiveInterests": 284,
  "GroupId": 672,
  "ActiveStatusMonitorId": 836,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 990,
  "DbiAgentId": 652,
  "DbiLastSyncronized": "2007-05-14T13:13:31.5895173+02:00",
  "DbiKey": "repellendus",
  "DbiLastModified": "2013-12-17T13:13:31.5895173+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 278,
  "ActiveErpLinks": 708,
  "BounceEmails": [
    "maxie.hodkiewicz@rodriguez.com",
    "sandra.boehm@considinepouros.info"
  ],
  "Domains": [
    "consequatur",
    "sed"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Katarina Shyanne Aufderhar Jr.",
    "SuperOffice:2": "Vincenza Gutkowski"
  },
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "doloribus",
  "2": "nobis"
}
```