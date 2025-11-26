---
uid: help-nl-crmscript
title: CRMScript
description: CRMScript is een functie waarmee u taken in of het gedrag van SuperOffice kunt automatiseren of wijzigen.
keywords: CRMScript
author: SuperOffice RnD
date: 02.22.2023
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from:
  - /nl/automation/crmscript/learn/macro-script
  - /nl/automation/crmscript/learn/screen/
  - /nl/automation/crmscript/learn/index
---

# CRMScript

CRMScript is een functie waarmee u taken in of het gedrag van SuperOffice kunt automatiseren of wijzigen. Met de automatisering van taken en processen kunt u tijd besparen en zullen u en uw collega's productiever zijn.

De verschillende hulpmiddelen, macro's en scripts, triggers en geplande taken, hebben verschillende mogelijkheden en worden voor verschillende doeleinden gebruikt. Het volgende is een inleiding tot het flexibele en krachtige ingesloten scriptinginstrument – CRMScript.

## Toegang tot CRMScript

Om toegang te krijgen tot de functies in CRMScript, opent u SuperOffice-instellingen en onderhoud en klikt u op <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** in de navigator.

Triggers zijn scripts die worden uitgevoerd voor specifieke gebeurtenissen in het systeem, zoals wanneer een nieuwe verkoop wordt gemaakt of een verzoek wordt gesloten. Triggers kunnen in stilte reageren op wat er gebeurt, of de bewerking blokkeren en de gebruiker voorzien van uitleg hierover.

## Macro's en scripts

Op het tabblad **Macro's en scripts** op **CRMScript** ziet u een lijst met de scripts en macro's in het systeem, gegroepeerd in mappen. Klik op een script of macro in de lijst voor weergave, bewerking of uitvoering.

### Over macro's

Macro's zijn de gebruiksvriendelijke versie van scripts: U hebt geen uitgebreide kennis over scriptverwerking of CRMScript nodig om macro's te kunnen maken.

Met macro's kunt u acties binnen SuperOffice aanpassen en automatiseren. De functie beschikt over een gebruiksvriendelijke wizard die u helpt bij de instelling van uw macro.

Macro's hebben meerdere functies in SuperOffice. Ze kunnen worden gekoppeld aan specifieke [triggers][2] in het systeem (zoals escalaties of een nieuw bericht op verzoek in SuperOffice) of worden toegewezen aan knoppen in gedefinieerde schermen, zodat gebruikers op een knop kunnen klikken om een serie acties uit te voeren die vaak wordt herhaald. Dit maakt verzoekbeheer sneller en vermijdt dat gebruikers onnodig klikken.

U kunt macro's bijvoorbeeld gebruiken:

* Als een taak/functie in een menu-item (zoals in **Taak** in het scherm Verzoek)
* Wanneer het verzoek wordt geëscaleerd via de waarschuwingsniveaus voor prioriteit
* Als een geplande taak
* Wanneer deze worden geactiveerd door een e-mailfilter
* Wanneer een ontvanger klikt op een gevolgde koppeling in een mailing

### Wat is het verschil tussen een script en een macro?

Een macro is een set van vooraf gedefinieerde acties uitgevoerd in een specifieke volgorde, het instellen vereist geen programmeerkennis.

Een script is een klein programma geschreven om specifieke taken uit te voeren; het instellen vereist programmeerkennis.

### Tabblad Macro's en scripts

Ga als volgt naar het tabblad **Macro's en scripts**:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klik op **CRMScript** en selecteer het tabblad **Macro's en scripts** .

Dit scherm biedt de volgende opties:

| Optie | Beschrijving |
|---|---|
| Nieuw script | Wordt gebruikt om [een nieuw script te maken][8]. |
| Nieuwe macro | Wordt gebruikt om [een nieuwe macro te maken][9]. |
| Nieuwe map | Wordt gebruikt om [een nieuwe map te maken][10]. |
| Zoeken | Wordt gebruikt om te zoeken naar macro's en scripts in de geselecteerde map en submappen. |

#### Scriptscherm

Wanneer u op het tabblad **Macro's en scripts** klikt op een script of macro, wordt het scherm **Script** geopend. In aanvulling op de informatie in het bovenste deel van het scherm kunt u meer details over het script vinden op de tabbladen **Beschrijving** en **Script**.

**Opties:**

| Pictogram | Optie | Beschrijving |
|---|---|---|
| | Macro's en scripts | Wordt gebruikt om terug te keren naar de lijst met scripts en macro's. |
| <i class="ph ph-pencil-simple" aria-label="Edit"></i> | Script bewerken | Wordt gebruikt om het script of de macro te bewerken. |
| <i class="ph ph-play" aria-label="Play"></i> | Script uitvoeren | Wordt gebruikt om het script of de macro uit te voeren in de standaardmodus. |
| <i class="ph ph-bug" aria-label="Bug"></i> | Fouten opsporen in script | Wordt gebruikt om het scherm **Foutopsporing** te openen en het geselecteerde script of de geselecteerde macro uit te voeren in de foutopsporingsmodus . Het script stopt bij de eerste regel. U kunt een [foutopsporingssessie][4] openen vanaf het tabblad **Foutopsporingssessies**. |
| | Script traceren | Wordt gebruikt om [het script of de macro te traceren][5]. |

## Tabbladen

* [Macro's en scripts][8] - Maak macro's en scripts om taken in SuperOffice te automatiseren en te plannen.
* [Triggers][2] - Geef aan of een bepaalde gebeurtenis in het systeem één of meer vooraf gedefinieerde acties activeert.
* [Geplande taken][3] - Geef aan of een script of macro op bepaalde momenten moet worden uitgevoerd.
* [Foutopsporingssessies][4] - Zoek de fouten in uw scripts en macro's en verhelp deze.
* [Traceren][5] - Leg alle details van de uitvoering van een script of macro vast en sla deze op in een logboek.

## Gerelateerde inhoud

* [Een script maken][8]
* [Een macro maken][9]
* [Map maken][10]
* [De CRMScript-taal leren][6]
* [CRMScript API-referentie][7]

<!-- Referenced links -->
[2]: trigger.md
[3]: schedule-task.md
[4]: ../../../../en/automation/crmscript/debugging/built-in-debugger.md
[5]: ../../../../en/automation/crmscript/debugging/using-trace.md
[6]: ../../../../en/automation/crmscript/overview/index.md
[7]: ../../../../en/automation/crmscript/reference/index.md
[8]: create-script.md
[9]: create-macro.md
[10]: create-script.md#folder
