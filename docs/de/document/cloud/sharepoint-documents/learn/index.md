---
uid: help-de-sharepoint-documents
title: Integration der SharePoint-Dokumentbibliothek
description: "Mit dem Add-In SuperOffice für Outlook können Sie mühelos zwischen Ihrer Microsoft 365- und SuperOffice CRM-Lösung arbeiten, indem Sie direkt in Ihrer E-Mail auf wichtige Informationen und Funktionen von SuperOffice zugreifen können."
author: Bergfrid Dias
so.date: 01.15.2024
keywords: Dokument, Sharepoint
so.topic: concept
language: de
---

# Integration der SharePoint-Dokumentbibliothek

Mit der Integration der SharePoint-Dokumentenbibliothek von SuperOffice können Sie Dokumente und E-Mails mühelos und sicher erstellen, archivieren und teilen.

Mit dieser Integration können Sie alle Dokumente und E-Mails in SharePoint Online speichern, wo jeder in der Firma - auch diejenigen, die SuperOffice CRM nicht verwenden, darauf zugreifen kann. Der Zugriff auf Ihre SuperOffice Dokumentenseite in SharePoint kann über Microsoft Entra Domänengruppen (ehemals Azure Active Directory) gesteuert werden.

![Unter Einstellungen in Einstellungen und Verwaltung finden Sie die Dokumentbibliothek, in der Sie die SharePoint-Integration einrichten können -screenshot][img1]

## Anforderungen

Um SharePoint als Ihre Dokumentbibliothek in SuperOffice einzurichten, benötigen Sie:

* SuperOffice Online-Tenant
  * [Microsoft Entra Authentifizierung des SO-Administrators][1]
* Microsoft 365 für Business-Abonnement
  * Wenn Sie kein Microsoft 365-Abonnement haben, müssen Sie sich dafür bei Microsoft anmelden
* Eine SharePoint-Dokumentbibliothek (zum Speichern von Dokumenten)
* Wenn sie einen Gruppenzugriff auf SharePoint-Dokumente gemäß den Einstellungen "Sichtbar für" in SuperOffice aktivieren möchten
  * Sie benötigen Zugriff auf "Global Admin"-Rechte in Microsoft 365 (um SuperOffice als vertrauenswürdige App in Ihrer Microsoft 365-Lösung authentifizieren zu können). Diesen können Sie entweder während der Einrichtung beantragen odereinen Link an jemanden senden, der es ist.

> [!NOTE]
> Wenn Sie kein Microsoft 365-Abonnement haben und sich nicht für eines anmelden können, können Sie die standardmäßige SuperOffice-Dokumentbibliothek verwenden. Jeder Benutzer muss WebTools für Windows OS oder Mac OS installiert haben.

## Erste Schritte

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/8mIo3Yac2QI]

## Verwandt

* [Wie man die SharePoint-Ordner einrichtet][2]
* [Wie man die SharePoint-Dokumentbibliothek konfiguriert][4]
* [Genießen Sie eine effektive Dokumentkollaboration und Informationsaustausch mit SharePoint und SuperOffice CRM][3] -Blog

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html
[2]: set-up-folders.md
[3]: https://community.superoffice.com/en/learning/best-practices-tips/standard-crm/sharepoint-integration/
[4]: ../../../../admin/preferences/learn/document-library/change-to-sharepoint.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary.png
