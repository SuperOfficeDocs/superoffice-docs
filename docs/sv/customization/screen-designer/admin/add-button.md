---
uid: help-sv-screen-designer-button
title: Lägg till en knapp eller länk
description: Hur du lägger till en knapp eller länk i en layout med hjälp av Skärmdesignern i Inställningar och underhåll.
keywords: lägg till knapp, ny knapp, lägg till länk, ny länk, etikett
author: Bergfrid Dias
date: 10.09.2025
version: 10.3.7
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: sv
index: true
redirect_from: /sv/customization/screen-designer/add-button
---

# Lägg till en knapp eller länk

[!include[Krav](../../../includes/req-dev-tools.md)]

Anpassade knappar och länkar läggs till i **Förhandsgranskning**-panelen när du redigerar en layout. URL:en används för att öppna en webbsida i aktuell eller ny flik, köra ett CRMScript från skärmen eller navigera till andra delar av SuperOffice med hjälp av [SoProtocol][3].

Knappar och länkar fungerar på liknande sätt. Skillnaden är att du kan formatera en knapp men inte en länk.

> [!TIP]
> Du kan använda [mallvariabler][1] i URL:erna.

Instruktionerna nedan förutsätter att du redan [redigerar layouten][4].

## Lägg till en knapp

1. Välj fliken du vill redigera.

1. Välj avsnittet **Objekt** till vänster.

1. Klicka och dra elementet **Knapp** till layouten.

1. Klicka för att välja den nya knappen.

1. I avsnittet **Inställningar**, ersätt texten "Knapp" med det nya knappnamnet.

    ![Skärmdesigner, inställningar för knappelement -screenshot][img1]

    > [!TIP]
    > Du kan också lägga till knappnamnet på andra språk.

1. I listan **Åtgärd** väljer du åtgärden som ska utföras när knappen klickas. Se referensseksjonen i slutet av denna sida för mer information om varje åtgärd.

    * Öppna webbplatsen: Välj det här alternativet för att lägga till en länk till en webbplats. Välj URL-kodning och -mål efter behov.

    * Kör CRMScript: Välj det här alternativet för att lägga till ett [CRMScript][2] för att utföra specifika åtgärder i SuperOffice.

    * Genväg ([SoProtocol][3]): Välj det här alternativet för att lägga till en kontroll som navigerar till ett annat område eller skärm i SuperOffice när den klickas.

1. I listan **Läge** väljer du om knappen alltid ska vara tillgänglig, eller om den bara ska vara tillgänglig i läs- eller redigeringsläge.

1. Välj i listan **Stil** knappens stil.

## <a id="link"></a>Lägg till länkar

1. Välj fliken du vill redigera.

1. Välj avsnittet **Objekt** till vänster.

1. Klicka och dra elementet **Länk** till layouten.

1. Klicka för att välja det nya länkfältet.

1. I avsnittet **Inställningar**, ersätt texten "Länk" med det nya länknamnet.

    > [!TIP]
    > Du kan också lägga till länkens namn på andra språk.

1. I listan **Åtgärd**, välj åtgärden som ska utföras när länken klickas. (Samma lista som för knappar.)

1. I listan **Läge** väljer du om länken alltid ska vara tillgänglig, eller om den bara ska vara tillgänglig i läs- eller redigeringsläge.

## Översättning av etiketter

Namnet och text i inforuta kan översättas till andra språk.

När elementet är valt:

1. Klicka på <i class="ph ph-translate" aria-label="Translate"></i> bredvid etiketten.
1. Klicka på **Lägg till** och välj ett språk från listan.
1. Ange text för det nya språket.

    ![Skärmdesigner, översätt etikett -screenshot][img2]

1. Upprepa steg 2-3 för fler språk.
1. Klicka på **Stäng** för att avsluta översättningsdialogen.

Kom ihåg att publicera layouten på nytt.

## Referens

| Inställning | Beskrivning | Kommentar |
|---|---|---|
| Namn | Text | Kan översättas |
| Åtgärd | Vad som händer när du klickar: Öppna webbplats, CRMScript, SoProtocol | |
| Webbadress | URL | HTTP-prefixet läggs till automatiskt. Du måste lägga till 'https://' själv om det är tillämpligt. |
| Läge | När elementet visas: Alltid, läsläge, redigeringsläge | |
| Text i inforuta | Text | Kan översättas |
| Stil | Åtgärd, Normal, Radera, OK, Redigera | Gäller inte länkar |

Vissa inställningar beror på vilken åtgärd som valts.

### Öppna webbplats

* URL-format: ingen, ANSI eller Unicode
* Mål: ny flik eller samma flik

![Skärmdesigner, öppna webbplats på knapp -screenshot][img4]

> [!NOTE]
> Det rekommenderas att specificera protokollet, till exempel `https://www.superoffice.com`; annars är HTTP standard.

### Kör CRMScript

* CRMScript: Välj det specifika skriptet som ska köras.

![Skärmdesigner, kör CRMScript på knapp -screenshot][img3]

[Läs mer om CRMScript][2]

### Genväg (SoProtocol)

* SoProtocol: Den navigations- och innehållsdelen av URL:en utan prefixet `superoffice:`.

![Skärmdesigner, SoProtocol på knapp -screenshot][img5]

[Läs mer om SoProtocol][3]

<!-- Referenced links -->
[1]: ../../../document/templates/variables/from-company-card.md
[2]: ../../../../en/automation/crmscript/overview/index.md
[3]: ../../../../en/customization/soprotocol/index.md
[4]: edit-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/new-button.png
[img2]: ../../../../media/loc/en/customization/translate-button-label.png
[img3]: ../../../../media/loc/en/customization/button-script.png
[img4]: ../../../../media/loc/en/customization/button-website.png
[img5]: ../../../../media/loc/en/customization/button-soprotocol.png
