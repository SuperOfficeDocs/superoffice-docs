---
uid: help-sv-privacy
title: Integritet
description: integritet
author: SuperOffice RnD
so.date: 06.29.2022
keywords: integritet, GDPR, e-marknadsföring, samtycke
so.topic: concept
language: sv
---

# Integritet

Med **Integritet**-funktionen i SuperOffice kan du skydda kundens personliga data och följa EU:s nya dataskyddsförordning (GDPR).

[!include[Need concent](includes/why-consent.md)]

Detta är två olika syften för att få samtycke av en person. I SuperOffice kallas dessa syften **Försäljning och tjänster** och **E-marknadsföring**. Det kan också vara andra syften som är relevanta för din verksamhet.

På fliken **Samtycke** i fönstret **Integritet** (![ikon][img1]) kan du [skapa och redigera syften][2].

En rättslig grund och en samtyckeskälla måste dokumenteras för varje syfte (under import eller i SuperOffice CRM för enskilda användare eller grupper av användare).

## <a id="legal-basis" />Rättslig grund

Du måste dokumentera den rättsliga grunden för varje syfte som registrerats för en kontakt. I den här listan lägger du till och underhåller listan över rättsliga grunder som används när du redigerar integritetsinställningarna för dina kontakter.

Exempel: En person skickar en förfrågan via ett webbformulär och markerar alternativet ”Prenumerera på nyhetsbrev” (eller liknande). Det innebär att denna person har gett sitt samtycke till att ta emot e-marknadsföring från ditt företag. Den rättsliga grunden är alltså **Samtycke** för syftet e-marknadsföring.

## <a id="source" />Källa

Var och hur fick du samtycke från en kontakt? Exempel: E-post, chatt, webbformulär och kundportal.

## Alternativ på fliken Samtycke

Fliken **Samtycke** innehåller en lista över alla tillgängliga syften.

## Aktivera eller inaktivera ett syfte

I kolumnen **Aktiv** kan du aktivera och inaktivera syften. Det är bättre att inaktivera ett syfte än att ta bort det.

## Lägga till ett nytt syfte

Klicka på **Lägg till** under listan över syften. Se [Lägga till syfte][2].

## Ange standard för rättslig grund

När en kontakt skapas i SuperOffice CRM anges inte rättslig grund för syftet **Försäljning och tjänster**. Du kan välja en standard för rättslig grund som ska användas för syftet **Försäljning och tjänster** när en person skapas. Detta värde utgör också standard för rättslig grund för importerade kontakter, om inte ett annat värde har valts vid importen.

Välj alternativet **Ange standard för rättslig grund** och välj rättslig grund i listan. Den rättsliga grunden anges för alla nya kontakter för syftet **Försäljning och tjänster**.

[Lägga till poster i listan Integritet – Rättslig grund][3]

## Filtrera mottagare utifrån medgivande till e-marknadsföring och aktiva prenumerationer

Om du väljer det här alternativet kommer enbart personer som gett sitt medgivande till att ta emot e-marknadsföring, eller som har en prenumeration, att läggas till i listan över mottagare i ett utskick.

Om du *inte* väljer det här alternativet kommer bara personer med **E-marknadsföring** inställt på **AV** och med rättslig grund inställt på **Återkallat** att filtreras bort från mottagarlistan. Den fungerar på samma sätt som för **Inga utskick**.

## Vad vill du göra nu?

* [Läs mer om GDPR och styrningen av integritet och samtycke i SuperOffice][1]
* [Lägga till poster i listan Integritet – Rättslig grund][3]
* [Lägga till poster i listan Integritet – Källa][4]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/learning/best-practices-tips/gdpr/how-to-set-up-privacy-settings-for-gdpr-in-superoffice-crm/
[2]: admin/add-consent-purpose.md
[3]: ../../../admin/lists/learn/privacy-legal-base-add.md
[4]: ../../../admin/lists/learn/privacy-source-add.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-privacy-active.png
