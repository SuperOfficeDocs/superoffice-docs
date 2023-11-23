---
title: POST Agents/Contact/AddPerson
uid: v1ContactAgent_AddPerson
generated: true
---

# POST Agents/Contact/AddPerson

```http
POST /api/v1/Agents/Contact/AddPerson
```

Add a person to the given contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/AddPerson?$select=name,department,category/id
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

## Request Body: request 

ContactId, NewPersonEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| NewPersonEntity | PersonEntity |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

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

## Sample request

```http!
POST /api/v1/Agents/Contact/AddPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 56,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 730,
  "Firstname": "Emma",
  "MiddleName": "Hahn, Will and Stoltenberg",
  "Lastname": "Grant",
  "Mrmrs": "id",
  "Title": "eius",
  "UpdatedDate": "2019-08-20T13:38:13.3583869+02:00",
  "CreatedDate": "1996-10-20T13:38:13.3583869+02:00",
  "BirthDate": "2022-04-06T13:38:13.3583869+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "esse",
      "StrippedValue": "impedit",
      "Description": "User-friendly eco-centric flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 288
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "impedit",
      "Description": "User-friendly eco-centric flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 288
        }
      }
    }
  ],
  "Description": "Multi-layered discrete policy",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "consequuntur",
      "StrippedValue": "ipsum",
      "Description": "Customizable global intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "ipsum",
      "Description": "Customizable global intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ipsa",
      "StrippedValue": "error",
      "Description": "Streamlined non-volatile strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 109
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "error",
      "Description": "Streamlined non-volatile strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 109
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quas",
      "StrippedValue": "est",
      "Description": "Robust web-enabled customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "est",
      "Description": "Robust web-enabled customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quia",
      "StrippedValue": "vero",
      "Description": "Universal fresh-thinking secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 625
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "vero",
      "Description": "Universal fresh-thinking secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 625
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "sit",
      "StrippedValue": "aut",
      "Description": "Total static matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 492
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "aut",
      "Description": "Total static matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 492
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
      "Id": 999,
      "Name": "Ullrich LLC",
      "ToolTip": "Suscipit explicabo.",
      "Deleted": false,
      "Rank": 412,
      "Type": "cupiditate",
      "ColorBlock": 546,
      "IconHint": "esse",
      "Selected": true,
      "LastChanged": "2009-12-01T13:38:13.3583869+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "excepturi",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Garland Priscilla Kemmer III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 386
        }
      }
    }
  ],
  "PersonNumber": "1006732",
  "FullName": "Mrs. Erica Hagenes I",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "commodi",
      "Description": "Multi-lateral bandwidth-monitored focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 26
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "commodi",
      "Description": "Multi-lateral bandwidth-monitored focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 26
        }
      }
    }
  ],
  "FormalName": "Kuvalis Group",
  "Address": null,
  "Post3": "est",
  "Post2": "similique",
  "Post1": "quae",
  "Kanalname": "quo",
  "Kanafname": "facilis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "nulla",
  "ActiveInterests": 37,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 145,
  "DbiKey": "qui",
  "DbiLastModified": "1998-10-09T13:38:13.3583869+02:00",
  "DbiLastSyncronized": "2012-01-18T13:38:13.3583869+01:00",
  "SentInfo": 781,
  "ShowContactTickets": 265,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "aperiam",
      "StrippedValue": "rerum",
      "Description": "Switchable upward-trending artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 921
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "rerum",
      "Description": "Switchable upward-trending artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 921
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "tempore",
      "StrippedValue": "autem",
      "Description": "Customizable high-level capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 410
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "autem",
      "Description": "Customizable high-level capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 410
        }
      }
    }
  ],
  "Source": 556,
  "ActiveErpLinks": 29,
  "ShipmentTypes": [
    {
      "Id": 686,
      "Name": "Zboncak, Lakin and Muller",
      "ToolTip": "Accusantium maxime omnis quis illo nobis vel deserunt.",
      "Deleted": true,
      "Rank": 553,
      "Type": "qui",
      "ColorBlock": 124,
      "IconHint": "voluptas",
      "Selected": true,
      "LastChanged": "2013-05-10T13:38:13.3583869+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "occaecati",
      "Hidden": false,
      "FullName": "Prof. Armand Consuelo Cronin DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 165
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 279,
      "Comment": "et",
      "Registered": "2011-03-18T13:38:13.3583869+01:00",
      "RegisteredAssociateId": 730,
      "Updated": "1998-08-16T13:38:13.3583869+02:00",
      "UpdatedAssociateId": 215,
      "LegalBaseId": 25,
      "LegalBaseKey": "veniam",
      "LegalBaseName": "Gislason Group",
      "ConsentPurposeId": 261,
      "ConsentPurposeKey": "aut",
      "ConsentPurposeName": "Swift, Wolf and Mueller",
      "ConsentSourceId": 653,
      "ConsentSourceKey": "illum",
      "ConsentSourceName": "Schmidt Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 485
        }
      }
    }
  ],
  "BounceEmails": [
    "genesis@langworthschaefer.uk",
    "westley@hegmann.info"
  ],
  "ActiveStatusMonitorId": 945,
  "UserDefinedFields": {
    "SuperOffice:1": "Adelia Emard",
    "SuperOffice:2": "Ms. Eldred Macejkovic"
  },
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "error"
  },
  "CustomFields": {
    "CustomFields1": "quos",
    "CustomFields2": "placeat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 833
    }
  }
}
```