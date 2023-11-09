---
title: POST Agents/Person/CreateDefaultByContactId
uid: v1PersonAgent_CreateDefaultByContactId
generated: true
---

# POST Agents/Person/CreateDefaultByContactId

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId
```

Creates a PersonEntity with default values based on the contactId.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Person/CreateDefaultByContactId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 439
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 726,
  "Firstname": "Rosemary",
  "MiddleName": "Wolff Group",
  "Lastname": "Will",
  "Mrmrs": "sint",
  "Title": "pariatur",
  "UpdatedDate": "2020-06-14T11:06:35.0208116+02:00",
  "CreatedDate": "2002-06-07T11:06:35.0208116+02:00",
  "BirthDate": "2015-01-13T11:06:35.0208116+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quo",
      "StrippedValue": "rem",
      "Description": "Ameliorated dynamic project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 649
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "rem",
      "Description": "Ameliorated dynamic project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 649
        }
      }
    }
  ],
  "Description": "Sharable heuristic function",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "fuga",
      "StrippedValue": "quasi",
      "Description": "Robust bottom-line algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 523
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "quasi",
      "Description": "Robust bottom-line algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 523
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eius",
      "StrippedValue": "facilis",
      "Description": "Persistent bi-directional frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 171
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "facilis",
      "Description": "Persistent bi-directional frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 171
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "non",
      "StrippedValue": "reiciendis",
      "Description": "Future-proofed system-worthy productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "reiciendis",
      "Description": "Future-proofed system-worthy productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Innovative empowering info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 221
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Innovative empowering info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 221
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "recusandae",
      "StrippedValue": "dolorem",
      "Description": "Advanced zero administration complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 343
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "dolorem",
      "Description": "Advanced zero administration complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 343
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
      "Id": 726,
      "Name": "Fay LLC",
      "ToolTip": "Voluptatem autem voluptatem numquam ut praesentium doloribus ut.",
      "Deleted": true,
      "Rank": 302,
      "Type": "fugiat",
      "ColorBlock": 420,
      "IconHint": "velit",
      "Selected": true,
      "LastChanged": "2018-05-25T11:06:35.0208116+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Mr. Makenna Denesik",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 876
        }
      }
    }
  ],
  "PersonNumber": "140470",
  "FullName": "Randi Krajcik",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "sunt",
      "StrippedValue": "accusantium",
      "Description": "Grass-roots even-keeled Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 578
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "accusantium",
      "Description": "Grass-roots even-keeled Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 578
        }
      }
    }
  ],
  "FormalName": "Hamill, Funk and Emmerich",
  "Address": null,
  "Post3": "qui",
  "Post2": "fugiat",
  "Post1": "vitae",
  "Kanalname": "odio",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptatem",
  "ActiveInterests": 615,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 574,
  "DbiKey": "quo",
  "DbiLastModified": "2016-11-12T11:06:35.0208116+01:00",
  "DbiLastSyncronized": "2003-05-10T11:06:35.0208116+02:00",
  "SentInfo": 556,
  "ShowContactTickets": 583,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "inventore",
      "StrippedValue": "consequuntur",
      "Description": "Cross-group analyzing challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 575
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "consequuntur",
      "Description": "Cross-group analyzing challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 575
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "placeat",
      "StrippedValue": "pariatur",
      "Description": "Balanced fresh-thinking Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "pariatur",
      "Description": "Balanced fresh-thinking Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    }
  ],
  "Source": 153,
  "ActiveErpLinks": 449,
  "ShipmentTypes": [
    {
      "Id": 919,
      "Name": "Schowalter, Konopelski and Lowe",
      "ToolTip": "Nostrum quia blanditiis accusamus et aut labore.",
      "Deleted": false,
      "Rank": 476,
      "Type": "ipsam",
      "ColorBlock": 517,
      "IconHint": "laboriosam",
      "Selected": false,
      "LastChanged": "2015-06-24T11:06:35.0208116+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "expedita",
      "StyleHint": "dolorum",
      "Hidden": true,
      "FullName": "Geovanny Erdman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 414
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 300,
      "Comment": "facilis",
      "Registered": "1998-10-13T11:06:35.0208116+02:00",
      "RegisteredAssociateId": 104,
      "Updated": "2021-12-24T11:06:35.0208116+01:00",
      "UpdatedAssociateId": 932,
      "LegalBaseId": 430,
      "LegalBaseKey": "atque",
      "LegalBaseName": "Wehner, Konopelski and Spencer",
      "ConsentPurposeId": 704,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Lehner-Kerluke",
      "ConsentSourceId": 946,
      "ConsentSourceKey": "rerum",
      "ConsentSourceName": "Grant-Ward",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 468
        }
      }
    }
  ],
  "BounceEmails": [
    "earline.barton@carter.co.uk",
    "oran_batz@torp.name"
  ],
  "ActiveStatusMonitorId": 565,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Rita Kaley Kihn",
    "SuperOffice:2": "Mr. Ricky Kemmer V"
  },
  "ExtraFields": {
    "ExtraFields1": "porro",
    "ExtraFields2": "porro"
  },
  "CustomFields": {
    "CustomFields1": "aliquam",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 629
    }
  }
}
```