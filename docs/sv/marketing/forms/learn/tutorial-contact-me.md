---
uid: help-sv-forms-contact-me
title: Guide - så här skapar du ett Kontakta mig formulär
description: Denna guide kommer att förklara hur du kan skapa ett Kontakta mig formulär i SuperOffice Marketing
keywords: formulär, kontakta mig
author: Bergfrid Dias
date: 09.26.2025
version: 10.5
content_type: tutorial
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Guide - Så här skapar du ett Kontakta mig formulär

Lägg ett "Kontakta mig"-formulär på företagets webbsidor som en enkel kommunikationskanal för befintliga eller potentiella kunder. Använd det här formuläret om du vill generera supportärenden eller leads för säljteamet.

## Vad vi ska göra

I denna här handledning visar vi hur du skapar korta formulär för kunder som vill komma i kontakt med en supporthandläggare. Inlämnandet av formuläret utlöser ett nytt ärende till er supportavdelning.

Exemplen behandlar inte alla fält och alternativ, men du kan hitta omfattande instruktioner under [Skapa ett nytt formulär][1].

## Börja här

1. Öppna SuperOffice Marknadsföring och gå till fliken **Formulär**.

1. Klicka på **Formulär**-knappen under **Skapa nytt** på höger sida av skärmen.

1. I dialogrutan **Redigera formulär**, ange "Kontakta mig (support)" i **fältet Formulärnamn.**

1. Välj **Egenskaper**, beskriv formulärets syfte, och fyll i fälten efter behov. Aktivera INTE några alternativ under **Avaktivera formuläret automatiskt.**

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

![Definiera egenskaper för nytt Kontakta mig formulär -screenshot][img5]

## Fält

1. Välj **Fält** från vänstermenyn.

1. Välj fältet **Kontakt - Namn** och klicka på den röda X:et för att ta bort detta fält.

1. Klicka på <i class="ph ph-plus" aria-label="Add"></i>, och lägg till följande fält:

    * För- och efternamn.

    * **Visningselement** > **Textblock**: Skriv texten i "Hur kan vi kontakta dig?" i fetstil.

    * **Kontakt - mobil**: Ge ett exempel på ett korrekt formaterat telefonnummer för ditt land (inkludera landskoden) i **fältet platshållare** (exempel: + 47 999 88 777).

    * **Kontakt – E-post**

    * **Formulärposter** > **Textområde**: Ändra namnet på fältet till "Kommentar (valfri)" och skriv "Vad kan vi hjälpa dig med?" i fältet **Platshållare**.

    [!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

1. Välj fältet **OK**, ändra namnet till "Skicka" och redigera typsnitt/bakgrundsfärg och position.

1. Redigera namnen på de andra fälten efter behov. **Tips!** Ta bort "Kontakt -".

1. Klicka på <i class="ph ph-dots-six" aria-label="Sex prickar"></i> överst i fältet och dra den till önskad position i formuläret. Fälten ska ha en logisk ordning.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

![Lägg till fält i nytt Kontakta mig formulär -screenshot][img6]

## Stil

1. Välj **Stil** från vänstermenyn för att definiera utseendet. Redigera layouten, färgerna, storleken och typsnitten i formuläret. Överväg att involvera dina webbdesignkollegor.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

## Landningssidor

1. Välj **Tacksida**.

1. Välj **Visa detta meddelande** och skriv "Tack för att du kontaktar oss. Vi kontaktar dig inom kort.". Detta kommer att visas efter att kunden skickar formuläret.

1. Välj **Sida för inaktivt formulär**.

1. Välj **Omdirigera till extern webbplats** och ange en URL. Om en kund får tillgång till formuläret efter att det har markerats som inaktivt kommer de att skickas till denna sida.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

## Åtgärder

1. Välj **Åtgärder** från vänstermenyn för att ange vilka åtgärder som ska utföras när formuläret bearbetas.

1. Välj **Skapa ärende** och gör följande:
    1. Ange en beskrivande titel för de ärenden som ska genereras från det här formuläret.
    2. Välj önskad kategori för ärendet, till exempel "Support" eller en underkategori som kallas "Formulärinlämningar".
    3. Ange prioritet för begäran till **Medel**.

1. Välj **Manuellt om avsändaren är okänd. Automatiskt om avsändaren är känd**: Om e-postadressen som skickas i formuläret matchar en e-postadress i SuperOffice behandlas formulärinlämningen automatiskt. Annars måste den bearbetas manuellt.

1. **E-postsvar**: Välj eller [skapa ett formulärsvar][2] som du vill skicka till kontakter när deras formulär behandlas. Detta e-postmeddelande kan till exempel informera kunden om ditt företags integritetspolicy och kan även innehålla en länk för att [hantera prenumerationer][6].

![Definer formuläråtgärder -screenshot][img7]

## Spara och lansera

1. Klicka på **Spara**. Formuläret sparas och fönstret **Redigera formulär** stängs.

1. Ställ in formuläret som **Aktivt** <i class="ph ph-toggle-right" aria-label="Toggle on"></i> i rubriken.

1. Gå till fliken **Publicera**.

1. Kopiera direktlänken och/eller JavaScript till ett nyhetsbrev, en webbplats eller ett kundcenter om du vill publicera den till dina kunder eller prospekt.

1. Öppna länken till formuläret, fyll i formuläret och kontrollera att allt fungerar som förväntat.

> [!TIP]
> Du kanske också är intresserad av vår [nyhetsbrevsanmälan][7] handledning. Låt dina kunder anmäla sig till ett eller flera av dina nyhetsbrev.

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.md
[6]: ../../recipients/learn/manage-email-subscriptions.md
[7]: tutorial-sign-up.md

<!-- Referenced images -->
[img5]: ../../../../media/loc/en/marketing/contact-me-form-properties.png
[img6]: ../../../../media/loc/en/marketing/contact-me-form-fields.png
[img7]: ../../../../media/loc/en/marketing/contact-me-form-actions.png
