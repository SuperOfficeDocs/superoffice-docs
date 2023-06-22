---
uid: help-da-mailing-manage-subscriptions
title: Administrere e-mail-abonnementer
description: "Funktionerne til administration af abonnementer i SuperOffice CRM giver dig mulighed for at dokumentere, hvilken type indhold dine kontakter ønsker at modtage fra dig."
author: SuperOffice RnD
so.date: 02.16.2023
keywords: marketing
so.topic: howto
language: da
---

# Administrere e-mail-abonnementer

Funktionerne til administration af abonnementer i SuperOffice CRM giver dig mulighed for at dokumentere, hvilken type indhold dine kontakter ønsker at modtage fra dig.

Disse funktioner er koblet til **Samtykkeadministration**, fordi du i nogle lande også er forpligtet til at dokumentere en persons samtykke, inden du kan sende dem e-marketing.

Funktionerne i**Abonnementsadministration** hjælper dig med at undgå at sende e-marketingmeddelelser til personer, der ikke har givet deres samtykke.

Denne funktionalitet sikrer, at alle kontaktpersoner i din CRM-database til enhver tid har kontrol over deres e-mail-abonnementer. Fra det øjeblik du tilføjer dem til din SuperOffice-database, kan de fortælle dig, hvilke mailudsendelser de ønsker at modtage. Hver gang dine kontakter modtager dine mailudsendelser, kan de ændre deres abonnementspræferencer ved hjælp af afmeldingslinket i e-mailen.

Det faktum, at dine kunder er i stand til at administrere deres egne abonnementer, vil positivt påvirke åbningsraten for dine mailudsendelser og gøre din marketingindsats mere vellykket.

## Din målliste

Når du ][1]opretter din målliste[ til din næste mailudsendelse, kan du foretage et valg baseret på den abonnementstype, du vil anvende. Dermed vil SuperOffice CRM kun tilføje kontakter, der har sagt "ja" til denne type abonnement.

## Vælge abonnementstype

Der er flere måder at oprette din målliste på ved hjælp af en udvælgelse. Det betyder, at du måske ikke altid bruger abonnementstypen som udvælgelseskriterium. Når du gør det, er det nemt at glemme, at du har tilføjet de personer, der sagde nej til at modtage dine mails, til din målliste.

For at forhindre, at du sender mails til personer, som ikke ønsker at modtage dem, kan SuperOffice CRM hjælpe dig ved at filtrere de personer fra, som ikke har givet dig deres samtykke.

Når du opretter en ny mailudsendelse, vil udsendelsesguiden i trin 1 bede dig om at tilføje den abonnementstype, du ønsker at sende til: Opsætning.

![I opsætningstrinnet vælger du, hvilken type mail du vil sende ud. -screenshot][img1]

Når du har angivet typen af mailudsendelse, vil SuperOffice CRM tjekke hver enkelt kontakt, du tilføjer som modtager, for at se, om de har givet dig deres samtykke til at sende dem denne type udsendelse.

I mailudsendelsesguidens trin 4, der hedder Modtagere, kan du se præcis, hvem der har givet dig deres samtykke, og hvem der ikke har. Når funktionen Beskyttelse af personoplysninger for E-Marketing er slået til, filtrerer SuperOffice CRM automatisk alle modtagere fra, der ikke har tilmeldt sig baseret på deres samtykke til e-marketing og aktive abonnementer.

> [!TIP]
> Der er et afkrydsningsfelt til Tilsidesæt samtykke og abonnement, hvis det er meget vigtigt at få mailudsendelsen ud til alle kontakter.

![Når du har tilføjet modtagere til udsendelsen, kan du se, om de har givet samtykke til den type udsendelse. -screenshot][img2]

Hvis funktionen Beskyttelse af personoplysninger for E-Marketing er slået FRA, betyder det, at SuperOffice CRM vil se bort fra samtykker og abonnementspræferencer, når du sender dine mails. Hvis du vil aktivere funktionen Beskyttelse af personoplysninger for e-marketing, skal du have administratorrettigheder.

Hvis du vil vide mere, kan du se videoen om, hvordan du kan konfigurere privatlivsindstillingerne for GDPR i SuperOffice CRM.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/1e0ZIUwX3IY?list=PL9fefjwA0X290ZZ8bMUHWh_d6s3Y2P0Jr]

![Under Indstillinger og vedligeholdelse kan du aktivere funktionen til beskyttelse af personoplysninger for e-marketing. -screenshot][img3]

## Bruge afmeldingslinket

Nogle gange skifter folk mening om, hvilke e-mails de vil modtage. Når det sker, bør de have mulighed for at fravælge den type mail, du har sendt dem. Derfor følger der et afmeldingslink med alle mailskabeloner i SuperOffice CRM.

> [!TIP]
> Hvis du vil sende en mail om at Administrere abonnement til en kontakt, se Sende mail om beskyttelse af personoplysninger.

Hvis du klikker på dette link, kommer modtagerne til siden med abonnementspræferencer, hvor de kan vælge den type mailudsendelser, de vil modtage. De ændringer, dine kontakter foretager, gemmes, så snart de bekræfter de nye indstillinger.

![Vælg de e-mails, du gerne vil modtage, på siden med abonnementspræferencer. -screenshot][img4]

Dine kunder kan selv styre, hvilke mails de modtager, og du kan sikre dig, at du kun sender mails ud til de personer, der er interesserede.

Med SuperOffice CRM respekterer du dine kontakters kommunikationspræferencer og kan sikre, at du arbejder inden for reglerne i GDPR. På den måde risikerer du aldrig at få en bøde på 20.000.000 euro.

## Relateret

* [GDPR og beskyttelse af personoplysninger][2]
* [Sende e-mail om beskyttelse af personoplysninger][3]
* [Erklæring om beskyttelse af personoplysninger for SuperOffice][4]

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
