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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 691,
  "Firstname": "Harvey",
  "MiddleName": "Bogan LLC",
  "Lastname": "Rodriguez",
  "Mrmrs": "sed",
  "Title": "officiis",
  "UpdatedDate": "2022-10-23T12:01:32.9488139+02:00",
  "CreatedDate": "2009-10-05T12:01:32.9488139+02:00",
  "BirthDate": "2006-02-14T12:01:32.9488139+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "earum",
      "Description": "Centralized zero tolerance matrices"
    },
    {
      "Value": "est",
      "StrippedValue": "earum",
      "Description": "Centralized zero tolerance matrices"
    }
  ],
  "Description": "Object-based object-oriented alliance",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "iste",
      "StrippedValue": "et",
      "Description": "Extended needs-based encryption"
    },
    {
      "Value": "iste",
      "StrippedValue": "et",
      "Description": "Extended needs-based encryption"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "dolorum",
      "Description": "Automated incremental strategy"
    },
    {
      "Value": "et",
      "StrippedValue": "dolorum",
      "Description": "Automated incremental strategy"
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolores",
      "StrippedValue": "enim",
      "Description": "Programmable optimal interface"
    },
    {
      "Value": "dolores",
      "StrippedValue": "enim",
      "Description": "Programmable optimal interface"
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "iure",
      "Description": "Versatile web-enabled strategy"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "iure",
      "Description": "Versatile web-enabled strategy"
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "occaecati",
      "Description": "Re-contextualized tangible monitoring"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "occaecati",
      "Description": "Re-contextualized tangible monitoring"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 417,
      "Name": "Christiansen-Kuhlman",
      "ToolTip": "Nemo enim cum et autem in perferendis.",
      "Deleted": false,
      "Rank": 337,
      "Type": "quis",
      "ColorBlock": 2,
      "IconHint": "quas",
      "Selected": true,
      "LastChanged": "2001-09-18T12:01:32.9488139+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "illum",
      "Hidden": true,
      "FullName": "Jarrell Kemmer"
    }
  ],
  "PersonNumber": "740247",
  "FullName": "Katelynn Pfeffer",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "ab",
      "StrippedValue": "nobis",
      "Description": "Inverse actuating paradigm"
    },
    {
      "Value": "ab",
      "StrippedValue": "nobis",
      "Description": "Inverse actuating paradigm"
    }
  ],
  "FormalName": "Kessler Inc and Sons",
  "Address": null,
  "Post3": "quia",
  "Post2": "maxime",
  "Post1": "vel",
  "Kanalname": "nobis",
  "Kanafname": "laborum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "omnis",
  "ActiveInterests": 634,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 494,
  "DbiKey": "sapiente",
  "DbiLastModified": "2004-12-21T12:01:32.9488139+01:00",
  "DbiLastSyncronized": "2010-08-09T12:01:32.9488139+02:00",
  "SentInfo": 5,
  "ShowContactTickets": 392,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "rerum",
      "StrippedValue": "recusandae",
      "Description": "Exclusive intangible Graphical User Interface"
    },
    {
      "Value": "rerum",
      "StrippedValue": "recusandae",
      "Description": "Exclusive intangible Graphical User Interface"
    }
  ],
  "InternetPhones": [
    {
      "Value": "ducimus",
      "StrippedValue": "vel",
      "Description": "Persevering heuristic protocol"
    },
    {
      "Value": "ducimus",
      "StrippedValue": "vel",
      "Description": "Persevering heuristic protocol"
    }
  ],
  "Source": 418,
  "ActiveErpLinks": 882,
  "ShipmentTypes": [
    {
      "Id": 84,
      "Name": "Ondricka-Goldner",
      "ToolTip": "Temporibus expedita odio.",
      "Deleted": true,
      "Rank": 267,
      "Type": "accusantium",
      "ColorBlock": 540,
      "IconHint": "neque",
      "Selected": true,
      "LastChanged": "2024-02-23T12:01:32.96444+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "a",
      "StyleHint": "temporibus",
      "Hidden": false,
      "FullName": "August Jenkins"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 373,
      "Comment": "autem",
      "Registered": "2004-03-28T12:01:32.96444+02:00",
      "RegisteredAssociateId": 211,
      "Updated": "2000-09-15T12:01:32.96444+02:00",
      "UpdatedAssociateId": 482,
      "LegalBaseId": 102,
      "LegalBaseKey": "porro",
      "LegalBaseName": "Swift Group",
      "ConsentPurposeId": 745,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "O'Connell, Kling and Haley",
      "ConsentSourceId": 306,
      "ConsentSourceKey": "autem",
      "ConsentSourceName": "Bradtke-Keebler"
    }
  ],
  "BounceEmails": [
    "anabel.hermiston@casper.co.uk",
    "jabari@okeefe.uk"
  ],
  "ActiveStatusMonitorId": 776,
  "CreatedByFormId": 988,
  "UserDefinedFields": {
    "SuperOffice:1": "Renee Hamill",
    "SuperOffice:2": "43918984"
  },
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "dolorem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 199,
  "Firstname": "Deondre",
  "MiddleName": "Schultz-Gutmann",
  "Lastname": "Lakin",
  "Mrmrs": "ab",
  "Title": "temporibus",
  "UpdatedDate": "2017-02-20T12:01:32.96444+01:00",
  "CreatedDate": "2004-05-10T12:01:32.96444+02:00",
  "BirthDate": "2024-06-08T12:01:32.96444+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "adipisci",
      "StrippedValue": "reiciendis",
      "Description": "Reactive eco-centric capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 406
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "reiciendis",
      "Description": "Reactive eco-centric capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 406
        }
      }
    }
  ],
  "Description": "Open-source methodical time-frame",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dolore",
      "StrippedValue": "accusamus",
      "Description": "Synchronised bottom-line access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 505
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "accusamus",
      "Description": "Synchronised bottom-line access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 505
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "accusantium",
      "StrippedValue": "ipsam",
      "Description": "Distributed clear-thinking budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 390
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "ipsam",
      "Description": "Distributed clear-thinking budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 390
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "eligendi",
      "StrippedValue": "et",
      "Description": "Implemented incremental info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 674
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "et",
      "Description": "Implemented incremental info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 674
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "soluta",
      "Description": "User-centric reciprocal task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 141
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "soluta",
      "Description": "User-centric reciprocal task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 141
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ut",
      "StrippedValue": "quia",
      "Description": "Customizable zero tolerance monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "quia",
      "Description": "Customizable zero tolerance monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
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
      "Id": 508,
      "Name": "Hirthe, Glover and Mante",
      "ToolTip": "Rem voluptate id rem porro nam quos quaerat.",
      "Deleted": true,
      "Rank": 39,
      "Type": "quo",
      "ColorBlock": 269,
      "IconHint": "ratione",
      "Selected": false,
      "LastChanged": "2022-06-08T12:01:32.96444+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "debitis",
      "StyleHint": "minus",
      "Hidden": false,
      "FullName": "Prof. Rod Ward",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 314
        }
      }
    }
  ],
  "PersonNumber": "1565158",
  "FullName": "Brennan Ruecker",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "id",
      "Description": "Ergonomic clear-thinking success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "id",
      "Description": "Ergonomic clear-thinking success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    }
  ],
  "FormalName": "Hudson-Nader",
  "Address": null,
  "Post3": "reprehenderit",
  "Post2": "sapiente",
  "Post1": "cupiditate",
  "Kanalname": "doloribus",
  "Kanafname": "temporibus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "assumenda",
  "ActiveInterests": 569,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 914,
  "DbiKey": "vel",
  "DbiLastModified": "2023-01-11T12:01:32.96444+01:00",
  "DbiLastSyncronized": "2006-02-08T12:01:32.96444+01:00",
  "SentInfo": 436,
  "ShowContactTickets": 102,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Virtual non-volatile policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Virtual non-volatile policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quibusdam",
      "StrippedValue": "iusto",
      "Description": "Integrated zero administration productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 151
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "iusto",
      "Description": "Integrated zero administration productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 151
        }
      }
    }
  ],
  "Source": 88,
  "ActiveErpLinks": 737,
  "ShipmentTypes": [
    {
      "Id": 993,
      "Name": "Kub, Casper and Morar",
      "ToolTip": "Ipsa est placeat assumenda.",
      "Deleted": true,
      "Rank": 572,
      "Type": "consequatur",
      "ColorBlock": 88,
      "IconHint": "illum",
      "Selected": false,
      "LastChanged": "2020-11-07T12:01:32.96444+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "rem",
      "Hidden": true,
      "FullName": "Rebeka Gerlach I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 892
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 885,
      "Comment": "perferendis",
      "Registered": "2008-07-20T12:01:32.96444+02:00",
      "RegisteredAssociateId": 735,
      "Updated": "2006-07-25T12:01:32.96444+02:00",
      "UpdatedAssociateId": 601,
      "LegalBaseId": 758,
      "LegalBaseKey": "corrupti",
      "LegalBaseName": "Heller LLC",
      "ConsentPurposeId": 197,
      "ConsentPurposeKey": "porro",
      "ConsentPurposeName": "Kulas-Hartmann",
      "ConsentSourceId": 900,
      "ConsentSourceKey": "voluptate",
      "ConsentSourceName": "Koss LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 283
        }
      }
    }
  ],
  "BounceEmails": [
    "savanah.keebler@kihn.uk",
    "yasmine@reichel.name"
  ],
  "ActiveStatusMonitorId": 341,
  "CreatedByFormId": 160,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Baylee Ruth Connelly III",
    "SuperOffice:2": "Toy Nicolas"
  },
  "ExtraFields": {
    "ExtraFields1": "laudantium",
    "ExtraFields2": "nam"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 636
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```