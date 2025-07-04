---
uid: help-nl-document-update
title: Documenten bewerken
description: Documenten bewerken
keywords: document
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from: /nl/document/learn/delete
---

# Documenten bewerken

Het bewerken van documenten omvat twee zaken:

* Bewerken van de documenteigenschappen in het dialoogvenster Document.
* Bewerken van het documentbestand zelf in de toepassing waarin het document is gemaakt.

U kunt een document openen in [bewerkingsmodus of in leesmodus][1]. Wanneer u een document opent in de bewerkingsmodus, kunt u alleen zelf het document bewerken. Andere gebruikers kunnen het document in leesmodus openen. Als uw organisatie een documentbibliotheek zoals SharePoint gebruikt, kunnen meerdere mensen tegelijkertijd een document bewerken.

## Documenteigenschappen bewerken in het venster Document

Als u documenteigenschappen wilt wijzigen, zoals het project waaraan het document is gekoppeld, gebruikt u het scherm Document:

1. Selecteer het gewenste document.

2. Klik met de rechtermuisknop en kies **Document**. Als u dubbelklikt op het document, wordt het document rechtstreeks geopend in de toepassing waarin het is gemaakt.

3. [Breng de gewenste wijzigingen aan][3].

4. Klik op de knop **Opslaan**.

> [!NOTE]
> Voltooide documenten kunt u pas bewerken als u de optie **Voltooid** ongedaan hebt gemaakt.

## Documentinhoud bewerken

Volg de onderstaande instructies, afhankelijk van hoe documenten worden beheerd in uw SuperOffice-installatie.

<!-- markdownlint-disable-file MD051 -->
### [Met SuperOffice Web Tools](#tab/webtools)

1. Dubbelklik op het gewenste document.

1. Als er een dialoogvenster wordt geopend, klikt u op **Bewerken**.

1. Breng de gewenste wijzigingen aan.

1. Sla het document op en sluit de tekstbewerkingstoepassing.

1. (indien van toepassing) Klik in het dialoogvenster dat wordt weergegeven, op **Ja** als u klaar bent met de bewerking van het document. Klik op **Nee** om het document afgemeld te houden.

    Dit dialoogvenster wordt alleen weergegeven als deze optie is geactiveerd in SuperOffice WebTools.

1. Het document is aangemeld en de status is ingesteld op **Voltooid**.

### [Met SharePoint](#tab/sharepoint)

**Voor deze functie is een licentie vereist.**

1. Dubbelklik op het gewenste document. Het document wordt geopend in een nieuw tabblad met het online tekstbewerkingsprogramma (Office Online).

    Als u uw bewerkingsprogramma op uw bureaublad wilt gebruiken, kiest u **Openen in desktop-app** van Office Online.

2. Bewerk het document.

3. Sluit het tabblad of uw bureaublad-app. Het document wordt automatisch opgeslagen in SharePoint.

### [Zonder SuperOffice Web Tools](#tab/no-webtools)

> [!NOTE]
> In deze procedure wordt beschreven hoe u nieuwe documenten maakt als u een bureaubladtoepassing voor tekstbewerking gebruikt. Het werkelijke proces kan enigszins anders zijn als u een online tekstbewerkingsprogramma (zoals Microsoft Office Online) en een documentbibliotheek (zoals SharePoint) gebruikt.

1. Dubbelklik op het gewenste document.

2. Klik in het dialoogvenster **Document** op **Openen**.

3. Als er een dialoogvenster wordt geopend, klikt u op **Bewerken**.

4. In het dialoogvenster **Bestandsdownload** selecteert u **Openen** of **Opslaan**. Volg vervolgens stap 5-9 uit de procedure [document maken zonder WebTools][2].

***

### <a id="allow"></a>Beveiligingsvraag van de browser bij het openen van bestanden

Wanneer u toegang krijgt tot en een document, bestand of e-mail bewerkt in SuperOffice, vraagt uw browser u om een *beveiligingsvraag* met betrekking tot het downloaden van het bestand.

* Om het bestand te openen, moet u de knop **Openen**/**Toestaan** selecteren.
* Selecteer **Altijd toestaan** om de vraag de volgende keer over te slaan.

De dialoog is enigszins verschillend in Chrome, Edge, Firefox en Safari.

**Chrome:** Selecteer **Openen URL:SuperOffice-Extensions**.

![Chrome: Openen URL:SuperOffice-Extensions -screenshot][img5]

**Edge:** Selecteer **Openen**.

![Edge: Openen -screenshot][img2]

**Firefox:** Selecteer **Link openen**.

![Firefox: Link openen -screenshot][img3]

**Safari:** Selecteer **Altijd toestaan** of **Toestaan**.

![Safari: Altijd toestaan of Toestaan -screenshot][img4]

## <a id="delete"></a>Documenten verwijderen

### Vanuit het Activiteiten-tabblad

1. Selecteer het gewenste document op het sectietabblad **Activiteiten** op de schermen Bedrijf, Persoon, Agenda, Verkoop of Project.

2. Klik met de rechtermuisknop en kies **Verwijderen**.

3. Bevestig of annuleer de verwijdering in het bevestigingsdialoogvenster.

### Vanuit het Documentdialoogvenster

Bij het bekijken van een specifiek document:

1. Klik op de knop **Taak** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) in het **Document**-dialoogvenster.
2. Kies **Verwijderen**.
3. Bevestig of annuleer de verwijdering in het bevestigingsdialoogvenster.

## Probleemoplossing

Als u dubbelklikt op een document en er gebeurt niets, klikt u er met de rechtermuisknop op en selecteert u **Document**. Hiermee wordt het dialoogvenster **Document** geopend. Klik op **Openen** en kijk of het document nu wordt geopend.

### Hoe weet ik of ik SharePoint, SuperOffice WebTools gebruik of niet?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Gerelateerde inhoud

* [De status Voltooid voor een activiteit wijzigen][4]

<!-- Referenced links -->
[1]: lock.md
[2]: create.md
[3]: create.md#fields
[4]: ../../diary/learn/change-completed-status.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/webtools/webtools-edge-security-question.png
[img3]: ../../../media/loc/en/webtools/webtools-firefox-security-question.png
[img4]: ../../../media/loc/en/webtools/webtools-safari-security-question.png
[img5]: ../../../media/loc/en/webtools/webtools-chrome-security-question.png
