---
uid: help-da-sharepoint-documents-folders
title: Sådan konfigureres SharePoint-mapperne
description: Sådan konfigureres SharePoint-mapperne
author: Bergfrid Dias
so.date: 01.15.2024
keywords: dokument, Sharepoint
so.topic: howto
language: da
---

# Sådan konfigureres SharePoint-mapperne

Opsætningen af SharePoint-webstedet og dokumentbibliotekerne er ret fleksibel, men vi anbefaler, at du opretter et **separat SharePoint-websted** til dine SuperOffice-dokumenter og **to dokumentbiblioteker**: et til dokumenter og et til dokumentskabeloner.

* I SharePoint kan du give tilladelse på webstedsniveau eller dokumentbiblioteksniveau:
Dokumentbiblioteker arver automatisk tilladelsen fra webstedsniveau.
Dokumenter i biblioteket arver tilladelsen fra selve biblioteket.

* SharePoint-brugergrupper:
  * I SharePoint kan du oprette og vedligeholde SharePoint-brugergrupper, hvilket giver brugerne direkte adgang til dokumenterne (som standard har du en ejergruppe, en medlemsgruppe og en besøgsgruppe).
  * Du kan ikke bruge SharePoint-brugergrupper til at angive tilladelser på dokumentniveau med SuperOffice SharePoint-dokumenter. Integrationen skal bruge Microsoft Entra domænegrupper. Så du skal give tilladelser til disse grupper.

* Gruppen af SharePoint-webstedsejere:
  * Når du opretter et websted i SharePoint, får du automatisk en *ejergruppe*. Medlemmer af denne ejergruppe har adgang til alle dokumenter på webstedet.
  * Denne adgang kan ikke fjernes.
  * Derfor skal du bruge en upersonlig konto til at oprette dit SharePoint-websted til SuperOffice-dokumenter.

![Tildel de forskellige tilladelser på webstedsniveau i SharePoint, husk at dokumentejerne har brug for fuld kontrol -screenshot][img1]

## Tilknyttet

* [Krav][1]
* [Sådan konfigurer du SharePoint-dokumentbibliotek][3]
* [Vedligehold dine dokumentskabeloner][2]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../../admin/lists/learn/add-template.md
[3]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary.png
