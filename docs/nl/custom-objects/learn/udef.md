---
uid: help-nl-udef
title: Gebruikersgedefinieerde velden
description: Gebruikersgedefinieerde velden
keywords: udef, aangepast veld, gebruikersgedefinieerd
author: Bergfrid Dias
date: 01.30.2024
version: 10
topic: concept
audience: user
audience_tooltip: SuperOffice CRM
language: nl
---

# Gebruikersgedefinieerde velden

Een *gebruikersgedefinieerd* veld (udef) is een aangepast veld dat u toevoegt aan een standard SuperOffice-databasetabel. U kunt de volgende entiteiten uitbreiden:

* Bedrijf
* Persoon
* Documenten
* Vervolgactiviteit
* Project
* Verkoop

Gebruikersgedefinieerde velden worden beheerd in Instellingen en onderhoud, in het scherm **Velden**. In de applicatie zijn gebruikersgedefinieerde velden zichtbaar op het **Meer**-tabblad van de entiteit waaraan ze zijn toegevoegd. Bijvoorbeeld wordt een gebruikersgedefinieerd veld op een bedrijf weergegeven op het **Meer**-tabblad in het scherm Bedrijf.

> [!NOTE]
> Iedereen kan de gegevens in een gebruikersgedefinieerd veld **bijwerken**. Alleen een beheerder kan een gebruikersgedefinieerd veld toevoegen (of verwijderen). U hebt een Development Tools-licentie nodig om het ontwerp van het **Meer**-tabblad aan te passen en pagina 1-velden te gebruiken.

## <a id="field-types"></a>Veldtypen

* **Getal**: Geheel getal, onbeperkt aantal cijfers.
* **Korte tekst**: Een tekst van maximaal 39 tekens. Geef in het veld **Tekstlengte**, dat is ingeschakeld wanneer u deze optie kiest, het maximaal aantal tekens aan dat door gebruikers in dit veld ingevoerd kan worden.
* **Lange tekst**: Een tekst van maximaal 199 tekens. Geef in het veld **Tekstlengte**, dat is ingeschakeld wanneer u deze optie kiest, het maximaal aantal tekens aan dat door gebruikers in dit veld ingevoerd kan worden.
* **Datum**: Een datum tussen 01-01-1970 en 19-01-2038.
* **Onbeperkte datum**: Een willekeurige datum.
* **Selectievakje**: Een selectievakje.
* **Lijst**: Een keuzelijst. Selecteer een lijst uit het systeem uit het veld hieronder.
* **Decimaal**: Een getal met decimalen.

## <a id="limit"></a>Maximumaantal velden

De volgende beperkingen gelden voor het aantal door gebruikers gedefinieerde velden dat u kunt opgeven op elk van de tabbladen Bedrijf, Persoon, Project en Verkoop.

* **Nummer**, **Datum**, **Selectievakje** en **Lijst**: Maximaal 60 in totaal.
* **Korte tekst** en **Onbegrensde datum**: Maximaal 40 in totaal.
* **Lange tekst**: Maximaal 9 in totaal.
* **Decimaal**: Maximaal 10 in totaal.

> [!NOTE]
> Vier van de door de gebruiker gedefinieerde velden in elke groep moeten worden geïndexeerd.

## <a id="index"></a>Geïndexeerde velden

Indexering is goed voor de gebruikerservaring en prestaties. De eerste 4 velden van elk gegevenstype zijn gereserveerd voor indexen.

U moet het selectievakje aanvinken bij het maken van het veld om indexering toe te staan. U kunt tot 4 velden markeren in elk van de 4 gegevenstypen (Long, Double, String[40], String[200]) voor elke entiteit. U kunt bijvoorbeeld 4 getallen en 4 decimalen indexeren voor een contact, maar u kunt niet tegelijkertijd ook een datum indexeren - omdat alle Long-indexposities worden ingenomen door de getallen.

Als u ervoor kiest helemaal niet te indexeren, verspilt u in feite 16 velden! Hierdoor wordt het maximale aantal aangepaste velden teruggebracht tot 103.

## <a id="page-1"></a>Velden pagina 1

Uit de door gebruikers gedefinieerde velden die worden weergegeven op de tabbladen **Meer** in SuperOffice CRM kunt u *drie* velden kiezen die fungeren als velden voor pagina 1 (deze heten zo omdat de velden worden weergegeven op de eerste pagina van de respectievelijke schermen).

**Locaties:**

* Op het tabblad **Bedrijf** in het scherm Bedrijf
* Op het tabblad **Persoon** op het scherm Persoon
* Op het tabblad **Project** in het scherm Project
* Op het tabblad **Verkoop** in het scherm Verkoop
* Het tabblad **Details** in het scherm Document

> [!NOTE]
> Pagina-1 veld vereist de licentie Development Tools en is niet beschikbaar als de organisatie een andere lay-out gebruikt via [Schermontwerper][8].

## Voorbeelden

### Door gebruikers gedefinieerde velden voor bedrijven

Uw bedrijf verkoopt software en supportdiensten voor gebruikers. De afdeling Gebruikersondersteuning moet weten hoeveel medewerkers en pc's de diverse klanten hebben. De afdeling moet ook weten wat voor een onderhoudsovereenkomst de klanten hebben en wanneer deze verloopt.

U kunt dan deze schermen toevoegen aan het scherm Bedrijf:

| Veldnaam | Type | Beschrijving |
|---|---|---|
| Aantal pc's | Cijfer | Een nummerveld waarin u het aantal pc's kunt vastleggen. |
| Aantal werknemers | Cijfer | Een nummerveld waarin u het aantal werknemers kunt vastleggen. |
| Onderhoudsovereenkomst | Lijst | Een lijst met de diverse onderhoudsovereenkomsten die u aanbiedt. Deze lijst moet [worden aangemaakt in het scherm Lijsten][3]. |
| Het contract verloopt | Datum | Een datumveld waarin u de verloopdatum van het contract kunt vastleggen. |
| Toepassing A; Toepassing B; Toepassing C | Selectievakje | Drie selectievakjes waarin u de toepassingen kunt selecteren die de klant heeft gekocht. |

> [!NOTE]
> De velden die u toevoegt, worden weergegeven op het tabblad **Meer** in het scherm Bedrijf. Als u ze op de bedrijfskaart wilt weergeven, [geeft u ze op als *velden pagina 1*][1].

### Door gebruikers gedefinieerde velden voor verkopen

Wanneer u een verkoop maakt, kan het handig zijn de producten in te voeren die u hebt verkocht en de hoeveelheid.

U kunt dan deze velden toevoegen aan het scherm Verkoop:

| Veldnaam | Type | Beschrijving |
|---|---|---|
| Product | Lange tekst | Een tekstveld waarin u de naam kunt typen van het product dat is verkocht. |
| Hoeveelheid | Cijfer | Een nummerveld waarin u het aantal verkochte eenheden kunt vastleggen. |

> [!TIP]
> Hier kunt u ook een lijst-veld gebruiken als u een lijst heeft gemaakt van de door u verkochte producten.

### Door gebruikers gedefinieerde velden voor projecten

U wilt dat het budget voor een product duidelijk zichtbaar is voor de projectleden.

U kunt dan deze velden toevoegen aan het scherm Project:

| Veldnaam | Type | Beschrijving | Commentaar |
|---|---|---|---|
| Budget | Decimaal | Een nummerveld waarin u een som kunt invoeren. | [Kies of het veld op pagina 1 moet worden weergegeven][1]. |

## Gerelateerde inhoud

* [Door gebruiker gedefinieerd veld toevoegen][2]

<!-- Referenced links -->
[1]: ../admin/edit-udef-layout.md#page-1
[2]: ../admin/add-udef.md
[3]: ../../admin/lists/learn/adding-user-defined-lists.md
[8]: ../../ui/screen-designer/learn/index.md

<!-- Referenced images -->