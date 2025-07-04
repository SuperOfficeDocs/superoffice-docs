---
uid: help-nl-project-guide-create
title: Een nieuwe projectgids maken
description: Leer hoe u een projectgids in SuperOffice CRM kunt maken. Definieer statussen, koppel projecttypen en voeg vervolgactiviteiten en documenten toe om uw projecten efficiënter te beheren.
keywords: projectgids maken, nieuwe projectgids, projectgids, gids, workflow, project
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Instellingen en onderhoud
language: nl
redirect_from:
  - /nl/project/learn/project-guide/create
  - /nl/project/learn/screen/project-guide-admin
---

# Een nieuwe projectgids maken

[!include[Moet beheerder zijn](../../learn/includes/req-admin.md)]

In Instellingen en onderhoud bepaalt u welke projecttypen aan een projectgids moeten worden gekoppeld en welke statussen en activiteiten deze gidsen bevatten. Hierdoor kan de inhoud van een projectgids variëren, afhankelijk van het projecttype.

Bijvoorbeeld, een projecttype **Conferentie** kan worden gekoppeld aan een projectgids met de volgende statussen, vervolgactiviteiten en documenten:

| Statussen | Vervolgactiviteiten | Documenten |
|---|---|---|
| Gepland | Planningsvergadering (Vergadering (intern)) | Conferentieprogramma (Opmerking) |
| Wordt uitgevoerd | Lijst met projectleden maken (Taak); Conferentie organiseren (Vergadering (extern)) | Uitnodiging voor conferentie (Brief) |
| Bezig met sluiten | Evaluatievergadering (Vergadering (intern)) | Evaluatierapport (Opmerking) |

Deze handleiding laat zien hoe u een projectgids helemaal vanaf het begin opbouwt.

1. Definieer de [statussen](#create-stage) die in de projectgids worden opgenomen.
2. Definieer het [projecttype](#create-type) (met bijbehorende statussen) waaraan de projectgids wordt gekoppeld.
3. Ontwerp de [projectgids](#create-guide) door vervolgactiviteiten en documenten toe te voegen.

![Ga naar de sectie Workflow en maak uw eigen projectroutines in SuperOffice CRM -screenshot][img2]

## <a id="create-stage"></a> Statussen maken voor de projectgids

Een projectgids moet worden gekoppeld aan een projecttype dat weer uit verschillende statussen bestaat. [Zo maakt u een status][2].

Voorbeeld: een projectgids voor een project van het type **Conferentie** kan de statussen Gepland, Wordt uitgevoerd, en Bezig met sluiten bevatten.

Ga naar de volgende stap om deze statussen aan een projecttype te koppelen.

## <a id="create-type"></a> Een projecttype maken voor de projectgids

Een projectgids moet aan een projecttype worden gekoppeld. [Zo maakt u een projecttype][3].

Voorbeelden van projecttypen: "Conferentie", "Campagne", "Intern".

1. Schakel de optie **Dit projecttype is gekoppeld aan een gids** in.
2. Selecteer ten minste twee statussen voor het projecttype.
3. Ga verder met de volgende stap om de projectgids te maken.

## <a id="create-guide"></a>Een projectgids maken

Nadat u statussen hebt gemaakt en een projecttype voor de projectgids hebt opgegeven, kunt u de projectgids zelf ontwerpen. U doet door vervolgactiviteiten en/of documenten toe te voegen voor elke status in de projectgids.

1. Selecteer <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow** in de Navigator.

2. Ga naar het tabblad **Projectgids**.

3. Selecteer in de lijst **Projecttype** het projecttype waarvoor u een projectgids wilt maken. De statussen die aan dit projecttype zijn gekoppeld, worden bovenaan weergegeven.

    > [!NOTE]
    > Wanneer niet is gedefinieerd dat het projecttype een projectgids heeft, moet u op **Klik hier om de gids in te schakelen** onder aan het scherm klikken.
    >
    > Wanneer geen statussen zijn gedefinieerd voor het projecttype, klikt u op **Klik hier om statussen toe te voegen** onder aan het scherm. U kunt het projecttype ook bewerken door bovenaan op de knop **Bewerken** te klikken.

4. Selecteer een status in de lijst. De details van de status worden onderaan weergegeven.

5. [Voeg één of meer vervolgactiviteiten toe aan de geselecteerde status](#add-fo-status).

    > [!NOTE]
    > U hoeft niet voor elke status een document toe te voegen, maar u moet ten minste één vervolgactiviteit per status toevoegen.

6. [Voeg één of meer documenten toe aan de geselecteerde status](#add-doc-status).

7. Herhaal stap 4-6 voor elke status waarvoor u vervolgactiviteiten en documenten wilt toevoegen.

De wijzigingen worden automatisch opgeslagen. De projectgids wordt nu weergegeven in SuperOffice CRM wanneer een project wordt aangemaakt met het projecttype dat in stap 3 is geselecteerd.

## <a id="add-fo-status"></a>Een vervolgactiviteit toevoegen voor een status

1. Selecteer het gewenste projecttype en de gewenste status zoals hierboven is beschreven.

2. Klik op **Toevoegen** onder **Voorgestelde vervolgactiviteiten in status**.

3. Voer in het dialoogvenster **Voorgestelde vervolgactiviteit** de naam van de vervolgactiviteit in het veld **Naam**. Dit moet een herkenbare naam zijn voor de vervolgactiviteit.

4. Typ het doel van de vervolgactiviteit in het veld **Het doel van deze vervolgactiviteit**. Deze tekst wordt weergegeven wanneer u de muisaanwijzer op de vervolgactiviteit plaatst op het sectietabblad **Projectgids** in SuperOffice CRM.

    > [!NOTE]
    > Sommige van de onderstaande opties zijn, om logische redenen, niet relevant voor de eerste vervolgactiviteit in een projectgids.

5. Schakel de optie **Vervolgactiviteit toewijzen aan projectlid** in om deze vervolgactiviteit toe te wijzen aan een van de projectleden. Wanneer de projecteigenaar deze vervolgactiviteit aanmaakt in SuperOffice CRM, kan een van zijn/haar medewerkers worden geselecteerd als eigenaar van de vervolgactiviteit.

6. Schakel de optie **Mijlpaalvervolgactiviteit** in als u deze vervolgactiviteit als een mijlpaal wilt definiëren.

7. Selecteer een type voor de vervolgactiviteit in de lijst **Type vervolgactiviteit**.

8. Geef in het veld **Startdatum** aan wanneer de vervolgactiviteit moet beginnen (het aantal dagen vanaf vandaag).

9. Geef in het veld **Duur** op hoe lang de vervolgactiviteit moet duren. De indeling is *0u00m*.

10. Voer in het veld **Standaardtekst in vervolgactiviteit** een beschrijving voor de vervolgactiviteit in.

    > [!TIP]
    > De gebruiker kan de bovenstaande gegevens indien gewenst wijzigen.

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

\- Waar moet de vergadering over gaan?
\- Deelnemers?
\- Sprekers?
\- Waar?

## <a id="add-doc-status"></a>Een document toevoegen voor een status

1. Selecteer het gewenste projecttype en de gewenste status zoals hierboven is beschreven.
2. Klik op **Toevoegen** onder **Voorgestelde documenten in status**.
3. Voer in het dialoogvenster **Voorgestelde document** de naam van het document in het veld **Naam** in. Dit moet een beschrijvende naam zijn voor het document.
4. Typ het doel van het document in het veld **Het doel van dit document**. Deze tekst wordt weergegeven wanneer u de muisaanwijzer op het document plaatst op het sectietabblad **Projectgids** in SuperOffice CRM.
5. Selecteer de gewenste [sjabloon][4] in het veld **Sjabloon**.
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

## Gerelateerde inhoud

* [Een projectgids bewerken of deactiveren][5]

<!-- Referenced links -->
[1]: ../../document/templates/variables/from-project-card.md
[4]: ../../document/templates/learn/index.md
[2]: project-status.md
[3]: project-type.md
[5]: edit-project-guide.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/project/create-project-guide.png
