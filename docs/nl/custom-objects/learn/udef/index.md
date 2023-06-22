---
uid: help-nl-udef
title: Velden web
description: Velden web
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, aangepast veld
so.topic: concept
so.user: admin
so.user.tooltip: Settings and maintenance
language: nl
---

# Door gebruiker gedefinieerde velden

Verschillende onderdelen van SuperOffice CRM, zoals het scherm Bedrijf, hebben een afzonderlijk tabblad met de naam **Meer**. Op dit tabblad kunt u zelf velden invoeren om het programma aan te passen aan de vereisten binnen uw bedrijf. [!include[SM](../../../learn/includes/are-defined-sm.md)]

Alle bedrijven en organisaties hebben hun eigen vereisten voor de informatie die ze moeten registreren met betrekking tot hun klanten, verkoop, projecten, contracten, enzovoort. U kunt uw eigen velden invoeren voor SuperOffice CRM in het scherm **Velden**. Zo kunt u het type informatie aanpassen dat kan worden geregistreerd met betrekking tot bedrijven, personen, projecten, verkoop, documenten en vervolgactiviteiten.

> [!NOTE]
> U kunt 3 velden opgeven die worden weergegeven op de 'eerste pagina' van hun respectievelijke schermen en dialoogvensters. [Hoe][1]. Houd er rekening mee dat dit mogelijk niet van toepassing is als u een andere opmaak gebruikt via de [Schermontwerper][8].

## <a id="field-types" />Veldtypen

[!include[List of field types](includes/field-types.md)]

## Welk voordeel kan ik behalen van de informatie die ik in deze velden invoer?

* Met de zoekfunctie **Zoeken** kunt u naar informatie zoeken die u in deze velden heeft geregistreerd en dynamische selecties maken.
    **Voorbeeld**: Als u de verloopdatum vastlegt van de onderhoudsovereenkomst die u met klanten hebt, kunt u een dynamische selectie maken die de klanten laat zien voor wie de overeenkomst in minder dan een maand verloopt.

* Met sjabloonvariabelen kunt u de informatie uit deze velden hergebruiken voor documenten en e-mails. Ieder toegevoegd veld heeft zijn unieke ID, welke kan worden gebruikt in documenten om klantspecifieke informatie samen te voegen.
    **Voorbeeld**: Als u een e-mail verzendt naar klanten met daarin het bericht dat de onderhoudsovereenkomst binnenkort verloopt, kan de sjabloonvariabele worden gebruikt om de juiste verloopdatum in het te verzenden bericht op te nemen.

## Waar worden de velden die ik maak, weergegeven?

* [Het tabblad Meer (Bedrijf)][6]
* [Het tabblad Meer (Contactpersoon)][7]
* [Het tabblad Meer (Project)][3]
* [Het tabblad Meer (Vervolgactiviteit)][4]
* [Het tabblad Meer (Document)][5]
* Het tabblad Details in het scherm Verkoop

U kunt *pagina 1-velden* opgeven (velden die worden weergegeven op de 'eerste pagina' van de schermen en dialoogvensters) op de volgende locaties:

[!include[List](includes/list-page-1-field-locations.md)]

## Voorbeelden

### Door gebruikers gedefinieerde velden voor bedrijven

Uw bedrijf verkoopt software en supportdiensten voor gebruikers. De afdeling Gebruikersondersteuning moet weten hoeveel medewerkers en pc's de diverse klanten hebben. De afdeling moet ook weten wat voor een onderhoudsovereenkomst de klanten hebben en wanneer deze verloopt.

U kunt dan deze schermen toevoegen aan het scherm Bedrijf:

| Veldnaam | Type | Beschrijving |
|---|---|---|
| Aantal pc's | Cijfer | Een nummerveld waarin u het aantal pc's kunt vastleggen. |
| Aantal werknemers | Cijfer | Een nummerveld waarin u het aantal werknemers kunt vastleggen. |
| Onderhoudsovereenkomst | Lijst | Een lijst met de diverse onderhoudsovereenkomsten die u aanbiedt. Deze lijst moet [worden aangemaakt in het scherm Lijsten][2]. |
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

<!-- Referenced links -->
[1]: page-1-fields.md
[2]: ../../../admin/lists/learn/adding-user-defined-lists.md
[3]: ../../../project/learn/index.md#more-tab
[4]: ../../../diary/learn/screen/dialog-for-followups.md
[5]: ../../../document/learn/screen/index.md
[6]: ../../../company/learn/create.md#more-tab
[7]: ../../../contact/learn/create.md#more-tab
[8]: ../../../ui/screen-designer/learn/index.md

<!-- Referenced images -->