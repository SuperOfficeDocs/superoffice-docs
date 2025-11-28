```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Type": "ChatAfterSaveNewMessage",
  "InputValues": {
    "TicketId": "1234",
    "MessageBody": "Thank you for contacting support"
  },
  "BlockExecution": true,
  "NavigateTo": "/tickets/1234",
  "Message": "Event handler executed successfully",
  "ShowDialog": "Notification sent to customer",
  "OutputValues": {
    "Status": "Success",
    "NotificationSent": "true"
  },
  "StateValues": {
    "LastExecuted": "2024-01-15T10:30:00",
    "ExecutionCount": "42"
  },
  "Exception": "",
  "ParserValues": {
    "CustomerName": "John Doe",
    "TicketTitle": "Login issue"
  },
  "CgiVariables": {
    "HTTP_USER_AGENT": "Mozilla/5.0",
    "REMOTE_ADDR": "192.168.1.100"
  },
  "CgiContent": "action=send_notification",
  "Headers": {
    "Content-Type": "application/json",
    "Authorization": "Bearer token_abc123"
  },
  "TraceExecution": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 240
    }
  }
}
```
