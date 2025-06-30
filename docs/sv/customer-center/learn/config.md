---
uid: help-sv-customer-center-config
title: Konfigurera kundcenter
description: Den här guiden beskriver hur du konfigurerar ditt Kundcenter.
keywords: Tjänst, Kundcenter, CEP
author: SuperOffice RnD
date: 02.25.2025
content_type: howto
language: sv
---

# Konfigurera Kundcenter <i class="ph ph-question" aria-label="Question mark"></i>

[!include[Requirement](../../learn/includes/req-cep.md)]

Du kan redigera ditt kundcenters stilmall och layout och förhandsgranska ändringarna.

![Konfigurera chattwidgeten i ditt Kundcenter så att kunderna kan chatta med dig när de besöker din webbplats -screenshot][img2]

Om kundcentret är flerspråkigt kan du välja alternativ (till exempel välkomsttext, öppettider och telefonnummer) för varje enskilt språk.

> [!NOTE]
> Om du vill redigera HTML-koden för de olika sidorna [uppdaterar du källfilerna][1].

## Steg

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Välj **Kundcenter** > **Konfigurera**. Det finns 2 flikar i fönstret **Kundcenter**: **Stilmall** och **Systemval**. Högst upp på den här sidan finns en länk till en förhandsgranskning av Kundcenter-sidan.

1. På fliken **Stilmall** kan du redigera olika inställningar för hur du vill att kundcentret ska se ut och upplevas: Logotyp, önskad bredd, färger och typsnitt. Förhandsgranskningen uppdateras automatiskt.

    ![Förhandsgranska dina Kundcenter-sidor -screenshot][img3]

1. Gå till fliken **Alternativ**.

1. Välj den språkversion som du vill redigera.

1. Redigera alternativen. Mer information om varje alternativ finns nedan.

1. Klicka på **Spara**.

1. Upprepa steg 4–6 för att ange alternativen för ett annat språk.

1. Klicka på **Spara** när du är klar.

## Alternativ

| Alternativ | Beskrivning |
|---|---|
| Logotyp-URL | Länken till logotypbilden. |
| Webbplatsens namn | Rubriken på webbsidan. |
| Välkommen, rubrik | Text som visas i rubrikfältet. |
| Välkommen, brödtext | Brödtext som visas i rubrikfältet. |
| Visa öppettider | Välj det här alternativet om du vill visa öppettider bredvid rubrikfältet. Ange öppettiderna i fältet nedan. |
| Visa telefonnummer | Välj det här alternativet om du vill visa ditt telefonnummer bredvid rubrikfältet. Ange telefonnumret i fältet nedan. |
| Aktivera sökning på välkomstsidan | Välj det här alternativet om du vill visa sökfältet för vanliga frågor i rubrikfältet. Ange platshållartext i fältet nedan. Exempel: "skriv text här för att söka i FAQ". |
| Aktivera information på välkomstsidan | Välj det här alternativet om du vill visa ett textfält under rubrikfältet. Klicka på **Redigera** för att skriva text. |
| Visa de vanligaste frågorna på välkomstsidan | Välj det här alternativet om du vill visa de vanligaste och de senaste frågorna. |
| Aktivera sidfot | Välj det här alternativet om du vill visa en sidfot längst ned på sidan. Klicka på **Redigera** för att skriva text. |
| Aktivera chatt | Välj det här alternativet om du vill aktivera chattfönstret i det nedre högra hörnet av sidan. Välj **Alltid** om du vill att chattfönstret ska vara tillgängligt för alla som besöker kundcentret. Annars väljer du **Inloggade kunder** för att kräva att användarna loggar in för att komma åt chattfönstret. |
| Chattkanal | Välj den chattkanal du vill använda. Om ingen chattkanal väljs kommer chattfönstret inte att vara tillgängligt. |
| Använd det anpassade formuläret "Kontakta oss" | Välj det här alternativet om du vill använda ett anpassat formulär i stället för standardformuläret. Välj ett formulär i listan.|

<!-- Referenced links -->
[1]: edit.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/customer-center/customer-centre-chat-with-agents.jpg
[img3]: ../../../media/loc/en/customer-center/config-cust-centre.png
