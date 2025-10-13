---
uid: help-sv-customer-language-add
title: Lägg till kundspråk
description: Den här guiden beskriver hur du konfigurerar kundspråk.
keywords: kundspråk, lägga till språk, nytt kundspråk, språkkod
author: digitaldiina
date: 10.09.2025
version: 11.5
content_type: howto
category: localization
topic: language
audience: settings
audience_tooltip: Settings and maintenance
redirect_from: /sv/admin/options/learn/custlang/update
language: sv
index: true
---

# Lägg till kundspråk

På skärmen **Kundspråk** visas en lista över installerade [kundspråk][2]. På den här sidan kan du konfigurera kundspråken så att det blir enkelt att kommunicera med kunder på olika språk.

Till exempel:

* Du kan ha flera språkversioner av SuperOffice Customer Centre, FAQ och svarsmallar.
* Du kan ange ett språk för en kontakt så att personen automatiskt får svarsmallar på det språket.
* [Supportärenden kan delas in][1] i olika grupper för olika avdelningar och språk.

Som standard kan du lägga till 6 olika språk. Om språket du vill använda inte är tillgängligt ber vi dig att kontakta oss så kan våra konsulter hjälpa dig att lägga till de språk du behöver.

## Steg

1. Gå till Inställningar och underhåll och välj <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Alternativ**.

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

| Språk | Kod |
|---|:-:|
| Kinesiska (förenklat) | CN |
| Tjeckiska | CZ |
| Danska | DA (inte DK) |
| Holländska | NL |
| Engelska | EN |
| Finska | FI |
| Franska | FR |
| Tyska | DE |
| Tyska (Schweiz) | CH |
| Italienska | IT |
| Koreanska | KO |
| Norska | NR |
| Polska | PL |
| Portugisiska (Brasilien) | BR |
| Ryska | RU |
| Spanska | ES |
| Svenska | SE (inte SV) |
| Ukrainska | Storbritannien |
| Vietnamesiska | VI |

## Relaterat innehåll

* [Så väljer SuperOffice kundspråk för nya kontakter][2]

<!-- Referenced links -->
[1]: ../../request/admin/category/external-categories.md
[2]: ../learn/customer-languages.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/customer-centre-language.png
