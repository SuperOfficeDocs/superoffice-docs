---
title: POST Person
uid: v1PersonEntity_PostPersonEntity
generated: true
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 48,
  "Firstname": "Levi",
  "MiddleName": "Kris, Schroeder and Braun",
  "Lastname": "Gerhold",
  "Mrmrs": "nesciunt",
  "Title": "sed",
  "UpdatedDate": "2022-08-25T16:00:48.0084441+02:00",
  "CreatedDate": "2011-03-27T16:00:48.0084441+02:00",
  "BirthDate": "2012-04-14T16:00:48.0084441+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "aut",
      "Description": "Open-source 5th generation throughput"
    },
    {
      "Value": "est",
      "StrippedValue": "aut",
      "Description": "Open-source 5th generation throughput"
    }
  ],
  "Description": "Switchable local matrix",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ad",
      "StrippedValue": "sint",
      "Description": "Reverse-engineered demand-driven extranet"
    },
    {
      "Value": "ad",
      "StrippedValue": "sint",
      "Description": "Reverse-engineered demand-driven extranet"
    }
  ],
  "Faxes": [
    {
      "Value": "quos",
      "StrippedValue": "et",
      "Description": "Object-based systematic projection"
    },
    {
      "Value": "quos",
      "StrippedValue": "et",
      "Description": "Object-based systematic projection"
    }
  ],
  "MobilePhones": [
    {
      "Value": "non",
      "StrippedValue": "quisquam",
      "Description": "Intuitive fresh-thinking projection"
    },
    {
      "Value": "non",
      "StrippedValue": "quisquam",
      "Description": "Intuitive fresh-thinking projection"
    }
  ],
  "OfficePhones": [
    {
      "Value": "accusantium",
      "StrippedValue": "perferendis",
      "Description": "Realigned full-range open system"
    },
    {
      "Value": "accusantium",
      "StrippedValue": "perferendis",
      "Description": "Realigned full-range open system"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ab",
      "StrippedValue": "perspiciatis",
      "Description": "User-friendly leading edge initiative"
    },
    {
      "Value": "ab",
      "StrippedValue": "perspiciatis",
      "Description": "User-friendly leading edge initiative"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 8,
      "Name": "Cronin-Kuhic",
      "ToolTip": "Neque consequatur sint eum aut consequatur animi.",
      "Deleted": false,
      "Rank": 865,
      "Type": "doloremque",
      "ColorBlock": 939,
      "IconHint": "dolorum",
      "Selected": true,
      "LastChanged": "2000-08-11T16:00:48.0084441+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "voluptate",
      "Hidden": false,
      "FullName": "Bernice Kassulke"
    }
  ],
  "PersonNumber": "1305894",
  "FullName": "Dr. Eleanora Norwood Leffler",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "molestiae",
      "Description": "Extended fresh-thinking challenge"
    },
    {
      "Value": "velit",
      "StrippedValue": "molestiae",
      "Description": "Extended fresh-thinking challenge"
    }
  ],
  "FormalName": "Swaniawski, Murphy and Reichert",
  "Address": null,
  "Post3": "libero",
  "Post2": "repellat",
  "Post1": "sit",
  "Kanalname": "eum",
  "Kanafname": "nemo",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ipsa",
  "ActiveInterests": 580,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 873,
  "DbiKey": "consequatur",
  "DbiLastModified": "2004-02-03T16:00:48.0084441+01:00",
  "DbiLastSyncronized": "1998-10-31T16:00:48.0084441+01:00",
  "SentInfo": 816,
  "ShowContactTickets": 998,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quia",
      "StrippedValue": "provident",
      "Description": "Upgradable composite encryption"
    },
    {
      "Value": "quia",
      "StrippedValue": "provident",
      "Description": "Upgradable composite encryption"
    }
  ],
  "InternetPhones": [
    {
      "Value": "cumque",
      "StrippedValue": "pariatur",
      "Description": "Down-sized optimizing algorithm"
    },
    {
      "Value": "cumque",
      "StrippedValue": "pariatur",
      "Description": "Down-sized optimizing algorithm"
    }
  ],
  "Source": 362,
  "ActiveErpLinks": 855,
  "ShipmentTypes": [
    {
      "Id": 928,
      "Name": "Reichel-Schamberger",
      "ToolTip": "Iusto ut.",
      "Deleted": true,
      "Rank": 113,
      "Type": "voluptas",
      "ColorBlock": 703,
      "IconHint": "eligendi",
      "Selected": false,
      "LastChanged": "2000-05-08T16:00:48.0084441+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Antonetta Batz"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 418,
      "Comment": "dolor",
      "Registered": "2012-05-25T16:00:48.0084441+02:00",
      "RegisteredAssociateId": 808,
      "Updated": "2001-03-18T16:00:48.0084441+01:00",
      "UpdatedAssociateId": 188,
      "LegalBaseId": 429,
      "LegalBaseKey": "aut",
      "LegalBaseName": "Huels Group",
      "ConsentPurposeId": 408,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Wisoky, Mitchell and Mertz",
      "ConsentSourceId": 389,
      "ConsentSourceKey": "facilis",
      "ConsentSourceName": "Ferry, Sporer and Howe"
    }
  ],
  "BounceEmails": [
    "elmira@tremblay.biz",
    "meagan.west@pfeffer.name"
  ],
  "ActiveStatusMonitorId": 101,
  "UserDefinedFields": {
    "SuperOffice:1": "Melyna Hills",
    "SuperOffice:2": "Mrs. Syble Gottlieb MD"
  },
  "ExtraFields": {
    "ExtraFields1": "inventore",
    "ExtraFields2": "maxime"
  },
  "CustomFields": {
    "CustomFields1": "expedita",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 317,
  "Firstname": "Virginia",
  "MiddleName": "Effertz Group",
  "Lastname": "Jenkins",
  "Mrmrs": "distinctio",
  "Title": "nemo",
  "UpdatedDate": "2018-07-09T16:00:48.0240688+02:00",
  "CreatedDate": "2001-08-01T16:00:48.0240688+02:00",
  "BirthDate": "2010-11-27T16:00:48.0240688+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptate",
      "StrippedValue": "labore",
      "Description": "Seamless eco-centric leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 716
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "labore",
      "Description": "Seamless eco-centric leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 716
        }
      }
    }
  ],
  "Description": "Horizontal motivating neural-net",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "ut",
      "Description": "User-centric intangible solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "ut",
      "Description": "User-centric intangible solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "libero",
      "StrippedValue": "enim",
      "Description": "Reduced exuding project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "enim",
      "Description": "Reduced exuding project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptates",
      "StrippedValue": "fugiat",
      "Description": "Versatile multi-tasking extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 448
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "fugiat",
      "Description": "Versatile multi-tasking extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 448
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aut",
      "StrippedValue": "maxime",
      "Description": "Adaptive transitional open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 86
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "maxime",
      "Description": "Adaptive transitional open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 86
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ut",
      "StrippedValue": "velit",
      "Description": "Universal clear-thinking adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "velit",
      "Description": "Universal clear-thinking adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
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
      "Id": 298,
      "Name": "Hintz-Collier",
      "ToolTip": "Nostrum non ratione.",
      "Deleted": false,
      "Rank": 259,
      "Type": "est",
      "ColorBlock": 92,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "1998-11-30T16:00:48.0240688+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "iure",
      "Hidden": true,
      "FullName": "Leonard Conner Kuhic II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 148
        }
      }
    }
  ],
  "PersonNumber": "1596090",
  "FullName": "Martina D'Amore",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "voluptatem",
      "Description": "Diverse multimedia challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "voluptatem",
      "Description": "Diverse multimedia challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    }
  ],
  "FormalName": "Terry Inc and Sons",
  "Address": null,
  "Post3": "voluptatum",
  "Post2": "est",
  "Post1": "aut",
  "Kanalname": "repellendus",
  "Kanafname": "veritatis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "atque",
  "ActiveInterests": 470,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 228,
  "DbiKey": "sapiente",
  "DbiLastModified": "2023-02-15T16:00:48.0240688+01:00",
  "DbiLastSyncronized": "2012-08-23T16:00:48.0240688+02:00",
  "SentInfo": 88,
  "ShowContactTickets": 754,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sunt",
      "StrippedValue": "fuga",
      "Description": "Versatile stable open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 568
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "fuga",
      "Description": "Versatile stable open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 568
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "cum",
      "Description": "Grass-roots logistical hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "cum",
      "Description": "Grass-roots logistical hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    }
  ],
  "Source": 604,
  "ActiveErpLinks": 517,
  "ShipmentTypes": [
    {
      "Id": 923,
      "Name": "Ritchie-Wolff",
      "ToolTip": "Similique aliquam necessitatibus minus.",
      "Deleted": true,
      "Rank": 105,
      "Type": "quibusdam",
      "ColorBlock": 596,
      "IconHint": "vel",
      "Selected": false,
      "LastChanged": "2002-08-24T16:00:48.0240688+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "dolor",
      "Hidden": false,
      "FullName": "Andreanne Klein",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 551
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 248,
      "Comment": "labore",
      "Registered": "2014-03-14T16:00:48.0240688+01:00",
      "RegisteredAssociateId": 374,
      "Updated": "1999-02-06T16:00:48.0240688+01:00",
      "UpdatedAssociateId": 107,
      "LegalBaseId": 797,
      "LegalBaseKey": "itaque",
      "LegalBaseName": "Berge LLC",
      "ConsentPurposeId": 563,
      "ConsentPurposeKey": "natus",
      "ConsentPurposeName": "O'Kon LLC",
      "ConsentSourceId": 792,
      "ConsentSourceKey": "numquam",
      "ConsentSourceName": "Bode Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 947
        }
      }
    }
  ],
  "BounceEmails": [
    "tressie@lubowitzschmeler.co.uk",
    "gino@smithamlehner.uk"
  ],
  "ActiveStatusMonitorId": 107,
  "UserDefinedFields": {
    "SuperOffice:1": "Lelah Connelly",
    "SuperOffice:2": "Tom Moen"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "veritatis"
  },
  "CustomFields": {
    "CustomFields1": "delectus",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 364
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```