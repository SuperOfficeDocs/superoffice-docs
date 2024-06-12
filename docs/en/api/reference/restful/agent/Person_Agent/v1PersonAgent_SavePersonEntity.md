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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 687,
  "Firstname": "Roslyn",
  "MiddleName": "Johnson-Denesik",
  "Lastname": "Mraz",
  "Mrmrs": "nihil",
  "Title": "perspiciatis",
  "UpdatedDate": "2005-03-24T04:22:27.1122473+01:00",
  "CreatedDate": "2017-09-16T04:22:27.1122473+02:00",
  "BirthDate": "2018-04-03T04:22:27.1122473+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "eum",
      "StrippedValue": "soluta",
      "Description": "Intuitive eco-centric artificial intelligence"
    },
    {
      "Value": "eum",
      "StrippedValue": "soluta",
      "Description": "Intuitive eco-centric artificial intelligence"
    }
  ],
  "Description": "Devolved regional time-frame",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "quo",
      "StrippedValue": "voluptatum",
      "Description": "Phased optimizing database"
    },
    {
      "Value": "quo",
      "StrippedValue": "voluptatum",
      "Description": "Phased optimizing database"
    }
  ],
  "Faxes": [
    {
      "Value": "labore",
      "StrippedValue": "enim",
      "Description": "Diverse asynchronous help-desk"
    },
    {
      "Value": "labore",
      "StrippedValue": "enim",
      "Description": "Diverse asynchronous help-desk"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "est",
      "Description": "Cloned empowering archive"
    },
    {
      "Value": "quisquam",
      "StrippedValue": "est",
      "Description": "Cloned empowering archive"
    }
  ],
  "OfficePhones": [
    {
      "Value": "nobis",
      "StrippedValue": "aut",
      "Description": "Configurable mobile superstructure"
    },
    {
      "Value": "nobis",
      "StrippedValue": "aut",
      "Description": "Configurable mobile superstructure"
    }
  ],
  "OtherPhones": [
    {
      "Value": "inventore",
      "StrippedValue": "consequatur",
      "Description": "Front-line zero defect hub"
    },
    {
      "Value": "inventore",
      "StrippedValue": "consequatur",
      "Description": "Front-line zero defect hub"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 442,
      "Name": "Kautzer, Skiles and Murazik",
      "ToolTip": "Id quod ut eos corporis occaecati esse.",
      "Deleted": false,
      "Rank": 461,
      "Type": "est",
      "ColorBlock": 70,
      "IconHint": "voluptatibus",
      "Selected": false,
      "LastChanged": "2005-05-05T04:22:27.1122473+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "corporis",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Justice Rice"
    }
  ],
  "PersonNumber": "927108",
  "FullName": "Virginia Russel",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "explicabo",
      "StrippedValue": "aut",
      "Description": "Business-focused cohesive data-warehouse"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "aut",
      "Description": "Business-focused cohesive data-warehouse"
    }
  ],
  "FormalName": "Sipes Group",
  "Address": null,
  "Post3": "qui",
  "Post2": "quasi",
  "Post1": "sit",
  "Kanalname": "non",
  "Kanafname": "enim",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "labore",
  "ActiveInterests": 563,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 443,
  "DbiKey": "qui",
  "DbiLastModified": "2012-06-12T04:22:27.1278731+02:00",
  "DbiLastSyncronized": "2020-12-01T04:22:27.1278731+01:00",
  "SentInfo": 382,
  "ShowContactTickets": 75,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "saepe",
      "StrippedValue": "ex",
      "Description": "Enhanced interactive conglomeration"
    },
    {
      "Value": "saepe",
      "StrippedValue": "ex",
      "Description": "Enhanced interactive conglomeration"
    }
  ],
  "InternetPhones": [
    {
      "Value": "fuga",
      "StrippedValue": "voluptatem",
      "Description": "Phased client-driven hardware"
    },
    {
      "Value": "fuga",
      "StrippedValue": "voluptatem",
      "Description": "Phased client-driven hardware"
    }
  ],
  "Source": 132,
  "ActiveErpLinks": 256,
  "ShipmentTypes": [
    {
      "Id": 321,
      "Name": "Pouros, Hermann and Olson",
      "ToolTip": "Dolores quos.",
      "Deleted": false,
      "Rank": 592,
      "Type": "nostrum",
      "ColorBlock": 343,
      "IconHint": "numquam",
      "Selected": false,
      "LastChanged": "1999-06-10T04:22:27.1278731+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Ms. Dylan Stokes II"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 852,
      "Comment": "rerum",
      "Registered": "2012-04-29T04:22:27.1278731+02:00",
      "RegisteredAssociateId": 117,
      "Updated": "2004-04-18T04:22:27.1278731+02:00",
      "UpdatedAssociateId": 649,
      "LegalBaseId": 403,
      "LegalBaseKey": "consequatur",
      "LegalBaseName": "Wuckert, Rohan and Brakus",
      "ConsentPurposeId": 285,
      "ConsentPurposeKey": "vel",
      "ConsentPurposeName": "Lind Inc and Sons",
      "ConsentSourceId": 999,
      "ConsentSourceKey": "quae",
      "ConsentSourceName": "Borer LLC"
    }
  ],
  "BounceEmails": [
    "rosalee_dooley@dietrichgraham.ca",
    "polly@lakin.name"
  ],
  "ActiveStatusMonitorId": 135,
  "CreatedByFormId": 364,
  "UserDefinedFields": {
    "SuperOffice:1": "Millie Kreiger",
    "SuperOffice:2": "Cathrine Hilll"
  },
  "ExtraFields": {
    "ExtraFields1": "laudantium",
    "ExtraFields2": "culpa"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "voluptas"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 610,
  "Firstname": "Ivory",
  "MiddleName": "Quigley-Okuneva",
  "Lastname": "Schaefer",
  "Mrmrs": "et",
  "Title": "veniam",
  "UpdatedDate": "2014-06-30T04:22:27.1278731+02:00",
  "CreatedDate": "2015-11-29T04:22:27.1278731+01:00",
  "BirthDate": "1997-02-10T04:22:27.1278731+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "vel",
      "StrippedValue": "nihil",
      "Description": "Organized 6th generation protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 781
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "nihil",
      "Description": "Organized 6th generation protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 781
        }
      }
    }
  ],
  "Description": "Re-engineered modular array",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "at",
      "StrippedValue": "fugiat",
      "Description": "Multi-channelled dedicated hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 76
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "fugiat",
      "Description": "Multi-channelled dedicated hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 76
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Reverse-engineered hybrid throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 334
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Reverse-engineered hybrid throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 334
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "ex",
      "StrippedValue": "autem",
      "Description": "Versatile impactful capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "autem",
      "Description": "Versatile impactful capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "eos",
      "StrippedValue": "vitae",
      "Description": "Virtual background instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "vitae",
      "Description": "Virtual background instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "aperiam",
      "StrippedValue": "doloribus",
      "Description": "User-centric context-sensitive model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 263
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "doloribus",
      "Description": "User-centric context-sensitive model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 263
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
      "Id": 973,
      "Name": "Hilpert-Nader",
      "ToolTip": "Voluptatem doloremque et voluptatem aliquam.",
      "Deleted": true,
      "Rank": 254,
      "Type": "omnis",
      "ColorBlock": 456,
      "IconHint": "doloribus",
      "Selected": false,
      "LastChanged": "2024-05-17T04:22:27.1434967+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quasi",
      "StyleHint": "consectetur",
      "Hidden": true,
      "FullName": "Justine Nikolaus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 510
        }
      }
    }
  ],
  "PersonNumber": "1188756",
  "FullName": "Doyle Pollich I",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "minima",
      "StrippedValue": "quis",
      "Description": "Function-based web-enabled knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 787
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "quis",
      "Description": "Function-based web-enabled knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 787
        }
      }
    }
  ],
  "FormalName": "Casper, O'Keefe and McClure",
  "Address": null,
  "Post3": "dolorum",
  "Post2": "numquam",
  "Post1": "nihil",
  "Kanalname": "quo",
  "Kanafname": "ut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "architecto",
  "ActiveInterests": 696,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 974,
  "DbiKey": "consequatur",
  "DbiLastModified": "1998-02-23T04:22:27.1434967+01:00",
  "DbiLastSyncronized": "2001-01-22T04:22:27.1434967+01:00",
  "SentInfo": 486,
  "ShowContactTickets": 553,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sunt",
      "StrippedValue": "et",
      "Description": "Visionary clear-thinking system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "et",
      "Description": "Visionary clear-thinking system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sed",
      "StrippedValue": "sit",
      "Description": "User-centric 24 hour attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "sit",
      "Description": "User-centric 24 hour attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    }
  ],
  "Source": 559,
  "ActiveErpLinks": 570,
  "ShipmentTypes": [
    {
      "Id": 871,
      "Name": "Erdman-Zulauf",
      "ToolTip": "Provident possimus dolore autem.",
      "Deleted": false,
      "Rank": 275,
      "Type": "repellendus",
      "ColorBlock": 533,
      "IconHint": "nulla",
      "Selected": true,
      "LastChanged": "2013-02-24T04:22:27.1434967+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Rashawn Balistreri",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 119
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 488,
      "Comment": "et",
      "Registered": "2016-12-26T04:22:27.1434967+01:00",
      "RegisteredAssociateId": 554,
      "Updated": "2012-02-05T04:22:27.1434967+01:00",
      "UpdatedAssociateId": 538,
      "LegalBaseId": 689,
      "LegalBaseKey": "esse",
      "LegalBaseName": "Ortiz, Nolan and Parker",
      "ConsentPurposeId": 416,
      "ConsentPurposeKey": "possimus",
      "ConsentPurposeName": "Cassin-Kemmer",
      "ConsentSourceId": 932,
      "ConsentSourceKey": "qui",
      "ConsentSourceName": "Bechtelar-Gulgowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 591
        }
      }
    }
  ],
  "BounceEmails": [
    "georgette@raynor.co.uk",
    "jada@ryan.info"
  ],
  "ActiveStatusMonitorId": 872,
  "CreatedByFormId": 388,
  "UserDefinedFields": {
    "SuperOffice:1": "Helga Runolfsson",
    "SuperOffice:2": "1800377106"
  },
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "iste"
  },
  "CustomFields": {
    "CustomFields1": "molestiae",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 826
    }
  }
}
```