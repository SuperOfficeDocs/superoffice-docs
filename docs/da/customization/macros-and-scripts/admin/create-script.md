---
uid: help-da-automation-script-create
title: Opret eller rediger et script
description: Opret et script
keywords: script, makro
author: digitaldiina
date: 11.26.2025
version: 11.6
content_type: howto
category: automation
topic: CRMScript
audience: settings
audience_tooltip: Settings and maintenance
redirect_from:
  - /da/automation/crmscript/learn/create-folder
  - /da/automation/crmscript/learn/create-script
language: da
index: true
---

# Opret eller rediger et script

## Steps

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Vælg **CRMScript**, og gør et af følgende:
    * Sådan opretter du en ny makro: Klik på **Ny makro**.
    * Sådan redigeres en eksisterende makro: Klik på makronavnet.

1. Under fanen **Information** redigerer eller indtaster du data om scriptet:

    * **Mappe**: Vælg den mappe, hvor du vil gemme scriptet.
    * **Navn**
    * **Beskrivelse**
    * **Include-navn**: Et entydigt navn til scriptet, der bruges til at inkludere dette script i et andet script.
    * **Nøgle**: Nøglen anvendes sammen med funktionen "action=parse" på kundesiderne, så du kan køre scripts og oprette scriptbaseret funktionalitet i SuperOffice Customer Centre. Nøglen forhindrer vilkårlige scripts i at kunne køres fra kundesiderne.
    * **Vis resultat af scriptkørsel som HTML**

1. På fanen **Script** kan du indtaste selve scriptet.

1. (valgfrit) Klik på **Stage** for gemme scriptet på en midlertidig placering. Det giver dig mulighed for selv at teste ændringerne.

1. Klik på **Kør script** for at udføre scriptet. Resultatet vises i fanen **Resultat** .

1. Klik på **OK**.

## <a id="folder"></a>Makro/scriptmappe-egenskaber

Script- og makromapper bruges til at organisere dine brugerdefinerede scripts og makroer.

### Oprettelse af mappe

1. Klik på <i class="ph ph-folder" aria-hidden="true"></i> **Ny mappe** øverst på skærmen.
2. I feltet **Mappe** vælger du en overordnet mappe på listen.
3. Angiv et beskrivende navn på mappen i feltet **Navn**.
4. Klik på **OK**. Den nye mappe oprettes.

### Redigering af mappe

Du kan både ændre navnet på en mappe og de oplysninger, du angav, da du oprettede den.

1. Gå til den ønskede mappe.
2. Klik på selve mappenavnet.
3. Rediger felterne.
4. Klik på **OK**. Ændringerne gemmes.

### Sletning af mappe

Når du sletter en mappe, slettes alt dens indhold (såsom valg, FAQ-poster, svarskabeloner, tabeller, script og makroer.) også fra SuperOffice Service.

1. Gå til den ønskede mappe.
2. Klik på selve mappenavnet.
3. Klik på **Slet**.
4. Klik på **OK** for at bekræfte. Mappen og indholdet i den fjernes fra SuperOffice.

## Relateret indhold

* [Om CRMScript][1]
* [Fejlfind scripts][2]
* [Spor scripts][3]

<!-- Referenced links -->
[1]: ../../../../en/automation/crmscript/index.yml
[2]: ../../../../en/automation/crmscript/debugging/built-in-debugger.md
[3]: ../../../../en/automation/crmscript/debugging/using-trace.md

<!-- Referenced images -->
