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
  "ContactId": 599,
  "Name": "Zemlak Inc and Sons",
  "Department": "",
  "OrgNr": "516521",
  "Number1": "456487",
  "Number2": "506861",
  "UpdatedDate": "2018-10-03T14:28:26.8520728+02:00",
  "CreatedDate": "2016-11-01T14:28:26.8520728+01:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "autem",
      "Description": "Phased motivating projection"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "autem",
      "Description": "Phased motivating projection"
    }
  ],
  "Interests": [
    {
      "Id": 91,
      "Name": "Ritchie LLC",
      "ToolTip": "Repudiandae praesentium corrupti sed consequuntur totam aperiam nemo.",
      "Deleted": false,
      "Rank": 15,
      "Type": "laborum",
      "ColorBlock": 343,
      "IconHint": "ullam",
      "Selected": false,
      "LastChanged": "2016-08-01T14:28:26.8520728+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Prof. Selmer Bode"
    }
  ],
  "Urls": [
    {
      "Value": "assumenda",
      "StrippedValue": "voluptates",
      "Description": "Open-source 24/7 open system"
    },
    {
      "Value": "assumenda",
      "StrippedValue": "voluptates",
      "Description": "Open-source 24/7 open system"
    }
  ],
  "Phones": [
    {
      "Value": "vero",
      "StrippedValue": "enim",
      "Description": "Profit-focused even-keeled capacity"
    },
    {
      "Value": "vero",
      "StrippedValue": "enim",
      "Description": "Profit-focused even-keeled capacity"
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "magni",
      "Description": "Decentralized intangible hub"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "magni",
      "Description": "Decentralized intangible hub"
    }
  ],
  "Description": "Vision-oriented mobile protocol",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "non",
      "PersonId": 488,
      "Mrmrs": "autem",
      "Firstname": "Darrin",
      "Lastname": "Kassulke",
      "MiddleName": "Mertz, Halvorson and Leuschke",
      "Title": "et",
      "Description": "Advanced attitude-oriented definition",
      "Email": "heath@sauerglover.name",
      "FullName": "Mrs. Esmeralda O'Kon IV",
      "DirectPhone": "829-851-7358 x854",
      "FormalName": "Bahringer LLC",
      "CountryId": 285,
      "ContactId": 439,
      "ContactName": "Kilback-Cummerata",
      "Retired": 283,
      "Rank": 4,
      "ActiveInterests": 652,
      "ContactDepartment": "",
      "ContactCountryId": 955,
      "ContactOrgNr": "1203368",
      "FaxPhone": "(224)129-4556 x4612",
      "MobilePhone": "891.867.2491 x4004",
      "ContactPhone": "1-126-622-7335",
      "AssociateName": "Carroll Group",
      "AssociateId": 848,
      "UsePersonAddress": false,
      "ContactFax": "provident",
      "Kanafname": "veniam",
      "Kanalname": "officia",
      "Post1": "placeat",
      "Post2": "ea",
      "Post3": "voluptas",
      "EmailName": "amely_kuphal@grady.uk",
      "ContactFullName": "Aryanna Barrows",
      "ActiveErpLinks": 211,
      "TicketPriorityId": 98,
      "SupportLanguageId": 24,
      "SupportAssociateId": 403,
      "CategoryName": "VIP Customer",
      "PersonNumber": "867437"
    }
  ],
  "NoMailing": false,
  "Kananame": "repellat",
  "Xstop": false,
  "ActiveInterests": 691,
  "GroupId": 1001,
  "ActiveStatusMonitorId": 596,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 671,
  "DbiAgentId": 98,
  "DbiLastSyncronized": "2001-12-26T14:28:26.8520728+01:00",
  "DbiKey": "rerum",
  "DbiLastModified": "2023-10-27T14:28:26.8520728+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 170,
  "ActiveErpLinks": 252,
  "BounceEmails": [
    "titus@wisozk.name",
    "dereck.cremin@stiedemann.us"
  ],
  "Domains": [
    "dolore",
    "id"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Hilton Graham",
    "SuperOffice:2": "Dr. Crystel Collins Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "ab",
    "ExtraFields2": "explicabo"
  },
  "CustomFields": {
    "CustomFields1": "sapiente",
    "CustomFields2": "delectus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "suscipit",
  "2": "ut"
}
```