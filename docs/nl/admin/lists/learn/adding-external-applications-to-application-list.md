---
uid: help-nl-adding-external-applications-to-application-list
title: Externe toepassingen toevoegen aan de lijst Toepassing
description: Externe toepassingen toevoegen aan de lijst Toepassing
keywords: lijst GUI - Toepassing
author: SuperOffice RnD
date: 03.14.2025
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Items toevoegen aan de lijst GUI - Toepassing

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

[!include[Edit list item](includes/edit-list-item.md)] Wanneer de items toepassingen of soortgelijke artikelen zijn:

> [!NOTE]
> Bestanden of toepassingen die lokaal moeten worden uitgevoerd (bijvoorbeeld *.exe*-bestanden) zijn niet toegankelijk in SuperOffice CRM for Web.

1. Typ de gewenste naam voor het item in het veld **Naam**. Deze naam wordt weergegeven op de plaats waar u de toepassing in SuperOffice CRM invoegt (zie stap 7 met betrekking tot de keuzelijst **Weergeven**).

    > [!NOTE]
    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Geef onder **Toevoegen als** aan hoe de toepassing moet worden toegevoegd:

    * **Knop**: het toepassingspictogram wordt weergegeven in de navigator. Gebruikers kunnen de toepassing rechtstreeks starten door te klikken op het pictogram in de navigator.
    * **Menu-item**: de gebruiker kan de toepassing starten door te klikken op de knop **Hulpmiddelen** (<i class="ph ph-wrench" aria-hidden="true"></i>) in de navigator en/of door **Andere toepassingen** te selecteren in het hoofdmenu (<i class="ph ph-list" aria-hidden="true"></i>).
    * **Gebeurtenis**: de toepassing wordt uitgevoerd wanneer SuperOffice CRM wordt gestart of afgesloten, of bij een lokale update (Travel). Zie stap 8. U kunt bijvoorbeeld een synchronisatieprogramma uitvoeren voor een PDA wanneer SuperOffice CRM wordt afgesloten.
    * **Taak**: selecteer een optie in deze keuzelijst om de toepassing toegankelijk te maken vanaf het tabblad **Taak** op het scherm Selectie, of de knoppen **Taak**.

        <details><summary>Meer informatie over de verschillende opties.</summary>

        De namen tussen haakjes geven het sectietabblad aan waar de toepassing beschikbaar is.

        Voorbeelden:

        * **Selectie verkoop (verkoop)**: Nadat u een selectie verkoop hebt geopend in het scherm Selectie en het sectietabblad **Verkoop** is ingeschakeld, wordt de toepassing weergegeven als een taak op het tabblad **Taak**.
        * **Selectie verkoop (bedrijven)**: Nadat u een selectie verkoop hebt geopend in het scherm Selectie en het sectietabblad **Bedrijven** is ingeschakeld, wordt de toepassing weergegeven als een taak op het tabblad **Taak**.
        * **Selectie verkoop (extern)**: Als uw SuperOffice CRM-installatie is gekoppeld aan een toepassing van derden, kunnen andere sectietabbladen worden weergegeven voor de verschillende selecties. U kunt vervolgens bijvoorbeeld **Selectie verkoop (extern)** selecteren om de toepassing als taak weer te geven op het tabblad **Taak** wanneer u een selectie verkoop opent in het scherm Selectie en het sectietabblad voor toepassingen van derden actief is.

        Andere opties:

        * **Werkbalk**: de toepassing wordt weergegeven als een optie op de werkbalk. Gebruikers moeten de werkbalk in SuperOffice CRM configureren en ervoor kiezen de toepassing weer te geven.

        * **Dialoogvenster voor Vervolgactiviteiten**: de toepassing wordt weergegeven als een optie onder de knop **Taak** in het dialoogvenster voor vervolgactiviteiten.

        * **Dialoogvenster Document**: de toepassing wordt weergegeven als een optie onder de knop **Taak** in het geselecteerde dialoogvenster. Dezelfde optie is beschikbaar voor de schermen Persoon, Offerte en Product.

        </details>

    > [!NOTE]
    > de opties die u kiest bij **Toevoegen als**, bepalen welke opties beschikbaar zijn in de rest van het dialoogvenster.

1. Geef onder **Beschikbaar op** aan waar de toepassing beschikbaar is. U kunt meerdere opties tegelijk selecteren.

    * **Centrale database**: wanneer u werkt met de centrale database.
    * **Satellite**: wanneer u werkt met een satelliet.
    * **Travel**: wanneer u een lokale database gebruikt met Travel.

1. Geef de gewenste toepassing op in het veld **Bestandsnaam**.

1. Geef de opstartparameters voor de toepassing op in het veld **Parameters**.

1. In het veld **Werkmap** kunt u opgeven welke map u wilt gebruiken als beginmap bij het uitvoeren van het programma. Voer het pad handmatig in. U laat dit veld normaalgesproken leeg.

1. Selecteer de gewenste optie in de keuzelijst **Weergeven**. Deze keuzelijst is alleen beschikbaar wanneer u **Menu-item** hebt geselecteerd onder **Toevoegen als**.

    * **Modulemenu**: de gebruiker kan de toepassing starten door te klikken op de knop **Hulpmiddelen** in de navigator of door **Andere toepassingen** te selecteren in het hoofdmenu in SuperOffice CRM.
    * **Weergavemenu**: de gebruiker kan de toepassing openen via de optie **Andere toepassingen** in het menu **Weergave** in SuperOffice CRM.

1. Kies in de keuzelijst **Starten als** wanneer de toepassing moet worden uitgevoerd. Deze keuzelijst is alleen beschikbaar wanneer u **Gebeurtenis** hebt geselecteerd onder **Toevoegen als**.

    * **SuperOffice CRM start**: de toepassing wordt uitgevoerd wanneer SuperOffice CRM start.
    * **SuperOffice CRM sluit af**: de toepassing wordt uitgevoerd wanneer SuperOffice CRM wordt afgesloten.
    * **Lokale update**: de toepassing wordt uitgevoerd wanneer Travel wordt gebruikt.

1. Schakel het vakje **Wacht tot de toepassing klaar is** in als u wilt dat SuperOffice CRM pas wordt afgesloten wanneer de externe toepassing is afgesloten. Als u deze optie niet inschakelt, kunt u SuperOffice CRM sluiten zonder de externe toepassing te sluiten. Deze keuzelijst is alleen beschikbaar wanneer u **Gebeurtenis** hebt geselecteerd onder **Toevoegen als**.

1. Kies onder **Opstartmodus** het type venster waarin de toepassing wordt gestart – Gemaximaliseerd, Geminimaliseerd of Hersteld.

1. Kies in het veld **Pictogram** het pictogram dat voor de toepassing wordt weergegeven in de Navigator van SuperOffice CRM (zie stap 7 met betrekking tot de keuzelijst **Weergeven**). Deze keuzelijst is alleen beschikbaar wanneer u **Knop** hebt geselecteerd onder **Toevoegen als**.

    * **Uit bibliotheek**: Selecteer een van de beschikbare pictogrammen in de lijst.
    * **Programmapictogram gebruiken**: Gebruik het standaard pictogram voor de geselecteerde toepassing.

1. Typ zo nodig een beschrijving voor de koptekst in het veld **Beschrijving**.

1. Klik op **Opslaan**. Het item wordt nu toegevoegd aan de lijst **Items**. Herhaal deze procedure om meer items toe te voegen.

> [!NOTE]
> gebruikers moeten zich opnieuw aanmelden bij SuperOffice CRM om de toepassing weer te geven.
