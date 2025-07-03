---
uid: help-nl-sales-guide-create
title: Een nieuwe verkoopgids maken
description: Leer hoe u een verkoopgids kunt maken in SuperOffice.
keywords: verkoopgids, verkoophandleiding, gids, workflow, verkoop
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: settings
audience_tooltip: Settings and Maintenance
language: nl
redirect_from: /nl/sale/learn/sales-guide/create
index: true
---

# Een nieuwe verkoopgids maken

[!include[Moet een beheerder zijn](../../learn/includes/req-admin.md)]

In Instellingen en onderhoud kunt u definiëren welke verkooptypen een verkoopgids moeten krijgen en welke fasen en activiteiten deze gidsen moeten bevatten. Hierdoor kan het uiterlijk van een verkoopgids variëren.

De beste manier om uw eigen verkoopproces te definiëren, is eerst te overleggen en overeenstemming te bereiken over de best practices binnen uw verkoopteam. U kunt meerdere verkooptypen met gidsen instellen als uw bedrijf meerdere verkoopprocessen gebruikt.

Bijvoorbeeld:

* Een verkooptype met gids voor **prospects**
* Een verkooptype met gids voor **bestaande klanten**
* Een verkooptype voor **langlopende verkoopprocessen** met meerdere fasen en activiteiten

Deze procedure laat zien hoe u een verkoopgids vanaf nul maakt.

1. Definieer [fasen](#create-stages) voor de verkoopgids.
2. Definieer [het verkooptype](#create-type) (met de bijbehorende fasen) waaraan de verkoopgids wordt gekoppeld.
3. Ontwerp de [verkoopgids](#create-guide).

## <a id="create-stages"></a>Fasen maken voor de verkoopgids

Een verkoopgids moet worden gekoppeld aan een verkooptype dat bestaat uit verschillende fasen. [Zo maakt u fasen][2].

Een verkoopgids voor verkoop aan nieuwe klanten kan bijvoorbeeld bestaan uit de fasen "Eerste gesprek", "Offerte uitbrengen", "Contract ondertekenen".

Ga naar de volgende procedure om de fasen aan een verkooptype te koppelen.

## <a id="create-type"></a>Een verkooptype maken voor de verkoopgids

Een verkoopgids moet worden gekoppeld aan een verkooptype. [Zo maakt u een verkooptype][3].

Voorbeelden van verkooptypen: "Verkoop aan nieuwe klant", "Verkoop aan bestaande klant", "Doorverkoop aan bestaande klant".

1. Vink aan **Dit verkooptype is gekoppeld aan een verkoopgids**.
1. Selecteer ten minste twee fasen.
1. Ga naar de volgende procedure om de verkoopgids te maken.

## <a id="create-guide"></a>Een verkoopgids maken

Nadat u fasen hebt gemaakt en een verkooptype voor de verkoopgids hebt opgegeven, kunt u de verkoopgids zelf ontwerpen door vervolgactiviteiten en/of documenten voor elke fase toe te voegen.

1. Klik op <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow** in de navigator.

2. Selecteer het tabblad **Verkoopgids**.

3. Selecteer in de lijst bovenin het verkooptype waarvoor u een verkoopgids wilt maken. De fasen die voor dit verkooptype zijn geselecteerd, staat hieronder.

    * wanneer niet is gedefinieerd dat het verkooptype een verkoopgids heeft, klik op **Klik hier om de handleiding in te schakelen** onder aan het scherm klikken.

    * Wanneer geen fasen zijn gedefinieerd voor het verkooptype, klik op **Klik hier om fasen toe te voegen** onder aan het scherm klikken. U kunt het verkooptype ook bewerken door bovenaan op de knop **Bewerken** te klikken.

4. Selecteer de gewenste fase in de lijst. De gegevens van de fase worden onder aan het scherm weergegeven.

5. [Voeg een of meer vervolgactiviteiten toe](#add-fo-stage) voor de geselecteerde fase.

    > [!TIP]
    > U hoeft niet voor elke fase een document toe te voegen, maar u moet ten minste één vervolgactiviteit toevoegen voor elke fase.

6. [Voeg een of meer documenten toe](#add-doc-stage) voor de geselecteerde fase.

7. Herhaal stap 4-6 voor elke fase waarvoor u vervolgactiviteiten en documenten wilt toevoegen.

De wijzigingen worden automatisch opgeslagen. De verkoopgids wordt nu weergegeven in SuperOffice CRM wanneer een verkoop wordt aangemaakt met het in stap 3 geselecteerde verkooptype.

## <a id="add-fo-stage"></a>Een vervolgactiviteit toevoegen voor een fase

1. Selecteer het gewenste verkooptype en de gewenste fase zoals hierboven beschreven.

2. Klik op **Toevoegen** onder **Voorgestelde vervolgactiviteiten in fase**.

3. Voer in het dialoogvenster **Voorgestelde vervolgactiviteit** de naam van de vervolgactiviteit in het veld **Naam** in. Dit moet een duidelijke en herkenbare naam zijn.

4. Typ in het veld **Het doel van deze vervolgactiviteit** de tekst die als tooltip wordt weergegeven in het sectietabblad **Verkoopgids** in SuperOffice CRM.

    > [!NOTE]
    > Sommige van de onderstaande opties zijn, om logische redenen, niet relevant voor de eerste vervolgactiviteit in een verkoopgids.

5. Schakel **Deze vervolgactiviteit automatisch voorstellen** in als u wilt dat SuperOffice CRM deze activiteit automatisch voorstelt wanneer de vorige activiteit (in deze of de vorige fase) als voltooid is gemarkeerd.

6. Selecteer een type voor de vervolgactiviteit in de lijst **Type vervolgactiviteit**.

7. Geef in het veld **Startdatum** op hoeveel dagen er tussen de vorige en deze vervolgactiviteit moeten zitten.

8. Geef in het veld **Duur** op hoe lang de vervolgactiviteit moet duren. De indeling is *0u00m*.

9. Voer in het veld **Standaardtekst in vervolgactiviteit** een beschrijving in van de activiteit.

    > [!TIP]
    > De gebruiker kan deze informatie aanpassen indien nodig.

10. Klik op **Opslaan**.

11. Herhaal deze procedure om meer vervolgactiviteiten toe te voegen in deze fase of in andere fasen.

### Voorbeeld van een vervolgactiviteit

**Verkooptype**: Verkoop aan nieuwe klant
**Fase**: Eerste vergadering
**Naam** van vervolgactiviteit: Eerste vergadering
**Doel van deze vervolgactiviteit**: Controleer de behoeften van de potentiële klant en ga na of uw product aan deze behoeften kan voldoen
**Type vervolgactiviteit**: Klantgesprek
**Duur**: 1 uur
**Standaardtekst**:

Agenda voor eerste gesprek:

\- Informatie over het bedrijf en de organisatie van de klant
\- Behoeften, wensen, problemen
\- Bedrijfspresentatie
\- Wvttk

## <a id="add-doc-stage"></a>Een document toevoegen voor een fase

1. Selecteer het gewenste verkooptype en de gewenste fase zoals hierboven beschreven.

2. Klik op **Toevoegen** onder **Voorgestelde documenten in fase**.

3. Voer in het dialoogvenster **Voorgestelde document** de naam van het document in het veld **Naam** in. Dit moet een beschrijvende naam zijn die de inhoud en het doel van het document duidelijk maakt.

4. Voer in het veld **Het doel van dit document** de tekst in die als tooltip wordt weergegeven in het sectietabblad **Verkoopgids**.

5. Selecteer de juiste [sjabloon][4] in het veld **Sjabloon**.

6. Voer in het veld **Standaardonderwerp** het onderwerp in dat in het document gebruikt moet worden.

7. Voer eventueel een referentie in het veld **Onze ref.** in. Bijvoorbeeld een [sjabloonvariabele][1] voor een verkoopnummer, verkooptitel of een ander veld dat gerelateerd is aan de verkoop.

8. Klik op **Opslaan**.

9. Herhaal deze procedure om meer documenten toe te voegen in deze of andere fasen.

### Voorbeeld van een document

**Verkooptype**: Verkoop aan nieuwe klant
**Fase**: Eerste vergadering
**Naam** van document: Bevestiging van vergadering
**Doel van deze verkoopstap**: Een e-mailbericht verzenden met bevestiging van de vergadering en datum/tijd naar alle deelnemers aan de eerste vergadering.
**Sjabloon**: E-mail
**Standaardonderwerp**: Bevestiging van vergadering (eerste gesprek)

<!-- Referenced links -->
[1]: ../../document/templates/variables/for-sales.md
[4]: ../../document/templates/learn/index.md
[2]: sale-stage.md
[3]: sale-type.md
