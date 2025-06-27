---
uid: help-sv-languages-add
title: Arbeta med kundspråk
description: Den här guiden beskriver hur du konfigurerar kundspråk.
author: SuperOffice RnD
date: 06.29.2022
keywords: språk
content_type: howto
language: sv
---

# Skapa och redigera kundspråk

## Så här lägger du till kundspråk

1. [!include[Go to Options](../includes/open-options.md)]

2. Välj fliken **Kundspråk**.

3. Klicka på knappen **Nytt kundspråk**. Du kommer då till skärmen **Egenskaper för kundspråk**.

    ![Du kan konfigurera ett nytt språk under egenskaper i dialogrutan Kundspråk -screenshot][img1]

4. Skriv språkets namn i fältet **Namn**. Detta namn kommer att användas som ledtext i språkvalsfälten.

5. I fältet **Språkkod** anger du en kort kod för det aktuella språket (eller motsvarande). Normalt används de internationella förkortningarna på två bokstäver (exempelvis DE, DK, EN, NL, NO och SE). Längst ner på den här sidan finns en fullständig lista.

6. I fältet **Virtuell domän** anger du den domänadress som ger åtkomst till SuperOffice Kundcenter för det aktuella språket, t.ex. germany.liberty.com. Sådana domäner måste skapas i förväg.

7. I fältet **E-postdomäner** lägger du till e-postdomäner (med komma mellan). Exempel: no, se, co.uk. Om en ny kontakt registreras automatiskt (vid import av e-post) och kontakten har en e-postadress som slutar på någon av dessa domäner väljs motsvarande språk automatiskt för kontakten.

8. I fältet **FAQ-mapp** väljer du vilken FAQ-mapp som ska vara överst i FAQ-hierarkin för dem som använder SuperOffice Kundcenter på det aktuella språket. FAQ-modulen kan med andra ord delas in i flera olika språkdelar och sedan filtreras efter språk. Det ger bättre sökresultat och endast FAQ-poster på det aktuella språket visas för användaren.

9. Markera **Använd som standard** om du vill att detta språk ska användas som standardspråk. Detta språk kommer då att användas om inget annat kundspråk stämmer med kriterierna eller om inget språk har definierats för en kund.

10. Klicka på **OK**. Kundspråket skapas och du får möjlighet att skapa [externa kategorier][1].

    > [!TIP]
    > Det går att använda kundspråk för andra saker än språk, till exempel om ni endast har verksamhet i ett land. En möjlighet är att skapa olika avdelningar, industrisektioner eller branscher, t.ex. Bygg och konstruktion, Badrum, Interiörer eller Trädgårdar. Då kan SuperOffice Kundcenter, FAQ-hierarkin och svarsmallarna återspegla den sektor som är relevant för specifika kunder. Den förkortning som används för avdelningen måste återspegla mappnamnet i mappen \\templates. Exempel: Bygg och konstruktion = BC.

## Språkkoder

[!include[Language codes](includes/language-codes.md)]

## Vad vill du veta mer om?

* [Arbeta med externa kategorier][1]
* [Så väljer SuperOffice kundspråk för nya kontakter][2]

<!-- Referenced links -->
[1]: external-categories.md
[2]: select-language.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/customer-centre-language.png
