---
title: POST Person
uid: v1PersonEntity_PostPersonEntity
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
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "PersonId": 218,
  "Firstname": "Caroline",
  "MiddleName": "Paucek-Schamberger",
  "Lastname": "McGlynn",
  "Mrmrs": "nulla",
  "Title": "numquam",
  "UpdatedDate": "2000-02-05T03:51:33.7240727+01:00",
  "CreatedDate": "1999-12-08T03:51:33.7240727+01:00",
  "BirthDate": "1999-06-19T03:51:33.7240727+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "rem",
      "StrippedValue": "facilis",
      "Description": "Programmable user-facing core"
    },
    {
      "Value": "rem",
      "StrippedValue": "facilis",
      "Description": "Programmable user-facing core"
    }
  ],
  "Description": "Diverse incremental model",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "quibusdam",
      "Description": "Advanced tertiary moderator"
    },
    {
      "Value": "et",
      "StrippedValue": "quibusdam",
      "Description": "Advanced tertiary moderator"
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Monitored maximized complexity"
    },
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Monitored maximized complexity"
    }
  ],
  "MobilePhones": [
    {
      "Value": "autem",
      "StrippedValue": "perferendis",
      "Description": "Mandatory human-resource artificial intelligence"
    },
    {
      "Value": "autem",
      "StrippedValue": "perferendis",
      "Description": "Mandatory human-resource artificial intelligence"
    }
  ],
  "OfficePhones": [
    {
      "Value": "aut",
      "StrippedValue": "et",
      "Description": "Organized composite adapter"
    },
    {
      "Value": "aut",
      "StrippedValue": "et",
      "Description": "Organized composite adapter"
    }
  ],
  "OtherPhones": [
    {
      "Value": "fugiat",
      "StrippedValue": "et",
      "Description": "Horizontal client-driven orchestration"
    },
    {
      "Value": "fugiat",
      "StrippedValue": "et",
      "Description": "Horizontal client-driven orchestration"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 277,
      "Name": "Mann, Labadie and Collier",
      "ToolTip": "Aut cum enim vel.",
      "Deleted": false,
      "Rank": 37,
      "Type": "excepturi",
      "ColorBlock": 348,
      "IconHint": "cumque",
      "Selected": true,
      "LastChanged": "2011-06-11T03:51:33.7240727+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "asperiores",
      "Hidden": false,
      "FullName": "Martine Koss"
    }
  ],
  "PersonNumber": "794522",
  "FullName": "Dr. Jacinthe Bergnaum",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "earum",
      "StrippedValue": "quia",
      "Description": "Right-sized tangible moratorium"
    },
    {
      "Value": "earum",
      "StrippedValue": "quia",
      "Description": "Right-sized tangible moratorium"
    }
  ],
  "FormalName": "Anderson Group",
  "Address": null,
  "Post3": "voluptatibus",
  "Post2": "explicabo",
  "Post1": "voluptatem",
  "Kanalname": "delectus",
  "Kanafname": "porro",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "alias",
  "ActiveInterests": 872,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 504,
  "DbiKey": "corrupti",
  "DbiLastModified": "2010-06-28T03:51:33.7240727+02:00",
  "DbiLastSyncronized": "2022-03-25T03:51:33.7240727+01:00",
  "SentInfo": 350,
  "ShowContactTickets": 434,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "dolor",
      "StrippedValue": "voluptatem",
      "Description": "Operative optimizing moderator"
    },
    {
      "Value": "dolor",
      "StrippedValue": "voluptatem",
      "Description": "Operative optimizing moderator"
    }
  ],
  "InternetPhones": [
    {
      "Value": "nam",
      "StrippedValue": "ducimus",
      "Description": "Synchronised user-facing artificial intelligence"
    },
    {
      "Value": "nam",
      "StrippedValue": "ducimus",
      "Description": "Synchronised user-facing artificial intelligence"
    }
  ],
  "Source": 319,
  "ActiveErpLinks": 770,
  "ShipmentTypes": [
    {
      "Id": 117,
      "Name": "Reinger, Hoeger and Rippin",
      "ToolTip": "Sed enim suscipit sit sit.",
      "Deleted": false,
      "Rank": 743,
      "Type": "at",
      "ColorBlock": 223,
      "IconHint": "repudiandae",
      "Selected": true,
      "LastChanged": "2005-05-30T03:51:33.7240727+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veniam",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Dr. Vilma Lockman IV"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 149,
      "Comment": "ut",
      "Registered": "1997-04-27T03:51:33.7240727+02:00",
      "RegisteredAssociateId": 609,
      "Updated": "2015-12-23T03:51:33.7240727+01:00",
      "UpdatedAssociateId": 676,
      "LegalBaseId": 89,
      "LegalBaseKey": "laboriosam",
      "LegalBaseName": "Jerde-Turcotte",
      "ConsentPurposeId": 888,
      "ConsentPurposeKey": "minima",
      "ConsentPurposeName": "Heidenreich Inc and Sons",
      "ConsentSourceId": 184,
      "ConsentSourceKey": "qui",
      "ConsentSourceName": "Swift, Schowalter and Crist"
    }
  ],
  "BounceEmails": [
    "stephen@beermcclure.ca",
    "rachelle_grimes@ornleffler.info"
  ],
  "ActiveStatusMonitorId": 997,
  "UserDefinedFields": {
    "SuperOffice:1": "Ardella Bernhard",
    "SuperOffice:2": "508094644"
  },
  "ExtraFields": {
    "ExtraFields1": "reprehenderit",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "fugit",
    "CustomFields2": "nulla"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 590,
  "Firstname": "Rosanna",
  "MiddleName": "Gulgowski-Swaniawski",
  "Lastname": "Abernathy",
  "Mrmrs": "aspernatur",
  "Title": "autem",
  "UpdatedDate": "1998-09-10T03:51:33.7240727+02:00",
  "CreatedDate": "1998-09-10T03:51:33.7240727+02:00",
  "BirthDate": "2009-01-09T03:51:33.7240727+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "rerum",
      "Description": "Cross-platform optimal access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 611
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "rerum",
      "Description": "Cross-platform optimal access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 611
        }
      }
    }
  ],
  "Description": "Advanced 3rd generation process improvement",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "vitae",
      "StrippedValue": "dignissimos",
      "Description": "Advanced contextually-based parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 830
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "dignissimos",
      "Description": "Advanced contextually-based parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 830
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "est",
      "Description": "User-centric context-sensitive initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "est",
      "Description": "User-centric context-sensitive initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "autem",
      "StrippedValue": "amet",
      "Description": "Cloned systemic budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "amet",
      "Description": "Cloned systemic budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "modi",
      "StrippedValue": "et",
      "Description": "Synergistic executive application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 542
        }
      }
    },
    {
      "Value": "modi",
      "StrippedValue": "et",
      "Description": "Synergistic executive application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 542
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "dolor",
      "StrippedValue": "eius",
      "Description": "De-engineered encompassing superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "eius",
      "Description": "De-engineered encompassing superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
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
      "Id": 549,
      "Name": "Kuhlman-Stracke",
      "ToolTip": "Nostrum possimus ut.",
      "Deleted": true,
      "Rank": 142,
      "Type": "quaerat",
      "ColorBlock": 701,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2003-11-15T03:51:33.7396971+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsum",
      "StyleHint": "iusto",
      "Hidden": false,
      "FullName": "Webster Robel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    }
  ],
  "PersonNumber": "456229",
  "FullName": "Gregoria Hilll",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "ut",
      "Description": "User-friendly 6th generation leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "ut",
      "Description": "User-friendly 6th generation leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    }
  ],
  "FormalName": "Turcotte, White and Stanton",
  "Address": null,
  "Post3": "sit",
  "Post2": "adipisci",
  "Post1": "est",
  "Kanalname": "nemo",
  "Kanafname": "sapiente",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "qui",
  "ActiveInterests": 64,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 53,
  "DbiKey": "non",
  "DbiLastModified": "1998-03-17T03:51:33.7396971+01:00",
  "DbiLastSyncronized": "2015-07-10T03:51:33.7396971+02:00",
  "SentInfo": 61,
  "ShowContactTickets": 739,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ipsa",
      "StrippedValue": "animi",
      "Description": "Advanced mission-critical orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 810
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "animi",
      "Description": "Advanced mission-critical orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 810
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sed",
      "StrippedValue": "inventore",
      "Description": "Switchable value-added project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 91
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "inventore",
      "Description": "Switchable value-added project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 91
        }
      }
    }
  ],
  "Source": 423,
  "ActiveErpLinks": 988,
  "ShipmentTypes": [
    {
      "Id": 945,
      "Name": "Hessel, O'Connell and Keebler",
      "ToolTip": "Perspiciatis aliquid aut.",
      "Deleted": false,
      "Rank": 423,
      "Type": "fugit",
      "ColorBlock": 416,
      "IconHint": "architecto",
      "Selected": false,
      "LastChanged": "2013-06-19T03:51:33.7396971+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cupiditate",
      "StyleHint": "similique",
      "Hidden": false,
      "FullName": "Marco Harris",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 241
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 822,
      "Comment": "placeat",
      "Registered": "2018-05-10T03:51:33.7396971+02:00",
      "RegisteredAssociateId": 33,
      "Updated": "1997-04-24T03:51:33.7396971+02:00",
      "UpdatedAssociateId": 966,
      "LegalBaseId": 780,
      "LegalBaseKey": "enim",
      "LegalBaseName": "Kirlin, Breitenberg and Fay",
      "ConsentPurposeId": 738,
      "ConsentPurposeKey": "incidunt",
      "ConsentPurposeName": "Smitham, Pacocha and Champlin",
      "ConsentSourceId": 321,
      "ConsentSourceKey": "quia",
      "ConsentSourceName": "Ernser LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 151
        }
      }
    }
  ],
  "BounceEmails": [
    "korbin@wuckert.biz",
    "casandra@schmitt.uk"
  ],
  "ActiveStatusMonitorId": 472,
  "UserDefinedFields": {
    "SuperOffice:1": "1899109670",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "unde",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "tenetur",
    "CustomFields2": "modi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 590
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```