---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
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

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 322,
  "Firstname": "Derek",
  "MiddleName": "Wilkinson-O'Conner",
  "Lastname": "Sawayn",
  "Mrmrs": "aut",
  "Title": "veritatis",
  "UpdatedDate": "2015-01-20T11:10:27.3434556+01:00",
  "CreatedDate": "2008-04-21T11:10:27.3434556+02:00",
  "BirthDate": "2011-09-02T11:10:27.3434556+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "vel",
      "StrippedValue": "quam",
      "Description": "User-friendly scalable utilisation"
    },
    {
      "Value": "vel",
      "StrippedValue": "quam",
      "Description": "User-friendly scalable utilisation"
    }
  ],
  "Description": "Organized high-level function",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "rem",
      "StrippedValue": "id",
      "Description": "Organized tangible budgetary management"
    },
    {
      "Value": "rem",
      "StrippedValue": "id",
      "Description": "Organized tangible budgetary management"
    }
  ],
  "Faxes": [
    {
      "Value": "illum",
      "StrippedValue": "voluptatem",
      "Description": "Realigned bi-directional productivity"
    },
    {
      "Value": "illum",
      "StrippedValue": "voluptatem",
      "Description": "Realigned bi-directional productivity"
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "amet",
      "Description": "Down-sized dynamic model"
    },
    {
      "Value": "et",
      "StrippedValue": "amet",
      "Description": "Down-sized dynamic model"
    }
  ],
  "OfficePhones": [
    {
      "Value": "in",
      "StrippedValue": "commodi",
      "Description": "Diverse eco-centric paradigm"
    },
    {
      "Value": "in",
      "StrippedValue": "commodi",
      "Description": "Diverse eco-centric paradigm"
    }
  ],
  "OtherPhones": [
    {
      "Value": "dolor",
      "StrippedValue": "illo",
      "Description": "Progressive bi-directional local area network"
    },
    {
      "Value": "dolor",
      "StrippedValue": "illo",
      "Description": "Progressive bi-directional local area network"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 376,
      "Name": "Gislason Inc and Sons",
      "ToolTip": "Laboriosam commodi similique labore tenetur nam.",
      "Deleted": false,
      "Rank": 69,
      "Type": "ea",
      "ColorBlock": 142,
      "IconHint": "incidunt",
      "Selected": true,
      "LastChanged": "1998-09-22T11:10:27.3464528+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ullam",
      "StyleHint": "facilis",
      "Hidden": false,
      "FullName": "Cielo Christiansen"
    }
  ],
  "PersonNumber": "1290737",
  "FullName": "Dr. Lawrence Cooper Kiehn Sr.",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "vero",
      "StrippedValue": "nisi",
      "Description": "Triple-buffered static system engine"
    },
    {
      "Value": "vero",
      "StrippedValue": "nisi",
      "Description": "Triple-buffered static system engine"
    }
  ],
  "FormalName": "Dickinson LLC",
  "Address": null,
  "Post3": "voluptas",
  "Post2": "suscipit",
  "Post1": "doloremque",
  "Kanalname": "odit",
  "Kanafname": "vitae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptatibus",
  "ActiveInterests": 828,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 402,
  "DbiKey": "id",
  "DbiLastModified": "1996-10-03T11:10:27.3484524+02:00",
  "DbiLastSyncronized": "2008-03-16T11:10:27.3484524+01:00",
  "SentInfo": 920,
  "ShowContactTickets": 831,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "neque",
      "StrippedValue": "blanditiis",
      "Description": "Team-oriented tertiary algorithm"
    },
    {
      "Value": "neque",
      "StrippedValue": "blanditiis",
      "Description": "Team-oriented tertiary algorithm"
    }
  ],
  "InternetPhones": [
    {
      "Value": "maxime",
      "StrippedValue": "veniam",
      "Description": "Progressive user-facing orchestration"
    },
    {
      "Value": "maxime",
      "StrippedValue": "veniam",
      "Description": "Progressive user-facing orchestration"
    }
  ],
  "Source": 820,
  "ActiveErpLinks": 296,
  "ShipmentTypes": [
    {
      "Id": 1001,
      "Name": "Wilderman-Murray",
      "ToolTip": "Ea culpa.",
      "Deleted": true,
      "Rank": 643,
      "Type": "error",
      "ColorBlock": 836,
      "IconHint": "ex",
      "Selected": false,
      "LastChanged": "2015-04-17T11:10:27.3494523+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quas",
      "StyleHint": "nihil",
      "Hidden": false,
      "FullName": "Madie Legros"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 948,
      "Comment": "quas",
      "Registered": "2002-12-29T11:10:27.3494523+01:00",
      "RegisteredAssociateId": 530,
      "Updated": "2002-01-25T11:10:27.3494523+01:00",
      "UpdatedAssociateId": 896,
      "LegalBaseId": 899,
      "LegalBaseKey": "ipsum",
      "LegalBaseName": "Hermann Group",
      "ConsentPurposeId": 40,
      "ConsentPurposeKey": "dolorem",
      "ConsentPurposeName": "Abbott, Ortiz and Baumbach",
      "ConsentSourceId": 36,
      "ConsentSourceKey": "quos",
      "ConsentSourceName": "Volkman Group"
    }
  ],
  "BounceEmails": [
    "yessenia@johns.name",
    "pietro_morissette@rutherfordmante.info"
  ],
  "ActiveStatusMonitorId": 184,
  "UserDefinedFields": {
    "SuperOffice:1": "Jennings Hassie Farrell DVM",
    "SuperOffice:2": "233443606"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "deleniti"
  },
  "CustomFields": {
    "CustomFields1": "quae",
    "CustomFields2": "repudiandae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 740,
  "Firstname": "Greg",
  "MiddleName": "Funk LLC",
  "Lastname": "Murray",
  "Mrmrs": "nisi",
  "Title": "molestias",
  "UpdatedDate": "2003-03-20T11:10:27.3574537+01:00",
  "CreatedDate": "2006-12-06T11:10:27.3574537+01:00",
  "BirthDate": "2014-04-04T11:10:27.3574537+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "officia",
      "StrippedValue": "aliquam",
      "Description": "Balanced secondary core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 378
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "aliquam",
      "Description": "Balanced secondary core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 378
        }
      }
    }
  ],
  "Description": "Cloned methodical Graphic Interface",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dolores",
      "StrippedValue": "assumenda",
      "Description": "Horizontal needs-based Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 65
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "assumenda",
      "Description": "Horizontal needs-based Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 65
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "facere",
      "StrippedValue": "nihil",
      "Description": "Progressive client-server emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 312
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "nihil",
      "Description": "Progressive client-server emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 312
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "officia",
      "StrippedValue": "et",
      "Description": "Cloned multimedia function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 420
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "et",
      "Description": "Cloned multimedia function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 420
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "corporis",
      "StrippedValue": "officia",
      "Description": "Streamlined user-facing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 846
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "officia",
      "Description": "Streamlined user-facing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 846
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "reiciendis",
      "StrippedValue": "fuga",
      "Description": "Up-sized heuristic system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "fuga",
      "Description": "Up-sized heuristic system engine",
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
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 383,
      "Name": "Bahringer-Rice",
      "ToolTip": "Aliquid maiores.",
      "Deleted": false,
      "Rank": 266,
      "Type": "aut",
      "ColorBlock": 700,
      "IconHint": "perferendis",
      "Selected": true,
      "LastChanged": "2011-04-18T11:10:27.359464+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laboriosam",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Maye Stroman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 81
        }
      }
    }
  ],
  "PersonNumber": "618108",
  "FullName": "Lenna Dietrich",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "eius",
      "StrippedValue": "accusantium",
      "Description": "Horizontal content-based matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 193
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "accusantium",
      "Description": "Horizontal content-based matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 193
        }
      }
    }
  ],
  "FormalName": "Waelchi, Gerhold and Bahringer",
  "Address": null,
  "Post3": "voluptatem",
  "Post2": "a",
  "Post1": "ut",
  "Kanalname": "quibusdam",
  "Kanafname": "perspiciatis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quo",
  "ActiveInterests": 950,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 666,
  "DbiKey": "nihil",
  "DbiLastModified": "2008-08-05T11:10:27.3624527+02:00",
  "DbiLastSyncronized": "2010-10-14T11:10:27.3624527+02:00",
  "SentInfo": 886,
  "ShowContactTickets": 665,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quia",
      "StrippedValue": "quia",
      "Description": "Front-line upward-trending superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 431
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "quia",
      "Description": "Front-line upward-trending superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 431
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "distinctio",
      "StrippedValue": "incidunt",
      "Description": "Innovative multi-tasking system engine",
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
      "Value": "distinctio",
      "StrippedValue": "incidunt",
      "Description": "Innovative multi-tasking system engine",
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
  "Source": 228,
  "ActiveErpLinks": 832,
  "ShipmentTypes": [
    {
      "Id": 1000,
      "Name": "Smitham Group",
      "ToolTip": "Eligendi odit vitae ut dolor non.",
      "Deleted": false,
      "Rank": 712,
      "Type": "fugit",
      "ColorBlock": 195,
      "IconHint": "qui",
      "Selected": false,
      "LastChanged": "2011-09-16T11:10:27.3634526+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "excepturi",
      "StyleHint": "ab",
      "Hidden": false,
      "FullName": "Karson Grimes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 850
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 293,
      "Comment": "nulla",
      "Registered": "2010-07-18T11:10:27.3634526+02:00",
      "RegisteredAssociateId": 940,
      "Updated": "2021-11-01T11:10:27.3634526+01:00",
      "UpdatedAssociateId": 440,
      "LegalBaseId": 91,
      "LegalBaseKey": "fugit",
      "LegalBaseName": "Kilback Inc and Sons",
      "ConsentPurposeId": 386,
      "ConsentPurposeKey": "animi",
      "ConsentPurposeName": "Bogan-Krajcik",
      "ConsentSourceId": 208,
      "ConsentSourceKey": "eligendi",
      "ConsentSourceName": "Lind Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 579
        }
      }
    }
  ],
  "BounceEmails": [
    "dereck_von@fisherkrajcik.uk",
    "jakayla@breitenberg.co.uk"
  ],
  "ActiveStatusMonitorId": 316,
  "UserDefinedFields": {
    "SuperOffice:1": "591101276",
    "SuperOffice:2": "1266890579"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "aliquid"
  },
  "CustomFields": {
    "CustomFields1": "adipisci",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 875
    }
  }
}
```