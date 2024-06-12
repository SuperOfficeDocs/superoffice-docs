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
  "ContactId": 212,
  "Name": "Stark-Abshire",
  "Department": "",
  "OrgNr": "561559",
  "Number1": "355748",
  "Number2": "693197",
  "UpdatedDate": "2002-02-25T04:22:34.8433753+01:00",
  "CreatedDate": "2011-12-10T04:22:34.8433753+01:00",
  "Emails": [
    {
      "Value": "tempore",
      "StrippedValue": "ipsum",
      "Description": "Cross-platform intangible concept"
    },
    {
      "Value": "tempore",
      "StrippedValue": "ipsum",
      "Description": "Cross-platform intangible concept"
    }
  ],
  "Interests": [
    {
      "Id": 566,
      "Name": "Hayes, Swaniawski and Padberg",
      "ToolTip": "Sit veniam suscipit.",
      "Deleted": true,
      "Rank": 410,
      "Type": "sint",
      "ColorBlock": 984,
      "IconHint": "adipisci",
      "Selected": false,
      "LastChanged": "2012-04-10T04:22:34.8433753+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consectetur",
      "StyleHint": "voluptate",
      "Hidden": false,
      "FullName": "Hans Littel"
    }
  ],
  "Urls": [
    {
      "Value": "ipsum",
      "StrippedValue": "ut",
      "Description": "Centralized 24 hour software"
    },
    {
      "Value": "ipsum",
      "StrippedValue": "ut",
      "Description": "Centralized 24 hour software"
    }
  ],
  "Phones": [
    {
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Monitored real-time structure"
    },
    {
      "Value": "rerum",
      "StrippedValue": "et",
      "Description": "Monitored real-time structure"
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "nobis",
      "Description": "Integrated intermediate infrastructure"
    },
    {
      "Value": "aut",
      "StrippedValue": "nobis",
      "Description": "Integrated intermediate infrastructure"
    }
  ],
  "Description": "Switchable static framework",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "omnis",
      "PersonId": 755,
      "Mrmrs": "animi",
      "Firstname": "Ella",
      "Lastname": "Wuckert",
      "MiddleName": "Ferry, Schoen and Renner",
      "Title": "enim",
      "Description": "Multi-layered cohesive architecture",
      "Email": "brando_mckenzie@mcclure.biz",
      "FullName": "Marina Schulist",
      "DirectPhone": "341-082-4928 x299",
      "FormalName": "Larkin, Hills and Reichert",
      "CountryId": 487,
      "ContactId": 603,
      "ContactName": "Russel, Doyle and Kautzer",
      "Retired": 47,
      "Rank": 663,
      "ActiveInterests": 989,
      "ContactDepartment": "harness web-enabled functionalities",
      "ContactCountryId": 595,
      "ContactOrgNr": "824181",
      "FaxPhone": "068.913.6055",
      "MobilePhone": "334.497.6972 x4191",
      "ContactPhone": "(008)487-3186 x000",
      "AssociateName": "Welch LLC",
      "AssociateId": 438,
      "UsePersonAddress": false,
      "ContactFax": "sunt",
      "Kanafname": "delectus",
      "Kanalname": "quo",
      "Post1": "ab",
      "Post2": "aut",
      "Post3": "maxime",
      "EmailName": "delilah@mcglynn.name",
      "ContactFullName": "Ashlee Marvin",
      "ActiveErpLinks": 759,
      "TicketPriorityId": 864,
      "SupportLanguageId": 240,
      "SupportAssociateId": 516,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "ducimus",
  "Xstop": true,
  "ActiveInterests": 174,
  "GroupId": 23,
  "ActiveStatusMonitorId": 493,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 863,
  "DbiAgentId": 230,
  "DbiLastSyncronized": "2020-06-22T04:22:34.8433753+02:00",
  "DbiKey": "reiciendis",
  "DbiLastModified": "2008-01-02T04:22:34.8433753+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 583,
  "ActiveErpLinks": 266,
  "BounceEmails": [
    "michaela@christiansendoyle.biz",
    "russel_braun@halvorson.name"
  ],
  "Domains": [
    "ut",
    "quod"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "723834667",
    "SuperOffice:2": "Aidan Fritsch"
  },
  "ExtraFields": {
    "ExtraFields1": "illo",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "id"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ut",
  "2": "aliquid"
}
```