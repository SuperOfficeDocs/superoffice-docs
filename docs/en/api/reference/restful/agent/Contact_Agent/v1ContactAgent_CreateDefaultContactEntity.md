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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 684,
  "Name": "Rau-Feest",
  "Department": "",
  "OrgNr": "1289476",
  "Number1": "1358852",
  "Number2": "1251189",
  "UpdatedDate": "2001-03-09T04:02:01.4248943+01:00",
  "CreatedDate": "2020-07-31T04:02:01.4248943+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "sapiente",
      "Description": "Realigned upward-trending throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "sapiente",
      "Description": "Realigned upward-trending throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 72,
      "Name": "Schumm, Carter and Dicki",
      "ToolTip": "In deserunt.",
      "Deleted": false,
      "Rank": 111,
      "Type": "sed",
      "ColorBlock": 227,
      "IconHint": "eum",
      "Selected": false,
      "LastChanged": "2002-12-12T04:02:01.4248943+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "impedit",
      "Hidden": false,
      "FullName": "Mrs. Adolf Federico Wyman MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolores",
      "StrippedValue": "consequuntur",
      "Description": "Secured homogeneous groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 878
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "consequuntur",
      "Description": "Secured homogeneous groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 878
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quaerat",
      "StrippedValue": "repellat",
      "Description": "Grass-roots intangible pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 999
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "repellat",
      "Description": "Grass-roots intangible pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 999
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "itaque",
      "StrippedValue": "doloremque",
      "Description": "Front-line background standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "doloremque",
      "Description": "Front-line background standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    }
  ],
  "Description": "Proactive optimizing toolset",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "harum",
      "PersonId": 1001,
      "Mrmrs": "dolorem",
      "Firstname": "Diego",
      "Lastname": "Towne",
      "MiddleName": "Maggio, Bednar and Gaylord",
      "Title": "laudantium",
      "Description": "Diverse bi-directional hardware",
      "Email": "allene@bode.uk",
      "FullName": "Eveline Tromp",
      "DirectPhone": "1-429-714-5015",
      "FormalName": "Senger, Gislason and Lynch",
      "CountryId": 164,
      "ContactId": 256,
      "ContactName": "Wolf, Renner and Fay",
      "Retired": 186,
      "Rank": 386,
      "ActiveInterests": 150,
      "ContactDepartment": "",
      "ContactCountryId": 706,
      "ContactOrgNr": "1080075",
      "FaxPhone": "808.255.9485 x17840",
      "MobilePhone": "(122)236-9838 x4509",
      "ContactPhone": "(848)044-9158 x9930",
      "AssociateName": "Quigley-Orn",
      "AssociateId": 268,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "sunt",
      "Kanalname": "sapiente",
      "Post1": "distinctio",
      "Post2": "consequatur",
      "Post3": "et",
      "EmailName": "marley@daughertydicki.biz",
      "ContactFullName": "Ross Mayer",
      "ActiveErpLinks": 96,
      "TicketPriorityId": 796,
      "SupportLanguageId": 350,
      "SupportAssociateId": 693,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "aut",
  "Xstop": false,
  "ActiveInterests": 338,
  "GroupId": 119,
  "ActiveStatusMonitorId": 934,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 504,
  "DbiAgentId": 801,
  "DbiLastSyncronized": "2018-09-10T04:02:01.4248943+02:00",
  "DbiKey": "impedit",
  "DbiLastModified": "2019-11-16T04:02:01.4248943+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 156,
  "ActiveErpLinks": 779,
  "BounceEmails": [
    "betty@schumm.ca",
    "edna.stoltenberg@braunemard.name"
  ],
  "Domains": [
    "aut",
    "at"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "2115194975",
    "SuperOffice:2": "Ms. Coby Bednar DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "officia",
    "ExtraFields2": "ullam"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "reprehenderit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 117
    }
  }
}
```