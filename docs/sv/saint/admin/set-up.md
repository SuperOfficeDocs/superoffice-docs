---
uid: help-sv-saint-setup
title: Konfigurera ny aktivitetsövervakning
description: Konfigurera ny aktivitetsövervakning
keywords: SAINT, aktivitetsövervakning, statusövervakning
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
index: true
redirect_from: 
  - /sv/sale/saint/learn/admin/create-status
  - /sv/sale/saint/learn/admin/select-image-for-status
  - /sv/saint/admin/select-image-for-status
  - /sv/saint/admin/create-status
---

# Konfigurera ny aktivitetsövervakning

[!include[Requirement](../includes/note-saint-req.md)]

Med statusövervakning ser du enkelt alla kunder som behöver uppmärksamhet.

För att skapa en status definierar du dess namn och beskrivning, lägger till minst ett kriterium och anger eventuellt en prioritet, standardtyp för händelse eller bild. Stegen nedan visar hela processen.

## Steg

1. Öppna skärmen **SAINT** i Inställningar och underhåll och välj fliken **Företag**, **Kontakt** eller **Projekt**.

1. Klicka **Lägg till** under listan **Statusövervakning**.

1. I dialogrutan fyller du i dessa fält:

    * **Namn:** Ange ett beskrivande namn för den status du vill lägga till.
        Valfritt: Välj <i class="ph ph-translate" aria-label="Translate"></i> för att [lägga till översättningar][8] av statusnamnet.

    * **Beskrivning:** Ange en tydlig beskrivning av statusen och vilken åtgärd som krävs eller rekommenderas. Du kan också använda [mallvariabler][9] för att anpassa texten till företaget, kontakten eller projektet.

    ![Ny statusövervakningsdialogruta -screenshot][img1]

    Namnet och beskrivningen visas i SuperOffice CRM när användaren håller muspekaren över statusbilden eller öppnar statusdialogen. Du kan senare redigera beskrivelsen.

1. Klicka **Spara**. Välj sedan den nya statusen i listan för att fortsätta med konfigurationen.

1. **Ange kriterier för statusen:**

    1. Under kriterielistan väljer du **Lägg till** för att infoga ett nytt kriterium.
    1. Välj en kriterietyp, ställ in villkoret och ange ett värde.

    ![Kriterielista med flera definierade villkor och knappen Lägg till under listan -screenshot][img3]

    Varje status måste innehålla minst ett kriterium. Upprepa vid behov för att lägga till fler.

1. *(Valfritt)* [Definiera en standardtyp för händelse][2] för statusen i fliken **Skapa uppföljning**.

1. *(Valfritt)* [Välj en bild för att visualisera statusen](#image).

1. Om det finns flera statusar i listan, ställ in **prioriteten** för att kontrollera vilken statusbild som visas på kortet.
    Ett företag, en kontakt eller ett projekt kan matcha kriterierna för flera statusar, men bara en bild kan visas.
    Välj en status och använd pilknapparna under listan för att flytta den uppåt eller nedåt.

    ![Lista över statusövervakningar med prioriteringar -screenshot][img2]

1. När du är klar väljer du <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Regenerera vald statusövervakning** för att aktivera statusen.

## <a id="image"></a>Välja en bild för en status

Du kan lägga till en bild som ska visas på företags-, kontakt- eller projektkort som uppfyller statuskriterierna. Bilden visas som ett ljust vattenstämpel (40% transparens) så att den inte skymmer annat innehåll.

Att lägga till en bild är valfritt. Det kan hjälpa till att dra uppmärksamhet och symbolisera den typ av uppföljningsåtgärd du vill att användarna ska vidta. Om du bara vill använda statusen för sökningar eller urval kan du lämna den utan bild.

1. I statuslistan väljer du önskad status.
1. På höger sida av skärmen markerar du **Visualisera** för att visa bilden.
1. Välj **Ändra bild**.
1. Gör något av följande:
    * Välj en av de befintliga bilderna från listan **Bilder**.
    * Välj **Lägg till**, ladda upp en fil, ange en beskrivning och välj **Spara**.
1. Välj **OK** för att bekräfta.

[!include[File type and size](../../learn/includes/image-type-and-size.md)]

> [!TIP]
> Använd enkla, ljusfarget bilder som representerar statusen på ett meningsfullt sätt. Till exempel kan ett spindelnät symbolisera inaktivitet.

## Använd mallvariabler i beskrivningar

Du kan använda mallvariabler i fältet **Beskrivning** för att anpassa texten som visas i uppföljningar eller statusdialoger. Variabler ersätts med information från företaget, kontakten eller projektet.

### Exempel

En status kan gälla för till exempel alla företag som uppfyller följande kriterier:

* Kategori = Kund
* Den senaste försäljningen var för över 2 månader sedan
* Antal försäljningar är över 50

Texten i fältet **Beskrivning** kan till exempel vara:

"&lt;name&gt; har tidigare varit en bra kund, men vi har inte sålt något till dem på 2 månader. &lt;cont&gt; är huvudkontakten för denna kund och bör kontakta kunden snart per telefon (&lt;cpho&gt;) eller e-post (&lt;mail&gt;) för att ta reda på varför."

I detta exempel används följande mallvariabler:

| Variabel | Beskrivning |
|---|---|
| name | Namnet på företaget |
| cont | Namnet på vår kontakt för företaget |
| cpho | Företagets telefonnummer |
| mail | Företagets e-postadress |

## Relaterat innehåll

* [Uppdatera, ta bort och återställ statusövervakning][2]
* [Räknare och räknarinställningar (period)][7]
* [Regenerera statusövervakning och räknare][4]

<!-- Referenced links -->
[2]: update.md
[4]: update.md#regen
[7]: counter-settings.md
[8]: ../../localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/new-status-monitor.png
[img2]: ../../../media/loc/en/saint/status-list-priority.png
[img3]: ../../../media/loc/en/saint/criteria.png
