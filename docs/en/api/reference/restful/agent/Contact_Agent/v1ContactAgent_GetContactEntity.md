---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=741
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 587,
  "Name": "Bashirian, Kutch and Larkin",
  "Department": "",
  "OrgNr": "950825",
  "Number1": "396766",
  "Number2": "837795",
  "UpdatedDate": "2023-05-31T14:32:02.2961659+02:00",
  "CreatedDate": "2018-11-03T14:32:02.2961659+01:00",
  "Emails": [
    {
      "Value": "ea",
      "StrippedValue": "sed",
      "Description": "Up-sized motivating solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 395
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "sed",
      "Description": "Up-sized motivating solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 395
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 954,
      "Name": "Ritchie, Daugherty and Borer",
      "ToolTip": "Praesentium reprehenderit praesentium ullam nesciunt qui.",
      "Deleted": false,
      "Rank": 870,
      "Type": "laudantium",
      "ColorBlock": 147,
      "IconHint": "autem",
      "Selected": false,
      "LastChanged": "2021-03-20T14:32:02.2961659+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "ab",
      "Hidden": true,
      "FullName": "Maryjane Kerluke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 226
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vero",
      "StrippedValue": "vel",
      "Description": "Public-key multi-state forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 437
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "vel",
      "Description": "Public-key multi-state forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 437
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ut",
      "StrippedValue": "facilis",
      "Description": "Managed regional pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 519
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "facilis",
      "Description": "Managed regional pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 519
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "magnam",
      "StrippedValue": "odio",
      "Description": "Advanced explicit emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "odio",
      "Description": "Advanced explicit emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    }
  ],
  "Description": "Persistent scalable moratorium",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ex",
      "PersonId": 919,
      "Mrmrs": "sed",
      "Firstname": "Diana",
      "Lastname": "Gutkowski",
      "MiddleName": "Schmidt-Huel",
      "Title": "expedita",
      "Description": "Compatible reciprocal matrix",
      "Email": "roberto.maggio@goyette.info",
      "FullName": "Reba Balistreri Jr.",
      "DirectPhone": "1-926-822-9181",
      "FormalName": "Schowalter, Haley and Pfeffer",
      "CountryId": 759,
      "ContactId": 941,
      "ContactName": "Hand Inc and Sons",
      "Retired": 451,
      "Rank": 280,
      "ActiveInterests": 827,
      "ContactDepartment": "",
      "ContactCountryId": 844,
      "ContactOrgNr": "816409",
      "FaxPhone": "845.561.5456",
      "MobilePhone": "(769)195-7987",
      "ContactPhone": "(074)386-2747",
      "AssociateName": "Batz Group",
      "AssociateId": 194,
      "UsePersonAddress": false,
      "ContactFax": "consequatur",
      "Kanafname": "occaecati",
      "Kanalname": "autem",
      "Post1": "magnam",
      "Post2": "laudantium",
      "Post3": "eius",
      "EmailName": "glenna.lebsack@kulas.uk",
      "ContactFullName": "Tom Green",
      "ActiveErpLinks": 760,
      "TicketPriorityId": 862,
      "SupportLanguageId": 863,
      "SupportAssociateId": 879,
      "CategoryName": "VIP Customer",
      "PersonNumber": "909401",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 498
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "est",
  "Xstop": true,
  "ActiveInterests": 410,
  "GroupId": 992,
  "ActiveStatusMonitorId": 529,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 705,
  "DbiAgentId": 863,
  "DbiLastSyncronized": "2020-03-16T14:32:02.2961659+01:00",
  "DbiKey": "alias",
  "DbiLastModified": "2012-01-14T14:32:02.2961659+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 978,
  "ActiveErpLinks": 334,
  "BounceEmails": [
    "hayden@homenickkuhn.com",
    "gladys.moen@cummings.info"
  ],
  "Domains": [
    "omnis",
    "autem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Jordan Moshe Osinski DDS",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "quis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 976
    }
  }
}
```