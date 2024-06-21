---
uid: crmscript-status-reminder-notification-tutorial
title: Automated reminder email
description: Using a "Waiting for customer" status with automated reminder email
author: kronicz
date: 10.03.2022
keywords: CRMScript
topic: tutorial
---

# Using a "Waiting for customer" status with automated reminder email

A frequently demanded feature is to have Service reminding the end customer when we are waiting for the response to a request. This is not out-of-the-box functionality, but quite simple to configure. The functionality will behave like this:

1. When we send a message to the customer, we manually change status to "Waiting for customer".
2. If the request remains in this status for X days without us getting a response from the customer, we will send a notification email reminding the customer that we are waiting for their response.
3. If the request remains in this status for another Y days without us getting a response from the customer, we will close the request and send a notification email informing the customer that the issue is closed.
4. If the customer responds back by email to a request with status "Waiting for customer", the request will change status to "Open". Consequently, if this happens before we reach X days, there will not be sent any notification emails.

## This solution will be based on the following components

* A new request status, "Waiting for customer".
* A new datetime fields on request to register when we send the notification to the customer about closing the request. This is to ensure that we do not send more than one notification.
* A new script that will be executed every night, checking the requests and sending email notifications as described above.
* Two new reply templates, containing the messages we send for notification.

## Implementation

Creating the field should be straightforward:

![field -screenshot][img1]

You then need to create the two reply templates we will use. The script will merge the templates with the request and customer data, so merge fields from these entities can be used, such as “Dear [[customer.name]]”:

![replytemplate -screenshot][img2]

Creating the status is also easy. Note: the field `Standard` should not be checked.

![requeststatus -screenshot][img3]

Finally, we need to create the script. Here is the code:

```crmscript
#setLanguageLevel 3;
// Start configuration section
Integer daysBeforeWarning = 3;
Integer daysBeforeClosing = 7;
Integer waitingStatus = 6;
Integer notificationReplyTemplate = 22;
Integer closingReplyTemplate = 23;
// End configuration section

Integer secondsPrDay = 24 * 60 * 60;
Void sendNotification(Ticket ticket, Integer customerId, Integer replyTemplateId)
{
  // Load customer
  Customer customer;
  customer.load(customerId);
  Integer customerLanguage = customer.getValue("language").toInteger();

  // Load reply template
  ReplyTemplate rt;
  rt.load(replyTemplateId);
  String subject = rt.getSubject(customerLanguage);
  String bodyPlain = rt.getPlainBody(customerLanguage);
  String bodyHtml = rt.getHtmlBody(customerLanguage);

  // Parse templates with customer and ticket
  Parser parser = getParser();
  ticket.toParser(parser);
  customer.toParser(parser);
  subject = parser.parseString(subject);
  bodyPlain = parser.parseString(bodyPlain);
  bodyHtml = parser.parseString(bodyHtml);

  // Add message
  Message newMessage;
  newMessage.setValue("ticketId", ticket.getValue("id"));
  if (bodyPlain != "")
    newMessage.setValue("bodyPlain", bodyPlain);
  if (bodyHtml != "")
    newMessage.setValue("bodyHtml", bodyHtml);
  newMessage.setValue("author", "(Notification script)");
  newMessage.save();

  // Send email
  Email email;
  email.setValue("to", customer.getValue("email"));
  email.setValue("subject", subject);
  if (bodyPlain != "")
    email.setValue("body", bodyPlain);
  if (bodyHtml != "")
    email.setValue("bodyHtml", bodyHtml);
  email.send();
}

SearchEngine se;
se.addField("ticket.id");
se.addField("ticket.x_notification_sent");
se.addField("ticket.created_at");
se.addField("ticket.replied_at");
se.addField("ticket.cust_id");
se.addCriteria("ticket.ticket_status", "OperatorEquals", waitingStatus.toString(), "OperatorAnd", 0);
for (se.execute(); !se.eof(); se.next())
{
  DateTime createdAt = DateTime(se.getField("ticket.created_at"));
  DateTime repliedAt = DateTime(se.getField("ticket.replied_at"));
  DateTime notificationSent = DateTime(se.getField("ticket.x_notification_sent"));
  DateTime lastCustomerMessage = createdAt;
  if (repliedAt > createdAt)
    lastCustomerMessage = repliedAt;
  if (se.getField("ticket.x_notification_sent") == "" && getCurrentDateTime().diff(lastCustomerMessage) > daysBeforeWarning * secondsPrDay)
  {
    Integer ticketId = se.getField("ticket.id").toInteger();
    Integer customerId = se.getField("ticket.cust_id").toInteger();
    // Update ticket
    Ticket theTicket;
    theTicket.load(ticketId);
    theTicket.setValue("x_notification_sent", getCurrentDateTime().toString());
    theTicket.save();
    // Add message and send by email
    sendNotification(theTicket, customerId, notificationReplyTemplate);
    // Print to out for logging
    print("Sent notification email for request " + ticketId.toString() + "\r\n");
  }
  else if (getCurrentDateTime().diff(lastCustomerMessage) > daysBeforeClosing * secondsPrDay)
  {
    Integer ticketId = se.getField("ticket.id").toInteger();
    Integer customerId = se.getField("ticket.cust_id").toInteger();
    // Update ticket
    Ticket theTicket;
    theTicket.load(ticketId);
    theTicket.setValue("status", "2"); // Closed
    theTicket.save();
    // Add message and send by email
    sendNotification(theTicket, customerId, closingReplyTemplate);
    // Print to out for logging
    print("Sent closing email for request " + ticketId.toString() + "\r\n");
  }
}
```

The opening part of this script have some variables you need to configure:

| Variable | Description |
|----------|-------------|
| daysBeforeWarning | The number of days before we send the first notification. |
| daysBeforeClosing | The number of days before we close and send the second notification. |
| waitingStatus | The ID of the new status we have created: "Waiting for customer". |
| notificationReplyTemplate | The ID of the reply template used for first notification.|
| closingReplyTemplate | The ID of the reply template used for second notification. |

Schedule this script as a nightly task, and you should be all set. The notifications will be logged on the request so that you can easily see what has been sent:

![viewticket -screenshot][img4]

[img1]: media/notification-field.png
[img2]: media/reply-template.png
[img3]: media/request-status.png
[img4]: media/ticket-view.png
