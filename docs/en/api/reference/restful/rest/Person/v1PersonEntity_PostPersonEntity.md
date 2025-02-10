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
| CreatedByFormId | Integer | The form id of the form that created the person |
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 535,
  "Firstname": "Celia",
  "MiddleName": "Kessler-Corkery",
  "Lastname": "Roberts",
  "Mrmrs": "aut",
  "Title": "saepe",
  "UpdatedDate": "2002-12-27T12:01:32.933188+01:00",
  "CreatedDate": "2005-05-25T12:01:32.933188+02:00",
  "BirthDate": "2002-07-06T12:01:32.933188+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "animi",
      "Description": "Reverse-engineered stable knowledge base"
    },
    {
      "Value": "et",
      "StrippedValue": "animi",
      "Description": "Reverse-engineered stable knowledge base"
    }
  ],
  "Description": "Vision-oriented tertiary local area network",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "qui",
      "Description": "Optional content-based middleware"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "qui",
      "Description": "Optional content-based middleware"
    }
  ],
  "Faxes": [
    {
      "Value": "nam",
      "StrippedValue": "quod",
      "Description": "Progressive tangible orchestration"
    },
    {
      "Value": "nam",
      "StrippedValue": "quod",
      "Description": "Progressive tangible orchestration"
    }
  ],
  "MobilePhones": [
    {
      "Value": "est",
      "StrippedValue": "omnis",
      "Description": "Intuitive client-driven architecture"
    },
    {
      "Value": "est",
      "StrippedValue": "omnis",
      "Description": "Intuitive client-driven architecture"
    }
  ],
  "OfficePhones": [
    {
      "Value": "illum",
      "StrippedValue": "ut",
      "Description": "Open-architected contextually-based benchmark"
    },
    {
      "Value": "illum",
      "StrippedValue": "ut",
      "Description": "Open-architected contextually-based benchmark"
    }
  ],
  "OtherPhones": [
    {
      "Value": "praesentium",
      "StrippedValue": "ut",
      "Description": "Networked intangible flexibility"
    },
    {
      "Value": "praesentium",
      "StrippedValue": "ut",
      "Description": "Networked intangible flexibility"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 410,
      "Name": "Goodwin Group",
      "ToolTip": "Quia consequuntur provident.",
      "Deleted": true,
      "Rank": 603,
      "Type": "facere",
      "ColorBlock": 715,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2018-11-17T12:01:32.933188+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "quam",
      "Hidden": false,
      "FullName": "Grace Christiansen"
    }
  ],
  "PersonNumber": "816203",
  "FullName": "Travis Leffler",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "autem",
      "StrippedValue": "et",
      "Description": "Progressive heuristic workforce"
    },
    {
      "Value": "autem",
      "StrippedValue": "et",
      "Description": "Progressive heuristic workforce"
    }
  ],
  "FormalName": "Schroeder, Friesen and Pfeffer",
  "Address": null,
  "Post3": "necessitatibus",
  "Post2": "harum",
  "Post1": "sit",
  "Kanalname": "recusandae",
  "Kanafname": "fugit",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptatibus",
  "ActiveInterests": 682,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 649,
  "DbiKey": "nobis",
  "DbiLastModified": "2003-07-19T12:01:32.933188+02:00",
  "DbiLastSyncronized": "2013-05-14T12:01:32.933188+02:00",
  "SentInfo": 283,
  "ShowContactTickets": 149,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sed",
      "StrippedValue": "harum",
      "Description": "Down-sized executive service-desk"
    },
    {
      "Value": "sed",
      "StrippedValue": "harum",
      "Description": "Down-sized executive service-desk"
    }
  ],
  "InternetPhones": [
    {
      "Value": "ipsam",
      "StrippedValue": "odit",
      "Description": "Team-oriented mobile flexibility"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "odit",
      "Description": "Team-oriented mobile flexibility"
    }
  ],
  "Source": 728,
  "ActiveErpLinks": 936,
  "ShipmentTypes": [
    {
      "Id": 1001,
      "Name": "Kuhlman Group",
      "ToolTip": "Necessitatibus tempore velit beatae voluptatem repudiandae suscipit temporibus.",
      "Deleted": false,
      "Rank": 290,
      "Type": "at",
      "ColorBlock": 95,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2010-07-20T12:01:32.933188+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Anastasia Cremin"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 113,
      "Comment": "doloribus",
      "Registered": "2003-01-17T12:01:32.933188+01:00",
      "RegisteredAssociateId": 543,
      "Updated": "2009-03-04T12:01:32.933188+01:00",
      "UpdatedAssociateId": 783,
      "LegalBaseId": 992,
      "LegalBaseKey": "maxime",
      "LegalBaseName": "Howe LLC",
      "ConsentPurposeId": 108,
      "ConsentPurposeKey": "consequatur",
      "ConsentPurposeName": "Bradtke-Adams",
      "ConsentSourceId": 156,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Stark, Powlowski and Lehner"
    }
  ],
  "BounceEmails": [
    "pascale.veum@weissnatkuhic.us",
    "imogene.ziemann@west.us"
  ],
  "ActiveStatusMonitorId": 646,
  "CreatedByFormId": 714,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Cruz Dach",
    "SuperOffice:2": "1809993398"
  },
  "ExtraFields": {
    "ExtraFields1": "a",
    "ExtraFields2": "amet"
  },
  "CustomFields": {
    "CustomFields1": "beatae",
    "CustomFields2": "vitae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 61,
  "Firstname": "Elenor",
  "MiddleName": "McCullough Group",
  "Lastname": "Ebert",
  "Mrmrs": "occaecati",
  "Title": "asperiores",
  "UpdatedDate": "2024-10-23T12:01:32.9488139+02:00",
  "CreatedDate": "1998-04-28T12:01:32.9488139+02:00",
  "BirthDate": "2008-08-13T12:01:32.9488139+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "doloremque",
      "Description": "Adaptive web-enabled project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "doloremque",
      "Description": "Adaptive web-enabled project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 150
        }
      }
    }
  ],
  "Description": "Persistent foreground focus group",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "exercitationem",
      "StrippedValue": "iure",
      "Description": "Open-architected well-modulated benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 850
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "iure",
      "Description": "Open-architected well-modulated benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 850
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "temporibus",
      "StrippedValue": "commodi",
      "Description": "Adaptive eco-centric middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 601
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "commodi",
      "Description": "Adaptive eco-centric middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 601
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "numquam",
      "StrippedValue": "tenetur",
      "Description": "Reverse-engineered high-level middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 613
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "tenetur",
      "Description": "Reverse-engineered high-level middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 613
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "deleniti",
      "StrippedValue": "sed",
      "Description": "Vision-oriented dynamic open system",
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
      "Value": "deleniti",
      "StrippedValue": "sed",
      "Description": "Vision-oriented dynamic open system",
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
  "OtherPhones": [
    {
      "Value": "numquam",
      "StrippedValue": "harum",
      "Description": "Open-architected fresh-thinking knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 259
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "harum",
      "Description": "Open-architected fresh-thinking knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 259
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
      "Id": 887,
      "Name": "Mertz, Reichel and Collins",
      "ToolTip": "Ea ex neque veniam qui veniam beatae rerum.",
      "Deleted": false,
      "Rank": 246,
      "Type": "ut",
      "ColorBlock": 751,
      "IconHint": "harum",
      "Selected": false,
      "LastChanged": "2012-09-09T12:01:32.9488139+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "at",
      "StyleHint": "quam",
      "Hidden": true,
      "FullName": "Kimberly Pagac",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 811
        }
      }
    }
  ],
  "PersonNumber": "584320",
  "FullName": "Mr. Daron Conrad Gusikowski II",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "tenetur",
      "StrippedValue": "quas",
      "Description": "Self-enabling discrete hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 27
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "quas",
      "Description": "Self-enabling discrete hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 27
        }
      }
    }
  ],
  "FormalName": "Baumbach Group",
  "Address": null,
  "Post3": "est",
  "Post2": "fuga",
  "Post1": "temporibus",
  "Kanalname": "et",
  "Kanafname": "consequatur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "doloribus",
  "ActiveInterests": 294,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 406,
  "DbiKey": "id",
  "DbiLastModified": "2014-04-13T12:01:32.9488139+02:00",
  "DbiLastSyncronized": "2015-07-06T12:01:32.9488139+02:00",
  "SentInfo": 933,
  "ShowContactTickets": 785,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quas",
      "StrippedValue": "aut",
      "Description": "Reduced grid-enabled emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 344
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "aut",
      "Description": "Reduced grid-enabled emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 344
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "est",
      "StrippedValue": "voluptates",
      "Description": "Innovative coherent project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 465
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "voluptates",
      "Description": "Innovative coherent project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 465
        }
      }
    }
  ],
  "Source": 956,
  "ActiveErpLinks": 452,
  "ShipmentTypes": [
    {
      "Id": 56,
      "Name": "Fisher, Dooley and Effertz",
      "ToolTip": "Voluptatem minima ut.",
      "Deleted": true,
      "Rank": 852,
      "Type": "rerum",
      "ColorBlock": 443,
      "IconHint": "vero",
      "Selected": false,
      "LastChanged": "2024-04-09T12:01:32.9488139+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rerum",
      "StyleHint": "quisquam",
      "Hidden": false,
      "FullName": "Miss Janice Quigley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 613
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 848,
      "Comment": "quis",
      "Registered": "2020-10-05T12:01:32.9488139+02:00",
      "RegisteredAssociateId": 348,
      "Updated": "1999-05-20T12:01:32.9488139+02:00",
      "UpdatedAssociateId": 885,
      "LegalBaseId": 70,
      "LegalBaseKey": "sunt",
      "LegalBaseName": "Donnelly Group",
      "ConsentPurposeId": 570,
      "ConsentPurposeKey": "dolor",
      "ConsentPurposeName": "Yost-Miller",
      "ConsentSourceId": 664,
      "ConsentSourceKey": "natus",
      "ConsentSourceName": "Krajcik LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 951
        }
      }
    }
  ],
  "BounceEmails": [
    "brayan@kuvalisbogisich.biz",
    "benjamin@halvorson.uk"
  ],
  "ActiveStatusMonitorId": 715,
  "CreatedByFormId": 25,
  "UserDefinedFields": {
    "SuperOffice:1": "Jordane Lind",
    "SuperOffice:2": "Alphonso Okuneva"
  },
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "ad"
  },
  "CustomFields": {
    "CustomFields1": "hic",
    "CustomFields2": "amet"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 765
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```