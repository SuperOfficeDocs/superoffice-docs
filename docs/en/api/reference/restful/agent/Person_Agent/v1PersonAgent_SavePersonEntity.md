---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty








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

## Request Body: entity 

The PersonEntity to be saved. 

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

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | int32 | The form id of the form that created the person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 684,
  "Firstname": "Melissa",
  "MiddleName": "Maggio LLC",
  "Lastname": "Russel",
  "Mrmrs": "pariatur",
  "Title": "alias",
  "UpdatedDate": "2014-03-08T12:01:28.0096725+01:00",
  "CreatedDate": "2008-10-29T12:01:28.0096725+01:00",
  "BirthDate": "2025-01-13T12:01:28.0096725+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "fuga",
      "StrippedValue": "et",
      "Description": "Multi-layered asynchronous encoding"
    },
    {
      "Value": "fuga",
      "StrippedValue": "et",
      "Description": "Multi-layered asynchronous encoding"
    }
  ],
  "Description": "Quality-focused eco-centric synergy",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "officia",
      "StrippedValue": "debitis",
      "Description": "Ergonomic 24 hour Graphic Interface"
    },
    {
      "Value": "officia",
      "StrippedValue": "debitis",
      "Description": "Ergonomic 24 hour Graphic Interface"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Networked uniform paradigm"
    },
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Networked uniform paradigm"
    }
  ],
  "MobilePhones": [
    {
      "Value": "est",
      "StrippedValue": "adipisci",
      "Description": "Compatible scalable matrices"
    },
    {
      "Value": "est",
      "StrippedValue": "adipisci",
      "Description": "Compatible scalable matrices"
    }
  ],
  "OfficePhones": [
    {
      "Value": "eveniet",
      "StrippedValue": "inventore",
      "Description": "Synchronised global project"
    },
    {
      "Value": "eveniet",
      "StrippedValue": "inventore",
      "Description": "Synchronised global project"
    }
  ],
  "OtherPhones": [
    {
      "Value": "officiis",
      "StrippedValue": "molestiae",
      "Description": "Sharable interactive toolset"
    },
    {
      "Value": "officiis",
      "StrippedValue": "molestiae",
      "Description": "Sharable interactive toolset"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 647,
      "Name": "Anderson-Howe",
      "ToolTip": "Aut cum facilis.",
      "Deleted": false,
      "Rank": 553,
      "Type": "non",
      "ColorBlock": 482,
      "IconHint": "quod",
      "Selected": false,
      "LastChanged": "2008-03-09T12:01:28.0252987+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magni",
      "StyleHint": "impedit",
      "Hidden": false,
      "FullName": "Prof. Emely Stoltenberg DVM"
    }
  ],
  "PersonNumber": "670954",
  "FullName": "Hilda Lilly Torphy DVM",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "incidunt",
      "StrippedValue": "omnis",
      "Description": "Grass-roots 24 hour intranet"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "omnis",
      "Description": "Grass-roots 24 hour intranet"
    }
  ],
  "FormalName": "Kuvalis-McKenzie",
  "Address": null,
  "Post3": "possimus",
  "Post2": "corrupti",
  "Post1": "dolorem",
  "Kanalname": "non",
  "Kanafname": "voluptas",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "recusandae",
  "ActiveInterests": 391,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 18,
  "DbiKey": "sint",
  "DbiLastModified": "2011-12-11T12:01:28.0252987+01:00",
  "DbiLastSyncronized": "2003-01-13T12:01:28.0252987+01:00",
  "SentInfo": 846,
  "ShowContactTickets": 521,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quae",
      "StrippedValue": "eveniet",
      "Description": "Managed optimizing matrices"
    },
    {
      "Value": "quae",
      "StrippedValue": "eveniet",
      "Description": "Managed optimizing matrices"
    }
  ],
  "InternetPhones": [
    {
      "Value": "nam",
      "StrippedValue": "voluptas",
      "Description": "Customizable dedicated software"
    },
    {
      "Value": "nam",
      "StrippedValue": "voluptas",
      "Description": "Customizable dedicated software"
    }
  ],
  "Source": 62,
  "ActiveErpLinks": 950,
  "ShipmentTypes": [
    {
      "Id": 792,
      "Name": "O'Connell LLC",
      "ToolTip": "Et rerum cum perspiciatis.",
      "Deleted": false,
      "Rank": 736,
      "Type": "exercitationem",
      "ColorBlock": 315,
      "IconHint": "dolore",
      "Selected": false,
      "LastChanged": "2008-09-20T12:01:28.0252987+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "a",
      "Hidden": false,
      "FullName": "Leta Torp"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 751,
      "Comment": "debitis",
      "Registered": "2008-06-01T12:01:28.0252987+02:00",
      "RegisteredAssociateId": 383,
      "Updated": "2010-12-11T12:01:28.0252987+01:00",
      "UpdatedAssociateId": 850,
      "LegalBaseId": 876,
      "LegalBaseKey": "iure",
      "LegalBaseName": "Cartwright Inc and Sons",
      "ConsentPurposeId": 858,
      "ConsentPurposeKey": "autem",
      "ConsentPurposeName": "Hessel LLC",
      "ConsentSourceId": 324,
      "ConsentSourceKey": "corporis",
      "ConsentSourceName": "Schmitt-Sawayn"
    }
  ],
  "BounceEmails": [
    "tyrique@sporer.biz",
    "crystal@streichparisian.uk"
  ],
  "ActiveStatusMonitorId": 383,
  "CreatedByFormId": 46,
  "UserDefinedFields": {
    "SuperOffice:1": "369063485",
    "SuperOffice:2": "Desiree Cronin"
  },
  "ExtraFields": {
    "ExtraFields1": "dolores",
    "ExtraFields2": "animi"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "in"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 955,
  "Firstname": "Demarcus",
  "MiddleName": "O'Kon, Bahringer and Murphy",
  "Lastname": "Sporer",
  "Mrmrs": "ad",
  "Title": "nemo",
  "UpdatedDate": "2013-11-19T12:01:28.0252987+01:00",
  "CreatedDate": "2009-03-20T12:01:28.0252987+01:00",
  "BirthDate": "2020-11-15T12:01:28.0252987+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "tempora",
      "Description": "Customer-focused zero administration protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 692
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "tempora",
      "Description": "Customer-focused zero administration protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 692
        }
      }
    }
  ],
  "Description": "Triple-buffered optimizing adapter",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quibusdam",
      "StrippedValue": "atque",
      "Description": "Universal value-added local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 361
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "atque",
      "Description": "Universal value-added local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 361
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolores",
      "StrippedValue": "rem",
      "Description": "Organized reciprocal ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 56
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "rem",
      "Description": "Organized reciprocal ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 56
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "soluta",
      "StrippedValue": "animi",
      "Description": "Secured homogeneous database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 919
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "animi",
      "Description": "Secured homogeneous database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 919
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "non",
      "StrippedValue": "quo",
      "Description": "Adaptive systematic data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 673
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "quo",
      "Description": "Adaptive systematic data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 673
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "harum",
      "StrippedValue": "eos",
      "Description": "Advanced system-worthy ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "eos",
      "Description": "Advanced system-worthy ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 466,
      "Name": "Kshlerin-Schaefer",
      "ToolTip": "Laboriosam error temporibus qui in qui.",
      "Deleted": true,
      "Rank": 428,
      "Type": "nulla",
      "ColorBlock": 383,
      "IconHint": "tempora",
      "Selected": true,
      "LastChanged": "2001-10-02T12:01:28.0252987+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repudiandae",
      "StyleHint": "alias",
      "Hidden": false,
      "FullName": "Hershel Herzog",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    }
  ],
  "PersonNumber": "135066",
  "FullName": "Florian Kuvalis",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "et",
      "Description": "Decentralized coherent neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 111
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "et",
      "Description": "Decentralized coherent neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 111
        }
      }
    }
  ],
  "FormalName": "Goldner Inc and Sons",
  "Address": null,
  "Post3": "a",
  "Post2": "et",
  "Post1": "soluta",
  "Kanalname": "molestiae",
  "Kanafname": "amet",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "maxime",
  "ActiveInterests": 331,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 260,
  "DbiKey": "alias",
  "DbiLastModified": "2013-10-07T12:01:28.0252987+02:00",
  "DbiLastSyncronized": "2014-11-06T12:01:28.0252987+01:00",
  "SentInfo": 678,
  "ShowContactTickets": 983,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quia",
      "StrippedValue": "ipsam",
      "Description": "Enhanced logistical access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "ipsam",
      "Description": "Enhanced logistical access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "eum",
      "StrippedValue": "quis",
      "Description": "Self-enabling directional customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 344
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "quis",
      "Description": "Self-enabling directional customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 344
        }
      }
    }
  ],
  "Source": 833,
  "ActiveErpLinks": 684,
  "ShipmentTypes": [
    {
      "Id": 215,
      "Name": "Collier, Koepp and Barrows",
      "ToolTip": "Velit a cumque expedita et est omnis.",
      "Deleted": true,
      "Rank": 339,
      "Type": "qui",
      "ColorBlock": 751,
      "IconHint": "exercitationem",
      "Selected": false,
      "LastChanged": "2024-01-28T12:01:28.0252987+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "autem",
      "Hidden": true,
      "FullName": "Prof. Adeline Langosh",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 219
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 593,
      "Comment": "architecto",
      "Registered": "2002-11-02T12:01:28.0252987+01:00",
      "RegisteredAssociateId": 773,
      "Updated": "2006-03-20T12:01:28.0252987+01:00",
      "UpdatedAssociateId": 378,
      "LegalBaseId": 57,
      "LegalBaseKey": "laudantium",
      "LegalBaseName": "Lesch Inc and Sons",
      "ConsentPurposeId": 233,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "West-Labadie",
      "ConsentSourceId": 73,
      "ConsentSourceKey": "non",
      "ConsentSourceName": "Beahan, Smith and Jewess",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 455
        }
      }
    }
  ],
  "BounceEmails": [
    "demarco.corkery@wisozk.co.uk",
    "jayne@heidenreich.uk"
  ],
  "ActiveStatusMonitorId": 627,
  "CreatedByFormId": 379,
  "UserDefinedFields": {
    "SuperOffice:1": "Emilie Okuneva",
    "SuperOffice:2": "Aryanna Zieme"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "ratione",
    "CustomFields2": "dolor"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 979
    }
  }
}
```