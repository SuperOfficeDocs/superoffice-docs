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
| CreatedByFormId | Integer | The form id of the form that created the person |
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
  "PersonId": 389,
  "Firstname": "Danny",
  "MiddleName": "Bogisich LLC",
  "Lastname": "Beatty",
  "Mrmrs": "officia",
  "Title": "qui",
  "UpdatedDate": "2005-08-17T13:28:31.8198338+02:00",
  "CreatedDate": "2004-07-14T13:28:31.8198338+02:00",
  "BirthDate": "2020-10-31T13:28:31.8198338+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptatum",
      "StrippedValue": "sed",
      "Description": "Universal global migration"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "sed",
      "Description": "Universal global migration"
    }
  ],
  "Description": "Self-enabling mission-critical projection",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "deserunt",
      "StrippedValue": "rerum",
      "Description": "Adaptive heuristic ability"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "rerum",
      "Description": "Adaptive heuristic ability"
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "ipsa",
      "Description": "Function-based 4th generation system engine"
    },
    {
      "Value": "qui",
      "StrippedValue": "ipsa",
      "Description": "Function-based 4th generation system engine"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quo",
      "StrippedValue": "asperiores",
      "Description": "Devolved full-range info-mediaries"
    },
    {
      "Value": "quo",
      "StrippedValue": "asperiores",
      "Description": "Devolved full-range info-mediaries"
    }
  ],
  "OfficePhones": [
    {
      "Value": "praesentium",
      "StrippedValue": "dolorem",
      "Description": "Re-engineered global secured line"
    },
    {
      "Value": "praesentium",
      "StrippedValue": "dolorem",
      "Description": "Re-engineered global secured line"
    }
  ],
  "OtherPhones": [
    {
      "Value": "quidem",
      "StrippedValue": "tempore",
      "Description": "Sharable high-level open system"
    },
    {
      "Value": "quidem",
      "StrippedValue": "tempore",
      "Description": "Sharable high-level open system"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 663,
      "Name": "Schumm-Hudson",
      "ToolTip": "Consequatur officia nesciunt quia sit eius itaque.",
      "Deleted": true,
      "Rank": 784,
      "Type": "voluptatem",
      "ColorBlock": 867,
      "IconHint": "ex",
      "Selected": false,
      "LastChanged": "2008-09-29T13:28:31.8198338+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "alias",
      "StyleHint": "delectus",
      "Hidden": false,
      "FullName": "Rashad Jerde III"
    }
  ],
  "PersonNumber": "1357380",
  "FullName": "Anabelle Gibson",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "vel",
      "StrippedValue": "quia",
      "Description": "Sharable homogeneous array"
    },
    {
      "Value": "vel",
      "StrippedValue": "quia",
      "Description": "Sharable homogeneous array"
    }
  ],
  "FormalName": "Walter LLC",
  "Address": null,
  "Post3": "officiis",
  "Post2": "earum",
  "Post1": "hic",
  "Kanalname": "occaecati",
  "Kanafname": "voluptates",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quae",
  "ActiveInterests": 171,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 38,
  "DbiKey": "omnis",
  "DbiLastModified": "1997-07-24T13:28:31.8198338+02:00",
  "DbiLastSyncronized": "2002-02-01T13:28:31.8198338+01:00",
  "SentInfo": 711,
  "ShowContactTickets": 567,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "corporis",
      "StrippedValue": "est",
      "Description": "Compatible secondary methodology"
    },
    {
      "Value": "corporis",
      "StrippedValue": "est",
      "Description": "Compatible secondary methodology"
    }
  ],
  "InternetPhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "sapiente",
      "Description": "Adaptive intangible solution"
    },
    {
      "Value": "quisquam",
      "StrippedValue": "sapiente",
      "Description": "Adaptive intangible solution"
    }
  ],
  "Source": 875,
  "ActiveErpLinks": 255,
  "ShipmentTypes": [
    {
      "Id": 890,
      "Name": "Hansen Inc and Sons",
      "ToolTip": "Ab sint atque voluptate.",
      "Deleted": false,
      "Rank": 901,
      "Type": "ex",
      "ColorBlock": 68,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2022-09-03T13:28:31.8198338+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "at",
      "StyleHint": "dolorem",
      "Hidden": false,
      "FullName": "Mr. Abbie Valentin Schaden III"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 925,
      "Comment": "vitae",
      "Registered": "2003-06-27T13:28:31.8198338+02:00",
      "RegisteredAssociateId": 777,
      "Updated": "2010-07-18T13:28:31.8198338+02:00",
      "UpdatedAssociateId": 838,
      "LegalBaseId": 550,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Zemlak, Langosh and Schroeder",
      "ConsentPurposeId": 730,
      "ConsentPurposeKey": "sunt",
      "ConsentPurposeName": "Greenfelder-Buckridge",
      "ConsentSourceId": 575,
      "ConsentSourceKey": "corrupti",
      "ConsentSourceName": "Ondricka, Mohr and Schamberger"
    }
  ],
  "BounceEmails": [
    "clarissa@runolfsson.com",
    "tia_fritsch@torp.uk"
  ],
  "ActiveStatusMonitorId": 653,
  "CreatedByFormId": 567,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Abdul Flossie Stanton Jr.",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "laudantium"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "officia",
  "2": "minima"
}
```