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
  "ContactId": 832,
  "Name": "Kertzmann-Dickinson",
  "Department": "",
  "OrgNr": "725283",
  "Number1": "1455031",
  "Number2": "582918",
  "UpdatedDate": "2019-07-07T13:28:31.5074055+02:00",
  "CreatedDate": "2022-07-10T13:28:31.5074055+02:00",
  "Emails": [
    {
      "Value": "consequatur",
      "StrippedValue": "voluptas",
      "Description": "Universal web-enabled system engine"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "voluptas",
      "Description": "Universal web-enabled system engine"
    }
  ],
  "Interests": [
    {
      "Id": 350,
      "Name": "Quigley-Daugherty",
      "ToolTip": "Labore voluptatibus exercitationem.",
      "Deleted": true,
      "Rank": 620,
      "Type": "ea",
      "ColorBlock": 895,
      "IconHint": "rerum",
      "Selected": false,
      "LastChanged": "2014-06-04T13:28:31.5074055+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eveniet",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Miss Heber Aliza Mayert"
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "id",
      "Description": "Virtual multi-tasking archive"
    },
    {
      "Value": "quo",
      "StrippedValue": "id",
      "Description": "Virtual multi-tasking archive"
    }
  ],
  "Phones": [
    {
      "Value": "natus",
      "StrippedValue": "dolore",
      "Description": "Pre-emptive intermediate customer loyalty"
    },
    {
      "Value": "natus",
      "StrippedValue": "dolore",
      "Description": "Pre-emptive intermediate customer loyalty"
    }
  ],
  "Faxes": [
    {
      "Value": "enim",
      "StrippedValue": "saepe",
      "Description": "Virtual didactic system engine"
    },
    {
      "Value": "enim",
      "StrippedValue": "saepe",
      "Description": "Virtual didactic system engine"
    }
  ],
  "Description": "Team-oriented homogeneous infrastructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "excepturi",
      "PersonId": 182,
      "Mrmrs": "laborum",
      "Firstname": "Margarette",
      "Lastname": "Hand",
      "MiddleName": "Ankunding Group",
      "Title": "vitae",
      "Description": "Sharable secondary info-mediaries",
      "Email": "irma@schowalter.co.uk",
      "FullName": "Solon Buckridge",
      "DirectPhone": "942.136.2693 x107",
      "FormalName": "Cummerata Inc and Sons",
      "CountryId": 335,
      "ContactId": 851,
      "ContactName": "Bins, Block and Reinger",
      "Retired": 581,
      "Rank": 455,
      "ActiveInterests": 787,
      "ContactDepartment": "",
      "ContactCountryId": 163,
      "ContactOrgNr": "961792",
      "FaxPhone": "151.742.9265 x444",
      "MobilePhone": "1-970-132-5126",
      "ContactPhone": "510.606.3078 x830",
      "AssociateName": "Goodwin, Veum and McCullough",
      "AssociateId": 43,
      "UsePersonAddress": true,
      "ContactFax": "nulla",
      "Kanafname": "non",
      "Kanalname": "ipsa",
      "Post1": "facere",
      "Post2": "harum",
      "Post3": "quidem",
      "EmailName": "ezequiel_stokes@fahey.info",
      "ContactFullName": "Jannie Bartell",
      "ActiveErpLinks": 737,
      "TicketPriorityId": 75,
      "SupportLanguageId": 262,
      "SupportAssociateId": 638,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "deserunt",
  "Xstop": true,
  "ActiveInterests": 922,
  "GroupId": 448,
  "ActiveStatusMonitorId": 909,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 149,
  "DbiAgentId": 388,
  "DbiLastSyncronized": "2021-07-04T13:28:31.5074055+02:00",
  "DbiKey": "quibusdam",
  "DbiLastModified": "2002-11-25T13:28:31.5074055+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 70,
  "ActiveErpLinks": 12,
  "BounceEmails": [
    "roel.kihn@nader.biz",
    "marisa@stromanconnelly.us"
  ],
  "Domains": [
    "animi",
    "dolorum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Romaine Jacobson DVM",
    "SuperOffice:2": "629590452"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "similique"
  },
  "CustomFields": {
    "CustomFields1": "quasi",
    "CustomFields2": "sint"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "cum",
  "2": "alias"
}
```