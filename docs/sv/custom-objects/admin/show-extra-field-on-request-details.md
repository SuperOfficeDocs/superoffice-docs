---
uid: help-sv-extra-field-display
title: Visa extra fält på fliken Detaljer
description: Visa extra fält på fliken Detaljer
keywords: extra fält, custom field, förfrågan, layout, screen designer
author: Bergfrid Dias
date: 01.18.2024
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
index: true
---

# Visa extra fält på fliken Detaljer

Scenario: Du har lagt till ett extra fält för företag (`contact` tabellen) som indikerar om ett företag har ett supportavtal och du vill visa den informationen när du tittar på en förfrågan.

<!-- markdownlint-disable-file MD051 -->
## Steg

### [I den nya skärmen för förfrågningar med Screen Designer](#tab/screen-designer)

1. Gå till **Inställningar och underhåll** > **Screen designer** och välj fliken **Förfrågningar**.
1. Klicka på **Redigera layout** längst ned.
1. Hitta inställningen för **Fält**.
1. Välj ditt fält.
1. Välj eventuellt lämpliga stilar.
1. Klicka på **Spara** för att spara inställningarna.

> [!TIP]
> Du kan också gruppera fält, lägga till rubriker för grupper och ändra storleken på kolumner. [Läs mer om Screen Designer][1].

### [I klassisk Service](#tab/service)

I Service måste du skapa en gemensam elementprofil.

1. Gå till **Inställningar och underhåll** > **Systemdesign** och välj fliken **Profil**.

1. Välj **Systemskärmar**. Klicka sedan på **Visa ärende**, peka på **ärendeinfo**, och klicka på **Ny gemensam profil**.

1. Ange ett **namn** för den nya profilen.

1. Klicka på **Lägg till kriterium**-knappen och gör följande:

    1. Ange en UI-etikett för det extra fältet.
    1. Välj vilket fält i databasen du vill hämta data från.
    1. Klicka på **OK**. Det nya kriteriet läggs till under de andra.
    1. Eventuellt lägg till fler kriterier.

1. Klicka på **OK**. Den nya profilen är skapad.

1. Klicka på hamburgemenyn igen och välj **Roller**.

1. Välj en roll (vem som ska kunna se fältet på förfrågningsskärmen).

1. I dialogrutan välj fliken **Profil**.

1. I listan **Ny elementprofil** välj profilen du just skapade.

1. Klicka på **OK** för att spara inställningarna.

Alla användare som har denna roll kommer nu att kunna se det extra fältet på fliken **Detaljer** i alla sina förfrågningar.

***

<!-- Referenced links -->
[1]: ../../../en/ui/screen-designer/configurable-screens/working-with-fields.md
