---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 215,
  "Name": "Jenkins Group",
  "Department": "",
  "OrgNr": "1363405",
  "Number1": "405717",
  "Number2": "1458585",
  "UpdatedDate": "2019-10-30T16:00:40.3362702+01:00",
  "CreatedDate": "2021-08-20T16:00:40.3362702+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "neque",
      "Description": "Decentralized 24/7 open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 388
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "neque",
      "Description": "Decentralized 24/7 open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 388
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 629,
      "Name": "Friesen Inc and Sons",
      "ToolTip": "Aliquam qui ullam laboriosam consequatur et dolore tenetur.",
      "Deleted": true,
      "Rank": 706,
      "Type": "beatae",
      "ColorBlock": 466,
      "IconHint": "dicta",
      "Selected": false,
      "LastChanged": "1997-05-11T16:00:40.3362702+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quaerat",
      "StyleHint": "voluptatum",
      "Hidden": false,
      "FullName": "Dejah Koss II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 6
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "earum",
      "Description": "Synchronised didactic leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 777
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "earum",
      "Description": "Synchronised didactic leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 777
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "porro",
      "StrippedValue": "occaecati",
      "Description": "Horizontal foreground toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 449
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "occaecati",
      "Description": "Horizontal foreground toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 449
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "ea",
      "Description": "Cross-group mission-critical analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 354
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ea",
      "Description": "Cross-group mission-critical analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 354
        }
      }
    }
  ],
  "Description": "Multi-layered client-driven synergy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "reiciendis",
      "PersonId": 722,
      "Mrmrs": "aspernatur",
      "Firstname": "Randal",
      "Lastname": "Tromp",
      "MiddleName": "Mosciski, Bartoletti and Adams",
      "Title": "error",
      "Description": "Right-sized assymetric frame",
      "Email": "marietta@hoppe.ca",
      "FullName": "Miss Reid Carter",
      "DirectPhone": "675-435-5615 x79842",
      "FormalName": "Durgan, Schmidt and Oberbrunner",
      "CountryId": 490,
      "ContactId": 639,
      "ContactName": "Price-Mraz",
      "Retired": 61,
      "Rank": 51,
      "ActiveInterests": 448,
      "ContactDepartment": "",
      "ContactCountryId": 604,
      "ContactOrgNr": "1671638",
      "FaxPhone": "1-476-048-2679",
      "MobilePhone": "209-577-8895",
      "ContactPhone": "380-173-3156",
      "AssociateName": "Waelchi LLC",
      "AssociateId": 673,
      "UsePersonAddress": false,
      "ContactFax": "necessitatibus",
      "Kanafname": "voluptas",
      "Kanalname": "placeat",
      "Post1": "odio",
      "Post2": "iusto",
      "Post3": "et",
      "EmailName": "colby@tillman.uk",
      "ContactFullName": "Joshua Keeling",
      "ActiveErpLinks": 435,
      "TicketPriorityId": 396,
      "SupportLanguageId": 899,
      "SupportAssociateId": 296,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "qui",
  "Xstop": true,
  "ActiveInterests": 624,
  "GroupId": 361,
  "ActiveStatusMonitorId": 62,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 224,
  "DbiAgentId": 614,
  "DbiLastSyncronized": "2012-11-17T16:00:40.3362702+01:00",
  "DbiKey": "quae",
  "DbiLastModified": "2012-02-26T16:00:40.3362702+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 677,
  "ActiveErpLinks": 398,
  "BounceEmails": [
    "raegan_connelly@vandervort.info",
    "rosamond@grant.ca"
  ],
  "Domains": [
    "soluta",
    "rerum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Arvid Howell",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "saepe",
    "CustomFields2": "dolorem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 744
    }
  }
}
```