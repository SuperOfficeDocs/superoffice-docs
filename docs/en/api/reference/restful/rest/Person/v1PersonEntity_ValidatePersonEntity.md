---
title: POST Person/Validate
uid: v1PersonEntity_ValidatePersonEntity
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 824,
  "Firstname": "Noemy",
  "MiddleName": "Halvorson-Watsica",
  "Lastname": "Marquardt",
  "Mrmrs": "odit",
  "Title": "aut",
  "UpdatedDate": "2021-07-04T14:19:10.4592274+02:00",
  "CreatedDate": "2016-09-27T14:19:10.4592274+02:00",
  "BirthDate": "2017-03-11T14:19:10.4592274+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ducimus",
      "StrippedValue": "at",
      "Description": "Object-based exuding instruction set"
    },
    {
      "Value": "ducimus",
      "StrippedValue": "at",
      "Description": "Object-based exuding instruction set"
    }
  ],
  "Description": "Polarised user-facing support",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "rem",
      "Description": "Re-contextualized demand-driven help-desk"
    },
    {
      "Value": "et",
      "StrippedValue": "rem",
      "Description": "Re-contextualized demand-driven help-desk"
    }
  ],
  "Faxes": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "voluptatibus",
      "Description": "Down-sized global function"
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "voluptatibus",
      "Description": "Down-sized global function"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quis",
      "StrippedValue": "nisi",
      "Description": "Managed bi-directional process improvement"
    },
    {
      "Value": "quis",
      "StrippedValue": "nisi",
      "Description": "Managed bi-directional process improvement"
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolores",
      "StrippedValue": "doloribus",
      "Description": "Automated mobile pricing structure"
    },
    {
      "Value": "dolores",
      "StrippedValue": "doloribus",
      "Description": "Automated mobile pricing structure"
    }
  ],
  "OtherPhones": [
    {
      "Value": "labore",
      "StrippedValue": "veritatis",
      "Description": "Customer-focused tangible data-warehouse"
    },
    {
      "Value": "labore",
      "StrippedValue": "veritatis",
      "Description": "Customer-focused tangible data-warehouse"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 629,
      "Name": "O'Hara, Walsh and Corkery",
      "ToolTip": "Cupiditate magni esse similique et eligendi doloremque.",
      "Deleted": false,
      "Rank": 522,
      "Type": "eius",
      "ColorBlock": 959,
      "IconHint": "veritatis",
      "Selected": true,
      "LastChanged": "2010-04-16T14:19:10.4592274+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "similique",
      "StyleHint": "quae",
      "Hidden": false,
      "FullName": "Mrs. Janelle Ernesto Anderson"
    }
  ],
  "PersonNumber": "723170",
  "FullName": "Miss Elijah Anderson DVM",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "totam",
      "Description": "Mandatory dynamic strategy"
    },
    {
      "Value": "est",
      "StrippedValue": "totam",
      "Description": "Mandatory dynamic strategy"
    }
  ],
  "FormalName": "Wiegand, Prosacco and Okuneva",
  "Address": null,
  "Post3": "eius",
  "Post2": "est",
  "Post1": "sit",
  "Kanalname": "tenetur",
  "Kanafname": "veritatis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "adipisci",
  "ActiveInterests": 403,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 663,
  "DbiKey": "dolorem",
  "DbiLastModified": "2006-08-05T14:19:10.4592274+02:00",
  "DbiLastSyncronized": "2018-05-09T14:19:10.4592274+02:00",
  "SentInfo": 313,
  "ShowContactTickets": 111,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "dolor",
      "StrippedValue": "laudantium",
      "Description": "Persistent interactive solution"
    },
    {
      "Value": "dolor",
      "StrippedValue": "laudantium",
      "Description": "Persistent interactive solution"
    }
  ],
  "InternetPhones": [
    {
      "Value": "minima",
      "StrippedValue": "facilis",
      "Description": "De-engineered human-resource Graphic Interface"
    },
    {
      "Value": "minima",
      "StrippedValue": "facilis",
      "Description": "De-engineered human-resource Graphic Interface"
    }
  ],
  "Source": 504,
  "ActiveErpLinks": 640,
  "ShipmentTypes": [
    {
      "Id": 818,
      "Name": "Morar, Lubowitz and Greenfelder",
      "ToolTip": "Labore quia.",
      "Deleted": false,
      "Rank": 156,
      "Type": "libero",
      "ColorBlock": 362,
      "IconHint": "accusantium",
      "Selected": true,
      "LastChanged": "2008-03-21T14:19:10.4592274+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "earum",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Merle Walsh"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 233,
      "Comment": "ut",
      "Registered": "2011-01-11T14:19:10.4592274+01:00",
      "RegisteredAssociateId": 887,
      "Updated": "2022-04-27T14:19:10.4592274+02:00",
      "UpdatedAssociateId": 631,
      "LegalBaseId": 445,
      "LegalBaseKey": "illo",
      "LegalBaseName": "Grady LLC",
      "ConsentPurposeId": 230,
      "ConsentPurposeKey": "reiciendis",
      "ConsentPurposeName": "Pouros LLC",
      "ConsentSourceId": 673,
      "ConsentSourceKey": "id",
      "ConsentSourceName": "Graham, Adams and Kirlin"
    }
  ],
  "BounceEmails": [
    "alexandra@tremblay.co.uk",
    "ezequiel.gottlieb@bosco.com"
  ],
  "ActiveStatusMonitorId": 82,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Mr. Angie Mozell Bernhard"
  },
  "ExtraFields": {
    "ExtraFields1": "optio",
    "ExtraFields2": "libero"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "est"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "culpa",
  "2": "quia"
}
```