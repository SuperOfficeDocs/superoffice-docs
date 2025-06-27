---
uid: help-sv-request-find
title: Söka efter ett ärende
description: I den här guiden förklarar vi hur du söker efter ärenden i SuperOffice
keywords: söka efter ärende, hitta ärende, senaste ärenden, egna öppna ärenden, otilldelade ärenden, visa bara egna kategorier, sökning, sök, hitta, ärende
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: sv
---

# Söka efter ett ärende

Som kundsupporthandläggare får du många inkommande samtal och e-postmeddelanden om väntande eller gamla kundförfrågningar. Det är därför viktigt att veta hur du snabbt kan hitta ett enskilt ärende eller grupper av ärenden.

Gör något av följande:

* Använd listor, som i själva verket är fördefinierade sökningar.
* Använd sökskärmen för ärenden under **Sök ärende**.
* Använd [fritextsökningen][12] i toppraden.
* Använd [dashboards][18].
* Använd [urval][10] för ärenden.
* Använd [navigatorns sökning][19] på Ärenden.
* Använd [Sök][11] i toppraden, välj en av de typiska sökningarna eller lägg till önskade kriterier.

## <a id="list"></a>Använda listor

Det enklaste sättet att söka efter ärenden är att använda sökfältet i menyn för den första fliken **Sök ärenden** i fönstret Ärenden.

![Söka efter ärenden -screenshot][img3]

* **Senaste ärenden:** Visar de senast registrerade ärendena i systemet. Om inställt i användarinställningar visar denna lista endast ärenden i de kategorier du är medlem i.

* **Egna öppna ärenden:** Visar alla ärenden du ansvarar för som har status **Öppet**. Denna lista innehåller de ärenden som du är ansvarig för, och det är därför den skärm du kommer arbeta med mest.

* **Otilldelade ärenden:** Visar ärenden som ännu inte har tilldelats någon handläggare. För att [ta över ett ärende][6] måste du klicka på **Ta över ärende**, annars finns risk att någon annan besvarar samma ärende samtidigt.

* **Mina favoriter:** Visar de ärenden du har sparat som favoriter.

* **Hämta nästa i kön:** Om [kösystemet är aktiverat][9] kan du klicka här för att få nästa otilldelade ärende i kön för den kategori du tillhör.

* **Ärendeurval:** Visar dina egna urval av ärenden.

### Visa bara egna kategorier

1. Välj <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** > **Inställningar**.
1. Välj gruppen **Ärende**.
1. Ställ in **Visa bara egna kategorier** på **Ja**.
1. Klicka på **Spara**.

## Använda sökkriterier

Du kan anpassa sökkriterier för att hitta specifika ärenden.

### Hur du öppnar sökkriterier

Fliken **Sök ärenden** har två interaktiva element:

* **Fliktext:** Klicka på texten för att öppna skärmen med sökkriterier.

* **Dropdownikon:** Klicka på pilen (<i class="ph ph-caret-down" aria-label="Dropdown icon"></i>) för att öppna en meny med fördefinierade sökningar, som *Senaste ärenden* eller *Egna öppna ärenden*.
Om du inte ser sökkriterieskärmen, klicka på texten och inte på pilen.

### Anpassa kriterier

1. Klicka på **Sök ärenden** i sidhuvudet i fönstret Ärenden.

1. Justera [sökkriterierna][14] genom att lägga till eller ändra filter:

    * Använd rullgardinsmenyer för att ange kriterier som Ägare, Intern status eller Kategori.
    * Lägg till fler kriterier genom att klicka på **Lägg till kriterium**, eller ta bort befintliga med <i class="ph ph-x" aria-label="Remove criterion"></i>-ikonen.
    * Kombinera filter med **OCH** eller **ELLER** för att förfina din sökning.

    ![Sök efter ärenden -screenshot][img2]

1. Klicka på **Sök** i nedre högra hörnet för att genomföra sökningen.

    > [!TIP]
    > Du kan spara ofta använda kriterier som ett [urval][13] för snabb åtkomst senare.

1. För att återställa sökningen till standardvärden, välj **Återställ till standard**. För att rensa alla filter, välj **Ta bort allt**.

### <a id="result"></a>Sökresultat

Sökresultatet visar en lista över ärenden i fliken **Resultat**. Du kan:

* Sortera ärenden genom att klicka på kolumnrubriker.
* Klicka på ett ärende för att visa detaljer i förhandsgranskningen till höger.
* Dubbelklicka på ett ärende för att öppna det.
* Växla förhandsgranskning genom att klicka på **Visa/Dölj förhandsgranskning** längst ner på skärmen.
* Utföra åtgärder i bulk genom att klicka på <i class="ph ph-list" aria-hidden="true"></i> **Uppgift**. Här kan du exempelvis massuppdatera, vidarebefordra eller ta bort flera ärenden samtidigt.

> [!TIP]
> Statusen **Öppen** i kombination med kolumnen **Läst** ger en översikt över om ärendet är **Läst av ägare**, **Ny information** eller **Inte läst av ägare**.

## <a id="preview"></a>Förhandsgranskning

Denna del av skärmen visar innehållet i det valda ärendet i **Sökresultat**. Här har du samma alternativ som när du [behandlar ärenden][6].

Om förhandsgranskningen inte syns, klicka på **Visa förhandsgranskning** längst ner på skärmen.

## Relaterat innhåll

* [Använda taggar i ärenden][1]
* [Sökskärmen][11]
* [Använda navigatorns sökning][19]
* [Skapa urval][13]
* [Hämta nästa i kön][9]

<!-- Referenced links -->
[1]: tags.md
[6]: accept.md
[9]: ../admin/next-in-queue.md
[10]: ../../search-options/selection/learn/index.md
[11]: ../../search-options/learn/find-screen.md
[12]: ../../search-options/learn/freetext-search.md
[13]: ../../search-options/selection/learn/create.md
[14]: ../../search-options/learn/search-criteria.md
[18]: ../../dashboard/learn/index.md
[19]: ../../learn/getting-started/main-screen/navigator.md#navigator

<!-- Referenced images -->
[img2]: ../../../media/loc/en/request/find-request-criteria.png
[img3]: ../../../media/loc/en/request/find-request-dropdown.png
