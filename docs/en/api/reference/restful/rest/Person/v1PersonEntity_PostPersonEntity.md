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
  "PersonId": 77,
  "Firstname": "Leonor",
  "MiddleName": "Johns LLC",
  "Lastname": "Rempel",
  "Mrmrs": "dolores",
  "Title": "ipsam",
  "UpdatedDate": "2005-08-23T17:54:08.2730803+02:00",
  "CreatedDate": "2009-06-23T17:54:08.2730803+02:00",
  "BirthDate": "2014-12-17T17:54:08.2730803+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Adaptive clear-thinking workforce"
    },
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Adaptive clear-thinking workforce"
    }
  ],
  "Description": "Digitized real-time support",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "odit",
      "StrippedValue": "ut",
      "Description": "Business-focused zero defect workforce"
    },
    {
      "Value": "odit",
      "StrippedValue": "ut",
      "Description": "Business-focused zero defect workforce"
    }
  ],
  "Faxes": [
    {
      "Value": "laboriosam",
      "StrippedValue": "ut",
      "Description": "Monitored heuristic website"
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "ut",
      "Description": "Monitored heuristic website"
    }
  ],
  "MobilePhones": [
    {
      "Value": "dicta",
      "StrippedValue": "sapiente",
      "Description": "Advanced executive complexity"
    },
    {
      "Value": "dicta",
      "StrippedValue": "sapiente",
      "Description": "Advanced executive complexity"
    }
  ],
  "OfficePhones": [
    {
      "Value": "delectus",
      "StrippedValue": "doloremque",
      "Description": "Multi-channelled needs-based forecast"
    },
    {
      "Value": "delectus",
      "StrippedValue": "doloremque",
      "Description": "Multi-channelled needs-based forecast"
    }
  ],
  "OtherPhones": [
    {
      "Value": "mollitia",
      "StrippedValue": "sapiente",
      "Description": "Monitored systematic concept"
    },
    {
      "Value": "mollitia",
      "StrippedValue": "sapiente",
      "Description": "Monitored systematic concept"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 68,
      "Name": "Hilpert-Ullrich",
      "ToolTip": "Excepturi et voluptatem expedita est quae dolores natus.",
      "Deleted": true,
      "Rank": 63,
      "Type": "doloribus",
      "ColorBlock": 634,
      "IconHint": "vero",
      "Selected": false,
      "LastChanged": "2024-06-30T17:54:08.2730803+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "vitae",
      "Hidden": false,
      "FullName": "Ms. Juana Nichole Lind V"
    }
  ],
  "PersonNumber": "1094635",
  "FullName": "Imani Shields",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "atque",
      "Description": "Integrated contextually-based open architecture"
    },
    {
      "Value": "nihil",
      "StrippedValue": "atque",
      "Description": "Integrated contextually-based open architecture"
    }
  ],
  "FormalName": "Bednar-Goodwin",
  "Address": null,
  "Post3": "explicabo",
  "Post2": "aut",
  "Post1": "nesciunt",
  "Kanalname": "doloribus",
  "Kanafname": "aut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "rem",
  "ActiveInterests": 892,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 607,
  "DbiKey": "error",
  "DbiLastModified": "2019-07-09T17:54:08.2730803+02:00",
  "DbiLastSyncronized": "2020-03-28T17:54:08.2730803+01:00",
  "SentInfo": 433,
  "ShowContactTickets": 65,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quo",
      "StrippedValue": "modi",
      "Description": "Integrated tangible core"
    },
    {
      "Value": "quo",
      "StrippedValue": "modi",
      "Description": "Integrated tangible core"
    }
  ],
  "InternetPhones": [
    {
      "Value": "aut",
      "StrippedValue": "nisi",
      "Description": "Digitized 4th generation support"
    },
    {
      "Value": "aut",
      "StrippedValue": "nisi",
      "Description": "Digitized 4th generation support"
    }
  ],
  "Source": 851,
  "ActiveErpLinks": 883,
  "ShipmentTypes": [
    {
      "Id": 627,
      "Name": "Smitham, Mohr and Schuster",
      "ToolTip": "Laboriosam neque qui laudantium rerum quia vitae.",
      "Deleted": false,
      "Rank": 835,
      "Type": "et",
      "ColorBlock": 357,
      "IconHint": "sunt",
      "Selected": true,
      "LastChanged": "2000-04-28T17:54:08.2730803+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "porro",
      "StyleHint": "velit",
      "Hidden": false,
      "FullName": "Roel Sigrid Bogan IV"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 47,
      "Comment": "eos",
      "Registered": "2018-09-05T17:54:08.2730803+02:00",
      "RegisteredAssociateId": 530,
      "Updated": "2009-03-17T17:54:08.2730803+01:00",
      "UpdatedAssociateId": 714,
      "LegalBaseId": 344,
      "LegalBaseKey": "voluptatem",
      "LegalBaseName": "Goyette-Pacocha",
      "ConsentPurposeId": 309,
      "ConsentPurposeKey": "repellendus",
      "ConsentPurposeName": "Hackett, Runte and Bashirian",
      "ConsentSourceId": 846,
      "ConsentSourceKey": "repellat",
      "ConsentSourceName": "Nikolaus-Hane"
    }
  ],
  "BounceEmails": [
    "arianna.rippin@swiftshields.co.uk",
    "javier@funk.com"
  ],
  "ActiveStatusMonitorId": 137,
  "CreatedByFormId": 829,
  "UserDefinedFields": {
    "SuperOffice:1": "1976520097",
    "SuperOffice:2": "Graham Marquardt"
  },
  "ExtraFields": {
    "ExtraFields1": "suscipit",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "natus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 134,
  "Firstname": "Monroe",
  "MiddleName": "Walker, Stark and Becker",
  "Lastname": "Muller",
  "Mrmrs": "quas",
  "Title": "vel",
  "UpdatedDate": "2015-09-09T17:54:08.2887055+02:00",
  "CreatedDate": "2007-08-07T17:54:08.2887055+02:00",
  "BirthDate": "2022-10-04T17:54:08.2887055+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "totam",
      "StrippedValue": "maxime",
      "Description": "Managed regional application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 277
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "maxime",
      "Description": "Managed regional application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 277
        }
      }
    }
  ],
  "Description": "Cross-group dedicated portal",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "molestias",
      "StrippedValue": "enim",
      "Description": "Fundamental transitional contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 374
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "enim",
      "Description": "Fundamental transitional contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 374
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "deserunt",
      "StrippedValue": "neque",
      "Description": "Cross-group analyzing synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 138
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "neque",
      "Description": "Cross-group analyzing synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 138
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "aspernatur",
      "Description": "Up-sized discrete encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "aspernatur",
      "Description": "Up-sized discrete encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "commodi",
      "StrippedValue": "molestiae",
      "Description": "Diverse optimizing framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "molestiae",
      "Description": "Diverse optimizing framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "doloremque",
      "StrippedValue": "voluptates",
      "Description": "Polarised heuristic encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 354
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "voluptates",
      "Description": "Polarised heuristic encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 354
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
      "Id": 482,
      "Name": "Shanahan Group",
      "ToolTip": "Cupiditate velit debitis dolorem perspiciatis voluptatibus.",
      "Deleted": false,
      "Rank": 557,
      "Type": "quo",
      "ColorBlock": 734,
      "IconHint": "voluptates",
      "Selected": false,
      "LastChanged": "2011-06-16T17:54:08.2887055+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "accusantium",
      "StyleHint": "excepturi",
      "Hidden": true,
      "FullName": "Columbus Bergnaum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 399
        }
      }
    }
  ],
  "PersonNumber": "1105538",
  "FullName": "Milo Smitham",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "hic",
      "StrippedValue": "et",
      "Description": "Customizable tertiary customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "et",
      "Description": "Customizable tertiary customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    }
  ],
  "FormalName": "Christiansen-Denesik",
  "Address": null,
  "Post3": "dignissimos",
  "Post2": "adipisci",
  "Post1": "consequatur",
  "Kanalname": "aut",
  "Kanafname": "aspernatur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ipsa",
  "ActiveInterests": 866,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 866,
  "DbiKey": "qui",
  "DbiLastModified": "2008-06-01T17:54:08.2887055+02:00",
  "DbiLastSyncronized": "2024-08-12T17:54:08.2887055+02:00",
  "SentInfo": 317,
  "ShowContactTickets": 292,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "porro",
      "StrippedValue": "iste",
      "Description": "Horizontal multimedia focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 399
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "iste",
      "Description": "Horizontal multimedia focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 399
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "inventore",
      "StrippedValue": "rerum",
      "Description": "Right-sized client-server encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 992
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "rerum",
      "Description": "Right-sized client-server encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 992
        }
      }
    }
  ],
  "Source": 674,
  "ActiveErpLinks": 204,
  "ShipmentTypes": [
    {
      "Id": 839,
      "Name": "Ledner, Durgan and Ondricka",
      "ToolTip": "Numquam aut incidunt sint et.",
      "Deleted": false,
      "Rank": 519,
      "Type": "assumenda",
      "ColorBlock": 400,
      "IconHint": "qui",
      "Selected": false,
      "LastChanged": "2012-05-30T17:54:08.2887055+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "animi",
      "StyleHint": "facilis",
      "Hidden": true,
      "FullName": "Mrs. Merlin Zoe Hegmann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 285
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 438,
      "Comment": "fuga",
      "Registered": "2002-12-03T17:54:08.2887055+01:00",
      "RegisteredAssociateId": 395,
      "Updated": "2007-01-22T17:54:08.2887055+01:00",
      "UpdatedAssociateId": 106,
      "LegalBaseId": 77,
      "LegalBaseKey": "harum",
      "LegalBaseName": "Sanford, Flatley and Metz",
      "ConsentPurposeId": 609,
      "ConsentPurposeKey": "qui",
      "ConsentPurposeName": "Dickens Inc and Sons",
      "ConsentSourceId": 766,
      "ConsentSourceKey": "animi",
      "ConsentSourceName": "Lubowitz-Gleason",
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
  "BounceEmails": [
    "eryn@nolan.uk",
    "marc_wolf@krajcikblick.uk"
  ],
  "ActiveStatusMonitorId": 385,
  "CreatedByFormId": 36,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Prof. Jaquelin Webster Hoeger Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "soluta",
    "CustomFields2": "repudiandae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 119
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```