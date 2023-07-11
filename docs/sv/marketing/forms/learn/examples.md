---
uid: help-sv-forms-examples
title: Så här skapar du formulär (exempel)
description: Så här skapar du formulär (exempel)
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Formulär
so.topic: concept
language: sv
---

# Så här skapar du formulär (exempel)

Låt oss titta på två anpassade formulär som kan vara relevanta för ditt företag:

* [Nyhetsbrevsprenumeration](#newsletter-sign-up): Låt kunderna registrera sig för ett eller flera av era nyhetsbrev.
* [Kontakta mig](#contact-me): Använd ett "Kontakta mig"-formulär för att öppna upp ytterligare en kommunikationskanal med kunder eller prospekt. Använd det här formuläret om du vill generera supportärenden eller leads för säljteamet.

Exemplen behandlar inte alla fält och alternativ, men du kan hitta omfattande instruktioner under [Skapa ett nytt formulär][1].

## Vad är dubbel anmälan?

Med dubbel anmälan måste kunden förutom att skicka in formuläret verifiera sin e-postadress genom att klicka på länken i ett bekräftelsemeddelande.

Alternativet lägger till ett extra säkerhetslager i formuläret. Om du aktiverar alternativet måste personen som lämnar in formuläret även bekräfta sin e-postadress. Detta görs genom att ett e-postmeddelande skickas till personen när formuläret skickas iväg. E-postmeddelandet innehåller en länk som personen måste klicka på för att bekräfta att e-postadressen är rätt.
Länken är giltig i 30 minuter som standard.

## <a id="newsletter-sign-up" />Nyhetsbrevsprenumeration

Låt kunderna registrera sig för ett eller flera av era nyhetsbrev med detta formulär. Registreringsprocessen inkluderar också dubbel anmälan för att eliminera felaktiga eller falska abonnemang.

1. Öppna SuperOffice CRM och skapa ett statiskt urval av företag/kontakter som kallas "Nyhetsbrevprenumeranter (formulär)". Vi kommer att använda det här urvalet senare i den här guiden.

1. Öppna SuperOffice Marknadsföring och gå till fliken **Formulär**.

1. Välj **Formulär** under **Skapa nytt** till höger på skärmen. Skärmen **Redigera formulär** visas.

1. Ange "Nyhetsbrevprenumeration" i fältet **Formulärnamn**.

1. Fyll i alternativen/fälten i kategorin **Egenskaper** efter behov. Aktivera INTE några alternativ under **Avaktivera formuläret automatiskt.**

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

1. I kategorin **Fält** klickar du på ![ikonen][img1] och lägger till följande fält:

    * För- och efternamn (ta bort **Kontaktnamn**)
    * **Kontakt – e-post** (gör det här fältet obligatoriskt)
    * Kontakt – prenumeration
        * Välj ett eller flera nyhetsbrev som ska vara tillgängliga
        * Ange fältet som **obligatoriskt**.
        * Ändra namnet på fältet till "Välj dina prenumerationer".

1. Välj fältet **OK**, ändra namnet till "Skicka" och redigera typsnitt/bakgrundsfärg och position.

1. Redigera namnen på de andra fälten efter behov. **Tips!** Ta bort "Kontakt -".

1. Klicka på ![ikon][img2] överst i fältet och dra den till önskad position i formuläret. Fälten ska ha en logisk ordning.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

1. I kategorin **Stil** redigerar du layouten, färgerna, storleken och typsnitten i formuläret. Överväg att involvera dina webbdesignkollegor.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

1. I kategorin **Dubbel anmälan** väljer du **Aktivera dubbel anmälan**.

1. Ange den text som ska visas när formuläret lämnas in på fliken **Meddelande**. Detta meddelande bör informera kunden om att de kommer att få en e-postbekräftelse. Klicka på **Visa/dölj verktygsfält** ![ikon][img3] om du vill visa formateringsalternativen för texten.

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

1. Klicka på **Visa/dölj verktygsfält** ![ikon][img3] och sedan på **Lägg in bekräftelselänk** ![ikon][img4]. Bekräftelselänken infogas i brödtexten.

1. Klicka på bekräftelselänken, välj **Redigera länk** ![ikon][img5] och ändra länktexten till ”Klicka här för att bekräfta din e-postadress”. Länken är giltig i 30 minuter som standard.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

1. I kategorin **Tack-sida** kan du antingen omdirigera kunden till en webbsida eller visa ett meddelande (till exempel "Tack för att du prenumererar"). Detta kommer att visas efter att kunden verifierat sin e-postadress.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

1. I kategorin **Sida för inaktivt formulär** anger du en URL eller ett meddelande. Detta är relevant om en kund öppnar formuläret efter att det angetts som inaktivt.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

1. I kategorin **Åtgärder** måste du ange vilka åtgärder som ska utföras när formuläret bearbetas:

    * Välj inte **Skapa ärende**. Prenumerationerna aktiveras automatiskt så att ingen åtgärd krävs av supportteamet.

    * Välj **Manuellt om avsändaren är okänd. Automatiskt om avsändaren är känd**: Om e-postadressen som skickas i formuläret matchar en e-postadress i SuperOffice behandlas formulärinlämningen automatiskt. Annars måste den bearbetas manuellt.

    * **Lägg till kontakt i urval**: Markera urvalet du skapade i steg 1. Använd detta för att hålla reda på kontakter som lagts till via det här formuläret.

    * **Lägg till intressen för kontakt**: Välj intresset **Nyhetsbrev**. Intresset läggs till i kontakter som lämnar in det här formuläret.

    * **E-postsvar**: Välj ett formulärsvar som du vill skicka till kontakter när deras formulär behandlas. Detta e-postmeddelande kan till exempel informera kunden om ditt företags integritetspolicy och kan även innehålla en länk för att hantera prenumerationer. [Hur skapar jag ett formulärsvar?][2].

1. Klicka på **Spara**. Formuläret sparas och fönstret **Redigera formulär** stängs.

1. Ställ in formuläret som **Aktivt** ![ikon][img6] i rubriken.

1. Gå till fliken **Publicera**.

1. Kopiera direktlänken och/eller JavaScript till ett nyhetsbrev, en webbplats eller ett kundcenter om du vill publicera den till dina kunder eller prospekt.

1. Öppna länken till formuläret, fyll i formuläret och kontrollera att allt fungerar som förväntat.

## <a id="contact-me" />Kontakta mig

Lägg ett "Kontakta mig"-formulär på företagets webbsidor som en enkel kommunikationskanal för befintliga eller potentiella kunder.

I det här exemplet visar vi hur du skapar korta formulär för kunder som vill komma i kontakt med en supporthandläggare. Inlämnandet av formuläret utlöser ett nytt ärende till er supportavdelning.

1. Öppna SuperOffice Marknadsföring och gå till fliken **Formulär**.

1. Välj **Formulär** under **Skapa nytt** till höger på skärmen. Skärmen **Redigera formulär** visas.

1. Ange "Kontakta mig (support)" i **fältet Formulärnamn.**

1. Fyll i alternativen/fälten i kategorin **Egenskaper** efter behov. Aktivera INTE några alternativ under **Avaktivera formuläret automatiskt.**

1. I kategorin **Fält** klickar du på ![ikonen][img1] och lägger till följande fält:

    * För- och efternamn. Ta bort fältet **Kontaktnamn**.
    * **Visningselement** &gt; **Textblock**: Skriv texten i "Hur kan vi kontakta dig?" i fetstil.
    * **Kontakt - mobil**: Ge ett exempel på ett korrekt formaterat telefonnummer för ditt land (inkludera landskoden) i **fältet platshållare** (exempel: + 47 999 88 777).
    * **Kontakt – E-post**
    * **Formulärposter** &gt; **Textområde**: Ändra namnet på fältet till "Kommentar (valfri)" och skriv "Vad kan vi hjälpa dig med?" i fältet **Platshållare**.

1. Välj fältet **OK**, ändra namnet till "Skicka" och redigera typsnitt/bakgrundsfärg och position.

1. Redigera namnen på de andra fälten efter behov. **Tips!** Ta bort "Kontakt -".

1. Klicka på ![ikon][img2] överst i fältet och dra den till önskad position i formuläret. Fälten ska ha en logisk ordning.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

1. I kategorin **Stil** redigerar du layouten, färgerna, storleken och typsnitten i formuläret. Överväg att involvera dina webbdesignkollegor.

1. Klicka på **Använd nu** för att spara formuläret och fortsätta redigera.

1. Tillval: För att aktivera dubbel anmälan bör du också ange att fältet **E-post** ska vara **obligatoriskt**.

1. I kategorin **Tacksida** kan du antingen omdirigera kunden till en webbsida eller visa ett meddelande (till exempel "Tack för att du kontaktar oss. Vi kontaktar dig inom kort. "). Detta kommer att visas efter att kunden skickar formuläret.

1. I kategorin **Sida för inaktivt formulär** anger du en URL eller ett meddelande. Detta är relevant om en kund öppnar formuläret efter att det angetts som inaktivt.

1. I kategorin **Åtgärder** måste du ange vilka åtgärder som ska utföras när formuläret bearbetas:

    * Välj **Skapa ärende** och gör följande:
        1. Ange en beskrivande titel för de ärenden som ska genereras från det här formuläret.
        2. Välj önskad kategori för ärendet, till exempel "Support" eller en underkategori som kallas "Formulärinlämningar".
        3. Ange prioritet för begäran till **Medel**.

    * Välj **Manuellt om avsändaren är okänd. Automatiskt om avsändaren är känd**: Om e-postadressen som skickas i formuläret matchar en e-postadress i SuperOffice behandlas formulärinlämningen automatiskt. Annars måste den bearbetas manuellt.

    * **E-postsvar**: Välj ett formulärsvar som du vill skicka till kontakter när deras formulär behandlas. Detta e-postmeddelande kan till exempel informera kunden om ditt företags integritetspolicy och kan även innehålla en länk för att hantera prenumerationer. [Så här skapar du ett formulärsvar][2].

1. Klicka på **Spara**. Formuläret sparas och fönstret **Redigera formulär** stängs.

1. Ställ in formuläret som **Aktivt** ![ikon][img6] i rubriken.

1. Gå till fliken **Publicera**.

1. Kopiera direktlänken och/eller JavaScript till ett nyhetsbrev, en webbplats eller ett kundcenter om du vill publicera den till dina kunder eller prospekt.

1. Öppna länken till formuläret, fyll i formuläret och kontrollera att allt fungerar som förväntat.

## Vad händer nu?

* [Formulärinlämningar][3]
* [Spåra formulärinlämningar och visa statistik][4]
* [Behandla formulärinlämningar][5]

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.yml
[3]: submissions/index.md
[4]: submissions/track.md
[5]: submissions/process.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/marketing-and-forms/add-field.png
[img2]: ../../../../media/icons/marketing-and-forms/move-field.png
[img3]: ../../../../media/icons/marketing-and-forms/toolbar-show-hide.png
[img4]: ../../../../../common/icons/new-window-icon.png
[img5]: ../../../../../common/icons/edit-black.png
[img6]: ../../../../media/icons/marketing-and-forms/form-active.png
