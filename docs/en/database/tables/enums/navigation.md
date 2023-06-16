---
uid: enum-navigation
title: Enum values for Navigation
description: Lists the enum values for Navigation.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# Navigation Enum

0=from menu, 1 = from Navigator(integration), 2 = From navigator

| Name | Value | Description |
|------|-------|-------------|
|Invisible|0|This application has no explicit navigation in GUI|
|ToolboxMenu|1|This application appears in the list of the Toolbox icon in the CRM5 Navigator sidebar|
|NavigatorButton|2|This application has its own navigator button (remember to set icon resource)|
|ViewMenu|3|This application appears in the View pulldown menu|
|SelectionTaskCard|4|(not yet implemented) This application appears as a Task in the Selection Task card|
|ContactCard|5|This application (type IntegratedHTML or IntegratedURL) appears as a tab on the Contact card|
|ContactArchive|6|This application (type IntegratedHTML or IntegratedURL)  appears as a tab on the Contact Archive|
|ProjectCard|7|This application (type IntegratedHTML or IntegratedURL)  appears as a tab on the Project card|
|ProjectArchive|8|This application (type IntegratedHTML or IntegratedURL)  appears as a tab on the Project Archive|
|SaleCard|9|This application (type IntegratedHTML or IntegratedURL)  appears as a tab in the Sale dialog|
|PersonCard|10|This application (type IntegratedHTML or IntegratedURL)  appears as a tab in the Person Card|
|ActivityDialog|11|This application (type IntegratedHTML or IntegratedURL)  appears as a tab in the Appointment dialog|
|DocumentDialog|12|This application (type IntegratedHTML or IntegratedURL)  appears as a tab in the Document dialog|
|BrowserPanel|13|In the Browser panel|
|ContSelectionTask|14|Task button visible on the Contact Selection task panel|
|AppntSelectionTask|15|Task button visible on the Appointment Selection task panel|
|SaleSelectionTask|16|Task button visible on the Sale Selection task panel|
|DocSelectionTask|17|Task button visible on the Document Selection task panel|
|ProjSelectionTask|18|Task button visible on the Project Selection task panel|
|CompanyMinicard|19|In company minicard|
|ProjectMinicard|20|In project minicard|
|DiaryMinicard|21|In diary minicard|
|SelectionMinicard|22|In selection minicard|
|ButtonPanelTask|23|In the main ButtonBar|
|AppointmentDialogTask|24|In the appointment dialog|
|SaleDialogTask|25|In the sale dialog|
|DocumentDialogTask|26|In the document dialog|
|PersonDialogTask|27|In the person dialog|
|SaleMinicard|28|In the sale minicard|
|SaleArchive|29|In the sale archive|
|AppntSelectionShadowTask|30|Task tab for appointment selection, while showing shadow sel|
|SaleSelectionShadowTask|31|Task tab for sale selection, while showing shadow sel|
|DocSelectionShadowTask|32|Task tab for document selection, while showing shadow sel|
|ProjSelectionShadowTask|33|Task tab for project selection, while showing shadow sel|
|DiaryArchive|34|Context (popup) menu in Diary archive|
|SelectionContactArchive|35|Context (popup) menu in Contact selection|
|SelectionProjectArchive|36|Context (popup) menu in Project archive|
|SelectionSaleArchive|37|Context (popup) menu in Sale archive|
|SelectionAppointmentArchive|38|Context (popup) menu in Appointment archive|
|SelectionDocumentArchive|39|Context (popup) menu in Document archive|
|ContSelectionCustomTask|40|Task card in Contact selection, when a custom archive is shown|
|AppntSelectionCustomTask|41|Task card in Appointment selection, when a custom archive is shown|
|SaleSelectionCustomTask|42|Task card in Sale selection, when a custom archive is shown|
|DocSelectionCustomTask|43|Task card in Document selection, when a custom archive is shown|
|ProjSelectionCustomTask|44|Task card in Project selection, when a custom archive is shown|
|CustomArchiveMiniCard|45|?|
|SelectionCard|46|?|
|ReportMinicard|47|In the Reporter panel minicard, so far only in Web|
|QuoteDialog|48||
|QuoteDialogTask|49||
|QuoteDialogArchive|50||
|QuoteLineDialogTask|51||
|QuoteLineDialog|52||
|QuoteLineSelectionMainTask|53||
|QuoteLineSelectionShadowTask|54||
|SelectionQuoteLineArchive|55||
|QuoteLineSelectionCustomTask|56||
|FindSystem|57||
|MailingSelectionTask|58|Task button visible on the Mailing Selection task panel|
|ContactSelectionMailingsTask|59|Task button visible on the Mailing Selection task panel|
|AppointmentSelectionMailingsTask|60|Task button visible on the Mailing Selection task panel|
|SaleSelectionMailingsTask|61|Task button visible on the Mailing Selection task panel|
|DocumentSelectionMailingsTask|62|Task button visible on the Mailing Selection task panel|
|ProjectSelectionMailingsTask|63|Task button visible on the Mailing Selection task panel|
|QuoteLineSelectionMailingsTask|64|Task button visible on the Mailing Selection task panel|
|TopPanelNewMenu|65|Visible in top panels new menu|
|Dashboard|66|Dashboard panel|
|PersonArchive|67|This application (type IntegratedHTML or IntegratedURL)  appears as a tab in the Person Archive|
|PersonMinicard|68|In the person minicard|
|CompanyCardTask|69|In the company card, task button|
|ProjectCardTask|70|In the project card, task button|
|TicketCard|71|This application (type IntegratedHTML or IntegratedURL) appears as a tab in the Request card|
|TicketMinicard|72|In the ticket minicard|

## Usage

* [ExtApp](../extapp.md).navigation - ExtApp list table. Applications startable from SuperOffice
