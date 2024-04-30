---
title: POST Person/Validate
uid: v1PersonEntity_ValidatePersonEntity
generated: true
---

# POST Person/Validate

```http
POST /api/v1/Person/Validate
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

## Request Body: personEntity 

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer | Primary key |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| Mrmrs | String | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | String | Title |
| UpdatedDate | String | Last updated date  in UTC. |
| CreatedDate | String | Registered date  in UTC. |
| BirthDate | String | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | Array | A collection of the person's emails |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | Boolean | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | Array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | Array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | Array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | Array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | Array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | Array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | String | Alphanumeric user field |
| FullName | String | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | Boolean | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | Boolean | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | Array | The urls related to this person. |
| FormalName | String | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | String | Postal address, used in Japanese versions only |
| Post2 | String | Postal address, used in Japanese versions only |
| Post1 | String | Postal address, used in Japanese versions only |
| Kanalname | String | Kana last name, used in Japanese versions only |
| Kanafname | String | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | String | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | Integer | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| DbiLastSyncronized | String | Last external syncronization. |
| SentInfo | Integer | Has information on username/password been sent (ejournal) |
| ShowContactTickets | Integer | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | Array |  |
| InternetPhones | Array |  |
| Source | Integer | How did we get this person? For future integration needs |
| ActiveErpLinks | Integer | How many active ERP links are there for this person? |
| ShipmentTypes | Array | The person's available and selected shipment types. |
| Consents | Array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Person/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 986,
  "Firstname": "Mervin",
  "MiddleName": "Tremblay Group",
  "Lastname": "Feeney",
  "Mrmrs": "iste",
  "Title": "in",
  "UpdatedDate": "2006-09-20T11:44:42.1171231+02:00",
  "CreatedDate": "2003-08-31T11:44:42.1171231+02:00",
  "BirthDate": "2014-01-07T11:44:42.1171231+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "deserunt",
      "StrippedValue": "esse",
      "Description": "Reduced actuating projection"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "esse",
      "Description": "Reduced actuating projection"
    }
  ],
  "Description": "Diverse zero administration contingency",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "delectus",
      "StrippedValue": "vel",
      "Description": "Switchable bottom-line Graphic Interface"
    },
    {
      "Value": "delectus",
      "StrippedValue": "vel",
      "Description": "Switchable bottom-line Graphic Interface"
    }
  ],
  "Faxes": [
    {
      "Value": "tenetur",
      "StrippedValue": "et",
      "Description": "Fundamental demand-driven extranet"
    },
    {
      "Value": "tenetur",
      "StrippedValue": "et",
      "Description": "Fundamental demand-driven extranet"
    }
  ],
  "MobilePhones": [
    {
      "Value": "illo",
      "StrippedValue": "sint",
      "Description": "Right-sized directional access"
    },
    {
      "Value": "illo",
      "StrippedValue": "sint",
      "Description": "Right-sized directional access"
    }
  ],
  "OfficePhones": [
    {
      "Value": "natus",
      "StrippedValue": "voluptatibus",
      "Description": "Balanced composite open architecture"
    },
    {
      "Value": "natus",
      "StrippedValue": "voluptatibus",
      "Description": "Balanced composite open architecture"
    }
  ],
  "OtherPhones": [
    {
      "Value": "dolor",
      "StrippedValue": "voluptas",
      "Description": "Networked next generation secured line"
    },
    {
      "Value": "dolor",
      "StrippedValue": "voluptas",
      "Description": "Networked next generation secured line"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 549,
      "Name": "O'Conner-Konopelski",
      "ToolTip": "Illum aliquid ut doloribus omnis consequatur.",
      "Deleted": false,
      "Rank": 715,
      "Type": "reprehenderit",
      "ColorBlock": 280,
      "IconHint": "delectus",
      "Selected": true,
      "LastChanged": "2007-10-14T11:44:42.1171231+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "deserunt",
      "Hidden": true,
      "FullName": "Serena Lehner"
    }
  ],
  "PersonNumber": "937520",
  "FullName": "Collin Rogahn",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "excepturi",
      "StrippedValue": "ut",
      "Description": "Operative coherent emulation"
    },
    {
      "Value": "excepturi",
      "StrippedValue": "ut",
      "Description": "Operative coherent emulation"
    }
  ],
  "FormalName": "Robel, Bergnaum and Nicolas",
  "Address": null,
  "Post3": "eius",
  "Post2": "corporis",
  "Post1": "ut",
  "Kanalname": "veritatis",
  "Kanafname": "voluptas",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "autem",
  "ActiveInterests": 203,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 441,
  "DbiKey": "vero",
  "DbiLastModified": "2010-10-23T11:44:42.1171231+02:00",
  "DbiLastSyncronized": "2002-03-22T11:44:42.1171231+01:00",
  "SentInfo": 368,
  "ShowContactTickets": 335,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "est",
      "StrippedValue": "harum",
      "Description": "Function-based reciprocal flexibility"
    },
    {
      "Value": "est",
      "StrippedValue": "harum",
      "Description": "Function-based reciprocal flexibility"
    }
  ],
  "InternetPhones": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "quam",
      "Description": "Business-focused logistical alliance"
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "quam",
      "Description": "Business-focused logistical alliance"
    }
  ],
  "Source": 918,
  "ActiveErpLinks": 634,
  "ShipmentTypes": [
    {
      "Id": 621,
      "Name": "Cruickshank, Goodwin and Weimann",
      "ToolTip": "Omnis explicabo sunt nam qui qui.",
      "Deleted": false,
      "Rank": 467,
      "Type": "adipisci",
      "ColorBlock": 879,
      "IconHint": "nihil",
      "Selected": true,
      "LastChanged": "2010-03-08T11:44:42.1171231+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "temporibus",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Joyce Rodriguez"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 359,
      "Comment": "aut",
      "Registered": "2005-08-07T11:44:42.1171231+02:00",
      "RegisteredAssociateId": 622,
      "Updated": "2011-04-30T11:44:42.1171231+02:00",
      "UpdatedAssociateId": 213,
      "LegalBaseId": 938,
      "LegalBaseKey": "enim",
      "LegalBaseName": "Hayes-Bednar",
      "ConsentPurposeId": 492,
      "ConsentPurposeKey": "sed",
      "ConsentPurposeName": "Herman-Effertz",
      "ConsentSourceId": 879,
      "ConsentSourceKey": "sed",
      "ConsentSourceName": "Pfannerstill, Bosco and Nicolas"
    }
  ],
  "BounceEmails": [
    "mattie@russelarmstrong.name",
    "mackenzie_cronin@schroeder.info"
  ],
  "ActiveStatusMonitorId": 282,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Brisa Stamm",
    "SuperOffice:2": "Ms. Lesly Jacobs PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "nihil"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "dolorum",
  "2": "dolores"
}
```