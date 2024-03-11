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
  "PersonId": 814,
  "Firstname": "Cassidy",
  "MiddleName": "Crooks, Batz and Nitzsche",
  "Lastname": "Schoen",
  "Mrmrs": "modi",
  "Title": "debitis",
  "UpdatedDate": "2020-11-05T14:23:46.9567612+01:00",
  "CreatedDate": "2012-04-05T14:23:46.9567612+02:00",
  "BirthDate": "2008-07-26T14:23:46.9567612+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "sit",
      "Description": "Secured clear-thinking standardization"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "sit",
      "Description": "Secured clear-thinking standardization"
    }
  ],
  "Description": "Enterprise-wide neutral contingency",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nihil",
      "StrippedValue": "saepe",
      "Description": "Synergistic static architecture"
    },
    {
      "Value": "nihil",
      "StrippedValue": "saepe",
      "Description": "Synergistic static architecture"
    }
  ],
  "Faxes": [
    {
      "Value": "eaque",
      "StrippedValue": "ea",
      "Description": "Switchable well-modulated infrastructure"
    },
    {
      "Value": "eaque",
      "StrippedValue": "ea",
      "Description": "Switchable well-modulated infrastructure"
    }
  ],
  "MobilePhones": [
    {
      "Value": "magni",
      "StrippedValue": "voluptas",
      "Description": "Polarised radical attitude"
    },
    {
      "Value": "magni",
      "StrippedValue": "voluptas",
      "Description": "Polarised radical attitude"
    }
  ],
  "OfficePhones": [
    {
      "Value": "non",
      "StrippedValue": "quidem",
      "Description": "Organic even-keeled adapter"
    },
    {
      "Value": "non",
      "StrippedValue": "quidem",
      "Description": "Organic even-keeled adapter"
    }
  ],
  "OtherPhones": [
    {
      "Value": "non",
      "StrippedValue": "fuga",
      "Description": "Down-sized fault-tolerant open architecture"
    },
    {
      "Value": "non",
      "StrippedValue": "fuga",
      "Description": "Down-sized fault-tolerant open architecture"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 321,
      "Name": "Von, Stokes and Hudson",
      "ToolTip": "Beatae qui rerum ex repellat.",
      "Deleted": true,
      "Rank": 339,
      "Type": "quia",
      "ColorBlock": 764,
      "IconHint": "enim",
      "Selected": false,
      "LastChanged": "2014-07-20T14:23:46.9567612+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Tyrese Brown"
    }
  ],
  "PersonNumber": "768845",
  "FullName": "Heather O'Connell",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "veniam",
      "Description": "Customizable directional monitoring"
    },
    {
      "Value": "omnis",
      "StrippedValue": "veniam",
      "Description": "Customizable directional monitoring"
    }
  ],
  "FormalName": "Langosh-Hackett",
  "Address": null,
  "Post3": "temporibus",
  "Post2": "non",
  "Post1": "commodi",
  "Kanalname": "earum",
  "Kanafname": "distinctio",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "placeat",
  "ActiveInterests": 650,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 35,
  "DbiKey": "id",
  "DbiLastModified": "1998-05-21T14:23:46.9567612+02:00",
  "DbiLastSyncronized": "2021-06-09T14:23:46.9567612+02:00",
  "SentInfo": 932,
  "ShowContactTickets": 600,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "aliquid",
      "StrippedValue": "sit",
      "Description": "Configurable contextually-based adapter"
    },
    {
      "Value": "aliquid",
      "StrippedValue": "sit",
      "Description": "Configurable contextually-based adapter"
    }
  ],
  "InternetPhones": [
    {
      "Value": "illo",
      "StrippedValue": "ut",
      "Description": "Switchable bi-directional groupware"
    },
    {
      "Value": "illo",
      "StrippedValue": "ut",
      "Description": "Switchable bi-directional groupware"
    }
  ],
  "Source": 671,
  "ActiveErpLinks": 232,
  "ShipmentTypes": [
    {
      "Id": 63,
      "Name": "Schaefer-Klein",
      "ToolTip": "Nihil et ut qui.",
      "Deleted": false,
      "Rank": 771,
      "Type": "adipisci",
      "ColorBlock": 168,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "2002-03-13T14:23:46.9567612+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perspiciatis",
      "StyleHint": "cupiditate",
      "Hidden": false,
      "FullName": "Dr. Tyler Ola Ledner"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 666,
      "Comment": "iusto",
      "Registered": "2004-11-29T14:23:46.9567612+01:00",
      "RegisteredAssociateId": 304,
      "Updated": "2016-08-05T14:23:46.9567612+02:00",
      "UpdatedAssociateId": 479,
      "LegalBaseId": 913,
      "LegalBaseKey": "distinctio",
      "LegalBaseName": "Donnelly-Schmitt",
      "ConsentPurposeId": 162,
      "ConsentPurposeKey": "eligendi",
      "ConsentPurposeName": "Barton-Bruen",
      "ConsentSourceId": 16,
      "ConsentSourceKey": "est",
      "ConsentSourceName": "Reilly-Stokes"
    }
  ],
  "BounceEmails": [
    "kiley@denesiklynch.biz",
    "genesis@gottliebkautzer.ca"
  ],
  "ActiveStatusMonitorId": 825,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Dr. Keshaun Bogan"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "magni"
  },
  "CustomFields": {
    "CustomFields1": "atque",
    "CustomFields2": "cum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 799,
  "Firstname": "Joanny",
  "MiddleName": "Sipes-Renner",
  "Lastname": "Adams",
  "Mrmrs": "veritatis",
  "Title": "consequuntur",
  "UpdatedDate": "2020-04-04T14:23:46.9723869+02:00",
  "CreatedDate": "2023-05-24T14:23:46.9723869+02:00",
  "BirthDate": "2015-04-22T14:23:46.9723869+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "quia",
      "Description": "Optional local productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 376
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "quia",
      "Description": "Optional local productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 376
        }
      }
    }
  ],
  "Description": "Focused composite function",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "quis",
      "StrippedValue": "quae",
      "Description": "Organic human-resource conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "quae",
      "Description": "Organic human-resource conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "fugiat",
      "StrippedValue": "quasi",
      "Description": "Public-key national website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 292
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "quasi",
      "Description": "Public-key national website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 292
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "et",
      "Description": "Grass-roots user-facing flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 704
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "et",
      "Description": "Grass-roots user-facing flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 704
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "id",
      "Description": "Diverse bandwidth-monitored strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "id",
      "Description": "Diverse bandwidth-monitored strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 688
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "dicta",
      "StrippedValue": "ut",
      "Description": "Managed 5th generation groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "ut",
      "Description": "Managed 5th generation groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
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
      "Id": 721,
      "Name": "Lubowitz-Mraz",
      "ToolTip": "Totam quis dolore sapiente magni est.",
      "Deleted": false,
      "Rank": 829,
      "Type": "id",
      "ColorBlock": 443,
      "IconHint": "facilis",
      "Selected": false,
      "LastChanged": "1998-08-18T14:23:46.9723869+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quidem",
      "StyleHint": "maxime",
      "Hidden": true,
      "FullName": "Carson Moen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 98
        }
      }
    }
  ],
  "PersonNumber": "1647421",
  "FullName": "Jules Enrico Fahey Jr.",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "dolore",
      "StrippedValue": "vero",
      "Description": "Proactive asynchronous knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 976
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "vero",
      "Description": "Proactive asynchronous knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 976
        }
      }
    }
  ],
  "FormalName": "Pfeffer-D'Amore",
  "Address": null,
  "Post3": "consectetur",
  "Post2": "sit",
  "Post1": "ut",
  "Kanalname": "nam",
  "Kanafname": "quia",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 897,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 507,
  "DbiKey": "commodi",
  "DbiLastModified": "2008-05-08T14:23:46.9723869+02:00",
  "DbiLastSyncronized": "2012-04-15T14:23:46.9723869+02:00",
  "SentInfo": 490,
  "ShowContactTickets": 452,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nam",
      "StrippedValue": "expedita",
      "Description": "Re-engineered demand-driven time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 482
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "expedita",
      "Description": "Re-engineered demand-driven time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 482
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ad",
      "StrippedValue": "enim",
      "Description": "Vision-oriented encompassing array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 624
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "enim",
      "Description": "Vision-oriented encompassing array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 624
        }
      }
    }
  ],
  "Source": 657,
  "ActiveErpLinks": 879,
  "ShipmentTypes": [
    {
      "Id": 493,
      "Name": "Hammes-Kling",
      "ToolTip": "Unde molestiae aut et.",
      "Deleted": false,
      "Rank": 678,
      "Type": "totam",
      "ColorBlock": 615,
      "IconHint": "similique",
      "Selected": false,
      "LastChanged": "2009-05-05T14:23:46.9723869+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "ut",
      "Hidden": true,
      "FullName": "Mafalda Dicki",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 941
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 650,
      "Comment": "et",
      "Registered": "2003-01-05T14:23:46.9723869+01:00",
      "RegisteredAssociateId": 412,
      "Updated": "2003-03-04T14:23:46.9723869+01:00",
      "UpdatedAssociateId": 544,
      "LegalBaseId": 858,
      "LegalBaseKey": "necessitatibus",
      "LegalBaseName": "Brekke, Swift and Williamson",
      "ConsentPurposeId": 292,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Batz-Jones",
      "ConsentSourceId": 708,
      "ConsentSourceKey": "ab",
      "ConsentSourceName": "Robel Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    }
  ],
  "BounceEmails": [
    "carlos.jones@durgan.biz",
    "lambert.lindgren@lindgren.com"
  ],
  "ActiveStatusMonitorId": 485,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "corporis"
  },
  "CustomFields": {
    "CustomFields1": "labore",
    "CustomFields2": "tempora"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 465
    }
  }
}
```