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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 986,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 63,
  "Firstname": "Connie",
  "MiddleName": "Parisian-Wisozk",
  "Lastname": "Krajcik",
  "Mrmrs": "mollitia",
  "Title": "ex",
  "UpdatedDate": "2010-05-26T23:03:55.5316044+02:00",
  "CreatedDate": "2015-03-26T23:03:55.5316044+01:00",
  "BirthDate": "2023-02-02T23:03:55.5316044+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ipsa",
      "StrippedValue": "dolor",
      "Description": "Cross-group heuristic frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 795
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "dolor",
      "Description": "Cross-group heuristic frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 795
        }
      }
    }
  ],
  "Description": "Balanced client-server customer loyalty",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "nihil",
      "Description": "Synchronised dynamic attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "nihil",
      "Description": "Synchronised dynamic attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "molestias",
      "StrippedValue": "ut",
      "Description": "Universal background projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "ut",
      "Description": "Universal background projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "numquam",
      "StrippedValue": "deserunt",
      "Description": "De-engineered interactive forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 418
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "deserunt",
      "Description": "De-engineered interactive forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 418
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "deserunt",
      "StrippedValue": "ducimus",
      "Description": "Phased full-range Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "ducimus",
      "Description": "Phased full-range Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "deserunt",
      "Description": "Fully-configurable stable flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 405
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "deserunt",
      "Description": "Fully-configurable stable flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 405
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
      "Id": 820,
      "Name": "O'Reilly-Schmitt",
      "ToolTip": "Vitae cum officia quisquam voluptates.",
      "Deleted": false,
      "Rank": 389,
      "Type": "iste",
      "ColorBlock": 681,
      "IconHint": "eligendi",
      "Selected": false,
      "LastChanged": "1998-10-10T23:03:55.5351357+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "porro",
      "Hidden": false,
      "FullName": "Lambert Kub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 912
        }
      }
    }
  ],
  "PersonNumber": "1450905",
  "FullName": "Jazmyne Roderick Brakus Sr.",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "quasi",
      "Description": "Centralized responsive intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 83
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quasi",
      "Description": "Centralized responsive intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 83
        }
      }
    }
  ],
  "FormalName": "Altenwerth Group",
  "Address": null,
  "Post3": "eligendi",
  "Post2": "expedita",
  "Post1": "minima",
  "Kanalname": "sint",
  "Kanafname": "dolores",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ipsa",
  "ActiveInterests": 319,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 89,
  "DbiKey": "id",
  "DbiLastModified": "2002-10-22T23:03:55.5376321+02:00",
  "DbiLastSyncronized": "2002-11-14T23:03:55.5376321+01:00",
  "SentInfo": 446,
  "ShowContactTickets": 54,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "natus",
      "StrippedValue": "dolor",
      "Description": "Secured national orchestration",
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
      "Value": "natus",
      "StrippedValue": "dolor",
      "Description": "Secured national orchestration",
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
  "InternetPhones": [
    {
      "Value": "sapiente",
      "StrippedValue": "sapiente",
      "Description": "Multi-lateral client-driven software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 929
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "sapiente",
      "Description": "Multi-lateral client-driven software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 929
        }
      }
    }
  ],
  "Source": 912,
  "ActiveErpLinks": 219,
  "ShipmentTypes": [
    {
      "Id": 10,
      "Name": "Hartmann, Reinger and Sauer",
      "ToolTip": "Adipisci cum excepturi quas ut.",
      "Deleted": false,
      "Rank": 86,
      "Type": "veritatis",
      "ColorBlock": 835,
      "IconHint": "quae",
      "Selected": false,
      "LastChanged": "2009-07-17T23:03:55.5386355+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "mollitia",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Austyn Kihn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 339
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 801,
      "Comment": "consequuntur",
      "Registered": "2008-10-31T23:03:55.5386355+01:00",
      "RegisteredAssociateId": 552,
      "Updated": "2004-07-22T23:03:55.5386355+02:00",
      "UpdatedAssociateId": 285,
      "LegalBaseId": 230,
      "LegalBaseKey": "dolor",
      "LegalBaseName": "Brown LLC",
      "ConsentPurposeId": 367,
      "ConsentPurposeKey": "quis",
      "ConsentPurposeName": "Gleason, Hilpert and Sauer",
      "ConsentSourceId": 849,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Luettgen Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 796
        }
      }
    }
  ],
  "BounceEmails": [
    "malachi.balistreri@wilkinson.name",
    "tyreek@block.biz"
  ],
  "ActiveStatusMonitorId": 344,
  "UserDefinedFields": {
    "SuperOffice:1": "691690718",
    "SuperOffice:2": "Vilma Sauer"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "doloremque"
  },
  "CustomFields": {
    "CustomFields1": "quaerat",
    "CustomFields2": "officiis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 308
    }
  }
}
```