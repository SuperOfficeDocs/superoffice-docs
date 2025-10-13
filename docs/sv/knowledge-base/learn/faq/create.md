---
uid: help-sv-faq-create
title: Skapa FAQ-poster
description: Skapa FAQ-poster
keywords: FAQ
author: Bergfrid Dias
date: 07.15.2025
version: 10.5
content_type: howto
category: service
topic: faq
license: servicepremium
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: sv
redirect_from: /sv/faq/learn/create
---

# Skapa FAQ-poster

Genom att skapa FAQ-poster kan ditt företag bygga upp en omfattande samling frågor och svar som både kunder och medarbetare kan använda för att hitta användbar information. FAQ-poster kan skapas på två sätt:

* En användare kan skapa en FAQ-post baserat på kommunikation med en kund i ärendefönstret.
* En administratör kan skapa en FAQ-post direkt i **Kunskapsbas** > **FAQ**.

## Krav

* Du behöver en licens för Service Premium eller Customer Engagement-plattformen för att använda kunskapsbasen.
* Om du inte ser den här funktionen måste du lägga till *Kunskapsbas* som funktionell rättighet för att skapa FAQ-artiklar.

## Skapa FAQ-poster från ett ärende

Om du svarar på en förfrågan och tänker att samma fråga antagligen kommer att ställas igen, kan det vara smart att utforma ett svar som kan återanvändas och göras tillgängligt för alla kunder.

1. [Öppna ett ärende][1].

1. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> och välj **Publicera i FAQ**. Då kommer du till skärmen **Egenskaper för FAQ-post**.

   ![Fönstret Egenskaper för FAQ-post -screenshot][img5]

1. Redigera ärendets namn i fältet **Namn** om det behövs.

1. I fältet **Placering** väljer du ett nummer som representerar postens placering i sorteringsordningen i den mapp som posten tillhör. 1 betyder överst i listan.

1. I fältet **Mapp** väljer du vilken mapp du vill placera posten i (om du har en [mappstruktur för FAQ-poster][2]).

1. I fältet **Åtkomst** väljer du vem som ska ha åtkomst till den aktuella FAQ-posten:

    * **Bara tillgängligt för dig**: Bara du. Detta kan vara relevant om du skapar nya FAQ-poster eller uppdaterar gamla FAQ-poster.
    * **Tillgängligt för ärendehandläggare**: Endast interna användare (inte kunder som använder SuperOffice Kundcenter).
    * **Tillgängligt för registrerade kunder**: Registrerade kunder som har inloggning till SuperOffice Kundcenter.
    * **Tillgängligt för alla**: Alla (ingen inloggning krävs för att läsa FAQ-posten).

1. I fältet **Nyckelord** kan du lägga in nyckelord (använd mellanrum eller komma som skiljetecken) för posten. Tänk på att bara ange nyckelord som är relevanta för posten. Nyckelord gör det enklare att hitta posten när du söker. Dessutom används nyckelord för att automatiskt föreslå FAQ-poster som matchar ett ärende från en kund.

1. Om du är FAQ-administratör kan du välja mellan följande alternativ i fältet **Arbetsflöde**:

    * **Inte publicerad**: Välj detta alternativ om du inte vill publicera FAQ-posten just nu.
    * **Publicerad**: Välj det här alternativet om du vill [publicera FAQ-posten omedelbart][3].
    * **Utgången**: Välj detta alternativ om FAQ-posten inte längre är aktuell. Relevant när du redigerar befintliga FAQ-poster.

    > [!NOTE]
    > Listan innehåller även alla egendefinierade arbetsflödessteg som har skapats i systemet.

1. Om du väljer ett datum i fältet **Giltig till** ändras postens status till **Utgången** på detta datum. Efter detta är den inte längre tillgänglig för andra än FAQ-administratörerna. De får en varning om att posten är utgången. Detta kan vara aktuellt i samband med kampanjer. Om du inte anger något datum här innebär det att FAQ-posten alltid är tillgänglig.

1. I fältet **Bilaga** kan du lägga till ett eller flera dokument som bilagor till ärendet:

    1. Klicka på **Bläddra** bredvid **Bilaga**.
    2. Bläddra dig fram till önskat dokument i dialogrutan.
    3. Klicka på **+** för att lägga till bilagan.
    4. Upprepa denna procedur om du vill lägga till fler bilagor.

1. I fältet **Länk** kan du lägga till en eller flera adresser till relevanta webbsidor:

    1. I fältet till vänster skriver du det namn som ska visas för länken.
    2. I fältet till höger anger du själva webbadressen efter `http://`
    3. Klicka på **+** för att lägga till länken.
    4. Upprepa denna procedur om du vill lägga till fler länkar.

1. Gå till fliken **Fråga**.

1. Skriv den fråga som du vill att FAQ-posten ska innehålla. Som standard klistras det första meddelandet i ärendet in på fliken **Fråga**.

    > [!TIP]
    > Klicka på knappen **Formatera typsnitt** (<i class="ph ph-text-a-underline" aria-hidden="true"></i>) om du vill ändra textens layout.

1. Gå till fliken **Svar** och skriv in svaret. Som standard klistras de nästkommande meddelandena i ärendet in på fliken **Svar**.

1. Om du har mer än ett [språk][6] måste du välja de olika **språken** i sidfoten och upprepa stegen för **Fråga** och **Svar**.

1. Klicka på **OK** när du är färdig. Skärmen **FAQ-post** visas och ditt förslag på FAQ-post skickas till administratören, som kan publicera den.

## Skapa ny FAQ

1. Gå till <i class="ph ph-list" aria-label="Main menu"></i> i det övre fältet och välj **Kunskapsbas** > **Vanliga frågor**.

1. Gå till mappen som du vill lägga in FAQ-posten i. Om den inte finns än kan du [skapa en ny mapp][2].

1. Klicka på knappen **Ny post**. Då kommer du till skärmen **Egenskaper för FAQ-post**.

    ![FAQ-fönstret -screenshot][img3]

1. Följ anvisningarna ovan från **steg 3**.

Eftersom det bara är **administratörer** som kan skapa FAQ-poster på det här sättet behövs inget separat publiceringssteg i processen. Administratören kan skapa och publicera samtidigt.

## Vad vill du göra nu?

* [Redigera FAQ-poster][4]
* [Lägg till FAQ-artikel i ett meddelande][5]
* [Konfigurera flera språk][6]

<!-- Referenced links -->
[1]: ../../../request/learn/index.md#open
[2]: ../manage-folders.md
[3]: publish.md
[4]: edit.md
[5]: ../../../request/learn/reply.md#faq
[6]: ../../../localization/learn/customer-languages.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/faq/create-publish-faq.png
[img5]: ../../../../media/loc/en/faq/faq-create.png
