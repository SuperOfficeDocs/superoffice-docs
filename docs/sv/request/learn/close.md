---
uid: help-sv-request-close
title: Stänga ett ärende
description: Så här stänger du ett eller flera ärenden i SuperOffice.
keywords: stäng ärende, sätt status stängt, stängt, massuppdatering, ärende
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: sv
redirect_from: /sv/request/learn/howto/close
---

# Stänga ärenden

Att stänga ett ärende innebär att ändra dess [status][5] till **Stängt**.

## Stäng ett enskilt ärende

Efter att du har [svarat på ärendet][3] väljer du **Stängt** i fältet **Status** i sidopanelen.

## Stäng flera ärenden med massuppdatering

Du kan snabbt stänga flera ärenden genom att ställa in fältet **Status** på **Stängt** i dialogrutan **Massuppdatering**.

1. Öppna listan över ärenden du vill uppdatera. Du kan använda:
    * Ett **sparat urval** i urvalsskärmen.
    * Sökträffar från skärmen **Sök ärenden**.
    * **Detaljkortet Ärenden** (på ett företag eller en kontakt).

1. Öppna dialogrutan **Massuppdatering**:
    * **Urval:** Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Uppgiftsknapp"></i> och välj **Massuppdatering**.
    * **Sök ärenden:** Markera ärendena, klicka på <i class="ph ph-list" aria-hidden="true"></i> **Uppgift** längst ner till vänster och välj **Massuppdatering**.
    * **Detaljkort:** Markera ärendena, högerklicka och välj **Massuppdatering**.

1. I dialogrutan **Massuppdatering**:
    * I kolumnen **Fält**, skriv eller välj **Status**.
    * I kolumnen **Åtgärd**, välj **Välj en**.
    * I kolumnen **Nytt värde**, välj **Stängt**.
    * Kontrollera att endast rutan bredvid **Status** är markerad.

    ![Massuppdateringsdialog -screenshot][img1]

    Om du vill kan du uppdatera andra fält, men var försiktig.

1. Klicka på **Uppdatera**.

1. Granska sammanfattningen i dialogrutan **Bekräfta**. Här visas vilket fält som ska uppdateras och antalet påverkade ärenden.

    ![Bekräftelsedialog -screenshot][img2]

1. Klicka på **Ja** för att tillämpa ändringarna. De valda ärendena stängs nu.

    > [!CAUTION]
    > När en uppdatering har tillämpats kan den inte ångras. Du kan dock stoppa uppdateringen medan den pågår. Alla poster som ännu inte har uppdaterats förblir oförändrade.

## Relaterat innehåll

* [Uppdatera flera poster (massuppdatering)][1]
* [Skapa ett urval][6]
* [Detaljkortet Ärenden][2]
* [Sök ärenden][4]

<!-- Referenced links -->
[1]: ../../learn/basics/bulk-update.md
[2]: ../../learn/section-tabs/requests-tab.md
[3]: reply.md
[4]: find.md
[5]: ../admin/status/index.md
[6]: ../../search-options/selection/learn/create.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/bulk-update-requests.png
[img2]: ../../../media/loc/en/request/bulk-update-confirm.png
