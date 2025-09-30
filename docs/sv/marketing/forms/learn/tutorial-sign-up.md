---
uid: help-sv-forms-sign-up
title: Guide - formulär för anmälning till nyhetsbrev
description: Denna guide kommer att förklara hur du kan skapa ett formulär för anmälning till nyhetsbrev
keywords: formulär, nyhetsbrevsprenumeration, anmälning, dubbel anmälan, nyhetsbrev, prenumeration
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

# Guide - formulär för anmälning till nyhetsbrev

Låt oss titta på ännu ett anpassat formulär som kan vara relevant för ditt företag.

## Vad vi ska göra

I den här guide kommer vi att skapa ett formulär för kunder som vill anmäla sig till ett eller flera nyhetsbrev. Anmälningsprocessen kommer också att inkludera dubbel opt-in för att eliminera felaktiga eller falska prenumerationer.

Exemplen behandlar inte alla fält och alternativ, men du kan hitta omfattande instruktioner under [Skapa ett nytt formulär][1].

## Börja här

1. I SuperOffice, [skapa ett statiskt urval][7] av företag/kontakter som kallas "Nyhetsbrevprenumeranter (formulär)". Vi kommer att använda det här urvalet senare i den här guiden.

1. Gå till **Marknadsföring** och välj fliken **Formulär**.

1. Klicka på **Formulär**-knappen under **Skapa nytt** på höger sida av skärmen.

1. I dialogrutan **Redigera formulär**, ange "Nyhetsbrevprenumeration" i fältet **Formulärnamn**.

1. Välj **Egenskaper**, beskriv formulärets syfte, och fyll i fälten efter behov. Aktivera INTE några alternativ under **Avaktivera formuläret automatiskt.**

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

## Fält

1. Välj **Fält** från vänstermenyn.

1. Välj fältet **Kontakt - Namn** och klicka på den röda X:et för att ta bort detta fält.

1. Klicka på <i class="ph ph-plus" aria-label="Add"></i>, och lägg till följande fält:

    * För- och efternamn

    * **Kontakt – e-post** (gör det här fältet obligatoriskt)

    * Kontakt – prenumeration
        * Välj ett eller flera nyhetsbrev som ska vara tillgängliga.
        * Ange fältet som **obligatoriskt**.
        * Ändra namnet på fältet till "Välj dina prenumerationer".

1. Välj fältet **OK**, ändra namnet till "Skicka" och redigera typsnitt/bakgrundsfärg och position.

1. Redigera namnen på de andra fälten efter behov. **Tips!** Ta bort "Kontakt -".

1. Klicka på <i class="ph ph-dots-six" aria-label="Sex prickar"></i> överst i fältet och dra den till önskad position i formuläret. Fälten ska ha en logisk ordning.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

![Definiera egenskaper för nytt prenumerationsformulär -screenshot][img7]

## Stil

1. Välj **Stil** från vänstermenyn för att definiera utseendet. Redigera layouten, färgerna, storleken och typsnitten i formuläret. Överväg att involvera dina webbdesignkollegor.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

![Stil för nytt prenumerationsformulär -screenshot][img8]

## Dubbel anmälan

[!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

1. Välj **Dubbel anmälan** från vänstermenyn.

1. Klikk **Aktivera dubbel anmälan**.

1. På fliken **Meddelande**, ange den text som ska visas när formuläret lämnas in . Detta meddelande bör informera kunden om att de kommer att få en e-postbekräftelse.

    <details><summary>Exempel</summary>

    Vi kommer nu att skicka ett e-postmeddelande till den adress du registrerat i vårt formulär.

    Klicka på länken i e-postmeddelandet för att bekräfta din e-postadress och aktivera prenumerationen/prenumerationerna.

    Med vänlig hälsning

    SuperShop
    </details>

1. Skapa bekräftelsemeddelandet som skickades till personen som lämnade in formuläret på fliken **E-post**.

    <details><summary>Exempel</summary>

    Hej och tack för ditt intresse för våra nyhetsbrev

    Klicka på länken nedan för att bekräfta din e-postadress och påbörja prenumerationen.

    Klicka här för att bekräfta din e-postadress

    Med vänlig hälsning

    SuperShop-teamet
    </details>

1. Klicka på **Lägg in bekräftelselänk** (<i class="ph ph-arrow-square-out" aria-hidden="true"></i>). Bekräftelselänken infogas i brödtexten.

1. Klicka på länken, välj **Redigera länk** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) och ändra länktexten till "Klicka här för att bekräfta din e-postadress". Länken är giltig i 30 minuter som standard.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

![Legg till dubbel anmälan i nytt prenumerationsformulär -screenshot][img9]

## Landningssidor

1. Välj **Tacksida**.

1. Välj **Visa detta meddelande** och skriv  "Tack för att du prenumererar". Detta kommer att visas efter att kunden verifierat sin e-postadress.

1. Välj **Sida för inaktivt formulär**.

1. Välj **Omdirigera till extern webbplats** och ange en URL. Om en kund får tillgång till formuläret efter att det har markerats som inaktivt kommer de att skickas till denna sida.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

## Åtgärder

1. Välj **Åtgärder** från vänstermenyn för att ange vilka åtgärder som ska utföras när formuläret bearbetas.

1. Välj inte **Skapa ärende**. Prenumerationerna aktiveras automatiskt så att ingen åtgärd krävs av supportteamet.

1. Välj **Manuellt om avsändaren är okänd. Automatiskt om avsändaren är känd**: Om e-postadressen som skickas i formuläret matchar en e-postadress i SuperOffice behandlas formulärinlämningen automatiskt. Annars måste den bearbetas manuellt.

1. **Lägg till kontakt i urval**: Markera urvalet du skapade i steg 1. Använd detta för att hålla reda på kontakter som lagts till via det här formuläret.

1. **Lägg till intressen för kontakt**: Välj intresset **Nyhetsbrev**. Intresset läggs till i kontakter som lämnar in det här formuläret.

1. **E-postsvar**: Välj eller [skapa ett formulärsvar][2] som du vill skicka till kontakter när deras formulär behandlas. Detta e-postmeddelande kan till exempel informera kunden om ditt företags integritetspolicy och kan även innehålla en länk för att [hantera prenumerationer][6].

![Definer formuläråtgärder -screenshot][img6]

## Spara och publicera

1. Klicka på **Spara**. Formuläret sparas och fönstret **Redigera formulär** stängs.

1. Ställ in formuläret som **Aktivt** <i class="ph ph-toggle-right" aria-label="Toggle on"></i> i rubriken.

1. Gå till fliken **Publicera**.

1. Kopiera direktlänken och/eller JavaScript till ett nyhetsbrev, en webbplats eller ett kundcenter om du vill publicera den till dina kunder eller prospekt.

1. Öppna länken till formuläret, fyll i formuläret och kontrollera att allt fungerar som förväntat.

> [!TIP]
> Du kanske också är intresserad av vår [kontakta mig formulär][7] handledning.

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.md
[6]: ../../recipients/learn/manage-email-subscriptions.md
[7]: ../../../search-options/selection/learn/create.md

<!-- Referenced images -->
[img6]: ../../../../media/loc/en/marketing/sign-up-form-actions.png
[img7]: ../../../../media/loc/en/marketing/sign-up-form-fields.png
[img8]: ../../../../media/loc/en/marketing/sign-up-form-style.png
[img9]: ../../../../media/loc/en/marketing/sign-up-form-double-opt-in.png
