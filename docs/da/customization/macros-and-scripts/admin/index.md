---
uid: help-da-crmscript
title: CRMScript
description: CRMScript er en funktion, der giver dig mulighed for at automatisere opgaver i eller ændre funktionsmåden for SuperOffice.
keywords: CRMScript
author: digitaldiina
date: 11.26.2025
version: 11.6
content_type: concept
category: automation
topic: CRMScript
audience: settings
audience_tooltip: Settings and maintenance
redirect_from:
  - /da/automation/crmscript/learn/macro-script
  - /da/automation/crmscript/learn/screen/index
  - /da/automation/crmscript/learn/index
language: da
index: true
---

# CRMScript

CRMScript er en funktion, der giver dig mulighed for at automatisere opgaver i eller ændre funktionsmåden for SuperOffice. Automatisering af opgaver og processer kan hjælpe dig med at spare tid og gøre dig og din kollega mere produktive.

De forskellige værktøjer, makroer og scripts, udløsere og planlagte opgaver, har forskellige muligheder og bruges til forskellige formål. Følgende er en introduktion til det fleksible og kraftfulde integrerede scriptværktøj – CRMScript.

## Få adgang til CRMScript

For at få adgang til funktionerne i CRMScript skal du åbne SuperOffice Indstillinger og vedligeholdelse og klikke på <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** i navigatoren.

Udløsere er scripts, der udføres for bestemte hændelser i systemet, f.eks. når der oprettes et nyt salg, eller når en sag lukkes. Udløsere kan reagere lydløst på, hvad der sker, eller blokere handlingen og vise en forklaring tilbage til brugeren.

## Makroer og script

På fanen **Macroer og scripts** på **CRMScript** finder du en liste over scripts og makroer i systemet, grupperet i mapper. Klik på et script eller en makro på listen for at vise, redigere eller køre den.

### Om makroer

Makroer er den brugervenlige version af scripts: Du behøver ikke omfattende viden om scripting eller CRMScript for at oprette makroer.

Med makroer kan du tilpasse og automatisere handlinger inde i SuperOffice. En brugervenlig guide hjælper dig med opsætning af din makro.

Makroer har et antal funktioner i SuperOffice. De kan knyttes til bestemte [udløsere][2] i systemet (såsom eskaleringer eller ny meddelelse på sag i SuperOffice) eller tildeles til knapper i definerede skærmbilleder, så brugerne kan klikke på en knap for at udføre en række handlinger, som ofte gentages. Det gør sagsbehandlingen hurtigere, og brugerne undgår unødvendige klik med musen.

Du kan for eksempel bruge makroer:

* Som en opgave/funktion i et menupunkt (for eksempel i **Opgave** på skærmen Sag)
* Når en sag eskaleres via advarselsniveauer for prioritet
* Som en planlagt opgave
* Når de aktiveres af et e-mailfilter
* Når en modtager klikker på et sporet link i en udsendelse

### Hvad er forskellen på et script og en makro?

En makro er et sæt af foruddefinerede handlinger, som udføres i en bestemt rækkefølge, og som ikke kræver programmeringsviden i forbindelse med opsætningen.

Et script er et lille program, der er skrevet til at udføre bestemte opgaver, og som kræver programmeringsviden i forbindelse med opsætningen.

### Fanen makroer og scripts

Sådan går du til fanen **Makroer og script**:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klik på **CRMScript**, og vælg fanen **Makroer og scripts**.

Fanen **Makroer og scripts** indeholder følgende knapper: **Nyt script**, **Ny makro**, **Ny mappe** og **Søg**.

#### Skærmbilledet Script

Når du klikker på et script eller en makro i fanen **Makro**, åbnes skærmbilledet **Script**. Ud over informationen i den øverste del af skærmen kan du finde flere scriptoplysninger i fanerne **Beskrivelse** og **Script**.

**Muligheder:**

| Knap | Beskrivelse |
|---|---|
| Makroer og script | bruges til at vende tilbage til listen over script og makroer. |
| Rediger script | Bruges til at redigere scriptet eller makroen. |
| Kør script | Klik her for at køre scriptet eller makroen i standardtilstand. |
| Fejlfind script | Bruges til at åbne skærmbilledet **Fejlfinding** og køre det valgte script eller makro i fejlfindingstilstand. Scriptet stopper ved første linje. Du kan åbne en [fejlfindingssession][4] fra fanen **Fejlfindingssessioner**. |
| Spor script | Bruges til at starte [sporing af scriptet eller makroen][5]. |

## Faner

* [Makroer og script][8] - Opret makroer og scripts til at automatisere og planlægge opgaver i SuperOffice.
* [Triggers][2] - Definer, at en bestemt hændelse i systemet udløser én eller flere foruddefinerede handlinger.
* [Planlagte opgaver][3] - Angiv, at et script eller en makro skal udføres på bestemte tidspunkter.
* [Fejlfindingssessioner][4] - Find og ret fejl inde i dine scripts og makroer.
* [Sporing][5] - Spor alle detaljer i udførelsen af et script eller en makro, og gem i en logfil.

## Relateret indhold

* [Opret et script][8]
* [Oprettelse af makro][9]
* [Oprettelse af mappe][10]
* [Lær CRMScript-sproget][6]
* [CRMScript API-reference][7]

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
