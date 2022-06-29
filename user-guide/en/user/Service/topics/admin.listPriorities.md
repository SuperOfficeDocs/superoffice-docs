---
uid: help-en-admin-listpriorities
title: admin listPriorities
description: admin listPriorities
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Priorities

**Note:** If this option is not visible, that means you have insufficient rights for this function. Contact your system administrator for more information.

All requests registered in SuperOffice Service are assigned a priority that reflects the importance of the enquiry. The priority assigned to a case can be determined by, for example:

* the contact
* the company
* the mailbox
* an e-mail filter

Once a request has been assigned a priority, the priority can be used to control any escalation of the request.

For example: You can specify that requests from a specific company should have VIP priority and that you should be notified by e mail if the request has not been read by a specified deadline.

Priorities override other priorities in this order:

1. priority specified for a contact
2. priority specified for a company
3. priority specified for an e mailbox
4. priority specified for an e mail filter
5. standard priorities

Since the priority is determined in this order, a request from a contact with high priority will be given a high priority even though the e-mailbox the person sends it to has a low priority.

In SuperOffice Service you can define as many priorities as you want. For each priority you can define escalation levels, so that the system forwards the enquiry further through the organisation if it has not been read or dealt with within a specified time.

An example of this is user-support and SLA agreements which specify that the supplier must begin troubleshooting within, say, 2 hours. You can then define operations which cause the request to be escalated and assigned to new request handlers if it has not been read or processed within this time. You can define as many operations as you want, and also be notified by mobile phone.

> [!NOTE]
> Each priority has an accessibility property associated with it. If the request's priority is set to **External**, the priority will be accessible via SuperOffice Customer Centre. If more than two priorities are accessible externally, the customer will be able to select which priority should apply to the request. This may cause the request to be given a higher priority than necessary, since the customer will want to get a reply as quickly as possible and is likely to select the highest available priority. The highest priorities should therefore be set to **Internal**, while **Medium** and **Low** priorities are made accessible externally.

## What would you like to do now?

[Work with priorities](admin.listPriorities.listPriorities.md)

[Work with escalation levels](admin.listPriorities.editAlert.md)
