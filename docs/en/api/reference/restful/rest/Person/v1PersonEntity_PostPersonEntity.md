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
  "PersonId": 235,
  "Firstname": "Lucinda",
  "MiddleName": "Adams Group",
  "Lastname": "Lowe",
  "Mrmrs": "quia",
  "Title": "sed",
  "UpdatedDate": "2002-06-18T14:32:11.5523109+02:00",
  "CreatedDate": "2024-06-13T14:32:11.5523109+02:00",
  "BirthDate": "2015-05-02T14:32:11.5523109+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ratione",
      "StrippedValue": "totam",
      "Description": "Networked even-keeled paradigm"
    },
    {
      "Value": "ratione",
      "StrippedValue": "totam",
      "Description": "Networked even-keeled paradigm"
    }
  ],
  "Description": "Synchronised dynamic firmware",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quis",
      "StrippedValue": "et",
      "Description": "Enterprise-wide maximized open architecture"
    },
    {
      "Value": "quis",
      "StrippedValue": "et",
      "Description": "Enterprise-wide maximized open architecture"
    }
  ],
  "Faxes": [
    {
      "Value": "fuga",
      "StrippedValue": "modi",
      "Description": "Right-sized solution-oriented service-desk"
    },
    {
      "Value": "fuga",
      "StrippedValue": "modi",
      "Description": "Right-sized solution-oriented service-desk"
    }
  ],
  "MobilePhones": [
    {
      "Value": "aperiam",
      "StrippedValue": "odio",
      "Description": "Persistent foreground ability"
    },
    {
      "Value": "aperiam",
      "StrippedValue": "odio",
      "Description": "Persistent foreground ability"
    }
  ],
  "OfficePhones": [
    {
      "Value": "quasi",
      "StrippedValue": "eum",
      "Description": "Object-based national paradigm"
    },
    {
      "Value": "quasi",
      "StrippedValue": "eum",
      "Description": "Object-based national paradigm"
    }
  ],
  "OtherPhones": [
    {
      "Value": "nemo",
      "StrippedValue": "nostrum",
      "Description": "Switchable non-volatile flexibility"
    },
    {
      "Value": "nemo",
      "StrippedValue": "nostrum",
      "Description": "Switchable non-volatile flexibility"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 447,
      "Name": "Runolfsson-Jast",
      "ToolTip": "In est perferendis sit ipsum rerum.",
      "Deleted": true,
      "Rank": 410,
      "Type": "perferendis",
      "ColorBlock": 63,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2003-08-27T14:32:11.5523109+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "excepturi",
      "StyleHint": "rerum",
      "Hidden": true,
      "FullName": "Orland Durgan"
    }
  ],
  "PersonNumber": "1333542",
  "FullName": "Laura O'Conner",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "odio",
      "StrippedValue": "aliquid",
      "Description": "Optional real-time database"
    },
    {
      "Value": "odio",
      "StrippedValue": "aliquid",
      "Description": "Optional real-time database"
    }
  ],
  "FormalName": "Rippin-Glover",
  "Address": null,
  "Post3": "aliquid",
  "Post2": "rerum",
  "Post1": "facere",
  "Kanalname": "voluptas",
  "Kanafname": "consequatur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "corporis",
  "ActiveInterests": 67,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 358,
  "DbiKey": "qui",
  "DbiLastModified": "1998-09-30T14:32:11.5523109+02:00",
  "DbiLastSyncronized": "2011-02-14T14:32:11.5523109+01:00",
  "SentInfo": 912,
  "ShowContactTickets": 749,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "similique",
      "StrippedValue": "illo",
      "Description": "Monitored contextually-based extranet"
    },
    {
      "Value": "similique",
      "StrippedValue": "illo",
      "Description": "Monitored contextually-based extranet"
    }
  ],
  "InternetPhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "excepturi",
      "Description": "Exclusive scalable task-force"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "excepturi",
      "Description": "Exclusive scalable task-force"
    }
  ],
  "Source": 51,
  "ActiveErpLinks": 605,
  "ShipmentTypes": [
    {
      "Id": 774,
      "Name": "Stamm-Mante",
      "ToolTip": "Provident similique vel omnis doloribus.",
      "Deleted": false,
      "Rank": 670,
      "Type": "dolor",
      "ColorBlock": 515,
      "IconHint": "totam",
      "Selected": false,
      "LastChanged": "2014-03-30T14:32:11.5523109+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "maiores",
      "StyleHint": "mollitia",
      "Hidden": false,
      "FullName": "Kory Nolan"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 73,
      "Comment": "eius",
      "Registered": "2007-01-17T14:32:11.5523109+01:00",
      "RegisteredAssociateId": 338,
      "Updated": "2010-07-06T14:32:11.5523109+02:00",
      "UpdatedAssociateId": 238,
      "LegalBaseId": 800,
      "LegalBaseKey": "ullam",
      "LegalBaseName": "Rosenbaum, Rice and Cormier",
      "ConsentPurposeId": 398,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Runte-Crist",
      "ConsentSourceId": 802,
      "ConsentSourceKey": "reprehenderit",
      "ConsentSourceName": "Runte-Tromp"
    }
  ],
  "BounceEmails": [
    "lilyan@beierschmidt.co.uk",
    "adrien@nader.info"
  ],
  "ActiveStatusMonitorId": 541,
  "CreatedByFormId": 400,
  "UserDefinedFields": {
    "SuperOffice:1": "Braulio Wehner",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "maiores",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "cum",
    "CustomFields2": "molestiae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 104,
  "Firstname": "Makayla",
  "MiddleName": "Reichel-Tillman",
  "Lastname": "Stanton",
  "Mrmrs": "omnis",
  "Title": "veritatis",
  "UpdatedDate": "2009-10-30T14:32:11.5679321+01:00",
  "CreatedDate": "2012-02-20T14:32:11.5679321+01:00",
  "BirthDate": "2001-12-28T14:32:11.5679321+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "deleniti",
      "StrippedValue": "eum",
      "Description": "Triple-buffered scalable functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 69
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "eum",
      "Description": "Triple-buffered scalable functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 69
        }
      }
    }
  ],
  "Description": "Implemented clear-thinking neural-net",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "iusto",
      "StrippedValue": "et",
      "Description": "Vision-oriented analyzing product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 967
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "et",
      "Description": "Vision-oriented analyzing product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 967
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "totam",
      "Description": "Fully-configurable content-based archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "totam",
      "Description": "Fully-configurable content-based archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "voluptatem",
      "Description": "Focused didactic application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 760
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "voluptatem",
      "Description": "Focused didactic application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 760
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "rerum",
      "StrippedValue": "sint",
      "Description": "Multi-tiered encompassing attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "sint",
      "Description": "Multi-tiered encompassing attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ex",
      "StrippedValue": "dicta",
      "Description": "Networked explicit standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "dicta",
      "Description": "Networked explicit standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
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
      "Id": 993,
      "Name": "Osinski-Hand",
      "ToolTip": "Quo dolore unde ut.",
      "Deleted": false,
      "Rank": 352,
      "Type": "animi",
      "ColorBlock": 62,
      "IconHint": "provident",
      "Selected": false,
      "LastChanged": "2009-10-11T14:32:11.5679321+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "expedita",
      "Hidden": false,
      "FullName": "Antonette Hauck",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 759
        }
      }
    }
  ],
  "PersonNumber": "544730",
  "FullName": "Joe Marvin",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "excepturi",
      "StrippedValue": "nam",
      "Description": "Stand-alone non-volatile matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 754
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "nam",
      "Description": "Stand-alone non-volatile matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 754
        }
      }
    }
  ],
  "FormalName": "Strosin Group",
  "Address": null,
  "Post3": "sed",
  "Post2": "excepturi",
  "Post1": "dolore",
  "Kanalname": "eveniet",
  "Kanafname": "quibusdam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptatem",
  "ActiveInterests": 736,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 771,
  "DbiKey": "officia",
  "DbiLastModified": "2007-02-06T14:32:11.5679321+01:00",
  "DbiLastSyncronized": "1997-11-10T14:32:11.5679321+01:00",
  "SentInfo": 322,
  "ShowContactTickets": 916,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "qui",
      "StrippedValue": "aut",
      "Description": "Optimized transitional superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 749
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "aut",
      "Description": "Optimized transitional superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 749
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "adipisci",
      "Description": "Triple-buffered incremental migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 187
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "adipisci",
      "Description": "Triple-buffered incremental migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 187
        }
      }
    }
  ],
  "Source": 382,
  "ActiveErpLinks": 851,
  "ShipmentTypes": [
    {
      "Id": 765,
      "Name": "Simonis, Schmidt and Zemlak",
      "ToolTip": "Perspiciatis qui molestiae ut.",
      "Deleted": false,
      "Rank": 263,
      "Type": "laboriosam",
      "ColorBlock": 419,
      "IconHint": "voluptatum",
      "Selected": false,
      "LastChanged": "2017-06-20T14:32:11.5679321+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Mr. Dimitri Hoeger",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 70
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 308,
      "Comment": "sint",
      "Registered": "2004-01-16T14:32:11.5679321+01:00",
      "RegisteredAssociateId": 191,
      "Updated": "2007-02-06T14:32:11.5679321+01:00",
      "UpdatedAssociateId": 375,
      "LegalBaseId": 774,
      "LegalBaseKey": "optio",
      "LegalBaseName": "Hauck Inc and Sons",
      "ConsentPurposeId": 823,
      "ConsentPurposeKey": "sit",
      "ConsentPurposeName": "Moen, Goldner and Kris",
      "ConsentSourceId": 629,
      "ConsentSourceKey": "veritatis",
      "ConsentSourceName": "Beahan LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 782
        }
      }
    }
  ],
  "BounceEmails": [
    "alan@gutkowski.us",
    "sheridan@hamill.biz"
  ],
  "ActiveStatusMonitorId": 483,
  "CreatedByFormId": 102,
  "UserDefinedFields": {
    "SuperOffice:1": "1621029551",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "dicta",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "cumque",
    "CustomFields2": "dolorum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 308
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```