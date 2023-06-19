---
uid: help-sv-mailing-manage-subscriptions
title: Hantera e-postprenumerationer
description: Med funktionerna för prenumerationshantering i SuperOffice CRM kan du dokumentera vilken typ av innehåll dina kontakter vill få från dig.
author: SuperOffice RnD
so.date: 02.16.2023
keywords: marknadsföring
so.topic: howto
language: sv
---

# Hantera e-postprenumerationer

Med funktionerna för prenumerationshantering i SuperOffice CRM kan du dokumentera vilken typ av innehåll dina kontakter vill få från dig.

Dessa funktioner är kopplade till **samtyckeshantering** eftersom du i vissa länder också måste dokumentera en persons samtycke innan du kan skicka utskick med e-marknadsföring till dem.

Funktionerna **för prenumerationshantering** hjälper dig att undvika att skicka e-marknadsföringsmeddelanden till någon som inte har gett sitt samtycke.

Den här funktionen säkerställer att alla kontaktpersoner i din CRM-databas alltid har kontroll över sina e-postprenumerationer. När du har lagt till dem i din SuperOffice-databas kan de ange vilka utskick de vill få. Varje gång dina kontakter får dina utskick kan de ändra sina prenumerationsinställningar med hjälp av avregistreringslänken i e-postmeddelandet.

Att dina kunder kan hantera sina egna prenumerationer kommer att påverka öppningsgraden för dina utskick positivt och göra att dina marknadsföringsinsatser blir mer framgångsrika totalt sett.

## Din mållista

När du [skapar din mållista][1] för ditt nästa utskick kan du göra ett urval baserat på den prenumerationstyp du ska använda. Genom att göra detta kommer SuperOffice CRM endast att lägga till kontakter som har sagt "ja" till denna typ av prenumeration.

## Välj prenumerationstyp

Det finns flera sätt att skapa din mållista med hjälp av ett urval. Det innebär att du kanske inte alltid använder en prenumerationstyp som urvalskriterium. När du gör det är det lätt att glömma bort att du har lagt till de personer som sa "nej" till att ta emot dina utskick i din mållista.

För att förhindra att du skickar utskick till personer som inte vill ta emot dem kan SuperOffice CRM hjälpa dig genom att filtrera bort de personer som inte har gett dig sitt samtycke.

När du skapar ett nytt utskick kommer e-postguiden att be dig att lägga till den prenumerationstyp du vill skicka i Steg 1: Konfiguration.

![Välj vilken typ av utskick du skickar ut i konfigurationssteget. -screenshot][img1]

När du har lagt till din utskickstyp kontrollerar SuperOffice CRM varje kontakt du lägger till som mottagare för att se om de har gett dig sitt samtycke till att du skickar utskick till dem.

I steg 4 i utskicksguiden, som heter Mottagare, kan du se exakt vem som har och vem som inte har gett dig sitt samtycke. När funktionen e-marknadsföringsintegritet är aktiverad filtrerar SuperOffice CRM automatiskt bort alla mottagare som inte har valt att delta baserat på deras samtycke till e-marknadsföring och aktiva prenumerationer.

> [!TIP]
> Du har en kryssruta för att åsidosätta samtycke och prenumeration, om utskicket är mycket viktigt att skicka ut till alla kontakter.

![När du har lagt till mottagare i e-postlistan kan du se om de har gett sitt samtycke eller inte till den här typen av utskick. -screenshot][img2]

Om funktionen för e-marknadsföringsintegritet är avstängd innebär det att SuperOffice CRM kommer att bortse från samtycken och prenumerationspreferenser när du skickar dina utskick. För att aktivera funktionen för e-marknadsföringsintegritet behöver du administratörsrättigheter.

Om du vill veta mer kan du titta på videon om hur du konfigurerar integritetsinställningarna för GDPR i SuperOffice CRM.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/1e0ZIUwX3IY?list=PL9fefjwA0X290ZZ8bMUHWh_d6s3Y2P0Jr]

![I Inställningar och underhåll kan du aktivera funktionen för e-marknadsföringsintegritet. -screenshot][img3]

## Använd länken för avregistrering

Ibland ändrar människor sig vad gäller vilka e-postmeddelanden de vill ta emot. När detta händer bör de ha möjlighet att välja bort den typ av utskick du har skickat dem. Därför levereras alla SuperOffice CRM-e-postmallar med en avregistreringslänk.

> [!TIP]
> Information om hur du skickar e-postmeddelandet för Hantera prenumeration till en kontakt finns i Skicka e-post om integritet.

Genom att klicka på den här länken kommer dina mottagare till sin sida för prenumerationsinställningar, där de kan välja vilken typ av utskick de vill ta emot. De ändringar som dina kontakter gör sparas så snart de bekräftar de nya inställningarna.

![Välj vilka utskick du vill ta emot på sidan med prenumerationsinställningar. -screenshot][img4]

Din kund har kontroll över de utskick de tar emot och du kan se till att du bara skickar dina utskick till de personer som är intresserade.

Med SuperOffice CRM respekterar du dina kontakters kommunikationspreferenser och kan se till att du följer reglerna i GDPR. På så sätt riskerar du aldrig att få böter på 20 000 000 euro.

## Relaterat

* [GDPR och integritet][2]
* [Skicka e-post om integritet][3]
* [SuperOffice Meddelande om behandling av personuppgifter][4]

<!-- Referenced links -->
[1]: create/target-list.md
[2]: ../../../security/privacy/learn/index.md
[3]: ../../../security/privacy/learn/send-privacy-confirmation-email.md
[4]: https://www.superoffice.com/company/privacy/

<!-- Referenced images -->
[img1]: media/setup-type-drop-down.png
[img2]: media/recipients-content-status.png
[img3]: media/e-marketing-privacy-feature.png
[img4]: media/subscription-preferences-page.png
