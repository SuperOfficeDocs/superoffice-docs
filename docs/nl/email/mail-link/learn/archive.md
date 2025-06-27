---
uid: help-nl-mail-link-archive
title: E-mails archiveren naar SuperOffice
description: E-mails archiveren naar SuperOffice
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail-koppeling
content_type: howto
language: nl
---

# Een e-mail archiveren

Wanneer u op de knop **E-mail archiveren** op de werkbalk van de e-mailclient klikt, wordt er een menu met archiveeropties weergegeven.

> [!NOTE]
> Deze knop wordt ook weergegeven in het e-mailvenster wanneer u een e-mail opent die u hebt ontvangen.

**Opties:**

* [E-mails archiveren op bedrijven/personen][2]
* [E-mails archiveren als activiteiten][1]
* [Bijlagen archiveren][3]
* [E-mails archiveren als verzoeken][4]

Voor alle verschillende archiveeropties kunt u de optie **Waarschuw mij wanneer een e-mail groter is dan (in kB)** selecteren in [het deelvenster **Algemene instellingen**][5] van het dialoogvenster **SuperOffice CRM-opties**. Wanneer u dus een e-mail probeert te archiveren met een bijlage die de opgegeven limiet overschrijdt, zal een dialoogvenster u hierover informeren en u vragen of u deze toch wilt archiveren.

## Verschillen tussen Outlook, Notes en SuperOffice CRM

U kunt op verschillende manieren e-mails maken, zowel [vanuit Outlook][6] als vanuit [SuperOffice CRM][8]. Als het dialoogvenster **Document** wordt weergegeven, wordt de e-mail behandeld als een SuperOffice-document en wordt deze gearchiveerd. Als het dialoogvenster **Document** niet wordt weergegeven, wordt de e-mail gearchiveerd op basis van de instellingen in het dialoogvenster **SuperOffice CRM-opties**.

Het dialoogvenster **Document** wordt automatisch geopend als u:

* Klikt op de knop **Schrijven** in SuperOffice CRM.

* Klikt op de pijl-omlaag rechts van de knop **Nieuwe e-mail** op de werkbalk Microsoft Outlook en een van de sjablonen selecteert in het submenu **SuperOffice-bericht**.

Het dialoogvenster **Document** wordt niet automatisch geopend als u:

* Klikt op de knop **Nieuwe e-mail** in de e-mailclient. De e-mails worden echter gearchiveerd als de optie **E-mail standaard archiveren wanneer: gemaakt vanaf optie e-mailclient** in het dialoogvenster **SuperOffice CRM-opties** is geselecteerd.

* Klik op de knop **E-mail** in SuperOffice CRM. De e-mails worden echter gearchiveerd als de optie **E-mail standaard archiveren wanneer: gemaakt uit SuperOffice CRM** in het dialoogvenster **SuperOffice CRM-opties** is geselecteerd.

* Wanneer u een e-mail maakt met de knop **E-mail** in SuperOffice CRM, is het mogelijk om standaard een vooraf gedefinieerde e-mailtekstsjabloon te gebruiken als de optie **SuperOffice-e-mailtekst gebruiken** in het dialoogvenster **SuperOffice CRM-opties** is geselecteerd.

> [!NOTE]
> Dit geldt ook als u op een e-mailadres klikt in SuperOffice CRM, een e-mail verzendt vanaf het tabblad **Contactpersonen** of een e-mail beantwoordt/doorstuurt vanaf het sectietabblad **Activiteiten**.

## De e-mail is al gearchiveerd in SuperOffice CRM

Wanneer een e-mail wordt gearchiveerd door een gebruiker, wordt deze getagd met een unieke ID in SuperOffice CRM. Dit betekent dat de volgende keer dat iemand dezelfde e-mail probeert te archiveren, er een waarschuwing verschijnt die hen hierover informeert; Op deze manier is het mogelijk om duplicaten in de database te voorkomen.

Als u een e-mail opent die al is gearchiveerd, wordt de knop **E-mail archiveren** ![pictogram][img1] groen weergegeven met een wit vinkje. Als u met de muisaanwijzer over de knop gaat, wordt een infovak weergegeven waarin staat wanneer en door wie de e-mail is gearchiveerd. Dit veronderstelt dat u de optie **Controleren op duplicaten wanneer een e-mail wordt geopend** hebt geselecteerd in het dialoogvenster **SuperOffice CRM-opties**.

## Gerelateerde inhoud

* [Archiefopties][9]
* [Algemene instellingen][5]

<!-- Referenced links -->
[1]: archive-as-activity.md
[2]: archive-on-contact.md
[3]: archive-attachment.md
[4]: archive-as-request.md
[5]: settings/general.md
[9]: settings/default.md
[6]: create-in-outlook.md
[8]: create-in-superoffice.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/mail-link/already-archived.png
