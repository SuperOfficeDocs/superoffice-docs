---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.







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
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 24 Aug 2012 11:06:41 G8T

{
  "ContactId": 23,
  "Name": "Corwin-Monahan",
  "Department": "",
  "OrgNr": "1326420",
  "Number1": "777129",
  "Number2": "1533951",
  "UpdatedDate": "2012-08-24T11:06:41.5822408+02:00",
  "CreatedDate": "1997-01-02T11:06:41.5822408+01:00",
  "Emails": [
    {
      "Value": "laboriosam",
      "StrippedValue": "quos",
      "Description": "Switchable human-resource project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 108
        }
      }
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "quos",
      "Description": "Switchable human-resource project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 108
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 798,
      "Name": "Koss Group",
      "ToolTip": "Excepturi nisi et quia ea et sunt dolores.",
      "Deleted": false,
      "Rank": 338,
      "Type": "corrupti",
      "ColorBlock": 544,
      "IconHint": "expedita",
      "Selected": true,
      "LastChanged": "2018-11-15T11:06:41.5822408+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "asperiores",
      "StyleHint": "aspernatur",
      "Hidden": false,
      "FullName": "Alex Von",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 834
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "illo",
      "StrippedValue": "iste",
      "Description": "Persevering modular process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 224
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "iste",
      "Description": "Persevering modular process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 224
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "quia",
      "Description": "Cross-group responsive product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 597
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "quia",
      "Description": "Cross-group responsive product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 597
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "repellat",
      "StrippedValue": "quo",
      "Description": "Persistent impactful orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 834
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "quo",
      "Description": "Persistent impactful orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 834
        }
      }
    }
  ],
  "Description": "Function-based motivating protocol",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "fugit",
      "PersonId": 821,
      "Mrmrs": "itaque",
      "Firstname": "Devin",
      "Lastname": "Koepp",
      "MiddleName": "Roberts, Harvey and Block",
      "Title": "rerum",
      "Description": "Optional exuding hierarchy",
      "Email": "rene@blanda.co.uk",
      "FullName": "Prof. Luciano Spinka",
      "DirectPhone": "869-504-8531",
      "FormalName": "Turcotte Inc and Sons",
      "CountryId": 447,
      "ContactId": 941,
      "ContactName": "Feest Inc and Sons",
      "Retired": 137,
      "Rank": 293,
      "ActiveInterests": 629,
      "ContactDepartment": "incubate innovative communities",
      "ContactCountryId": 178,
      "ContactOrgNr": "1008754",
      "FaxPhone": "250.536.0445",
      "MobilePhone": "028-698-9207 x9912",
      "ContactPhone": "167-993-1024 x75170",
      "AssociateName": "Torp-Connelly",
      "AssociateId": 205,
      "UsePersonAddress": false,
      "ContactFax": "architecto",
      "Kanafname": "eaque",
      "Kanalname": "ipsam",
      "Post1": "placeat",
      "Post2": "corporis",
      "Post3": "officia",
      "EmailName": "kirsten@nader.com",
      "ContactFullName": "Madalyn Predovic",
      "ActiveErpLinks": 899,
      "TicketPriorityId": 87,
      "SupportLanguageId": 252,
      "SupportAssociateId": 552,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eveniet",
  "Xstop": false,
  "ActiveInterests": 384,
  "GroupId": 74,
  "ActiveStatusMonitorId": 151,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 789,
  "DbiAgentId": 243,
  "DbiLastSyncronized": "2013-01-29T11:06:41.5822408+01:00",
  "DbiKey": "officia",
  "DbiLastModified": "2007-01-09T11:06:41.5822408+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 639,
  "ActiveErpLinks": 375,
  "BounceEmails": [
    "chandler_braun@koss.ca",
    "mustafa@kuphal.co.uk"
  ],
  "Domains": [
    "perferendis",
    "vitae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dina Christiansen",
    "SuperOffice:2": "Kristian Schmitt"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatum",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "natus",
    "CustomFields2": "cum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 814
    }
  }
}
```