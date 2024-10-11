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
  "ContactId": 675,
  "Name": "Kuvalis Group",
  "Department": "",
  "OrgNr": "760333",
  "Number1": "93990",
  "Number2": "721146",
  "UpdatedDate": "2013-10-23T03:44:57.1715229+02:00",
  "CreatedDate": "2013-05-19T03:44:57.1715229+02:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "reprehenderit",
      "Description": "Managed next generation secured line"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "reprehenderit",
      "Description": "Managed next generation secured line"
    }
  ],
  "Interests": [
    {
      "Id": 474,
      "Name": "Schneider, Upton and Schulist",
      "ToolTip": "In vitae rerum nihil.",
      "Deleted": true,
      "Rank": 468,
      "Type": "voluptatem",
      "ColorBlock": 842,
      "IconHint": "neque",
      "Selected": true,
      "LastChanged": "2023-06-01T03:44:57.1715229+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perferendis",
      "StyleHint": "mollitia",
      "Hidden": false,
      "FullName": "Deion Collier"
    }
  ],
  "Urls": [
    {
      "Value": "eveniet",
      "StrippedValue": "consectetur",
      "Description": "Inverse high-level ability"
    },
    {
      "Value": "eveniet",
      "StrippedValue": "consectetur",
      "Description": "Inverse high-level ability"
    }
  ],
  "Phones": [
    {
      "Value": "iste",
      "StrippedValue": "at",
      "Description": "Expanded global internet solution"
    },
    {
      "Value": "iste",
      "StrippedValue": "at",
      "Description": "Expanded global internet solution"
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "aut",
      "Description": "Realigned heuristic capability"
    },
    {
      "Value": "est",
      "StrippedValue": "aut",
      "Description": "Realigned heuristic capability"
    }
  ],
  "Description": "Sharable content-based process improvement",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "perferendis",
      "PersonId": 27,
      "Mrmrs": "quaerat",
      "Firstname": "Erica",
      "Lastname": "Macejkovic",
      "MiddleName": "O'Hara-Senger",
      "Title": "dolores",
      "Description": "Customizable bandwidth-monitored frame",
      "Email": "sonia@oconner.ca",
      "FullName": "Ava Sauer",
      "DirectPhone": "(268)849-3426 x48673",
      "FormalName": "Legros, Haag and Bahringer",
      "CountryId": 987,
      "ContactId": 601,
      "ContactName": "Smitham, Mills and Bernhard",
      "Retired": 26,
      "Rank": 971,
      "ActiveInterests": 891,
      "ContactDepartment": "",
      "ContactCountryId": 764,
      "ContactOrgNr": "1448905",
      "FaxPhone": "117-819-9780 x2515",
      "MobilePhone": "1-667-210-0780 x483",
      "ContactPhone": "(723)532-6948 x5756",
      "AssociateName": "Berge Group",
      "AssociateId": 718,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "a",
      "Kanalname": "et",
      "Post1": "soluta",
      "Post2": "odit",
      "Post3": "dolorem",
      "EmailName": "joseph@mayerbauch.biz",
      "ContactFullName": "Bridgette Christiansen",
      "ActiveErpLinks": 300,
      "TicketPriorityId": 621,
      "SupportLanguageId": 784,
      "SupportAssociateId": 8,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "quod",
  "Xstop": false,
  "ActiveInterests": 6,
  "GroupId": 319,
  "ActiveStatusMonitorId": 671,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 945,
  "DbiAgentId": 886,
  "DbiLastSyncronized": "2000-04-13T03:44:57.1871459+02:00",
  "DbiKey": "quis",
  "DbiLastModified": "2019-12-18T03:44:57.1871459+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 790,
  "ActiveErpLinks": 469,
  "BounceEmails": [
    "isaiah@hoppe.ca",
    "margarita@wilkinson.name"
  ],
  "Domains": [
    "qui",
    "ipsa"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Aimee Carroll",
    "SuperOffice:2": "543053814"
  },
  "ExtraFields": {
    "ExtraFields1": "quisquam",
    "ExtraFields2": "rem"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "harum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "qui",
  "2": "et"
}
```