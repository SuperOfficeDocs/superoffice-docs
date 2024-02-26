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
  "ContactId": 17,
  "Name": "Hegmann, Prosacco and Ryan",
  "Department": "",
  "OrgNr": "1332277",
  "Number1": "1188984",
  "Number2": "1481103",
  "UpdatedDate": "2014-08-05T10:30:31.9324368+02:00",
  "CreatedDate": "2006-01-18T10:30:31.9324368+01:00",
  "Emails": [
    {
      "Value": "inventore",
      "StrippedValue": "molestiae",
      "Description": "Expanded 4th generation service-desk"
    },
    {
      "Value": "inventore",
      "StrippedValue": "molestiae",
      "Description": "Expanded 4th generation service-desk"
    }
  ],
  "Interests": [
    {
      "Id": 103,
      "Name": "Crona, Leannon and Toy",
      "ToolTip": "Aperiam quas ipsam repellendus ex.",
      "Deleted": true,
      "Rank": 683,
      "Type": "illum",
      "ColorBlock": 296,
      "IconHint": "voluptates",
      "Selected": false,
      "LastChanged": "2003-09-19T10:30:31.9324368+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veniam",
      "StyleHint": "esse",
      "Hidden": false,
      "FullName": "Hermann Schuppe"
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "ad",
      "Description": "Cross-group 4th generation internet solution"
    },
    {
      "Value": "aut",
      "StrippedValue": "ad",
      "Description": "Cross-group 4th generation internet solution"
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "ut",
      "Description": "Enterprise-wide discrete knowledge user"
    },
    {
      "Value": "qui",
      "StrippedValue": "ut",
      "Description": "Enterprise-wide discrete knowledge user"
    }
  ],
  "Faxes": [
    {
      "Value": "sapiente",
      "StrippedValue": "et",
      "Description": "Universal executive contingency"
    },
    {
      "Value": "sapiente",
      "StrippedValue": "et",
      "Description": "Universal executive contingency"
    }
  ],
  "Description": "Fully-configurable full-range pricing structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorem",
      "PersonId": 843,
      "Mrmrs": "vel",
      "Firstname": "Devon",
      "Lastname": "Weimann",
      "MiddleName": "Steuber, Cruickshank and Kris",
      "Title": "est",
      "Description": "Down-sized mission-critical flexibility",
      "Email": "helen_lindgren@wisoky.com",
      "FullName": "Ms. Leonard Johns V",
      "DirectPhone": "697-075-5257 x22011",
      "FormalName": "Hodkiewicz, Schuppe and Fahey",
      "CountryId": 30,
      "ContactId": 493,
      "ContactName": "Senger Inc and Sons",
      "Retired": 80,
      "Rank": 361,
      "ActiveInterests": 182,
      "ContactDepartment": "",
      "ContactCountryId": 655,
      "ContactOrgNr": "989602",
      "FaxPhone": "461-551-0355",
      "MobilePhone": "(070)636-7802 x4157",
      "ContactPhone": "742-886-0518 x73480",
      "AssociateName": "Haag-Gislason",
      "AssociateId": 957,
      "UsePersonAddress": false,
      "ContactFax": "corrupti",
      "Kanafname": "ratione",
      "Kanalname": "voluptatum",
      "Post1": "id",
      "Post2": "omnis",
      "Post3": "incidunt",
      "EmailName": "kale@ritchieheller.co.uk",
      "ContactFullName": "Margret Jensen Cremin DDS",
      "ActiveErpLinks": 734,
      "TicketPriorityId": 953,
      "SupportLanguageId": 504,
      "SupportAssociateId": 28,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "aut",
  "Xstop": true,
  "ActiveInterests": 885,
  "GroupId": 978,
  "ActiveStatusMonitorId": 307,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 828,
  "DbiAgentId": 39,
  "DbiLastSyncronized": "2014-12-02T10:30:31.9324368+01:00",
  "DbiKey": "fugiat",
  "DbiLastModified": "2020-01-06T10:30:31.9324368+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 329,
  "ActiveErpLinks": 299,
  "BounceEmails": [
    "faustino@hettinger.com",
    "malcolm.hyatt@gutkowski.co.uk"
  ],
  "Domains": [
    "vel",
    "deleniti"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1409109202",
    "SuperOffice:2": "Madaline Ledner"
  },
  "ExtraFields": {
    "ExtraFields1": "alias",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "deserunt"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "magnam",
  "2": "mollitia"
}
```