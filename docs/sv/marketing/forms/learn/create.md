---
uid: help-sv-form-create
title: Skapa nytt formulär
description: Lär dig hur du kan skapa ett webbformulär i den här instruktionsguiden.
keywords: formulär, webbformulär, anmäl dig
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Skapa nytt formulär

Webbformulär gör det lättare att interagera med befintliga och potentiella kunder via din webbplats eller kundcenter. Du har tre alternativ: skapa ett formulär från grunden, skapa och använda en anpassad formulärmall eller välj en gratis mall från **Online Template Library** i SuperOffice Marketing.

## Skapa nytt (från grunden)

1. Gå till fliken **Formulär**.
2. Om det behövs, klicka på **Lägg till mapp** för att [skapa en mapp för formuläret][8].
3. Klicka på **Formulär**-knappen under **Skapa nytt** på höger sida av skärmen.
4. I dialogrutan **Redigera formulär**, ange ett beskrivande **Formulärnamn**.
5. [Fyll i fälten](#fields) enligt beskrivningen nedan. Kom ihåg att klicka på **Använd nu** regelbundet för att spara ditt arbete. Formuläret sparas inte automatiskt.
6. Klicka på **Spara** när du är klar.

![Definiera egenskaper för nytt Kontakta mig formulär -screenshot][img15]

## Skapa nytt formulär baserat på en formulärmall

1. Välj fliken **Formulärmallar**.
2. Klicka på **Alla mallar**.
3. Klicka på <i class="ph ph-list" aria-label="menyknapp"></i> bredvid den mall som du vill använda.
4. Välj **Kopiera till nytt formulär**. Mallen öppnas i dialogrutan **Redigera formulär**.
5. [Aktivera och publicera formuläret][2].

## <a id="multi-page"></a>Skapa flersidiga formulär

För att öka användarvänligheten och underlätta läsbarheten kan du överväga att dela upp ett formulär med många fält på flera sidor. Användare kan navigera genom formuläret med hjälp av **Nästa**- och **Föregående**-knappar, och en förloppsindikator kan läggas till för att visa återstående fält.

1. Skapa ett formulär enligt beskrivningen ovan.
2. Välj **Fält** från vänstermenyn (i dialogrutan).
3. Klicka på knappen **Lägg till** (<i class="ph ph-plus" aria-hidden="true"></i>).
4. I fönstret **Lägg till post** väljer du **Visa poster**.
5. Välj **Avsnitt** och klicka på **Lägg till**. Fönstret stängs och ett avsnitt läggs till i formuläret. Du kan också se avsnittet i förhandsgranskningen av formuläret.
6. Klicka på <i class="ph ph-dots-six" aria-label="Six dots"></i> längst upp i avsnittet och dra den till önskad position i formuläret. Fälten ovanför och under avsnittet visas på två olika sidor i formuläret.
7. Klicka på **Använd nu** när du är klar.
8. Upprepa steg 2-7 för att lägga till ett nytt avsnitt.

> [!TIP]
> Du kan lägga till en förloppsindikator i formuläret så att användaren kan se hur mycket det är kvar att fylla i. Gå till kategorin **Stil**, klicka på kryssrutan bredvid **Färg på förloppsindikatorn** och välj en färg.

## <a id="fields"></a>Fylla i formulärfält

[!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

### Egenskaper

* **Mapp**: Välj var du vill placera formuläret eller [skapa en ny mapp][8].

* **Beskrivning**: Beskriv formulärets syfte. Den här texten är bara synlig internt.

* **Språk**: Välj det språk som används i formuläret.

* **Hanteras av**: Valfritt. Välj en användargrupp och begränsa åtkomsten till det här formuläret. Det är bara medlemmar i den valda användargruppen som kan bearbeta inlämningar från det här formuläret och ta emot meddelanden om inlämningar.

* **Inaktivera formulär automatiskt**: Valfritt. I vissa fall ska formuläret vara aktivt enbart tills ett specifikt datum eller tills ett specifikt antal svar har tagits emot. Någon som försöker få åtkomst till ett inaktivt formulär dirigeras om till sidan för det inaktiva formuläret. Du kan kombinera dessa alternativ.

  * **Tills**: Välj ett datum. Formuläret inaktiveras detta datum.
  * **Max**: Ange antal svar. Formuläret inaktiveras när det angivna antalet svar har tagits emot.

* **Använd Google Analytics**: Välj detta alternativ om du vill spåra formuläret och koppla det till [Google Analytics][1] (om det är konfigurerat för din webbplats). I fältet under detta alternativ kan du skriva in Google Analytics-spårnings-ID:n för detta formulär.

### Lägg till fält i formuläret

I kategorin **Fält** lägger du till fälten som ska finnas med i formuläret. När du lägger till och redigerar fält uppdateras förhandsgranskningen automatiskt.

1. Välj **Fält** från vänstermenyn. Fältet **Kontakt – namn** och knappen **OK** har lagts till som standard i det nya formuläret.

2. Klicka på knappen **Lägg till** (<i class="ph ph-plus" aria-hidden="true"></i>).

3. Välj en av följande fältkategorier i fönstret **Lägg till post**:

    * **SuperOffice-poster**: Fält som är länkade till SuperOffice-data, till exempel kontaktnamn, land, e-postadress och så vidare. Beroende på typ av fält kan värden från inlämnade formulär antingen ersätta befintliga värden (t.ex. land eller titel) eller läggas till i relevant SuperOffice-fält (t.ex. mobiltelefon).

    * **Formulärposter**: Fält där text eller datum, fält för att välja värden (listor, kryssrutor och alternativknappar) och filöverföringsfält anges.

    * **Visa poster**: Avsnitt, texter och bilder. Använd avsnitt för att [skapa flersidiga formulär](#multi-page).

4. Välj ett fält i listan.

5. Klicka på **Lägg till**. Fönstret stängs och fältet läggs till i formuläret och i formulärförhandsvisningen.

6. Klicka på <i class="ph ph-dots-six" aria-label="Six dots"></i> längst upp i fältet och dra den till önskad position i formuläret.

7. Välj fältnamn och redigera det om det behövs. Det ursprungliga fältnamnet visas alltid längst upp till höger i fältet.

8. Du kan också redigera dessa inställningar (valfritt):

    * Ange en kort ledtråd om vad som ska anges i fältet i **Platshållare**.

    * Markera kryssrutan **Obligatoriskt** om fältet måste fyllas i. Formuläret kan inte skickas om obligatoriska fält inte är ifyllda.

    * Klicka på **Avancerat** (<i class="ph ph-gear" aria-hidden="true"></i>) om du vill visa fältet **Identifierare** där du kan lägga till ett ID för fältet. Detta blir ett unikt ID för fältet och ändras inte även om fältnamnet/etiketten eller språket ändras. På så sätt kan du vara säker på att länkar till fältet inte är brutna när formuläret har publicerats.

    * Klicka på kryssrutan **Full bredd** om du vill att det markerade fältet ska ha samma bredd som formuläret.

9. Redigera andra [alternativ i fältet][4] om det behövs.

10. Klicka på **Använd nu** när du är klar.

11. Upprepa steg 2–10 om du vill lägga till fler fält. Du kan också klicka på **Duplicera fält** (<i class="ph ph-copy" aria-hidden="true"></i>) om du vill skapa en kopia av ett fält.

### Stil

Välj **Stil** från vänstermenyn för att definiera utseendet och känslan av formuläret. Till exempel, antal kolumner, placering av fältnamn, kanter, bakgrund, typsnittsfärg/-storlek och formulärstorlek.

Förhandsgranskningen till höger uppdateras automatiskt när du ändrar någon inställning. Om du inte anger höjden och bredden på formuläret får formuläret automatiskt skärmstorleken (stationär dator, surfplatta eller mobil).

> [!TIP]
> Du kan lägga till en förloppsindikator i formuläret så att användaren kan se hur mycket det är kvar att fylla i. Klicka på kryssrutan bredvid **Färg på förloppsindikator** och välj en färg. Förloppsindikatorn visas längst ner i formuläret. Se även [Skapa flersidiga formulär](#multi-page).

### Aktivera dubbel anmälan

Dubbel anmälan (opt-in) är ett extra steg i processen för formulärinlämning som garanterar att personer skickar in rätt e-postadress.

**Steg:**

1. Klicka på **Aktivera dubbel anmälan**.

2. Ange den text som ska visas när formuläret lämnas in på fliken **Meddelande**.

3. Skapa bekräftelsemeddelandet som skickades till personerna som lämnade in formuläret på fliken **E-post**.

    1. **Ämne**: Ange ämnet i bekräftelsemeddelandet.

    2. **Avsändaradress**: Ange e-postadressen som ska visas i fältet **Från** i bekräftelsemeddelandet.

    3. **Bekräftelsetext**: Ange brödtexten i e-postmeddelandet.

    4. Välj **Lägg in bekräftelselänk** (<i class="ph ph-arrow-square-out" aria-hidden="true"></i>) från verktygsfältet (klicka <i class="ph ph-text-a-underline" aria-label="Show toolbar"></i> för att visa). Bekräftelselänken infogas i brödtexten. Om du vill redigera länken klickar du på den och väljer **Redigera länk** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>).

4. Klicka på **Använd nu** när du är klar.

Om dubbel anmälan är aktiverad för ett formulär får alla inlämningar för det här formuläret statusen **Väntar på bekräftelse** tills e-postadressen har bekräftats.

> [!NOTE]
> Kom ihåg att lägga till fältet **Kontakt – e-post** i kategorin **Fält**.

### Tacksida

När en person slutför och lämnar in ett formulär ska du tacka dem och tala om för dem vad som händer härnäst. Det är alltid trevligt att säga tack. Det är något människor verkligen uppskattar.

Använd "Tack"-sidan för att marknadsföra andra produkter eller evenemang och länka till relevanta delar av din webbplats. Detta förbättrar användarupplevelsen och främjar kundlojalitet.

Välj något av följande alternativ:

* **Omdirigera till extern webbplats**: Ange länken till webbsidan med mer information.
* **Visa detta meddelande**: Ange den text som ska visas.

### Sida för inaktivt formulär

Om en person öppnar ett inaktivt formulär kan du antingen dirigera om honom eller henne till en annan webbsida eller visa ett meddelande.

* **Omdirigera till extern webbplats**: Ange länken till webbsidan.
* **Visa detta meddelande**: Ange den text som ska visas.

### Åtgärder

Här kan du [definiera vad som händer när någon skickar in ett svarsformulär][3].

* Meddela inlämningar genom att skapa ärenden
* Hur ska en formulärinlämning bearbetas?
* What should happen when the form is processed?

## Relaterat innehåll

* [Publicera formulär][2]

<!-- Referenced links -->
[1]: ../../tracked-links/learn/ga-tutorial.md
[2]: publish.md
[3]: define-form-actions.md
[4]: field-options.md
[8]: ../../learn/create-folder.md

<!-- Referenced images -->
[img15]: ../../../../media/loc/en/marketing/contact-me-form-properties.png
