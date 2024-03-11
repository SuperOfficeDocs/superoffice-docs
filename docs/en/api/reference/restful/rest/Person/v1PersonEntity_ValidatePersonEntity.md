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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 773,
  "Firstname": "Lewis",
  "MiddleName": "Tillman Group",
  "Lastname": "Zieme",
  "Mrmrs": "optio",
  "Title": "ullam",
  "UpdatedDate": "2011-02-11T14:23:55.2908369+01:00",
  "CreatedDate": "2001-10-04T14:23:55.2908369+02:00",
  "BirthDate": "2010-10-28T14:23:55.2908369+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "quis",
      "Description": "Proactive impactful capability"
    },
    {
      "Value": "et",
      "StrippedValue": "quis",
      "Description": "Proactive impactful capability"
    }
  ],
  "Description": "Implemented empowering policy",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "eius",
      "StrippedValue": "odio",
      "Description": "Horizontal stable encoding"
    },
    {
      "Value": "eius",
      "StrippedValue": "odio",
      "Description": "Horizontal stable encoding"
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "vitae",
      "Description": "Team-oriented incremental extranet"
    },
    {
      "Value": "qui",
      "StrippedValue": "vitae",
      "Description": "Team-oriented incremental extranet"
    }
  ],
  "MobilePhones": [
    {
      "Value": "maiores",
      "StrippedValue": "eveniet",
      "Description": "Switchable intermediate approach"
    },
    {
      "Value": "maiores",
      "StrippedValue": "eveniet",
      "Description": "Switchable intermediate approach"
    }
  ],
  "OfficePhones": [
    {
      "Value": "facere",
      "StrippedValue": "omnis",
      "Description": "Extended asynchronous interface"
    },
    {
      "Value": "facere",
      "StrippedValue": "omnis",
      "Description": "Extended asynchronous interface"
    }
  ],
  "OtherPhones": [
    {
      "Value": "id",
      "StrippedValue": "consequatur",
      "Description": "Public-key asynchronous extranet"
    },
    {
      "Value": "id",
      "StrippedValue": "consequatur",
      "Description": "Public-key asynchronous extranet"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 137,
      "Name": "O'Connell Inc and Sons",
      "ToolTip": "Placeat non distinctio temporibus nisi tempora ut sed.",
      "Deleted": false,
      "Rank": 253,
      "Type": "dignissimos",
      "ColorBlock": 72,
      "IconHint": "quisquam",
      "Selected": true,
      "LastChanged": "2006-06-28T14:23:55.2908369+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "unde",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Alvina Senger"
    }
  ],
  "PersonNumber": "1182649",
  "FullName": "Claudine Lizzie Dickens MD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "itaque",
      "StrippedValue": "laboriosam",
      "Description": "Cross-platform grid-enabled alliance"
    },
    {
      "Value": "itaque",
      "StrippedValue": "laboriosam",
      "Description": "Cross-platform grid-enabled alliance"
    }
  ],
  "FormalName": "Goyette-Gerlach",
  "Address": null,
  "Post3": "omnis",
  "Post2": "quia",
  "Post1": "cupiditate",
  "Kanalname": "et",
  "Kanafname": "dolore",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "aperiam",
  "ActiveInterests": 987,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 674,
  "DbiKey": "voluptas",
  "DbiLastModified": "2012-08-02T14:23:55.2908369+02:00",
  "DbiLastSyncronized": "2021-05-10T14:23:55.2908369+02:00",
  "SentInfo": 30,
  "ShowContactTickets": 664,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "deleniti",
      "StrippedValue": "reiciendis",
      "Description": "Total leading edge encryption"
    },
    {
      "Value": "deleniti",
      "StrippedValue": "reiciendis",
      "Description": "Total leading edge encryption"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "omnis",
      "Description": "Fundamental background model"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "omnis",
      "Description": "Fundamental background model"
    }
  ],
  "Source": 966,
  "ActiveErpLinks": 733,
  "ShipmentTypes": [
    {
      "Id": 55,
      "Name": "Schroeder Group",
      "ToolTip": "Nisi labore occaecati deleniti quaerat quam dicta.",
      "Deleted": true,
      "Rank": 392,
      "Type": "nihil",
      "ColorBlock": 597,
      "IconHint": "laboriosam",
      "Selected": false,
      "LastChanged": "2000-08-17T14:23:55.2908369+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "dicta",
      "Hidden": false,
      "FullName": "Mr. Mackenzie O'Keefe I"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 513,
      "Comment": "sed",
      "Registered": "2022-11-04T14:23:55.2908369+01:00",
      "RegisteredAssociateId": 505,
      "Updated": "2001-10-25T14:23:55.2908369+02:00",
      "UpdatedAssociateId": 207,
      "LegalBaseId": 412,
      "LegalBaseKey": "distinctio",
      "LegalBaseName": "Rau, Mayer and Greenholt",
      "ConsentPurposeId": 237,
      "ConsentPurposeKey": "reprehenderit",
      "ConsentPurposeName": "Bayer LLC",
      "ConsentSourceId": 672,
      "ConsentSourceKey": "doloremque",
      "ConsentSourceName": "Armstrong Inc and Sons"
    }
  ],
  "BounceEmails": [
    "shanie@weissnattorp.name",
    "amos@cronin.info"
  ],
  "ActiveStatusMonitorId": 487,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Geovany Bartell"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "ex"
  },
  "CustomFields": {
    "CustomFields1": "magnam",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "voluptatem",
  "2": "molestiae"
}
```