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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 368,
  "Firstname": "Frederick",
  "MiddleName": "Nicolas Group",
  "Lastname": "O'Conner",
  "Mrmrs": "et",
  "Title": "rem",
  "UpdatedDate": "1997-08-09T12:15:27.0056349+02:00",
  "CreatedDate": "2004-03-05T12:15:27.0056349+01:00",
  "BirthDate": "2005-05-18T12:15:27.0056349+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "iusto",
      "StrippedValue": "sunt",
      "Description": "User-friendly high-level hierarchy"
    },
    {
      "Value": "iusto",
      "StrippedValue": "sunt",
      "Description": "User-friendly high-level hierarchy"
    }
  ],
  "Description": "Focused local utilisation",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "sed",
      "StrippedValue": "nesciunt",
      "Description": "Progressive well-modulated moderator"
    },
    {
      "Value": "sed",
      "StrippedValue": "nesciunt",
      "Description": "Progressive well-modulated moderator"
    }
  ],
  "Faxes": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "tempore",
      "Description": "Optimized disintermediate software"
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "tempore",
      "Description": "Optimized disintermediate software"
    }
  ],
  "MobilePhones": [
    {
      "Value": "magni",
      "StrippedValue": "maiores",
      "Description": "Function-based bandwidth-monitored help-desk"
    },
    {
      "Value": "magni",
      "StrippedValue": "maiores",
      "Description": "Function-based bandwidth-monitored help-desk"
    }
  ],
  "OfficePhones": [
    {
      "Value": "laborum",
      "StrippedValue": "eaque",
      "Description": "Mandatory clear-thinking product"
    },
    {
      "Value": "laborum",
      "StrippedValue": "eaque",
      "Description": "Mandatory clear-thinking product"
    }
  ],
  "OtherPhones": [
    {
      "Value": "alias",
      "StrippedValue": "neque",
      "Description": "Ameliorated contextually-based collaboration"
    },
    {
      "Value": "alias",
      "StrippedValue": "neque",
      "Description": "Ameliorated contextually-based collaboration"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 369,
      "Name": "Mohr-Kulas",
      "ToolTip": "Et et cupiditate iste autem repellat.",
      "Deleted": false,
      "Rank": 813,
      "Type": "et",
      "ColorBlock": 989,
      "IconHint": "minus",
      "Selected": false,
      "LastChanged": "2008-04-28T12:15:27.0086359+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatum",
      "StyleHint": "odit",
      "Hidden": false,
      "FullName": "Mrs. Oral Collins"
    }
  ],
  "PersonNumber": "997227",
  "FullName": "Dr. Kenyatta Mohr IV",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "delectus",
      "Description": "Switchable 24/7 contingency"
    },
    {
      "Value": "id",
      "StrippedValue": "delectus",
      "Description": "Switchable 24/7 contingency"
    }
  ],
  "FormalName": "Price Inc and Sons",
  "Address": null,
  "Post3": "placeat",
  "Post2": "dolorem",
  "Post1": "fugiat",
  "Kanalname": "consequatur",
  "Kanafname": "accusamus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quidem",
  "ActiveInterests": 202,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 895,
  "DbiKey": "rerum",
  "DbiLastModified": "2012-10-21T12:15:27.0106364+02:00",
  "DbiLastSyncronized": "2005-06-03T12:15:27.0106364+02:00",
  "SentInfo": 940,
  "ShowContactTickets": 637,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ratione",
      "StrippedValue": "voluptate",
      "Description": "Organized assymetric archive"
    },
    {
      "Value": "ratione",
      "StrippedValue": "voluptate",
      "Description": "Organized assymetric archive"
    }
  ],
  "InternetPhones": [
    {
      "Value": "quo",
      "StrippedValue": "qui",
      "Description": "De-engineered intermediate initiative"
    },
    {
      "Value": "quo",
      "StrippedValue": "qui",
      "Description": "De-engineered intermediate initiative"
    }
  ],
  "Source": 465,
  "ActiveErpLinks": 381,
  "ShipmentTypes": [
    {
      "Id": 341,
      "Name": "Stokes-Feeney",
      "ToolTip": "Aut laboriosam accusantium doloribus.",
      "Deleted": false,
      "Rank": 104,
      "Type": "necessitatibus",
      "ColorBlock": 563,
      "IconHint": "sed",
      "Selected": true,
      "LastChanged": "2007-05-10T12:15:27.0116349+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "assumenda",
      "StyleHint": "fugiat",
      "Hidden": true,
      "FullName": "Garett Susan Leffler DDS"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 853,
      "Comment": "sed",
      "Registered": "2011-07-15T12:15:27.0116349+02:00",
      "RegisteredAssociateId": 67,
      "Updated": "2023-01-15T12:15:27.0116349+01:00",
      "UpdatedAssociateId": 531,
      "LegalBaseId": 867,
      "LegalBaseKey": "ipsam",
      "LegalBaseName": "Friesen Group",
      "ConsentPurposeId": 886,
      "ConsentPurposeKey": "autem",
      "ConsentPurposeName": "Bartell, Walker and Hahn",
      "ConsentSourceId": 836,
      "ConsentSourceKey": "dolor",
      "ConsentSourceName": "Gorczany LLC"
    }
  ],
  "BounceEmails": [
    "lucinda@borer.biz",
    "euna.block@damore.info"
  ],
  "ActiveStatusMonitorId": 869,
  "UserDefinedFields": {
    "SuperOffice:1": "108953396",
    "SuperOffice:2": "1557102758"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "rerum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 96,
  "Firstname": "Dominique",
  "MiddleName": "Batz Group",
  "Lastname": "Watsica",
  "Mrmrs": "quo",
  "Title": "voluptate",
  "UpdatedDate": "2015-11-16T12:15:27.0206346+01:00",
  "CreatedDate": "2007-03-01T12:15:27.0206346+01:00",
  "BirthDate": "2018-04-10T12:15:27.0206346+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "blanditiis",
      "StrippedValue": "qui",
      "Description": "Decentralized logistical neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "qui",
      "Description": "Decentralized logistical neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    }
  ],
  "Description": "Reduced explicit throughput",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "delectus",
      "StrippedValue": "voluptatem",
      "Description": "Secured radical algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 519
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "voluptatem",
      "Description": "Secured radical algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 519
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nemo",
      "StrippedValue": "dolor",
      "Description": "Cross-group contextually-based capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 174
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "dolor",
      "Description": "Cross-group contextually-based capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 174
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "nobis",
      "StrippedValue": "qui",
      "Description": "Self-enabling actuating task-force",
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
      "Value": "nobis",
      "StrippedValue": "qui",
      "Description": "Self-enabling actuating task-force",
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
  "OfficePhones": [
    {
      "Value": "ducimus",
      "StrippedValue": "voluptatem",
      "Description": "Multi-layered foreground orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 916
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "voluptatem",
      "Description": "Multi-layered foreground orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 916
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "atque",
      "StrippedValue": "aperiam",
      "Description": "Ameliorated discrete moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 529
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "aperiam",
      "Description": "Ameliorated discrete moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 529
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
      "Id": 886,
      "Name": "Gleason LLC",
      "ToolTip": "Itaque consectetur minima.",
      "Deleted": true,
      "Rank": 729,
      "Type": "animi",
      "ColorBlock": 130,
      "IconHint": "autem",
      "Selected": true,
      "LastChanged": "2011-03-26T12:15:27.0226345+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "occaecati",
      "Hidden": false,
      "FullName": "Dr. Will Lang DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 408
        }
      }
    }
  ],
  "PersonNumber": "731841",
  "FullName": "Santa Bashirian PhD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "ipsa",
      "Description": "Ergonomic tertiary synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "ipsa",
      "Description": "Ergonomic tertiary synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    }
  ],
  "FormalName": "Walter Inc and Sons",
  "Address": null,
  "Post3": "non",
  "Post2": "rerum",
  "Post1": "dolorum",
  "Kanalname": "sit",
  "Kanafname": "omnis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "corrupti",
  "ActiveInterests": 172,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 250,
  "DbiKey": "consequatur",
  "DbiLastModified": "2016-04-26T12:15:27.0256383+02:00",
  "DbiLastSyncronized": "2017-12-19T12:15:27.0256383+01:00",
  "SentInfo": 916,
  "ShowContactTickets": 974,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "facilis",
      "StrippedValue": "ab",
      "Description": "De-engineered bottom-line support",
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
      "Value": "facilis",
      "StrippedValue": "ab",
      "Description": "De-engineered bottom-line support",
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
  "InternetPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "nisi",
      "Description": "Ameliorated high-level methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "nisi",
      "Description": "Ameliorated high-level methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    }
  ],
  "Source": 29,
  "ActiveErpLinks": 428,
  "ShipmentTypes": [
    {
      "Id": 781,
      "Name": "Miller LLC",
      "ToolTip": "Ratione ex id velit odio tempora sint.",
      "Deleted": false,
      "Rank": 227,
      "Type": "nulla",
      "ColorBlock": 519,
      "IconHint": "unde",
      "Selected": false,
      "LastChanged": "2014-10-28T12:15:27.0266382+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "delectus",
      "Hidden": false,
      "FullName": "Cathryn Easter Williamson Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 147,
      "Comment": "quia",
      "Registered": "2001-04-25T12:15:27.0266382+02:00",
      "RegisteredAssociateId": 736,
      "Updated": "2012-07-08T12:15:27.0266382+02:00",
      "UpdatedAssociateId": 678,
      "LegalBaseId": 686,
      "LegalBaseKey": "ipsum",
      "LegalBaseName": "Renner-Feest",
      "ConsentPurposeId": 918,
      "ConsentPurposeKey": "debitis",
      "ConsentPurposeName": "Sanford-Kertzmann",
      "ConsentSourceId": 99,
      "ConsentSourceKey": "corrupti",
      "ConsentSourceName": "Hermiston Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 998
        }
      }
    }
  ],
  "BounceEmails": [
    "caden@cruickshank.name",
    "nayeli@schinnerkutch.com"
  ],
  "ActiveStatusMonitorId": 391,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Oran Rodriguez II",
    "SuperOffice:2": "Colten Willms"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "earum"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "ea"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 168
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```