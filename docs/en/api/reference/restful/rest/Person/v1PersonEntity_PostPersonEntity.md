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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 803,
  "Firstname": "Valentin",
  "MiddleName": "Dietrich-Cronin",
  "Lastname": "Lockman",
  "Mrmrs": "aperiam",
  "Title": "sapiente",
  "UpdatedDate": "2022-01-20T23:04:04.2595176+01:00",
  "CreatedDate": "2019-06-03T23:04:04.2595176+02:00",
  "BirthDate": "2019-09-06T23:04:04.2595176+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "porro",
      "StrippedValue": "sint",
      "Description": "Centralized human-resource function"
    },
    {
      "Value": "porro",
      "StrippedValue": "sint",
      "Description": "Centralized human-resource function"
    }
  ],
  "Description": "Triple-buffered executive moderator",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "quo",
      "Description": "Stand-alone intermediate concept"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "quo",
      "Description": "Stand-alone intermediate concept"
    }
  ],
  "Faxes": [
    {
      "Value": "suscipit",
      "StrippedValue": "consectetur",
      "Description": "Streamlined client-server groupware"
    },
    {
      "Value": "suscipit",
      "StrippedValue": "consectetur",
      "Description": "Streamlined client-server groupware"
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "dolorem",
      "Description": "Organic leading edge attitude"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "dolorem",
      "Description": "Organic leading edge attitude"
    }
  ],
  "OfficePhones": [
    {
      "Value": "exercitationem",
      "StrippedValue": "eaque",
      "Description": "Multi-layered grid-enabled neural-net"
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "eaque",
      "Description": "Multi-layered grid-enabled neural-net"
    }
  ],
  "OtherPhones": [
    {
      "Value": "doloremque",
      "StrippedValue": "voluptas",
      "Description": "Networked didactic capacity"
    },
    {
      "Value": "doloremque",
      "StrippedValue": "voluptas",
      "Description": "Networked didactic capacity"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 187,
      "Name": "Rogahn Inc and Sons",
      "ToolTip": "Repellendus rem.",
      "Deleted": false,
      "Rank": 157,
      "Type": "suscipit",
      "ColorBlock": 425,
      "IconHint": "modi",
      "Selected": true,
      "LastChanged": "1999-10-14T23:04:04.2635178+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repellendus",
      "StyleHint": "perspiciatis",
      "Hidden": false,
      "FullName": "Prof. Mireille Edwardo Crist"
    }
  ],
  "PersonNumber": "980211",
  "FullName": "Ericka Hickle",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "dolores",
      "StrippedValue": "cumque",
      "Description": "Programmable composite ability"
    },
    {
      "Value": "dolores",
      "StrippedValue": "cumque",
      "Description": "Programmable composite ability"
    }
  ],
  "FormalName": "Klocko-Ortiz",
  "Address": null,
  "Post3": "quos",
  "Post2": "qui",
  "Post1": "voluptate",
  "Kanalname": "blanditiis",
  "Kanafname": "accusantium",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eius",
  "ActiveInterests": 169,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 909,
  "DbiKey": "sunt",
  "DbiLastModified": "2018-08-21T23:04:04.2655165+02:00",
  "DbiLastSyncronized": "2018-07-01T23:04:04.2655165+02:00",
  "SentInfo": 135,
  "ShowContactTickets": 963,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "error",
      "StrippedValue": "harum",
      "Description": "Realigned mobile success"
    },
    {
      "Value": "error",
      "StrippedValue": "harum",
      "Description": "Realigned mobile success"
    }
  ],
  "InternetPhones": [
    {
      "Value": "quis",
      "StrippedValue": "consequatur",
      "Description": "Profound radical capability"
    },
    {
      "Value": "quis",
      "StrippedValue": "consequatur",
      "Description": "Profound radical capability"
    }
  ],
  "Source": 295,
  "ActiveErpLinks": 772,
  "ShipmentTypes": [
    {
      "Id": 388,
      "Name": "Grimes Inc and Sons",
      "ToolTip": "Doloremque sint illo sit.",
      "Deleted": false,
      "Rank": 760,
      "Type": "autem",
      "ColorBlock": 307,
      "IconHint": "quidem",
      "Selected": false,
      "LastChanged": "2014-09-03T23:04:04.2665192+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "itaque",
      "Hidden": true,
      "FullName": "Freeda Carter"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 924,
      "Comment": "sequi",
      "Registered": "2002-10-20T23:04:04.2670158+02:00",
      "RegisteredAssociateId": 44,
      "Updated": "2001-01-09T23:04:04.2670158+01:00",
      "UpdatedAssociateId": 255,
      "LegalBaseId": 33,
      "LegalBaseKey": "molestias",
      "LegalBaseName": "Nitzsche-Douglas",
      "ConsentPurposeId": 363,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Cormier, Bahringer and Mann",
      "ConsentSourceId": 69,
      "ConsentSourceKey": "enim",
      "ConsentSourceName": "Corkery LLC"
    }
  ],
  "BounceEmails": [
    "dedric@walternicolas.uk",
    "amanda.miller@mayer.info"
  ],
  "ActiveStatusMonitorId": 610,
  "UserDefinedFields": {
    "SuperOffice:1": "Makayla Armstrong",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "labore",
    "ExtraFields2": "optio"
  },
  "CustomFields": {
    "CustomFields1": "libero",
    "CustomFields2": "voluptatibus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 737,
  "Firstname": "Claire",
  "MiddleName": "Douglas-Yundt",
  "Lastname": "Gottlieb",
  "Mrmrs": "fugiat",
  "Title": "omnis",
  "UpdatedDate": "2000-11-08T23:04:04.2765207+01:00",
  "CreatedDate": "2023-01-16T23:04:04.2765207+01:00",
  "BirthDate": "2012-11-16T23:04:04.2765207+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "reiciendis",
      "StrippedValue": "occaecati",
      "Description": "Cross-platform tangible application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 597
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "occaecati",
      "Description": "Cross-platform tangible application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 597
        }
      }
    }
  ],
  "Description": "Reduced context-sensitive synergy",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "Re-contextualized fault-tolerant frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 319
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "Re-contextualized fault-tolerant frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 319
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "omnis",
      "Description": "Quality-focused foreground methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "omnis",
      "Description": "Quality-focused foreground methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sit",
      "StrippedValue": "nemo",
      "Description": "Front-line exuding Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "nemo",
      "Description": "Front-line exuding Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "est",
      "StrippedValue": "ratione",
      "Description": "Up-sized homogeneous collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 790
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "ratione",
      "Description": "Up-sized homogeneous collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 790
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "non",
      "Description": "Open-architected clear-thinking standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 586
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "non",
      "Description": "Open-architected clear-thinking standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 586
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
      "Id": 518,
      "Name": "Konopelski LLC",
      "ToolTip": "Natus deleniti at voluptate quia commodi consequatur modi.",
      "Deleted": false,
      "Rank": 262,
      "Type": "aspernatur",
      "ColorBlock": 781,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2014-01-16T23:04:04.2785134+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "accusamus",
      "StyleHint": "culpa",
      "Hidden": false,
      "FullName": "Coy Fritsch I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 176
        }
      }
    }
  ],
  "PersonNumber": "1223815",
  "FullName": "Derek Murazik",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "nihil",
      "Description": "Front-line intermediate installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "nihil",
      "Description": "Front-line intermediate installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    }
  ],
  "FormalName": "Murray, Jakubowski and Bahringer",
  "Address": null,
  "Post3": "sapiente",
  "Post2": "facere",
  "Post1": "quo",
  "Kanalname": "ea",
  "Kanafname": "voluptas",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ullam",
  "ActiveInterests": 936,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 290,
  "DbiKey": "sapiente",
  "DbiLastModified": "1998-07-07T23:04:04.282016+02:00",
  "DbiLastSyncronized": "2012-10-17T23:04:04.282016+02:00",
  "SentInfo": 839,
  "ShowContactTickets": 151,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "modi",
      "StrippedValue": "consequuntur",
      "Description": "Exclusive scalable middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 540
        }
      }
    },
    {
      "Value": "modi",
      "StrippedValue": "consequuntur",
      "Description": "Exclusive scalable middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 540
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "voluptatem",
      "Description": "Proactive attitude-oriented capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "voluptatem",
      "Description": "Proactive attitude-oriented capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    }
  ],
  "Source": 52,
  "ActiveErpLinks": 325,
  "ShipmentTypes": [
    {
      "Id": 108,
      "Name": "Herzog-Keeling",
      "ToolTip": "Quia quod eligendi.",
      "Deleted": false,
      "Rank": 131,
      "Type": "ea",
      "ColorBlock": 537,
      "IconHint": "rerum",
      "Selected": false,
      "LastChanged": "2012-02-05T23:04:04.2825181+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deleniti",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Dr. Darrell Erika Krajcik V",
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
  "Consents": [
    {
      "ConsentPersonId": 791,
      "Comment": "amet",
      "Registered": "2013-07-19T23:04:04.2830158+02:00",
      "RegisteredAssociateId": 31,
      "Updated": "2019-02-07T23:04:04.2830158+01:00",
      "UpdatedAssociateId": 254,
      "LegalBaseId": 665,
      "LegalBaseKey": "deserunt",
      "LegalBaseName": "Boyle, Stiedemann and Abernathy",
      "ConsentPurposeId": 303,
      "ConsentPurposeKey": "sed",
      "ConsentPurposeName": "Will, Gottlieb and Smith",
      "ConsentSourceId": 112,
      "ConsentSourceKey": "nam",
      "ConsentSourceName": "Metz Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    }
  ],
  "BounceEmails": [
    "maureen.ondricka@erdmanleffler.biz",
    "leda@zemlak.co.uk"
  ],
  "ActiveStatusMonitorId": 116,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Gregg Stiedemann",
    "SuperOffice:2": "Cleveland Green"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "eaque"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "sapiente"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 597
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```