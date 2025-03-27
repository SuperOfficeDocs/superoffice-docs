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
  "PersonId": 959,
  "Firstname": "Adela",
  "MiddleName": "Christiansen, Dibbert and Toy",
  "Lastname": "Toy",
  "Mrmrs": "nihil",
  "Title": "quia",
  "UpdatedDate": "2019-06-05T02:38:26.1360573+02:00",
  "CreatedDate": "2020-02-21T02:38:26.1360573+01:00",
  "BirthDate": "1997-12-09T02:38:26.1360573+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "officiis",
      "StrippedValue": "ad",
      "Description": "Proactive bottom-line policy"
    },
    {
      "Value": "officiis",
      "StrippedValue": "ad",
      "Description": "Proactive bottom-line policy"
    }
  ],
  "Description": "Configurable exuding benchmark",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "vel",
      "StrippedValue": "corrupti",
      "Description": "Innovative heuristic implementation"
    },
    {
      "Value": "vel",
      "StrippedValue": "corrupti",
      "Description": "Innovative heuristic implementation"
    }
  ],
  "Faxes": [
    {
      "Value": "deleniti",
      "StrippedValue": "atque",
      "Description": "Exclusive multi-state architecture"
    },
    {
      "Value": "deleniti",
      "StrippedValue": "atque",
      "Description": "Exclusive multi-state architecture"
    }
  ],
  "MobilePhones": [
    {
      "Value": "sed",
      "StrippedValue": "voluptatem",
      "Description": "Persistent explicit secured line"
    },
    {
      "Value": "sed",
      "StrippedValue": "voluptatem",
      "Description": "Persistent explicit secured line"
    }
  ],
  "OfficePhones": [
    {
      "Value": "modi",
      "StrippedValue": "debitis",
      "Description": "Object-based scalable matrix"
    },
    {
      "Value": "modi",
      "StrippedValue": "debitis",
      "Description": "Object-based scalable matrix"
    }
  ],
  "OtherPhones": [
    {
      "Value": "labore",
      "StrippedValue": "eveniet",
      "Description": "Persistent transitional success"
    },
    {
      "Value": "labore",
      "StrippedValue": "eveniet",
      "Description": "Persistent transitional success"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 342,
      "Name": "Corwin-Rath",
      "ToolTip": "Non est rem error consequatur.",
      "Deleted": false,
      "Rank": 931,
      "Type": "et",
      "ColorBlock": 904,
      "IconHint": "totam",
      "Selected": false,
      "LastChanged": "2010-08-28T02:38:26.1360573+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minima",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Winston Bosco"
    }
  ],
  "PersonNumber": "1092611",
  "FullName": "Henderson Bahringer Jr.",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "ut",
      "Description": "Configurable system-worthy artificial intelligence"
    },
    {
      "Value": "sint",
      "StrippedValue": "ut",
      "Description": "Configurable system-worthy artificial intelligence"
    }
  ],
  "FormalName": "Dooley-Langworth",
  "Address": null,
  "Post3": "est",
  "Post2": "aut",
  "Post1": "ullam",
  "Kanalname": "minima",
  "Kanafname": "quas",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "doloremque",
  "ActiveInterests": 408,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 36,
  "DbiKey": "corporis",
  "DbiLastModified": "2019-08-07T02:38:26.1360573+02:00",
  "DbiLastSyncronized": "2021-12-05T02:38:26.1360573+01:00",
  "SentInfo": 709,
  "ShowContactTickets": 182,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "autem",
      "StrippedValue": "explicabo",
      "Description": "Sharable heuristic encryption"
    },
    {
      "Value": "autem",
      "StrippedValue": "explicabo",
      "Description": "Sharable heuristic encryption"
    }
  ],
  "InternetPhones": [
    {
      "Value": "expedita",
      "StrippedValue": "quaerat",
      "Description": "Secured reciprocal local area network"
    },
    {
      "Value": "expedita",
      "StrippedValue": "quaerat",
      "Description": "Secured reciprocal local area network"
    }
  ],
  "Source": 753,
  "ActiveErpLinks": 401,
  "ShipmentTypes": [
    {
      "Id": 234,
      "Name": "Walker-Marks",
      "ToolTip": "Eius quia rerum.",
      "Deleted": false,
      "Rank": 919,
      "Type": "placeat",
      "ColorBlock": 417,
      "IconHint": "fugit",
      "Selected": false,
      "LastChanged": "2011-03-23T02:38:26.1360573+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "facere",
      "StyleHint": "sunt",
      "Hidden": true,
      "FullName": "Ursula Dach"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 974,
      "Comment": "sit",
      "Registered": "2015-09-08T02:38:26.1360573+02:00",
      "RegisteredAssociateId": 6,
      "Updated": "2021-02-05T02:38:26.1360573+01:00",
      "UpdatedAssociateId": 173,
      "LegalBaseId": 964,
      "LegalBaseKey": "et",
      "LegalBaseName": "Metz Group",
      "ConsentPurposeId": 241,
      "ConsentPurposeKey": "ad",
      "ConsentPurposeName": "Herman-Herzog",
      "ConsentSourceId": 163,
      "ConsentSourceKey": "exercitationem",
      "ConsentSourceName": "Harber-Donnelly"
    }
  ],
  "BounceEmails": [
    "marco@parker.us",
    "nat@yost.info"
  ],
  "ActiveStatusMonitorId": 385,
  "CreatedByFormId": 112,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Isac Yost",
    "SuperOffice:2": "Mr. Laila Emmie Klein"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "eveniet",
    "CustomFields2": "tenetur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 380,
  "Firstname": "Kiara",
  "MiddleName": "Dooley-Jacobi",
  "Lastname": "Kulas",
  "Mrmrs": "ut",
  "Title": "vero",
  "UpdatedDate": "2024-08-07T02:38:26.1360573+02:00",
  "CreatedDate": "2009-07-03T02:38:26.1360573+02:00",
  "BirthDate": "2006-06-28T02:38:26.1360573+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "mollitia",
      "StrippedValue": "omnis",
      "Description": "Persistent 24/7 installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 865
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "omnis",
      "Description": "Persistent 24/7 installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 865
        }
      }
    }
  ],
  "Description": "Multi-lateral content-based array",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "tempore",
      "StrippedValue": "nostrum",
      "Description": "Persistent zero tolerance algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 231
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "nostrum",
      "Description": "Persistent zero tolerance algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 231
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "in",
      "StrippedValue": "fuga",
      "Description": "Advanced exuding open system",
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
      "Value": "in",
      "StrippedValue": "fuga",
      "Description": "Advanced exuding open system",
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
  "MobilePhones": [
    {
      "Value": "id",
      "StrippedValue": "qui",
      "Description": "Configurable 6th generation collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 414
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "qui",
      "Description": "Configurable 6th generation collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 414
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "et",
      "StrippedValue": "deleniti",
      "Description": "Visionary cohesive groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "deleniti",
      "Description": "Visionary cohesive groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "quia",
      "Description": "Right-sized 24/7 conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "quia",
      "Description": "Right-sized 24/7 conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
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
      "Id": 841,
      "Name": "King-Block",
      "ToolTip": "Consectetur quia error est.",
      "Deleted": true,
      "Rank": 876,
      "Type": "quasi",
      "ColorBlock": 516,
      "IconHint": "libero",
      "Selected": true,
      "LastChanged": "2002-05-10T02:38:26.1360573+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatibus",
      "StyleHint": "vero",
      "Hidden": false,
      "FullName": "Friedrich Streich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 820
        }
      }
    }
  ],
  "PersonNumber": "217394",
  "FullName": "Mrs. Rafael Morris Price Sr.",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "magnam",
      "Description": "Down-sized user-facing matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 764
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "magnam",
      "Description": "Down-sized user-facing matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 764
        }
      }
    }
  ],
  "FormalName": "Auer LLC",
  "Address": null,
  "Post3": "consequatur",
  "Post2": "fugit",
  "Post1": "dignissimos",
  "Kanalname": "sequi",
  "Kanafname": "assumenda",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "illum",
  "ActiveInterests": 255,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 241,
  "DbiKey": "dolor",
  "DbiLastModified": "2022-02-02T02:38:26.1360573+01:00",
  "DbiLastSyncronized": "2011-06-10T02:38:26.1360573+02:00",
  "SentInfo": 972,
  "ShowContactTickets": 462,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quia",
      "StrippedValue": "animi",
      "Description": "Visionary coherent forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 517
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "animi",
      "Description": "Visionary coherent forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 517
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "minus",
      "StrippedValue": "earum",
      "Description": "Operative hybrid protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "earum",
      "Description": "Operative hybrid protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    }
  ],
  "Source": 735,
  "ActiveErpLinks": 193,
  "ShipmentTypes": [
    {
      "Id": 955,
      "Name": "Wehner Inc and Sons",
      "ToolTip": "Quibusdam dolor sed iusto non delectus voluptas aliquam.",
      "Deleted": false,
      "Rank": 920,
      "Type": "aut",
      "ColorBlock": 929,
      "IconHint": "qui",
      "Selected": false,
      "LastChanged": "2007-06-25T02:38:26.1516781+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nisi",
      "StyleHint": "fugiat",
      "Hidden": true,
      "FullName": "Sheila Hessel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 485
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 850,
      "Comment": "repellendus",
      "Registered": "2007-11-25T02:38:26.1516781+01:00",
      "RegisteredAssociateId": 456,
      "Updated": "2006-11-24T02:38:26.1516781+01:00",
      "UpdatedAssociateId": 630,
      "LegalBaseId": 470,
      "LegalBaseKey": "qui",
      "LegalBaseName": "Considine-Dibbert",
      "ConsentPurposeId": 353,
      "ConsentPurposeKey": "dolorum",
      "ConsentPurposeName": "Lesch, Hegmann and Schmeler",
      "ConsentSourceId": 666,
      "ConsentSourceKey": "non",
      "ConsentSourceName": "Haley LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 430
        }
      }
    }
  ],
  "BounceEmails": [
    "ocie@prohaska.uk",
    "margarette_hane@breitenberg.ca"
  ],
  "ActiveStatusMonitorId": 281,
  "CreatedByFormId": 359,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Fabian Reyes Thompson PhD",
    "SuperOffice:2": "777367957"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "illum",
    "CustomFields2": "vero"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 727
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```