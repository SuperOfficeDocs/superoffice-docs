---
uid: help-nl-bulk-update
title: Bulksgewijs bijwerken
description: Met bulksgewijs bijwerken kunt u details wijzigen voor een grote groep personen, activiteiten, verkopen, projecten en meer.
keywords: bulkgewijs bijwerken, bulk, bulk update, gegevens bijwerken
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from: /nl/search-options/selection/learn/howto/bulk-update
---

# Meerdere records bijwerken (bulksgewijs bijwerken)

Met Bulkgewijs bijwerken kunt u in meerdere records tegelijk waarden wijzigen van hetzelfde type. U kunt alle of geselecteerde records bulksgewijs bijwerken in sectietabbladen (archieven), selecties en het scherm **Zoeken**. U kunt specifieke waarden bijwerken of wissen. Deze taak kan ook worden gebruikt om meerdere records te verwijderen.

> [!NOTE]
> U hebt specifieke rechten nodig om Bulksgewijs bijwerken te kunnen gebruiken. Deze rechten worden toegewezen in de Instellingen en het onderhoud.

## Stappen

1. Open de selectie, het sectietabblad (archief) of de zoekresultaten (scherm **Zoeken**) met de records die u wilt bijwerken.

2. Klik op de **Taak**-knop (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) en kies **Bulk update**.
    Of, selecteer de records die u wilt bijwerken, klik met de rechtermuisknop en kies **Bulk update...**.

    Het dialoogvenster **Bulkgewijs bijwerken** wordt geopend. Onder aan dit dialoogvenster kunt u het type record zien en hoeveel records er moeten worden bijgewerkt. Bijvoorbeeld: Aantal personen in wachtrij voor bulkgewijs bijwerken: 7.

    > [!NOTE]
    > Als de selectie zowel bedrijven als personen bevat, zijn er twee tabbladen: **Bedrijf** en **Persoon**.

3. Selecteer een veld dat u wilt bijwerken in de kolom **Veld**. U kunt de naam ook in het veld typen. Terwijl u elke letter typt, worden in de onderstaande lijst alle overeenkomsten weergegeven die relevant zijn voor de geselecteerde records.

4. Selecteer een actie in de kolom **Actie**. De beschikbare acties zijn afhankelijk van het type veld dat u in de vorige stap hebt geselecteerd. Voorbeelden:

    * **Gedaan**: een selectievakje in- of uitschakelen.
    * **Wisselknop**: een ingeschakeld selectievakje uitschakelen en omgekeerd.
    * **Zoeken en vervangen**: [Een tekst zoeken en vervangen](#search-and-replace).
    * **Reguliere expressie**: Een veld bijwerken met gebruik van [reguliere expressies](#regex).
    * **Instellen**: een nieuwe waarde toepassen op het veld.
    * **Wissen**: wis elke waarde in het veld.
    * Acties in de lijst: selecteer of wis een enkele of meerdere waarden voor velden met lijsten.
    * Acties voor activiteitenkoppeling: activiteitenkoppelingen toevoegen, verwijderen of vervangen of alle activiteitenkoppelingen wissen.

5. Klik op **Toevoegen** en herhaal stappen 3 en 4 om meer velden toe te voegen die moeten worden bijgewerkt.

6. Zorg ervoor dat de velden die u wilt bijwerken zijn geselecteerd (<i class="ph ph-check" aria-hidden="true"></i>) en dat niet-bijgewerkte velden zijn uitgeschakeld.

7. Klik op **Bijwerken**. Het dialoogvenster **Bevestigen** wordt geopend en geeft een overzicht van de updates weer.

8. Klik op **Ja** om de wijzigingen in de geselecteerde records te implementeren.

    > [!CAUTION]
    > Eenmaal toegepast, kunnen bulkupdates niet ongedaan worden gemaakt. U kunt het bijwerken echter onderbreken terwijl het bezig is. Alle records die nog niet zijn bijgewerkt, blijven dan ongewijzigd.

9. Klik op **Logboek** om het wijzigingenlogboek weer te geven. Als bepaalde records niet zijn bijgewerkt, wordt de reden weergegeven in de kolom **Redenen waarom**.

10. Klik op **Sluiten**.

## <a id="search-and-replace"></a>Zoeken en vervangen

Met het actietype **Zoeken en vervangen** kunt een specifieke tekst in een veld zoeken en deze vervangen.

1. Selecteer **Zoeken en vervangen** in de kolom **Actie**.
2. Typ de tekst die moet worden vervangen in het veld **Zoeken**.
3. Typ de vervangende tekst in het veld **Vervangen door**.
4. Optioneel: Klik op **Opties** en selecteer de instellingen voor hoofdlettergevoeligheid en om volledige woorden of woorddelen te zoeken.

## <a id="regex"></a>Reguliere expressies

Met het actietype **Reguliere expressie** kunt u reguliere expressies gebruiken om een veld bij te werken.

1. Selecteer **Reguliere expressie** in de kolom **Actie**.
2. Geef de expressie op in het veld **Expressie**.
3. Typ de vervangende tekst in het veld **Vervangen door**.
4. Optioneel: Klik op **Opties** en selecteer de instellingen voor de reguliere expressie.

## Voorbeelden

## Bedrijfscategorieën bijwerken

U wilt uw klanten categoriseren op verkoopbedragen. Maak bedrijfscategorieën met de namen "Klant A", "Klant B" en "Klant C" in SuperOffice CRM. Voor "Klant A" kunt een selectie maken van bedrijven met verkoopbedragen boven de EUR 50.000 over het laatste jaar. Gebruik **Bulkgewijs bijwerken** om de categorie voor deze klanten bij te werken naar "Klant A". Herhaal dit proces voor de andere bedrijven.

## De postcode voor het bedrijf bijwerken

Postcodes en postplaatsen in Noorwegen zijn veranderd. Gebruik dan **Bulkgewijs bijwerken** om de adressen bij te werken.

## Persoon bijwerken

U ontdekt dat het contactveld **Positie** zelden wordt gebruikt. Omdat u in elk geval wilt beginnen met het invullen van dit veld voor alle personen, wilt u iedereen zoeken met de functie directeur. Maak een selectie van alle personen met het woord "directeur" in het veld **Functie**. Gebruik **Bulkgewijs bijwerken** om het veld **Positie** in te stellen als **Management**.

## Project bijwerken

U wilt alle "oude" projecten opschonen die niet zijn ingesteld als voltooid. Maak een selectie van al uw oude projecten, bijvoorbeeld van alle projecten die meer dan 2 jaar geleden zijn gemaakt en die de laatste jaren niet zijn bijgewerkt. Gebruik **Bulkgewijs bijwerken** om de status **Voltooid** voor deze projecten in stellen als **Ja**.

## Gerelateerde inhoud

* [Hoe vul ik voor veel personen in één keer de velden "Juridische basis", "Toestemmingsbron" en "Doel" in in SuperOffice CRM?][3]
* [Massaal personen en bedrijven uit selectie verwijderen][1]

<!-- Referenced links -->
[1]: ../../security/privacy/learn/mass-delete.md
[3]: ../../../en/security/privacy/learn/edit-legal-base.md#bulk
