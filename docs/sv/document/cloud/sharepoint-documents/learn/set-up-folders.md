---
uid: help-sv-sharepoint-documents-folders
title: Så konfigurerar du SharePoint-mapparna
description: Så konfigurerar du SharePoint-mapparna
author: Bergfrid Dias
so.date: 01.15.2024
keywords: dokument, Sharepoint
so.topic: howto
language: sv
---

# Så konfigurerar du SharePoint-mapparna

Konfigurationen av SharePoint-sidan och dokumentbiblioteken är ganska flexibel, men vi rekommenderar att du skapar en **separat SharePoint-sida** för dina SuperOffice-dokument och **två dokumentbibliotek**: ett för dokument och ett för dokumentmallar.

* I SharePoint kan du tilldela behörighet på sidnivå eller dokumentbiblioteksnivå:
Dokumentbibliotek ärver automatiskt behörigheten från sidnivån.
Dokument i bibliotek ärver automatiskt behörigheten från själva biblioteket.

* Användargrupper i SharePoint:
  * I SharePoint kan du skapa och underhålla användargrupper, vilket ger användarna direkt åtkomst till dokumenten (som standard har du en ägargrupp, en medlemsgrupp och en besökargrupp).
  * Du kan inte använda SharePoint-användargrupper för att tilldela behörigheter på dokumentnivå med SuperOffice SharePoint-dokument. Integrationen måste använda Microsoft Entra domängrupper. Därför måste du tilldela behörigheter till dessa grupper.

* Ägargrupp för SharePoint-sidan:
  * När du skapar en sida i SharePoint får du automatiskt en *ägargrupp*. Medlemmarna i ägargruppen kommer åt alla dokument på den här sidan.
  * Åtkomsten kan inte tas bort.
  * Därför måste du använda ett opersonligt konto för att skapa din SharePoint-sida för SuperOffice-dokument.

![Tilldela de olika behörigheterna på sidnivå i SharePoint och tänk på att dokumentägarna behöver ha fullständig kontroll -screenshot][img1]

## Relaterat

* [Krav][1]
* [Så konfigurerar du SharePoint dokumentbibliotek][3]
* [Hantera dina dokumentmallar][2]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../../admin/lists/learn/add-template.md
[3]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary-sharepoint-permissions.png
