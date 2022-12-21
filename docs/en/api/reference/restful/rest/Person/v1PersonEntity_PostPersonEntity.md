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
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 984,
  "Firstname": "Tanner",
  "MiddleName": "Corkery Group",
  "Lastname": "Kuvalis",
  "Mrmrs": "reprehenderit",
  "Title": "a",
  "UpdatedDate": "2012-12-21T02:49:51.0109136+01:00",
  "CreatedDate": "2015-02-11T02:49:51.0109136+01:00",
  "BirthDate": "2006-09-27T02:49:51.0109136+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolores",
      "StrippedValue": "quisquam",
      "Description": "Face to face non-volatile synergy"
    },
    {
      "Value": "dolores",
      "StrippedValue": "quisquam",
      "Description": "Face to face non-volatile synergy"
    }
  ],
  "Description": "Streamlined 6th generation extranet",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "suscipit",
      "StrippedValue": "ex",
      "Description": "Reactive actuating strategy"
    },
    {
      "Value": "suscipit",
      "StrippedValue": "ex",
      "Description": "Reactive actuating strategy"
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "enim",
      "Description": "De-engineered needs-based complexity"
    },
    {
      "Value": "rerum",
      "StrippedValue": "enim",
      "Description": "De-engineered needs-based complexity"
    }
  ],
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "dolorem",
      "Description": "Cross-group heuristic alliance"
    },
    {
      "Value": "aut",
      "StrippedValue": "dolorem",
      "Description": "Cross-group heuristic alliance"
    }
  ],
  "OfficePhones": [
    {
      "Value": "iste",
      "StrippedValue": "et",
      "Description": "Versatile tertiary middleware"
    },
    {
      "Value": "iste",
      "StrippedValue": "et",
      "Description": "Versatile tertiary middleware"
    }
  ],
  "OtherPhones": [
    {
      "Value": "autem",
      "StrippedValue": "ipsa",
      "Description": "Universal explicit approach"
    },
    {
      "Value": "autem",
      "StrippedValue": "ipsa",
      "Description": "Universal explicit approach"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 595,
      "Name": "Leannon, Quigley and Becker",
      "ToolTip": "Eos et tempora sunt aut magni.",
      "Deleted": false,
      "Rank": 66,
      "Type": "et",
      "ColorBlock": 519,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "2019-05-20T02:49:51.0109136+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "excepturi",
      "Hidden": true,
      "FullName": "Miss Neil Ryan Willms PhD"
    }
  ],
  "PersonNumber": "983472",
  "FullName": "Mrs. Alfreda Lebsack V",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "cumque",
      "StrippedValue": "temporibus",
      "Description": "Fully-configurable 24 hour core"
    },
    {
      "Value": "cumque",
      "StrippedValue": "temporibus",
      "Description": "Fully-configurable 24 hour core"
    }
  ],
  "FormalName": "Brakus, Simonis and West",
  "Address": null,
  "Post3": "quia",
  "Post2": "distinctio",
  "Post1": "explicabo",
  "Kanalname": "veniam",
  "Kanafname": "numquam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eos",
  "ActiveInterests": 314,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 906,
  "DbiKey": "ipsum",
  "DbiLastModified": "2003-01-19T02:49:51.0265388+01:00",
  "DbiLastSyncronized": "2001-08-04T02:49:51.0265388+02:00",
  "SentInfo": 968,
  "ShowContactTickets": 930,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eaque",
      "StrippedValue": "quia",
      "Description": "Realigned disintermediate moderator"
    },
    {
      "Value": "eaque",
      "StrippedValue": "quia",
      "Description": "Realigned disintermediate moderator"
    }
  ],
  "InternetPhones": [
    {
      "Value": "neque",
      "StrippedValue": "aliquam",
      "Description": "Ameliorated tertiary methodology"
    },
    {
      "Value": "neque",
      "StrippedValue": "aliquam",
      "Description": "Ameliorated tertiary methodology"
    }
  ],
  "Source": 374,
  "ActiveErpLinks": 529,
  "ShipmentTypes": [
    {
      "Id": 657,
      "Name": "Wisozk-Frami",
      "ToolTip": "Ratione rem autem.",
      "Deleted": false,
      "Rank": 124,
      "Type": "expedita",
      "ColorBlock": 285,
      "IconHint": "velit",
      "Selected": false,
      "LastChanged": "2010-08-13T02:49:51.0265388+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Garrett Gottlieb"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 726,
      "Comment": "fuga",
      "Registered": "2005-01-16T02:49:51.0265388+01:00",
      "RegisteredAssociateId": 547,
      "Updated": "2000-08-25T02:49:51.0265388+02:00",
      "UpdatedAssociateId": 731,
      "LegalBaseId": 618,
      "LegalBaseKey": "inventore",
      "LegalBaseName": "Hand, Stracke and Considine",
      "ConsentPurposeId": 946,
      "ConsentPurposeKey": "incidunt",
      "ConsentPurposeName": "Batz Group",
      "ConsentSourceId": 698,
      "ConsentSourceKey": "voluptas",
      "ConsentSourceName": "Bayer Inc and Sons"
    }
  ],
  "BounceEmails": [
    "samir_crooks@cummerata.biz",
    "shyann_harris@maggio.name"
  ],
  "ActiveStatusMonitorId": 154,
  "UserDefinedFields": {
    "SuperOffice:1": "Rebeka Becker",
    "SuperOffice:2": "Adelia Willa Schroeder Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "eius",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "quia"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 429,
  "Firstname": "Adelle",
  "MiddleName": "Medhurst Group",
  "Lastname": "Kreiger",
  "Mrmrs": "ut",
  "Title": "eaque",
  "UpdatedDate": "2002-12-20T02:49:51.2296882+01:00",
  "CreatedDate": "2022-10-23T02:49:51.2296882+02:00",
  "BirthDate": "1996-07-23T02:49:51.2296882+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "error",
      "StrippedValue": "a",
      "Description": "Assimilated regional core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 302
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "a",
      "Description": "Assimilated regional core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 302
        }
      }
    }
  ],
  "Description": "Configurable object-oriented methodology",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "sed",
      "StrippedValue": "eos",
      "Description": "Organic discrete data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 717
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "eos",
      "Description": "Organic discrete data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 717
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "suscipit",
      "StrippedValue": "qui",
      "Description": "User-centric mobile benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "qui",
      "Description": "User-centric mobile benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "adipisci",
      "StrippedValue": "eos",
      "Description": "Progressive intermediate service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 565
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "eos",
      "Description": "Progressive intermediate service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 565
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "assumenda",
      "Description": "Profit-focused intangible policy",
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
      "Value": "consequatur",
      "StrippedValue": "assumenda",
      "Description": "Profit-focused intangible policy",
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
  "OtherPhones": [
    {
      "Value": "sed",
      "StrippedValue": "aliquid",
      "Description": "Synchronised transitional system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 740
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "aliquid",
      "Description": "Synchronised transitional system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 740
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
      "Id": 1000,
      "Name": "Moore-Grant",
      "ToolTip": "Aut consequatur voluptates.",
      "Deleted": false,
      "Rank": 786,
      "Type": "eum",
      "ColorBlock": 853,
      "IconHint": "cumque",
      "Selected": false,
      "LastChanged": "2021-01-21T02:49:51.2296882+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Dr. Roderick Jewess",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 469
        }
      }
    }
  ],
  "PersonNumber": "1094574",
  "FullName": "Ms. Duncan Marco Hettinger I",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "accusantium",
      "StrippedValue": "rerum",
      "Description": "Cross-platform full-range alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 40
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "rerum",
      "Description": "Cross-platform full-range alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 40
        }
      }
    }
  ],
  "FormalName": "Little, Cronin and Abbott",
  "Address": null,
  "Post3": "voluptatem",
  "Post2": "aut",
  "Post1": "optio",
  "Kanalname": "non",
  "Kanafname": "tenetur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "enim",
  "ActiveInterests": 786,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 868,
  "DbiKey": "sed",
  "DbiLastModified": "2021-05-18T02:49:51.2296882+02:00",
  "DbiLastSyncronized": "2002-01-20T02:49:51.2296882+01:00",
  "SentInfo": 299,
  "ShowContactTickets": 664,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "officiis",
      "StrippedValue": "accusamus",
      "Description": "Profound responsive implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 904
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "accusamus",
      "Description": "Profound responsive implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 904
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "iusto",
      "StrippedValue": "nihil",
      "Description": "Profound value-added product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 656
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "nihil",
      "Description": "Profound value-added product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 656
        }
      }
    }
  ],
  "Source": 306,
  "ActiveErpLinks": 443,
  "ShipmentTypes": [
    {
      "Id": 594,
      "Name": "Cartwright-Feeney",
      "ToolTip": "Eum sit voluptates sunt aspernatur.",
      "Deleted": false,
      "Rank": 830,
      "Type": "labore",
      "ColorBlock": 298,
      "IconHint": "velit",
      "Selected": true,
      "LastChanged": "2010-09-29T02:49:51.2296882+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "incidunt",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Jasen Francesca Marks PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 854
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 231,
      "Comment": "magni",
      "Registered": "2008-01-30T02:49:51.2296882+01:00",
      "RegisteredAssociateId": 627,
      "Updated": "2005-08-12T02:49:51.2296882+02:00",
      "UpdatedAssociateId": 177,
      "LegalBaseId": 863,
      "LegalBaseKey": "magnam",
      "LegalBaseName": "Boyle-Deckow",
      "ConsentPurposeId": 339,
      "ConsentPurposeKey": "in",
      "ConsentPurposeName": "Green, Waters and Reichel",
      "ConsentSourceId": 864,
      "ConsentSourceKey": "in",
      "ConsentSourceName": "Keeling Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    }
  ],
  "BounceEmails": [
    "andreanne.greenholt@watsicaroberts.us",
    "vada@abshirekrajcik.uk"
  ],
  "ActiveStatusMonitorId": 406,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "58265590"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "cupiditate"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "mollitia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 176
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```