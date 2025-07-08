---
uid: help-nl-search-criteria
title: Zoekcriteria gebruiken
description: Zoekcriteria gebruiken
keywords: zoeken, criteria
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Zoekcriteria gebruiken

U gebruikt zoekcriteria om te bepalen waar u naar zoekt, bijvoorbeeld "bedrijven met een adres in Denemarken". Zoekcriteria worden op meerdere plaatsen in SuperOffice CRM gebruikt, zoals in het scherm **Zoeken** en bij het maken van selecties. Waar u de criteria ook voor gebruikt, u werkt er altijd op dezelfde manier mee.

Overal waar u zoekcriteria kunt invoeren, vindt u een criterialijst met de geselecteerde zoekcriteria.

Frequente zoekacties zijn er om u te helpen aan de slag te gaan en uw eigen zoekopdracht voor CRM-gegevens te maken. Nadat u een frequente zoekactie hebt geselecteerd, kunt u de zoekcriteria toevoegen en bewerken. En nadat u een nuttige zoekopdracht hebt gemaakt die u opnieuw wilt gebruiken, kunt u deze opslaan als een selectie.

Bekijk deze video om te leren hoe u een frequente zoekactie uitvoert en deze wijzigt door nieuwe zoekcriteria toe te voegen of volg de stapsgewijze handleiding hieronder:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/gx-vXm-b_7g]

(duur van de video - 3:01)

## Zoekcriteria toevoegen

1. Ga naar de criterialijst.
    * Klik op **Zoeken** in de bovenste balk. De criterialijst staat op het tabblad **Criteria**.
    * Of ga naar de betreffende selectie en selecteer het tabblad **Criteria**.

1. Klik op de knop **Toevoegen**.
    Er wordt een nieuwe regel aan de criterialijst toegevoegd en er wordt een lijst weergegeven met velden waaruit u kunt kiezen.

1. Selecteer het veld waarin u naar gegevens wilt zoeken. U kunt ook het [begin van de naam invoeren][2] in het juiste veld. Er zijn verschillende typen velden:

    * [Tekst](#text)
    * [Ja/nee](#yes-no)
    * [Datum](#date)
    * [Cijfer](#number)
    * [Lijst](#list)
    * [Status](#status)
    * [Teller](#counter)

1. Selecteer waarden voor de zoekcriteria in de verschillende velden op de regel.

1. Klik op **Toevoegen** om een nieuwe regel toe te voegen of klik op **Of** om een nieuwe set criteria toe te voegen.

## Veldtypen

### <a id="text"></a>Tekstveld

Als het veld waarin u zoekt een tekstveld is (zoals een naam), wordt er gezocht naar de tekst of cijfers die u invoert. Er wordt een lijst met de volgende opties weergegeven:

* Begint met:
* Bevat
* Eindigt op
* Is gelijk aan
* Is exact
* Begint niet met
* Bevat niet
* Eindigt niet op
* Is niet

Selecteer een van deze opties en voer vervolgens de zoekcriteria in het tekstveld rechts in.

### <a id="yes-no"></a>Ja/Nee-veld

Als het veld waarin u zoekt een Ja/Nee-veld is (bijvoorbeeld het veld **Geen mailings** in het scherm Bedrijf), worden er twee keuzerondjes weergegeven. U kunt kiezen tussen **Ja** en **Nee**.

### <a id="date"></a>Datumveld

Als het veld waarin u zoekt een datumveld is (bijvoorbeeld het veld **Datum** in het dialoogvenster **Document**), wordt een keuzelijst met de volgende opties weergegeven:

* Voor
* Is gelijk aan
* Na
* Tussen
* Vóór vandaag
* Vandaag
* Na vandaag
* Deze...
* Deze en volgende...
* Volgende...
* Deze en vorige...
* Vorige...
* Deze, vorige en volgende...

Selecteer de gewenste optie. Afhankelijk van uw keuze wordt het veld automatisch gevuld met een datum of datumbereik. U kunt ook zelf een datum invoeren. U kunt ook een datum in de kalender selecteren die wordt weergegeven wanneer u op <i class="ph ph-caret-down" aria-label="Chevron"></i> klikt.

### <a id="number"></a>Nummerveld

Als het veld waarin u zoekt, een numerieke waarde bevat (bijvoorbeeld het veld **Bedrag** in het scherm Verkoop), wordt een keuzelijst met de volgende opties weergegeven:

| Optie | Beschrijving |
|---|---|
| = | Is gelijk aan |
| &gt; | Is groter dan |
| &lt; | Minder dan |
| &gt;= | Groter dan of gelijk aan |
| &lt;= | Kleiner dan of gelijk aan |
| &lt; &gt; | Is niet gelijk aan |
| Tussen | De waarde ligt tussen opgegeven cijfers |

Selecteer de gewenste optie en voer de gewenste numerieke waarde in het tekstveld rechts in.

### <a id="list"></a>Lijstveld

Wanneer het veld waarin u zoekt een veld is dat lijsten bevat (bijvoorbeeld het veld **Branche** op het scherm Bedrijf), wordt een lijst weergegeven met de opties **Is een van** en **Is niet een van**.

Klik op het veld **Items selecteren** om de lijst met waarden weer te geven.

Als de lijst lang is, kunt u tekst typen in de velden **Zoekcriteria** om te zoeken naar waarden.

Klik buiten de lijst om de lijst te sluiten.

### <a id="status"></a>Statusveld

Als het veld waarin u zoekt een statusveld is, selecteer dan de vereiste status.

De statussen worden gemaakt en bijgehouden in Instellingen en onderhoud. Statusvelden zijn alleen van belang als u een licentie voor statuscontroles hebt aangeschaft en statuscontroles hebt ingeschakeld.

### <a id="counter"></a>Tellerveld

[Tellers][3] kunnen bijvoorbeeld voor het aantal verkopen binnen een periode staan, of voor de datum van de laatst afgeronde verkoop.

Tellervelden zijn alleen van belang als u een licentie voor statuscontroles hebt aangeschaft en statuscontroles hebt ingeschakeld.

1. U kunt rechts van de velden klikken op de koppelingen als u aanvullende criteria voor de tellers wilt opgeven. De beschikbare opties zijn afhankelijk van het type record en de teller waarmee u werkt.

    * **SAINT-type**: hier kiest u het type activiteit waarnaar u wilt zoeken.
    * **Status**: hier kiest u de status van de record waarnaar u wilt zoeken.
    * **Richting**: hier kunt u opgeven of de activiteit binnenkomend of uitgaand is.
    * **Bedragklasse**: hier kiest u de bedragklasse van de verkoop.
    * **Intentie**: hier kiest u de intentie van de activiteit.

1. Afhankelijk van uw selectie hierboven, wordt een keuzelijst voor een datumveld of een getalveld weergegeven. Deze keuzelijsten werken op de hierboven beschreven wijze. Selecteer de gewenste optie en voer de gewenste numerieke waarde of datum in het tekstveld in.

U vindt tellervelden onder **Tellers (SAINT)** in de criterialijst. De tellers worden gemaakt en bijgehouden in Instellingen en onderhoud.

## Werken met zoekcriteria

De criterialijsten bevatten een set standaardcriteria die u zo nodig kunt bewerken of verwijderen.

Wanneer u het scherm **Zoeken** opent, bevat het de standaardzoekcriteria of de zoekcriteria die u de laatste keer hebt opgegeven toen u het dialoogvenster gebruikte. Om andere zoekcriteria te gebruiken dan de getoonde criteria, hebt u de volgende opties:

| Taak | Stap |
|---|---|
| Zoekcriteria (een regel) verplaatsen | Klik en sleep met <i class="ph ph-equals" aria-label="="></i>. |
| Zoekcriteria wijzigen | Klikt u erop en selecteert u een ander criterium in de lijst die wordt weergegeven. |
| Een of meer zoekcriteria deactiveren | Geen waarde op te geven voor het veld. |
| Inaktivera alla sökkriterierna | Klik op **Alles deactiverena**. |
| Zoekcriteria verwijderen | Klik op <i class="ph ph-x-circle" aria-label="X"></i>. |
| Standaardzoekcriteria opnieuw instellen | Klikt u op **Standaardwaarde opnieuw instellen**. |

> [!NOTE]
> Zoekcriteria omhoog of omlaag verplaatsen is niet van invloed op de zoekopdracht, maar zo kunt u de criteria rangschikken in de volgorde die uw voorkeur heeft. Als u ongebruikte criteria wilt behouden, kunt u de inactieve criteria verplaatsen naar onder aan de lijst.
>
> Een gedeactiveerd zoekcriterium blijft in de criterialijst staan en kan zo nodig opnieuw worden geactiveerd.

## Gerelateerde inhoud

* [Het scherm Zoeken gebruiken][1]
* [Selecties][4]

<!-- Referenced links -->
[1]: find-screen.md
[2]: in-navigator.md
[3]: ../../saint/learn/index.md
[4]: ../selection/learn/index.md
