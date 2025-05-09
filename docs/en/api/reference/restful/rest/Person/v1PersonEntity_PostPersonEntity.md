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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 353,
  "Firstname": "Norene",
  "MiddleName": "Morar, Schultz and Buckridge",
  "Lastname": "Stehr",
  "Mrmrs": "eveniet",
  "Title": "voluptas",
  "UpdatedDate": "2006-06-02T16:32:47.5870675+02:00",
  "CreatedDate": "2023-11-20T16:32:47.5870675+01:00",
  "BirthDate": "1999-12-24T16:32:47.5870675+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "et",
      "Description": "Optimized coherent standardization"
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "et",
      "Description": "Optimized coherent standardization"
    }
  ],
  "Description": "Organized client-server conglomeration",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sit",
      "StrippedValue": "impedit",
      "Description": "Multi-layered high-level encoding"
    },
    {
      "Value": "sit",
      "StrippedValue": "impedit",
      "Description": "Multi-layered high-level encoding"
    }
  ],
  "Faxes": [
    {
      "Value": "quibusdam",
      "StrippedValue": "et",
      "Description": "Cross-platform global conglomeration"
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "et",
      "Description": "Cross-platform global conglomeration"
    }
  ],
  "MobilePhones": [
    {
      "Value": "molestias",
      "StrippedValue": "dicta",
      "Description": "Persistent optimal adapter"
    },
    {
      "Value": "molestias",
      "StrippedValue": "dicta",
      "Description": "Persistent optimal adapter"
    }
  ],
  "OfficePhones": [
    {
      "Value": "atque",
      "StrippedValue": "velit",
      "Description": "Synergistic systemic task-force"
    },
    {
      "Value": "atque",
      "StrippedValue": "velit",
      "Description": "Synergistic systemic task-force"
    }
  ],
  "OtherPhones": [
    {
      "Value": "sed",
      "StrippedValue": "aut",
      "Description": "Front-line real-time open system"
    },
    {
      "Value": "sed",
      "StrippedValue": "aut",
      "Description": "Front-line real-time open system"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 324,
      "Name": "Brakus-Gorczany",
      "ToolTip": "Quo quam pariatur distinctio itaque beatae qui.",
      "Deleted": false,
      "Rank": 334,
      "Type": "et",
      "ColorBlock": 597,
      "IconHint": "culpa",
      "Selected": false,
      "LastChanged": "1999-06-12T16:32:47.5870675+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Dr. Rashawn Amelie Yost"
    }
  ],
  "PersonNumber": "684335",
  "FullName": "Myrtis Lydia Bins I",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "quaerat",
      "StrippedValue": "aliquid",
      "Description": "Face to face mobile archive"
    },
    {
      "Value": "quaerat",
      "StrippedValue": "aliquid",
      "Description": "Face to face mobile archive"
    }
  ],
  "FormalName": "Haley LLC",
  "Address": null,
  "Post3": "asperiores",
  "Post2": "fugiat",
  "Post1": "labore",
  "Kanalname": "quo",
  "Kanafname": "vitae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "consectetur",
  "ActiveInterests": 596,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 119,
  "DbiKey": "officiis",
  "DbiLastModified": "2009-10-08T16:32:47.5870675+02:00",
  "DbiLastSyncronized": "2004-10-12T16:32:47.5870675+02:00",
  "SentInfo": 748,
  "ShowContactTickets": 830,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptates",
      "StrippedValue": "unde",
      "Description": "De-engineered value-added capability"
    },
    {
      "Value": "voluptates",
      "StrippedValue": "unde",
      "Description": "De-engineered value-added capability"
    }
  ],
  "InternetPhones": [
    {
      "Value": "qui",
      "StrippedValue": "dolor",
      "Description": "Distributed eco-centric infrastructure"
    },
    {
      "Value": "qui",
      "StrippedValue": "dolor",
      "Description": "Distributed eco-centric infrastructure"
    }
  ],
  "Source": 3,
  "ActiveErpLinks": 774,
  "ShipmentTypes": [
    {
      "Id": 236,
      "Name": "Maggio Inc and Sons",
      "ToolTip": "Tenetur quia.",
      "Deleted": false,
      "Rank": 189,
      "Type": "nobis",
      "ColorBlock": 870,
      "IconHint": "praesentium",
      "Selected": true,
      "LastChanged": "2014-02-05T16:32:47.5870675+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rerum",
      "StyleHint": "quia",
      "Hidden": true,
      "FullName": "Darrin Cormier"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 523,
      "Comment": "adipisci",
      "Registered": "2010-12-20T16:32:47.5870675+01:00",
      "RegisteredAssociateId": 989,
      "Updated": "2000-05-30T16:32:47.5870675+02:00",
      "UpdatedAssociateId": 403,
      "LegalBaseId": 493,
      "LegalBaseKey": "nam",
      "LegalBaseName": "Walsh LLC",
      "ConsentPurposeId": 968,
      "ConsentPurposeKey": "voluptate",
      "ConsentPurposeName": "Kris LLC",
      "ConsentSourceId": 128,
      "ConsentSourceKey": "rerum",
      "ConsentSourceName": "Altenwerth Group"
    }
  ],
  "BounceEmails": [
    "joanny_little@franeckimedhurst.us",
    "lyla@thiel.biz"
  ],
  "ActiveStatusMonitorId": 816,
  "CreatedByFormId": 980,
  "UserDefinedFields": {
    "SuperOffice:1": "2019700573",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "laboriosam",
    "ExtraFields2": "nemo"
  },
  "CustomFields": {
    "CustomFields1": "voluptatum",
    "CustomFields2": "ut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 792,
  "Firstname": "Richard",
  "MiddleName": "Homenick, Ortiz and Mann",
  "Lastname": "Crooks",
  "Mrmrs": "consequatur",
  "Title": "atque",
  "UpdatedDate": "2002-05-11T16:32:47.6026894+02:00",
  "CreatedDate": "2002-04-06T16:32:47.6026894+02:00",
  "BirthDate": "2011-06-03T16:32:47.6026894+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "commodi",
      "StrippedValue": "autem",
      "Description": "Upgradable real-time infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "autem",
      "Description": "Upgradable real-time infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    }
  ],
  "Description": "Cross-group foreground attitude",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ipsum",
      "StrippedValue": "maiores",
      "Description": "Virtual analyzing strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 436
        }
      }
    },
    {
      "Value": "ipsum",
      "StrippedValue": "maiores",
      "Description": "Virtual analyzing strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 436
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "harum",
      "StrippedValue": "laudantium",
      "Description": "Customer-focused incremental Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "laudantium",
      "Description": "Customer-focused incremental Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quibusdam",
      "StrippedValue": "quibusdam",
      "Description": "Enhanced 5th generation initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "quibusdam",
      "Description": "Enhanced 5th generation initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolor",
      "StrippedValue": "dolorem",
      "Description": "Realigned system-worthy moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "dolorem",
      "Description": "Realigned system-worthy moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ipsum",
      "StrippedValue": "veniam",
      "Description": "Synergized uniform utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
        }
      }
    },
    {
      "Value": "ipsum",
      "StrippedValue": "veniam",
      "Description": "Synergized uniform utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
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
      "Id": 936,
      "Name": "Lemke-Fahey",
      "ToolTip": "Assumenda atque ab.",
      "Deleted": false,
      "Rank": 97,
      "Type": "assumenda",
      "ColorBlock": 130,
      "IconHint": "autem",
      "Selected": true,
      "LastChanged": "2006-04-06T16:32:47.6026894+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "id",
      "StyleHint": "vitae",
      "Hidden": true,
      "FullName": "Murphy Luettgen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 617
        }
      }
    }
  ],
  "PersonNumber": "185097",
  "FullName": "Emily Reichel DVM",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "officiis",
      "StrippedValue": "sit",
      "Description": "Future-proofed regional service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "sit",
      "Description": "Future-proofed regional service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    }
  ],
  "FormalName": "Pollich-Mayer",
  "Address": null,
  "Post3": "laboriosam",
  "Post2": "dolor",
  "Post1": "excepturi",
  "Kanalname": "qui",
  "Kanafname": "distinctio",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ullam",
  "ActiveInterests": 230,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 765,
  "DbiKey": "recusandae",
  "DbiLastModified": "2005-05-25T16:32:47.6026894+02:00",
  "DbiLastSyncronized": "2009-08-31T16:32:47.6026894+02:00",
  "SentInfo": 336,
  "ShowContactTickets": 712,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "dolor",
      "StrippedValue": "explicabo",
      "Description": "Sharable even-keeled product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 868
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "explicabo",
      "Description": "Sharable even-keeled product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 868
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "debitis",
      "StrippedValue": "cum",
      "Description": "Balanced assymetric groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 916
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "cum",
      "Description": "Balanced assymetric groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 916
        }
      }
    }
  ],
  "Source": 230,
  "ActiveErpLinks": 382,
  "ShipmentTypes": [
    {
      "Id": 299,
      "Name": "Hoeger-Mitchell",
      "ToolTip": "Sequi perspiciatis id quidem.",
      "Deleted": false,
      "Rank": 146,
      "Type": "et",
      "ColorBlock": 80,
      "IconHint": "dolores",
      "Selected": false,
      "LastChanged": "2011-10-18T16:32:47.6026894+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sapiente",
      "StyleHint": "soluta",
      "Hidden": false,
      "FullName": "Mr. Annie Koch II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 380
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 387,
      "Comment": "dolor",
      "Registered": "2022-11-24T16:32:47.6026894+01:00",
      "RegisteredAssociateId": 946,
      "Updated": "2020-12-16T16:32:47.6026894+01:00",
      "UpdatedAssociateId": 572,
      "LegalBaseId": 460,
      "LegalBaseKey": "ex",
      "LegalBaseName": "Ritchie-Wiza",
      "ConsentPurposeId": 712,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Osinski LLC",
      "ConsentSourceId": 921,
      "ConsentSourceKey": "quo",
      "ConsentSourceName": "Fahey Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "BounceEmails": [
    "lorine@parisianeichmann.name",
    "giles_buckridge@powlowski.ca"
  ],
  "ActiveStatusMonitorId": 885,
  "CreatedByFormId": 356,
  "UserDefinedFields": {
    "SuperOffice:1": "Judd Fahey",
    "SuperOffice:2": "Prof. Ozella Waters Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "molestiae"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 325
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```