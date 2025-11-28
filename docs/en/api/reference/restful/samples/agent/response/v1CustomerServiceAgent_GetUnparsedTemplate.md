```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReplyTemplateId": 591,
  "PlainParsed": "Dear [[customer.name]],\n\nThank you for contacting us regarding [[ticket.title]]. Your ticket number is [[ticket.id]].\n\nBest regards,\n[[user.name]]",
  "HtmlParsed": "<p>Dear [[customer.name]],</p><p>Thank you for contacting us regarding [[ticket.title]]. Your ticket number is [[ticket.id]].</p><p>Best regards,<br/>[[user.name]]</p>",
  "Attachments": [
    {
      "AttachmentId": 795,
      "Name": "company-signature.png",
      "ContentType": "ab",
      "AttSize": 168,
      "InlineImage": false,
      "ContentId": "sed",
      "AuthKey": "vero",
      "IsSafeFileExtension": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 581
        }
      }
    }
  ],
  "Subject": "Re: [[ticket.title]] - Ticket #[[ticket.id]]",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 138
    }
  }
}
```
