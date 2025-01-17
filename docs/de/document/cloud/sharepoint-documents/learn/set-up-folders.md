---
uid: help-de-sharepoint-documents-folders
title: Wie man die SharePoint-Ordner einrichtet
description: Wie man die SharePoint-Ordner einrichtet
author: Bergfrid Dias
so.date: 01.15.2024
keywords: Dokument, Sharepoint
so.topic: howto
language: de
---

# Wie man die SharePoint-Ordner einrichtet

Die Einrichtung der Website in SharePoint und der Dokumentbibliotheken ist recht flexibel, dennoch empfehlen wir, eine **separate Website in SharePoint** für Ihre SuperOffice-Dokumente und **zwei Dokumentbibliotheken** zu erstellen: eine für Dokumente und eine für Dokumentvorlagen.

* In SharePoint können Sie Berechtigungen auf Website- oder Dokumentbibliotheksebene erteilen:
Dokumentbibliotheken erben automatisch die Berechtigung von der Websiteebene.
Dokumente innerhalb der Bibliothek erben die Berechtigung von der Bibliothek selbst.

* SharePoint-Benutzergruppen:
  * In SharePoint können Sie SharePoint-Benutzergruppen erstellen und verwalten, wodurch die Benutzer direkten Zugriff auf die Dokumente erhalten (standardmäßig haben Sie eine Eigentümergruppe, eine Mitgliedergruppe und eine Besuchergruppe).
  * Sie können keine SharePoint-Benutzergruppen verwenden, um Berechtigungen auf Dokumentebene mit SuperOffice SharePoint-Dokumenten festzulegen. Für die Integration müssen Microsoft Entra Domänengruppen verwendet werden. Daher müssen Sie diesen Gruppen Berechtigungen erteilen.

* Eigentümergruppe der Website in SharePoint:
  * Wenn Sie eine Website in SharePoint erstellen, erhalten Sie automatisch eine *Eigentümergruppe*. Mitglieder dieser Eigentümergruppe haben Zugriff auf alle Dokumente in dieser Website.
  * Dieser Zugriff kann nicht entfernt werden.
  * Aus diesem Grund müssen Sie ein unpersönliches Konto verwenden, um Ihre Website in SharePoint für SuperOffice-Dokumente zu erstellen.

![Erteilen Sie die verschiedenen Berechtigungen auf Websiteebene in SharePoint und vergessen Sie nicht, dass Dokumenteigentümer vollen Zugriff benötigen -screenshot][img1]

## Verwandt

* [Anforderungen][1]
* [Wie man die SharePoint-Dokumentbibliothek konfiguriert][3]
* [Dokumentvorlagen verwalten][2]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../../admin/lists/learn/add-template.md
[3]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary-sharepoint-permissions.png
