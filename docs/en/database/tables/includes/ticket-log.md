<!-- markdownlint-disable-file MD041 -->
The field `ticket_log.log_code` has an enum from this list:

### enum LogMessages

| Name                             | Value | Description                                   |
|----------------------------------|-------|-----------------------------------------------|
| `LOG_TICKET_EJ23_WHAT`           | 0     | Backward compatibility with ej2.3 log_what    |
| `LOG_TICKET_POSTEDEMAIL`         | 1     | Request generated from email                  |
| `LOG_TICKET_POSTEDINTERNALLY`    | 2     | Request posted internally                     |
| `LOG_TICKET_POSTEDEXTERNALLY`    | 3     | Request posted externally                     |
| `LOG_TICKET_POSTPONED`           | 4     | Postponed to                                  |
| `LOG_TICKET_CHANGEDOWNER`        | 5     | Changed owner to                              |
| `LOG_TICKET_CHANGEDTITLE`        | 6     | Changed title to                              |
| `LOG_TICKET_CHANGEDSLEVEL`       | 7     | Changed security level to                     |
| `LOG_TICKET_CHANGEDCATEGORY`     | 8     | Changed category to                           |
| `LOG_TICKET_CHANGEDPRIORITY`     | 9     | Changed priority to                           |
| `LOG_TICKET_CHANGEDCUSTOMER`     | 10    | Changed contact to                            |
| `LOG_TICKET_CHANGEDSTATUS`       | 11    | Changed status to                             |
| `LOG_TICKET_CONNECTED`           | 12    | Connected to request #                        |
| `LOG_TICKET_CUSTOMERREAD`        | 13    | Request read by contact                       |
| `LOG_TICKET_ESCALATED`           | 14    | Request escalated                             |
| `LOG_TICKET_MESSAGE_EMAIL`       | 15    | Message added to ticket from email            |
| `LOG_TICKET_MESSAGE_INTERNAL`    | 16    | Message added to ticket from internal web     |
| `LOG_TICKET_MESSAGE_EXTERNAL`    | 17    | Message added to ticket from external web     |
| `LOG_TICKET_FORWARDED`           | 18    | Ticket forwarded by email                     |
| `LOG_TICKET_MESSAGE_DELETED`     | 19    | Message deleted by admin user                 |
| `LOG_TICKET_ADD_CUSTOMER`        | 20    | Added reference to secondary customer contact |
| `LOG_TICKET_REMOVE_CUSTOMER`     | 21    | Removed reference to secondary customer contact |
| `LOG_TICKET_DELETE_ATTACHMENT`   | 22    | Removed attachment                            |
| `LOG_TICKET_CLOSED_FAQ`          | 23    | Ticket closed via FAQ in customer             |
| `LOG_TICKET_NOTIFY_FAQ`          | 24    | Customer notified FAQ answer in customer      |
| `LOG_TICKET_AUTOREPLY`           | 25    | Who received autoreply                        |
| `LOG_TICKET_EMAIL_FILTER`        | 26    | Email filter processed a mail for the ticket  |
| `LOG_NOTIFY_EMAIL_NEW_TICKET`    | 27    | Email sent to user notifying new ticket       |
| `LOG_NOTIFY_EMAIL_NEW_MESSAGE`   | 28    | Email sent to user notifying new message      |
| `LOG_TICKET_MESSAGE_TO`          | 29    | Add message: TO recipients                    |
| `LOG_TICKET_MESSAGE_CC`          | 30    | Add message: CC recipients                    |
| `LOG_TICKET_MESSAGE_BCC`         | 31    | Add message: BCC recipients                   |
| `LOG_TICKET_CHANGED_READSTATUS`  | 32    | Changed read status                           |
| `LOG_TICKET_MESSAGE_SMS`         | 33    | Add message: SMS recipients                   |
| `LOG_NOTIFY_SMS_NEW_TICKET`      | 34    | SMS sent notifying new ticket                 |
| `LOG_NOTIFY_SMS_NEW_MESSAGE`     | 35    | SMS sent notifying new message                |
| `LOG_TICKET_MESSAGE_EDITED`      | 36    | Message edited                                |
| `LOG_TICKET_EJSCRIPT`            | 37    | Ticket altered by an ejscript                 |
| `LOG_TICKET_JSON`                | 38    |                                               |
