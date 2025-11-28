```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Type": "ChatAfterSaveNewMessage",
  "InputValues": {
    "ticketId": "12345",
    "customerId": "67890"
  },
  "BlockExecution": false,
  "NavigateTo": "ticket.main?id=12345",
  "Message": "Ticket has been successfully created and assigned",
  "ShowDialog": "Success",
  "OutputValues": {
    "assignedTo": "John Anderson",
    "priority": "High"
  },
  "StateValues": {
    "ticketStatus": "Open",
    "lastModified": "2024-11-27T10:00:00Z"
  },
  "Exception": "",
  "ParserValues": {
    "scriptName": "new-ticket-auto-assign",
    "executionTime": "85ms"
  },
  "CgiVariables": {
    "HTTP_USER_AGENT": "SuperOffice/10.0",
    "REMOTE_ADDR": "192.168.1.100"
  },
  "CgiContent": "{\"action\":\"create\",\"entity\":\"ticket\"}",
  "Headers": {
    "Content-Type": "application/json",
    "X-Execution-Context": "trigger-script"
  },
  "TraceExecution": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 154
    }
  }
}
```
