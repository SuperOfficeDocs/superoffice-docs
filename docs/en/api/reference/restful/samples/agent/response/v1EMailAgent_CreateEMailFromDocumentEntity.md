```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 149,
      "ContactName": "Acme Corporation",
      "PersonId": 718,
      "PersonName": "John Anderson",
      "AssociateId": 639,
      "Address": "john.anderson@acmecorp.com",
      "EmailId": 37,
      "DuplicatePersonIds": [
        29,
        516
      ],
      "Name": "John Anderson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 817
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 246,
      "ContactName": "TechCorp Solutions",
      "PersonId": 483,
      "PersonName": "Sarah Johnson",
      "AssociateId": 31,
      "Address": "sarah.johnson@techcorp.com",
      "EmailId": 220,
      "DuplicatePersonIds": [
        644,
        127
      ],
      "Name": "Sarah Johnson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 643
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 258,
      "ContactName": "GlobalCorp Industries",
      "PersonId": 431,
      "PersonName": "Linda Chen",
      "AssociateId": 720,
      "Address": "linda.chen@globalcorp.com",
      "EmailId": 973,
      "DuplicatePersonIds": [
        915,
        596
      ],
      "Name": "Linda Chen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
        }
      }
    }
  ],
  "Subject": "Document Review - Service Agreement Draft",
  "HTMLBody": "<p>Hi John,</p><p>Please review the attached service agreement draft. I've incorporated the feedback from our last meeting.</p><p>Best,<br>Sarah</p>",
  "From": null,
  "Sent": "2021-05-12T10:11:00.0798072+02:00",
  "Size": 545,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "<20210512101100.90123@techcorp.com>",
  "PlainBody": "Hi John,\n\nPlease review the attached service agreement draft. I've incorporated the feedback from our last meeting.\n\nBest,\nSarah",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 571,
  "Attachments": [
    {
      "Description": "Service Agreement Draft",
      "Filename": "Service_Agreement_Draft_v2.docx",
      "Size": 612,
      "Type": "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
      "Encoding": "base64",
      "Id": "att_20210512_008",
      "Disposition": "attachment",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 168
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "X-Document-Type",
      "Values": [
        "Agreement",
        "Draft"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 309
        }
      }
    },
    {
      "Name": "X-Document-Version",
      "Values": [
        "2.0",
        "Draft"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 309
        }
      }
    }
  ],
  "FolderName": "Documents",
  "EmailItemId": 568,
  "AccountId": 512,
  "ReceivedAt": "2025-09-16T10:11:00.0808052+02:00",
  "InReplyTo": null,
  "RepliedAt": "1999-08-22T10:11:00.0808052+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 255
    }
  }
}
```
