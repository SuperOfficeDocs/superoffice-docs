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

## Response

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 301,
  "Firstname": "Lynn",
  "MiddleName": "Hartmann-Trantow",
  "Lastname": "Murazik",
  "Mrmrs": "ut",
  "Title": "ab",
  "UpdatedDate": "2016-02-05T11:10:52.9401433+01:00",
  "CreatedDate": "2009-01-22T11:10:52.9401433+01:00",
  "BirthDate": "2004-10-22T11:10:52.9401433+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "possimus",
      "StrippedValue": "qui",
      "Description": "Reactive impactful hierarchy"
    },
    {
      "Value": "possimus",
      "StrippedValue": "qui",
      "Description": "Reactive impactful hierarchy"
    }
  ],
  "Description": "Adaptive asynchronous implementation",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "consectetur",
      "StrippedValue": "nisi",
      "Description": "Synergistic next generation throughput"
    },
    {
      "Value": "consectetur",
      "StrippedValue": "nisi",
      "Description": "Synergistic next generation throughput"
    }
  ],
  "Faxes": [
    {
      "Value": "amet",
      "StrippedValue": "voluptas",
      "Description": "Fully-configurable local Graphical User Interface"
    },
    {
      "Value": "amet",
      "StrippedValue": "voluptas",
      "Description": "Fully-configurable local Graphical User Interface"
    }
  ],
  "MobilePhones": [
    {
      "Value": "repellat",
      "StrippedValue": "quas",
      "Description": "Devolved tertiary productivity"
    },
    {
      "Value": "repellat",
      "StrippedValue": "quas",
      "Description": "Devolved tertiary productivity"
    }
  ],
  "OfficePhones": [
    {
      "Value": "rem",
      "StrippedValue": "perferendis",
      "Description": "Up-sized grid-enabled solution"
    },
    {
      "Value": "rem",
      "StrippedValue": "perferendis",
      "Description": "Up-sized grid-enabled solution"
    }
  ],
  "OtherPhones": [
    {
      "Value": "aperiam",
      "StrippedValue": "cupiditate",
      "Description": "Open-source 5th generation policy"
    },
    {
      "Value": "aperiam",
      "StrippedValue": "cupiditate",
      "Description": "Open-source 5th generation policy"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 315,
      "Name": "Brakus, Prohaska and Murphy",
      "ToolTip": "Provident at ipsum veritatis quia enim.",
      "Deleted": true,
      "Rank": 606,
      "Type": "sunt",
      "ColorBlock": 33,
      "IconHint": "natus",
      "Selected": true,
      "LastChanged": "2004-10-26T11:10:52.9421769+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "nostrum",
      "Hidden": false,
      "FullName": "Mr. Pattie Gottlieb"
    }
  ],
  "PersonNumber": "1316823",
  "FullName": "Travis Champlin",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "tempora",
      "StrippedValue": "at",
      "Description": "Vision-oriented encompassing hardware"
    },
    {
      "Value": "tempora",
      "StrippedValue": "at",
      "Description": "Vision-oriented encompassing hardware"
    }
  ],
  "FormalName": "Bode, Hackett and Blanda",
  "Address": null,
  "Post3": "consequatur",
  "Post2": "nisi",
  "Post1": "praesentium",
  "Kanalname": "sit",
  "Kanafname": "eum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "maxime",
  "ActiveInterests": 258,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 291,
  "DbiKey": "consequatur",
  "DbiLastModified": "2013-07-19T11:10:52.9451749+02:00",
  "DbiLastSyncronized": "2018-08-22T11:10:52.9451749+02:00",
  "SentInfo": 731,
  "ShowContactTickets": 851,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quis",
      "StrippedValue": "tempora",
      "Description": "Vision-oriented optimal policy"
    },
    {
      "Value": "quis",
      "StrippedValue": "tempora",
      "Description": "Vision-oriented optimal policy"
    }
  ],
  "InternetPhones": [
    {
      "Value": "sunt",
      "StrippedValue": "ipsa",
      "Description": "Adaptive zero tolerance service-desk"
    },
    {
      "Value": "sunt",
      "StrippedValue": "ipsa",
      "Description": "Adaptive zero tolerance service-desk"
    }
  ],
  "Source": 426,
  "ActiveErpLinks": 42,
  "ShipmentTypes": [
    {
      "Id": 311,
      "Name": "Homenick, Spencer and Mraz",
      "ToolTip": "Velit sunt nemo consequatur.",
      "Deleted": false,
      "Rank": 770,
      "Type": "et",
      "ColorBlock": 168,
      "IconHint": "quaerat",
      "Selected": false,
      "LastChanged": "2020-08-17T11:10:52.9451749+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consectetur",
      "StyleHint": "explicabo",
      "Hidden": false,
      "FullName": "Julian Dach"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 497,
      "Comment": "animi",
      "Registered": "2009-01-17T11:10:52.9451749+01:00",
      "RegisteredAssociateId": 336,
      "Updated": "2014-03-16T11:10:52.9451749+01:00",
      "UpdatedAssociateId": 645,
      "LegalBaseId": 804,
      "LegalBaseKey": "quia",
      "LegalBaseName": "Gusikowski, Paucek and Thompson",
      "ConsentPurposeId": 949,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Botsford, Dicki and Koch",
      "ConsentSourceId": 770,
      "ConsentSourceKey": "ut",
      "ConsentSourceName": "Marquardt-Stokes"
    }
  ],
  "BounceEmails": [
    "stefanie@okon.com",
    "kira@moen.info"
  ],
  "ActiveStatusMonitorId": 244,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Ms. Lue Tomasa Jacobi"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "cumque",
    "CustomFields2": "sequi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 932,
  "Firstname": "Germaine",
  "MiddleName": "Grant-Lehner",
  "Lastname": "White",
  "Mrmrs": "vel",
  "Title": "dolor",
  "UpdatedDate": "2009-07-08T11:10:52.9541741+02:00",
  "CreatedDate": "2012-03-20T11:10:52.9541741+01:00",
  "BirthDate": "2010-02-15T11:10:52.9541741+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "doloribus",
      "Description": "Face to face bifurcated budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 596
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "doloribus",
      "Description": "Face to face bifurcated budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 596
        }
      }
    }
  ],
  "Description": "Programmable web-enabled database",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "itaque",
      "StrippedValue": "hic",
      "Description": "Streamlined upward-trending database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 807
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "hic",
      "Description": "Streamlined upward-trending database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 807
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "quo",
      "Description": "Polarised human-resource parallelism",
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
      "Value": "quia",
      "StrippedValue": "quo",
      "Description": "Polarised human-resource parallelism",
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
  "MobilePhones": [
    {
      "Value": "tempora",
      "StrippedValue": "hic",
      "Description": "Vision-oriented demand-driven extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 281
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "hic",
      "Description": "Vision-oriented demand-driven extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 281
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "excepturi",
      "StrippedValue": "doloribus",
      "Description": "Expanded upward-trending benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "doloribus",
      "Description": "Expanded upward-trending benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "vero",
      "StrippedValue": "et",
      "Description": "Secured bandwidth-monitored throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 864
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "et",
      "Description": "Secured bandwidth-monitored throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 864
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
      "Id": 505,
      "Name": "Jacobs-Connelly",
      "ToolTip": "Quas repellendus est optio.",
      "Deleted": false,
      "Rank": 671,
      "Type": "eligendi",
      "ColorBlock": 995,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2016-06-21T11:10:52.9571474+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ratione",
      "StyleHint": "eum",
      "Hidden": false,
      "FullName": "Mr. Joanie Keenan Davis Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 337
        }
      }
    }
  ],
  "PersonNumber": "1108902",
  "FullName": "Sadye Kuhn Jr.",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "sint",
      "Description": "Synergized asynchronous capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 189
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "sint",
      "Description": "Synergized asynchronous capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 189
        }
      }
    }
  ],
  "FormalName": "Smitham, Mills and Runte",
  "Address": null,
  "Post3": "est",
  "Post2": "illo",
  "Post1": "quidem",
  "Kanalname": "est",
  "Kanafname": "excepturi",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sit",
  "ActiveInterests": 874,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 862,
  "DbiKey": "inventore",
  "DbiLastModified": "2011-05-02T11:10:52.9601794+02:00",
  "DbiLastSyncronized": "2003-08-06T11:10:52.9601794+02:00",
  "SentInfo": 858,
  "ShowContactTickets": 781,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "tempora",
      "StrippedValue": "iste",
      "Description": "Universal methodical flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 359
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "iste",
      "Description": "Universal methodical flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 359
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "est",
      "Description": "Optimized methodical data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 807
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "est",
      "Description": "Optimized methodical data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 807
        }
      }
    }
  ],
  "Source": 596,
  "ActiveErpLinks": 524,
  "ShipmentTypes": [
    {
      "Id": 393,
      "Name": "Hand-O'Reilly",
      "ToolTip": "Est in itaque sunt.",
      "Deleted": false,
      "Rank": 190,
      "Type": "suscipit",
      "ColorBlock": 839,
      "IconHint": "id",
      "Selected": false,
      "LastChanged": "1999-10-23T11:10:52.9611799+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quae",
      "StyleHint": "repudiandae",
      "Hidden": false,
      "FullName": "Lela Von",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 694
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 344,
      "Comment": "est",
      "Registered": "2018-02-14T11:10:52.9611799+01:00",
      "RegisteredAssociateId": 65,
      "Updated": "2000-02-25T11:10:52.9611799+01:00",
      "UpdatedAssociateId": 323,
      "LegalBaseId": 847,
      "LegalBaseKey": "voluptatem",
      "LegalBaseName": "Harber, Streich and Rohan",
      "ConsentPurposeId": 279,
      "ConsentPurposeKey": "vitae",
      "ConsentPurposeName": "Franecki, Zboncak and Armstrong",
      "ConsentSourceId": 192,
      "ConsentSourceKey": "aut",
      "ConsentSourceName": "Johnston, Grady and Kiehn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 247
        }
      }
    }
  ],
  "BounceEmails": [
    "rex@cartwright.biz",
    "marcelo@tromp.us"
  ],
  "ActiveStatusMonitorId": 760,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Andreanne Waelchi",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 19
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
