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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 384,
  "Firstname": "Keaton",
  "MiddleName": "Kris, Stokes and Fahey",
  "Lastname": "Langworth",
  "Mrmrs": "eveniet",
  "Title": "eum",
  "UpdatedDate": "2014-02-20T17:37:38.8518691+01:00",
  "CreatedDate": "2020-12-04T17:37:38.8518691+01:00",
  "BirthDate": "2021-05-27T17:37:38.8518691+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "non",
      "StrippedValue": "consequuntur",
      "Description": "Decentralized grid-enabled portal"
    },
    {
      "Value": "non",
      "StrippedValue": "consequuntur",
      "Description": "Decentralized grid-enabled portal"
    }
  ],
  "Description": "Advanced 24/7 synergy",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "praesentium",
      "StrippedValue": "assumenda",
      "Description": "Exclusive user-facing analyzer"
    },
    {
      "Value": "praesentium",
      "StrippedValue": "assumenda",
      "Description": "Exclusive user-facing analyzer"
    }
  ],
  "Faxes": [
    {
      "Value": "deserunt",
      "StrippedValue": "animi",
      "Description": "Organized assymetric collaboration"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "animi",
      "Description": "Organized assymetric collaboration"
    }
  ],
  "MobilePhones": [
    {
      "Value": "adipisci",
      "StrippedValue": "quis",
      "Description": "Ergonomic analyzing leverage"
    },
    {
      "Value": "adipisci",
      "StrippedValue": "quis",
      "Description": "Ergonomic analyzing leverage"
    }
  ],
  "OfficePhones": [
    {
      "Value": "deserunt",
      "StrippedValue": "tempore",
      "Description": "Automated assymetric product"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "tempore",
      "Description": "Automated assymetric product"
    }
  ],
  "OtherPhones": [
    {
      "Value": "quos",
      "StrippedValue": "nihil",
      "Description": "Reduced maximized matrices"
    },
    {
      "Value": "quos",
      "StrippedValue": "nihil",
      "Description": "Reduced maximized matrices"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 110,
      "Name": "Bartell, Jenkins and Cremin",
      "ToolTip": "Modi consequuntur sequi dolorem iure sint aut iusto.",
      "Deleted": false,
      "Rank": 168,
      "Type": "ratione",
      "ColorBlock": 799,
      "IconHint": "inventore",
      "Selected": false,
      "LastChanged": "2014-01-27T17:37:38.853861+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "id",
      "StyleHint": "neque",
      "Hidden": false,
      "FullName": "Mr. Paige Smitham"
    }
  ],
  "PersonNumber": "1157949",
  "FullName": "Mr. Lizeth Susan Dicki",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "ipsam",
      "StrippedValue": "inventore",
      "Description": "Multi-channelled incremental service-desk"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "inventore",
      "Description": "Multi-channelled incremental service-desk"
    }
  ],
  "FormalName": "Herman Inc and Sons",
  "Address": null,
  "Post3": "ipsam",
  "Post2": "odit",
  "Post1": "nisi",
  "Kanalname": "numquam",
  "Kanafname": "totam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sed",
  "ActiveInterests": 608,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 33,
  "DbiKey": "a",
  "DbiLastModified": "2019-08-21T17:37:38.8588296+02:00",
  "DbiLastSyncronized": "2008-04-19T17:37:38.8588296+02:00",
  "SentInfo": 270,
  "ShowContactTickets": 565,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "rem",
      "StrippedValue": "impedit",
      "Description": "Optimized methodical product"
    },
    {
      "Value": "rem",
      "StrippedValue": "impedit",
      "Description": "Optimized methodical product"
    }
  ],
  "InternetPhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "nisi",
      "Description": "Distributed object-oriented ability"
    },
    {
      "Value": "dolorem",
      "StrippedValue": "nisi",
      "Description": "Distributed object-oriented ability"
    }
  ],
  "Source": 626,
  "ActiveErpLinks": 517,
  "ShipmentTypes": [
    {
      "Id": 914,
      "Name": "Dibbert-Connelly",
      "ToolTip": "Et sapiente voluptatem velit id.",
      "Deleted": true,
      "Rank": 727,
      "Type": "qui",
      "ColorBlock": 806,
      "IconHint": "consequatur",
      "Selected": true,
      "LastChanged": "1998-01-28T17:37:38.8588296+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsam",
      "StyleHint": "explicabo",
      "Hidden": false,
      "FullName": "Dr. Audrey Cassandre Reilly V"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 39,
      "Comment": "omnis",
      "Registered": "2021-08-26T17:37:38.8588296+02:00",
      "RegisteredAssociateId": 125,
      "Updated": "2017-06-28T17:37:38.8588296+02:00",
      "UpdatedAssociateId": 262,
      "LegalBaseId": 495,
      "LegalBaseKey": "porro",
      "LegalBaseName": "Homenick LLC",
      "ConsentPurposeId": 975,
      "ConsentPurposeKey": "aut",
      "ConsentPurposeName": "Altenwerth Group",
      "ConsentSourceId": 328,
      "ConsentSourceKey": "delectus",
      "ConsentSourceName": "Nader-O'Hara"
    }
  ],
  "BounceEmails": [
    "waylon@hirtheledner.name",
    "myrl_simonis@monahan.us"
  ],
  "ActiveStatusMonitorId": 694,
  "UserDefinedFields": {
    "SuperOffice:1": "Anahi Douglas IV",
    "SuperOffice:2": "1943191868"
  },
  "ExtraFields": {
    "ExtraFields1": "unde",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "ad",
    "CustomFields2": "voluptatibus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 216,
  "Firstname": "Terrell",
  "MiddleName": "Beatty, Becker and Rodriguez",
  "Lastname": "Lynch",
  "Mrmrs": "quod",
  "Title": "quidem",
  "UpdatedDate": "2002-03-16T17:37:38.8668315+01:00",
  "CreatedDate": "2001-01-06T17:37:38.8668315+01:00",
  "BirthDate": "2005-02-15T17:37:38.8668315+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "non",
      "StrippedValue": "beatae",
      "Description": "Balanced asynchronous monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 969
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "beatae",
      "Description": "Balanced asynchronous monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 969
        }
      }
    }
  ],
  "Description": "Innovative actuating process improvement",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "sint",
      "StrippedValue": "sed",
      "Description": "Balanced zero administration hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 739
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "sed",
      "Description": "Balanced zero administration hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 739
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nam",
      "StrippedValue": "voluptate",
      "Description": "Reactive empowering throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "voluptate",
      "Description": "Reactive empowering throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "minus",
      "StrippedValue": "sint",
      "Description": "Seamless encompassing application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 470
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "sint",
      "Description": "Seamless encompassing application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 470
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "enim",
      "Description": "Horizontal zero defect matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 307
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "enim",
      "Description": "Horizontal zero defect matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 307
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quia",
      "StrippedValue": "ratione",
      "Description": "Organized incremental secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 655
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "ratione",
      "Description": "Organized incremental secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 655
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
      "Id": 177,
      "Name": "Kiehn, Sauer and Goodwin",
      "ToolTip": "Facere praesentium laboriosam sapiente voluptas.",
      "Deleted": false,
      "Rank": 21,
      "Type": "eum",
      "ColorBlock": 951,
      "IconHint": "iste",
      "Selected": false,
      "LastChanged": "2003-05-17T17:37:38.8698656+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ad",
      "StyleHint": "dicta",
      "Hidden": false,
      "FullName": "Caroline Hettinger V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    }
  ],
  "PersonNumber": "1864983",
  "FullName": "Clifford Hamill",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "iste",
      "StrippedValue": "velit",
      "Description": "Virtual discrete model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 271
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "velit",
      "Description": "Virtual discrete model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 271
        }
      }
    }
  ],
  "FormalName": "Doyle Inc and Sons",
  "Address": null,
  "Post3": "et",
  "Post2": "et",
  "Post1": "voluptas",
  "Kanalname": "maiores",
  "Kanafname": "id",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 853,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 875,
  "DbiKey": "consequatur",
  "DbiLastModified": "2019-05-09T17:37:38.8718648+02:00",
  "DbiLastSyncronized": "2019-10-30T17:37:38.8718648+01:00",
  "SentInfo": 131,
  "ShowContactTickets": 27,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "fugit",
      "StrippedValue": "animi",
      "Description": "Streamlined zero tolerance framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 15
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "animi",
      "Description": "Streamlined zero tolerance framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 15
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Multi-lateral demand-driven methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 208
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Multi-lateral demand-driven methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 208
        }
      }
    }
  ],
  "Source": 187,
  "ActiveErpLinks": 658,
  "ShipmentTypes": [
    {
      "Id": 456,
      "Name": "Zieme Group",
      "ToolTip": "Aut nobis illo corrupti.",
      "Deleted": false,
      "Rank": 768,
      "Type": "ipsam",
      "ColorBlock": 755,
      "IconHint": "temporibus",
      "Selected": true,
      "LastChanged": "2015-11-29T17:37:38.8738658+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "quis",
      "Hidden": false,
      "FullName": "Effie Bernhard",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 766
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 384,
      "Comment": "nihil",
      "Registered": "2020-07-26T17:37:38.8738658+02:00",
      "RegisteredAssociateId": 912,
      "Updated": "2018-09-16T17:37:38.8738658+02:00",
      "UpdatedAssociateId": 428,
      "LegalBaseId": 892,
      "LegalBaseKey": "pariatur",
      "LegalBaseName": "Monahan, Brown and O'Kon",
      "ConsentPurposeId": 142,
      "ConsentPurposeKey": "nesciunt",
      "ConsentPurposeName": "Beahan-Jacobson",
      "ConsentSourceId": 168,
      "ConsentSourceKey": "similique",
      "ConsentSourceName": "Koch-Schmidt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    }
  ],
  "BounceEmails": [
    "davonte_zulauf@dickens.co.uk",
    "genevieve_jacobs@reynolds.name"
  ],
  "ActiveStatusMonitorId": 840,
  "UserDefinedFields": {
    "SuperOffice:1": "2052183804",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "excepturi",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "commodi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 456
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```