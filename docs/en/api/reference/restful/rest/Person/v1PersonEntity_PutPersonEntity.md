---
title: PUT Person/{id}
uid: v1PersonEntity_PutPersonEntity
generated: true
---

# PUT Person/{id}

```http
PUT /api/v1/Person/{id}
```

Updates the existing PersonEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PersonEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Person/{id}?$select=name,department,category/id
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

PersonEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity updated. |
| 412 | Update stopped because PersonEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 553,
  "Firstname": "Narciso",
  "MiddleName": "Beatty-Bahringer",
  "Lastname": "Ullrich",
  "Mrmrs": "voluptate",
  "Title": "ratione",
  "UpdatedDate": "2020-08-18T03:44:57.4058726+02:00",
  "CreatedDate": "2014-01-16T03:44:57.4058726+01:00",
  "BirthDate": "2022-07-15T03:44:57.4058726+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "veritatis",
      "StrippedValue": "omnis",
      "Description": "Organized holistic hierarchy"
    },
    {
      "Value": "veritatis",
      "StrippedValue": "omnis",
      "Description": "Organized holistic hierarchy"
    }
  ],
  "Description": "Multi-tiered empowering Graphical User Interface",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "enim",
      "StrippedValue": "architecto",
      "Description": "Reactive clear-thinking local area network"
    },
    {
      "Value": "enim",
      "StrippedValue": "architecto",
      "Description": "Reactive clear-thinking local area network"
    }
  ],
  "Faxes": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "quia",
      "Description": "Mandatory system-worthy portal"
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "quia",
      "Description": "Mandatory system-worthy portal"
    }
  ],
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "ut",
      "Description": "Compatible empowering interface"
    },
    {
      "Value": "aut",
      "StrippedValue": "ut",
      "Description": "Compatible empowering interface"
    }
  ],
  "OfficePhones": [
    {
      "Value": "non",
      "StrippedValue": "delectus",
      "Description": "Ameliorated modular workforce"
    },
    {
      "Value": "non",
      "StrippedValue": "delectus",
      "Description": "Ameliorated modular workforce"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ea",
      "StrippedValue": "sed",
      "Description": "Multi-tiered transitional extranet"
    },
    {
      "Value": "ea",
      "StrippedValue": "sed",
      "Description": "Multi-tiered transitional extranet"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 298,
      "Name": "Schimmel Inc and Sons",
      "ToolTip": "Similique consequatur quia sunt ipsum debitis ratione ex.",
      "Deleted": true,
      "Rank": 919,
      "Type": "consectetur",
      "ColorBlock": 348,
      "IconHint": "blanditiis",
      "Selected": true,
      "LastChanged": "2022-02-25T03:44:57.4058726+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "id",
      "Hidden": true,
      "FullName": "Mrs. Lawson Edyth Marvin II"
    }
  ],
  "PersonNumber": "534236",
  "FullName": "Idella Roberts",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "est",
      "Description": "Implemented 6th generation superstructure"
    },
    {
      "Value": "nihil",
      "StrippedValue": "est",
      "Description": "Implemented 6th generation superstructure"
    }
  ],
  "FormalName": "Crooks-Jacobs",
  "Address": null,
  "Post3": "commodi",
  "Post2": "reiciendis",
  "Post1": "voluptatibus",
  "Kanalname": "soluta",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "qui",
  "ActiveInterests": 791,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 769,
  "DbiKey": "numquam",
  "DbiLastModified": "2007-09-14T03:44:57.4058726+02:00",
  "DbiLastSyncronized": "2004-02-08T03:44:57.4058726+01:00",
  "SentInfo": 670,
  "ShowContactTickets": 728,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quis",
      "StrippedValue": "totam",
      "Description": "Virtual multimedia analyzer"
    },
    {
      "Value": "quis",
      "StrippedValue": "totam",
      "Description": "Virtual multimedia analyzer"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "ducimus",
      "Description": "Down-sized uniform algorithm"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "ducimus",
      "Description": "Down-sized uniform algorithm"
    }
  ],
  "Source": 632,
  "ActiveErpLinks": 240,
  "ShipmentTypes": [
    {
      "Id": 186,
      "Name": "Hammes, Champlin and Pollich",
      "ToolTip": "Architecto aut.",
      "Deleted": false,
      "Rank": 595,
      "Type": "ut",
      "ColorBlock": 449,
      "IconHint": "distinctio",
      "Selected": false,
      "LastChanged": "2002-01-18T03:44:57.4058726+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "fugiat",
      "Hidden": false,
      "FullName": "Carol Christiansen"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 990,
      "Comment": "nesciunt",
      "Registered": "1998-09-19T03:44:57.4058726+02:00",
      "RegisteredAssociateId": 769,
      "Updated": "2019-08-16T03:44:57.4058726+02:00",
      "UpdatedAssociateId": 855,
      "LegalBaseId": 907,
      "LegalBaseKey": "necessitatibus",
      "LegalBaseName": "Wiegand-Shields",
      "ConsentPurposeId": 75,
      "ConsentPurposeKey": "consectetur",
      "ConsentPurposeName": "Jacobi-Kohler",
      "ConsentSourceId": 329,
      "ConsentSourceKey": "maxime",
      "ConsentSourceName": "Rolfson-Torp"
    }
  ],
  "BounceEmails": [
    "darian_bayer@grant.info",
    "clifton_farrell@shields.uk"
  ],
  "ActiveStatusMonitorId": 821,
  "CreatedByFormId": 391,
  "UserDefinedFields": {
    "SuperOffice:1": "Dolly Feest",
    "SuperOffice:2": "Ms. Bridgette Ellen Nicolas"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "optio",
    "CustomFields2": "blanditiis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 799,
  "Firstname": "Aubrey",
  "MiddleName": "Predovic Inc and Sons",
  "Lastname": "Kunze",
  "Mrmrs": "qui",
  "Title": "neque",
  "UpdatedDate": "2006-12-04T03:44:57.4058726+01:00",
  "CreatedDate": "2000-02-17T03:44:57.4058726+01:00",
  "BirthDate": "2000-11-22T03:44:57.4058726+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "esse",
      "StrippedValue": "omnis",
      "Description": "Balanced incremental success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 121
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "omnis",
      "Description": "Balanced incremental success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 121
        }
      }
    }
  ],
  "Description": "Front-line asynchronous throughput",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "quia",
      "StrippedValue": "laudantium",
      "Description": "Fundamental bottom-line task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 175
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "laudantium",
      "Description": "Fundamental bottom-line task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 175
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "magni",
      "Description": "Monitored fresh-thinking internet solution",
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
      "Value": "est",
      "StrippedValue": "magni",
      "Description": "Monitored fresh-thinking internet solution",
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
  "MobilePhones": [
    {
      "Value": "delectus",
      "StrippedValue": "quam",
      "Description": "Digitized bottom-line access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "quam",
      "Description": "Digitized bottom-line access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ab",
      "StrippedValue": "unde",
      "Description": "Fully-configurable stable synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "unde",
      "Description": "Fully-configurable stable synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "nihil",
      "StrippedValue": "a",
      "Description": "Face to face solution-oriented utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "a",
      "Description": "Face to face solution-oriented utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
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
      "Id": 59,
      "Name": "Kuvalis-Turcotte",
      "ToolTip": "A harum at fuga ea excepturi fugit dignissimos.",
      "Deleted": false,
      "Rank": 119,
      "Type": "suscipit",
      "ColorBlock": 236,
      "IconHint": "fuga",
      "Selected": true,
      "LastChanged": "2016-02-17T03:44:57.4058726+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "hic",
      "StyleHint": "perferendis",
      "Hidden": false,
      "FullName": "Mr. Lucienne Yadira Tremblay",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 635
        }
      }
    }
  ],
  "PersonNumber": "1513206",
  "FullName": "Miss Emmanuel Senger",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "vitae",
      "StrippedValue": "enim",
      "Description": "Switchable static approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 132
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "enim",
      "Description": "Switchable static approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 132
        }
      }
    }
  ],
  "FormalName": "Dibbert Inc and Sons",
  "Address": null,
  "Post3": "quo",
  "Post2": "quidem",
  "Post1": "ut",
  "Kanalname": "nihil",
  "Kanafname": "ut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "in",
  "ActiveInterests": 735,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 16,
  "DbiKey": "optio",
  "DbiLastModified": "2019-08-23T03:44:57.4058726+02:00",
  "DbiLastSyncronized": "2002-03-19T03:44:57.4058726+01:00",
  "SentInfo": 159,
  "ShowContactTickets": 172,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vel",
      "StrippedValue": "placeat",
      "Description": "Optimized background secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 321
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "placeat",
      "Description": "Optimized background secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 321
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "iusto",
      "StrippedValue": "accusantium",
      "Description": "Automated real-time capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "accusantium",
      "Description": "Automated real-time capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    }
  ],
  "Source": 29,
  "ActiveErpLinks": 308,
  "ShipmentTypes": [
    {
      "Id": 630,
      "Name": "West, Gottlieb and Gibson",
      "ToolTip": "Quis ut nam dignissimos architecto.",
      "Deleted": false,
      "Rank": 909,
      "Type": "dignissimos",
      "ColorBlock": 255,
      "IconHint": "eos",
      "Selected": false,
      "LastChanged": "2022-10-13T03:44:57.4058726+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "numquam",
      "StyleHint": "odio",
      "Hidden": false,
      "FullName": "Daisha Adele Lang I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 164
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 763,
      "Comment": "similique",
      "Registered": "2008-08-18T03:44:57.4058726+02:00",
      "RegisteredAssociateId": 25,
      "Updated": "2013-04-22T03:44:57.4058726+02:00",
      "UpdatedAssociateId": 144,
      "LegalBaseId": 232,
      "LegalBaseKey": "mollitia",
      "LegalBaseName": "Bartoletti-Russel",
      "ConsentPurposeId": 844,
      "ConsentPurposeKey": "delectus",
      "ConsentPurposeName": "Okuneva Group",
      "ConsentSourceId": 4,
      "ConsentSourceKey": "ea",
      "ConsentSourceName": "VonRueden, Koch and Skiles",
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
  "BounceEmails": [
    "keely@hamillbaumbach.ca",
    "meagan.flatley@leannonfeest.name"
  ],
  "ActiveStatusMonitorId": 778,
  "CreatedByFormId": 221,
  "UserDefinedFields": {
    "SuperOffice:1": "Piper Ernser",
    "SuperOffice:2": "Maxie Wyman"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "aliquid"
  },
  "CustomFields": {
    "CustomFields1": "aspernatur",
    "CustomFields2": "adipisci"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 716
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```