---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

### Response body: ContactEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 539
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 100,
  "Name": "Russel, Wolf and Stoltenberg",
  "Department": "",
  "OrgNr": "1009808",
  "Number1": "1399356",
  "Number2": "1115823",
  "UpdatedDate": "2021-09-09T13:28:22.257418+02:00",
  "CreatedDate": "2020-05-24T13:28:22.257418+02:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "magnam",
      "Description": "Cloned bi-directional groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 648
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "magnam",
      "Description": "Cloned bi-directional groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 648
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 867,
      "Name": "Herzog LLC",
      "ToolTip": "Iste alias magni consequatur sit.",
      "Deleted": false,
      "Rank": 600,
      "Type": "voluptas",
      "ColorBlock": 560,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2010-12-20T13:28:22.257418+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "reprehenderit",
      "StyleHint": "libero",
      "Hidden": true,
      "FullName": "Miss Alyson Mathilde Hammes",
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
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "perferendis",
      "Description": "Re-engineered demand-driven extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 507
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "perferendis",
      "Description": "Re-engineered demand-driven extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 507
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quis",
      "StrippedValue": "iste",
      "Description": "Exclusive disintermediate portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 735
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "iste",
      "Description": "Exclusive disintermediate portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 735
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "dolorem",
      "Description": "Integrated client-server orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "dolorem",
      "Description": "Integrated client-server orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    }
  ],
  "Description": "Right-sized 24 hour database",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "unde",
      "PersonId": 82,
      "Mrmrs": "enim",
      "Firstname": "Sasha",
      "Lastname": "Quitzon",
      "MiddleName": "Rice Group",
      "Title": "consequuntur",
      "Description": "Organic stable time-frame",
      "Email": "tess.herman@greenholthartmann.us",
      "FullName": "Jovany Abbott",
      "DirectPhone": "(845)544-7312 x767",
      "FormalName": "Monahan Inc and Sons",
      "CountryId": 750,
      "ContactId": 426,
      "ContactName": "Schaden-Swaniawski",
      "Retired": 63,
      "Rank": 840,
      "ActiveInterests": 525,
      "ContactDepartment": "",
      "ContactCountryId": 773,
      "ContactOrgNr": "949329",
      "FaxPhone": "1-158-048-5355 x28574",
      "MobilePhone": "(087)497-4433 x757",
      "ContactPhone": "(804)781-0527 x05375",
      "AssociateName": "Kertzmann LLC",
      "AssociateId": 483,
      "UsePersonAddress": false,
      "ContactFax": "ea",
      "Kanafname": "explicabo",
      "Kanalname": "corporis",
      "Post1": "alias",
      "Post2": "ab",
      "Post3": "veniam",
      "EmailName": "nannie@nitzschejones.ca",
      "ContactFullName": "Prof. Tyshawn Howe",
      "ActiveErpLinks": 680,
      "TicketPriorityId": 208,
      "SupportLanguageId": 124,
      "SupportAssociateId": 620,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 107
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sapiente",
  "Xstop": false,
  "ActiveInterests": 219,
  "GroupId": 54,
  "ActiveStatusMonitorId": 295,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 34,
  "DbiAgentId": 809,
  "DbiLastSyncronized": "2020-04-18T13:28:22.257418+02:00",
  "DbiKey": "voluptatibus",
  "DbiLastModified": "2000-10-26T13:28:22.257418+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 128,
  "ActiveErpLinks": 403,
  "BounceEmails": [
    "creola@pfeffer.biz",
    "cordelia@baumbachrodriguez.name"
  ],
  "Domains": [
    "quia",
    "optio"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Ms. Tomas Kuhic"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "ullam",
    "CustomFields2": "veritatis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 598
    }
  }
}
```