---
title: POST Person
uid: v1PersonEntity_PostPersonEntity
generated: true
content_type: reference
---

# POST Person

```http
POST /api/v1/Person
```

Creates a new PersonEntity


Calls the Person agent service SavePersonEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Person?$select=name,department,category/id
```


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

## Request Body: newEntity 

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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating this person, readonly fields |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntityWithLinks

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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating this person, readonly fields |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 374,
  "Firstname": "Nicole",
  "MiddleName": "Sporer-Hahn",
  "Lastname": "Wuckert",
  "Mrmrs": "quo",
  "Title": "quasi",
  "UpdatedDate": "2022-08-29T03:47:00.0505611+02:00",
  "CreatedDate": "2022-03-28T03:47:00.0505611+02:00",
  "BirthDate": "2000-03-25T03:47:00.0505611+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "incidunt",
      "Description": "User-centric needs-based strategy"
    },
    {
      "Value": "et",
      "StrippedValue": "incidunt",
      "Description": "User-centric needs-based strategy"
    }
  ],
  "Description": "Advanced 24 hour forecast",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "enim",
      "Description": "Customer-focused 24 hour budgetary management"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "enim",
      "Description": "Customer-focused 24 hour budgetary management"
    }
  ],
  "Faxes": [
    {
      "Value": "iste",
      "StrippedValue": "voluptas",
      "Description": "Total static internet solution"
    },
    {
      "Value": "iste",
      "StrippedValue": "voluptas",
      "Description": "Total static internet solution"
    }
  ],
  "MobilePhones": [
    {
      "Value": "neque",
      "StrippedValue": "eos",
      "Description": "Innovative attitude-oriented leverage"
    },
    {
      "Value": "neque",
      "StrippedValue": "eos",
      "Description": "Innovative attitude-oriented leverage"
    }
  ],
  "OfficePhones": [
    {
      "Value": "quis",
      "StrippedValue": "et",
      "Description": "Function-based eco-centric database"
    },
    {
      "Value": "quis",
      "StrippedValue": "et",
      "Description": "Function-based eco-centric database"
    }
  ],
  "OtherPhones": [
    {
      "Value": "nihil",
      "StrippedValue": "assumenda",
      "Description": "Reactive grid-enabled product"
    },
    {
      "Value": "nihil",
      "StrippedValue": "assumenda",
      "Description": "Reactive grid-enabled product"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 364,
      "Name": "Kerluke Inc and Sons",
      "ToolTip": "Dolores mollitia ipsum incidunt beatae nulla.",
      "Deleted": false,
      "Rank": 792,
      "Type": "corporis",
      "ColorBlock": 780,
      "IconHint": "quod",
      "Selected": false,
      "LastChanged": "2008-05-24T03:47:00.0505611+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestias",
      "StyleHint": "neque",
      "Hidden": false,
      "FullName": "Prof. Elfrieda Dickinson Jr."
    }
  ],
  "PersonNumber": "1214340",
  "FullName": "Forrest Herzog",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "eligendi",
      "StrippedValue": "id",
      "Description": "Quality-focused intangible pricing structure"
    },
    {
      "Value": "eligendi",
      "StrippedValue": "id",
      "Description": "Quality-focused intangible pricing structure"
    }
  ],
  "FormalName": "Kuvalis Inc and Sons",
  "Address": null,
  "Post3": "eum",
  "Post2": "nobis",
  "Post1": "quod",
  "Kanalname": "quia",
  "Kanafname": "ut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "consequuntur",
  "ActiveInterests": 857,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 100,
  "DbiKey": "totam",
  "DbiLastModified": "2025-07-26T03:47:00.0505611+02:00",
  "DbiLastSyncronized": "2018-10-20T03:47:00.0505611+02:00",
  "SentInfo": 694,
  "ShowContactTickets": 394,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nostrum",
      "StrippedValue": "unde",
      "Description": "Versatile composite matrix"
    },
    {
      "Value": "nostrum",
      "StrippedValue": "unde",
      "Description": "Versatile composite matrix"
    }
  ],
  "InternetPhones": [
    {
      "Value": "rem",
      "StrippedValue": "unde",
      "Description": "Right-sized logistical function"
    },
    {
      "Value": "rem",
      "StrippedValue": "unde",
      "Description": "Right-sized logistical function"
    }
  ],
  "Source": 465,
  "ActiveErpLinks": 246,
  "ShipmentTypes": [
    {
      "Id": 321,
      "Name": "Harber-Von",
      "ToolTip": "Nihil pariatur nihil porro illum saepe impedit.",
      "Deleted": false,
      "Rank": 553,
      "Type": "neque",
      "ColorBlock": 530,
      "IconHint": "blanditiis",
      "Selected": true,
      "LastChanged": "2005-10-06T03:47:00.0505611+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestias",
      "StyleHint": "asperiores",
      "Hidden": false,
      "FullName": "Grant Zieme DVM"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 16,
      "Comment": "non",
      "Registered": "2001-02-04T03:47:00.0505611+01:00",
      "RegisteredAssociateId": 848,
      "Updated": "1998-09-02T03:47:00.0505611+02:00",
      "UpdatedAssociateId": 993,
      "LegalBaseId": 620,
      "LegalBaseKey": "necessitatibus",
      "LegalBaseName": "Beer, Krajcik and Sipes",
      "ConsentPurposeId": 96,
      "ConsentPurposeKey": "fuga",
      "ConsentPurposeName": "Harber Inc and Sons",
      "ConsentSourceId": 139,
      "ConsentSourceKey": "quia",
      "ConsentSourceName": "Farrell LLC"
    }
  ],
  "BounceEmails": [
    "bradly.schaden@danielheller.us",
    "faustino_bartoletti@nicolas.ca"
  ],
  "ActiveStatusMonitorId": 137,
  "CreatedByFormId": 972,
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Margarete Cayla Lakin Jr.",
    "SuperOffice:2": "Dr. Heath Winfield Dooley II"
  },
  "ExtraFields": {
    "ExtraFields1": "nisi",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "aliquam",
    "CustomFields2": "delectus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 272,
  "Firstname": "Ned",
  "MiddleName": "Hagenes-Wiegand",
  "Lastname": "Kris",
  "Mrmrs": "architecto",
  "Title": "voluptas",
  "UpdatedDate": "1998-04-15T03:47:00.0505611+02:00",
  "CreatedDate": "2012-05-29T03:47:00.0505611+02:00",
  "BirthDate": "2008-11-30T03:47:00.0505611+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptatum",
      "StrippedValue": "nesciunt",
      "Description": "Programmable encompassing firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 573
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "nesciunt",
      "Description": "Programmable encompassing firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 573
        }
      }
    }
  ],
  "Description": "Multi-channelled bi-directional throughput",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "consequuntur",
      "StrippedValue": "a",
      "Description": "Persistent motivating firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 147
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "a",
      "Description": "Persistent motivating firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 147
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "repellendus",
      "StrippedValue": "ad",
      "Description": "Exclusive incremental strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 640
        }
      }
    },
    {
      "Value": "repellendus",
      "StrippedValue": "ad",
      "Description": "Exclusive incremental strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 640
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sit",
      "StrippedValue": "id",
      "Description": "Function-based client-driven firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 748
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "id",
      "Description": "Function-based client-driven firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 748
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aut",
      "StrippedValue": "esse",
      "Description": "Diverse stable adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "esse",
      "Description": "Diverse stable adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "enim",
      "Description": "Synergized methodical model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 614
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "enim",
      "Description": "Synergized methodical model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 614
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
      "Id": 90,
      "Name": "Oberbrunner, Hayes and Labadie",
      "ToolTip": "Laudantium nulla sed est qui aspernatur.",
      "Deleted": false,
      "Rank": 462,
      "Type": "voluptatem",
      "ColorBlock": 990,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2019-05-26T03:47:00.0505611+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "totam",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Joshuah Feeney",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    }
  ],
  "PersonNumber": "994018",
  "FullName": "Ottis Keebler",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "aspernatur",
      "StrippedValue": "vel",
      "Description": "Mandatory radical parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 636
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "vel",
      "Description": "Mandatory radical parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 636
        }
      }
    }
  ],
  "FormalName": "Gutkowski-Stanton",
  "Address": null,
  "Post3": "et",
  "Post2": "porro",
  "Post1": "qui",
  "Kanalname": "molestiae",
  "Kanafname": "ab",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "nihil",
  "ActiveInterests": 665,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 1000,
  "DbiKey": "eum",
  "DbiLastModified": "2016-05-05T03:47:00.0505611+02:00",
  "DbiLastSyncronized": "2021-01-04T03:47:00.0505611+01:00",
  "SentInfo": 555,
  "ShowContactTickets": 599,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "deserunt",
      "StrippedValue": "corporis",
      "Description": "Organic static matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 192
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "corporis",
      "Description": "Organic static matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 192
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "tempore",
      "StrippedValue": "aliquam",
      "Description": "Team-oriented executive productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "aliquam",
      "Description": "Team-oriented executive productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    }
  ],
  "Source": 978,
  "ActiveErpLinks": 545,
  "ShipmentTypes": [
    {
      "Id": 948,
      "Name": "Wilderman, McGlynn and Hermiston",
      "ToolTip": "Tenetur id et sed qui consectetur.",
      "Deleted": true,
      "Rank": 963,
      "Type": "quo",
      "ColorBlock": 78,
      "IconHint": "velit",
      "Selected": true,
      "LastChanged": "1998-08-23T03:47:00.0505611+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Mr. David Joesph Prosacco",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 834
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 603,
      "Comment": "odio",
      "Registered": "1999-01-23T03:47:00.0505611+01:00",
      "RegisteredAssociateId": 468,
      "Updated": "2010-09-08T03:47:00.0505611+02:00",
      "UpdatedAssociateId": 176,
      "LegalBaseId": 199,
      "LegalBaseKey": "quisquam",
      "LegalBaseName": "O'Keefe-Gleichner",
      "ConsentPurposeId": 942,
      "ConsentPurposeKey": "eligendi",
      "ConsentPurposeName": "Bosco, Bogan and Altenwerth",
      "ConsentSourceId": 423,
      "ConsentSourceKey": "distinctio",
      "ConsentSourceName": "Lehner, Kemmer and Rice",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    }
  ],
  "BounceEmails": [
    "kole@adams.co.uk",
    "chanel.breitenberg@rogahn.biz"
  ],
  "ActiveStatusMonitorId": 878,
  "CreatedByFormId": 721,
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Isai Jonas Torphy V",
    "SuperOffice:2": "Benedict Balistreri"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "totam",
    "CustomFields2": "dolor"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 676
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```