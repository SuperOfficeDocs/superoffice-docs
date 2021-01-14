---
title: Bool sendMessages(String subject, StringMatrix recipients, Bool fromCust, String messages, Integer msgId, String comment)
path: /EJScript/Classes/Ticket/Member functions/Bool sendMessages(String subject, StringMatrix recipients, Bool fromCust, String messages, Integer msgId, String comment)
intellisense: 1
classref: 1
sortOrder: 9176
keywords: sendMessages(String,StringMatrix,Bool,String,Integer,String)
---


Will send the given messages just like the forward ticket functionality in the GUI. The forwarded messages are separated by a line, and the comment is placed on top of the mail.



* **subject:** The mail subject, maybe ticket.title.
* **recipients:** String matrix with recepients
* **fromCust:** Email address from ticket or customer
* **messages:** Comma separated list of message id's to forward
* **msgId:** Id of added "forward" message or "-1"
* **comment:** A comment that will be above the forwarded messages.
* **Returns:** True if success




###The recepients string matrix is formatted like this:###

To | John Doe \<john.doe@john.doe>
Cc | jane Doe \<jane.doe@jane.doe>



