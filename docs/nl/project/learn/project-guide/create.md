---
uid: help-nl-project-guide-create
title: Een nieuwe projectgids maken
description: Zo maakt u een nieuwe projectgids in SuperOffice
author: SuperOffice RnD
so.date: 02.23.2023
keywords: project, gids, workflow
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: nl
---

# Een nieuwe projectgids maken

[!include[Must be admin](../../../learn/includes/req-admin.md)]

Welke projecttypen aan een projectgids moeten worden toegewezen en welke statussen en activiteiten de projectgidsen moeten bevatten, wordt ingesteld in Instellingen en onderhoud. Hoe een projectgids eruitziet, kan dus variëren. Hieronder staat een voorbeeld van een project waarbij gebruik wordt gemaakt van een projectgids.

Stel u voor dat u een projecttype hebt met de naam **Conferentie**. Deze projectgids kan worden gekoppeld aan een projectgids met de volgende statussen, vervolgactiviteiten en documenten:

| Statussen | Vervolgactiviteiten | Documenten |
|---|---|---|
| Gepland | Planningsvergadering (Vergadering (intern)) | Vergaderprogramma (Opmerking) |
| Wordt uitgevoerd | Lijst met projectleden maken (taak); Conferentie (Vergadering (Extern)) | Uitnodiging voor vergadering (Brief) |
| Bezig met sluiten | Evaluatievergadering (Vergadering (intern)) | Evaluatierapport (Opmerking) |

Deze procedure toont u hoe u een geheel nieuwe projectgids kunt maken.

1. [Statussen](#create-stage) voor opname in de projectgids definiëren.
2. Definieer het [projecttype](#create-type) (met gekoppelde statussen) waaraan de projectgids wordt gekoppeld.
3. De [projectgids](#create-guide) ontwerpen.

![Ga naar de sectie Workflow en maak uw eigen projectroutines in SuperOffice CRM -screenshot][img2]

## <a id="create-stage" /> Statussen maken voor de projectgids

Een projectgids moet worden gekoppeld aan een projecttype dat weer uit verschillende statussen bestaat. [Zo maakt u een status][2].

Een projectgids voor een project van het type Conferentie kan bijvoorbeeld de statussen Gepland, Lopend en Bezig met afsluiten bevatten.

Ga naar de volgende procedures om de statussen aan een projecttype te koppelen.

## <a id="create-type" /> Een projecttype maken voor de projectgids

Een projectgids moet aan een projecttype worden gekoppeld. [Zo maakt u een projecttype][3].

Voorbeelden van projecttypen: 'Vergadering', 'Campagne' en 'Intern'.

1. Schakel de optie **Dit projecttype is gekoppeld aan een gids** in.
1. Selecteer ten minste twee statussen.
1. Ga naar de volgende procedure om de projectgids te maken.

## <a id="create-guide" />Een projectgids maken

Nadat u statussen hebt gemaakt en een projecttype voor de projectgids hebt opgegeven, kunt u de projectgids zelf ontwerpen. U doet door vervolgactiviteiten en/of documenten toe te voegen voor elke status in de projectgids.

1. Klik op de knop **Workflow** in de navigator (![pictogram][img1]).

2. Selecteer het tabblad **Projectgids**.

3. Selecteer in de lijst **Projecttype** het projecttype waarvoor u een projectgids wilt maken. De statussen die voor dit projecttype zijn geselecteerd, worden in de bovenstaande lijst getoond.

    > [!NOTE]
    > Wanneer niet is gedefinieerd dat het projecttype een projectgids heeft, moet u op **Klik hier om de gids in te schakelen** onder aan het scherm klikken.
    >
    > Wanneer geen statussen zijn gedefinieerd voor het projecttype, klikt u op **Klik hier om statussen toe te voegen** onder aan het scherm. U kunt het projecttype ook bewerken door bovenaan op de knop **Bewerken** te klikken.

4. Selecteer de gewenste status in de lijst. De gegevens van de status worden onder aan het scherm weergegeven.

5. [Voeg een of meer vervolgactiviteiten toe voor de geselecteerde status](#add-fo-status).

    > [!NOTE]
    > U hoeft niet voor elke status een document toe te voegen, maar u moet ten minste één vervolgactiviteit toevoegen voor elke status.

6. [Voeg een of meer documenten toe voor de geselecteerde status](#add-doc-status).

7. Herhaal stap 4-6 voor elke status waarvoor u vervolgactiviteiten en documenten wilt toevoegen.

De wijzigingen worden automatisch opgeslagen. De projectgids wordt nu weergegeven in SuperOffice CRM wanneer een project wordt aangemaakt met het in stap B geselecteerde projecttype.

## <a id="add-fo-status" />Een vervolgactiviteit toevoegen voor een status

1. Selecteer het gewenste projecttype en de gewenste status zoals hierboven is beschreven.

2. Klik op **Toevoegen** onder **Voorgestelde vervolgactiviteiten in status**.

3. Voer in het dialoogvenster **Voorgestelde vervolgactiviteit** de naam van de vervolgactiviteit in het veld **Naam**. Dit moet een herkenbare naam zijn voor de vervolgactiviteit.

4. Typ het doel van de vervolgactiviteit in het veld **Het doel van deze vervolgactiviteit**. Deze tekst wordt weergegeven wanneer u de muisaanwijzer op de vervolgactiviteit plaatst op het sectietabblad **Projectgids** in SuperOffice CRM.

    > [!NOTE]
    > sommige van de onderstaande opties zijn, om logische redenen, niet relevant voor de eerste vervolgactiviteit in een projectgids.

5. Schakel de optie **Vervolgactiviteit toewijzen aan projectlid** om deze vervolgactiviteit toe te wijzen aan een van de projectdeelnemers. Wanneer de projecteigenaar deze vervolgactiviteit maakt in SuperOffice CRM, kan een van zijn/haar medewerkers worden geselecteerd als eigenaar van de vervolgactiviteit.

6. Schakel de optie **Mijlpaalvervolgactiviteit** in als u deze vervolgactiviteit als een mijlpaal wilt definiëren.

7. Selecteer een type voor de vervolgactiviteit in de lijst **Type vervolgactiviteit**.

8. Geef in het veld **Startdatum** aan wanneer de vervolgactiviteit moet beginnen (het aantal dagen vanaf vandaag).

9. Geef in het veld **Duur** op hoe lang de vervolgactiviteit moet duren. De indeling is *0u00m*.

10. Voer in het veld **Standaardtekst in vervolgactiviteit** een beschrijving voor de vervolgactiviteit in.

    > [!TIP]
    > de gebruiker kan de bovenstaande gegevens indien gewenst wijzigen.

11. Klik op **Opslaan**.

12. Herhaal deze procedure om meer vervolgactiviteiten toe te voegen in deze status of in andere statussen.

### Voorbeeld van een vervolgactiviteit

**Projecttype**: Vergadering
**Status**: Gepland
**Naam** van vervolgactiviteit: Planningsvergadering
**Doel van deze vervolgactiviteit**: Een bijeenkomst organiseren om de vergadering te plannen en een vergaderprogramma op te stellen.
**Type vervolgactiviteit**: Vergadering (intern)
**Duur**: 1 uur
**Standaardtekst**:

Planningsvergadering:

- Waar moet de vergadering over gaan?
- Deelnemers?
- Sprekers?
- Waar?

## <a id="add-doc-status" />Een document toevoegen voor een status

1. Selecteer het gewenste projecttype en de gewenste status zoals hierboven is beschreven.
2. Klik op **Toevoegen** onder **Voorgestelde documenten in status**.
3. Voer in het dialoogvenster **Voorgestelde document** de naam van het document in het veld **Naam** in. Dit moet een beschrijvende naam zijn voor het document.
4. Typ het doel van het document in het veld **Het doel van dit document**. Deze tekst wordt weergegeven wanneer u de muisaanwijzer op de het document plaatst op het sectietabblad **Projectgids** in SuperOffice CRM.
5. Selecteer de gewenste sjabloon in het veld **Sjabloon** (zie ook [Document - Sjabloon][4]).
6. Voer het in het document te gebruiken onderwerp in het veld **Standaardonderwerp** in.
7. Voer eventueel een referentie in het veld **Onze ref.** in. Bijvoorbeeld een [sjabloonvariabele][1] voor een projectnummer, projecttitel of een ander veld met betrekking tot het project.
8. Klik op **Opslaan**.
9. Herhaal deze procedure om meer documenten toe te voegen in deze status of in andere statussen.

### Voorbeeld van een document

**Projecttype**: Vergadering
**Status**: Gepland
**Naam** van document: Vergaderprogramma
**Doel van deze projectstatus**: Een programma opstellen voor de vergadering.
**Sjabloon**: Opmerking
**Standaardonderwerp**: Vergaderprogramma

## Aanverwant

* [Een projectgids bewerken][5]
* [Projectgids deactiveren][6]

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/from-project-card.html
[2]: ../../../admin/lists/learn/project-status.md
[3]: ../../../admin/lists/learn/project-type.md
[4]: ../../../admin/lists/learn/document-template.md
[5]: edit.md
[6]: deactivate.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-workflow-active.png
[img2]: ../../../../media/loc/en/project/create-project-guide.png
