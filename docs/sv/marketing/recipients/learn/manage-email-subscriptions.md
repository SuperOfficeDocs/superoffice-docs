---
uid: help-sv-mailing-manage-subscriptions
title: Hantera e-postprenumerationer
description: Med funktionerna för prenumerationshantering i SuperOffice CRM kan du dokumentera vilken typ av innehåll dina kontakter vill få från dig.
keywords: prenumerationshantering
author: Bergfrid Dias
date: 09.26.2025
version: 11
content_type: concept
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Hantera e-postprenumerationer

SuperOffice CRM:s funktioner för prenumerationshantering ger dina kontakter möjlighet att specificera det innehåll de vill ta emot. Detta är kopplat till samtyckeshantering, eftersom vissa jurisdiktioner kräver dokumenterat samtycke innan e-marknadsföringsutskick kan skickas.

Dessa funktioner förhindrar att e-marknadsföringsmeddelanden skickas till dem som inte har samtyckt, vilket säkerställer att dina kontakter behåller kontrollen över sina e-postprenumerationer. Från det ögonblick de läggs till i din SuperOffice-databas kan kontakter specificera sina utskickspreferenser. De kan också justera dessa preferenser via avprenumerationslänken i varje e-post.

Genom att möjliggöra för kunder att hantera sina prenumerationer kan du förbättra öppningsfrekvensen för dina utskick och öka din marknadsföringssuccé.

## Intressen i SuperOffice CRM

Du kan registrera intressen (t.ex. "Månatligt nyhetsbrev") för kontakterna. I stället för att använda avregistrering kan du enkelt ved å lage en [kobling som fjerner den aktuelle interessen][5] hos kunder som inte vill ha nyhetsbrevet. Samma metod kan användas för att registrera intressen.

## Din mållista

När du [skapar din mållista][1] för ditt nästa utskick kan du göra ett urval baserat på den prenumerationstyp du ska använda. Genom att göra detta kommer SuperOffice CRM endast att lägga till kontakter som har sagt "ja" till denna typ av prenumeration.

## Välj prenumerationstyp

Det finns flera sätt att skapa din mållista med hjälp av ett urval. Det innebär att du kanske inte alltid använder en prenumerationstyp som urvalskriterium. När du gör det är det lätt att glömma bort att du har lagt till de personer som sa "nej" till att ta emot dina utskick i din mållista.

För att förhindra att du skickar utskick till personer som inte vill ta emot dem kommer e-postguiden att be dig att lägga till den prenumerationstyp du vill skicka i Steg 1: Konfiguration.

![Välj vilken typ av utskick du skickar ut i konfigurationssteget. -screenshot][img1]

När du har lagt till din utskickstyp kontrollerar SuperOffice CRM varje kontakt du lägger till som mottagare för att se om de har gett dig sitt samtycke till att du skickar utskick till dem.

I steg 4 i utskicksguiden, som heter Mottagare, kan du se exakt vem som har och vem som inte har gett dig sitt samtycke. När funktionen e-marknadsföringsintegritet är aktiverad filtrerar SuperOffice CRM automatiskt bort alla mottagare som inte har valt att delta baserat på deras samtycke till e-marknadsföring och aktiva prenumerationer.

> [!TIP]
> Du har en kryssruta för att åsidosätta samtycke och prenumeration, om utskicket är mycket viktigt att skicka ut till alla kontakter.

![När du har lagt till mottagare i e-postlistan kan du se om de har gett sitt samtycke eller inte till den här typen av utskick. -screenshot][img2]

Om funktionen för e-marknadsföringsintegritet är avstängd innebär det att SuperOffice CRM kommer att bortse från samtycken och prenumerationspreferenser när du skickar dina utskick. För att aktivera funktionen för e-marknadsföringsintegritet behöver du administratörsrättigheter.

![I Inställningar och underhåll kan du aktivera funktionen för e-marknadsföringsintegritet. -screenshot][img3]

## Använd länken för avregistrering

Ibland ändrar människor sig vad gäller vilka e-postmeddelanden de vill ta emot. När detta händer bör de ha möjlighet att välja bort den typ av utskick du har skickat dem. Därför levereras alla SuperOffice CRM-e-postmallar med en avregistreringslänk.

> [!TIP]
> Information om hur du skickar e-postmeddelandet för Hantera prenumeration till en kontakt finns i [Skicka e-post om integritet][3].

Genom att klicka på den här länken kommer dina mottagare till sin sida för prenumerationsinställningar, där de kan välja vilken typ av utskick de vill ta emot. De ändringar som dina kontakter gör sparas så snart de bekräftar de nya inställningarna.

![Välj vilka utskick du vill ta emot på sidan med prenumerationsinställningar. -screenshot][img4]

Din kund har kontroll över de utskick de tar emot och du kan se till att du bara skickar dina utskick till de personer som är intresserade. Med SuperOffice CRM respekterar du dina kontakters kommunikationspreferenser och kan se till att du följer reglerna i GDPR. På så sätt riskerar du aldrig att få böter på 20 000 000 euro.

## Relaterat innehåll

* [GDPR och integritet][2]
* [SuperOffice Meddelande om behandling av personuppgifter][4]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../security/privacy/learn/index.md
[3]: ../../../security/privacy/learn/send-privacy-confirmation-email.md
[4]: https://www.superoffice.com/company/privacy/
[5]: ../../tracked-links/learn/define-link-actions.md#interests

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/setup-type-drop-down.png
[img2]: ../../../../media/loc/en/marketing/recipients-content-status.png
[img3]: ../../../../media/loc/en/marketing/e-marketing-privacy-feature.png
[img4]: ../../../../media/loc/en/marketing/subscription-preferences-page.png
