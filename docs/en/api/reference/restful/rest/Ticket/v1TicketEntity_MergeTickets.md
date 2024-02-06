---
title: POST Ticket/Merge
uid: v1TicketEntity_MergeTickets
generated: true
---

# POST Ticket/Merge

```http
POST /api/v1/Ticket/Merge
```

Merge one or more tickets into one primary ticket







## Query String Parameters


```http
POST /api/v1/Ticket/Merge?secondaryTicketIds=670,272
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketId=325
POST /api/v1/Ticket/Merge?mergedTicketEntity.title=dolores
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdAt=01/14/2017 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.lastChanged=10/10/2000 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.readByOwner=04/03/2010 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.readByCustomer=10/14/2019 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.firstReadByOwner=09/21/1999 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.firstReadByUser=01/01/2016 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.activate=04/01/2022 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.closedAt=01/02/2019 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.repliedAt=11/22/2005 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.alertTimeout=04/14/1998 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.deadline=12/04/1997 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.associateId=461
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.name=ad
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.personId=31
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.rank=38
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tooltip=omnis
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.type=AnonymousAssociate
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.groupIdx=554
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.fullName=Emard, Heaney and Schulist
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.formalName=Connelly Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.deleted=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.ejUserId=276
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.userName=Veum-Moen
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tableRight.reason=quia
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.author=amet
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.associateId=107
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.name=facere
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.personId=309
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.rank=548
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tooltip=pariatur
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.type=AnonymousAssociate
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.groupIdx=99
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.fullName=Von LLC
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.formalName=Fahey-Paucek
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.deleted=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.ejUserId=457
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.userName=Witting-Reinger
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tableRight.reason=totam
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.ticketCategoryId=193
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.parentId=244
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.name=in
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.fullname=possimus
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.categoryMaster=285
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.flags=AcceptWhenReplying
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.delegateMethod=Even
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.externalName=Swaniawski LLC
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.closingStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.msgClosingStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.assignmentLag=574
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.replyTemplate=30
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.notificationEmail=elza.mcclure@streichlakin.us
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.ticketStatusId=536
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.name=illo
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.isDefault=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.usedInQueue=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.tableRight.reason=aut
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.ticketStatusId=115
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.name=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.isDefault=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.usedInQueue=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.tableRight.reason=iusto
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.effectiveReplyTemplateId=92
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.tableRight.reason=itaque
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.slevel=External
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketPriorityId=340
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.name=dolorem
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.status=Deleted
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.flags=AlertSchedule
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sortOrder=619
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketRead=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.changedOwner=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketNewinfo=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketClosed=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketChangedPriority=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketNew=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.deadline=284
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.monStart=11/22/2002 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.monStop=05/30/2017 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tueStart=09/13/1999 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tueStop=06/29/1997 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.wedStart=10/05/2007 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.wedStop=03/24/2003 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.thuStart=04/17/2011 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.thuStop=12/05/1998 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.friStart=04/10/2019 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.friStop=01/07/2017 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.satStart=09/27/1997 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.satStop=12/19/2022 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sunStart=11/30/2003 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sunStop=11/01/2020 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.nonDates=tempore,qui
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.escalationLevels=atque,consequatur
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tableRight.reason=ipsa
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.baseStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.ticketStatusId=456
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.name=odio
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.isDefault=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.usedInQueue=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.tableRight.reason=id
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.origin=AutoGenerated
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.position=ipsum
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.personId=725
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.mrmrs=vitae
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.firstname=rerum
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.lastname=omnis
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.middleName=Prohaska-Muller
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.title=qui
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.description=voluptas
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.email=voluptatum
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.fullName=Lind, Tillman and Gleichner
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.directPhone=678.350.8632 x3265
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.formalName=Marquardt-Emard
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.countryId=159
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactId=136
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactName=Sawayn-Hermiston
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.retired=383
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.rank=4
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.activeInterests=795
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactDepartment=
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactCountryId=6
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactOrgNr=355774
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.faxPhone=(400)643-5228 x23257
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.mobilePhone=637.688.8535 x3577
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactPhone=051.402.9010 x14955
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.associateName=Paucek Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.associateId=299
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.usePersonAddress=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactFax=sed
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.kanafname=aut
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.kanalname=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post1=fuga
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post2=molestiae
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post3=beatae
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.emailName=Carroll-Morar
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactFullName=Daisha Krajcik I
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.activeErpLinks=15
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.ticketPriorityId=591
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.supportLanguageId=411
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.supportAssociateId=786
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.categoryName=Welch LLC
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.tableRight.reason=ipsa
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.secondaryPersons=sit,laborum
POST /api/v1/Ticket/Merge?mergedTicketEntity.alertLevel=719
POST /api/v1/Ticket/Merge?mergedTicketEntity.connectId=26
POST /api/v1/Ticket/Merge?mergedTicketEntity.readStatus=Green
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeToReply=553
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeToReply=661
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeToClose=17
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeToClose=836
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentInternally=230
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentExternally=497
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentQueue=746
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentInternally=362
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentExternally=640
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentQueue=170
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpent=710
POST /api/v1/Ticket/Merge?mergedTicketEntity.hasAttachment=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.numReplies=65
POST /api/v1/Ticket/Merge?mergedTicketEntity.numMessages=118
POST /api/v1/Ticket/Merge?mergedTicketEntity.fromAddress=esse
POST /api/v1/Ticket/Merge?mergedTicketEntity.messages=dignissimos,accusantium
POST /api/v1/Ticket/Merge?mergedTicketEntity.tags=natus,sunt
POST /api/v1/Ticket/Merge?mergedTicketEntity.language=expedita
POST /api/v1/Ticket/Merge?mergedTicketEntity.sentiment=965
POST /api/v1/Ticket/Merge?mergedTicketEntity.sentimentConfidence=126
POST /api/v1/Ticket/Merge?mergedTicketEntity.suggestedCategoryId=482
POST /api/v1/Ticket/Merge?mergedTicketEntity.suggestedCategoryName=VIP Customer
POST /api/v1/Ticket/Merge?mergedTicketEntity.origHumanCategoryId=816
POST /api/v1/Ticket/Merge?mergedTicketEntity.iconHint=impedit
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.contactName=Berge, Effertz and Mraz
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleDate=03/19/1997 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleId=18
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.probability=584
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.title=rerum
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.amount=28669.832
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.currency=culpa
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.projectName=Mraz Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.associateFullName=D'angelo Bosco
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.description=quo
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.status=Lost
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.weightedAmount=16936.136
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.projectId=885
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.earningPercent=2861.342
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.earning=26146.962
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.contactId=214
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.associateId=753
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.personId=389
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleTypeId=128
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleTypeName=Renner, Predovic and Bergnaum
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.personFullName=Ms. Reyna Collier V
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.completed=Completed
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.activeErpLinks=248
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.nextDueDate=01/11/2022 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.number=soluta
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.tableRight.reason=culpa
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.projectId=407
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.name=ratione
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.description=optio
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.uRL=rerum
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.type=rem
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.associateId=640
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.associateFullName=Mrs. Katrine Morissette DDS
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.typeId=579
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.updated=03/10/2020 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.statusId=920
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.status=sed
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.textId=817
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.publishTo=03/18/2005 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.publishFrom=11/08/2012 23:04:06
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.isPublished=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.uRLName=Huel, Fahey and Steuber
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.projectNumber=1105184
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.activeErpLinks=131
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.tableRight.reason=eum
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.formSubmissionId=955
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.emailAddress=dicta
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.status=EmailVerification
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.ticketTypeId=116
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.name=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.icon=ea
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.defaultTicketStatus=432
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.defaultTicketPriority=705
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.isDefault=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.tableRight.reason=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.activeStatusMonitorId=339
POST /api/v1/Ticket/Merge?mergedTicketEntity.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.tableRight.reason=ut
POST /api/v1/Ticket/Merge?mergedTicketEntity.fieldProperties=An object of some kind
```


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

### Response body: TicketEntity


## Sample request

```http!
POST /api/v1/Ticket/Merge
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 161,
  "Title": "consequatur",
  "CreatedAt": "2010-03-25T23:04:04.9250073+01:00",
  "LastChanged": "1997-12-24T23:04:04.9250073+01:00",
  "ReadByOwner": "2019-01-04T23:04:04.9250073+01:00",
  "ReadByCustomer": "1999-01-09T23:04:04.9250073+01:00",
  "FirstReadByOwner": "2006-07-20T23:04:04.9250073+02:00",
  "FirstReadByUser": "1998-05-11T23:04:04.9250073+02:00",
  "Activate": "1998-10-24T23:04:04.9250073+02:00",
  "ClosedAt": "2003-12-23T23:04:04.9250073+01:00",
  "RepliedAt": "2020-03-18T23:04:04.9250073+01:00",
  "AlertTimeout": "2014-03-15T23:04:04.9250073+01:00",
  "Deadline": "2023-11-13T23:04:04.9250073+01:00",
  "CreatedBy": null,
  "Author": "veritatis",
  "OwnedBy": null,
  "Category": null,
  "Slevel": "External",
  "Priority": null,
  "BaseStatus": "Active",
  "Status": null,
  "Origin": "AutoGenerated",
  "Person": null,
  "SecondaryPersons": [
    {
      "Position": "dolores",
      "PersonId": 510,
      "Mrmrs": "porro",
      "Firstname": "June",
      "Lastname": "Braun",
      "MiddleName": "Grady-Green",
      "Title": "blanditiis",
      "Description": "Networked local policy",
      "Email": "elisa@romaguera.co.uk",
      "FullName": "Mrs. Geraldine Blanda",
      "DirectPhone": "187.019.9922 x9743",
      "FormalName": "Prosacco, West and Paucek",
      "CountryId": 789,
      "ContactId": 256,
      "ContactName": "Fay Group",
      "Retired": 188,
      "Rank": 502,
      "ActiveInterests": 214,
      "ContactDepartment": "",
      "ContactCountryId": 449,
      "ContactOrgNr": "625817",
      "FaxPhone": "546-409-1136",
      "MobilePhone": "(333)181-0886 x093",
      "ContactPhone": "(173)392-9753 x4031",
      "AssociateName": "Barrows, Friesen and Parisian",
      "AssociateId": 396,
      "UsePersonAddress": true,
      "ContactFax": "dignissimos",
      "Kanafname": "et",
      "Kanalname": "aliquid",
      "Post1": "reprehenderit",
      "Post2": "error",
      "Post3": "molestias",
      "EmailName": "orpha_emmerich@gislason.com",
      "ContactFullName": "Pascale Grady",
      "ActiveErpLinks": 204,
      "TicketPriorityId": 980,
      "SupportLanguageId": 287,
      "SupportAssociateId": 462,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 692
        }
      }
    }
  ],
  "AlertLevel": 933,
  "ConnectId": 379,
  "ReadStatus": "Green",
  "TimeToReply": 921,
  "RealTimeToReply": 317,
  "TimeToClose": 344,
  "RealTimeToClose": 454,
  "TimeSpentInternally": 978,
  "TimeSpentExternally": 405,
  "TimeSpentQueue": 529,
  "RealTimeSpentInternally": 904,
  "RealTimeSpentExternally": 462,
  "RealTimeSpentQueue": 966,
  "TimeSpent": 962,
  "HasAttachment": true,
  "NumReplies": 156,
  "NumMessages": 229,
  "FromAddress": "saepe",
  "Messages": [
    {
      "TicketMessageId": 279,
      "CreatedAt": "1999-10-21T23:04:04.9295074+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "soluta",
      "PersonId": 434,
      "PersonFullName": "Ava King",
      "ContactId": 911,
      "ContactName": "Ritchie LLC",
      "ContactDepartment": "",
      "NumAttachments": 184,
      "EmailHeader": "jeffery_quigley@schmidt.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "officiis",
      "Sentiment": 914,
      "SentimentConfidence": 927,
      "CreatedBy": 978,
      "ChangedAt": "1997-08-29T23:04:04.9300072+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 460,
      "Name": "Gaylord-Zieme",
      "ToolTip": "Rem exercitationem quae eos error illum maxime.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
        }
      }
    },
    {
      "Id": 460,
      "Name": "Gaylord-Zieme",
      "ToolTip": "Rem exercitationem quae eos error illum maxime.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
        }
      }
    }
  ],
  "Language": "omnis",
  "Sentiment": 434,
  "SentimentConfidence": 761,
  "SuggestedCategoryId": 399,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 288,
  "IconHint": "voluptatem",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 97,
  "ExtraFields": {
    "ExtraFields1": "aspernatur",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "dignissimos",
    "CustomFields2": "animi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 789
    }
  }
}
```