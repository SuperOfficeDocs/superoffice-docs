---
uid: help-nl-sales-guide-create
title: Nieuwe verkoopgids maken
description: Zo maakt u een nieuwe verkoopgids in SuperOffice
author: SuperOffice RnD
so.date: 06.29.2022
keywords: verkoop, gids
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: nl
---

# Een nieuwe verkoopgids maken

[!include[Must be admin](../../../learn/includes/req-admin.md)]

Deze procedure toont u hoe u een geheel nieuwe verkoopgids kunt maken.

1. Definieer [fasen](#create-stages) voor opname in de verkoopgids.
2. Definieer [het verkooptype](#create-type) (met gekoppelde fasen) waaraan de verkoopgids wordt gekoppeld.
3. Ontwerpen van de [Verkoopgids](#create-guide).

## <a id="create-stages" />Fasen maken voor de verkoopgids

Een verkoopgids moet worden gekoppeld aan een verkooptype dat weer uit verschillende fasen bestaat. [Het maken van fasen][2].

Een verkoopgids voor verkoop aan nieuwe klanten kan bijvoorbeeld bestaan uit de fasen 'Eerste gesprek', 'Offerte' en 'Contract tekenen'.

Ga naar de volgende procedures om de fasen aan een verkooptype te koppelen.

## <a id="create-type" />Een verkooptype maken voor de verkoopgids

Een verkoopgids moet aan een verkooptype worden gekoppeld. [Het maken van een fasetype][3].

Voorbeelden van verkooptypen: 'Verkoop aan nieuwe klant', 'Verkoop aan bestaande klant', 'Doorverkoop aan bestaande klant'.

1. Vink aan **Dit verkooptype is gekoppeld aan een verkoopgids**.
1. Selecteer ten minste twee fasen.
1. Ga naar de volgende procedure om de verkoopgids te maken.

## <a id="create-guide" />Een verkoopgids maken

Nadat u fasen hebt gemaakt en een verkooptype voor de verkoopgids hebt opgegeven, kunt u de verkoopgids zelf ontwerpen door vervolgactiviteiten en/of documenten voor elke fase toe te voegen.

1. Klik op de knop **Workflow** in de navigator (![pictogram][img1]).

2. Selecteer het tabblad **Verkoopgids**.

3. Selecteer in de lijst bovenin het verkooptype waarvoor u een verkoopgids wilt maken. De fasen die voor dit verkooptype zijn geselecteerd, staat hieronder.

    * wanneer niet is gedefinieerd dat het verkooptype een verkoopgids heeft, klik op **Klik hier om de handleiding in te schakelen** onder aan het scherm klikken.

    * Wanneer geen fasen zijn gedefinieerd voor het verkooptype, klik op **Klik hier om fasen toe te voegen** onder aan het scherm klikken. U kunt het verkooptype ook bewerken door bovenaan op de knop **Bewerken** te klikken.

4. Selecteer de gewenste fase in de lijst. De gegevens van de fase worden onder aan het scherm weergegeven.

5. [Voeg een of meer vervolgactiviteiten](#add-fo-stage) toe voor de geselecteerde fase.

    u hoeft niet voor elke fase een document toe te voegen, maar u moet ten minste één vervolgactiviteit toevoegen voor elke fase.

6. [Voeg een of meer documenten](#add-doc-stage) toe voor de geselecteerde fase.

7. Herhaal stap 4-6 voor elke fase waarvoor u vervolgactiviteiten en documenten wilt toevoegen.

De wijzigingen worden automatisch opgeslagen. De verkoopgids wordt nu weergegeven in SuperOffice CRM wanneer een verkoop wordt aangemaakt met het in stap B geselecteerde verkooptype.

## <a id="add-fo-stage" />Een vervolgactiviteit toevoegen voor een fase

1. Selecteer het gewenste verkooptype en de gewenste verkoopfase, zoals hierboven is beschreven.

2. Klik op **Toevoegen** onder **Voorgestelde vervolgactiviteiten in fase**.

3. Voer in het dialoogvenster **Voorgestelde vervolgactiviteit** de naam van de vervolgactiviteit in het veld **Naam**. Dit moet een herkenbare naam zijn voor de vervolgactiviteit.

4. Voer in het veld **Het doel van deze vervolgactiviteit** de tekst in voor de knopinfo van de vervolgactiviteit op het sectietabblad **Verkoopgids** in SuperOffice CRM.

    > [!NOTE]
    > sommige van de onderstaande opties zijn, om logische redenen, niet relevant voor de eerste vervolgactiviteit in een verkoopgids.

5. Schakel **Deze vervolgactiviteit automatisch voorstellen** in als u wilt dat in SuperOffice CRM deze vervolgactiviteit wordt voorgesteld wanneer de vorige vervolgactiviteit (in deze of de vorige fase) als voltooid is gemarkeerd.

6. Selecteer een type voor de vervolgactiviteit in de lijst **Type vervolgactiviteit**.

7. Geef in het veld **Startdatum** op hoeveel dagen er moeten liggen tussen de vorige vervolgactiviteit en deze.

8. Geef in het veld **Duur** op hoe lang de vervolgactiviteit moet duren. De indeling is *0u00m*.

9. Voer in het veld **Standaardtekst in vervolgactiviteit** een beschrijving voor de vervolgactiviteit in.

    > [!TIP]
    > de gebruiker kan de bovenstaande gegevens indien gewenst wijzigen.

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

## <a id="add-doc-stage" />Een document toevoegen voor een fase

1. Selecteer het gewenste verkooptype en de gewenste verkoopfase, zoals hierboven is beschreven.

2. Klik op **Toevoegen** onder **Voorgestelde documenten in fase**.

3. Voer in het dialoogvenster **Voorgestelde document** de naam van het document in het veld **Naam** in. Dit moet een beschrijvende naam zijn voor het document.

4. Voer in het veld **Het doel van dit document** de tekst in voor de knopinfo van het document op het sectietabblad **Verkoopgids**.

5. Selecteer de gewenste sjabloon in het veld **Sjabloon** (zie ook [Document - Sjabloon][4]).

6. Voer het in het document te gebruiken onderwerp in het veld **Standaardonderwerp** in.

7. Voer eventueel een referentie in het veld **Onze ref.** in. Bijvoorbeeld [sjabloonvariabele][1] voor een verkoopnummer, verkooptitel of een ander veld met betrekking tot de verkoop.

8. Klik op **Opslaan**.

9. Herhaal deze procedure om meer documenten toe te voegen in deze fase of in andere fasen.

### Voorbeeld van een document

**Verkooptype**: Verkoop aan nieuwe klant
**Fase**: Eerste vergadering
**Naam** van document: Bevestiging van vergadering
**Doel van deze verkoopstap**: Een e-mailbericht verzenden met bevestiging van de vergadering en datum/tijd naar alle deelnemers aan de eerste vergadering.
**Sjabloon**: E-mail
**Standaardonderwerp**: Bevestiging van vergadering (eerste gesprek)

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/for-sales.html
[2]: ../../../admin/lists/learn/sale-stage.md
[3]: ../../../admin/lists/learn/sale-type.md
[4]: ../../../admin/lists/learn/document-template.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-workflow-active.png
