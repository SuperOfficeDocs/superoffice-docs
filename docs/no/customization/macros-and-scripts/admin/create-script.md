---
uid: help-no-automation-script-create
title: Opprette eller redigere et skript
description: Opprette et skript
keywords: skript, makro
author: digitaldiina
date: 11.26.2025
version: 11.6
content_type: howto
category: automation
topic: CRMScript
audience: settings
audience_tooltip: Settings and maintenance
redirect_from:
  - /no/automation/crmscript/learn/create-folder
  - /no/automation/crmscript/learn/create-script
language: no
index: true
---

# Opprette eller redigere et skript

## Steps

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Velg **CRMScript**, og gjør deretter ett av følgende:
    * Slik oppretter du en ny makro: Klikk på **Ny makro**.
    * Slik redigerer du en eksisterende makro: Klikk på makronavnet.

1. I fanen **Informasjon** redigerer eller angir du informasjon om skriptet:

    * **Mappe**: Velg mappen du vil lagre skriptet i.
    * **Navn**
    * **Beskrivelse**
    * **Inkluder navn**: Et unikt navn for skriptet, som brukes til å inkludere dette skriptet i et annet skript.
    * **Nøkkel**: Nøkkelen brukes med funksjonen "action=parse" på kundesidene, slik at du kan kjøre og sette opp skriptbasert funksjonalitet i SuperOffice Customer Centre. Nøkkelen hindrer at tilfeldige skript kjøres fra kundesidene.
    * **Vis resultat av skriptkjøring som HTML**

1. I fanen **Skript** kan du angi selve skriptet.

1. (valgfritt) Klikk på **Trinn** for å "stage" skriptet. Du kan da teste endringene selv.

1. (valgfritt) Klikk på **Kjør skript** for å kjøre skriptet. Resultatet vises i fanen **Resultat**.

1. Klikk på **OK**.

## <a id="folder"></a>Egenskaper for makro-/skriptmappe

Skript- og makromapper brukes til å organisere egendefinerte skript og makroer.

### Opprett mappe

1. Klikk på <i class="ph ph-folder" aria-hidden="true"></i> **Ny mappe** øverst i bildet.
2. I feltet **Mappe** velger du en overordnet mappe i listen.
3. Angi et beskrivende navn på mappen i feltet **Navn**.
4. Klikk på **OK**. Den nye mappen opprettes.

### Rediger mappe

Du kan endre både navnet på en mappe og informasjonen du oppga da du opprettet den.

1. Gå til ønsket mappe.
2. Klikk på mappenavnet.
3. Endre feltene.
4. Klikk på **OK**. Endringene lagres.

### Slett mappe

Når du sletter en mappe, slettes også alt innholdet (for eksempel utvalg, FAQ-oppføringer, svarmaler, tabeller, skript og makroer) i mappen fra SuperOffice.

1. Gå til ønsket mappe.
2. Klikk på mappenavnet.
3. Klikk på **Slett**.
4. Klikk på **OK** for å bekrefte. Mappen og innholdet i den fjernes fra SuperOffice.

## Relatert innhold

* [Om CRMScript][1]
* [Feilsøk skript][2]
* [Spor skript][3]

<!-- Referenced links -->
[1]: ../../../../en/automation/crmscript/index.yml
[2]: ../../../../en/automation/crmscript/debugging/built-in-debugger.md
[3]: ../../../../en/automation/crmscript/debugging/using-trace.md

<!-- Referenced images -->
